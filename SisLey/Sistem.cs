using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SisLey
{
    class Sistem
    {
        private int idSistema;
        private String nombre;
        private DateTime fechacreacion;

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
            Conexion create1 = new Conexion();
            create1.realizarconexion();
            MySqlCommand comando = create1.crearComando();
            comando.CommandText = "Insert into Sistema (nombre) values (@nombre)";
            comando.Parameters.Add("@nombre",MySqlDbType.VarChar,45).Value = sis1.getNombre();
            comando.ExecuteNonQuery();

        }
    }
}
