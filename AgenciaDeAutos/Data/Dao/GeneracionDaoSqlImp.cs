using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaDeAutos.Business;
using AgenciaDeAutos.Data.Interfaces;

namespace AgenciaDeAutos.Data.Dao
{
    public class GeneracionDaoSqlImp : IDaoGeneracion<Generacion>
    {
        DBHelper helper = DBHelper.getDBHelper();
        public IList<Generacion> getGeneraciones(int id)
        {
            string sql = "select * from Generaciones g where g.idSerie = "+id;
            DataTable tabla = helper.ConsultaSQL(sql);
            List<Generacion> generaciones = new List<Generacion>();

            foreach(DataRow fila in tabla.Rows)
            {
                generaciones.Add(mapper(fila));
            }
            return generaciones;
        }

        private Generacion mapper(DataRow fila)
        {
            Generacion generacion = new Generacion();
            generacion.IdGeneracion = Convert.ToInt32(fila[0].ToString());
            generacion.Nombre = fila[1].ToString();
            generacion.IdSerie = Convert.ToInt32(fila[2].ToString());
            return generacion;
        }
    }
}
