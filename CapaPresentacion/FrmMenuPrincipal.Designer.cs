namespace CapaPresentacion
{
    partial class FrmMenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.btnCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.btnProducto = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.btnRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.btnDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.btnRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.btnDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelBienvenida = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelBienvenida.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1407, 70);
            this.panel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(1002, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(350, 70);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "usuario: Ivan Rey";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCerrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1352, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 70);
            this.panel4.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 40;
            this.btnCerrar.Location = new System.Drawing.Point(3, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1397, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 70);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 70);
            this.panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuMantenedor,
            this.menuVentas,
            this.menuCompras,
            this.menuClientes,
            this.menuproveedores,
            this.menuReportes,
            this.menuAcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 70);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1407, 63);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 40;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(100, 59);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuMantenedor
            // 
            this.menuMantenedor.AutoSize = false;
            this.menuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCategoria,
            this.btnProducto});
            this.menuMantenedor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuMantenedor.IconColor = System.Drawing.Color.Black;
            this.menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantenedor.IconSize = 40;
            this.menuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMantenedor.Name = "menuMantenedor";
            this.menuMantenedor.Size = new System.Drawing.Size(100, 59);
            this.menuMantenedor.Text = "Mantenedor";
            this.menuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnCategoria
            // 
            this.btnCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCategoria.IconColor = System.Drawing.Color.Black;
            this.btnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(143, 24);
            this.btnCategoria.Text = "Categoría";
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProducto.IconColor = System.Drawing.Color.Black;
            this.btnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(143, 24);
            this.btnProducto.Text = "Producto";
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.AutoSize = false;
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrarVenta,
            this.btnDetalleVenta});
            this.menuVentas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 40;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(100, 59);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(192, 24);
            this.btnRegistrarVenta.Text = "Registrar";
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnDetalleVenta
            // 
            this.btnDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.btnDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetalleVenta.Name = "btnDetalleVenta";
            this.btnDetalleVenta.Size = new System.Drawing.Size(192, 24);
            this.btnDetalleVenta.Text = "Ver Detalle Venta";
            this.btnDetalleVenta.Click += new System.EventHandler(this.btnDetalleVenta_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.AutoSize = false;
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrarCompra,
            this.btnDetalleCompra});
            this.menuCompras.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menuCompras.IconColor = System.Drawing.Color.Black;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 40;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(100, 59);
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(208, 24);
            this.btnRegistrarCompra.Text = "Registrar";
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // btnDetalleCompra
            // 
            this.btnDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.btnDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetalleCompra.Name = "btnDetalleCompra";
            this.btnDetalleCompra.Size = new System.Drawing.Size(208, 24);
            this.btnDetalleCompra.Text = "Ver Detalle Compra";
            this.btnDetalleCompra.Click += new System.EventHandler(this.btnDetalleCompra_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 40;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(100, 59);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuproveedores
            // 
            this.menuproveedores.AutoSize = false;
            this.menuproveedores.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuproveedores.IconColor = System.Drawing.Color.Black;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedores.IconSize = 40;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(100, 59);
            this.menuproveedores.Text = "Proveedores";
            this.menuproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.AutoSize = false;
            this.menuReportes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 40;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(100, 59);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.AutoSize = false;
            this.menuAcercaDe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.menuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAcercaDe.IconSize = 40;
            this.menuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(100, 59);
            this.menuAcercaDe.Text = "Acerca de";
            this.menuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelBienvenida);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 133);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1407, 639);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panelBienvenida
            // 
            this.panelBienvenida.Controls.Add(this.label3);
            this.panelBienvenida.Location = new System.Drawing.Point(100, 65);
            this.panelBienvenida.Name = "panelBienvenida";
            this.panelBienvenida.Size = new System.Drawing.Size(1200, 448);
            this.panelBienvenida.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1200, 448);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bienvenido al Sistema";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1407, 772);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelBienvenida.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuAcercaDe;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelBienvenida;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconMenuItem btnCategoria;
        private FontAwesome.Sharp.IconMenuItem btnProducto;
        private FontAwesome.Sharp.IconMenuItem btnRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem btnDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem btnRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem btnDetalleCompra;
    }
}