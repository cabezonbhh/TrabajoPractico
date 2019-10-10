using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class Generacion
    {
        public int IdGeneracion { get; set; }
        public string Nombre { get; set; }
        public int IdSerie { get; set; }
        public IList<Modelo> Modelos { get; set; }

        public Generacion()
        {
            this.IdGeneracion = -99;
            this.Nombre = "";
            this.IdSerie = -99;
            this.Modelos = null;
        }

        public Modelo getModelo(string nombre)
        {
            foreach (Modelo modelo in Modelos)
            {
                if (modelo.Nombre.Equals(nombre))
                    return modelo;
            }
            return null;
        }
    }
}
