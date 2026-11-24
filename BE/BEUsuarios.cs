using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEUsuarios
    {
		private int id;

		public int IdUsuario
		{
			get { return id; }
			set { id = value; }
		}

		private string usuario;

		public string Usuario
		{
			get { return usuario; }
			set { usuario = value; }
		}


		private string contraseña;

		public string Contraseña
		{
			get { return contraseña; }
			set { contraseña = value; }
		}

		private string mail;

		public string Email
		{
			get { return mail; }
			set { mail = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		private bool estado;

		public bool Estado
		{
			get { return estado; }
			set { estado = value; }
		}

		private bool baja;

		public bool Baja
		{
			get { return baja; }
			set { baja = value; }
		}

	}
}
