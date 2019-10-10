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
        private int IdFabricante { get; set; }
        private string Nombre { get; set; }
        private IList<Serie> series { get; set; }

        public Fabricante()
        {
            this.IdFabricante = -99;
            this.Nombre = "N/D";
            this.series = new List<Serie>();
        }
    }
}
