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
    public partial class frm_detalle_pv : Form
    {
        PostVenta pvSeleccionado = null;
        Unidad uSeleccionada = null;
        private UnidadService uService = null;
        private PostVentaService pvService = null;
        public frm_detalle_pv(int seleccionada, int unidadSeleccionada)
        {
            InitializeComponent();
            uService = new UnidadService();
            pvService = new PostVentaService();           
            this.pvSeleccionado = pvService.getPostVentaMasDetalle(seleccionada, unidadSeleccionada);
            this.uSeleccionada = uService.getUnidadPorId(unidadSeleccionada);
        }

        private void frm_detalle_pv_Load(object sender, EventArgs e)
        {
            llenarGrilla();
            txt_km_limite.Text = pvSeleccionado.Kmlimite.ToString();
            txt_total_dolar.Text = pvSeleccionado.getPrecioTotal().ToString();
            lbl_vehiculo.Text = uSeleccionada.NombreFabricante.ToString()+" - "+ uSeleccionada.Nombre.ToString()+" - "+
                uSeleccionada.NombreGeneracion.ToString() + " - " + uSeleccionada.Patente.ToString();
        }

        private void llenarGrilla()
        {
            if(pvSeleccionado.Detalles !=null)
            {
                foreach(DetallePostVenta dpv in pvSeleccionado.Detalles)
                {
                    dgv_detalles.Rows.Add(new object[] { pvSeleccionado.Detalles.Count.ToString(), dpv.Job.Titulo.ToString(),
                                                         dpv.Precio.ToString(),dpv.Job.Descripcion.ToString(),dpv.Descripcion.ToString()});
                }
            }
        }

        private void dgv_detalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_detalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_detalles.CurrentRow != null)
            {
                txt_tareas_trabajos.Text = dgv_detalles.CurrentRow.Cells["tareas"].Value.ToString();
                txt_detalles_realizados.Text = dgv_detalles.CurrentRow.Cells["descripcion"].Value.ToString();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
