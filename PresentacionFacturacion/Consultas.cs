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
        private static readonly System.Collections.Generic.HashSet<string> TablasPermitidas =
            new System.Collections.Generic.HashSet<string>(StringComparer.OrdinalIgnoreCase)
            { "SFTCLIE0", "SFTARTI0", "SFTUNID0", "SFTUSUA0", "SFTFACT0", "SFTDEFAC1", "SFTCONF0" };

        public DataSet LlenarDGV(string tabla)
        {
            if (!TablasPermitidas.Contains(tabla))
                throw new System.Security.SecurityException("Tabla no permitida: " + tabla);

            string cmd = "select * from [" + tabla + "]";
            return Conexion_BD.Ejecutar(cmd);
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
