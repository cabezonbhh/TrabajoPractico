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
        public string NombreFabricante { get; set; }
        public int IdSerie { get; set; }
        public string NombreSerie { get; set; }
        public int IdGeneracion { get; set; }
        public string NombreGeneracion { get; set; }
        public string Nombre { get; set; }
        public long PrecioVenta { get; set; }
        public long PrecioCompra { get; set; }
        public int AñoModelo { get; set; }
        public long Kilometraje { get; set; }
        public string Descripcion { get; set; }
        public int Potencia { get; set; }
        public string Patente { get; set; }

        public Cliente Dueño { get; set; }

        public Unidad()
        {
            this.CodUnidad = -99;
            this.IdFabricante = -99;
            this.NombreFabricante = "";
            this.IdSerie = -99;
            this.NombreSerie = "";
            this.IdGeneracion = -99;
            this.NombreGeneracion = "";
            this.Nombre = "";
            this.PrecioVenta = -99;
            this.AñoModelo = -99;
            this.Kilometraje = -99;
            this.Descripcion = "";
            this.Potencia = -99;
            this.Patente = "N/D";
            this.Dueño = null;
        }
    }
}
