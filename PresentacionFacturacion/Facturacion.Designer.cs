
namespace PresentacionFacturacion
{
    partial class Facturacion
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnofactura = new System.Windows.Forms.TextBox();
            this.txtnombrefact = new System.Windows.Forms.TextBox();
            this.txtclientefact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnbuscarclie = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdescripcionart = new System.Windows.Forms.TextBox();
            this.txtcodigoart = new System.Windows.Forms.TextBox();
            this.txtprecioart = new System.Windows.Forms.TextBox();
            this.txtcantidadart = new System.Windows.Forms.TextBox();
            this.btnbuscarArt = new FontAwesome.Sharp.IconButton();
            this.btnagregarArti = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridDetalle = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtitbis = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(458, 951);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(595, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "No. Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre:";
            // 
            // txtnofactura
            // 
            this.txtnofactura.Location = new System.Drawing.Point(114, 92);
            this.txtnofactura.Multiline = true;
            this.txtnofactura.Name = "txtnofactura";
            this.txtnofactura.Size = new System.Drawing.Size(170, 29);
            this.txtnofactura.TabIndex = 13;
            // 
            // txtnombrefact
            // 
            this.txtnombrefact.Location = new System.Drawing.Point(114, 181);
            this.txtnombrefact.Multiline = true;
            this.txtnombrefact.Name = "txtnombrefact";
            this.txtnombrefact.Size = new System.Drawing.Size(320, 29);
            this.txtnombrefact.TabIndex = 14;
            // 
            // txtclientefact
            // 
            this.txtclientefact.Location = new System.Drawing.Point(114, 133);
            this.txtclientefact.Multiline = true;
            this.txtclientefact.Name = "txtclientefact";
            this.txtclientefact.Size = new System.Drawing.Size(170, 29);
            this.txtclientefact.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Facturación";
            // 
            // btnbuscarclie
            // 
            this.btnbuscarclie.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscarclie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarclie.ForeColor = System.Drawing.Color.White;
            this.btnbuscarclie.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarclie.IconColor = System.Drawing.Color.White;
            this.btnbuscarclie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarclie.IconSize = 25;
            this.btnbuscarclie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscarclie.Location = new System.Drawing.Point(290, 133);
            this.btnbuscarclie.Name = "btnbuscarclie";
            this.btnbuscarclie.Size = new System.Drawing.Size(100, 35);
            this.btnbuscarclie.TabIndex = 18;
            this.btnbuscarclie.Text = "    Buscar";
            this.btnbuscarclie.UseVisualStyleBackColor = false;
            this.btnbuscarclie.Click += new System.EventHandler(this.btnbuscarclie_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(7, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 1);
            this.panel1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Código:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cantidad:";
            // 
            // txtdescripcionart
            // 
            this.txtdescripcionart.Location = new System.Drawing.Point(114, 334);
            this.txtdescripcionart.Multiline = true;
            this.txtdescripcionart.Name = "txtdescripcionart";
            this.txtdescripcionart.Size = new System.Drawing.Size(300, 29);
            this.txtdescripcionart.TabIndex = 24;
            // 
            // txtcodigoart
            // 
            this.txtcodigoart.Location = new System.Drawing.Point(114, 283);
            this.txtcodigoart.Multiline = true;
            this.txtcodigoart.Name = "txtcodigoart";
            this.txtcodigoart.Size = new System.Drawing.Size(170, 29);
            this.txtcodigoart.TabIndex = 25;
            // 
            // txtprecioart
            // 
            this.txtprecioart.Location = new System.Drawing.Point(114, 382);
            this.txtprecioart.Multiline = true;
            this.txtprecioart.Name = "txtprecioart";
            this.txtprecioart.Size = new System.Drawing.Size(170, 29);
            this.txtprecioart.TabIndex = 26;
            // 
            // txtcantidadart
            // 
            this.txtcantidadart.Location = new System.Drawing.Point(114, 431);
            this.txtcantidadart.Multiline = true;
            this.txtcantidadart.Name = "txtcantidadart";
            this.txtcantidadart.Size = new System.Drawing.Size(170, 29);
            this.txtcantidadart.TabIndex = 27;
            // 
            // btnbuscarArt
            // 
            this.btnbuscarArt.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarArt.ForeColor = System.Drawing.Color.White;
            this.btnbuscarArt.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarArt.IconColor = System.Drawing.Color.White;
            this.btnbuscarArt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarArt.IconSize = 25;
            this.btnbuscarArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscarArt.Location = new System.Drawing.Point(290, 279);
            this.btnbuscarArt.Name = "btnbuscarArt";
            this.btnbuscarArt.Size = new System.Drawing.Size(100, 35);
            this.btnbuscarArt.TabIndex = 28;
            this.btnbuscarArt.Text = "    Buscar";
            this.btnbuscarArt.UseVisualStyleBackColor = false;
            this.btnbuscarArt.Click += new System.EventHandler(this.btnbuscarArt_Click);
            // 
            // btnagregarArti
            // 
            this.btnagregarArti.BackColor = System.Drawing.Color.ForestGreen;
            this.btnagregarArti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarArti.ForeColor = System.Drawing.Color.White;
            this.btnagregarArti.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnagregarArti.IconColor = System.Drawing.Color.White;
            this.btnagregarArti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregarArti.IconSize = 25;
            this.btnagregarArti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregarArti.Location = new System.Drawing.Point(443, 431);
            this.btnagregarArti.Name = "btnagregarArti";
            this.btnagregarArti.Size = new System.Drawing.Size(100, 35);
            this.btnagregarArti.TabIndex = 29;
            this.btnagregarArti.Text = "    Agregar";
            this.btnagregarArti.UseVisualStyleBackColor = false;
            this.btnagregarArti.Click += new System.EventHandler(this.btnagregarArti_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(7, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 30;
            // 
            // dataGridDetalle
            // 
            this.dataGridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetalle.Location = new System.Drawing.Point(35, 490);
            this.dataGridDetalle.Name = "dataGridDetalle";
            this.dataGridDetalle.RowHeadersWidth = 62;
            this.dataGridDetalle.RowTemplate.Height = 28;
            this.dataGridDetalle.Size = new System.Drawing.Size(855, 328);
            this.dataGridDetalle.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(645, 911);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "ITBIS 18%:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(662, 876);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Subtotal:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(691, 946);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Total:";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 25;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(308, 951);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(126, 45);
            this.btnguardar.TabIndex = 35;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(741, 873);
            this.txtsubtotal.Multiline = true;
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(170, 29);
            this.txtsubtotal.TabIndex = 36;
            // 
            // txtitbis
            // 
            this.txtitbis.Location = new System.Drawing.Point(741, 908);
            this.txtitbis.Multiline = true;
            this.txtitbis.Name = "txtitbis";
            this.txtitbis.Size = new System.Drawing.Size(170, 29);
            this.txtitbis.TabIndex = 37;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(745, 943);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(170, 29);
            this.txtTotal.TabIndex = 38;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 1008);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtitbis);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridDetalle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnagregarArti);
            this.Controls.Add(this.btnbuscarArt);
            this.Controls.Add(this.txtcantidadart);
            this.Controls.Add(this.txtprecioart);
            this.Controls.Add(this.txtcodigoart);
            this.Controls.Add(this.txtdescripcionart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnbuscarclie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtclientefact);
            this.Controls.Add(this.txtnombrefact);
            this.Controls.Add(this.txtnofactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.Shown += new System.EventHandler(this.Facturacion_shown);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtnofactura, 0);
            this.Controls.SetChildIndex(this.txtnombrefact, 0);
            this.Controls.SetChildIndex(this.txtclientefact, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnbuscarclie, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtdescripcionart, 0);
            this.Controls.SetChildIndex(this.txtcodigoart, 0);
            this.Controls.SetChildIndex(this.txtprecioart, 0);
            this.Controls.SetChildIndex(this.txtcantidadart, 0);
            this.Controls.SetChildIndex(this.btnbuscarArt, 0);
            this.Controls.SetChildIndex(this.btnagregarArti, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dataGridDetalle, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.txtsubtotal, 0);
            this.Controls.SetChildIndex(this.txtitbis, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnofactura;
        private System.Windows.Forms.TextBox txtnombrefact;
        private System.Windows.Forms.TextBox txtclientefact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnbuscarclie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdescripcionart;
        private System.Windows.Forms.TextBox txtcodigoart;
        private System.Windows.Forms.TextBox txtprecioart;
        private System.Windows.Forms.TextBox txtcantidadart;
        private FontAwesome.Sharp.IconButton btnbuscarArt;
        private FontAwesome.Sharp.IconButton btnagregarArti;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridDetalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtitbis;
        private System.Windows.Forms.TextBox txtTotal;
    }
}