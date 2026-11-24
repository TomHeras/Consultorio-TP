using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BETratamientos
    {
		private int idtratamiento;

		public int IdTratamiento
		{
			get { return idtratamiento; }
			set { idtratamiento = value; }
		}

		private int idpaciente;

		public int IdPaciente
        {
			get { return idpaciente; }
			set { idpaciente = value; }
		}

		private DateTime fecha;

		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		private string nombretratamiento;

		public string NombreTratamiento
		{
			get { return nombretratamiento; }
			set { nombretratamiento = value; }
		}

		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}


        public BETratamientos(int idTratamiento, int idPaciente, DateTime fecha, string nombreTratamiento, string descripcion)
        {
            IdTratamiento = idTratamiento;
            IdPaciente = idPaciente;
            Fecha = fecha;
            NombreTratamiento = nombreTratamiento;
            Descripcion = descripcion;
        }

    }
}
