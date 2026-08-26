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
using Microsoft.Reporting.WinForms;

namespace PresentacionFacturacion
{
    public partial class ReportesArticulos : Form
    {
        private readonly string usuario;

        public ReportesArticulos()
            : this("Administrador")
        {
        }

        public ReportesArticulos(string usuario)
        {
            InitializeComponent();
            this.usuario = string.IsNullOrWhiteSpace(usuario) ? "Administrador" : usuario.Trim();
        }

        private void ReportesArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = Conexion_BD.Ejecutar(
                    "select codart, desart, preart, isnull(exiactart, 0) as exiactart " +
                    "from sftarti0 order by codart");

                DataTable datos = ds.Tables[0];
                datos.TableName = "sftarti0";

                LocalReport reporte = this.reportViewer1.LocalReport;
                reporte.ReportEmbeddedResource = "PresentacionFacturacion.ReportArticulos.rdlc";
                reporte.DataSources.Clear();
                reporte.DataSources.Add(new ReportDataSource("dsArticulos", datos));
                reporte.SetParameters(new ReportParameter("Usuario", this.usuario));

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del reporte: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
