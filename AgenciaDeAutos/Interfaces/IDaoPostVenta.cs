using AgenciaDeAutos.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Interfaces
{
    public interface IDaoPostVenta <Pv>
    {
        IList<PostVenta> getPostVentaPorIdUnidad(int unidad, int borrado);

        bool registrarNuevoServiceCliente(PostVenta pv);
        bool registrarNuevoServiceInterno(PostVenta pv);


    }
}
