namespace Diseño
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatospersona = new System.Windows.Forms.GroupBox();
            this.grpDatosTipopersona = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaNacimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.dtgDatospersona = new System.Windows.Forms.DataGridView();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtIdentificacio = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPARKINLOT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpDatospersona.SuspendLayout();
            this.grpDatosTipopersona.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatospersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatospersona
            // 
            this.grpDatospersona.BackColor = System.Drawing.Color.DarkCyan;
            this.grpDatospersona.Controls.Add(this.button1);
            this.grpDatospersona.Controls.Add(this.grpDatosTipopersona);
            this.grpDatospersona.Controls.Add(this.btnSalir);
            this.grpDatospersona.Controls.Add(this.btnEjecutar);
            this.grpDatospersona.Controls.Add(this.dtgDatospersona);
            this.grpDatospersona.Controls.Add(this.dtpFechaNacimiento);
            this.grpDatospersona.Controls.Add(this.txtEmail);
            this.grpDatospersona.Controls.Add(this.txtNombre);
            this.grpDatospersona.Controls.Add(this.txtTelefono);
            this.grpDatospersona.Controls.Add(this.txtIdentificacio);
            this.grpDatospersona.Controls.Add(this.lblFechaNacimiento);
            this.grpDatospersona.Controls.Add(this.lblEmail);
            this.grpDatospersona.Controls.Add(this.lblTelefono);
            this.grpDatospersona.Controls.Add(this.lblNombre);
            this.grpDatospersona.Controls.Add(this.lblIdentificacion);
            this.grpDatospersona.Location = new System.Drawing.Point(12, 170);
            this.grpDatospersona.Name = "grpDatospersona";
            this.grpDatospersona.Size = new System.Drawing.Size(585, 303);
            this.grpDatospersona.TabIndex = 0;
            this.grpDatospersona.TabStop = false;
            this.grpDatospersona.Text = "Datos de persona";
            // 
            // grpDatosTipopersona
            // 
            this.grpDatosTipopersona.BackColor = System.Drawing.Color.MediumAquamarine;
            this.grpDatosTipopersona.Controls.Add(this.menuStrip1);
            this.grpDatosTipopersona.Location = new System.Drawing.Point(290, 32);
            this.grpDatosTipopersona.Name = "grpDatosTipopersona";
            this.grpDatosTipopersona.Size = new System.Drawing.Size(277, 116);
            this.grpDatosTipopersona.TabIndex = 1;
            this.grpDatosTipopersona.TabStop = false;
            this.grpDatosTipopersona.Text = "Tipo de persona";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdministrador,
            this.colaboradorToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(271, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAdministrador
            // 
            this.mnuAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripMenuItem,
            this.telefonoToolStripMenuItem,
            this.identificacionToolStripMenuItem,
            this.fechaNacimientoToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.mnuAdministrador.Name = "mnuAdministrador";
            this.mnuAdministrador.Size = new System.Drawing.Size(95, 20);
            this.mnuAdministrador.Text = "Administrador";
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.nombreToolStripMenuItem.Text = "Nombre";
            // 
            // telefonoToolStripMenuItem
            // 
            this.telefonoToolStripMenuItem.Name = "telefonoToolStripMenuItem";
            this.telefonoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.telefonoToolStripMenuItem.Text = "Telefono";
            // 
            // identificacionToolStripMenuItem
            // 
            this.identificacionToolStripMenuItem.Name = "identificacionToolStripMenuItem";
            this.identificacionToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.identificacionToolStripMenuItem.Text = "Identificacion";
            // 
            // fechaNacimientoToolStripMenuItem
            // 
            this.fechaNacimientoToolStripMenuItem.Name = "fechaNacimientoToolStripMenuItem";
            this.fechaNacimientoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.fechaNacimientoToolStripMenuItem.Text = "FechaNacimiento";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // colaboradorToolStripMenuItem
            // 
            this.colaboradorToolStripMenuItem.Name = "colaboradorToolStripMenuItem";
            this.colaboradorToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.colaboradorToolStripMenuItem.Text = "Colaborador";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(467, 263);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(45, 274);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 9;
            this.btnEjecutar.Text = "Guardar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            // 
            // dtgDatospersona
            // 
            this.dtgDatospersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatospersona.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgDatospersona.Location = new System.Drawing.Point(177, 172);
            this.dtgDatospersona.Name = "dtgDatospersona";
            this.dtgDatospersona.Size = new System.Drawing.Size(197, 82);
            this.dtgDatospersona.TabIndex = 2;
            this.dtgDatospersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(126, 135);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(120, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(97, 50);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(149, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtIdentificacio
            // 
            this.txtIdentificacio.Location = new System.Drawing.Point(97, 20);
            this.txtIdentificacio.Name = "txtIdentificacio";
            this.txtIdentificacio.Size = new System.Drawing.Size(149, 20);
            this.txtIdentificacio.TabIndex = 1;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(30, 135);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(90, 13);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "FechaNacimiento";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(25, 50);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(21, 20);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacion.TabIndex = 0;
            this.lblIdentificacion.Text = "Identificacion";
            this.lblIdentificacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Khaki;
            this.picLogo.Image = global::Diseño.Properties.Resources.logop;
            this.picLogo.Location = new System.Drawing.Point(12, 22);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 118);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // lblPARKINLOT
            // 
            this.lblPARKINLOT.AutoSize = true;
            this.lblPARKINLOT.BackColor = System.Drawing.Color.Honeydew;
            this.lblPARKINLOT.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPARKINLOT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPARKINLOT.Location = new System.Drawing.Point(329, 61);
            this.lblPARKINLOT.Name = "lblPARKINLOT";
            this.lblPARKINLOT.Size = new System.Drawing.Size(247, 39);
            this.lblPARKINLOT.TabIndex = 3;
            this.lblPARKINLOT.Text = "PARKING LOT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "conexion MySQL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(690, 504);
            this.Controls.Add(this.lblPARKINLOT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpDatospersona);
            this.Name = "Form1";
            this.Text = "Formulario persona";
            this.grpDatospersona.ResumeLayout(false);
            this.grpDatospersona.PerformLayout();
            this.grpDatosTipopersona.ResumeLayout(false);
            this.grpDatosTipopersona.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatospersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatospersona;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtIdentificacio;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.GroupBox grpDatosTipopersona;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.DataGridView dtgDatospersona;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministrador;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaNacimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPARKINLOT;
        private System.Windows.Forms.Button button1;
    }
}

