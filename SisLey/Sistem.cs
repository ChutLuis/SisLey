using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SisLey
{
    public class Sistem
    {
        private Conexion create1;
        private int idSistema;
        private String nombre;
        private DateTime fechacreacion;

        internal Conexion Create1
        {
            get
            {
                return create1;
            }

            set
            {
                create1 = new Conexion() ;
            }
        }

        public int getidSistema()
        {
            return idSistema; 
        }
        public void setidSistema(int newid)
        {
            idSistema = newid;
        }
        public String getNombre()
        {
            return nombre;
        }
        public void setNombre(String newNombre)
        {
            nombre = newNombre;
        }
        public DateTime getFecha()
        {
            return fechacreacion;
        }
        public void setFecha(DateTime newFecha)
        {
            fechacreacion = newFecha;
        }

        public void insertarSistema(Sistem sis1)
        {
            try
            {
                Conexion create1 = new Conexion();
                create1.realizarconexion();
                MySqlCommand comando = create1.crearComando();
                comando.CommandText = "Insert into Sistema (nombre) values (@nombre)";
                comando.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = sis1.getNombre();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("El error ocurrido: " + e);
                throw;
            }
            

        }
    }
}
