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
    public class ClienteDaoSqlImp : IDaoCliente<Cliente>
    {
        DBHelper helper = DBHelper.getDBHelper();
        public bool borrarCliente(int id)
        {
            return helper.ejecutarSQL("exec borrarCliente "+id)==1;
        }

        public bool buscarClientePorDNI(long dni)
        {
            string sql = "exec buscarClientePorDNI " + dni;
            DataTable tabla = new DataTable();
            tabla = helper.ConsultaSQL(sql);
            return tabla.Rows.Count == 1;
        }

        public Cliente buscarClientePorID(int id)
        {
            DataTable tabla = helper.ConsultaSQL("exec buscarClientePorID " + id);
            Cliente cliente = new Cliente();
            foreach(DataRow fila in tabla.Rows)
            {
                cliente = mapper(fila);
            }
            return cliente;
        }
        public Cliente buscarClientePorDNI(int dni)
        {
            DataTable tabla = helper.ConsultaSQL("exec buscarClientePorDNI " + dni);
            Cliente cliente = new Cliente();
            foreach (DataRow fila in tabla.Rows)
            {
                cliente = mapper(fila);
            }
            return cliente;
        }

        public bool editarCliente(Cliente cliente)
        {
            string sql = @"exec actualizarCliente " + cliente.IdCliente +", " +
                                               cliente.Dni + ", '" +
                                               cliente.Nombre.ToString() + "', '" +
                                               cliente.Apellido.ToString() + "', '" +
                                               cliente.Calle.ToString() + "', " +
                                               cliente.NroCalle + ", " +
                                               cliente.Telefono + ", " +
                                               cliente.Celular;
            return helper.ejecutarSQL(sql) == 1;
        }

        public IList<Cliente> getClientes()
        {
            string sql = "exec getClientesActivos";
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
