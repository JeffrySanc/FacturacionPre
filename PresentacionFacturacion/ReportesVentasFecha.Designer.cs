
namespace PresentacionFacturacion
{
    partial class ReportesVentasFecha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnver = new FontAwesome.Sharp.IconButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlFiltros.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlFiltros
            //
            this.pnlFiltros.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlFiltros.Controls.Add(this.lblDesde);
            this.pnlFiltros.Controls.Add(this.dtpDesde);
            this.pnlFiltros.Controls.Add(this.lblHasta);
            this.pnlFiltros.Controls.Add(this.dtpHasta);
            this.pnlFiltros.Controls.Add(this.btnver);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1199, 62);
            this.pnlFiltros.TabIndex = 1;
            //
            // lblDesde
            //
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(18, 20);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(64, 23);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            //
            // dtpDesde
            //
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(88, 16);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(150, 29);
            this.dtpDesde.TabIndex = 1;
            //
            // lblHasta
            //
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(262, 20);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(61, 23);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";
            //
            // dtpHasta
            //
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(328, 16);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(150, 29);
            this.dtpHasta.TabIndex = 3;
            //
            // btnver
            //
            this.btnver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnver.ForeColor = System.Drawing.Color.White;
            this.btnver.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnver.IconColor = System.Drawing.Color.White;
            this.btnver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnver.IconSize = 28;
            this.btnver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnver.Location = new System.Drawing.Point(510, 11);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(160, 40);
            this.btnver.TabIndex = 4;
            this.btnver.Text = "Ver reporte";
            this.btnver.UseVisualStyleBackColor = false;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            //
            // reportViewer1
            //
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1199, 505);
            this.reportViewer1.TabIndex = 5;
            //
            // ReportesVentasFecha
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 567);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnlFiltros);
            this.Name = "ReportesVentasFecha";
            this.Text = "Reporte de Ventas por Fecha";
            this.Load += new System.EventHandler(this.ReportesVentasFecha_Load);
            this.Shown += new System.EventHandler(this.ReportesVentasFecha_Shown);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private FontAwesome.Sharp.IconButton btnver;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
