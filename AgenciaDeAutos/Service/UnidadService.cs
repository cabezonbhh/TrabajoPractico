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
        private int seleccionado;

        public UnidadService()
        {
            dao = new UnidadDaoSqlImp();
        }
        public Unidad getUnidadPorId(int id)
        {                  
            return dao.GetUnidadPorID(id); 
        }

        public IList<Unidad> getUnidades(string nombre)
        {
            return dao.GetUnidades(nombre);
        }

        public bool nuevaUnidad(int fabricante, int serie, int generacion, string nombre, long precio, int año, int km, int potencia, string descripcion)
        {
            Unidad unidad = new Unidad();
            unidad.IdFabricante = fabricante;
            unidad.IdSerie = serie;
            unidad.IdGeneracion = generacion;
            unidad.Nombre = nombre;
            unidad.PrecioVenta = precio;
            unidad.AñoModelo = año;
            unidad.Kilometraje = km;
            unidad.Potencia = potencia;
            unidad.Descripcion = descripcion;
            return dao.nuevaUnidad(unidad);
        }
        public bool nuevaUnidad(int fabricante, int serie, int generacion, string nombre, long precio, int año, int km, int potencia, string descripcion,string patente)
        {
            Unidad unidad = new Unidad();
            unidad.IdFabricante = fabricante;
            unidad.IdSerie = serie;
            unidad.IdGeneracion = generacion;
            unidad.Nombre = nombre;
            unidad.PrecioVenta = precio;
            unidad.AñoModelo = año;
            unidad.Kilometraje = km;
            unidad.Potencia = potencia;
            unidad.Descripcion = descripcion;
            unidad.Patente = patente;
            return dao.nuevaUnidad(unidad);
        }
    }
}
