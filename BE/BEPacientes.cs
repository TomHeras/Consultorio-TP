using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPacientes
    {
        private int id_paciente;
        public int IdPaciente 
        {
            get { return id_paciente; }
            set { id_paciente = value; } 

        
        }
        private string dni;
        public string Dni 
        {
            get { return dni; }
            set { dni = value; }
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
        private int telefono;
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string obra_social;
        public string ObraSocial
        {
            get { return obra_social; }
            set { obra_social = value; }
        }
        private bool baja;
        public bool Baja
        {
            get { return baja; }
            set { baja = value; }
        }

    }

}

