using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaDeAutos.Service;
using AgenciaDeAutos.Support;

namespace AgenciaDeAutos.GUI.Unidades
{
    public partial class frm_new_unidad : Form
    {
        Support.Support support = null;
        UnidadService service = new UnidadService();
        public frm_new_unidad()
        {
            InitializeComponent();
            support = Support.Support.GetSupport();
        }
        public frm_new_unidad(int id)
        {
            InitializeComponent();
            support = Support.Support.GetSupport();
        }
        private void frm_new_unidad_Load(object sender, EventArgs e)
        {
            support.cargarCombo(combo_fab,"Fabricantes","idFabricante","nombre");
            txt_patente.Enabled = false;
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
            if (String.IsNullOrWhiteSpace(txt_precio_compra.Text))
            {
                return "precio de compra";
            }
            return null;
        }

        private void txt_potencia_cv_TextChanged(object sender, EventArgs e)
        {
            //double cv = Convert.ToDouble(((TextBox)sender).Text);
            if(String.IsNullOrWhiteSpace(txt_potencia_cv.Text)!=true)
            {
                int cv = Convert.ToInt32(txt_potencia_cv.Text);
                int hp = Convert.ToInt32(cv * 0.9863);
                txt_potencia_hp.Text = hp.ToString();
            }
            
        }
        

        private void btn_register_Click(object sender, EventArgs e)
        {
            bool flag;
            if (validarCampos() != null)
            {
                {
                    MessageBox.Show("Ha dejado el campo " + validarCampos() + " vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                int fabricante = Convert.ToInt32(combo_fab.SelectedValue);
                int serie = Convert.ToInt32(combo_serie.SelectedValue);
                int generacion = Convert.ToInt32(combo_gen.SelectedValue);
                string nombre = combo_modelo.Text;
                long precio = Convert.ToInt64(txt_precio_compra.Text); 
                int año = Convert.ToInt32(txt_año_modelo.Text);
                int km = Convert.ToInt32(txt_km.Text);
                int potencia = Convert.ToInt32(txt_potencia_cv.Text);
                string descripcion = txt_descripcion.Text;
                if(km > 0)
                {
                    if(String.IsNullOrWhiteSpace(txt_patente.Text))
                    {
                        MessageBox.Show("No ingreso una patente valida", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = false;
                    }
                    else
                    {
                        string patente = txt_patente.Text;
                        flag = service.nuevaUnidad(fabricante, serie, generacion, nombre, precio, año, km, potencia, descripcion, patente);
                    }
                    
                }                   
                else
                {
                    flag = service.nuevaUnidad(fabricante, serie, generacion, nombre, precio, año, km, potencia, descripcion);
                }
                if (flag == true)
                    MessageBox.Show("Unidad registrada con exito", "Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Hubo un problema al registrar la unidad, revise los datos e intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void check_edit_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_patente.Enabled == false)
                txt_patente.Enabled = true;
            else
                txt_patente.Enabled = false;
        }
    }
}
