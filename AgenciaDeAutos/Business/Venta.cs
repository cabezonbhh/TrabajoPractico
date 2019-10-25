using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class Venta
    {
        public int AñoVenta { get; set; }
        public int NroVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public DateTime fechaEntrega { get; set; }
        IList<DetalleVenta> Detalles { get; set; }
        public Cliente Cliente { get; set; }

        private void agregarDetalle(DetalleVenta detalle)
        {
            Detalles.Add(detalle);
        }
        public void crearDetalle(int codUnidad, long precioVenta)
        {
            Detalles = new List<DetalleVenta>();
            DetalleVenta detalle = new DetalleVenta();
            detalle.CodUnidad = codUnidad;
            detalle.PrecioVenta = precioVenta;
            agregarDetalle(detalle);
        }
    }
}
