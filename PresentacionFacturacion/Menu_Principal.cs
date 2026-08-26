using System;
using System.Linq;
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


        private void AbrirFormularioHijo<T>(string textoMenu) where T : Form, new()
        {
            Form existente = this.MdiChildren
                .FirstOrDefault(f => f.GetType() == typeof(T));

            if (existente != null)
            {
                existente.Activate();

                if (existente.WindowState == FormWindowState.Minimized)
                    existente.WindowState = FormWindowState.Maximized;

                return;
            }

            Form formulario = new T();
            formulario.MdiParent = this;
            formulario.WindowState = FormWindowState.Maximized;
            formulario.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<MantenimientoCliente>("Mantenimiento de Clientes");
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<MantenimientoArticulos>("Mantenimiento de Artículos");
        }

        private void unidadesDeMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<MantenimientoUnidMedi>("Mantenimiento de Unidades de Medida");
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<MantenimientoUsuario>("Mantenimiento de Usuarios");
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<Configuracion>("Configuración del Sistema");
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<Facturacion>("Facturación");
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<ConsultaClientes>("Consulta de Clientes");
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<ConsultaArticulos>("Consulta de Artículos");
        }

        private void unidadesDeMedidasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<ConsultaUnidMedi>("Consulta de Unidades de Medida");
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<ConsultaFacturas>("Consulta de Facturas");
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form repCli = new ReportesClientes(lblusuario.Text);
            repCli.MdiParent = this;
            repCli.WindowState = FormWindowState.Maximized;
            repCli.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form repFac = new ReportesFactura(lblusuario.Text);
            repFac.MdiParent = this;
            repFac.WindowState = FormWindowState.Maximized;
            repFac.Show();
        }

        private void artículosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form repArt = new ReportesArticulos(lblusuario.Text);
            repArt.MdiParent = this;
            repArt.WindowState = FormWindowState.Maximized;
            repArt.Show();
        }

        private void ventasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form repVen = new ReportesVentasFecha(lblusuario.Text);
            repVen.MdiParent = this;
            repVen.WindowState = FormWindowState.Maximized;
            repVen.Show();
        }

        private void menusalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Deseas salir?",
                "Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        

        private void iconMenuItem1_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioHijo<Configuracion>("Configuración del Sistema");
        }

        private void Menu_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}