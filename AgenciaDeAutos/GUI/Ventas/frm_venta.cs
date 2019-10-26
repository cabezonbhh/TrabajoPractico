using AgenciaDeAutos.Business;
using AgenciaDeAutos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeAutos.GUI.Ventas
{
    public partial class frm_venta : Form
    {
        public UnidadService service = null;
        private double cotizacion;
        long total = 0;
        long peso;
        public frm_venta(double cotizacion)
        {
            InitializeComponent();
            service = new UnidadService();
            this.cotizacion = cotizacion;
        }
        public void addDetail(int idUnidad)
        {   
            Unidad unidad = service.getUnidadPorId(idUnidad);
            peso = Convert.ToInt64(unidad.PrecioVenta * (long)cotizacion);
            dgv_details.Rows.Add(new object[]
            {
                unidad.CodUnidad.ToString(),
                unidad.NombreFabricante.ToString(),
                unidad.Nombre.ToString(),
                unidad.AñoModelo.ToString(),
                unidad.NombreGeneracion.ToString(),
                unidad.PrecioVenta.ToString(),
                peso.ToString()
            });
            total+= Convert.ToInt64(unidad.PrecioVenta);
            txt_total_dolar.Text = total.ToString();
            txt_total_peso.Text = (total * cotizacion).ToString();
        }

        private void frm_venta_Load(object sender, EventArgs e)
        {
            txt_cotizacion.Text = cotizacion.ToString();
            txt_cotizacion.ForeColor = Color.Red;
            txt_cotizacion.Enabled = false;
            txt_total_peso.Text = total.ToString();
            txt_total_dolar.Text = total.ToString();
        }

       
    }
}
