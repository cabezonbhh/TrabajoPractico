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
    public partial class frm_main_service : Form
    {
        private UnidadService uService = null;
        private ClienteService cService = null;
        private PostVentaService pvService = null;
        private int unidadSeleccionada;
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

        private void llenarGrillaServices(int id)
        {
            IList<PostVenta> lista = pvService.GetPostVentasPorID(id);
            foreach (PostVenta pv in lista)
            {
                dgv_post_service.Rows.Add(new Object[]  {   pv.IdService.ToString(),
                                                            pv.FechaService.ToShortDateString(),
                                                            pv.getPrecioTotal().ToString(),
                                                            pv.Kmlimite.ToString()
                                                        });
                
            }
        }

        private void txt_DNI_TextChanged(object sender, EventArgs e)
        {
            limpiarCampos();

            if (String.IsNullOrWhiteSpace(txt_DNI.Text) != true) 
            {
                Cliente c = cService.traerClientePorDni(Convert.ToInt32(txt_DNI.Text));
                int dni = Convert.ToInt32(txt_DNI.Text);
                llenarGrillaUnidades(dni);
                txt_name.Text = c.Nombre.ToString();
                txt_lastName.Text = c.Apellido.ToString();
                
            }
        }

        private void btn_verServices_Click(object sender, EventArgs e)
        {
            if (dgv_stock_unidades.CurrentRow != null)
            {
                unidadSeleccionada = Convert.ToInt32(dgv_stock_unidades.CurrentRow.Cells[0].Value.ToString());
                dgv_post_service.Rows.Clear();
                llenarGrillaServices(unidadSeleccionada);
                btn_new_service.Enabled = true;
            }
            else
            {
                MessageBox.Show("No selecciono ninguna unidad","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                btn_new_service.Enabled = false;
            }
        }

        private void dgv_post_service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_more_detail.Enabled = true;
        }

        private void btn_more_detail_Click(object sender, EventArgs e)
        {
            if (dgv_post_service.CurrentRow == null)
            {
                MessageBox.Show("No ha seleccionado ningun service");
            }
        }

        private void btn_new_service_Click(object sender, EventArgs e)
        {
            if (dgv_stock_unidades.CurrentRow == null)
            {
                MessageBox.Show("No ha seleccionado ninguna unidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                unidadSeleccionada = Convert.ToInt32(dgv_stock_unidades.CurrentRow.Cells[0].Value.ToString());
                Form aux = new frm_new_service(unidadSeleccionada);
                aux.Show();
            }
        }

       
    }
}
