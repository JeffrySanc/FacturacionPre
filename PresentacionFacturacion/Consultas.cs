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
    public partial class Consultas : Formbase
    {
        public Consultas()
        {
            InitializeComponent();
        }
        public DataSet LlenarDGV(string tabla)
        {
            DataSet ds;
            string cmd = string.Format("select * from " + tabla);
            ds = Conexion_BD.Ejecutar(cmd);
            return ds;
        }
        private void Consultas_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
