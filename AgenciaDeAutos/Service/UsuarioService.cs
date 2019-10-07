using AgenciaDeAutos.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaDeAutos.Business;
using AgenciaDeAutos.Data.Dao;

namespace AgenciaDeAutos.Service
{
    public class UsuarioService
    {
        private IDaoUsuario <Usuario> dao;
        public int UsuarioSeleccionado { get; set; }

        public UsuarioService()
        {
            dao = new UsuarioDaoSqlImp();
        }
        public IList<Usuario> obtenerUsuarios()
        {
            return dao.getUsuarios();
        }
        public bool borrarUsuario(int id)
        {
            return dao.borrarUsuario(id);
        }

        public bool editarUsuario(Usuario usuario)
        {
            return dao.editarUsuario(usuario);
        }

        public bool nuevoUsuario(string nombre, string contraseña, int idPerfil)
        {
            Perfil perfil = new Perfil(idPerfil);
            Usuario usuario = new Usuario();
            usuario.Nombre = nombre;
            usuario.Contraseña = contraseña;
            usuario.Perfil = perfil;
            return dao.nuevoUsuario(usuario);
        }

        public Usuario ValidarUsuario(string nombre, string contraseña)
        {
            return dao.getUsuarioValidado(nombre, contraseña);
        }

        public Usuario buscarUsuarioPorID(int id)
        {
            return dao.buscarUsuarioPorID(id);
        }

        public bool buscarUsuarioPorNombre(string nombre)
        {
            return dao.buscarUsuarioPorNombre(nombre);
        }
    }
}
