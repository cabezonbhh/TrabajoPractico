using AgenciaDeAutos.Business;
using AgenciaDeAutos.GUI.Clientes;
using AgenciaDeAutos.GUI.Usuarios;
using AgenciaDeAutos.GUI.Vehiculos;
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

namespace AgenciaDeAutos.GUI.Otros
{
    public partial class frm_main_admin : Form
    {
        private UsuarioService service;
        public frm_main_admin(string usuario)
        {
            InitializeComponent();
            service = new UsuarioService();
            lbl_userOn.Text = "Usuario logueado: "+ usuario;
        }

        private void cargarGrilla()
        {
            IList<Usuario> usuarios = service.obtenerUsuarios();
            dgv_usuarios.Rows.Clear();
            foreach (Usuario usuario in usuarios)
            {
                dgv_usuarios.Rows.Add(new Object[] { usuario.Idusuario.ToString(), usuario.Nombre.ToString(), usuario.Contraseña.ToString(), usuario.Perfil.Nombre.ToString() });
            }
        }
        private void frm_main_admin_Load(object sender, EventArgs e)
        {
            this.cargarGrilla();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.CurrentRow != null)
            {                
                if (MessageBox.Show("Seguro que desea eliminar el usuario?", "ALETA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgv_usuarios.CurrentRow.Cells["col_id_usuario"].Value); 
                    bool respuesta = service.borrarUsuario(id);
                    if (respuesta == true)
                    {
                        MessageBox.Show("Se borro exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al borrar");
                    }

                }
            }
            else
            {
                MessageBox.Show("No se selecciono ningun usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.cargarGrilla();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.CurrentRow != null)
            {
                service.UsuarioSeleccionado = Int32.Parse(dgv_usuarios.CurrentRow.Cells["col_id_usuario"].Value.ToString());
                this.Dispose();
                new frm_edit_user(service, lbl_userOn.Text).ShowDialog();
            }
            else
            {
                MessageBox.Show("No se selecciono ningun usuario", "Atencion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }


        private void btn_new_user_Click(object sender, EventArgs e)
        {
            Form aux = new frm_new_user(service,lbl_userOn.Text);
            this.Dispose();
            aux.ShowDialog();           
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            Form main1 = new frm_main_normal();       
            main1.ShowDialog();

        }

        private void btn_gerencial_Click(object sender, EventArgs e)
        {
            Form main2 = new frm_main_gerencial();
            main2.ShowDialog();           
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Form aux = new main_cliente();
            aux.ShowDialog();
        }
    }
}
