
namespace PresentacionFacturacion
{
    partial class Consultas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.btnseleccionar = new FontAwesome.Sharp.IconButton();
            this.btnimprimir = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(571, 448);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre:";
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(141, 32);
            this.txtconsulta.Multiline = true;
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(380, 32);
            this.txtconsulta.TabIndex = 10;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseleccionar.ForeColor = System.Drawing.Color.White;
            this.btnseleccionar.IconChar = FontAwesome.Sharp.IconChar.HandPointer;
            this.btnseleccionar.IconColor = System.Drawing.Color.White;
            this.btnseleccionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnseleccionar.IconSize = 28;
            this.btnseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnseleccionar.Location = new System.Drawing.Point(141, 448);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(148, 45);
            this.btnseleccionar.TabIndex = 11;
            this.btnseleccionar.Text = "Seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = false;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.SeaGreen;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.ForeColor = System.Drawing.Color.White;
            this.btnimprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnimprimir.IconColor = System.Drawing.Color.White;
            this.btnimprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnimprimir.IconSize = 28;
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(357, 448);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(148, 45);
            this.btnimprimir.TabIndex = 12;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.White;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 28;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(543, 27);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(126, 45);
            this.btnbuscar.TabIndex = 13;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(778, 324);
            this.dataGridView1.TabIndex = 14;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 514);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.label1);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtconsulta, 0);
            this.Controls.SetChildIndex(this.btnseleccionar, 0);
            this.Controls.SetChildIndex(this.btnimprimir, 0);
            this.Controls.SetChildIndex(this.btnbuscar, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtconsulta;
        public FontAwesome.Sharp.IconButton btnseleccionar;
        public FontAwesome.Sharp.IconButton btnimprimir;
        public System.Windows.Forms.DataGridView dataGridView1;
        public FontAwesome.Sharp.IconButton btnbuscar;
    }
}