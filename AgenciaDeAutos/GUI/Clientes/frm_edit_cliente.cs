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

namespace AgenciaDeAutos.GUI.Clientes
{
    public partial class frm_edit_cliente : Form
    {
        private ClienteService service = null;
        public frm_edit_cliente(ClienteService origen)
        {
            InitializeComponent();
            this.service = origen;
            lbl_dni_warning.Visible = false;
        }

        private void frm_edit_cliente_Load(object sender, EventArgs e)
        {
            int id = service.ClienteSeleccionado;
            Cliente cliente = service.buscarClientePorID(id);
            txt_name.Text = cliente.Nombre;
            txt_lastName.Text = cliente.Apellido;
            txt_dni.Enabled = false;
            txt_address.Text = cliente.Calle;
            txt_nro.Text = cliente.NroCalle.ToString();
            txt_phone.Text = cliente.Telefono.ToString();
            txt_mobile.Text = cliente.Celular.ToString();
            lbl_dni_warning.Text = "Para modificar el DNI tilde la opcion";
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
                return "nombre";
            }
            if (String.IsNullOrWhiteSpace(txt_lastName.Text))
            {
                return "apellido";
            }
            if (String.IsNullOrWhiteSpace(txt_address.Text))
            {
                return "direccion";
            }
            if (String.IsNullOrWhiteSpace(txt_nro.Text))
            {
                return "numero de calle";
            }
            if (String.IsNullOrWhiteSpace(txt_phone.Text))
            {
                return "telefono";
            }
            if (String.IsNullOrWhiteSpace(txt_mobile.Text))
            {
                return "celular";
            }
            return null;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool retorno = false;
            if (validarCampos() != null)
            {
                MessageBox.Show("Ha dejado el campo " + validarCampos() + " vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id = service.ClienteSeleccionado;
                Cliente cliente = service.buscarClientePorID(id);
                cliente.Nombre = txt_name.Text;
                cliente.Apellido = txt_lastName.Text;
                cliente.Calle = txt_address.Text;
                cliente.NroCalle = Convert.ToInt32(txt_nro.Text);
                cliente.Telefono = Convert.ToInt64(txt_phone.Text);
                cliente.Celular = Convert.ToInt64(txt_mobile.Text);
                if (check_dni.Checked == true)
                {
                    if (String.IsNullOrWhiteSpace(txt_dni.Text) == false)
                    {
                        if (service.buscarClientePorDni(Convert.ToInt64(txt_dni.Text)) == false)
                        {
                            cliente.Dni = Convert.ToInt64(txt_dni.Text);
                            retorno = service.editarCliente(cliente);
                            if (retorno == true)
                                MessageBox.Show("Datos del cliente modificados con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Hubo un problema al modificar los datos, revise e intente nuevamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un cliente con ese DNI ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No ha ingresado un dni ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    retorno = service.editarCliente(cliente);
                    if (retorno == true)
                        MessageBox.Show("Datos del cliente modificados con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Hubo un problema al modificar los datos, revise e intente nuevamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }         
            }
        }
             
        private void check_dni_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_dni.Enabled == false)
                txt_dni.Enabled = true;
            else
                txt_dni.Enabled = false;
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            if (service.buscarClientePorDni(Convert.ToInt64(txt_dni.Text)) == true)
            {
                lbl_dni_warning.Visible = true;
                lbl_dni_warning.Text = "Usuario existente";
                lbl_dni_warning.ForeColor = Color.Red;
                txt_dni.BackColor = Color.LightPink;
                txt_dni.Focus();
            }
            else
            {
                lbl_dni_warning.Text = "Para modificar el DNI tilde la opcion";
                lbl_dni_warning.ForeColor = Color.Red;
                txt_dni.BackColor = Color.White;
                lbl_dni_warning.Visible = false;
            }
        }
    }
}
