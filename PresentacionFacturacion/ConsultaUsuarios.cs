using System;
using System.Data;
using System.Windows.Forms;

using Conexion;

namespace PresentacionFacturacion
{
    public partial class ConsultaUsuarios : Consultas
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDGV("SFTUSUA0").Tables[0];
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtconsulta.Text.Trim()) == false)
            {
                try
                {
                    string cmd = "select * from sftusua0 where nomusu like '%" + txtconsulta.Text.Trim() + "%' or usuario like '%" + txtconsulta.Text.Trim() + "%'";
                    DataSet ds = Conexion_BD.Ejecutar(cmd);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al buscar: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
