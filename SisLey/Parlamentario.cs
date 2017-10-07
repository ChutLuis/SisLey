using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SisLey
{
    public class Parlamentario : Sistem
    {
        
        private int idParlamentario;
        private String nombre;
        private String apellido;
        private DateTime Creacion;
        private int idSistema;

      public int getId()
        {
            return idParlamentario;
        }
        public void setId(int rid)
        {
            idParlamentario = rid;
        }
        public int getIdSis()
        {
            return idSistema;
        }
        public void setIdSis(Sistem rid)
        {
            idSistema = rid.getidSistema();
        }
        public void setNombre(String newname)
        {
            nombre = newname;
        }
        public String getNombre()
        {
            return nombre;
        }

        public void setApellidp(String newlast)
        {
            apellido = newlast;
        }
        public String getApellido()
        {
            return apellido;
        }

        public DateTime getCreacion()
        {
            return Creacion;
        }
        public void setCreacion(DateTime Cr1)
        {
            Creacion = Cr1;
        }
        public void insertarParlamentario(Parlamentario sis1)
        {
            try
            {
                Conexion create1 = new Conexion();
                create1.realizarconexion();
                MySqlCommand comando = create1.crearComando();  
                comando.CommandText = "Insert into parlamentarios(nombre,apellido) values(@nombre, @apellido)";
                comando.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = sis1.getNombre();
                comando.Parameters.Add("@apellido", MySqlDbType.VarChar, 45).Value = sis1.getApellido();
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
