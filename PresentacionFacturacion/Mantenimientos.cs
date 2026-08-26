using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionFacturacion
{
    public partial class Mantenimientos : Formbase
    {
        public Mantenimientos()
        {
            InitializeComponent();

            btnguardar.Click += (s, e) => Guardar();
            btnbuscar.Click += (s, e) => Buscar();
            btnconsultar.Click += (s, e) => Consultar();
            btneliminar.Click += (s, e) => Eliminar();
        }

        private void Mantenimientos_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
