namespace CapaPresentacion
{
    partial class FrmProducto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Activar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCancelar = new FontAwesome.Sharp.IconMenuItem();
            this.btnActualizar = new FontAwesome.Sharp.IconMenuItem();
            this.btnInsertar = new FontAwesome.Sharp.IconMenuItem();
            this.ErrorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::CapaPresentacion.Properties.Resources.boligrafo;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.eliminar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = global::CapaPresentacion.Properties.Resources.boligrafo;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Activar
            // 
            this.Activar.HeaderText = "";
            this.Activar.Image = global::CapaPresentacion.Properties.Resources.activar;
            this.Activar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Activar.Name = "Activar";
            this.Activar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 50;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(193, 40);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = false;
            this.btnActualizar.BackColor = System.Drawing.Color.Teal;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 50;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(193, 40);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.AutoSize = false;
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnInsertar.IconColor = System.Drawing.Color.White;
            this.btnInsertar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsertar.IconSize = 50;
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(192, 40);
            this.btnInsertar.Text = "Guardar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // ErrorIcon
            // 
            this.ErrorIcon.ContainerControl = this;
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.BackgroundColor = System.Drawing.Color.White;
            this.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Activar,
            this.Editar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListado.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListado.EnableHeadersVisualStyles = false;
            this.DgvListado.Location = new System.Drawing.Point(300, 70);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(965, 586);
            this.DgvListado.TabIndex = 12;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoSize = true;
            this.chkSeleccionar.Location = new System.Drawing.Point(25, 24);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Size = new System.Drawing.Size(105, 22);
            this.chkSeleccionar.TabIndex = 3;
            this.chkSeleccionar.Text = "Seleccionar";
            this.chkSeleccionar.UseVisualStyleBackColor = true;
            this.chkSeleccionar.CheckedChanged += new System.EventHandler(this.chkSeleccionar_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(882, 24);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 18);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(0, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(366, 24);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::CapaPresentacion.Properties.Resources.activar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 70);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkSeleccionar);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(300, 656);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 70);
            this.panel3.TabIndex = 11;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(39, 524);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(231, 26);
            this.cboCategoria.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Categoría:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(39, 340);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(231, 24);
            this.txtStock.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(39, 270);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(231, 24);
            this.txtDescripcion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(39, 201);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 24);
            this.txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(160, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(110, 24);
            this.txtId.TabIndex = 3;
            this.txtId.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(39, 130);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(231, 24);
            this.txtCodigo.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPrecioVenta);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPrecioCompra);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboCategoria);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 726);
            this.panel1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsertar,
            this.btnActualizar,
            this.btnCancelar});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(51, 586);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(199, 145);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1265, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 726);
            this.panel4.TabIndex = 8;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(39, 405);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(231, 24);
            this.txtPrecioCompra.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio Compra:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(39, 464);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(231, 24);
            this.txtPrecioVenta.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio Venta:";
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProducto";
            this.Size = new System.Drawing.Size(1285, 726);
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Activar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private FontAwesome.Sharp.IconMenuItem btnCancelar;
        private FontAwesome.Sharp.IconMenuItem btnActualizar;
        private FontAwesome.Sharp.IconMenuItem btnInsertar;
        private System.Windows.Forms.ErrorProvider ErrorIcon;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkSeleccionar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label7;
    }
}
