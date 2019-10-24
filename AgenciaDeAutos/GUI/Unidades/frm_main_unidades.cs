using AgenciaDeAutos.GUI.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeAutos.GUI.Unidades
{
    public partial class frm_main_unidades : Form
    {
        private frm_venta venta;
        private int seleccionado;
        private double cotizacion;
        public frm_main_unidades()
        {
            InitializeComponent();
        }


        private void frm_main_unidades_Load(object sender, EventArgs e)
        {
            txt_cotizacion.Text = 60.ToString();
        }

        private void add_shopping_Click(object sender, EventArgs e)
        {
            if (venta == null)
            {           
                venta = new frm_venta(Convert.ToDouble(txt_cotizacion.Text));
                venta.addDetail(seleccionado);
            }
            else
            {
                venta.addDetail(seleccionado);
            }
        }
    }
}
