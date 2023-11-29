namespace Diseño
{
    partial class Form2
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
            this.grpDatospersona = new System.Windows.Forms.GroupBox();
            this.txtcapacidad = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtCoordenadas = new System.Windows.Forms.TextBox();
            this.lblCoordenadas = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.dtgDatosParqueadero = new System.Windows.Forms.DataGridView();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDirecciones = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.radPublico = new System.Windows.Forms.RadioButton();
            this.radPrivado = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpDatospersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosParqueadero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatospersona
            // 
            this.grpDatospersona.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.grpDatospersona.Controls.Add(this.radPrivado);
            this.grpDatospersona.Controls.Add(this.radPublico);
            this.grpDatospersona.Controls.Add(this.txtcapacidad);
            this.grpDatospersona.Controls.Add(this.lblCapacidad);
            this.grpDatospersona.Controls.Add(this.txtCoordenadas);
            this.grpDatospersona.Controls.Add(this.lblCoordenadas);
            this.grpDatospersona.Controls.Add(this.btnSalir);
            this.grpDatospersona.Controls.Add(this.btnEjecutar);
            this.grpDatospersona.Controls.Add(this.dtgDatosParqueadero);
            this.grpDatospersona.Controls.Add(this.txtciudad);
            this.grpDatospersona.Controls.Add(this.txtDireccion);
            this.grpDatospersona.Controls.Add(this.txtnom);
            this.grpDatospersona.Controls.Add(this.lblCiudad);
            this.grpDatospersona.Controls.Add(this.lblTipo);
            this.grpDatospersona.Controls.Add(this.lblDirecciones);
            this.grpDatospersona.Controls.Add(this.lblNombre);
            this.grpDatospersona.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatospersona.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpDatospersona.Location = new System.Drawing.Point(23, 76);
            this.grpDatospersona.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.grpDatospersona.Name = "grpDatospersona";
            this.grpDatospersona.Size = new System.Drawing.Size(614, 351);
            this.grpDatospersona.TabIndex = 1;
            this.grpDatospersona.TabStop = false;
            this.grpDatospersona.Text = "Datos Parqueadero";
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Location = new System.Drawing.Point(107, 246);
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Size = new System.Drawing.Size(149, 26);
            this.txtcapacidad.TabIndex = 14;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(21, 249);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(73, 20);
            this.lblCapacidad.TabIndex = 13;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // txtCoordenadas
            // 
            this.txtCoordenadas.Location = new System.Drawing.Point(107, 203);
            this.txtCoordenadas.Name = "txtCoordenadas";
            this.txtCoordenadas.Size = new System.Drawing.Size(149, 26);
            this.txtCoordenadas.TabIndex = 12;
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.AutoSize = true;
            this.lblCoordenadas.Location = new System.Drawing.Point(21, 209);
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(90, 20);
            this.lblCoordenadas.TabIndex = 11;
            this.lblCoordenadas.Text = "Coordenadas";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEjecutar.Location = new System.Drawing.Point(486, 300);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(109, 45);
            this.btnEjecutar.TabIndex = 9;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // dtgDatosParqueadero
            // 
            this.dtgDatosParqueadero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosParqueadero.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgDatosParqueadero.Location = new System.Drawing.Point(329, 29);
            this.dtgDatosParqueadero.Name = "dtgDatosParqueadero";
            this.dtgDatosParqueadero.Size = new System.Drawing.Size(266, 200);
            this.dtgDatosParqueadero.TabIndex = 2;
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(107, 150);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(149, 26);
            this.txtciudad.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(107, 105);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(149, 26);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(107, 20);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(149, 26);
            this.txtnom.TabIndex = 1;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(25, 153);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(51, 20);
            this.lblCiudad.TabIndex = 3;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(25, 63);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 20);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDirecciones
            // 
            this.lblDirecciones.AutoSize = true;
            this.lblDirecciones.Location = new System.Drawing.Point(21, 105);
            this.lblDirecciones.Name = "lblDirecciones";
            this.lblDirecciones.Size = new System.Drawing.Size(80, 20);
            this.lblDirecciones.TabIndex = 1;
            this.lblDirecciones.Text = "Direcciones";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(357, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(261, 48);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Parking Lot";
            // 
            // radPublico
            // 
            this.radPublico.AutoSize = true;
            this.radPublico.Location = new System.Drawing.Point(97, 52);
            this.radPublico.Name = "radPublico";
            this.radPublico.Size = new System.Drawing.Size(76, 24);
            this.radPublico.TabIndex = 15;
            this.radPublico.TabStop = true;
            this.radPublico.Text = "Publico ";
            this.radPublico.UseVisualStyleBackColor = true;
            // 
            // radPrivado
            // 
            this.radPrivado.AutoSize = true;
            this.radPrivado.Location = new System.Drawing.Point(97, 73);
            this.radPrivado.Name = "radPrivado";
            this.radPrivado.Size = new System.Drawing.Size(73, 24);
            this.radPrivado.TabIndex = 16;
            this.radPrivado.TabStop = true;
            this.radPrivado.Text = "Privado";
            this.radPrivado.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(643, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 93);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalir.Location = new System.Drawing.Point(483, 249);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 45);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.grpDatospersona);
            this.Name = "Form2";
            this.Text = "Fromulario Registro Parqueadero";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpDatospersona.ResumeLayout(false);
            this.grpDatospersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosParqueadero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatospersona;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.DataGridView dtgDatosParqueadero;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDirecciones;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtCoordenadas;
        private System.Windows.Forms.Label lblCoordenadas;
        private System.Windows.Forms.TextBox txtcapacidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radPrivado;
        private System.Windows.Forms.RadioButton radPublico;
    }
}