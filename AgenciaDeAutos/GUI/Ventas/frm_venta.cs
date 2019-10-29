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

namespace AgenciaDeAutos.GUI.Ventas
{
    public partial class frm_venta : Form
    {
        public UnidadService service = null;
        private VentaService serviceVenta = null;
        private double cotizacion;
        long total = 0;
        long peso;
        IList<int> detalles;
        public frm_venta(double cotizacion)
        {
            InitializeComponent();
            service = new UnidadService();
            serviceVenta = new VentaService();
            this.cotizacion = cotizacion;
            detalles = new List<int>();
        }
        public void addDetail(int idUnidad)
        {   
            Unidad unidad = service.getUnidadPorId(idUnidad);
            detalles.Add(idUnidad);
            peso = Convert.ToInt64(unidad.PrecioVenta * (long)cotizacion);
            dgv_details.Rows.Add(new object[]
            {
                unidad.CodUnidad.ToString(),
                unidad.NombreFabricante.ToString(),
                unidad.Nombre.ToString(),
                unidad.AñoModelo.ToString(),
                unidad.NombreGeneracion.ToString(),
                unidad.PrecioVenta.ToString(),
                peso.ToString()
            });
            total+= Convert.ToInt64(unidad.PrecioVenta);
            txt_total_dolar.Text = total.ToString();
            txt_total_peso.Text = (total * cotizacion).ToString();
        }

        private void frm_venta_Load(object sender, EventArgs e)
        {
            txt_cotizacion.Text = cotizacion.ToString();
            txt_cotizacion.ForeColor = Color.Red;
            txt_cotizacion.Enabled = false;
            txt_total_peso.Text = total.ToString();
            txt_total_dolar.Text = total.ToString();
        }

        private void btn_new_venta_Click(object sender, EventArgs e)
        {
            if(serviceVenta.existeCliente(Convert.ToInt64(txt_dni.Text))==true)
            {
                if (detalles.Count > 0)
                {
                    int dni = Convert.ToInt32(txt_dni.Text);
                    DialogResult resultado = MessageBox.Show("Confirma la venta?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resultado == DialogResult.Yes)
                    {
                        bool retorno = false;
                        DateTime fechaEntrega = new DateTime();
                        fechaEntrega = dtp_fechaEntrega.Value;
                        retorno = serviceVenta.registrarVenta(dni, detalles, fechaEntrega);
                        if (retorno == true)
                            MessageBox.Show("Venta registrada con exito!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                            MessageBox.Show("Error al registrar la venta, verifique los datos e intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No a ingresado ninguna unidad a la venta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No existe un cliente registrado con ese DNI", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_details.CurrentRow == null)
            {
                MessageBox.Show("No ha seleccionado ningun item para eliminar","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                int fila = Convert.ToInt32(dgv_details.CurrentRow.Cells["col_id_unidad"].Value.ToString());
                foreach(int n in detalles)
                {
                    if (n == fila)
                        detalles.Remove(n);
                }
                dgv_details.Rows.RemoveAt(dgv_details.CurrentRow.Index);
            }
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_lastName.Clear();
            if(!String.IsNullOrWhiteSpace(txt_dni.Text))
            {              
                txt_name.Text = serviceVenta.getClientePorDNI(Convert.ToInt32(txt_dni.Text)).Nombre.ToString();
                txt_lastName.Text = serviceVenta.getClientePorDNI(Convert.ToInt32(txt_dni.Text)).Apellido.ToString(); 
            }
        }
    }
}
