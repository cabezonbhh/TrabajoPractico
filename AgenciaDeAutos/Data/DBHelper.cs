using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using AgenciaDeAutos.Business;

namespace AgenciaDeAutos
{
    //Resumen:
    //      La clase BDHelper permite quitar del código del formulario todo lo relacionado con el acceso a bd.
    //      Permite ejecutar comandos sql y retornar resultados a la capa de datos.
    //      Implementa el patrón SINGLETON, que garantiza tener solo una instancia de esta clase.
    //

    public class DBHelper
    {
        private string string_conexion;
        private static DBHelper instance = new DBHelper();
        private readonly string notebook = "Data Source=Notebook-PC;Initial Catalog=AgenciaDeAutos;Integrated Security=True";
        private readonly string pc = "Data Source=FRANCO-PC;Initial Catalog=AgenciaDeAutos;Integrated Security=True";

        private DBHelper()
        {
            string_conexion = pc;

        }

        public static DBHelper getDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }


        // Resumen:
        //     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        // Devuelve:
        //      un valor entero con el número de filas afectadas por la sentencia ejecutada
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.

        public int ejecutarSQL(string strSql)
        {
            int afectadas = 0;

            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                //comienzo de transaccion...
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                cmd.Transaction = t;
                afectadas = cmd.ExecuteNonQuery();
                //Commit de transacción...
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                MessageBox.Show("EXPLOTO EL HELPER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                this.CloseConnection(cnn);
            }

            return afectadas;
        }

        // Resumen:
        //     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        // Devuelve:
        //      un objeto de tipo DataTable con el resultado de la consulta
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.

        public DataTable ConsultaSQL(string strSql)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("EXPLOTO EL HELPER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }

        // Resumen:
        //      Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
        //      La función recibe por valor una sentencia sql como string y un arreglo de objetos como parámetros
        // Devuelve:
        //      un objeto de tipo DataTable con el resultado de la consulta
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.

        public DataTable ConsultarSQLConParametros(string sqlStr, Object[] prs)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            string n_param;
            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                //IMPORTANTE: cada parametro deberá llamarse: param1, param2,.., paramN
                for (int i = 0; i < prs.Length; i++)
                    if (prs[i] != null)
                    {
                        n_param = "param" + Convert.ToString(i + 1);
                        cmd.Parameters.AddWithValue(n_param, prs[i]);
                    }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("EXPLOTO EL HELPER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw (ex);
            }
            finally
            {
                CloseConnection(cnn);
            }
        }

        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }

        }

        public DataTable ConsultarTabla(string tabla)
        {
            return this.ConsultaSQL("Select * from " + tabla);
        }

        public DataTable ConsultarTablaPerfiles(string tabla)
        {
            return this.ConsultaSQL("Select * from " + tabla + "where idPerfil > 0");
        }
        public int registrarUnidad(string sql)
        {
            int filas = 0;

            SqlConnection conexion = new SqlConnection();
            SqlCommand command = new SqlCommand();

            try
            {
                conexion.ConnectionString = string_conexion;
                conexion.Open();
                command.Connection = conexion;
                command.CommandType = CommandType.Text;
                command.CommandText = sql;               
                filas = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EXPLOTO EL HELPER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filas = 0;
                throw ex;
            }
            finally
            {
                this.CloseConnection(conexion);
            }

            return filas;
        }

        
        public int registrarVenta(string factura, IList<string> detallesSQL)
        {
            int resultado = 0;

            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = factura;
                resultado = cmd.ExecuteNonQuery();
                foreach (string detalle in detallesSQL)
                {
                    cmd.CommandText = detalle;
                    resultado += cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EXPLOTO EL HELPER", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                this.CloseConnection(cnn);
            }

            return resultado;
        }

        public int registrarPostVentaCliente(PostVenta pv)
        {
            int afectadas = 0;

            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
               
                t = cnn.BeginTransaction();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "registrarServiceCliente";
                cmd.Parameters.AddWithValue("@unidad",pv.unidad.CodUnidad);
                cmd.Parameters.AddWithValue("@km", pv.Kmlimite);
                cmd.Transaction = t;
                afectadas = cmd.ExecuteNonQuery();
                //foreach (DetallePostVenta dpv in pv.Detalles)
                //{
                // ARROJA SQL EXCEPTION → EL PROCEDIMIENTO TIENE DEMASIADOS ARGUMENTOS
                //    cmd.CommandText = "registrarDetalleServiceCliente";
                //    cmd.Parameters.AddWithValue("@unidad", pv.unidad.CodUnidad);
                //    cmd.Parameters.AddWithValue("@trabajo", dpv.Job.IdTrabajo);
                //    cmd.Parameters.AddWithValue("@precio", dpv.Precio);
                //    cmd.Parameters.AddWithValue("@descripcion", dpv.Descripcion);
                //    afectadas += cmd.ExecuteNonQuery();
                //}
                cmd.CommandType = CommandType.Text;
                foreach (DetallePostVenta dpv in pv.Detalles)
                {               
                    cmd.CommandText = "registrarDetalleServiceCliente " + pv.unidad.CodUnidad+", " + dpv.Job.IdTrabajo + ", " + dpv.Precio + ", '" + dpv.Descripcion +"'";
                    cmd.Transaction = t;
                    afectadas += cmd.ExecuteNonQuery();
                }
                
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                MessageBox.Show("EXPLOTO EL HELPER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                this.CloseConnection(cnn);
            }

            return afectadas;
        }
        public int registrarPostVentaInterno(PostVenta pv)
        {
            int afectadas = 0;

            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();

                t = cnn.BeginTransaction();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "registrarService";
                cmd.Parameters.AddWithValue("@unidad", pv.unidad.CodUnidad);
                cmd.Parameters.AddWithValue("@km", pv.Kmlimite);
                cmd.Transaction = t;
                afectadas = cmd.ExecuteNonQuery();
                //foreach (DetallePostVenta dpv in pv.Detalles)
                //{
                //    cmd.CommandText = "registrarDetalleServiceCliente";
                //    cmd.Parameters.AddWithValue("@unidad", pv.unidad.CodUnidad);
                //    cmd.Parameters.AddWithValue("@trabajo", dpv.Job.IdTrabajo);
                //    cmd.Parameters.AddWithValue("@precio", dpv.Precio);
                //    cmd.Parameters.AddWithValue("@descripcion", dpv.Descripcion);
                //    afectadas += cmd.ExecuteNonQuery();
                //}
                cmd.CommandType = CommandType.Text;
                foreach (DetallePostVenta dpv in pv.Detalles)
                {
                    cmd.CommandText = "registrarDetalleService " + pv.unidad.CodUnidad + ", " + dpv.Job.IdTrabajo + ", " + dpv.Precio + ", '" + dpv.Descripcion + "'";
                    cmd.Transaction = t;
                    afectadas += cmd.ExecuteNonQuery();
                }

                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                MessageBox.Show("EXPLOTO EL HELPER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                this.CloseConnection(cnn);
            }

            return afectadas;
        }

        public bool actualizarUnidad(Unidad unidad)
        {
            int afectadas = 0;

            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;


            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();

                t = cnn.BeginTransaction();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "actualizarUnidad";
                cmd.Parameters.AddWithValue("@unidad",unidad.CodUnidad);
                cmd.Parameters.AddWithValue("@año",unidad.AñoModelo);
                cmd.Parameters.AddWithValue("@km",unidad.Kilometraje);
                cmd.Parameters.AddWithValue("@patente",unidad.Patente.ToString());
                cmd.Parameters.AddWithValue("@precioVenta",unidad.PrecioVenta);
                cmd.Parameters.AddWithValue("@precioCompra",unidad.PrecioCompra);
                cmd.Parameters.AddWithValue("@potencia",unidad.Potencia);
                cmd.Parameters.AddWithValue("@descripcion",unidad.Descripcion.ToString());
                cmd.Transaction = t;
                afectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                MessageBox.Show("EXPLOTO EL HELPER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                this.CloseConnection(cnn);
            }

            return afectadas > 0;
        }
    }
}
