using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public MantenimientoCliente()
        {
            InitializeComponent();
        }
        public int encontrado = 0;

        public override void Buscar()
        {
            try
            {
                string cmd = string.Format("select * from sftclie0 where codcli='{0}'", txtCodigo.Text.Trim());

                DataSet Ds = Conexion_BD.Ejecutar(cmd);

                txtNombre.Text = Ds.Tables[0].Rows[0]["nomcli"].ToString().Trim();
                txtapellido.Text = Ds.Tables[0].Rows[0]["apecli"].ToString().Trim();
                txtsector.Text = Ds.Tables[0].Rows[0]["seccli"].ToString().Trim();
                txtDireccion.Text = Ds.Tables[0].Rows[0]["dircli"].ToString().Trim();
                txtCiudad.Text = Ds.Tables[0].Rows[0]["ciucli"].ToString().Trim();

                encontrado = 1;
            }
            catch (Exception)
            {
                encontrado = 0;
            }

            txtNombre.Focus();
            btneliminar.Enabled = (encontrado == 1 ? true : false);
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
                    btnbuscar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir consulta: " + ex.Message);
            }
        }

        public override bool Guardar()
        {
            try
            {
                string fechaguardado = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                string cmd = (encontrado == 0 ? string.Format(
                    "insert into sftclie0 (codcli,nomcli,apecli,seccli,dircli,ciucli,fechaguardado) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    txtCodigo.Text.Trim(), txtNombre.Text.Trim(), txtapellido.Text.Trim(), txtsector.Text.Trim(), txtDireccion.Text.Trim(), txtCiudad.Text.Trim(), fechaguardado)
                    : string.Format(
                    "update sftclie0 set nomcli='{0}', apecli='{1}', seccli='{2}', dircli='{3}', ciucli='{4}', fechaguardado='{6}' where codcli='{5}'",
                    txtNombre.Text.Trim(), txtapellido.Text.Trim(), txtsector.Text.Trim(), txtDireccion.Text.Trim(), txtCiudad.Text.Trim(), txtCodigo.Text.Trim(), fechaguardado));

                DataSet Ds = Conexion_BD.Ejecutar(cmd);

                string letrero = (encontrado == 0 ? "Registro Guardado Correctamente..." : "Registro Actualizado Correctamente...");

                MessageBox.Show(letrero);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error " + error.Message);
            }

            btneliminar.Enabled = false;

            btnguardar.Enabled = false;
            txtNombre.Focus();

            return true;
        }

        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {
        }

        private void lbcodigo_Click(object sender, EventArgs e)
        {
        }
        private void lbnombre_Click(object sender, EventArgs e)
        {
        }
        private void lbcedula_Click(object sender, EventArgs e)
        {
        }
        private void lbtelefono_Click(object sender, EventArgs e)
        {
        }
        private void lbdireccion_Click(object sender, EventArgs e)
        {
        }
        private void lbcorreo_Click(object sender, EventArgs e)
        {
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}