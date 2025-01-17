﻿using AgenciaDeAutos.Business;
using AgenciaDeAutos.GUI.Unidades;
using AgenciaDeAutos.Properties;
using AgenciaDeAutos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private Support.Support support = null;
        private string logo = "";
        public frm_modelo(string logo, string titulo)
        {
            InitializeComponent();
            this.logo = logo;
            service = new UnidadService();
            pic_logo.BackColor = Color.Transparent;
            support = Support.Support.GetSupport();
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
                Image theImage = Image.FromFile(Path.Combine(Application.StartupPath, "Iconos /"+logo+".ico"));
                Bitmap theBitmap = new Bitmap(theImage, new Size(48,48));
                IntPtr Hicon = theBitmap.GetHicon();// Get an Hicon for myBitmap.
                Icon newIcon = Icon.FromHandle(Hicon);// Create a new icon from the handle
                this.Icon = newIcon;
                pic_logo.Image = Image.FromFile(Path.Combine(Application.StartupPath,"Imagenes/Logos/" + logo +".png"));
                BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes/Fondos/" + logo + " (" + i + ")" + ".jpg"));
                this.Text = logo.ToString();
                
            }
            catch(System.IO.FileNotFoundException)
            {
                pic_rear.Image = (Image)Resources.Image;
                BackgroundImage = (Image)Resources.Image;
            }
        }

        private void txt_cotizacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_modelo_Load(object sender, EventArgs e)
        {
            support.cargarComboSerie(combo_serie,fabricante);
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
                this.Dispose();
        }

       
        public void cargarGrilla(string nombre)
        {
            int serie, generacion;;
            serie = Convert.ToInt32(combo_serie.SelectedValue.ToString());
            generacion = Convert.ToInt32(combo_generacion.SelectedValue.ToString());
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

        private void combo_serie_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_stock_unidades.Rows.Clear();
            combo_generacion.SelectedIndex = -1;
        }

        private void combo_generacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_stock_unidades.Rows.Clear();
            combo_modelo.SelectedIndex = -1;

        }
        private void combo_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_stock_unidades.Rows.Clear();
            cargarGrilla(combo_modelo.Text);
            try
            {
                pic_front.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes/Modelos/Front/" + logo + "/" + combo_serie.Text + "/" + combo_generacion.Text + combo_modelo.Text + ".jpg"));
                pic_rear.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes/Modelos/Rear/" + logo + "/" + combo_serie.Text + "/" + combo_generacion.Text + combo_modelo.Text + ".jpg"));


            }
            catch (System.IO.FileNotFoundException)
            {
                pic_front.Image = (Image)Resources.NoImage;
                pic_rear.Image = (Image)Resources.NoImage;
            }
        }


        private void combo_serie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgv_stock_unidades.Rows.Clear();
            support.cargarComboGeneracion(combo_generacion, Convert.ToInt32(combo_serie.SelectedValue));
        }
        

        private void combo_generacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            support.cargarComboModelo(combo_modelo, fabricante,
                                           Convert.ToInt32(combo_serie.SelectedValue.ToString()),
                                           Convert.ToInt32(combo_generacion.SelectedValue.ToString())
                                        );
        }

        private void combo_modelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarGrilla(combo_modelo.Text);
            try
            {
                pic_front.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes/Modelos/Front/" + logo + "/" + combo_serie.Text + "/" + combo_generacion.Text + combo_modelo.Text + ".jpg"));
                pic_rear.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes/Modelos/Rear/" + logo + "/" + combo_serie.Text + "/" + combo_generacion.Text + combo_modelo.Text + ".jpg"));


            }
            catch (System.IO.FileNotFoundException)
            {
                pic_front.Image = (Image)Resources.NoImage;
                pic_rear.Image = (Image)Resources.NoImage;
            }
        }
        private void limpiar()
        {
            dgv_stock_unidades.Rows.Clear();
        }

        private void btn_iniciar_venta_Click(object sender, EventArgs e)
        {
            Form aux = new frm_main_unidades();
            aux.ShowDialog();
        }

        private void combo_serie_SelectedValueChanged(object sender, EventArgs e)
        {
            dgv_stock_unidades.Rows.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
