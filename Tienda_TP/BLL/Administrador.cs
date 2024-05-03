using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //Administrador hereda de Usuario que es una CLASE ABSTRACTA
    public class Administrador : Usuario
    {
        public Administrador(int Id, string nombre, string apellido, string user, string contraseña) : base(Id, nombre, apellido, user, contraseña)
        {
        }

        public override string ObtenerRol(string elRol)
        {
            throw new NotImplementedException();
        }
    }
}
