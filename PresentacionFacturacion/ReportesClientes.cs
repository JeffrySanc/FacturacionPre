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
    public partial class ReportesClientes : Form
    {
        private readonly string usuario;

        public ReportesClientes()
            : this("Administrador")
        {
        }

        public ReportesClientes(string usuario)
        {
            InitializeComponent();
            this.usuario = string.IsNullOrWhiteSpace(usuario) ? "Administrador" : usuario.Trim();
        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = Conexion_BD.Ejecutar("select * from sftclie0");
                this.dsClientes._sftclie0.Merge(ds.Tables[0]);

                this.reportViewer1.LocalReport.SetParameters(
                    new Microsoft.Reporting.WinForms.ReportParameter("Usuario", this.usuario));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del reporte: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
