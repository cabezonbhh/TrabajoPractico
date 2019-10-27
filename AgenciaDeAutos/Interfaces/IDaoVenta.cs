using AgenciaDeAutos.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Interfaces
{
    public interface IDaoVenta<V>
    {
        IList<V> getVentas();

        bool registrarVenta(Venta venta);
    }
}
