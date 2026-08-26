using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using Conexion;

namespace PresentacionFacturacion
{
    public partial class ConsultaUnidMedi : Consultas
    {
        public ConsultaUnidMedi()
        {
            InitializeComponent();
        }

        private void ConsultaUnidMedi_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUnidades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las unidades: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CargarUnidades()
        {
            DataSet ds = LlenarDGV("SFTUNID0");

            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtconsulta.Text.Trim();

                // Si est� vac�o, mostrar todas las unidades
                if (string.IsNullOrEmpty(texto))
                {
                    CargarUnidades();
                    return;
                }

                string sql = "SELECT * FROM SFTUNID0 WHERE coduni LIKE '%" + texto + "%' OR desuni LIKE '%" + texto + "%'";

                DataSet ds = Conexion_BD.Ejecutar(sql);

                if (ds != null && ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "No se encontraron unidades.",
                            "Consulta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ha ocurrido un error al buscar: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}