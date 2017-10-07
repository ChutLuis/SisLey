using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SisLey
{
    class Conexion
    {
        private MySqlConnection conexion;

        private void conectar()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "naci150299FER95";
            builder.Database = "sisley";
            conexion = new MySqlConnection(builder.ToString());

        
        }

        private void cerrar()
        {
            conexion.Close();
        }
        public void realizarconexion()
        {
            try
            {

                conectar();
                conexion.Open();
            }
            catch (Exception e)
            {
                DialogResult result;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                result = MessageBox.Show("Error"+e,"Error", buttons);
            }
        }
        public void cerrarconexion()
        {
            try
            {

                cerrar();
                
                MessageBox.Show("Conexion Cerrada", "Conexion", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                DialogResult result;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                result = MessageBox.Show("Error" + e, "Error", buttons);
            }
        }
        public MySqlCommand crearComando()
        {
            try
            {
                return conexion.CreateCommand();
            }
            catch (Exception s)
            {

                throw;
            }
        }
        
    }
}
