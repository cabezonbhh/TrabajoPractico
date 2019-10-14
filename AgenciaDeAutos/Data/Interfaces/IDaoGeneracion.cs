using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Data.Interfaces
{
    public interface IDaoGeneracion <G>
    {
        IList<G> getGeneraciones(int id);
    }
}
