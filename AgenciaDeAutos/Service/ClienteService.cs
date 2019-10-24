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

        public bool nuevoCliente(string[] vec, long dni, int nroCalle, long telefono, long celular)
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

        public string[] buscarClientePorID(int id)
        {
            Cliente cliente = dao.buscarClientePorID(id);
            string[] vec = new string[8];
            vec[0] = cliente.Dni.ToString();
            vec[1] = cliente.Nombre;
            vec[2] = cliente.Apellido;
            vec[3] = cliente.Calle;
            vec[4] = cliente.NroCalle.ToString();
            vec[5] = cliente.Telefono.ToString();
            vec[6] = cliente.Celular.ToString();
            vec[7] = cliente.IdCliente.ToString();
            return vec;

        }

        public bool buscarClientePorDni(long dni)
        {
            return dao.buscarClientePorDNI(dni);
        }

        public bool editarCliente(string[] vector)
        {
            //Orden del vector = DNI/Nombre/Apellido/Calle/NroCalle/Telefono/Celular/idCliente
            Cliente cliente = new Cliente();
            cliente.IdCliente = Convert.ToInt32(vector[7]);
            cliente.Dni = Convert.ToInt32(vector[0]);
            cliente.Nombre = vector[1];
            cliente.Apellido = vector[2];
            cliente.Calle = vector[3];
            cliente.NroCalle = Convert.ToInt32(vector[4]);
            cliente.Telefono = Convert.ToInt64(vector[5]);
            cliente.Celular = Convert.ToInt64(vector[6]);
            return dao.editarCliente(cliente);
        }

        public bool borrarCliente(int id)
        {
            return dao.borrarCliente(id);
        }
    }
}
