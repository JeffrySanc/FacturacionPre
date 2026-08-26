using System;
using System.Data;
using System.Windows.Forms;

using Conexion;

namespace PresentacionFacturacion
{
    public partial class Configuracion : Mantenimientos
    {
        private int encontrado = 0;

        public Configuracion()
        {
            InitializeComponent();
        }

        public override void Buscar()
        {
        }

        public override void Consultar()
        {
        }

        public override void Eliminar()
        {
        }

        public override bool Guardar()
        {
            if (txtEmpresa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe indicar el nombre de la empresa.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpresa.Focus();
                return false;
            }

            if (txtDireccion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe indicar la dirección.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
                return false;
            }

            try
            {
                if (encontrado == 0)
                {
                    Conexion_BD.Ejecutar(
                        "insert into sftconf0 (empresa, direccion, telefono, fax, email) values ('" +
                        txtEmpresa.Text.Trim() + "','" + txtDireccion.Text.Trim() + "','" +
                        txtTelefono.Text.Trim() + "','" + txtFax.Text.Trim() + "','" +
                        txtEmail.Text.Trim() + "')");

                    MessageBox.Show("Registro guardado correctamente...",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Conexion_BD.Ejecutar(
                        "update sftconf0 set empresa = '" + txtEmpresa.Text.Trim() +
                        "', direccion = '" + txtDireccion.Text.Trim() +
                        "', telefono = '" + txtTelefono.Text.Trim() +
                        "', fax = '" + txtFax.Text.Trim() +
                        "', email = '" + txtEmail.Text.Trim() + "'");

                    MessageBox.Show("Registro actualizado correctamente...",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                encontrado = 1;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al guardar: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            btnbuscar.Visible = false;
            btnconsultar.Visible = false;
            btneliminar.Visible = false;

            btnguardar.Location = new System.Drawing.Point(500, 110);
            btnsalir.Location = new System.Drawing.Point(500, 165);

            try
            {
                DataSet ds = Conexion_BD.Ejecutar(
                    "select empresa, direccion, telefono, fax, email from sftconf0");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow fila = ds.Tables[0].Rows[0];
                    txtEmpresa.Text = fila["empresa"].ToString().Trim();
                    txtDireccion.Text = fila["direccion"].ToString().Trim();
                    txtTelefono.Text = fila["telefono"].ToString().Trim();
                    txtFax.Text = fila["fax"].ToString().Trim();
                    txtEmail.Text = fila["email"].ToString().Trim();
                    encontrado = 1;
                }
                else
                {
                    encontrado = 0;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al cargar la configuración: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
