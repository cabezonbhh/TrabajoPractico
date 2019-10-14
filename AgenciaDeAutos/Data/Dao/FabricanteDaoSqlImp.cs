using AgenciaDeAutos.Business;
using AgenciaDeAutos.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Data.Dao
{
    public class FabricanteDaoSqlImp : IDaoFabricante<Fabricante>
    {
        DBHelper helper = DBHelper.getDBHelper();
        public IList<Fabricante> getFabricantes()
        {
            string sql = "select * from Fabricantes";
            DataTable tabla = helper.ConsultaSQL(sql);
            List<Fabricante> fabricantes = new List<Fabricante>();

            foreach(DataRow fila in tabla.Rows)
            {
                fabricantes.Add(mapper(fila));
            }
            return fabricantes;
        }

        private Fabricante mapper(DataRow fila)
        {
            Fabricante fabricante = new Fabricante();
            fabricante.IdFabricante = Convert.ToInt32(fila[0].ToString());
            fabricante.Nombre = fila[1].ToString();
            return fabricante;
        }
    }
}
