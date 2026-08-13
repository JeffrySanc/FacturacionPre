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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal(string nombre)
        {
            InitializeComponent();

            lblusuario.Text = nombre;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void unidadesDeMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form unidades_medidas = new MantenimientoUnidMedi();
            unidades_medidas.MdiParent = this; 
            unidades_medidas.WindowState = FormWindowState.Maximized; //Ocupa todo el contenedor
            unidades_medidas.Show();
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menucolor_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form conArti = new ConsultaArticulos();
            conArti.MdiParent = this;
            conArti.WindowState = FormWindowState.Maximized; //Ocupa todo el contenedor
            conArti.Show();
        }
    }
}
