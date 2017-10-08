using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisLey
{
    public class asesores : Parlamentario
    {
        private int idAsesores, idParlamentario;
        private String nombre, apellido;
        private DateTime creacion;

        public int IdAsesores
        {
            get
            {
                return idAsesores;
            }

            set
            {
                idAsesores = value;
            }
        }

        public int IdParlamentario
        {
            get
            {
                return idParlamentario;
            }

            set
            {
                idParlamentario = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public DateTime Creacion
        {
            get
            {
                return creacion;
            }

            set
            {
                creacion = value;
            }
        }

        public asesores(int idAsesores, int idParlamentario, string nombre, string apellido, DateTime creacion) : base(idParlamentario, nombre, apellido, creacion)
        {
            this.idAsesores = idAsesores;
            this.idParlamentario = idParlamentario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.creacion = creacion;
        }
        public void insertarAsesor(asesores sis1)
        {
            try
            {
                Conexion create1 = new Conexion();
                create1.realizarconexion();
                MySqlCommand comando = create1.crearComando();
                comando.CommandText = "Insert into asesores(nombre,apellido) values(@nombre, @apellido)";
                comando.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = sis1.Nombre;
                comando.Parameters.Add("@apellido", MySqlDbType.VarChar, 45).Value = sis1.apellido;
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
