using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaDeAutos.Data.Interfaces;
using AgenciaDeAutos.Business;
using System.Data;

namespace AgenciaDeAutos.Data.Dao
{
    public class UsuarioDaoSqlImp : IDaoUsuario<Usuario>
    {
        public IList<Usuario> getUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();          
            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL("exec getUsuarios");

            foreach(DataRow fila in tabla.Rows)
            {     
                lista.Add(mapper(fila));
            }
            return lista;
        }

        public Usuario buscarUsuarioPorID(int id)
        {
            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL("exec buscarUsuarioPorId " + id);
            DataRow fila = tabla.Rows[0];
            return mapper(fila);
        }

        public Usuario getUsuarioValidado(string nombre, string contraseña)
        {
            string consulta = "exec getUsuarioValidado '" + nombre + "','" + contraseña + "'";
            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL(consulta);
            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                Usuario usuario = mapper(fila);
                return usuario;
            }
            else
            {

                return null;
            }
        }

        public bool borrarUsuario(int id)
        {
            DBHelper helper = DBHelper.getDBHelper();
            return helper.ejecutarSQL("exec borrarUsuario " + id) == 1;
        }


        public bool nuevoUsuario(Usuario nuevo)
        {
            string consulta = @"exec nuevoUsuario '"+ 
                                nuevo.Nombre.ToString() + "','"+ 
                                nuevo.Contraseña.ToString() + 
                                "'," + nuevo.Perfil.IdPerfil;
            return DBHelper.getDBHelper().ejecutarSQL(consulta) == 1;
       }

        public bool editarUsuario(Usuario usuario)
        {
            DBHelper helper = DBHelper.getDBHelper();
            string sql = @"exec editarUsuario '"+
                            usuario.Nombre.ToString()+"','" +
                            usuario.Contraseña.ToString()+ "',"+
                            usuario.Idusuario+"," +
                            usuario.Perfil.IdPerfil;
            return helper.ejecutarSQL(sql)==1;
        }
        private Usuario mapper(DataRow fila)
        {
            Usuario usuario = null;
            Perfil perfil = null;
            perfil = new Perfil();
            perfil.IdPerfil = Int32.Parse(fila[3].ToString());
            perfil.Nombre = fila[4].ToString();
            usuario = new Usuario();
            usuario.Idusuario = Int32.Parse(fila[0].ToString());
            usuario.Nombre = fila[1].ToString();
            usuario.Contraseña = fila[2].ToString();
            usuario.Perfil = perfil;
            return usuario;
        }

        public bool buscarUsuarioPorNombre(string nombre)
        {
            string sql = @"select u.nombre " +
                         "from Usuarios u " +
                         "where u.nombre like '" + nombre + "'";
            DBHelper helper = DBHelper.getDBHelper();
            DataTable tabla = helper.ConsultaSQL(sql);
            return tabla.Rows.Count == 1;
            
        }

    }
}
