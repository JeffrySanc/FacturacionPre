using System;
using System.Data;
using System.Windows.Forms;

using Conexion;

namespace PresentacionFacturacion
{
    public partial class ConsultaFacturas : Consultas
    {
        public ConsultaFacturas()
        {
            InitializeComponent();
        }

        private void ConsultaFacturas_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = Conexion_BD.Ejecutar(
                    "select f.numfac, f.fecfac, f.codcli, c.nomcli, f.subtot, f.itbis, f.total " +
                    "from sftfact0 f left join sftclie0 c on f.codcli = c.codcli " +
                    "order by f.numfac desc");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando facturas: " + ex.Message);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtconsulta.Text.Trim()) == false)
            {
                try
                {
                    string patron = txtconsulta.Text.Trim();
                    string cmd =
                        "select f.numfac, f.fecfac, f.codcli, c.nomcli, f.subtot, f.itbis, f.total " +
                        "from sftfact0 f left join sftclie0 c on f.codcli = c.codcli " +
                        "where cast(f.numfac as varchar) like '%" + patron + "%' or c.nomcli like '%" + patron + "%' " +
                        "order by f.numfac desc";
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
