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

namespace AgenciaDeAutos.GUI.Fabricantes
{
    public partial class frm_menu_fabricantes : Form
    {
        public frm_menu_fabricantes()
        {
            InitializeComponent();
        }

        private void btn_audi_Click(object sender, EventArgs e)
        {
            Form aux = new frm_modelo("Audi", "Audi");
            aux.ShowDialog();
        }

        private void btn_bmw_Click(object sender, EventArgs e)
        {
            Form aux = new frm_modelo("Bmw", "BMW");
            aux.ShowDialog();
        }

        private void btn_ferrari_Click(object sender, EventArgs e)
        {
            Form aux = new frm_modelo("Ferrari", "Ferrari");
            aux.ShowDialog();
        }

        private void btn_lamborghini_Click(object sender, EventArgs e)
        {
            Form aux = new frm_modelo("Lamborghini", "Lamborghini");
            aux.ShowDialog();
        }

        private void btn_mercedes_Click(object sender, EventArgs e)
        {
            Form aux = new frm_modelo("Mercedes", "Mercedes Benz");
            aux.ShowDialog();
        }

        private void btn_porsche_Click(object sender, EventArgs e)
        {
            Form aux = new frm_modelo("Porsche", "Porsche");
            aux.ShowDialog();
        }
    }
}
