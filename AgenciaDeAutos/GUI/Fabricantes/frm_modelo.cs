using AgenciaDeAutos.Properties;
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
        public frm_modelo(string logo, string titulo)
        {
            InitializeComponent();
            pic_logo.BackColor = Color.Transparent;
            Random random = new Random();
            this.Text = titulo;
            int i = random.Next(1, 8);
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
    }
}
