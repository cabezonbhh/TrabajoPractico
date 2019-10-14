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
    public class GeneracionService
    {
        private IDaoGeneracion<Generacion> dao;

        public GeneracionService()
        {
            dao = new GeneracionDaoSqlImp();
        }
        public IList<Generacion> getGeneraciones(int serie)
        {
            return dao.getGeneraciones(serie);
        }
    }
}
