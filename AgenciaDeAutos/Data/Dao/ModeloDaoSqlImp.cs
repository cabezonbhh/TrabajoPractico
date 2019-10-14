using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaDeAutos.Business;
using AgenciaDeAutos.Data.Interfaces;

namespace AgenciaDeAutos.Data.Dao
{
    public class ModeloDaoSqlImp : IDaoModelo<Modelo>
    {
        DBHelper helper = DBHelper.getDBHelper();
        public IList<Modelo> getModelos(int fabricante, int serie, int generacion)
        {
            string sql = "exec getModelos " + fabricante +", " + serie + ", " + generacion ;
            List<Modelo> modelos = new List<Modelo>();
            DataTable tabla = helper.ConsultaSQL(sql);

            foreach(DataRow fila in tabla.Rows)
            {
                modelos.Add(mapper(fila));
            }
            return modelos;
        }
        public IList<string> getModelosString(int fabricante, int serie, int generacion)
        {
            string sql = "exec getModelos " + fabricante + ", " + serie + ", " + generacion;
            List<string> modelos = new List<string>();
            DataTable tabla = helper.ConsultaSQL(sql);

            foreach (DataRow fila in tabla.Rows)
            {              
                modelos.Add(mapper(fila).Nombre);
            }
            return modelos;
        }
        public Modelo mapper(DataRow fila)
        {
            Modelo modelo = new Modelo();
            modelo.Idfabricante = Convert.ToInt32(fila[0].ToString());
            modelo.IdSerie = Convert.ToInt32(fila[1].ToString());
            modelo.IdGeneracion = Convert.ToInt32(fila[2].ToString());
            modelo.Nombre = fila[3].ToString();
            modelo.Descripcion = fila[4].ToString();
            modelo.PrecioSugerido = Convert.ToInt64(fila[5].ToString());
            return modelo;
        }
    }
}
