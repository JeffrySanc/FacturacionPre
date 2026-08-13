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
    public partial class ConsultaArticulos : Consultas
    {
        public ConsultaArticulos()
        {
            InitializeComponent();
        }

        private void ConsultaArticulos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDGV("SFTARTI0").Tables[0];
            this.reportViewer1.RefreshReport();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtconsulta.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * from sftarti0 where desart like " + "('%" + txtconsulta.Text.Trim() + "%')";
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
