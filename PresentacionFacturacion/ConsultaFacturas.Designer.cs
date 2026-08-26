
namespace PresentacionFacturacion
{
    partial class ConsultaFacturas
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
            // ConsultaFacturas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 518);
            this.Name = "ConsultaFacturas";
            this.Text = "Consulta de Facturas";
            this.Load += new System.EventHandler(this.ConsultaFacturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
