using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using Conexion;
using Microsoft.Reporting.WinForms;

namespace PresentacionFacturacion
{
    public partial class ReportesFactura : Form
    {
        private readonly string usuario;

        public ReportesFactura()
            : this("Administrador")
        {
        }

        public ReportesFactura(string usuario)
        {
            InitializeComponent();
            this.usuario = string.IsNullOrWhiteSpace(usuario) ? "Administrador" : usuario.Trim();
        }

        private void ReportesFactura_Load(object sender, EventArgs e)
        {
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            CargarReporte();
            try
            {
                this.reportViewer1.PrintDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarReporte()
        {
            try
            {
                int numeroFactura;
                if (!int.TryParse(txtnofactura.Text.Trim(), out numeroFactura))
                {
                    MessageBox.Show("Debe indicar un número de factura válido.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnofactura.Focus();
                    return;
                }

                DataSet dsEncabezado = Conexion_BD.Ejecutar(
                    "select f.numfac, f.fecfac, f.codcli, c.nomcli, c.apecli, c.dircli, c.telcli, " +
                    "f.subtot, f.itbis, f.total " +
                    "from sftfact0 f left join sftclie0 c on f.codcli = c.codcli " +
                    "where f.numfac = @numfac",
                    new SqlParameter("@numfac", numeroFactura));

                if (dsEncabezado.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró la factura No. " + numeroFactura,
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataRow enc = dsEncabezado.Tables[0].Rows[0];

                DataSet dsDetalle = Conexion_BD.Ejecutar(
                    "select d.codart, a.desart, d.cantart, d.precioart, " +
                    "(d.cantart * d.precioart) as subtotallinea " +
                    "from sftdefac1 d left join sftarti0 a on d.codart = a.codart " +
                    "where d.numfac = @numfac",
                    new SqlParameter("@numfac", numeroFactura));

                LocalReport reporte = this.reportViewer1.LocalReport;
                reporte.ReportEmbeddedResource = "PresentacionFacturacion.ReportFactura.rdlc";
                reporte.DataSources.Clear();

                DataTable dtEncabezado = new DataTable("Encabezado");
                dtEncabezado.Columns.Add("NUMFAC", typeof(int));
                dtEncabezado.Columns.Add("FECFAC", typeof(DateTime));
                dtEncabezado.Columns.Add("CODCLI", typeof(string));
                dtEncabezado.Columns.Add("NOMCLI", typeof(string));
                dtEncabezado.Columns.Add("APECLI", typeof(string));
                dtEncabezado.Columns.Add("DIRCLI", typeof(string));
                dtEncabezado.Columns.Add("TELCLI", typeof(string));
                dtEncabezado.Columns.Add("SUBTOT", typeof(decimal));
                dtEncabezado.Columns.Add("ITBIS", typeof(decimal));
                dtEncabezado.Columns.Add("TOTAL", typeof(decimal));

                DataRow newRow = dtEncabezado.NewRow();
                newRow["NUMFAC"] = enc["numfac"];
                newRow["FECFAC"] = enc["fecfac"];
                newRow["CODCLI"] = enc["codcli"] ?? "";
                newRow["NOMCLI"] = enc["nomcli"] ?? "";
                newRow["APECLI"] = enc["apecli"] ?? "";
                newRow["DIRCLI"] = enc["dircli"] ?? "";
                newRow["TELCLI"] = enc["telcli"] ?? "";
                newRow["SUBTOT"] = enc["subtot"] == DBNull.Value ? 0m : Convert.ToDecimal(enc["subtot"]);
                newRow["ITBIS"] = enc["itbis"] == DBNull.Value ? 0m : Convert.ToDecimal(enc["itbis"]);
                newRow["TOTAL"] = enc["total"] == DBNull.Value ? 0m : Convert.ToDecimal(enc["total"]);
                dtEncabezado.Rows.Add(newRow);

                reporte.DataSources.Add(new ReportDataSource("Encabezado", dtEncabezado));
                reporte.DataSources.Add(new ReportDataSource("Detalle", dsDetalle.Tables[0]));
                reporte.SetParameters(new ReportParameter("Usuario", this.usuario));

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
