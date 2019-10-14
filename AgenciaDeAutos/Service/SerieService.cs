using AgenciaDeAutos.Business;
using AgenciaDeAutos.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaDeAutos.Data.Dao;

namespace AgenciaDeAutos.Service
{
    public class SerieService
    {
        private IDaoSerie<Serie> dao;

        public SerieService()
        {
            dao = new SerieDaoSqlImp();
        }
        public IList<Serie> getSeries(int serie)
        {
            return dao.getSeries(serie);
        }
    }
}
