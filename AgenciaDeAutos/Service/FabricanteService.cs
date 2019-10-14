using AgenciaDeAutos.Business;
using AgenciaDeAutos.Data.Dao;
using AgenciaDeAutos.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Service
{
    public class FabricanteService
    {
        private IDaoFabricante<Fabricante> dao;

        public FabricanteService()
        {
            dao = new FabricanteDaoSqlImp();
        }
        public IList<Fabricante> getFabricante()
        {
            return dao.getFabricantes();
        }
            
    }
}
