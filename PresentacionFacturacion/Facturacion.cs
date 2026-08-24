using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionFacturacion
{
    public partial class Facturacion : Formbase
    {
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

            //this.reportViewer1.RefreshReport();
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

        private void btnagregarArti_Click(object sender, EventArgs e)
        {
                // Validación básica: no dejar agregar si falta código o cantidad
                if (string.IsNullOrEmpty(txtcodigoart.Text.Trim()) || string.IsNullOrEmpty(txtcantidadart.Text.Trim()))
                {
                    MessageBox.Show("Debe buscar un artículo e indicar la cantidad.");
                    return;
                }

                // Validamos que precio y cantidad realmente sean números antes de calcular
                decimal precio, cantidad;
                if (!decimal.TryParse(txtprecioart.Text.Trim(), out precio) ||
                    !decimal.TryParse(txtcantidadart.Text.Trim(), out cantidad))
                {
                    MessageBox.Show("Precio o cantidad inválidos.");
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

            decimal itbis = subtotal * 0.18m;   
            decimal total = subtotal + itbis;

            txtsubtotal.Text = subtotal.ToString("N2");
            txtitbis.Text = itbis.ToString("N2");
            txtTotal.Text = total.ToString("N2");
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
    }
}
