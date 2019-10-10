using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class Fabricante
    {
        public int IdFabricante { get; set; }
        public string Nombre { get; set; }
        public IList<Serie> series { get; set; }

        public Fabricante()
        {
            this.IdFabricante = -99;
            this.Nombre = "N/D";
            this.series = new List<Serie>();
        }

        public Serie getOneSerie(int id)
        {
            foreach (Serie serie in series)
            {
                if (serie.IdSerie == id)
                {
                    return serie;
                }
            }
            return null;
        }
        public Serie getOneSerie(string nombre)
        {
            foreach (Serie serie in series)
            {
                if (serie.Nombre.Equals(nombre))
                {
                    return serie;
                }
            }
            return null;
        }
        public int getCantidadSeries()
        {
            return series.Count();
        }
    }
}
