
namespace PresentacionFacturacion
{
    partial class MantenimientoCliente
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.picIcono = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.grpPersonales = new System.Windows.Forms.GroupBox();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbnombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbapellido = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lbtelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbcorreo = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.grpUbicacion = new System.Windows.Forms.GroupBox();
            this.lbdireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbsector = new System.Windows.Forms.Label();
            this.txtsector = new System.Windows.Forms.TextBox();
            this.lbciudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.grpComercial = new System.Windows.Forms.GroupBox();
            this.lblimite = new System.Windows.Forms.Label();
            this.txtlimite = new System.Windows.Forms.TextBox();
            this.lbbanlance = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.lbobservacion = new System.Windows.Forms.Label();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.pnlEncabezado.SuspendLayout();
            this.grpPersonales.SuspendLayout();
            this.grpUbicacion.SuspendLayout();
            this.grpComercial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
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
            this.pnlEncabezado.Size = new System.Drawing.Size(1084, 78);
            this.pnlEncabezado.TabIndex = 22;
            //
            // picIcono
            //
            this.picIcono.BackColor = System.Drawing.Color.Transparent;
            this.picIcono.IconChar = FontAwesome.Sharp.IconChar.Users;
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
            this.lblTitulo.Size = new System.Drawing.Size(330, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Mantenimiento de Clientes";
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
            this.lblSubtitulo.Text = "Registre, consulte y actualice los clientes del sistema";
            //
            // grpPersonales
            //
            this.grpPersonales.Controls.Add(this.lbcodigo);
            this.grpPersonales.Controls.Add(this.txtCodigo);
            this.grpPersonales.Controls.Add(this.lbnombre);
            this.grpPersonales.Controls.Add(this.txtNombre);
            this.grpPersonales.Controls.Add(this.lbapellido);
            this.grpPersonales.Controls.Add(this.txtapellido);
            this.grpPersonales.Controls.Add(this.lbtelefono);
            this.grpPersonales.Controls.Add(this.txtTelefono);
            this.grpPersonales.Controls.Add(this.lbcorreo);
            this.grpPersonales.Controls.Add(this.txtcorreo);
            this.grpPersonales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpPersonales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(150)))));
            this.grpPersonales.Location = new System.Drawing.Point(16, 94);
            this.grpPersonales.Name = "grpPersonales";
            this.grpPersonales.Size = new System.Drawing.Size(452, 244);
            this.grpPersonales.TabIndex = 23;
            this.grpPersonales.TabStop = false;
            this.grpPersonales.Text = "Datos Personales";
            //
            // lbcodigo
            //
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbcodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbcodigo.Location = new System.Drawing.Point(22, 42);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(66, 23);
            this.lbcodigo.TabIndex = 0;
            this.lbcodigo.Text = "Código:";
            //
            // txtCodigo
            //
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCodigo.Location = new System.Drawing.Point(148, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(272, 29);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            //
            // lbnombre
            //
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbnombre.Location = new System.Drawing.Point(22, 82);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(73, 23);
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
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            //
            // lbapellido
            //
            this.lbapellido.AutoSize = true;
            this.lbapellido.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbapellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbapellido.Location = new System.Drawing.Point(22, 122);
            this.lbapellido.Name = "lbapellido";
            this.lbapellido.Size = new System.Drawing.Size(74, 23);
            this.lbapellido.TabIndex = 0;
            this.lbapellido.Text = "Apellido:";
            //
            // txtapellido
            //
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapellido.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtapellido.Location = new System.Drawing.Point(148, 118);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(272, 29);
            this.txtapellido.TabIndex = 2;
            this.txtapellido.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            //
            // lbtelefono
            //
            this.lbtelefono.AutoSize = true;
            this.lbtelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbtelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbtelefono.Location = new System.Drawing.Point(22, 162);
            this.lbtelefono.Name = "lbtelefono";
            this.lbtelefono.Size = new System.Drawing.Size(78, 23);
            this.lbtelefono.TabIndex = 0;
            this.lbtelefono.Text = "Teléfono:";
            //
            // txtTelefono
            //
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTelefono.Location = new System.Drawing.Point(148, 158);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(272, 29);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            //
            // lbcorreo
            //
            this.lbcorreo.AutoSize = true;
            this.lbcorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbcorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbcorreo.Location = new System.Drawing.Point(22, 202);
            this.lbcorreo.Name = "lbcorreo";
            this.lbcorreo.Size = new System.Drawing.Size(64, 23);
            this.lbcorreo.TabIndex = 0;
            this.lbcorreo.Text = "Correo:";
            //
            // txtcorreo
            //
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtcorreo.Location = new System.Drawing.Point(148, 198);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(272, 29);
            this.txtcorreo.TabIndex = 4;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            //
            // grpUbicacion
            //
            this.grpUbicacion.Controls.Add(this.lbdireccion);
            this.grpUbicacion.Controls.Add(this.txtDireccion);
            this.grpUbicacion.Controls.Add(this.lbsector);
            this.grpUbicacion.Controls.Add(this.txtsector);
            this.grpUbicacion.Controls.Add(this.lbciudad);
            this.grpUbicacion.Controls.Add(this.txtCiudad);
            this.grpUbicacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpUbicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(150)))));
            this.grpUbicacion.Location = new System.Drawing.Point(16, 350);
            this.grpUbicacion.Name = "grpUbicacion";
            this.grpUbicacion.Size = new System.Drawing.Size(452, 184);
            this.grpUbicacion.TabIndex = 24;
            this.grpUbicacion.TabStop = false;
            this.grpUbicacion.Text = "Ubicación";
            //
            // lbdireccion
            //
            this.lbdireccion.AutoSize = true;
            this.lbdireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbdireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbdireccion.Location = new System.Drawing.Point(22, 40);
            this.lbdireccion.Name = "lbdireccion";
            this.lbdireccion.Size = new System.Drawing.Size(82, 23);
            this.lbdireccion.TabIndex = 0;
            this.lbdireccion.Text = "Dirección:";
            //
            // txtDireccion
            //
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDireccion.Location = new System.Drawing.Point(148, 36);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(272, 29);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            //
            // lbsector
            //
            this.lbsector.AutoSize = true;
            this.lbsector.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbsector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbsector.Location = new System.Drawing.Point(22, 80);
            this.lbsector.Name = "lbsector";
            this.lbsector.Size = new System.Drawing.Size(62, 23);
            this.lbsector.TabIndex = 0;
            this.lbsector.Text = "Sector:";
            //
            // txtsector
            //
            this.txtsector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsector.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtsector.Location = new System.Drawing.Point(148, 76);
            this.txtsector.Name = "txtsector";
            this.txtsector.Size = new System.Drawing.Size(272, 29);
            this.txtsector.TabIndex = 6;
            this.txtsector.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            //
            // lbciudad
            //
            this.lbciudad.AutoSize = true;
            this.lbciudad.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbciudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbciudad.Location = new System.Drawing.Point(22, 120);
            this.lbciudad.Name = "lbciudad";
            this.lbciudad.Size = new System.Drawing.Size(66, 23);
            this.lbciudad.TabIndex = 0;
            this.lbciudad.Text = "Ciudad:";
            //
            // txtCiudad
            //
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCiudad.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCiudad.Location = new System.Drawing.Point(148, 116);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(272, 29);
            this.txtCiudad.TabIndex = 7;
            this.txtCiudad.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            //
            // grpComercial
            //
            this.grpComercial.Controls.Add(this.lblimite);
            this.grpComercial.Controls.Add(this.txtlimite);
            this.grpComercial.Controls.Add(this.lbbanlance);
            this.grpComercial.Controls.Add(this.txtbalance);
            this.grpComercial.Controls.Add(this.lbobservacion);
            this.grpComercial.Controls.Add(this.txtobservaciones);
            this.grpComercial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpComercial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(150)))));
            this.grpComercial.Location = new System.Drawing.Point(484, 94);
            this.grpComercial.Name = "grpComercial";
            this.grpComercial.Size = new System.Drawing.Size(452, 440);
            this.grpComercial.TabIndex = 25;
            this.grpComercial.TabStop = false;
            this.grpComercial.Text = "Datos Comerciales";
            //
            // lblimite
            //
            this.lblimite.AutoSize = true;
            this.lblimite.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblimite.Location = new System.Drawing.Point(22, 42);
            this.lblimite.Name = "lblimite";
            this.lblimite.Size = new System.Drawing.Size(133, 23);
            this.lblimite.TabIndex = 0;
            this.lblimite.Text = "Límite de crédito:";
            //
            // txtlimite
            //
            this.txtlimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlimite.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtlimite.Location = new System.Drawing.Point(168, 38);
            this.txtlimite.Name = "txtlimite";
            this.txtlimite.Size = new System.Drawing.Size(252, 29);
            this.txtlimite.TabIndex = 8;
            this.txtlimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtlimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloDecimal_KeyPress);
            //
            // lbbanlance
            //
            this.lbbanlance.AutoSize = true;
            this.lbbanlance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbbanlance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbbanlance.Location = new System.Drawing.Point(22, 82);
            this.lbbanlance.Name = "lbbanlance";
            this.lbbanlance.Size = new System.Drawing.Size(77, 23);
            this.lbbanlance.TabIndex = 0;
            this.lbbanlance.Text = "Balance:";
            //
            // txtbalance
            //
            this.txtbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbalance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtbalance.Location = new System.Drawing.Point(168, 78);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(252, 29);
            this.txtbalance.TabIndex = 9;
            this.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloDecimal_KeyPress);
            //
            // lbobservacion
            //
            this.lbobservacion.AutoSize = true;
            this.lbobservacion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbobservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbobservacion.Location = new System.Drawing.Point(22, 122);
            this.lbobservacion.Name = "lbobservacion";
            this.lbobservacion.Size = new System.Drawing.Size(114, 23);
            this.lbobservacion.TabIndex = 0;
            this.lbobservacion.Text = "Observación:";
            //
            // txtobservaciones
            //
            this.txtobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtobservaciones.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtobservaciones.Location = new System.Drawing.Point(26, 152);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(394, 264);
            this.txtobservaciones.TabIndex = 10;
            //
            // MantenimientoCliente
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.grpComercial);
            this.Controls.Add(this.grpUbicacion);
            this.Controls.Add(this.grpPersonales);
            this.Controls.Add(this.pnlEncabezado);
            // Reposiciona los botones heredados en una columna a la derecha
            this.btnbuscar.Location = new System.Drawing.Point(952, 110);
            this.btnguardar.Location = new System.Drawing.Point(952, 165);
            this.btnconsultar.Location = new System.Drawing.Point(952, 220);
            this.btneliminar.Location = new System.Drawing.Point(952, 275);
            this.btnsalir.Location = new System.Drawing.Point(952, 330);
            this.Name = "MantenimientoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.MantenimientoCliente_Load);
            this.Controls.SetChildIndex(this.btnbuscar, 0);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.btnconsultar, 0);
            this.Controls.SetChildIndex(this.btneliminar, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.grpPersonales.ResumeLayout(false);
            this.grpPersonales.PerformLayout();
            this.grpUbicacion.ResumeLayout(false);
            this.grpUbicacion.PerformLayout();
            this.grpComercial.ResumeLayout(false);
            this.grpComercial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private FontAwesome.Sharp.IconPictureBox picIcono;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grpPersonales;
        private System.Windows.Forms.GroupBox grpUbicacion;
        private System.Windows.Forms.GroupBox grpComercial;

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbapellido;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lbsector;
        private System.Windows.Forms.Label lbdireccion;
        private System.Windows.Forms.Label lbciudad;
        private System.Windows.Forms.TextBox txtsector;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lbtelefono;
        private System.Windows.Forms.Label lbcorreo;
        private System.Windows.Forms.Label lblimite;
        private System.Windows.Forms.Label lbbanlance;
        private System.Windows.Forms.Label lbobservacion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtlimite;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.TextBox txtobservaciones;
    }
}
