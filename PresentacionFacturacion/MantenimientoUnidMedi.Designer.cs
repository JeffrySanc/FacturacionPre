
namespace PresentacionFacturacion
{
    partial class MantenimientoUnidMedi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo_uni = new System.Windows.Forms.TextBox();
            this.txtdescripcion_uni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(664, 308);
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Unidades de Medidas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Código de Unidades";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descripción";
            // 
            // txtcodigo_uni
            // 
            this.txtcodigo_uni.Location = new System.Drawing.Point(188, 137);
            this.txtcodigo_uni.Multiline = true;
            this.txtcodigo_uni.Name = "txtcodigo_uni";
            this.txtcodigo_uni.Size = new System.Drawing.Size(311, 33);
            this.txtcodigo_uni.TabIndex = 15;
            // 
            // txtdescripcion_uni
            // 
            this.txtdescripcion_uni.Location = new System.Drawing.Point(188, 257);
            this.txtdescripcion_uni.Multiline = true;
            this.txtdescripcion_uni.Name = "txtdescripcion_uni";
            this.txtdescripcion_uni.Size = new System.Drawing.Size(311, 33);
            this.txtdescripcion_uni.TabIndex = 16;
            // 
            // MantenimientoUnidMedi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.txtdescripcion_uni);
            this.Controls.Add(this.txtcodigo_uni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoUnidMedi";
            this.Text = "MantenimientoUnidMedi";
            this.Load += new System.EventHandler(this.MantenimientoUnidMedi_Load);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.btneliminar, 0);
            this.Controls.SetChildIndex(this.btnbuscar, 0);
            this.Controls.SetChildIndex(this.btnconsultar, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtcodigo_uni, 0);
            this.Controls.SetChildIndex(this.txtdescripcion_uni, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo_uni;
        private System.Windows.Forms.TextBox txtdescripcion_uni;
    }
}