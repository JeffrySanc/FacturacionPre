
namespace PresentacionFacturacion
{
    partial class MantenimientoUsuario
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.picIcono = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbnombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbclave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lbclave2 = new System.Windows.Forms.Label();
            this.txtClave2 = new System.Windows.Forms.TextBox();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlEncabezado
            //
            this.pnlEncabezado.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlEncabezado.Controls.Add(this.picIcono);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(801, 78);
            this.pnlEncabezado.TabIndex = 22;
            //
            // picIcono
            //
            this.picIcono.BackColor = System.Drawing.Color.Transparent;
            this.picIcono.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.picIcono.IconColor = System.Drawing.Color.White;
            this.picIcono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picIcono.IconSize = 44;
            this.picIcono.Location = new System.Drawing.Point(20, 17);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(48, 48);
            this.picIcono.TabIndex = 0;
            this.picIcono.TabStop = false;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(82, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(293, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Mantenimiento de Usuarios";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitulo.Location = new System.Drawing.Point(84, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(337, 23);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Registre, consulte y actualice los usuarios del sistema";
            //
            // grpDatos
            //
            this.grpDatos.Controls.Add(this.lbcodigo);
            this.grpDatos.Controls.Add(this.txtCodigo);
            this.grpDatos.Controls.Add(this.lbnombre);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lbclave);
            this.grpDatos.Controls.Add(this.txtClave);
            this.grpDatos.Controls.Add(this.lbclave2);
            this.grpDatos.Controls.Add(this.txtClave2);
            this.grpDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(150)))));
            this.grpDatos.Location = new System.Drawing.Point(20, 94);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(452, 260);
            this.grpDatos.TabIndex = 23;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Usuario";
            //
            // lbcodigo
            //
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbcodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbcodigo.Location = new System.Drawing.Point(22, 42);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(125, 23);
            this.lbcodigo.TabIndex = 0;
            this.lbcodigo.Text = "Usuario:";
            //
            // txtCodigo
            //
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCodigo.Location = new System.Drawing.Point(148, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(272, 29);
            this.txtCodigo.TabIndex = 0;
            //
            // lbnombre
            //
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbnombre.Location = new System.Drawing.Point(22, 82);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(125, 23);
            this.lbnombre.TabIndex = 0;
            this.lbnombre.Text = "Nombre:";
            //
            // txtNombre
            //
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(148, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 29);
            this.txtNombre.TabIndex = 1;
            //
            // lbclave
            //
            this.lbclave.AutoSize = true;
            this.lbclave.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbclave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbclave.Location = new System.Drawing.Point(22, 122);
            this.lbclave.Name = "lbclave";
            this.lbclave.Size = new System.Drawing.Size(125, 23);
            this.lbclave.TabIndex = 0;
            this.lbclave.Text = "Contraseña:";
            //
            // txtClave
            //
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtClave.Location = new System.Drawing.Point(148, 118);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(272, 29);
            this.txtClave.TabIndex = 2;
            //
            // lbclave2
            //
            this.lbclave2.AutoSize = true;
            this.lbclave2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbclave2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbclave2.Location = new System.Drawing.Point(22, 162);
            this.lbclave2.Name = "lbclave2";
            this.lbclave2.Size = new System.Drawing.Size(125, 23);
            this.lbclave2.TabIndex = 0;
            this.lbclave2.Text = "Confirmar:";
            //
            // txtClave2
            //
            this.txtClave2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtClave2.Location = new System.Drawing.Point(148, 158);
            this.txtClave2.Name = "txtClave2";
            this.txtClave2.PasswordChar = '*';
            this.txtClave2.Size = new System.Drawing.Size(272, 29);
            this.txtClave2.TabIndex = 3;
            //
            // MantenimientoUsuario
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.pnlEncabezado);
            this.btnbuscar.Location = new System.Drawing.Point(500, 110);
            this.btnguardar.Location = new System.Drawing.Point(500, 165);
            this.btnconsultar.Location = new System.Drawing.Point(500, 220);
            this.btneliminar.Location = new System.Drawing.Point(500, 275);
            this.btnsalir.Location = new System.Drawing.Point(500, 330);
            this.Name = "MantenimientoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Usuarios";
            this.Load += new System.EventHandler(this.MantenimientoUsuario_Load);
            this.Controls.SetChildIndex(this.btnbuscar, 0);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.btnconsultar, 0);
            this.Controls.SetChildIndex(this.btneliminar, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private FontAwesome.Sharp.IconPictureBox picIcono;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbclave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lbclave2;
        private System.Windows.Forms.TextBox txtClave2;
    }
}
