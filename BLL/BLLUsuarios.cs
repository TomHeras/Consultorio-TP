using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUsuarios
    {
        Mapper.MapperUsuario MapperUsuarios=new Mapper.MapperUsuario();

        public string AltaUsuairos (BE.BEUsuarios Usuario)
        {
            string fa= MapperUsuarios.AltaUsuarios(Usuario);
            return fa;
        }

        public List<BE.BEUsuarios> ListarUsuarios()
        {
            List<BE.BEUsuarios> ListaUsuarios=MapperUsuarios.ListarUsuarios();
            return ListaUsuarios;
        }

        public string Login(string nombreUsuario, string contraseña)
        {
            string fa="";
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña))
                return null;

            List<BE.BEUsuarios> lista = ListarUsuarios();

            lista.FirstOrDefault(u =>
                !u.Baja &&
                u.Estado &&
                u.Usuario.Equals(nombreUsuario.Trim(), StringComparison.OrdinalIgnoreCase) &&
                u.Contraseña == contraseña);

            if (lista==null)
            {
                fa = "Usuario o contraseña erroneos";
            }else
            {
                foreach (BE.BEUsuarios item in lista)
                {
                    fa = item.Usuario;
                }
            }

            return fa;
        }

        public string BloquearUsuario(string nombreUsuario)
        {
            string fa = MapperUsuarios.BloquearUsuario(nombreUsuario);
            return fa;
        }

        public string EditarUsuarios(BE.BEUsuarios Usuario)
        {
            string fa = MapperUsuarios.ModificarUsuario(Usuario);
            return fa;
        }

        public string BajaUsuairos(int Usuario)
        {
            string fa = MapperUsuarios.BajaUsuario(Usuario);
            return fa;
        }

    }
}
