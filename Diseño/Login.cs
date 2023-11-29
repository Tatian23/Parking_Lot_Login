using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Diseño
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string nombre, contraseña;
            nombre = user.Text;
            contraseña = pass.Text;
            MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; Database = parqueadero_lot_db; User Id=root; password=");
            try
            {
                conn.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }
            String sql = "select Usuario,Clave from usuario where Usuario = '" + nombre + "' AND Clave = '" + contraseña + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                this.Hide();
                MessageBox.Show("Bienvenido " + nombre);

                //Mandar a el formulario que se planifique despues de dar permisos a Administrador-Colaborador-Usuario.
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existe este usuario " +  nombre);
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                user.Text = "Ingrese su Usuario";
                user.ForeColor = Color.Green;
            }
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (user.Text == "Ingrese su Usuario")
            {
                user.Text = "";
                user.ForeColor = Color.Green;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Ingrese su Contraseña";
                pass.ForeColor = Color.Green;
                pass.UseSystemPasswordChar = false;

            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Ingrese su Contraseña")
            {
                pass.Text = "";
                pass.ForeColor = Color.Green;
                pass.UseSystemPasswordChar = true;
            }
        }

        private void muestra_CheckedChanged(object sender, EventArgs e)
        {
           if (!muestra.Checked == false)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }

    }

