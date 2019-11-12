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
        private Unidad unidadSeleccionada = null;
        private UnidadService uService = null;
        private PostVentaService pvService = null;
        private Support.Support support = Support.Support.GetSupport();
        private PostVenta newPostventa = null;
        private Trabajo job = null;
        private int opcion = -1;
        public frm_new_service(int unidad, int opcion)
        {         
            uService = new UnidadService();
            pvService = new PostVentaService();
            newPostventa = new PostVenta();
            job = new Trabajo();
            unidadSeleccionada = uService.getUnidadParaService(unidad);
            this.opcion = opcion;
            InitializeComponent();       
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cancelar el service?", "Atencion",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(resultado == DialogResult.Yes)
            this.Dispose();
        }

        private void frm_new_service_Load(object sender, EventArgs e)
        {
            combo_trabajos.SelectedIndex = -1;
            txt_km_limite.Text = unidadSeleccionada.Descripcion.ToString();
            txt_cotizacion.Text = 1.ToString();
            lbl_vehiculo.ForeColor = Color.Blue;
            lbl_vehiculo.Text = unidadSeleccionada.NombreFabricante.ToString() + " | " + unidadSeleccionada.Nombre.ToString() + " | " +
                                unidadSeleccionada.NombreGeneracion.ToString() + " | " + unidadSeleccionada.AñoModelo.ToString() + " | " + 
                                unidadSeleccionada.Patente.ToString();

            support.cargarCombo(combo_trabajos,"Trabajos","idTrabajo","nombre");

        }

        private void combo_trabajos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (combo_trabajos.SelectedValue != null)
                txt_tareas_trabajos.Text = support.getTitutoTrabajoPorID(Convert.ToInt32(combo_trabajos.SelectedValue.ToString()));
        }

        private void txt_cotizacion_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txt_cotizacion.Text) && Convert.ToInt32(txt_cotizacion.Text) > 0)
            {
                if (!String.IsNullOrWhiteSpace(txt_precio_dolar.Text))
                {
                    double cotizacion = Convert.ToDouble(txt_cotizacion.Text);
                    long dolar = Convert.ToInt64(txt_precio_dolar.Text);
                    long peso = Convert.ToInt64(dolar * cotizacion);
                    txt_precio_arg.Text = peso.ToString();
                    dgv_detalles.Rows.Clear();
                    refresh();
                }
                if (!String.IsNullOrWhiteSpace(txt_total_dolar.Text))
                {
                    double cotizacion = Convert.ToDouble(txt_cotizacion.Text);
                    long totaldolar = Convert.ToInt64(txt_total_dolar.Text);
                    long totalpeso = Convert.ToInt64(totaldolar * cotizacion);
                    txt_total_peso.Text = totalpeso.ToString();
                    dgv_detalles.Rows.Clear();
                    refresh();
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(txt_precio_dolar.Text))
                {
                    double cotizacion = 1;
                    long dolar = Convert.ToInt64(txt_precio_dolar.Text);
                    long peso = Convert.ToInt64(dolar * cotizacion);
                    txt_precio_arg.Text = peso.ToString();
                    dgv_detalles.Rows.Clear();
                    refresh();
                }
                if (!String.IsNullOrWhiteSpace(txt_total_dolar.Text))
                {
                    double cotizacion = 1;
                    long totaldolar = Convert.ToInt64(txt_total_dolar.Text);
                    long totalpeso = Convert.ToInt64(totaldolar * cotizacion);
                    txt_total_peso.Text = totalpeso.ToString();
                    dgv_detalles.Rows.Clear();
                    refresh();
                }
            }
        }

        private void txt_precio_dolar_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txt_cotizacion.Text)&& !String.IsNullOrWhiteSpace(txt_precio_dolar.Text))
            {
                double cotizacion = Convert.ToDouble(txt_cotizacion.Text);
                long dolar = Convert.ToInt64(txt_precio_dolar.Text);
                long peso = Convert.ToInt64(dolar * cotizacion);
                txt_precio_arg.Text = peso.ToString();
            }
        }

        private void txt_total_dolar_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txt_total_dolar.Text) && !String.IsNullOrWhiteSpace(txt_cotizacion.Text))
            {
                double cotizacion = Convert.ToDouble(txt_cotizacion.Text);
                long totaldolar = Convert.ToInt64(txt_total_dolar.Text);
                long totalpeso = Convert.ToInt64(totaldolar * cotizacion);
                txt_total_peso.Text = totalpeso.ToString();
            }
            else
            {
                txt_total_peso.Text = 0.ToString();
            }
        }
        private string validarCampos()
        {
            if (String.IsNullOrWhiteSpace(txt_detalles_realizados.Text))
                return "No dio una descripcion del trabajo realizado";
            if (String.IsNullOrWhiteSpace(txt_km_actual.Text))
                return "No ingreso el km actual del vehiculo";
            if (combo_trabajos.SelectedValue == null && combo_trabajos.SelectedIndex == -1)
                return "No ha seleccionado un trabajo";
            return null;
        }
            private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea registrar el nuevo service?","Atencion",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(resultado == DialogResult.Yes)
            {
                if (newPostventa.Detalles == null)
                {
                    MessageBox.Show("No ha realizado ningun trabajo sobre la unidad ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    newPostventa.unidad = unidadSeleccionada;
                    if (opcion == 0)
                    {
                        bool retorno;
                        if (Convert.ToInt64(txt_km_limite.Text) < Convert.ToInt64(txt_km_actual.Text))
                        {
                            newPostventa.Kmlimite = Convert.ToInt64(txt_km_actual.Text);
                            retorno = pvService.registrarServiceCliente(newPostventa);
                            if (retorno == true)
                                MessageBox.Show("Service registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            else
                                MessageBox.Show("Error al registrar el service, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            newPostventa.Kmlimite = Convert.ToInt64(txt_km_limite.Text);
                            retorno = pvService.registrarServiceCliente(newPostventa);
                            if (retorno == true)
                                MessageBox.Show("Service registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            else
                                MessageBox.Show("Error al registrar el service, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        bool retorno;
                        if (Convert.ToInt64(txt_km_limite.Text) < Convert.ToInt64(txt_km_actual.Text))
                        {
                            newPostventa.Kmlimite = Convert.ToInt64(txt_km_actual.Text);
                            retorno = pvService.registrarServiceInterno(newPostventa);
                            if (retorno == true)
                                MessageBox.Show("Service registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            else
                                MessageBox.Show("Error al registrar el service, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            newPostventa.Kmlimite = Convert.ToInt64(txt_km_limite.Text);
                            retorno = pvService.registrarServiceInterno(newPostventa);
                            if (retorno == true)
                                MessageBox.Show("Service registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            else
                                MessageBox.Show("Error al registrar el service, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                limpiarCampos();
            }
        }

        private void btn_add_detail_Click(object sender, EventArgs e)
        {
            if (validarCampos() == null)
            {
                long precio = Convert.ToInt64(txt_precio_dolar.Text);
                job.IdTrabajo = Convert.ToInt32(combo_trabajos.SelectedValue.ToString());
                job.Descripcion = txt_tareas_trabajos.Text;
                newPostventa.crearDetallePostVenta(unidadSeleccionada.CodUnidad,job,precio,txt_detalles_realizados.Text);
                llenarGrilla();
            }
            limpiarCampos();
        }

        private void llenarGrilla()
        {
            if(newPostventa.Detalles != null)
            {
                dgv_detalles.Rows.Add(new object[] {
                                                        newPostventa.Detalles.Count.ToString(),
                                                        txt_tareas_trabajos.Text,
                                                        txt_detalles_realizados.Text,
                                                        txt_precio_dolar.Text,
                                                        (Convert.ToInt64(txt_precio_dolar.Text) * Convert.ToInt64(txt_cotizacion.Text)).ToString()
                                                    });
                txt_total_dolar.Text = newPostventa.getPrecioTotal().ToString();
            }
        }
        private void refresh()
        {
            int count = 1;
            if (newPostventa.Detalles != null)
            {
                foreach(DetallePostVenta dpv in newPostventa.Detalles)
                {                  
                    dgv_detalles.Rows.Add(new object[] { 
                                                        count.ToString(),
                                                        dpv.Job.Titulo,
                                                        dpv.Job.Descripcion,
                                                        dpv.Descripcion,
                                                        dpv.Precio.ToString(),
                                                        (dpv.Precio * Convert.ToInt64(txt_cotizacion.Text)).ToString()
                                                    });
                    count++;
                }
            }
        }

        private void txt_km_actual_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender,e);
        }

        private void txt_cotizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            support.soloNumeros(sender, e);
        }
        private void limpiarCampos()
        {
            combo_trabajos.SelectedIndex = -1;
            txt_tareas_trabajos.Clear();
            txt_detalles_realizados.Clear();
            txt_precio_dolar.Clear();
            txt_precio_arg.Clear();
            txt_total_dolar.Clear();
            txt_total_peso.Clear();
            dgv_detalles.Rows.Clear();
        }

        private void txt_detalles_realizados_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
