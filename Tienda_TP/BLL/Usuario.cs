using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Usuario
    {
        //Comenté solo para probar el inicio de sesion, despues agregamos los demas atributos
        private int _id;
        private string _nombre;
        private string _apellido;
        //private long _dni;
        //private string _direccion;
        //private string _rol;
        private string _user;

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        private string _contrasenia;

        public string Contraseña
        {
            get { return _contrasenia; }
            set { _contrasenia = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}
        /*public long DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }*/
        public Usuario()
        {
        }

        public Usuario(int Id, string nombre, string apellido, string user, string contraseña)
        {
              this._id = Id;
              this.Nombre = nombre;
              this.Apellido = apellido;
              this.User = user;
              this.Contraseña = contraseña;
        }

        public abstract string ObtenerRol(string elRol);
    }
}
