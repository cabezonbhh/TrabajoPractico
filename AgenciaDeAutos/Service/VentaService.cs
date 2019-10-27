using AgenciaDeAutos.Business;
using AgenciaDeAutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Service
{
    public class VentaService
    {
        private IDaoVenta<Venta> dao;
        private UnidadService service = new UnidadService();
        public bool registrarVenta(IList<int> detalles, DateTime fecheEntrega)
        {
            Venta venta = new Venta();
            foreach(int detalle in detalles)
            {
                Unidad unidad = service.getUnidadPorId(detalle);
                venta.crearDetalle(unidad.CodUnidad,unidad.PrecioVenta);
            }
            venta.fechaEntrega = fecheEntrega;
            return dao.registrarVenta(venta);
        }
    }
}
