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

namespace PresentacionFacturacion
{
    public partial class MantenimientoArticulos : Mantenimientos
    {
        public int encontrado = 0;

        public MantenimientoArticulos()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        public override void Buscar()
        {
            try
            {
                DataSet ds = Conexion_BD.Ejecutar(
                    "select * from sftarti0 where codart = @codigo",
                    new SqlParameter("@codigo", txtcodigo.Text.Trim()));

                if (ds.Tables[0].Rows.Count == 0)
                {
                    encontrado = 0;
                }
                else
                {
                    DataRow fila = ds.Tables[0].Rows[0];
                    txtnombre.Text = fila["desart"].ToString().Trim();
                    txtprecio.Text = fila["preart"].ToString().Trim();

                    encontrado = 1;
                }
            }
            catch (Exception error)
            {
                encontrado = 0;
                MessageBox.Show("Ha ocurrido un error al buscar: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtnombre.Focus();
            btneliminar.Enabled = (encontrado == 1);
        }

        public override void Consultar()
        {
            try
            {
                ConsultaArticulos conArti = new ConsultaArticulos();
                conArti.ShowDialog();
                if (conArti.DialogResult == DialogResult.OK)
                {
                    txtcodigo.Text = conArti.dataGridView1.Rows[conArti.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    btnbuscar.Focus();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al abrir consulta: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Eliminar()
        {
            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea eliminar el artículo " + txtcodigo.Text.Trim() + "?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (respuesta != DialogResult.Yes)
                    return;

                Conexion_BD.EjecutarComando(
                    "delete from sftarti0 where codart = @codigo",
                    new SqlParameter("@codigo", txtcodigo.Text.Trim()));

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
            if (txtcodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe indicar el código del artículo.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcodigo.Focus();
                return false;
            }

            if (txtnombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe indicar la descripción del artículo.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombre.Focus();
                return false;
            }

            decimal precio;
            if (!decimal.TryParse(txtprecio.Text.Trim(), out precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un valor numérico válido.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtprecio.Focus();
                return false;
            }

            try
            {
                DateTime fechaguardado = DateTime.Now;

                if (encontrado == 0)
                {
                    Conexion_BD.EjecutarComando(
                        "insert into sftarti0 (codart,desart,preart,fechaguardado) values (@cod,@des,@pre,@fg)",
                        new SqlParameter("@cod", txtcodigo.Text.Trim()),
                        new SqlParameter("@des", txtnombre.Text.Trim()),
                        new SqlParameter("@pre", precio),
                        new SqlParameter("@fg", fechaguardado));
                }
                else
                {
                    Conexion_BD.EjecutarComando(
                        "update sftarti0 set desart = @des, preart = @pre, fechaguardado = @fg where codart = @cod",
                        new SqlParameter("@des", txtnombre.Text.Trim()),
                        new SqlParameter("@pre", precio),
                        new SqlParameter("@fg", fechaguardado),
                        new SqlParameter("@cod", txtcodigo.Text.Trim()));
                }

                MessageBox.Show(encontrado == 0 ?
                    "Registro guardado correctamente..." :
                    "Registro actualizado correctamente...",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al guardar: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            btneliminar.Enabled = false;
            btnguardar.Enabled = false;
            txtnombre.Focus();

            return true;
        }

        private void LimpiarCampos()
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtprecio.Clear();
            encontrado = 0;
            btneliminar.Enabled = false;
            btnguardar.Enabled = false;
            txtcodigo.Focus();
        }

        private void MantenimientoArticulos_Load(object sender, EventArgs e)
        {

        }
    }
}
