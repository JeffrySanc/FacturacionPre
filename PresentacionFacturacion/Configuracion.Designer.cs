
namespace PresentacionFacturacion
{
    partial class Configuracion
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
            this.lbempresa = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lbdireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.ltelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbfax = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
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
            this.picIcono.IconChar = FontAwesome.Sharp.IconChar.Gear;
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
            this.lblTitulo.Size = new System.Drawing.Size(320, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Configuración del Sistema";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitulo.Location = new System.Drawing.Point(84, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(310, 23);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Datos generales de la empresa";
            //
            // grpDatos
            //
            this.grpDatos.Controls.Add(this.lbempresa);
            this.grpDatos.Controls.Add(this.txtEmpresa);
            this.grpDatos.Controls.Add(this.lbdireccion);
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Controls.Add(this.ltelefono);
            this.grpDatos.Controls.Add(this.txtTelefono);
            this.grpDatos.Controls.Add(this.lbfax);
            this.grpDatos.Controls.Add(this.txtFax);
            this.grpDatos.Controls.Add(this.lbemail);
            this.grpDatos.Controls.Add(this.txtEmail);
            this.grpDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(150)))));
            this.grpDatos.Location = new System.Drawing.Point(20, 94);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(452, 310);
            this.grpDatos.TabIndex = 23;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos de la Empresa";
            //
            // lbempresa
            //
            this.lbempresa.AutoSize = true;
            this.lbempresa.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbempresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbempresa.Location = new System.Drawing.Point(22, 42);
            this.lbempresa.Name = "lbempresa";
            this.lbempresa.Size = new System.Drawing.Size(82, 23);
            this.lbempresa.TabIndex = 0;
            this.lbempresa.Text = "Empresa:";
            //
            // txtEmpresa
            //
            this.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpresa.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEmpresa.Location = new System.Drawing.Point(130, 38);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(290, 29);
            this.txtEmpresa.TabIndex = 1;
            //
            // lbdireccion
            //
            this.lbdireccion.AutoSize = true;
            this.lbdireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbdireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbdireccion.Location = new System.Drawing.Point(22, 82);
            this.lbdireccion.Name = "lbdireccion";
            this.lbdireccion.Size = new System.Drawing.Size(90, 23);
            this.lbdireccion.TabIndex = 0;
            this.lbdireccion.Text = "Dirección:";
            //
            // txtDireccion
            //
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDireccion.Location = new System.Drawing.Point(130, 78);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(290, 29);
            this.txtDireccion.TabIndex = 2;
            //
            // ltelefono
            //
            this.ltelefono.AutoSize = true;
            this.ltelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ltelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ltelefono.Location = new System.Drawing.Point(22, 122);
            this.ltelefono.Name = "ltelefono";
            this.ltelefono.Size = new System.Drawing.Size(80, 23);
            this.ltelefono.TabIndex = 0;
            this.ltelefono.Text = "Teléfono:";
            //
            // txtTelefono
            //
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTelefono.Location = new System.Drawing.Point(130, 118);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(290, 29);
            this.txtTelefono.TabIndex = 3;
            //
            // lbfax
            //
            this.lbfax.AutoSize = true;
            this.lbfax.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbfax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbfax.Location = new System.Drawing.Point(22, 162);
            this.lbfax.Name = "lbfax";
            this.lbfax.Size = new System.Drawing.Size(42, 23);
            this.lbfax.TabIndex = 0;
            this.lbfax.Text = "Fax:";
            //
            // txtFax
            //
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFax.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtFax.Location = new System.Drawing.Point(130, 158);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(290, 29);
            this.txtFax.TabIndex = 4;
            //
            // lbemail
            //
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbemail.Location = new System.Drawing.Point(22, 202);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(56, 23);
            this.lbemail.TabIndex = 0;
            this.lbemail.Text = "Email:";
            //
            // txtEmail
            //
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(130, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 29);
            this.txtEmail.TabIndex = 5;
            //
            // Configuracion
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración del Sistema";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.Controls.SetChildIndex(this.pnlEncabezado, 0);
            this.Controls.SetChildIndex(this.grpDatos, 0);
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
        private System.Windows.Forms.Label lbempresa;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lbdireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label ltelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbfax;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.TextBox txtEmail;
    }
}
