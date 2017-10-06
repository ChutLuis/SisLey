using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLey
{
    public class Usuarios
    {
        private String User="Luis";
        private String PassWord="SF12345";
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


    }
}
