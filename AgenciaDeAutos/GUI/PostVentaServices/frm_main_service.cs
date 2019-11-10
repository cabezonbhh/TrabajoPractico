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
        private Support.Support support = null;
        public frm_main_service()
        {
            InitializeComponent();
            uService = new UnidadService();
            cService = new ClienteService();
            pvService = new PostVentaService();
            support = Support.Support.GetSupport();
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
            }
            else
            {
                MessageBox.Show("No selecciono ninguna unidad","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
            else
            {
                int pv = Convert.ToInt32(dgv_post_service.CurrentRow.Cells["id_service"].Value.ToString());
                Form aux = new frm_detalle_pv(pv,unidadSeleccionada);
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
                Form aux = new frm_new_service(unidadSeleccionada,0);
                aux.Show();
            }
        }

        private void txt_DNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender,e);
        }

        private void txt_modelo_TextChanged(object sender, EventArgs e)
        {
            dgv_pv_interno.Rows.Clear();
            dgv_unidadesInternas.Rows.Clear();
            txt_patente.Clear();
            txt_unidad.Clear();
            if (!String.IsNullOrWhiteSpace(txt_modelo.Text))
            {
                IList<Unidad> stockUnidades = uService.getUnidadesFiltradas(txt_modelo.Text);
                dgv_unidadesInternas.Rows.Clear();
                foreach (Unidad unidad in stockUnidades)
                {
                    dgv_unidadesInternas.Rows.Add
                        (
                            new object[]
                            {
                            unidad.CodUnidad.ToString(), unidad.NombreFabricante, unidad.Nombre, unidad.NombreGeneracion,
                            unidad.AñoModelo.ToString(),unidad.Patente
                            }
                        );

                }
            }
            else
                dgv_unidadesInternas.Rows.Clear();
        }
   
        private void txt_modelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloLetrasNumeros(sender,e);
        }

        private void txt_patente_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.noEspaciosBlancos(sender,e);
        }

        private void txt_unidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender,e);
        }

        private void txt_unidad_TextChanged(object sender, EventArgs e)
        {
            txt_patente.Clear();
            txt_modelo.Clear();
            dgv_pv_interno.Rows.Clear();
            dgv_unidadesInternas.Rows.Clear();
            if (!String.IsNullOrWhiteSpace(txt_unidad.Text))
            {
                Unidad unidad = uService.getUnidadPorId(Convert.ToInt32(txt_unidad.Text));
                dgv_unidadesInternas.Rows.Clear();
                dgv_unidadesInternas.Rows.Add
                        (
                            new object[]
                            {
                            unidad.CodUnidad.ToString(), unidad.NombreFabricante, unidad.Nombre, unidad.NombreGeneracion,
                            unidad.AñoModelo.ToString(),unidad.Patente
                            }
                        );
            }
            else
                dgv_unidadesInternas.Rows.Clear();
        }

        private void txt_patente_TextChanged(object sender, EventArgs e)
        {
            dgv_pv_interno.Rows.Clear();
            dgv_unidadesInternas.Rows.Clear();
            txt_unidad.Clear();
            txt_modelo.Clear();
            if (!String.IsNullOrWhiteSpace(txt_patente.Text))
            {
                IList<Unidad> stockUnidades = uService.GetUnidadesPorPatente(txt_patente.Text);
                dgv_unidadesInternas.Rows.Clear();
                foreach (Unidad unidad in stockUnidades)
                {
                    dgv_unidadesInternas.Rows.Add
                        (
                            new object[]
                            {
                            unidad.CodUnidad.ToString(), unidad.NombreFabricante, unidad.Nombre, unidad.NombreGeneracion,
                            unidad.AñoModelo.ToString(),unidad.Patente
                            }
                        );

                }
            }
            else
                dgv_unidadesInternas.Rows.Clear();
        }

        private void btn_service_interno_Click(object sender, EventArgs e)
        {
            if (dgv_unidadesInternas.CurrentRow != null)
            {
                unidadSeleccionada = Convert.ToInt32(dgv_unidadesInternas.CurrentRow.Cells["col_numero_unidad"].Value.ToString());
                dgv_pv_interno.Rows.Clear();
                llenarGrillaServicesInterna(unidadSeleccionada);
            }
            else
            {
                MessageBox.Show("No selecciono ninguna unidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_new_service.Enabled = false;
            }
        }
        private void llenarGrillaServicesInterna(int id)
        {
            IList<PostVenta> lista = pvService.GetPostVentasPorIDInterno(id);
            foreach (PostVenta pv in lista)
            {
                dgv_pv_interno.Rows.Add(new Object[]  {   pv.IdService.ToString(),
                                                            pv.FechaService.ToShortDateString(),
                                                            pv.getPrecioTotal().ToString(),
                                                            pv.Kmlimite.ToString()
                                                        });

            }
        }

        private void frm_main_service_Load(object sender, EventArgs e)
        {

        }

        private void dgv_stock_unidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_nuevo_service_Click(object sender, EventArgs e)
        {
            if (dgv_unidadesInternas.CurrentRow == null)
            {
                MessageBox.Show("No ha seleccionado ninguna unidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                unidadSeleccionada = Convert.ToInt32(dgv_unidadesInternas.CurrentRow.Cells[0].Value.ToString());
                Form aux = new frm_new_service(unidadSeleccionada, 1);
                aux.Show();
            }
        }

        private void btn_mas_detalles_Click(object sender, EventArgs e)
        {
            Form aux = new frm_detalle_pv(Convert.ToInt32(dgv_pv_interno.CurrentRow.Cells[0].Value.ToString()),unidadSeleccionada);
            aux.ShowDialog();
        }

        private void dgv_pv_interno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_mas_detalles.Enabled = true;
        }

        private void dgv_pv_interno_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form aux = new frm_detalle_pv(Convert.ToInt32(dgv_pv_interno.CurrentRow.Cells[0].Value.ToString()), unidadSeleccionada);
            aux.ShowDialog();
        }
    }
}
