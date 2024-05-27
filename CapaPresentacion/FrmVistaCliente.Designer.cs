namespace CapaPresentacion
{
    partial class FrmVistaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(167, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(366, 24);
            this.txtBuscar.TabIndex = 15;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.DgvListado.EnableHeadersVisualStyles = false;
            this.DgvListado.Location = new System.Drawing.Point(27, 97);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(764, 491);
            this.DgvListado.TabIndex = 16;
            this.DgvListado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentDoubleClick);
            // 
            // FrmVistaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 653);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.DgvListado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmVistaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Cliente";
            this.Load += new System.EventHandler(this.FrmVistaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView DgvListado;
    }
}