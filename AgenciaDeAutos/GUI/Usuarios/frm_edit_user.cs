using AgenciaDeAutos.Business;
using AgenciaDeAutos.GUI.Otros;
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

namespace AgenciaDeAutos.GUI.Usuarios
{
    public partial class frm_edit_user : Form
    {
        private UsuarioService service;
        private string userOn;

        public frm_edit_user(UsuarioService origen, string userOn)
        {
            this.service = origen;
            InitializeComponent();
            this.userOn = userOn;
        }

        private void frm_edit_user_Load(object sender, EventArgs e)
        {
            txt_profile.Enabled = false;
            combo_perfil.Enabled = false;
            int id = service.UsuarioSeleccionado;
            Usuario usuario = service.buscarUsuarioPorID(id);
            txt_name.Enabled = false;
            txt_pass.Text = usuario.Contraseña;
            txt_profile.Text = usuario.Perfil.Nombre;
            Support.Support.GetSupport().cargarCombo(combo_perfil,"Perfiles","idPerfil","nombre");
            lbl_info_name.Text = "Maximo 30 caracteres";
            lbl_info_name.ForeColor = Color.Red;
            txt_name.BackColor = Color.White;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool retorno = false;
            if(String.IsNullOrEmpty(txt_pass.Text)==true)
            {
                MessageBox.Show("Ha dejado vacio el campo contraseña","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                int id = service.UsuarioSeleccionado;
                Usuario usuario = service.buscarUsuarioPorID(id);
                usuario.Contraseña = txt_pass.Text;
                usuario.Perfil.IdPerfil = usuario.Perfil.IdPerfil;
                if (check_profile.Checked == true)
                    usuario.Perfil.IdPerfil = (int)combo_perfil.SelectedValue;

                if (check_name.Checked == true)
                {
                    txt_name.Enabled = true;
                    usuario.Nombre = txt_name.Text;
                    if (String.IsNullOrWhiteSpace(txt_name.Text) == false)
                    {
                        if (service.buscarUsuarioPorNombre(txt_name.Text) == false)
                        {
                            usuario.Nombre = txt_name.Text;
                            retorno = service.editarUsuario(usuario);
                            if (retorno == true)
                                MessageBox.Show("Datos modificados con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Hubo un problema al modificar los datos, revise e intente nuevamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un usuario con ese nombre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No ingreso un nombre de usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    retorno = service.editarUsuario(usuario);
                    if (retorno == true)
                        MessageBox.Show("Datos modificados con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Hubo un problema al modificar los datos, revise e intente nuevamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }            
            
        }

        private void check_profile_CheckedChanged(object sender, EventArgs e)
        {
            if (combo_perfil.Enabled == false)
            combo_perfil.Enabled = true;
            else
            combo_perfil.Enabled = false;

        }
        private void check_name_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_name.Enabled == false)
                txt_name.Enabled = true;
            else
                txt_name.Enabled = false;
        }
        private void validarNombre(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Support.Support.GetSupport().soloLetrasNumerosConAdvertencia(sender,e);
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
                txt_name.BackColor = Color.LightPink;
                txt_name.Focus();
            }
            else 
            {
                lbl_info_name.Text = "Maximo 30 caracteres";
                lbl_info_name.ForeColor = Color.Red;
                txt_name.BackColor = Color.White;
            }
        }

       
    }
}
