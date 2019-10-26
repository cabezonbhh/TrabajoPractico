using AgenciaDeAutos.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Data.Interfaces
{
    public interface IDaoUsuario<U>
    {
        IList<U> getUsuarios();
        U buscarUsuarioPorID(int id);
        bool nuevoUsuario(U obj);
        bool editarUsuario(U obj);
        bool borrarUsuario(int id);
        Usuario getUsuarioValidado(string nombre, string contraseña);
        bool buscarUsuarioPorNombre(string nombre);
    }
}
