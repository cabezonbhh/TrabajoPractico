using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    class Generacion
    {
        private int IdGeneracion { get; set; }
        private string Nombre { get; set; }
        private int IdSerie { get; set; }
        private IList<StockModelo> Stock { get; set; }

        public Generacion()
        {
            this.IdGeneracion = -99;
            this.Nombre = "";
            this.IdSerie = -99;
            this.Stock = null;
        }
    }
}
