namespace Diseño
{
    partial class Registro
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
            this.label4 = new System.Windows.Forms.Label();
            this.iniciarsesionlink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passRegistro = new System.Windows.Forms.TextBox();
            this.userRegistro = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(12, 616);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Parking Lot - 2023";
            // 
            // iniciarsesionlink
            // 
            this.iniciarsesionlink.AutoSize = true;
            this.iniciarsesionlink.Location = new System.Drawing.Point(115, 525);
            this.iniciarsesionlink.Name = "iniciarsesionlink";
            this.iniciarsesionlink.Size = new System.Drawing.Size(161, 19);
            this.iniciarsesionlink.TabIndex = 18;
            this.iniciarsesionlink.TabStop = true;
            this.iniciarsesionlink.Text = "¡Inicia sesión Ahora!";
            this.iniciarsesionlink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iniciarsesionlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.iniciarsesionlink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "¿Ya tienes una cuenta?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(144, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Contraseña";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(159, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuario";
            this.label1.Visible = false;
            // 
            // passRegistro
            // 
            this.passRegistro.ForeColor = System.Drawing.Color.ForestGreen;
            this.passRegistro.Location = new System.Drawing.Point(80, 332);
            this.passRegistro.Name = "passRegistro";
            this.passRegistro.Size = new System.Drawing.Size(230, 26);
            this.passRegistro.TabIndex = 14;
            this.passRegistro.Text = "Registre su Contraseña";
            this.passRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passRegistro.Enter += new System.EventHandler(this.passRegistro_Enter);
            this.passRegistro.Leave += new System.EventHandler(this.passRegistro_Leave);
            // 
            // userRegistro
            // 
            this.userRegistro.ForeColor = System.Drawing.Color.ForestGreen;
            this.userRegistro.Location = new System.Drawing.Point(80, 250);
            this.userRegistro.Name = "userRegistro";
            this.userRegistro.Size = new System.Drawing.Size(230, 26);
            this.userRegistro.TabIndex = 13;
            this.userRegistro.Text = "Registre su Usuario";
            this.userRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userRegistro.Enter += new System.EventHandler(this.userRegistro_Enter);
            this.userRegistro.Leave += new System.EventHandler(this.userRegistro_Leave);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(139)))), ((int)(((byte)(187)))));
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnregistrar.Location = new System.Drawing.Point(133, 409);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(118, 45);
            this.btnregistrar.TabIndex = 12;
            this.btnregistrar.Text = "Registrarse";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.YellowGreen;
            this.label6.Location = new System.Drawing.Point(249, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "Parking Lot";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.YellowGreen;
            this.label5.Location = new System.Drawing.Point(10, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Registrate";
            this.label5.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Diseño.Properties.Resources.user_1808597_640;
            this.picLogo.Location = new System.Drawing.Point(119, 37);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(140, 148);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 23;
            this.picLogo.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(182)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(376, 632);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iniciarsesionlink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passRegistro);
            this.Controls.Add(this.userRegistro);
            this.Controls.Add(this.btnregistrar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel iniciarsesionlink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passRegistro;
        private System.Windows.Forms.TextBox userRegistro;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picLogo;
    }
}