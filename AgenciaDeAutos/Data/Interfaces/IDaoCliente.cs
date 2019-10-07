using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Data.Interfaces
{
    public interface IDaoCliente <C>
    {
        IList<C> getClientes();

        C buscarClientePorID(int id);
        bool nuevoCliente(C obj);
        bool editarCliente(C obj);
        bool borrarCliente(int id);
        bool buscarClientePorDNI(int dni);
    }
}
