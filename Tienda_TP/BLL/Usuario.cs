using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Usuario
    {
		private string _nombre;
        private string _apellido;

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

        public Usuario()
        {
        }

        public Usuario(string nombre, string apellido)
        {
              this.Nombre = nombre;
              this.Apellido = apellido;
        }

    }
}
