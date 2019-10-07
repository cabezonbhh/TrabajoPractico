using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Business
{
    public class Usuario
    {
        public int Idusuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        internal Perfil Perfil { get; set; }



        public Usuario()
        {
            this.Idusuario = -99;
            this.Nombre = "";
            this.Contraseña = "";
            this.Perfil = null;
        }
        public Usuario(string nombre, string contraseña)
        {
            this.Idusuario = -99;
            this.Nombre = nombre;
            this.Contraseña = contraseña;;
            this.Perfil = null;
        }

        
    }
}
