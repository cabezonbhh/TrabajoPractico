using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class DetallePostVenta
    {
        public int IdService { get; set; }
        public int IdUnidad { get; set; }
        public Trabajo Job { get; set; }
        public long Precio { get; set; }
        public string Descripcion { get; set; }


        public DetallePostVenta()
        {
            this.IdService = -99;
            this.IdUnidad = -99;
            this.Job = null;
            this.Precio = -99;
            this.Descripcion = "";
        }
    }
}
