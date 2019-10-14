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
    public class ModeloService
    {
        private IDaoModelo<Modelo> dao;

        public ModeloService()
        {
            dao = new ModeloDaoSqlImp();
        }

        public IList<Modelo> getModelos(int fabricante, int serie, int generacion)
        {
            return dao.getModelos(fabricante,serie,generacion);
        }
        public IList<string> getModelosString(int fabricante, int serie, int generacion)
        {
            return dao.getModelosString(fabricante, serie, generacion);
        }
    }
}
