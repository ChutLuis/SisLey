using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLey
{
    public class Leyes
    {
        private String Ley;
        // This Will return the actual value of the Law
        public String getPass()
        {
            return Ley;
        }
        //This Will set a new value to the Law
        public void SetPass(String NewPass)
        {
            Ley = NewPass;
        }

    }
}
