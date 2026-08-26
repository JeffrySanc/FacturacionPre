using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using Conexion;

namespace PresentacionFacturacion
{
    public partial class MantenimientoUsuario : Mantenimientos
    {
        public int encontrado = 0;

        public MantenimientoUsuario()
        {
            InitializeComponent();
        }

        public override void Buscar()
        {
            try
            {
                DataSet ds = Conexion_BD.Ejecutar(
                    "select usuario, nomusu from sftusua0 where usuario = @codigo",
                    new SqlParameter("@codigo", txtCodigo.Text.Trim()));

                if (ds.Tables[0].Rows.Count == 0)
                {
                    encontrado = 0;
                    MessageBox.Show("El usuario " + txtCodigo.Text.Trim() + " no existe...",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataRow fila = ds.Tables[0].Rows[0];
                    txtNombre.Text = fila["nomusu"].ToString().Trim();

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
                ConsultaUsuarios conUsu = new ConsultaUsuarios();
                conUsu.ShowDialog();
                if (conUsu.DialogResult == DialogResult.OK)
                {
                    txtCodigo.Text = conUsu.dataGridView1.Rows[conUsu.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
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
                    "¿Desea eliminar el usuario " + txtCodigo.Text.Trim() + "?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (respuesta != DialogResult.Yes)
                    return;

                Conexion_BD.EjecutarComando(
                    "delete from sftusua0 where usuario = @codigo",
                    new SqlParameter("@codigo", txtCodigo.Text.Trim()));

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
                MessageBox.Show("Debe indicar el código del usuario.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }

            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe indicar el nombre del usuario.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (txtClave.Text.Trim().Length == 0 && encontrado == 0)
            {
                MessageBox.Show("Debe indicar la contraseña del usuario.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return false;
            }

            if (txtClave.Text.Trim() != txtClave2.Text.Trim())
            {
                MessageBox.Show("Las contraseñas no coinciden.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave2.Focus();
                return false;
            }

            try
            {
                DateTime fechaguardado = DateTime.Now;

                if (encontrado == 0)
                {
                    string clave = Conexion.Seguridad.HashSHA256(txtClave.Text.Trim());
                    Conexion_BD.EjecutarComando(
                        "insert into sftusua0 (usuario, nomusu, password, fechaguardado) values (@usu, @nom, @pas, @fg)",
                        new SqlParameter("@usu", txtCodigo.Text.Trim()),
                        new SqlParameter("@nom", txtNombre.Text.Trim()),
                        new SqlParameter("@pas", clave),
                        new SqlParameter("@fg", fechaguardado));
                }
                else
                {
                    if (txtClave.Text.Trim().Length > 0)
                    {
                        string clave = Conexion.Seguridad.HashSHA256(txtClave.Text.Trim());
                        Conexion_BD.EjecutarComando(
                            "update sftusua0 set nomusu = @nom, password = @pas, fechaguardado = @fg where usuario = @usu",
                            new SqlParameter("@nom", txtNombre.Text.Trim()),
                            new SqlParameter("@pas", clave),
                            new SqlParameter("@fg", fechaguardado),
                            new SqlParameter("@usu", txtCodigo.Text.Trim()));
                    }
                    else
                    {
                        Conexion_BD.EjecutarComando(
                            "update sftusua0 set nomusu = @nom, fechaguardado = @fg where usuario = @usu",
                            new SqlParameter("@nom", txtNombre.Text.Trim()),
                            new SqlParameter("@fg", fechaguardado),
                            new SqlParameter("@usu", txtCodigo.Text.Trim()));
                    }
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

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtClave.Clear();
            txtClave2.Clear();
            encontrado = 0;
            btneliminar.Enabled = false;
            btnguardar.Enabled = false;
            txtCodigo.Focus();
        }

        private void MantenimientoUsuario_Load(object sender, EventArgs e)
        {
        }
    }
}
