using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class Trabajo
    {
        public int IdTrabajo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public Trabajo()
        {
            this.IdTrabajo = -1;
            this.Titulo = "";
            this.Descripcion = "";
        }
    }
}
