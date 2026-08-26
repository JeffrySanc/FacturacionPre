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
                DataSet ds = Conexion_BD.Ejecutar(
                    "select isnull(max(numfac), 0) + 1 from sftfact0");
                txtnofactura.Text = Convert.ToInt32(ds.Tables[0].Rows[0][0] ?? 1).ToString();
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
                DataSet dsExist = Conexion_BD.Ejecutar(
                    "select isnull(exiactart, 0) from sftarti0 where codart = '" + txtcodigoart.Text.Trim() + "'");

                if (dsExist.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("El artículo no existe en inventario.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal existencia = Convert.ToDecimal(dsExist.Tables[0].Rows[0][0]);
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
                string fechaGuardado = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string fechaFactura = fecfac.ToString("yyyy-MM-dd HH:mm:ss");

                // Calcular el próximo número de factura
                object resultado = Conexion_BD.Ejecutar("select isnull(max(numfac), 0) from sftfact0").Tables[0].Rows[0][0];
                numeroFactura = Convert.ToInt32(resultado ?? 0) + 1;

                // 1) Insertar encabezado de la factura (incluyendo numfac)
                string insertEncabezado =
                    "insert into sftfact0 (numfac,codcli,fecfac,subtot,itbis,total,fechaguardado) " +
                    "values (" + numeroFactura + ",'" + codcli + "','" + fechaFactura + "'," + subtotal + "," +
                    itbis + "," + total + ",'" + fechaGuardado + "')";
                Conexion_BD.Ejecutar(insertEncabezado);

                // 2) Insertar detalle y descontar existencia
                foreach (DataGridViewRow fila in dataGridDetalle.Rows)
                {
                    string codart = fila.Cells["Codigo"].Value.ToString();
                    decimal precioLinea = Convert.ToDecimal(fila.Cells["Precio"].Value);
                    decimal cantidadLinea = Convert.ToDecimal(fila.Cells["Cantidad"].Value);

                    string insertDetalle =
                        "insert into sftdefac1 (numfac,codart,cantart,precioart) " +
                        "values (" + numeroFactura + ",'" + codart + "'," + cantidadLinea + "," + precioLinea + ")";
                    Conexion_BD.Ejecutar(insertDetalle);

                    string descontarExistencia =
                        "update sftarti0 set exiactart = isnull(exiactart, 0) - " + cantidadLinea +
                        " where codart = '" + codart + "'";
                    Conexion_BD.Ejecutar(descontarExistencia);
                }

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
