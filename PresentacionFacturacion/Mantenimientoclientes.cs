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
    public partial class MantenimientoCliente : Mantenimientos
    {
        public int encontrado = 0;

        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        private static decimal DecimalDe(TextBox caja)
        {
            decimal valor;
            return decimal.TryParse(caja.Text.Trim(), out valor) ? valor : 0m;
        }

        public override void Buscar()
        {
            try
            {
                DataSet ds = Conexion_BD.Ejecutar(
                    "select * from sftclie0 where codcli = '" + txtCodigo.Text.Trim() + "'");

                if (ds.Tables[0].Rows.Count == 0)
                {
                    encontrado = 0;
                    MessageBox.Show("El cliente " + txtCodigo.Text.Trim() + " no existe...",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataRow fila = ds.Tables[0].Rows[0];
                    txtNombre.Text = fila["nomcli"].ToString().Trim();
                    txtapellido.Text = fila["apecli"].ToString().Trim();
                    txtTelefono.Text = fila["telcli"].ToString().Trim();
                    txtcorreo.Text = fila["numfaxcli"].ToString().Trim();
                    txtDireccion.Text = fila["dircli"].ToString().Trim();
                    txtsector.Text = fila["seccli"].ToString().Trim();
                    txtCiudad.Text = fila["ciucli"].ToString().Trim();
                    txtlimite.Text = fila["limcrecli"].ToString().Trim();
                    txtbalance.Text = fila["balcli"].ToString().Trim();
                    txtobservaciones.Text = fila["obscli"].ToString().Trim();

                    encontrado = 1;
                }
            }
            catch (Exception error)
            {
                encontrado = 0;
                MessageBox.Show("Ha ocurrido un error al buscar: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtNombre.Focus();
            btneliminar.Enabled = (encontrado == 1);
            btnguardar.Enabled = true;
        }

        public override void Consultar()
        {
            try
            {
                ConsultaClientes conCli = new ConsultaClientes();
                conCli.ShowDialog();
                if (conCli.DialogResult == DialogResult.OK)
                {
                    txtCodigo.Text = conCli.dataGridView1.Rows[conCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    Buscar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir consulta: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Eliminar()
        {
            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea eliminar el cliente " + txtCodigo.Text.Trim() + "?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (respuesta != DialogResult.Yes)
                    return;

                int existeEnFactura = 0;
                try
                {
                    DataSet dsCount = Conexion_BD.Ejecutar(
                        "select count(*) from sftfact0 where codcli = '" + txtCodigo.Text.Trim() + "'");
                    existeEnFactura = Convert.ToInt32(dsCount.Tables[0].Rows[0][0] ?? 0);
                }
                catch { }

                if (existeEnFactura > 0)
                {
                    MessageBox.Show("No se puede eliminar este cliente porque tiene facturas asociadas.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Conexion_BD.Ejecutar(
                    "delete from sftclie0 where codcli = '" + txtCodigo.Text.Trim() + "'");

                MessageBox.Show("Registro eliminado correctamente...",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al eliminar: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Guardar()
        {
            if (txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe indicar el código del cliente.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }

            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe indicar el nombre del cliente.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            try
            {
                string fechaguardado = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if (encontrado == 0)
                {
                    Conexion_BD.Ejecutar(
                        "insert into sftclie0 (codcli,nomcli,apecli,telcli,numfaxcli,dircli,seccli,ciucli,limcrecli,balcli,obscli,fechaguardado) " +
                        "values ('" + txtCodigo.Text.Trim() + "','" + txtNombre.Text.Trim() + "','" + txtapellido.Text.Trim() +
                        "','" + txtTelefono.Text.Trim() + "','" + txtcorreo.Text.Trim() + "','" + txtDireccion.Text.Trim() +
                        "','" + txtsector.Text.Trim() + "','" + txtCiudad.Text.Trim() + "'," + DecimalDe(txtlimite) + "," +
                        DecimalDe(txtbalance) + ",'" + txtobservaciones.Text.Trim() + "','" + fechaguardado + "')");
                }
                else
                {
                    Conexion_BD.Ejecutar(
                        "update sftclie0 set nomcli = '" + txtNombre.Text.Trim() + "', apecli = '" + txtapellido.Text.Trim() +
                        "', telcli = '" + txtTelefono.Text.Trim() + "', numfaxcli = '" + txtcorreo.Text.Trim() +
                        "', dircli = '" + txtDireccion.Text.Trim() + "', seccli = '" + txtsector.Text.Trim() +
                        "', ciucli = '" + txtCiudad.Text.Trim() + "', limcrecli = " + DecimalDe(txtlimite) +
                        ", balcli = " + DecimalDe(txtbalance) + ", obscli = '" + txtobservaciones.Text.Trim() +
                        "', fechaguardado = '" + fechaguardado + "' where codcli = '" + txtCodigo.Text.Trim() + "'");
                }

                MessageBox.Show(encontrado == 0 ?
                    "Registro guardado correctamente..." :
                    "Registro actualizado correctamente...",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                encontrado = 1;
                btneliminar.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al guardar: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            btnguardar.Enabled = false;
            txtNombre.Focus();

            return true;
        }

        private void SoloDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            bool valido = char.IsControl(c) || char.IsDigit(c) || (c == '.' &&
                !((TextBox)sender).Text.Contains("."));
            e.Handled = !valido;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtapellido.Clear();
            txtTelefono.Clear();
            txtcorreo.Clear();
            txtDireccion.Clear();
            txtsector.Clear();
            txtCiudad.Clear();
            txtlimite.Clear();
            txtbalance.Clear();
            txtobservaciones.Clear();
            encontrado = 0;
            btneliminar.Enabled = false;
            btnguardar.Enabled = false;
            txtCodigo.Focus();
        }

        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
