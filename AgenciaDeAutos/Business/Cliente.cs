using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public long Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public long Telefono { get; set; }
        public long Celular { get; set; }
        public IList<Unidad> vehiculos { get; set; }

        public Cliente()
        {
            this.IdCliente = -99;
            this.Dni = -99;
            this.Nombre = "";
            this.Apellido = "";
            this.Calle = "";
            this.NroCalle = -99;
            this.Telefono = -99;
            this.Celular = -99;
            this.vehiculos = null;
        }
    }

}
