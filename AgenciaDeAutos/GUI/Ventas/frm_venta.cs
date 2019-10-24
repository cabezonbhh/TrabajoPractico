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
            this.cotizacion = cotizacion;
        }
        public void addDetail(int idUnidad)
        {   //Orden del vector: idUnidad/modelo/añoModelo/precioVenta/fabricante/generacion
            //                      0       1       2           3           4           5
            string[] unidad = service.getUnidadParaGrilla(idUnidad);
            //orden grilla = id/fabricante/modelo/año/generacion/precio
            //0      4       1      2        5       3
            peso = Convert.ToInt64(unidad[3]) * (long)cotizacion;
            dgv_details.Rows.Add(new object[]
            {
                unidad[0].ToString(),
                unidad[4].ToString(),
                unidad[1].ToString(),
                unidad[2].ToString(),
                unidad[5].ToString(),
                unidad[3].ToString(),
                peso.ToString()
            });
            total+= Convert.ToInt64(unidad[3]);
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
