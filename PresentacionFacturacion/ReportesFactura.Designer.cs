
namespace PresentacionFacturacion
{
    partial class ReportesFactura
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnofactura = new System.Windows.Forms.TextBox();
            this.btnver = new FontAwesome.Sharp.IconButton();
            this.btnimprimir = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // panel1
            //
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnimprimir);
            this.panel1.Controls.Add(this.btnver);
            this.panel1.Controls.Add(this.txtnofactura);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 60);
            this.panel1.TabIndex = 0;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Factura:";
            //
            // txtnofactura
            //
            this.txtnofactura.Location = new System.Drawing.Point(150, 17);
            this.txtnofactura.Name = "txtnofactura";
            this.txtnofactura.Size = new System.Drawing.Size(150, 26);
            this.txtnofactura.TabIndex = 1;
            //
            // btnver
            //
            this.btnver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnver.ForeColor = System.Drawing.Color.White;
            this.btnver.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnver.IconColor = System.Drawing.Color.White;
            this.btnver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnver.IconSize = 22;
            this.btnver.Location = new System.Drawing.Point(320, 12);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(120, 36);
            this.btnver.TabIndex = 2;
            this.btnver.Text = "Ver Factura";
            this.btnver.UseVisualStyleBackColor = false;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            //
            // btnimprimir
            //
            this.btnimprimir.BackColor = System.Drawing.Color.ForestGreen;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.ForeColor = System.Drawing.Color.White;
            this.btnimprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnimprimir.IconColor = System.Drawing.Color.White;
            this.btnimprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnimprimir.IconSize = 22;
            this.btnimprimir.Location = new System.Drawing.Point(450, 12);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(120, 36);
            this.btnimprimir.TabIndex = 3;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            //
            // reportViewer1
            //
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1100, 511);
            this.reportViewer1.TabIndex = 1;
            //
            // ReportesFactura
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 571);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "ReportesFactura";
            this.Text = "Reporte de Factura";
            this.Load += new System.EventHandler(this.ReportesFactura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnofactura;
        private FontAwesome.Sharp.IconButton btnver;
        private FontAwesome.Sharp.IconButton btnimprimir;
    }
}
