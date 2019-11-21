using AgenciaDeAutos.GUI.Otros;
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
using AgenciaDeAutos.Service;
using AgenciaDeAutos.GUI.Usuarios;

namespace AgenciaDeAutos
{
    public partial class frm_login : Form
    {
        private Support.Support supp;
        private UsuarioService service;
        private string pass="";
        public frm_login()
        {
            service = new UsuarioService();
            supp = Support.Support.GetSupport();
            InitializeComponent();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            if(service.ValidarUsuario(txtUser.Text,txtPass.Text) !=null )
            {
                if(service.ValidarUsuario(txtUser.Text, txtPass.Text).Perfil.IdPerfil == 0)
                {
                    Form main = new frm_main_admin(txtUser.Text);
                    main.ShowDialog();
                }
 
               
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña invalidos","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }                
        }
       
       private void validarNombre(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            supp.soloLetrasNumerosConAdvertencia(sender,e);
        }

        private void validarContraseña(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            supp.noEspaciosBlancosConAdvertencia(sender, e);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cancelar", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
                this.Close();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }


        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
