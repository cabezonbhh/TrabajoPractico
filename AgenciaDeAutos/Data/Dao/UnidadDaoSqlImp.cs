﻿using AgenciaDeAutos.Business;
using AgenciaDeAutos.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Data.Dao
{
    class UnidadDaoSqlImp : IDaoUnidad<Unidad>
    {
        DBHelper helper = DBHelper.getDBHelper();

        public Unidad GetUnidadPorID(int id)
        {
            Unidad unidad = new Unidad();
            DataTable tabla = helper.ConsultaSQL("exec getUnidadPorID " + id);
            foreach(DataRow fila in tabla.Rows)
            {
                unidad = mapper(fila);
            }
            return unidad;
        }

        public IList<Unidad> GetUnidades(int fabricante, int serie, int generacion, String nombre)
        {
            string sql = "exec getUnidadesPorFiltros " + fabricante.ToString()+", "+serie.ToString()+", "+generacion.ToString()+", '"+nombre+"'";
            DataTable tabla = helper.ConsultaSQL(sql);
            IList<Unidad> unidades = new List<Unidad>();
            foreach(DataRow fila in tabla.Rows)
            {
                unidades.Add(mapper(fila));
            }
            return unidades;
        }

        public bool nuevaUnidad(Unidad unidad)
        {
            string sql = @"exec registrarUnidadCeroKM " + unidad.IdFabricante + ", "
                                                        + unidad.IdSerie + ", "
                                                        + unidad.IdGeneracion +", '"
                                                        + unidad.Nombre.ToString()+"', "
                                                        + unidad.PrecioVenta + ", "
                                                        + unidad.AñoModelo + ", "
                                                        + unidad.Kilometraje + ", "
                                                        + unidad.Potencia + ", '"
                                                        + unidad.Descripcion.ToString()+"', "
                                                        + unidad.PrecioCompra;

            string sql2 = @"exec registrarUnidadUsada " + unidad.IdFabricante + ", "
                                                        + unidad.IdSerie + ", "
                                                        + unidad.IdGeneracion + ", '"
                                                        + unidad.Nombre.ToString() + "', "
                                                        + unidad.PrecioVenta + ", "
                                                        + unidad.AñoModelo + ", "
                                                        + unidad.Kilometraje + ", "
                                                        + unidad.Potencia + ", '"
                                                        + unidad.Descripcion.ToString() + "', '"
                                                        + unidad.Patente.ToString() + "', "
                                                        + unidad.PrecioCompra;
            if(unidad.Kilometraje > 0)
            {
                return helper.registrarUnidad(sql2) > 2;
            }
            else
            {
                return helper.registrarUnidad(sql) > 2;
            }
        }
        private Unidad mapper(DataRow fila)
        {
            Unidad unidad = new Unidad();
            unidad.CodUnidad = Convert.ToInt32(fila["codUnidad"]);
            unidad.IdFabricante = Convert.ToInt32(fila["idfabricante"]);
            unidad.NombreFabricante = fila["NombreFabricante"].ToString();
            unidad.IdSerie = Convert.ToInt32(fila["idSerie"]);
            unidad.NombreSerie = fila["NombreSerie"].ToString();
            unidad.IdGeneracion = Convert.ToInt32(fila["idGeneracion"]);
            unidad.NombreGeneracion = fila["NombreGeneracion"].ToString();
            unidad.Nombre = fila["nombre"].ToString();
            unidad.PrecioVenta = Convert.ToInt64(fila["precioVenta"]);
            unidad.AñoModelo = Convert.ToInt32(fila["añoModelo"]);
            unidad.Kilometraje = Convert.ToInt32(fila["kilometraje"]);
            unidad.Potencia = Convert.ToInt32(fila["potencia"]);
            unidad.Descripcion = fila["descripcion"].ToString();
            unidad.Patente = fila["patente"].ToString();
            unidad.PrecioCompra = Convert.ToInt64(fila["precioCompra"].ToString());
            return unidad;
        }

        public IList<Unidad> getUnidadesFiltradas(string filtro)
        {
            string cadena = "'%"+filtro+"%'";
            string sql = "exec getUnidadesPorNombre " + cadena;
            DataTable tabla = helper.ConsultaSQL(sql);
            IList<Unidad> unidades = new List<Unidad>();
            foreach (DataRow fila in tabla.Rows)
            {
                unidades.Add(mapper(fila));
            }
            return unidades;
        }

        public IList<Unidad> GetUnidadesPorDni(int dni)
        {
            string sql = "exec getUnidadesPorDNI " + dni;
            DataTable tabla = helper.ConsultaSQL(sql);
            IList<Unidad> unidades = new List<Unidad>();
            foreach (DataRow fila in tabla.Rows)
            {
                unidades.Add(mapper(fila));
            }
            return unidades;
        }

        public Unidad getUnidadParaService(int id)
        {
            Unidad unidad = new Unidad();
            DataTable tabla = helper.ConsultaSQL("getUnidadParaService " + id);
            foreach (DataRow fila in tabla.Rows)
            {
                unidad.CodUnidad = Convert.ToInt32(fila["codUnidad"]);
                unidad.NombreFabricante = fila["NombreFabricante"].ToString();
                unidad.NombreGeneracion = fila["NombreGeneracion"].ToString();
                unidad.Nombre = fila["nombre"].ToString();              
                unidad.AñoModelo = Convert.ToInt32(fila["añoModelo"]);            
                unidad.Patente = fila["patente"].ToString();
                unidad.Descripcion = fila["kmLimite"].ToString();           
            }
            return unidad;          
        }

        public IList<Unidad> GetUnidadesPorPatente(string patente)
        {
            string cadena = "'%" + patente + "%'";
            string sql = "exec getUnidadPorPatente " + cadena;
            DataTable tabla = helper.ConsultaSQL(sql);
            IList<Unidad> unidades = new List<Unidad>();
            foreach (DataRow fila in tabla.Rows)
            {
                unidades.Add(mapper(fila));
            }
            return unidades;
        }

        public bool actualizarUnidad(Unidad unidad)
        {
            unidad.Patente = "'"+unidad.Patente.ToString()+"'";
            unidad.Descripcion =  "'" + unidad.Descripcion.ToString() + "'";
            return helper.actualizarUnidad(unidad);
        }
    }
}
