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
        private string validarCampos()
        {
            if (String.IsNullOrWhiteSpace(txt_año_modelo.Text))
            {
                return "año";
            }
            if (String.IsNullOrWhiteSpace(txt_descripcion.Text))
            {
                return "descripcion";
            }
            if (String.IsNullOrWhiteSpace(txt_km.Text))
            {
                return "kilometros";
            }
            if (String.IsNullOrWhiteSpace(txt_potencia_cv.Text))
            {
                return "potencia";
            }
            if (String.IsNullOrWhiteSpace(txt_precio_compra.Text))
            {
                return "precio de compra";
            }
           
            return null;
        }

        private void txt_potencia_cv_TextChanged(object sender, EventArgs e)
        {
            //int cv = Convert.ToInt32(txt_potencia_hp.Text);
            //int hp = Convert.ToInt32(cv * 0.9863);
            //txt_potencia_hp.Text = hp.ToString();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //public int CodUnidad { get; set; }
            //public int IdFabricant { get; set; }
            //public int IdSerie { get; set; }
            //public int IdGeneracion { get; set; }
            //public string Nombre { get; set; }
            //public long PrecioCompra { get; set; }
            //public int AñoModelo { get; set; }
            //public long Kilometraje { get; set; }
            //public string Descripcion { get; set; }
            //public int Potencia { get; set; }


        }
    }
}
