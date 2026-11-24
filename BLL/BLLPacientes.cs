using BE;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPacientes
    {

        Mapper.MapperPacientes mapper = new Mapper.MapperPacientes();


        public List<BEPacientes> ListarPacientes()
        {
            return mapper.ListarPacientes();
        }

        public string AltaPacientes(BEPacientes paciente)
        {
            return mapper.AltaPacientes(paciente);
        }

        public string ModificarPacientes(BEPacientes paciente)
        {
            return mapper.ModificarPacientes(paciente);
        }

        public string EliminarPacientes(int idPaciente)
        {
            return mapper.BajaPacientes(idPaciente);
        }
    }
}
