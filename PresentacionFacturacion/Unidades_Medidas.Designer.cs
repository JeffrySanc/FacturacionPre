
namespace PresentacionFacturacion
{
    partial class Unidades
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo_uni = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtdescripcion_uni = new System.Windows.Forms.TextBox();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(12, 11);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(290, 32);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Unidades de Medidas";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(72, 107);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(150, 20);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Código de unidades";
            // 
            // txtcodigo_uni
            // 
            this.txtcodigo_uni.Location = new System.Drawing.Point(76, 130);
            this.txtcodigo_uni.Multiline = true;
            this.txtcodigo_uni.Name = "txtcodigo_uni";
            this.txtcodigo_uni.Size = new System.Drawing.Size(242, 32);
            this.txtcodigo_uni.TabIndex = 2;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(72, 226);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(92, 20);
            this.lbldescripcion.TabIndex = 3;
            this.lbldescripcion.Text = "Descripción";
            // 
            // txtdescripcion_uni
            // 
            this.txtdescripcion_uni.Location = new System.Drawing.Point(76, 249);
            this.txtdescripcion_uni.Multiline = true;
            this.txtdescripcion_uni.Name = "txtdescripcion_uni";
            this.txtdescripcion_uni.Size = new System.Drawing.Size(510, 32);
            this.txtdescripcion_uni.TabIndex = 4;
            this.txtdescripcion_uni.TextChanged += new System.EventHandler(this.txtdescripcion_TextChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 28;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(76, 327);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(126, 45);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.DimGray;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnsalir.IconColor = System.Drawing.Color.White;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.IconSize = 28;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(344, 327);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(126, 45);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 28;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(208, 327);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(126, 45);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.White;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 28;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(344, 125);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(126, 45);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // Unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtdescripcion_uni);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.txtcodigo_uni);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Unidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidades de Medidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo_uni;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtdescripcion_uni;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnbuscar;
    }
}