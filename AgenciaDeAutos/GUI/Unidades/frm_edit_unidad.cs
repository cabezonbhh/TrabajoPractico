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

namespace AgenciaDeAutos.GUI.Unidades
{
    public partial class frm_edit_unidad : Form
    {
        private Unidad unit;
        private UnidadService service = null;
        private Support.Support support = null;
        public frm_edit_unidad(Unidad origen)
        {
            service = new UnidadService();
            support = Support.Support.GetSupport();
            this.unit = origen;
            InitializeComponent();
        }

        private void frm_edit_unidad_Load(object sender, EventArgs e)
        {
            llenarCampos();
        }

        private void llenarCampos()
        {
            txt_año_modelo.Text = unit.AñoModelo.ToString();
            txt_km.Text = unit.Kilometraje.ToString();
            txt_patente.Text =unit.Patente.ToString();
            txt_precio_compra.Text = unit.PrecioCompra.ToString();
            txt_precio_venta.Text = unit.PrecioVenta.ToString();
            txt_potencia_cv.Text = unit.Potencia.ToString();      
            txt_descripcion.Text = unit.Descripcion.ToString();
            int cv = Convert.ToInt32(txt_potencia_cv.Text);
            int hp = Convert.ToInt32(cv * 0.9863);
            txt_potencia_hp.Text = hp.ToString();
        }
        private void tomarDatos()
        {

            unit.AñoModelo = Convert.ToInt32(txt_año_modelo.Text);
            unit.Kilometraje = Convert.ToInt64(txt_km.Text);
            unit.Patente = txt_patente.Text;
            unit.PrecioCompra = Convert.ToInt64(txt_precio_compra.Text);
            unit.PrecioVenta = Convert.ToInt64(txt_precio_venta.Text);
            unit.Potencia = Convert.ToInt32(txt_potencia_cv.Text);
            unit.Descripcion = txt_descripcion.Text;
            
        }
        private void txt_potencia_cv_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_potencia_cv.Text) != true)
            {
                int cv = Convert.ToInt32(txt_potencia_cv.Text);
                int hp = Convert.ToInt32(cv * 0.9863);
                txt_potencia_hp.Text = hp.ToString();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (validarCampos() == null)
            {
                tomarDatos();
                bool retorno = service.actualizarUnidad(unit);
                if(retorno == true)
                    MessageBox.Show("La unidad ha sido modificada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Hubo un problema al modificar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ha dejado vacio el campo " + validarCampos(), "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


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
            if (String.IsNullOrWhiteSpace(txt_precio_venta.Text))
            {
                return "precio de venta";
            }
            if (String.IsNullOrWhiteSpace(txt_precio_compra.Text))
            {
                return "precio de compra";
            }
            return null;
        }

        private void txt_año_modelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender,e);
        }

        private void txt_precio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender, e);
        }

        private void txt_precio_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender, e);
        }

        private void txt_potencia_cv_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender, e);
        }

        private void txt_km_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender, e);
        }

        private void txt_patente_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloLetrasNumeros(sender, e);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea salir?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
                this.Dispose();

        }
    }
}
