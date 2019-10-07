using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class Perfil
    {
        public int IdPerfil { get; set; }
        public string Nombre { get; set; }

        public Perfil()
        {
            this.IdPerfil = -99;
            this.Nombre = "";
        }
        public Perfil(int id)
        {
            this.IdPerfil = id;
        }
    }
}
