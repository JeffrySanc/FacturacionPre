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
    public partial class ConsultArticulosFactura : Consultas
    {
        public ConsultArticulosFactura()
        {
            InitializeComponent();
        }

        private void ConsultArticulosFactura_Load(object sender, EventArgs e)
        {
            DataSet ds;
            string cmd = "select codart as 'Código', desart as 'Descripción', " +
                         "preart as 'Precio', exiactart as 'Existencia' " +
                         "from sftarti0";

            ds = Conexion_BD.Ejecutar(cmd);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtconsulta.Text.Trim()) == false)
            {
                try
                {
                    string cmd = "select codart as 'Código', desart as 'Descripción', " +
                                 "preart as 'Precio', exiactart as 'Existencia' " +
                                 "from sftarti0 where desart like @patron";

                    DataSet ds = Conexion_BD.Ejecutar(cmd,
                        new System.Data.SqlClient.SqlParameter("@patron", "%" + txtconsulta.Text.Trim() + "%"));
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
