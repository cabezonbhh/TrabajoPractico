using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Data.Interfaces
{
    public interface IDaoModelo <M>
    {
        IList<M> getModelos(int fabricante, int serie, int generacion);

        IList<string> getModelosString(int fabricante, int serie, int generacion);
    }
}
