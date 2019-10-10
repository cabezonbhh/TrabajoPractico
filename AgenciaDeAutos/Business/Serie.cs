using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class Serie
    {
        private int IdSerie { get; set; }
        private string Nombre { get; set; }
        private int IdFabricante { get; set; }
        private IList<Generacion> generaciones { get; set; }

        public Serie()
        {
            this.IdSerie = -99;
            this.Nombre = "N/D";
            this.IdFabricante = -99;
            this.generaciones = null;
        }

        public void conocerFabricante(Fabricante fabricante)
        {
            Fabricante aux = new Fabricante();
            getFabricante(aux);
            
        }

        public Fabricante getFabricante(Fabricante aux)
        {
            return aux;
        }

    }
}
