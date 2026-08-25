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
    public partial class MantenimientoUnidMedi : Mantenimientos
    {
        public int encontrado = 0;

        public MantenimientoUnidMedi()
        {
            InitializeComponent();
        }

        private void MantenimientoUnidMedi_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = Conexion_BD.Ejecutar(
                    "select * from sftunid0 where coduni = @codigo",
                    new SqlParameter("@codigo", txtcodigo_uni.Text.Trim()));

                if (ds.Tables[0].Rows.Count == 0)
                {
                    encontrado = 0;
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtcodigo_uni.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe indicar el código de la unidad de medida.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcodigo_uni.Focus();
                return;
            }

            if (txtdescripcion_uni.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe indicar la descripción de la unidad de medida.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdescripcion_uni.Focus();
                return;
            }

            try
            {
                DateTime fechaguardado = DateTime.Now;

                if (encontrado == 0)
                {
                    Conexion_BD.EjecutarComando(
                        "insert into sftunid0 (coduni,desuni,fechaguardado) values (@cod,@des,@fg)",
                        new SqlParameter("@cod", txtcodigo_uni.Text.Trim()),
                        new SqlParameter("@des", txtdescripcion_uni.Text.Trim()),
                        new SqlParameter("@fg", fechaguardado));
                }
                else
                {
                    Conexion_BD.EjecutarComando(
                        "update sftunid0 set desuni = @des, fechaguardado = @fg where coduni = @cod",
                        new SqlParameter("@des", txtdescripcion_uni.Text.Trim()),
                        new SqlParameter("@fg", fechaguardado),
                        new SqlParameter("@cod", txtcodigo_uni.Text.Trim()));
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
                return;
            }

            btneliminar.Enabled = false;
            BorrarCampos(this);
            btnguardar.Enabled = false;
            txtcodigo_uni.Focus();
        }

        private void BorrarCampos(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea eliminar la unidad de medida " + txtcodigo_uni.Text.Trim() + "?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (respuesta != DialogResult.Yes)
                    return;

                Conexion_BD.EjecutarComando(
                    "delete from sftunid0 where coduni = @codigo",
                    new SqlParameter("@codigo", txtcodigo_uni.Text.Trim()));

                MessageBox.Show("Registro eliminado correctamente...",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BorrarCampos(this);
                txtcodigo_uni.Focus();
                btneliminar.Enabled = false;
                btnguardar.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al eliminar: " + error.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
