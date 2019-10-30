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

namespace AgenciaDeAutos.GUI.Clientes
{
    public partial class frm_nuevo_cliente : Form
    {
        private ClienteService service;
        private Support.Support helper = Support.Support.GetSupport();
        public frm_nuevo_cliente(ClienteService origen)
        {
            service = origen;
            InitializeComponent();
        }

        private void validarNombre(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Support.Support.GetSupport().soloLetrasSiEspacioConAdvertencia(sender, e);
        }
        private void validarApellido(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Support.Support.GetSupport().soloLetrasSiEspacioConAdvertencia(sender, e);
        }
        private void validarDireccion(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Support.Support.GetSupport().soloLetrasSiEspacioConAdvertencia(sender, e);
        }
        private void validarNroDireccion(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Support.Support.GetSupport().soloNumerosConAdvertencia(sender, e);
        }
        private void validarDNI(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Support.Support.GetSupport().soloNumerosConAdvertencia(sender, e);
        }
        private void validarTelefono(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Support.Support.GetSupport().soloNumerosConAdvertencia(sender, e);
        }
        private void validarCelular(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Support.Support.GetSupport().soloNumerosConAdvertencia(sender, e);
        }
        private string validarCampos()
        {
            if (String.IsNullOrWhiteSpace(txt_name.Text))
            {
                return "Nombre";
            }
            if (String.IsNullOrWhiteSpace(txt_lastName.Text))
            {
                return "Apellido";
            }
            if (String.IsNullOrWhiteSpace(txt_dni.Text))
            {
                return "DNI";
            }
            if (String.IsNullOrWhiteSpace(txt_address.Text))
            {
                return "Direccion";
            }
            if (String.IsNullOrWhiteSpace(txt_nro.Text))
            {
                return "Numero de calle";
            }
            if (String.IsNullOrWhiteSpace(txt_phone.Text))
            {
                return "Telefono";
            }
            if (String.IsNullOrWhiteSpace(txt_mobile.Text))
            {
                return "Celular";
            }
            return null;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool retorno = false;
            if(validarCampos() != null)
            {
                MessageBox.Show("Ha dejado el campo " + validarCampos() + " vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if(service.buscarClientePorDni(Convert.ToInt32(txt_dni.Text)) == true)
                {
                    MessageBox.Show("Ya existe un cliente con ese DNI ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //vec: 0 - nombre / 1 - apellido / 2 - calle 
                    string[] vec = new string[3];
                    long dni = Convert.ToInt64(txt_dni.Text);
                    long telefono = Convert.ToInt64(txt_phone.Text);
                    long celular = Convert.ToInt64(txt_mobile.Text);
                    int nro = Int32.Parse(txt_nro.Text);
                    vec[0] = txt_name.Text;
                    vec[1] = txt_lastName.Text;
                    vec[2] = txt_address.Text;
                    retorno = service.nuevoCliente(vec,dni,nro,telefono,celular);
                    if(retorno == true)
                        MessageBox.Show("Cliente registrado con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Hubo un problema al registrar el cliente, intente nuevamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }               
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txt_dni.Text))
            {
                if (service.buscarClientePorDni(Convert.ToInt32(txt_dni.Text)) == true)
                {
                    lbl_dni_warning.Text = "Existe un cliente con este DNI";
                    lbl_dni_warning.ForeColor = Color.Red;
                    txt_dni.BackColor = Color.LightPink;
                    txt_dni.Focus();
                }
                else
                {
                    lbl_dni_warning.Text = "*";
                    txt_dni.BackColor = Color.White;
                }
                   
            }
          
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cancelar", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
                this.Dispose();
        }
    }
}
