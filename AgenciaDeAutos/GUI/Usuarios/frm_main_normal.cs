﻿using AgenciaDeAutos.GUI.Fabricantes;
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

        private void gestionNegocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aux = null;
        }
    }
}
