using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Conexion;
using Microsoft.Reporting.WinForms;

namespace PresentacionFacturacion
{
    public partial class ReportesVentasFecha : Form
    {
        private readonly string usuario;

        public ReportesVentasFecha()
            : this("Administrador")
        {
        }

        public ReportesVentasFecha(string usuario)
        {
            InitializeComponent();
            this.usuario = string.IsNullOrWhiteSpace(usuario) ? "Administrador" : usuario.Trim();

            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpHasta.Value = DateTime.Today;
        }

        private void ReportesVentasFecha_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            try
            {
                if (dtpHasta.Value.Date < dtpDesde.Value.Date)
                {
                    MessageBox.Show("La fecha 'Hasta' no puede ser menor que la fecha 'Desde'.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpHasta.Focus();
                    return;
                }

                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

                DataSet ds = Conexion_BD.Ejecutar(
                    "select numfac, fecfac, codcli, isnull(subtot, 0) as subtot, " +
                    "isnull(itbis, 0) as itbis, isnull(total, 0) as total " +
                    "from sftfact0 where fecfac >= @desde and fecfac <= @hasta " +
                    "order by fecfac desc, numfac desc",
                    new SqlParameter("@desde", desde),
                    new SqlParameter("@hasta", hasta));

                DataTable datos = ds.Tables[0];
                datos.TableName = "sftfact0";

                LocalReport reporte = this.reportViewer1.LocalReport;
                reporte.ReportEmbeddedResource = "PresentacionFacturacion.ReportVentasFechas.rdlc";
                reporte.DataSources.Clear();
                reporte.DataSources.Add(new ReportDataSource("dsVentasFecha", datos));
                reporte.SetParameters(new ReportParameter("FechaDesde", desde.ToString("dd/MM/yyyy")));
                reporte.SetParameters(new ReportParameter("FechaHasta", hasta.Date.ToString("dd/MM/yyyy")));
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
