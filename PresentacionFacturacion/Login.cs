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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            //El curso enfoca el usuario
            this.ActiveControl = txtusuario;
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtusuario.Text.Trim();
                string clave = txtclave.Text;

                if (usuario.Length == 0 || clave.Length == 0)
                {
                    MessageBox.Show("Debe indicar usuario y contraseña.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cmd = "SELECT nomusu FROM sftusua0 " +
                             "WHERE usuario = '" + usuario + "' AND password = '" + clave + "'";

                DataSet ds = Conexion_BD.Ejecutar(cmd);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    string nombre = ds.Tables[0].Rows[0]["nomusu"].ToString().Trim();

                    Menu_Principal menu = new Menu_Principal(nombre);
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtusuario.Clear();
                    txtclave.Clear();

                    txtusuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea cancelar el inicio de sesion? ", "Cancelar",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            
                this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
