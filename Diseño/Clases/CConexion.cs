using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño.Clases
{
    class CConexion
    {

        static string servidor = "localhost";
        static string bd = "bdmysql";
        static string usuario = "root";
        static string password = "2409";
        static string puerto = "3306";

        MySqlConnection conex = new MySqlConnection();

        String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection establecerconexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("se logro la conexion a la Base de Dactos Correctamente");
            }
            catch (MySqlException e)
            {
                
                MessageBox.Show("Error al conectar a la base de datos. Por favor, intente más tarde." + e.ToString());

                
                return null;
            }

            
            return conex;
        }
    }
}
