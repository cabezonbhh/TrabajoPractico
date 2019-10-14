using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaDeAutos.Support;

namespace AgenciaDeAutos.GUI.Unidades
{
    public partial class frm_new_unidad : Form
    {
        Support.Support support = null;
        public frm_new_unidad()
        {
            InitializeComponent();
            support = Support.Support.GetSupport();
        }

        private void frm_new_unidad_Load(object sender, EventArgs e)
        {
            support.cargarCombo(combo_fab,"Fabricantes","idFabricante","nombre");
        }

        private void combo_fab_SelectionChangeCommitted(object sender, EventArgs e)
        {
            support.cargarComboSerie(combo_serie, Convert.ToInt32(combo_fab.SelectedValue));
        }
        private void combo_serie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            support.cargarComboGeneracion(combo_gen, Convert.ToInt32(combo_serie.SelectedValue));
        }

        private void combo_gen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            support.cargarComboModelo(combo_modelo, Convert.ToInt32(combo_fab.SelectedValue),
                                                    Convert.ToInt32(combo_serie.SelectedValue),
                                                    Convert.ToInt32(combo_gen.SelectedValue)
                                    );
        }
    }
}
