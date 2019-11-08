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

        public IList<Unidad> getUnidades(int fabricante, int serie, int generacion, string nombre)
        {
            return dao.GetUnidades(fabricante, serie, generacion, nombre);
        }

        public IList<Unidad> getUnidadesFiltradas(string filtro)
        {
            return dao.getUnidadesFiltradas(filtro);
        }
        public IList<Unidad> GetUnidadesPorDni(int dni)
        {
            return dao.GetUnidadesPorDni(dni);
        }
        public IList<Unidad> GetUnidadesPorPatente(string patente)
        {
            return dao.GetUnidadesPorPatente(patente);
        }

        public bool nuevaUnidad(int fabricante, int serie, int generacion, string nombre, long precioVenta, long precioCompra, int año, int km, int potencia, string descripcion,string patente)
        {
            Unidad unidad = new Unidad();
            unidad.IdFabricante = fabricante;
            unidad.IdSerie = serie;
            unidad.IdGeneracion = generacion;
            unidad.Nombre = nombre;
            unidad.PrecioVenta = precioVenta;
            unidad.PrecioCompra = precioCompra;
            unidad.AñoModelo = año;
            unidad.Kilometraje = km;
            unidad.Potencia = potencia;
            unidad.Descripcion = descripcion;
            unidad.Patente = patente;
            return dao.nuevaUnidad(unidad);
        }
        public bool nuevaUnidad(int fabricante, int serie, int generacion, string nombre, long precioVenta, long precioCompra, int año, int km, int potencia, string descripcion)
        {
            Unidad unidad = new Unidad();
            unidad.IdFabricante = fabricante;
            unidad.IdSerie = serie;
            unidad.IdGeneracion = generacion;
            unidad.Nombre = nombre;
            unidad.PrecioVenta = precioVenta;
            unidad.PrecioCompra = precioCompra;
            unidad.AñoModelo = año;
            unidad.Kilometraje = km;
            unidad.Potencia = potencia;
            unidad.Descripcion = descripcion;
            return dao.nuevaUnidad(unidad);
        }

        public Unidad getUnidadParaService(int id)
        {
            return dao.getUnidadParaService(id);
        }
    }
}
