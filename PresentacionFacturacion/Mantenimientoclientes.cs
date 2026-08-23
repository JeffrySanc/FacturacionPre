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
                string cmd = string.Format("select * from sftclie0 where codclie='{0}'", txtCodigo.Text.Trim());

                DataSet Ds = Conexion_BD.Ejecutar(cmd);

                txtNombre.Text = Ds.Tables[0].Rows[0]["nomclie"].ToString().Trim();
                txtCedula.Text = Ds.Tables[0].Rows[0]["cedclie"].ToString().Trim();
                txtTelefono.Text = Ds.Tables[0].Rows[0]["telclie"].ToString().Trim();
                txtDireccion.Text = Ds.Tables[0].Rows[0]["dirclie"].ToString().Trim();
                txtCorreo.Text = Ds.Tables[0].Rows[0]["mailclie"].ToString().Trim();

                encontrado = 1;
            }
            catch (Exception Err)
            {
                encontrado = 0;
                // MessageBox.Show("Error " + Err.Message);
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
                string cmd = (encontrado == 0 ? string.Format(
                    "insert into sftclie0 (codclie,nomclie,cedclie,telclie,dirclie,mailclie) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    txtCodigo.Text.Trim(), txtNombre.Text.Trim(), txtCedula.Text.Trim(), txtTelefono.Text.Trim(), txtDireccion.Text.Trim(), txtCorreo.Text.Trim())
                    : string.Format(
                    "update sftclie0 set nomclie='{0}', cedclie='{1}', telclie='{2}', dirclie='{3}', mailclie='{4}' where codclie='{5}'",
                    txtNombre.Text.Trim(), txtCedula.Text.Trim(), txtTelefono.Text.Trim(), txtDireccion.Text.Trim(), txtCorreo.Text.Trim(), txtCodigo.Text.Trim()));

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