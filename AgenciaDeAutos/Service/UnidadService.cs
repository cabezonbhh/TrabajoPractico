using AgenciaDeAutos.Business;
using AgenciaDeAutos.Data;
using AgenciaDeAutos.Data.Dao;
using AgenciaDeAutos.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Service
{
    public class UnidadService
    {
        private IDaoUnidad <Unidad> dao;

        public UnidadService()
        {
            dao = new UnidadDaoSqlImp();
        }

        public bool nuevaUnidad(int fabricante, int serie, int generacion, string nombre, long precio, int año, int km, int potencia, string descripcion)
        {
            Unidad unidad = new Unidad();
            unidad.IdFabricante = fabricante;
            unidad.IdSerie = serie;
            unidad.IdGeneracion = generacion;
            unidad.Nombre = nombre;
            unidad.PrecioCompra = precio;
            unidad.AñoModelo = año;
            unidad.Kilometraje = km;
            unidad.Potencia = potencia;
            unidad.Descripcion = descripcion;
            return dao.nuevaUnidad(unidad);
        }
    }
}
