namespace CapaPresentacion
{
    partial class FrmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnInsertar = new FontAwesome.Sharp.IconMenuItem();
            this.btnActualizar = new FontAwesome.Sharp.IconMenuItem();
            this.btnCancelar = new FontAwesome.Sharp.IconMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Activar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ErrorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1333, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 764);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboRol);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNombreCompleto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtNumDocumento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 764);
            this.panel1.TabIndex = 4;
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(39, 414);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(231, 26);
            this.cboRol.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rol:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(39, 340);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(231, 24);
            this.txtClave.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Clave:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(39, 270);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(231, 24);
            this.txtCorreo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo:";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(39, 201);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(231, 24);
            this.txtNombreCompleto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Completto:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(160, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(110, 24);
            this.txtId.TabIndex = 3;
            this.txtId.Visible = false;
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Location = new System.Drawing.Point(39, 130);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(231, 24);
            this.txtNumDocumento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro. Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
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
            this.menuStrip1.Size = new System.Drawing.Size(199, 126);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 70);
            this.panel2.TabIndex = 5;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(0, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(366, 24);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkSeleccionar);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(300, 694);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1033, 70);
            this.panel3.TabIndex = 6;
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
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.BackgroundColor = System.Drawing.Color.White;
            this.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Activar,
            this.Editar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListado.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListado.EnableHeadersVisualStyles = false;
            this.DgvListado.Location = new System.Drawing.Point(300, 70);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1033, 624);
            this.DgvListado.TabIndex = 7;
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
            // Activar
            // 
            this.Activar.HeaderText = "";
            this.Activar.Image = global::CapaPresentacion.Properties.Resources.activar;
            this.Activar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Activar.Name = "Activar";
            this.Activar.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = global::CapaPresentacion.Properties.Resources.boligrafo;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // ErrorIcon
            // 
            this.ErrorIcon.ContainerControl = this;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.eliminar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::CapaPresentacion.Properties.Resources.activar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::CapaPresentacion.Properties.Resources.boligrafo;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // FrmUsuario
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
            this.Name = "FrmUsuario";
            this.Size = new System.Drawing.Size(1353, 764);
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSeleccionar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem btnInsertar;
        private FontAwesome.Sharp.IconMenuItem btnActualizar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ErrorProvider ErrorIcon;
        private FontAwesome.Sharp.IconMenuItem btnCancelar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Activar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
    }
}
