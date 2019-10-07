using AgenciaDeAutos.Business;
using AgenciaDeAutos.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Data.Dao
{
    class ClienteDaoSqlImp : IDaoCliente<Cliente>
    {
        DBHelper helper = DBHelper.getDBHelper();
        public bool borrarCliente(int id)
        {
            throw new NotImplementedException();
        }

        public bool buscarClientePorDNI(int dni)
        {
            string sql = "exec buscarClientePorDNI " + dni;
            DataTable tabla = new DataTable();
            tabla = helper.ConsultaSQL(sql);
            return tabla.Rows.Count == 1;
        }

        public Cliente buscarClientePorID(int id)
        {
            throw new NotImplementedException();
        }

        public bool editarCliente(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> getClientes()
        {
            string sql = "select * from Clientes where borrado = 0";
            List <Cliente> lista = new List<Cliente>();
            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL(sql);

            foreach(DataRow fila in tabla.Rows)
            {
                lista.Add(mapper(fila));
            }
            return lista;
        }

        public bool nuevoCliente(Cliente cliente)
        {

            // para en este orden: dni,nombre,apellido,calle,nrocalle,telefono,celular
            string sql = @"exec nuevoCliente " + cliente.Dni + ", '" +
                                               cliente.Nombre.ToString() + "', '" +
                                               cliente.Apellido.ToString() + "', '" +
                                               cliente.Calle.ToString() + "', " +
                                               cliente.NroCalle + ", " +
                                               cliente.Telefono + ", " +
                                               cliente.Celular;
            //exec nuevoCliente
            return helper.ejecutarSQL(sql)==1;
        }

        public Cliente mapper(DataRow fila)
        {
            Cliente cliente = new Cliente(); ;
            cliente.IdCliente = Int32.Parse(fila[0].ToString());
            cliente.Dni = Convert.ToInt64(fila[1].ToString()); 
            cliente.Nombre = fila[2].ToString();
            cliente.Apellido = fila[3].ToString();
            cliente.Calle = fila[4].ToString();
            cliente.NroCalle = Int32.Parse(fila[5].ToString()); 
            cliente.Telefono = Convert.ToInt64(fila[6].ToString());
            cliente.Celular = Convert.ToInt64(fila[7].ToString());
            return cliente;
        }
    }
}
