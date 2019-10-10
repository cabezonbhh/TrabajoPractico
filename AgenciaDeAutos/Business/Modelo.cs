using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class Modelo
    {
        public int Idfabricante { get; set; }
        public int IdSerie { get; set; }
        public int IdGeneracion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public double PrecioSugerido { get; set; }

        public Modelo()
        {
            this.Idfabricante = -99;
            this.IdSerie = -99;
            this.IdGeneracion = -99;
            this.Nombre = "N/D";
            this.Descripcion = "N/D";
            this.PrecioSugerido = -99;
        }


    }
}
