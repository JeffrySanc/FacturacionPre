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
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
                string usuario = txtusuario.Text;
                string clave = txtclave.Text;

                string cmd = "SELECT * FROM sftusua0 " +
                             "WHERE nomusu = '" + usuario + "' " +
                             "AND password = '" + clave + "'";

                DataSet ds = Conexion_BD.Ejecutar(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Usuario y contraseña correctos");
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea cancelar el inicio de sesion? ", "Cancelar",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            
                this.Close();
        }
    }
}
