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
    class UnidadDaoSqlImp : IDaoUnidad<Unidad>
    {
        DBHelper helper = DBHelper.getDBHelper();

        public string[] GetUnidadParaGrilla(int id)
        {
            string[] unidad = new string[6];
            DataTable tabla = helper.ConsultaSQL("exec getUnidadPorID " + id);
            foreach(DataRow fila in tabla.Rows)
            {
                unidad[0] = fila[0].ToString();
                unidad[1] = fila[1].ToString();
                unidad[2] = fila[2].ToString();
                unidad[3] = fila[3].ToString();
                unidad[4] = fila[4].ToString();
                unidad[5] = fila[5].ToString();
            }
            return null;
        }

        public bool nuevaUnidad(Unidad unidad)
        {
            string sql = @"exec registrarUnidadCeroKM " + unidad.IdFabricante + ", "
                                                        + unidad.IdSerie + ", "
                                                        + unidad.IdGeneracion +", '"
                                                        + unidad.Nombre.ToString()+"', "
                                                        + unidad.PrecioVenta + ", "
                                                        + unidad.AñoModelo + ", "
                                                        + unidad.Kilometraje + ", "
                                                        + unidad.Potencia + ", '"
                                                        + unidad.Descripcion.ToString()+"'";

            string sql2 = @"exec registrarUnidadUsada " + unidad.IdFabricante + ", "
                                                        + unidad.IdSerie + ", "
                                                        + unidad.IdGeneracion + ", '"
                                                        + unidad.Nombre.ToString() + "', "
                                                        + unidad.PrecioVenta + ", "
                                                        + unidad.AñoModelo + ", "
                                                        + unidad.Kilometraje + ", "
                                                        + unidad.Potencia + ", '"
                                                        + unidad.Descripcion.ToString() + "', '"
                                                        + unidad.Patente.ToString() + "'";
            if(unidad.Kilometraje > 0)
            {
                return helper.registrarUnidad(sql2) > 2;
            }
            else
            {
                return helper.registrarUnidad(sql) > 2;
            }
        }
        private Unidad mapper(DataRow fila)
        {
            Unidad unidad = new Unidad();
            unidad.CodUnidad = Convert.ToInt32(fila[0]);
            unidad.IdFabricante = Convert.ToInt32(fila[1]);
            unidad.IdSerie = Convert.ToInt32(fila[2]);
            unidad.IdGeneracion = Convert.ToInt32(fila[3]);
            unidad.Nombre = fila[4].ToString();
            unidad.PrecioVenta = Convert.ToInt64(fila[5]);
            unidad.AñoModelo = Convert.ToInt32(fila[6]);
            unidad.Kilometraje = Convert.ToInt32(fila[7]);
            unidad.Potencia = Convert.ToInt32(fila[8]);
            unidad.Descripcion = fila[9].ToString();
            unidad.Patente = fila[11].ToString();
            return unidad;
        }
    }
}
