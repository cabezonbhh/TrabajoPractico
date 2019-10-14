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
    public class SerieDaoSqlImp : IDaoSerie<Serie>
    {
        DBHelper helper = DBHelper.getDBHelper();
        public IList<Serie> getSeries(int id)
        {
            string sql = "select * from Series s where s.idFabricante = " + id;
            DataTable tabla = helper.ConsultaSQL(sql);
            List <Serie> series = new List<Serie>();

            foreach(DataRow fila in tabla.Rows)
            {
                series.Add(mapper(fila));
            }
            return series;
        }

        public Serie mapper(DataRow fila)
        {
            Serie serie = new Serie();
            serie.IdSerie = Convert.ToInt32(fila[0].ToString());
            serie.Nombre = fila[1].ToString();
            serie.IdFabricante = Convert.ToInt32(fila[2].ToString());
            return serie;
        }

    }
}
