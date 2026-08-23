
namespace PresentacionFacturacion
{
    partial class Menu_Principal
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesDeMedidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuprocesos = new FontAwesome.Sharp.IconMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuconsultas = new FontAwesome.Sharp.IconMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesDeMedidasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menusalir = new FontAwesome.Sharp.IconMenuItem();
            this.menucolor = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMantenedor,
            this.menuprocesos,
            this.menuconsultas,
            this.menusalir});
            this.menu.Location = new System.Drawing.Point(0, 82);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1080, 81);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // menuMantenedor
            // 
            this.menuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.unidadesDeMedidasToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.menuMantenedor.IconColor = System.Drawing.Color.Black;
            this.menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantenedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMantenedor.Name = "menuMantenedor";
            this.menuMantenedor.Size = new System.Drawing.Size(125, 77);
            this.menuMantenedor.Text = "Mantenedor";
            this.menuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.articulosToolStripMenuItem.Text = "Artículos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // unidadesDeMedidasToolStripMenuItem
            // 
            this.unidadesDeMedidasToolStripMenuItem.Name = "unidadesDeMedidasToolStripMenuItem";
            this.unidadesDeMedidasToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.unidadesDeMedidasToolStripMenuItem.Text = "Unidades de Medidas";
            this.unidadesDeMedidasToolStripMenuItem.Click += new System.EventHandler(this.unidadesDeMedidasToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // menuprocesos
            // 
            this.menuprocesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionToolStripMenuItem});
            this.menuprocesos.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.menuprocesos.IconColor = System.Drawing.Color.Black;
            this.menuprocesos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuprocesos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuprocesos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuprocesos.Name = "menuprocesos";
            this.menuprocesos.Size = new System.Drawing.Size(99, 77);
            this.menuprocesos.Text = "Procesos";
            this.menuprocesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuprocesos.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // menuconsultas
            // 
            this.menuconsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.artículosToolStripMenuItem,
            this.unidadesDeMedidasToolStripMenuItem1});
            this.menuconsultas.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.menuconsultas.IconColor = System.Drawing.Color.Black;
            this.menuconsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuconsultas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuconsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuconsultas.Name = "menuconsultas";
            this.menuconsultas.Size = new System.Drawing.Size(105, 77);
            this.menuconsultas.Text = "Consultas";
            this.menuconsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(286, 34);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.artículosToolStripMenuItem.Text = "Artículos";
            this.artículosToolStripMenuItem.Click += new System.EventHandler(this.artículosToolStripMenuItem_Click);
            // 
            // unidadesDeMedidasToolStripMenuItem1
            // 
            this.unidadesDeMedidasToolStripMenuItem1.Name = "unidadesDeMedidasToolStripMenuItem1";
            this.unidadesDeMedidasToolStripMenuItem1.Size = new System.Drawing.Size(286, 34);
            this.unidadesDeMedidasToolStripMenuItem1.Text = "Unidades de Medidas";
            this.unidadesDeMedidasToolStripMenuItem1.Click += new System.EventHandler(this.unidadesDeMedidasToolStripMenuItem1_Click);
            // 
            // menusalir
            // 
            this.menusalir.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.menusalir.IconColor = System.Drawing.Color.Black;
            this.menusalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menusalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menusalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menusalir.Name = "menusalir";
            this.menusalir.Size = new System.Drawing.Size(64, 77);
            this.menusalir.Text = "Salir";
            this.menusalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menucolor
            // 
            this.menucolor.AutoSize = false;
            this.menucolor.BackColor = System.Drawing.Color.SteelBlue;
            this.menucolor.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menucolor.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menucolor.Location = new System.Drawing.Point(0, 0);
            this.menucolor.Name = "menucolor";
            this.menucolor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menucolor.Size = new System.Drawing.Size(1080, 82);
            this.menucolor.TabIndex = 2;
            this.menucolor.Text = "menuStrip2";
            this.menucolor.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menucolor_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema de Facturación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(863, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "User:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(916, 30);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(64, 20);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "Usuario";
            this.lblusuario.Click += new System.EventHandler(this.lblusuario_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 623);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menucolor);
            this.IsMdiContainer = true;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Principal";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menucolor;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadesDeMedidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuprocesos;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuconsultas;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadesDeMedidasToolStripMenuItem1;
        private FontAwesome.Sharp.IconMenuItem menusalir;
    }
}