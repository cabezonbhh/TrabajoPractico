using AgenciaDeAutos.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Data.Interfaces
{
    public interface IDaoUnidad <U>
    {
        bool nuevaUnidad(U unidad);

        Unidad GetUnidadPorID(int id);

        IList<Unidad> GetUnidades(int fabricante, int serie, int generacion, String nombre);
        IList<Unidad> getUnidadesFiltradas(string filtro);
        IList<Unidad> GetUnidadesPorDni(int dni);
    }
}
