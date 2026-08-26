
namespace PresentacionFacturacion
{
    partial class ConsultaUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.SuspendLayout();
            //
            // btnbuscar
            //
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            //
            // ConsultaUsuarios
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 518);
            this.Name = "ConsultaUsuarios";
            this.Text = "Consulta de Usuarios";
            this.Load += new System.EventHandler(this.ConsultaUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
