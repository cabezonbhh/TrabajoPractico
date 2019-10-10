using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class Serie
    {
        public int IdSerie { get; set; }
        public string Nombre { get; set; }
        public int IdFabricante { get; set; }
        public IList<Generacion> Generaciones { get; set; }

        public Serie()
        {
            this.IdSerie = -99;
            this.Nombre = "N/D";
            this.IdFabricante = -99;
            this.Generaciones = null;
        }

        public Generacion getGeneracion(int id)
        {
            foreach (Generacion gen in Generaciones)
            {
                if (gen.IdGeneracion == id)
                    return gen;
            }
            return null;
        }

        public Generacion getGeneracion(string nombre)
        {
            foreach (Generacion gen in Generaciones)
            {
                if (gen.Nombre.Equals(nombre))
                    return gen;
            }
            return null;
        }

        public int getCantidadGeneraciones()
        {
            return Generaciones.Count();
        }


    }
}
