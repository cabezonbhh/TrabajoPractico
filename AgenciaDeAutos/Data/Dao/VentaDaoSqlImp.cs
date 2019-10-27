using AgenciaDeAutos.Business;
using AgenciaDeAutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Data.Dao
{
    public class VentaDaoSqlImp : IDaoVenta<Venta>
    {
        private DBHelper helper = DBHelper.getDBHelper();
        public IList<Venta> getVentas()
        {
            throw new NotImplementedException();
        }

        public bool registrarVenta(Venta venta)
        {
            string sqlFactura = "exec registrarVenta " + venta.Cliente.IdCliente + ", " + venta.fechaEntrega;
            
            IList<string> detallesSQL = new List<string>();
            IList<DetalleVenta> detalles = new List<DetalleVenta>();
            detalles = venta.Detalles;

            foreach(DetalleVenta detalle in detalles)
            {//cliente,unidad,precioventa
                detallesSQL.Add("exec registrarDetallesVenta " + venta.Cliente.IdCliente + ", " + detalle.CodUnidad + ", " + detalle.PrecioVenta);
            }
            return helper.registrarVenta(sqlFactura, detallesSQL)>1;
        }
    }
}
