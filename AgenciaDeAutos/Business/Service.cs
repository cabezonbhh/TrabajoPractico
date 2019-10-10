using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class Service
    {
        public int IdService { get; set; }
        public Unidad unidad { get; set; }
        public DateTime FechaService { get; set; }
        public IList<DetalleService> Detalles { get; set; }

        public Service()
        {
            this.IdService = -99;
            this.unidad = null;
            this.FechaService = new DateTime();
            this.Detalles = null;
        }


        
    }
}

