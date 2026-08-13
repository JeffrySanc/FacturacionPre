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
    public partial class Formbase : Form
    {
        public Formbase()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(243, 246, 249);
        }

        private void Formbase_Load(object sender, EventArgs e)
        {

        }
        public virtual void Buscar()
        {

        }

        public virtual void Eliminar()
        {

        }

        public virtual void Consultar()
        {

        }

        public virtual Boolean Guardar()
        {
            return false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
