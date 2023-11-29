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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
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

            string sql = "insert into usuario(Usuario,Clave) values ('" + userRegistro.Text + "' , '" + passRegistro.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Registrado :D");
                MessageBox.Show("Ya puedes Iniciar Sesión :p");
                this.Hide();
                Login log = new Login();
                log.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

        private void iniciarsesionlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void userRegistro_Leave(object sender, EventArgs e)
        {
            if (userRegistro.Text == "")
            {
                userRegistro.Text = "Registre su Usuario";
                userRegistro.ForeColor = Color.Green;
            }
        }

        private void userRegistro_Enter(object sender, EventArgs e)
        {
            if (userRegistro.Text == "Registre su Usuario")
            {
                userRegistro.Text = "";
                userRegistro.ForeColor = Color.Green;
            }
        }

        private void passRegistro_Leave(object sender, EventArgs e)
        {
            if (passRegistro.Text == "")
            {
                passRegistro.Text = "Registre su Contraseña";
                passRegistro.ForeColor = Color.Green;
                passRegistro.UseSystemPasswordChar = false;

            }
        }

        private void passRegistro_Enter(object sender, EventArgs e)
        {
            if (passRegistro.Text == "Registre su Contraseña")
            {
                passRegistro.Text = "";
                passRegistro.ForeColor = Color.Green;
                passRegistro.UseSystemPasswordChar = true;
            }
        }
    }
}
