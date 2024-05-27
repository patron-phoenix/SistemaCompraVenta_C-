namespace CapaPresentacion
{
    partial class FrmCompras
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRegistrarDetalle = new FontAwesome.Sharp.IconButton();
            this.btnAgregarDetalle = new FontAwesome.Sharp.IconButton();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnProducto = new FontAwesome.Sharp.IconButton();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkSeleccionar);
            this.panel1.Controls.Add(this.txtTotalPagar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnRegistrarDetalle);
            this.panel1.Controls.Add(this.btnAgregarDetalle);
            this.panel1.Controls.Add(this.DgvListado);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 773);
            this.panel1.TabIndex = 0;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoSize = true;
            this.chkSeleccionar.Location = new System.Drawing.Point(50, 726);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Size = new System.Drawing.Size(105, 22);
            this.chkSeleccionar.TabIndex = 23;
            this.chkSeleccionar.Text = "Seleccionar";
            this.chkSeleccionar.UseVisualStyleBackColor = true;
            this.chkSeleccionar.CheckedChanged += new System.EventHandler(this.chkSeleccionar_CheckedChanged);
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BackColor = System.Drawing.Color.White;
            this.txtTotalPagar.Location = new System.Drawing.Point(1055, 578);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(184, 24);
            this.txtTotalPagar.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1052, 547);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Total a Pagar:";
            // 
            // btnRegistrarDetalle
            // 
            this.btnRegistrarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrarDetalle.FlatAppearance.BorderSize = 0;
            this.btnRegistrarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarDetalle.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnRegistrarDetalle.IconColor = System.Drawing.Color.White;
            this.btnRegistrarDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarDetalle.IconSize = 20;
            this.btnRegistrarDetalle.Location = new System.Drawing.Point(1055, 647);
            this.btnRegistrarDetalle.Name = "btnRegistrarDetalle";
            this.btnRegistrarDetalle.Size = new System.Drawing.Size(184, 48);
            this.btnRegistrarDetalle.TabIndex = 20;
            this.btnRegistrarDetalle.Text = "Registrar";
            this.btnRegistrarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarDetalle.UseVisualStyleBackColor = false;
            this.btnRegistrarDetalle.Click += new System.EventHandler(this.btnRegistrarDetalle_Click);
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.White;
            this.btnAgregarDetalle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAgregarDetalle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarDetalle.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarDetalle.IconSize = 50;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(1173, 349);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(66, 48);
            this.btnAgregarDetalle.TabIndex = 19;
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.BackgroundColor = System.Drawing.Color.White;
            this.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListado.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListado.EnableHeadersVisualStyles = false;
            this.DgvListado.Location = new System.Drawing.Point(50, 310);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(967, 385);
            this.DgvListado.TabIndex = 18;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.numCantidad);
            this.groupBox3.Controls.Add(this.txtPrecioVenta);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPrecioCompra);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnProducto);
            this.groupBox3.Controls.Add(this.txtNombreProducto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtIdProducto);
            this.groupBox3.Controls.Add(this.txtCodigoProducto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(50, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1189, 109);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1038, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(1041, 51);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 24);
            this.numCantidad.TabIndex = 13;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(822, 50);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(179, 24);
            this.txtPrecioVenta.TabIndex = 12;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(819, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Precio Venta:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(604, 51);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(179, 24);
            this.txtPrecioCompra.TabIndex = 10;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Precio Compra:";
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.White;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnProducto.IconColor = System.Drawing.Color.Black;
            this.btnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducto.IconSize = 20;
            this.btnProducto.Location = new System.Drawing.Point(552, 51);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(30, 25);
            this.btnProducto.TabIndex = 8;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.White;
            this.txtNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.txtNombreProducto.Location = new System.Drawing.Point(295, 51);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(249, 24);
            this.txtNombreProducto.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Producto:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.Color.White;
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(168, 21);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(111, 24);
            this.txtIdProducto.TabIndex = 4;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(30, 51);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(249, 24);
            this.txtCodigoProducto.TabIndex = 1;
            this.txtCodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProducto_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código Producto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarProveedor);
            this.groupBox2.Controls.Add(this.txtIdProveedor);
            this.groupBox2.Controls.Add(this.txtRazonSocial);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNumeroDocumento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(602, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 109);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Proveedor";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProveedor.IconSize = 20;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(555, 51);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(30, 25);
            this.btnBuscarProveedor.TabIndex = 7;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.BackColor = System.Drawing.Color.White;
            this.txtIdProveedor.Enabled = false;
            this.txtIdProveedor.Location = new System.Drawing.Point(463, 21);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(155, 24);
            this.txtIdProveedor.TabIndex = 6;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.Location = new System.Drawing.Point(288, 51);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(249, 24);
            this.txtRazonSocial.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Razón Social:";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNumeroDocumento.Location = new System.Drawing.Point(20, 53);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.ReadOnly = true;
            this.txtNumeroDocumento.Size = new System.Drawing.Size(249, 24);
            this.txtNumeroDocumento.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Número Documento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTipoDocumento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(50, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 109);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Compra";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(304, 53);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(183, 26);
            this.cboTipoDocumento.TabIndex = 3;
            this.cboTipoDocumento.Text = "Boleta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Documento:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(30, 51);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(249, 24);
            this.txtFecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registrar Compras";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.eliminar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::CapaPresentacion.Properties.Resources.activar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::CapaPresentacion.Properties.Resources.boligrafo;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCompras";
            this.Size = new System.Drawing.Size(1330, 819);
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnRegistrarDetalle;
        private FontAwesome.Sharp.IconButton btnAgregarDetalle;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.CheckBox chkSeleccionar;
    }
}
