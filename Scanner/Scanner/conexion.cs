using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
namespace Scanner
{
    class conexion
    {
        public static MySqlConnection conex()
        {
            string servidor = "server=localhost; database=userdb; Uid=root; pwd=SMOJESC2023";

            MySqlConnection conexionDB = new MySqlConnection(servidor);

            try
            {
                return conexionDB;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message+e.StackTrace);
                return null;
            }
        }
    }
}
