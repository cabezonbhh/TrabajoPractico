using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class Unidad
    {
        public int CodUnidad { get; set; }
        public int IdFabricante { get; set; }
        public int IdSerie { get; set; }
        public int IdGeneracion { get; set; }
        public string Nombre { get; set; }
        public long PrecioCompra { get; set; }
        public int AñoModelo { get; set; }
        public long Kilometraje { get; set; }
        public string Descripcion { get; set; }
        public int Potencia { get; set; }

        public Unidad()
        {
            
        }
    }
}
