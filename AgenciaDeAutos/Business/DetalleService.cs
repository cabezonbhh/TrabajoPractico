using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class DetalleService
    {
        public int IdService { get; set; }
        public int IdUnidad { get; set; }
        public Trabajo Job { get; set; }
        public double Precio { get; set; }

        public DetalleService(Trabajo job)
        {
            this.IdService = -99;
            this.IdUnidad = -99;
            this.Job = job;
            this.Precio = -99;
        }
    }
}
