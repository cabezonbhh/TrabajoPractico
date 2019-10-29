using AgenciaDeAutos.Business;
using AgenciaDeAutos.GUI.Ventas;
using AgenciaDeAutos.Properties;
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
    public partial class frm_main_unidades : Form
    {
        private frm_venta venta;
        private double cotizacion;
        private Support.Support support;
        private UnidadService service;
        public frm_main_unidades()
        {
            InitializeComponent();
            support = Support.Support.GetSupport();
            service = new UnidadService();
            pic_unidad.BackColor = Color.Transparent;         
            try
            {
                //pic_unidad.Image = Image.FromFile("C:/Users/Franco/Dropbox/AgenciaDeAutos/Imagenes/Logos/" + logo + ".png");
              
            }
            catch (System.IO.FileNotFoundException)
            {
                pic_unidad.Image = (Image)Resources.NoImage;
            }
        }


        private void frm_main_unidades_Load(object sender, EventArgs e)
        {
            txt_cotizacion.Text = 60.ToString();
            txt_precio_dolar.Text = 0.ToString();
            txt_precio_peso.Text = 0.ToString();
            support.cargarComboFabricante(combo_fabricante);

        }
        public void cargarGrilla(string nombre)
        {
            int fabricante, serie, generacion;
            fabricante = Convert.ToInt32(combo_fabricante.SelectedValue);
            serie = Convert.ToInt32(combo_serie.SelectedValue);
            generacion = Convert.ToInt32(combo_generacion.SelectedValue);
            IList<Unidad> stockUnidades = service.getUnidades(fabricante,serie,generacion ,nombre);
            dgv_stock_unidades.Rows.Clear();
            foreach (Unidad unidad in stockUnidades)
            {
                dgv_stock_unidades.Rows.Add(new object[] {  unidad.CodUnidad.ToString(),unidad.NombreFabricante.ToString(),
                                                            unidad.Nombre.ToString(),unidad.AñoModelo.ToString(),unidad.NombreGeneracion.ToString()
                                                         }
                                            );
            }
        }
        private void add_shopping_Click(object sender, EventArgs e)
        {
            if (dgv_stock_unidades.CurrentRow == null)
            {
                MessageBox.Show("No ha seleccionado ninguna unidad","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                if(venta == null)
                {
                    venta = new frm_venta(cotizacion);
                    venta.Show();
                    venta.addDetail(Convert.ToInt32(dgv_stock_unidades.CurrentRow.Cells["col_id_unidad"].Value.ToString()));
                    dgv_stock_unidades.Rows.RemoveAt(dgv_stock_unidades.CurrentRow.Index);
                }
                else
                {
                   venta.addDetail(Convert.ToInt32(dgv_stock_unidades.CurrentRow.Cells["col_id_unidad"].Value.ToString()));
                   venta.Show();
                   dgv_stock_unidades.Rows.RemoveAt(dgv_stock_unidades.CurrentRow.Index);
                }
            }
        }

        private void txt_cv_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_cv.Text) != true)
            {
                int cv = Convert.ToInt32(txt_cv.Text);
                int hp = Convert.ToInt32(cv * 0.9863);
                txt_hp.Text = hp.ToString();
            }
        }

        private void txt_cotizacion_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txt_precio_dolar.Text)!=true)
            {
                double cotizacion = Convert.ToDouble(txt_cotizacion.Text);
                long dolar = Convert.ToInt64(txt_precio_dolar.Text);
                long peso = Convert.ToInt64(dolar * cotizacion );
                txt_precio_peso.Text = peso.ToString();
            }
        }
        private void cargarDatos(Unidad unidad)
        {
            txt_precio_dolar.Text = unidad.PrecioVenta.ToString();
            txt_km.Text = unidad.Kilometraje.ToString();
            txt_cv.Text = unidad.Potencia.ToString();
            txt_descripcion.Text = unidad.Descripcion.ToString();
            txt_precio_dolar.Text = unidad.PrecioVenta.ToString();
        }
        private void combo_fabricante_SelectionChangeCommitted(object sender, EventArgs e)
        {
            support.cargarComboSerie(combo_serie, Convert.ToInt32(combo_fabricante.SelectedValue));
        }
        private void combo_serie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            support.cargarComboGeneracion(combo_generacion, Convert.ToInt32(combo_serie.SelectedValue));
        }

        private void combo_generacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            support.cargarComboModelo(combo_modelo, Convert.ToInt32(combo_fabricante.SelectedValue),
                                           Convert.ToInt32(combo_serie.SelectedValue),
                                           Convert.ToInt32(combo_generacion.SelectedValue)
                                        );
        }

        private void dgv_stock_unidades_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_stock_unidades.CurrentRow != null)
            {
                Unidad unidad = service.getUnidadPorId(Convert.ToInt32(dgv_stock_unidades.CurrentRow.Cells["col_id_unidad"].Value.ToString()));
                cargarDatos(unidad);
            }
        }

        private void dgv_stock_unidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_stock_unidades.CurrentRow != null)
            {
                Unidad unidad = service.getUnidadPorId(Convert.ToInt32(dgv_stock_unidades.CurrentRow.Cells["col_id_unidad"].Value.ToString()));
                cargarDatos(unidad);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cancelar", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
                this.Dispose();
        }

        private void combo_modelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarGrilla(combo_modelo.Text);
        }
    }
}
