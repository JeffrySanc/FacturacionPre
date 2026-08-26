using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Conexion;

namespace PresentacionFacturacion
{
    public partial class Facturacion : Formbase
    {
        private const decimal TASA_ITBIS = 0.18m;

        public Facturacion()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;

            dataGridDetalle.Columns.Add("Codigo", "Código");
            dataGridDetalle.Columns.Add("Descripcion", "Descripción");
            dataGridDetalle.Columns.Add("Precio", "Precio");
            dataGridDetalle.Columns.Add("Cantidad", "Cantidad");
            dataGridDetalle.Columns.Add("Subtotal", "Subtotal");

            dataGridDetalle.ReadOnly = true;
            dataGridDetalle.AllowUserToAddRows = false;
            dataGridDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            txtnofactura.ReadOnly = true;
            CargarSiguienteFactura();
        }

        private void CargarSiguienteFactura()
        {
            try
            {
                object resultado = Conexion_BD.EjecutarEscalar(
                    "select isnull(max(numfac), 0) + 1 from sftfact0");
                txtnofactura.Text = Convert.ToInt32(resultado ?? 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el número de factura: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnofactura.Text = "1";
            }
        }

        private void Facturacion_shown(object sender, EventArgs e)
        {
            this.ActiveControl = txtnofactura;      // forzamos qué control tiene el foco
            this.AutoScrollPosition = new Point(0, 0);  // y luego forzamos el scroll arriba
        }

        private void btnbuscarclie_Click(object sender, EventArgs e)
        {
            ConsultaClientes consCli = new ConsultaClientes();
            consCli.ShowDialog();

            if (consCli.DialogResult == DialogResult.OK)
            {
                int fila = consCli.dataGridView1.CurrentRow.Index;

                txtclientefact.Text = consCli.dataGridView1.Rows[fila].Cells[0].Value.ToString();   // codclie
                txtnombrefact.Text = consCli.dataGridView1.Rows[fila].Cells[1].Value.ToString();    // nomclie

                txtnombrefact.Focus();
            }
        }

        private void btnbuscarArt_Click(object sender, EventArgs e)
        {
            ConsultArticulosFactura consArt = new ConsultArticulosFactura();
            consArt.ShowDialog();

            if (consArt.DialogResult == DialogResult.OK)
            {
                int fila = consArt.dataGridView1.CurrentRow.Index;

                txtcodigoart.Text = consArt.dataGridView1.Rows[fila].Cells[0].Value.ToString();
                txtdescripcionart.Text = consArt.dataGridView1.Rows[fila].Cells[1].Value.ToString();
                txtprecioart.Text = consArt.dataGridView1.Rows[fila].Cells[2].Value.ToString();


                txtcantidadart.Focus();
            }
        }

        private void btnagregarArti_Click(object sender, EventArgs e)
        {
            // Validación básica: no dejar agregar si falta código o cantidad
            if (string.IsNullOrEmpty(txtcodigoart.Text.Trim()) || string.IsNullOrEmpty(txtcantidadart.Text.Trim()))
            {
                MessageBox.Show("Debe buscar un artículo e indicar la cantidad.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validamos que precio y cantidad realmente sean números antes de calcular
            decimal precio, cantidad;
            if (!decimal.TryParse(txtprecioart.Text.Trim(), out precio) ||
                !decimal.TryParse(txtcantidadart.Text.Trim(), out cantidad))
            {
                MessageBox.Show("Precio o cantidad inválidos.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validamos la existencia disponible del artículo
            try
            {
                object existenciaDb = Conexion_BD.EjecutarEscalar(
                    "select isnull(exiactart, 0) from sftarti0 where codart = @codigo",
                    new SqlParameter("@codigo", txtcodigoart.Text.Trim()));

                if (existenciaDb == null)
                {
                    MessageBox.Show("El artículo no existe en inventario.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal existencia = Convert.ToDecimal(existenciaDb);
                if (cantidad > existencia)
                {
                    MessageBox.Show("Solo hay " + existencia + " unidad(es) disponible(s) de este artículo.",
                        "Existencia insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al validar la existencia: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal subtotalLinea = precio * cantidad;

            // Agregamos la fila al DataGridView, en el mismo orden que definimos las columnas
            dataGridDetalle.Rows.Add(
                txtcodigoart.Text.Trim(),
                txtdescripcionart.Text.Trim(),
                precio,
                cantidad,
                subtotalLinea
            );

            // Limpiamos los campos de artículo para la siguiente línea
            txtcodigoart.Clear();
            txtdescripcionart.Clear();
            txtprecioart.Clear();
            txtcantidadart.Clear();
            txtcodigoart.Focus();

            // Recalculamos los totales de toda la factura
            CalcularTotales();
        }

        private void CalcularTotales()
        {
            decimal subtotal = 0;

            // Recorremos cada fila del detalle y sumamos su columna "Subtotal"
            foreach (DataGridViewRow fila in dataGridDetalle.Rows)
            {
                subtotal += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
            }

            decimal itbis = decimal.Round(subtotal * TASA_ITBIS, 2);
            decimal total = subtotal + itbis;

            txtsubtotal.Text = subtotal.ToString("N2");
            txtitbis.Text = itbis.ToString("N2");
            txtTotal.Text = total.ToString("N2");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtclientefact.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente para la factura.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnbuscarclie.Focus();
                return;
            }

            if (dataGridDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un artículo a la factura.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Totales recalculados desde el detalle (no se confía en los cuadros de texto)
            decimal subtotal = 0;
            foreach (DataGridViewRow fila in dataGridDetalle.Rows)
                subtotal += Convert.ToDecimal(fila.Cells["Subtotal"].Value);

            decimal itbis = decimal.Round(subtotal * TASA_ITBIS, 2);
            decimal total = subtotal + itbis;

            string codcli = txtclientefact.Text.Trim();
            DateTime fecfac = dateTimePicker1.Value;
            int numeroFactura = 0;

            try
            {
                List<Func<SqlCommand, object>> operaciones = new List<Func<SqlCommand, object>>();

                // 1) Encabezado de la factura; devolvemos el número generado
                operaciones.Add(cmd =>
                {
                    cmd.CommandText =
                        "insert into sftfact0 (codcli,fecfac,subtot,itbis,total,fechaguardado) " +
                        "values (@codcli,@fecfac,@subtot,@itbis,@total,@fg); " +
                        "select cast(scope_identity() as int);";
                    cmd.Parameters.AddWithValue("@codcli", codcli);
                    cmd.Parameters.AddWithValue("@fecfac", fecfac);
                    cmd.Parameters.AddWithValue("@subtot", subtotal);
                    cmd.Parameters.AddWithValue("@itbis", itbis);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@fg", DateTime.Now);
                    numeroFactura = Convert.ToInt32(cmd.ExecuteScalar());
                    return numeroFactura;
                });

                foreach (DataGridViewRow fila in dataGridDetalle.Rows)
                {
                    string codart = fila.Cells["Codigo"].Value.ToString();
                    decimal precioLinea = Convert.ToDecimal(fila.Cells["Precio"].Value);
                    decimal cantidadLinea = Convert.ToDecimal(fila.Cells["Cantidad"].Value);

                    // 2) Detalle de la factura
                    operaciones.Add(cmd =>
                    {
                        cmd.CommandText =
                            "insert into sftdefac1 (numfac,codart,cantart,precioart) " +
                            "values (@numfac,@codart,@cant,@precio)";
                        cmd.Parameters.AddWithValue("@numfac", numeroFactura);
                        cmd.Parameters.AddWithValue("@codart", codart);
                        cmd.Parameters.AddWithValue("@cant", cantidadLinea);
                        cmd.Parameters.AddWithValue("@precio", precioLinea);
                        return cmd.ExecuteNonQuery();
                    });

                    // 3) Descuento de existencia
                    operaciones.Add(cmd =>
                    {
                        cmd.CommandText =
                            "update sftarti0 set exiactart = isnull(exiactart, 0) - @cant where codart = @codart";
                        cmd.Parameters.AddWithValue("@cant", cantidadLinea);
                        cmd.Parameters.AddWithValue("@codart", codart);
                        return cmd.ExecuteNonQuery();
                    });
                }

                Conexion_BD.EjecutarEnTransaccion(operaciones.ToArray());

                MessageBox.Show("Factura No. " + numeroFactura +
                    " registrada correctamente...",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFactura();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al guardar la factura: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFactura()
        {
            dataGridDetalle.Rows.Clear();
            txtsubtotal.Clear();
            txtitbis.Clear();
            txtTotal.Clear();
            txtclientefact.Clear();
            txtnombrefact.Clear();
            txtcodigoart.Clear();
            txtdescripcionart.Clear();
            txtprecioart.Clear();
            txtcantidadart.Clear();

            dateTimePicker1.Value = DateTime.Now;
            CargarSiguienteFactura();
            txtnofactura.Focus();
        }
    }
}
