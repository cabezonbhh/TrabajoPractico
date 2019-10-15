using AgenciaDeAutos.Business;
using AgenciaDeAutos.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Data.Dao
{
    class UnidadDaoSqlImp : IDaoUnidad<Unidad>
    {
        DBHelper helper = DBHelper.getDBHelper();
        public bool nuevaUnidad(Unidad unidad)
        {
            string sql = @"exec registrarUnidadCeroKM " + unidad.IdFabricante + ", "
                                                        + unidad.IdSerie + ", "
                                                        + unidad.IdGeneracion +", '"
                                                        + unidad.Nombre.ToString()+"', "
                                                        + unidad.PrecioCompra + ", "
                                                        + unidad.AñoModelo + ", "
                                                        + unidad.Kilometraje + ", "
                                                        + unidad.Potencia + ", '"
                                                        + unidad.Descripcion.ToString()+"'";
            string sql2 = @"exec registrarUnidadUsada " + unidad.IdFabricante + ", "
                                                        + unidad.IdSerie + ", "
                                                        + unidad.IdGeneracion + ", '"
                                                        + unidad.Nombre.ToString() + "', "
                                                        + unidad.PrecioCompra + ", "
                                                        + unidad.AñoModelo + ", "
                                                        + unidad.Kilometraje + ", "
                                                        + unidad.Potencia + ", '"
                                                        + unidad.Descripcion.ToString() + "'";
            if(unidad.Kilometraje > 0)
            {
                return helper.registrarUnidad(sql2) > 2;
            }
            else
            {
                return helper.registrarUnidad(sql) > 2;
            }
        }
    }
}
