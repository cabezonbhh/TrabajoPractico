using AgenciaDeAutos.Business;
using AgenciaDeAutos.Data.Dao;
using AgenciaDeAutos.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Service
{
    public class ClienteService
    {
        private IDaoCliente <Cliente> dao;
        public int ClienteSeleccionado { get; set; }
       
        public ClienteService()
        {
            dao = new ClienteDaoSqlImp();
        }

        public IList<Cliente> obtenerClientes()
        {
            return dao.getClientes();
        }

        public bool nuevoUsuario(string[] vec, long dni, int nroCalle, long telefono, long celular)
        {
            //vec: 0 - nombre / 1 - apellido / 2 - calle 
            Cliente cliente = new Cliente
            {
                Dni = dni,
                NroCalle = nroCalle,

                Nombre = vec[0],
                Apellido = vec[1],
                Calle = vec[2],
                Telefono = telefono,
                Celular = celular
            };

            return dao.nuevoCliente(cliente);
        }

        public Cliente buscarClientePorID(int id)
        {
            return dao.buscarClientePorID(id);
        }

        public bool buscarClientePorDni(long dni)
        {
            return dao.buscarClientePorDNI(dni);
        }

        public bool editarCliente(Cliente cliente)
        {
            return dao.editarCliente(cliente);
        }

        public bool borrarCliente(int id)
        {
            return dao.borrarCliente(id);
        }
    }
}
