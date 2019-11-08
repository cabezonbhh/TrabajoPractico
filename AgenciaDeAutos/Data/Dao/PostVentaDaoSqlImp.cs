using AgenciaDeAutos.Business;
using AgenciaDeAutos.Interfaces;
using AgenciaDeAutos.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Data.Dao
{
    public class PostVentaDaoSqlImp : IDaoPostVenta<PostVenta>
    {
        private UnidadService uService = new UnidadService();
        private DBHelper helper = DBHelper.getDBHelper();
        public IList<PostVenta> getPostVentaPorIdUnidad(int unidad, int borrado)
        {
            //para el detalle--→ int idService, int idUnidad, Trabajo trabajo, long precio, string descripcion
            string descripcion;
            long precio;
            Trabajo job = new Trabajo();
            string sqlService = "Exec getServicePorFiltro " + unidad + ", " + borrado;
            IList<PostVenta> listaServices = new List<PostVenta>();
            DataTable tablaService = helper.ConsultaSQL(sqlService);
            PostVenta post = null;

            foreach(DataRow fila in tablaService.Rows)
            {
                post = mapper(fila);
                DataTable tablaDetalle = helper.ConsultaSQL("Exec getDetallesPorService " + post.IdService + ", " + unidad);
                foreach(DataRow filaDetalle in tablaDetalle.Rows)
                {
                    job.IdTrabajo = Convert.ToInt32(filaDetalle["idTrabajo"].ToString());
                    job.Titulo = filaDetalle["nombre"].ToString();
                    job.Descripcion = filaDetalle["descripcion"].ToString();
                    precio = Convert.ToInt64(filaDetalle["precios"].ToString());
                    descripcion = filaDetalle["detalleDescripcion"].ToString();
                    post.crearDetallePostVenta(post.IdService,post.unidad.CodUnidad,job, precio,descripcion);
                }
                listaServices.Add(post);
            }
            return listaServices;
        }

      

        public bool registrarNuevoServiceCliente(PostVenta pv)
        {
            return helper.registrarPostVentaCliente(pv) > 0;
        }

        public bool registrarNuevoServiceInterno(PostVenta pv)
        {
            return helper.registrarPostVentaInterno(pv) > 0; ;
        }

        private PostVenta mapper(DataRow fila)
        {        
            PostVenta service = new PostVenta();
            service.IdService = Convert.ToInt32(fila["codService"].ToString());
            service.unidad = uService.getUnidadPorId(Convert.ToInt32(fila["codUnidad"].ToString()));
            service.FechaService = Convert.ToDateTime(fila["fechaService"].ToString());
            service.Kmlimite = Convert.ToInt64(fila["kmLimite"].ToString());
            return service;
        }


    }
}
