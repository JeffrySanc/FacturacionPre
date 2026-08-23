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
    public partial class ConsultaClientes : Consultas
    {
        public ConsultaClientes()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = LlenarDGV("SFTCLIE0").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando clientes: " + ex.Message);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtconsulta.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * from sftclie0 where nomclie like " + "('%" + txtconsulta.Text.Trim() + "%')";
                    ds = Conexion_BD.Ejecutar(cmd);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error...");
                }
            }
        }
    }
}