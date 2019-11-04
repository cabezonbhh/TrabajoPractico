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

namespace AgenciaDeAutos.GUI.PostVenta
{
    public partial class frm_main_service : Form
    {
        private UnidadService uService = null;
        private ClienteService cService = null;
        private PostVentaService pvService = null;
        public frm_main_service()
        {
            InitializeComponent();
            uService = new UnidadService();
            cService = new ClienteService();
            pvService = new PostVentaService();
        }

        private void limpiarCampos()
        {
            txt_name.Clear();
            txt_lastName.Clear();
            dgv_stock_unidades.Rows.Clear();
            dgv_post_service.Rows.Clear();
        }
        private void llenarGrillaUnidades(int dni)
        {
            IList<Unidad> unidades = uService.GetUnidadesPorDni(dni);
            dgv_stock_unidades.Rows.Clear();
            foreach (Unidad unidad in unidades )
            {
                dgv_stock_unidades.Rows.Add(new Object[]    { unidad.CodUnidad.ToString(),
                                                              unidad.NombreFabricante.ToString(),
                                                              unidad.Nombre.ToString(),
                                                              unidad.NombreGeneracion.ToString(),
                                                              unidad.AñoModelo.ToString(),
                                                              unidad.Patente.ToString()
                                                            });
            }
        }

        private void txt_DNI_TextChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            if (String.IsNullOrWhiteSpace(txt_DNI.Text) != true) 
            {
                int dni = Convert.ToInt32(txt_DNI.Text);
                llenarGrillaUnidades(dni);
            }
        }

        private void dgv_stock_unidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_stock_unidades.CurrentRow != null)
            {
                //pvService.
            }
        }
    }
}
