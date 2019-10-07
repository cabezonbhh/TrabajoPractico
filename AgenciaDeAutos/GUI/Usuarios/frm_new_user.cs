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
using AgenciaDeAutos.Support;
using AgenciaDeAutos.Data.Dao;

namespace AgenciaDeAutos.GUI.Otros
{
    public partial class frm_new_user : Form
    {
        private UsuarioService service;
        private Support.Support supp = Support.Support.GetSupport();
        private string userOn;
        public frm_new_user(UsuarioService origen, string userOn)
        {
            service = origen;
            InitializeComponent();
            supp.cargarCombo(combo_perfil, "Perfiles", "idPerfil", "nombre");
            this.userOn = userOn;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool retorno = false;
            if (String.IsNullOrEmpty(txt_name.Text) || String.IsNullOrEmpty(txt_pass.Text))
            {
                MessageBox.Show("Ha dejado vacio el campo nombre o contraseña", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (service.buscarUsuarioPorNombre(txt_name.Text) == true)
                {
                    MessageBox.Show("Ese nombre de usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    retorno = service.nuevoUsuario(txt_name.Text, txt_pass.Text, Convert.ToInt32(combo_perfil.SelectedValue.ToString()));
                    if (retorno == true)
                        MessageBox.Show("El usuario fue creado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("Ocurrio un error al crear el usuario", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void validarNombre(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Support.Support.GetSupport().soloLetrasNumerosConAdvertencia(sender, e);
        }

        private void validarContraseña(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Support.Support.GetSupport().noEspaciosBlancosConAdvertencia(sender, e);
        }



        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea salir", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                Form aux = new frm_main_admin(userOn);
                this.Dispose();
                aux.ShowDialog();
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (service.buscarUsuarioPorNombre(txt_name.Text) == true)
            {
                lbl_info_name.Text = "Usuario existente";
                lbl_info_name.ForeColor = Color.Red;
            }
            else
            {
                lbl_info_name.Text = "Maximo 30 caracteres";
                lbl_info_name.ForeColor = Color.Red;
            }
  
        }
    }
}

