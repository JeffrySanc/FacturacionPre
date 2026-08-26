using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using Conexion;

namespace PresentacionFacturacion
{
    public partial class MantenimientoUnidMedi : Mantenimientos
    {
        public int encontrado = 0;

        public MantenimientoUnidMedi()
        {
            InitializeComponent();
        }

        public override void Buscar()
        {
            try
            {
                DataSet ds = Conexion_BD.Ejecutar(
                    "select * from sftunid0 where coduni = '" + txtcodigo_uni.Text.Trim() + "'");

                if (ds.Tables[0].Rows.Count == 0)
                {
                    encontrado = 0;
                    MessageBox.Show("La unidad " + txtcodigo_uni.Text.Trim() + " no existe...",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtdescripcion_uni.Text = ds.Tables[0].Rows[0]["desuni"].ToString().Trim();
                    encontrado = 1;
                }
            }
            catch (Exception error)
            {
                encontrado = 0;
                MessageBox.Show("Ha ocurrido un error al buscar: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtdescripcion_uni.Focus();
            btneliminar.Enabled = (encontrado == 1);
            btnguardar.Enabled = true;
        }

        public override void Consultar()
        {
            try
            {
                ConsultaUnidMedi conUnid = new ConsultaUnidMedi();
                conUnid.ShowDialog();
                if (conUnid.DialogResult == DialogResult.OK)
                {
                    txtcodigo_uni.Text = conUnid.dataGridView1.Rows[conUnid.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    Buscar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir consulta: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Eliminar()
        {
            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea eliminar la unidad de medida " + txtcodigo_uni.Text.Trim() + "?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (respuesta != DialogResult.Yes)
                    return;

                Conexion_BD.Ejecutar(
                    "delete from sftunid0 where coduni = '" + txtcodigo_uni.Text.Trim() + "'");

                MessageBox.Show("Registro eliminado correctamente...",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al eliminar: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Guardar()
        {
            if (txtcodigo_uni.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe indicar el código de la unidad de medida.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcodigo_uni.Focus();
                return false;
            }

            if (txtdescripcion_uni.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe indicar la descripción de la unidad de medida.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdescripcion_uni.Focus();
                return false;
            }

            try
            {
                string fechaguardado = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if (encontrado == 0)
                {
                    Conexion_BD.Ejecutar(
                        "insert into sftunid0 (coduni,desuni,fechaguardado) values ('" +
                        txtcodigo_uni.Text.Trim() + "','" + txtdescripcion_uni.Text.Trim() + "','" + fechaguardado + "')");
                }
                else
                {
                    Conexion_BD.Ejecutar(
                        "update sftunid0 set desuni = '" + txtdescripcion_uni.Text.Trim() +
                        "', fechaguardado = '" + fechaguardado + "' where coduni = '" + txtcodigo_uni.Text.Trim() + "'");
                }

                MessageBox.Show(encontrado == 0 ?
                    "Registro guardado correctamente..." :
                    "Registro actualizado correctamente...",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                encontrado = 1;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al guardar: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            btneliminar.Enabled = true;
            btnguardar.Enabled = false;
            txtdescripcion_uni.Focus();

            return true;
        }

        private void LimpiarCampos()
        {
            txtcodigo_uni.Clear();
            txtdescripcion_uni.Clear();
            encontrado = 0;
            btneliminar.Enabled = false;
            btnguardar.Enabled = false;
            txtcodigo_uni.Focus();
        }

        private void MantenimientoUnidMedi_Load(object sender, EventArgs e)
        {
        }
    }
}
