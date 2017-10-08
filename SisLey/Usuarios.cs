using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisLey
{
    public class Usuarios : asesores
    {
        private String User;
        private String PassWord;
        private Boolean status;
        private int idAsesores1, idParlamentario1;
        private String nombreU, apellidoU;
        private DateTime creacion;

        public bool Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int IdAsesores1
        {
            get
            {
                return idAsesores1;
            }

            set
            {
                idAsesores1 = value;
            }
        }

        public int IdParlamentario1
        {
            get
            {
                return idParlamentario1;
            }

            set
            {
                idParlamentario1 = value;
            }
        }

        public string NombreU
        {
            get
            {
                return nombreU;
            }

            set
            {
                nombreU = value;
            }
        }

        public string ApellidoU
        {
            get
            {
                return apellidoU;
            }

            set
            {
                apellidoU = value;
            }
        }

        public DateTime Creacion1
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

        public Usuarios(int idAsesores, int idParlamentario, string nombre, string apellido, DateTime creacion) : base(idAsesores, idParlamentario, nombre, apellido, creacion)
        {
            idAsesores1 = idAsesores;
            idParlamentario1 = idParlamentario;
            nombreU = nombre;
            apellidoU = apellido;
            this.creacion = creacion;


        }

        // This Will return the actual value of the user 
        public String getUser()
        {
            return User;
        }
        //This Will set a new value to user
        public void SetUser(String NewUser)
        {
            User = NewUser;
        }
        // This Will return the actual value of the PassWord
        public String getPass()
        {
            return PassWord;
        }
        //This Will set a new value to user
        public void SetPass(String NewPass)
        {
            PassWord = NewPass;
        }

        public void insertarUsuario(Usuarios sis1)
        {
            try
            {
                Conexion create1 = new Conexion();
                create1.realizarconexion();
                MySqlCommand comando = create1.crearComando();
                comando.CommandText = "Insert into usuarios(user,password) values(@user, @password)";
                comando.Parameters.Add("@user", MySqlDbType.VarChar, 45).Value = sis1.getNombre();
                comando.Parameters.Add("@password", MySqlDbType.VarChar, 45).Value = sis1.getApellido();
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
