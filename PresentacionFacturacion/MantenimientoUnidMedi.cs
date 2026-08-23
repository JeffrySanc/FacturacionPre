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
    public partial class MantenimientoUnidMedi : Mantenimientos
    {
        public MantenimientoUnidMedi()
        {
            InitializeComponent();
        }

        public int encontrado = 0;

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
                string cmd = string.Format(
                    "select * from sftunid0 where coduni = '{0}'",
                    txtcodigo_uni.Text.Trim()
                    );

                DataSet ds = Conexion_BD.Ejecutar(cmd);

                txtdescripcion_uni.Text = ds.Tables[0].Rows[0]["desuni"].ToString().Trim();
                encontrado = 1;
            }
            catch (Exception Err)
            {
                encontrado = 0;
                MessageBox.Show("Error " + Err.Message);

            }
            txtdescripcion_uni.Focus();
            btneliminar.Enabled = (encontrado == 1 ? true : false);
            btnguardar.Enabled = true;

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {


                string cmd = (encontrado == 0 ? string.Format("insert into sftunid0 (coduni,desuni) " +
                    "values ('{0}', '{1}')", txtcodigo_uni.Text.Trim(), txtdescripcion_uni.Text.Trim())
                     : string.Format("update sftunid0 set desuni = '{0}' where coduni = '{1}'",
                     txtdescripcion_uni.Text.Trim(), txtcodigo_uni.Text.Trim()));
                DataSet ds = Conexion_BD.Ejecutar(cmd);

                string letrero = (encontrado == 0 ? "Registro guardado correctamente..." :
                    "Registro actualizado correctamenta...");

                MessageBox.Show(letrero);
            }
            catch (Exception Err)
            {
                MessageBox.Show("Ha ocurrido un error " + Err.Message);
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
            if (MessageBox.Show("Esta segur@ de eliminar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string letrero = "Registro Eliminado de forma satisfatoria...";
                string cmd = string.Format("delete from sftunid0 where coduni ='{0}'", txtcodigo_uni.Text.Trim());

                DataSet ds = Conexion_BD.Ejecutar(cmd);

                MessageBox.Show(letrero);

                BorrarCampos(this);
                txtcodigo_uni.Focus();
                btneliminar.Enabled = false;
                btnguardar.Enabled = false;

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
           

        }
    }
}