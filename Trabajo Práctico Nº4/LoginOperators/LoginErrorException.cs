using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginOperators
{
    public class LoginErrorException : Exception
    {
        public LoginErrorException():base("Incorrect username and password")
        {

        }
    }
}
