using AgenciaDeAutos.Business;
using AgenciaDeAutos.GUI.Unidades;
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

namespace AgenciaDeAutos.GUI.Vehiculos
{
    public partial class frm_modelo : Form
    {
        private int fabricante;
        private UnidadService service;
        public frm_modelo(string logo, string titulo)
        {
            InitializeComponent();
            pic_logo.BackColor = Color.Transparent;
            Random random = new Random();
            this.Text = titulo;
            int i = random.Next(1, 8);
            switch(titulo)
            {
                case "Audi":
                    fabricante = 1;
                    break;
                case "BMW":
                    fabricante = 2;
                    break;
                case "Ferrari":
                    fabricante = 3;
                    break;
                case "Lamborghini":
                    fabricante = 4;
                    break;
                case "Mercedes Benz":
                    fabricante = 5;
                    break;
                case "Porsche":
                    fabricante = 6;
                    break;
            }
            try
            {
                pic_logo.Image = Image.FromFile("C:/Users/Franco/Dropbox/AgenciaDeAutos/Imagenes/Logos/" + logo+".png");
                BackgroundImage = Image.FromFile("C:/Users/Franco/Dropbox/AgenciaDeAutos/Imagenes/Fondos/" + logo +" ("+i+")" + ".jpg");
            }
            catch(System.IO.FileNotFoundException)
            {
                pic_vehiculo.Image = (Image)Resources.NoImage;
                BackgroundImage = (Image)Resources.NoImage;
            }
        }

        private void txt_cotizacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_modelo_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cancelar", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
                this.Dispose();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            
        }
        public void cargarGrilla(string nombre)
        {
            int serie, generacion;;
            serie = Convert.ToInt32(combo_serie.SelectedValue);
            generacion = Convert.ToInt32(combo_generacion.SelectedValue);
            IList<Unidad> stockUnidades = service.getUnidades(fabricante, serie, generacion, nombre);
            dgv_stock_unidades.Rows.Clear();
            foreach (Unidad unidad in stockUnidades)
            {
                dgv_stock_unidades.Rows.Add(new object[] {  unidad.NombreFabricante.ToString(),
                                                            unidad.Nombre.ToString(),
                                                            unidad.NombreGeneracion.ToString(),
                                                            unidad.AñoModelo.ToString()
                                                         }
                                            );
            }
        }
    }
}
