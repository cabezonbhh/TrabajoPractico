using AgenciaDeAutos.Business;
using AgenciaDeAutos.Data.Dao;
using AgenciaDeAutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Service
{
    public class PostVentaService
    {
        private IDaoPostVenta<PostVenta> dao;

        public PostVentaService()
        {
            dao = new PostVentaDaoSqlImp();
        }

        public IList<PostVenta> GetPostVentasPorID(int id)
        {
            return dao.getPostVentaPorIdUnidad(id,"''","''",1);
        }

        public bool registrarService(PostVenta service)
        {
            return dao.registrarNuevoService(service);
        }

        
    }
}
