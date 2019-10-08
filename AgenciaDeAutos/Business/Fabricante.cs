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
        int IdFabricante { get; set; }
        string Nombre { get; set; }
        List<Serie> series { get; set; }

        public Fabricante()
        {
            this.IdFabricante = -99;
            this.Nombre = "N/D";
            this.series = new List<Serie>();
        }
    }
}
