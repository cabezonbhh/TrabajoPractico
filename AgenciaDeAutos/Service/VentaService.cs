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
    public class VentaService
    {
        private IDaoVenta<Venta> dao;
        private UnidadService service = new UnidadService();
        private ClienteService cservice = new ClienteService();

        public VentaService()
        {
            dao = new VentaDaoSqlImp();
        }
        public bool registrarVenta(int dni, IList<int> detalles, DateTime fecheEntrega)
        {
            Cliente cliente = cservice.traerClientePorDni(dni);
            Venta venta = new Venta();
            venta.Cliente = cliente;
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
