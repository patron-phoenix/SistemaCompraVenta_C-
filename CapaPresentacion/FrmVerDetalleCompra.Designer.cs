namespace CapaPresentacion
{
    partial class FrmVerDetalleCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Detalle Compra";
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
            this.DgvListado.Location = new System.Drawing.Point(0, 0);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1427, 383);
            this.DgvListado.TabIndex = 13;
            this.DgvListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellClick);
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvListado);
            this.panel1.Location = new System.Drawing.Point(92, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 383);
            this.panel1.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1164, 768);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 18);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "total";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(762, 59);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(299, 24);
            this.txtBuscar.TabIndex = 16;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoSize = true;
            this.chkSeleccionar.Location = new System.Drawing.Point(94, 768);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Size = new System.Drawing.Size(105, 22);
            this.chkSeleccionar.TabIndex = 17;
            this.chkSeleccionar.Text = "Seleccionar";
            this.chkSeleccionar.UseVisualStyleBackColor = true;
            this.chkSeleccionar.Visible = false;
            this.chkSeleccionar.CheckedChanged += new System.EventHandler(this.Seleccionar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTipoDocumento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(92, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1427, 92);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Compra";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(1098, 36);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(251, 24);
            this.txtUsuario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1031, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Usuario:";
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.BackColor = System.Drawing.Color.White;
            this.txtTipoDocumento.Location = new System.Drawing.Point(584, 36);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.ReadOnly = true;
            this.txtTipoDocumento.Size = new System.Drawing.Size(251, 24);
            this.txtTipoDocumento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Documento:";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.White;
            this.txtFecha.Location = new System.Drawing.Point(138, 36);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(251, 24);
            this.txtFecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMontoTotal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRazonSocial);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNumeroDocumento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(92, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1427, 92);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Proveedor";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.BackColor = System.Drawing.Color.White;
            this.txtMontoTotal.Location = new System.Drawing.Point(1156, 33);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(183, 24);
            this.txtMontoTotal.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1049, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sub Total:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.Location = new System.Drawing.Point(688, 33);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(301, 24);
            this.txtRazonSocial.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Razon Social:";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNumeroDocumento.Location = new System.Drawing.Point(245, 33);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.ReadOnly = true;
            this.txtNumeroDocumento.Size = new System.Drawing.Size(251, 24);
            this.txtNumeroDocumento.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número de Documento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Número de Documento:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1083, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 21;
            this.button1.Text = "Buscar...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmVerDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkSeleccionar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVerDetalleCompra";
            this.Size = new System.Drawing.Size(1611, 825);
            this.Load += new System.EventHandler(this.FrmVerDetalleCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.CheckBox chkSeleccionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}
