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

namespace AgenciaDeAutos.GUI.PostVentaServices
{
    public partial class frm_new_service : Form
    {
        Unidad seleccionada = null;
        UnidadService uService = null;
        PostVentaService pvService = null;
        public frm_new_service(int unidad)
        {
            uService = new UnidadService();
            pvService = new PostVentaService();
            InitializeComponent();
            seleccionada = uService.getUnidadPorId(unidad);
        }

        private void frm_detalles_service_Load(object sender, EventArgs e)
        {
            lbl_vehiculo.ForeColor = Color.Blue;
            lbl_vehiculo.Text = seleccionada.NombreFabricante.ToString() +" - "+ seleccionada.Nombre.ToString() + " - " +
                                seleccionada.NombreGeneracion.ToString() + " - " + seleccionada.AñoModelo.ToString();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
