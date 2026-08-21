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
    public partial class MantenimientoArticulos : Mantenimientos
    {
        public MantenimientoArticulos()
        {
            InitializeComponent();
        }
        public int encontrado = 0;

        public override void Buscar()
        {

            try
            {
                string cmd = string.Format("select * from sftarti0 where codart='{0}'", txtcodigo.Text.Trim());

                DataSet Ds = Conexion_BD.Ejecutar(cmd);

                txtnombre.Text = Ds.Tables[0].Rows[0]["desart"].ToString().Trim();
                txtprecio.Text = Ds.Tables[0].Rows[0]["preart"].ToString().Trim();

                encontrado = 1;
            }
            catch (Exception Err)
            {
                encontrado = 0;
                // MessageBox.Show("Error " + Err.Message);
            }

            txtnombre.Focus();
            btneliminar.Enabled = (encontrado == 1 ? true : false);
        }

        public override void Consultar()
        {
            ConsultaArticulos conArti = new ConsultaArticulos();
            conArti.ShowDialog();
            if (conArti.DialogResult == DialogResult.OK)
            {
                txtcodigo.Text = conArti.dataGridView1.Rows[conArti.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                btnbuscar.Focus();
            }
        }

        public override bool Guardar()
        {

            try
            {
                string cmd = (encontrado == 0 ? string.Format("insert into sftarti0 (codart,desart,preart) values ('{0}','{1}','{2}')", 
                    txtcodigo.Text.Trim(), txtnombre.Text.Trim(), txtprecio.Text.Trim()) : string.Format
                    ("update sftarti0 set desart='{0}', preart='{1}' where codart='{2}'", txtnombre.Text.Trim(),txtprecio.Text.Trim(), 
                   txtcodigo.Text.Trim()));
               
                DataSet Ds = Conexion_BD.Ejecutar(cmd);

                string letrero = (encontrado == 0 ? "Registro Guardado Correctamente..." : "Registro Actualizado Correctamente...");

                MessageBox.Show(letrero);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error " + error.Message);
            }

            btneliminar.Enabled = false;

            btnguardar.Enabled = false;
            txtnombre.Focus();


            return true;
        }

        private void MantenimientoArticulos_Load(object sender, EventArgs e)
        {

        }
    }
}
