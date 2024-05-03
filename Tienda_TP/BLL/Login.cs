using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Login
    {
        //hardcodee para probar si funciona
        private List<Usuario> usuarios = new List<Usuario>()
        {
            new Administrador(1, "Ana", "Ruescas", "anaAdmin", "passwordAna"),
            new Gerente(2, "Ciro", "Coria", "ciroAdmin", "passwordCiro"),
            new AtencionAlCliente(3, "Eric", "Perez", "ericAdmin", "passwordEric"),
            new Repositor(4, "Mica", "Barroso", "micaAdmin", "passwordMica")
        };

        public bool IniciarSesion(string username, string password)
        {

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }

            //Busca coincidencias 
            var usuario = usuarios.FirstOrDefault(u => u.User == username && u.Contraseña == password);
            return usuario != null;
        }
    }
}









   