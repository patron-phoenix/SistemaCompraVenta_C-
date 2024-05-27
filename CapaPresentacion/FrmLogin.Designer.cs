namespace CapaPresentacion
{
    partial class FrmLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIngresarLogin1 = new FontAwesome.Sharp.IconButton();
            this.btnSalirLogin = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 478);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(126, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 137);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Compra y Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(686, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro. Documento";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(625, 179);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(240, 17);
            this.txtNumeroDocumento.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(625, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 5);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Location = new System.Drawing.Point(625, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 5);
            this.panel3.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(625, 266);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 17);
            this.txtPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(622, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // btnIngresarLogin1
            // 
            this.btnIngresarLogin1.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIngresarLogin1.FlatAppearance.BorderSize = 0;
            this.btnIngresarLogin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarLogin1.ForeColor = System.Drawing.Color.White;
            this.btnIngresarLogin1.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnIngresarLogin1.IconColor = System.Drawing.Color.White;
            this.btnIngresarLogin1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresarLogin1.IconSize = 25;
            this.btnIngresarLogin1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarLogin1.Location = new System.Drawing.Point(621, 335);
            this.btnIngresarLogin1.Name = "btnIngresarLogin1";
            this.btnIngresarLogin1.Size = new System.Drawing.Size(120, 37);
            this.btnIngresarLogin1.TabIndex = 8;
            this.btnIngresarLogin1.Text = "Ingresar";
            this.btnIngresarLogin1.UseVisualStyleBackColor = false;
            this.btnIngresarLogin1.Click += new System.EventHandler(this.btnIngresarLogin1_Click);
            // 
            // btnSalirLogin
            // 
            this.btnSalirLogin.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalirLogin.FlatAppearance.BorderSize = 0;
            this.btnSalirLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirLogin.ForeColor = System.Drawing.Color.White;
            this.btnSalirLogin.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnSalirLogin.IconColor = System.Drawing.Color.White;
            this.btnSalirLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalirLogin.IconSize = 25;
            this.btnSalirLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirLogin.Location = new System.Drawing.Point(747, 335);
            this.btnSalirLogin.Name = "btnSalirLogin";
            this.btnSalirLogin.Size = new System.Drawing.Size(120, 37);
            this.btnSalirLogin.TabIndex = 9;
            this.btnSalirLogin.Text = "Salir";
            this.btnSalirLogin.UseVisualStyleBackColor = false;
            this.btnSalirLogin.Click += new System.EventHandler(this.btnSalirLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 478);
            this.Controls.Add(this.btnSalirLogin);
            this.Controls.Add(this.btnIngresarLogin1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnIngresarLogin1;
        private FontAwesome.Sharp.IconButton btnSalirLogin;
    }
}