﻿using AgenciaDeAutos.Business;
using AgenciaDeAutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeAutos.Data.Dao
{
    public class VentaDaoSqlImp : IDaoVenta<Venta>
    {
        public IList<Venta> getVentas()
        {
            throw new NotImplementedException();
        }
    }
}
