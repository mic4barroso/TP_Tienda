using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Login
    {
        private string _username = "username";
        private string _password = "password";

        /*public bool IniciarSesion(string userName, string password)
        {
            throw new NotImplementedException();
        }*/

        public bool IniciarSesion(string username, string password) {

            if (string.IsNullOrEmpty(username)) {
                throw new ArgumentNullException("username");
            }

            if (string.IsNullOrEmpty(password)) {  
                throw new ArgumentNullException("password"); 
            }

            if(_username == username || _password == password) {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
