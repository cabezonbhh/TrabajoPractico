using AgenciaDeAutos.GUI.Fabricantes;
using AgenciaDeAutos.GUI.PostVentaServices;
using AgenciaDeAutos.GUI.Unidades;
using AgenciaDeAutos.GUI.Vehiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeAutos.GUI.Otros
{
    public partial class frm_main_normal : Form
    {
        public frm_main_normal()
        {
            InitializeComponent();
        }

        private void btn_brands_Click(object sender, EventArgs e)
        {
            Form aux = new frm_menu_fabricantes();
            aux.ShowDialog();
        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            Form aux = new frm_main_unidades();
            aux.ShowDialog();
        }

        private void btn_postVenta_Click(object sender, EventArgs e)
        {
            Form aux = new frm_main_service();
            aux.ShowDialog();
        }
    }
}
