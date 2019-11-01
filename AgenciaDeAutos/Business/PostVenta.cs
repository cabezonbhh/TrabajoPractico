using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class PostVenta
    {
        public int IdService { get; set; }
        public Unidad unidad { get; set; }
        public DateTime FechaService { get; set; }
        public IList<DetallePostVenta> Detalles { get; set; }

        public PostVenta()
        {
            this.IdService = -99;
            this.unidad = null;
            this.FechaService = new DateTime();
            this.Detalles = null;
        }

        public long getPrecioTotal()
        {
            long total = 0;
            if(Detalles == null)
            {
                return 0;
            }
            else
            {
                foreach(DetallePostVenta detalle in Detalles)
                {
                    total += detalle.Precio;
                }
                return total;
            }
        }
        private void agregarDetalle(DetallePostVenta detalle)
        {
            Detalles.Add(detalle);
        }
        
        public void crearDetallePostVenta(int idService, int idUnidad, Trabajo trabajo, long precio, string descripcion)
        {
            DetallePostVenta detalle = new DetallePostVenta();
            detalle.IdUnidad = idUnidad;
            detalle.Job = trabajo;
            detalle.Precio = precio;
            detalle.Descripcion = descripcion;
            detalle.IdService = idService;
            agregarDetalle(detalle);
        }
        
    }
}

