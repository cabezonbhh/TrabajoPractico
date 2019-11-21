using AgenciaDeAutos.Business;
using AgenciaDeAutos.GUI.Clientes;
using AgenciaDeAutos.GUI.Reports;
using AgenciaDeAutos.GUI.Unidades;
using AgenciaDeAutos.GUI.Usuarios;
using AgenciaDeAutos.GUI.Vehiculos;
using AgenciaDeAutos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private UnidadService uService;
        public frm_main_admin(string usuario)
        {
            InitializeComponent();
            service = new UsuarioService();
            uService = new UnidadService();
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

        private void cargarGrillaUnidades()
        {
            IList<Unidad> stockUnidades = uService.getUnidadesFiltradas(txt_filter_name.Text);
            dgv_stock_unidades.Rows.Clear();
            foreach (Unidad unidad in stockUnidades)
            {
                dgv_stock_unidades.Rows.Add(new object[] {  unidad.CodUnidad.ToString(),unidad.NombreFabricante.ToString(),
                                                            unidad.Nombre.ToString(),unidad.AñoModelo.ToString(),unidad.NombreGeneracion.ToString()
                                                         }
                                            );
            }
        }
        private void frm_main_admin_Load(object sender, EventArgs e)
        {
            this.cargarGrilla();
            btn_edit.Enabled = false;
            btn_edit_uni.Enabled = false;
            btn_delete.Enabled = false;
            btn_delete_uni.Enabled = false;
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
                 
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Form aux = new main_cliente();
            aux.ShowDialog();
        }

        private void btn_unid_Click(object sender, EventArgs e)
        {
            Form aux = new frm_new_unidad();
            aux.ShowDialog();
        }
        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_usuarios.CurrentRow != null)
            {
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
            }
            else
            {
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
            }
            
        }

        private void txt_filter_name_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txt_filter_name.Text))
                cargarGrillaUnidades();
            else
                dgv_stock_unidades.Rows.Clear();
        }

        private void dgv_stock_unidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_usuarios.CurrentRow != null)
            {
                btn_edit_uni.Enabled = true;
                btn_delete_uni.Enabled = true;
            }
            else
            {
                btn_edit_uni.Enabled = false;
                btn_delete_uni.Enabled = false;
            }
        }

        private void btn_edit_uni_Click(object sender, EventArgs e)
        {
            if(dgv_stock_unidades.CurrentRow == null)
            {
                MessageBox.Show("No se selecciono ninguna unidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Unidad seleccionada = uService.getUnidadPorId(Convert.ToInt32(dgv_stock_unidades.CurrentRow.Cells[0].Value.ToString()));
                Form aux = new frm_edit_unidad(seleccionada);
                aux.ShowDialog();
            }
        }

        private void btn_entregas_Click(object sender, EventArgs e)
        {
            Process.Start(@"T:\Programacion\C#\TrabajoPractico\Otros\entregas.pbix");
            Form aux = new frm_entrega_unidades();
            aux.Show();
        }

        private void btn_gerencial_rep_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Franco\Dropbox\AgenciaDeAutos\Reportes\gerencia.pbix");
        }
    }
}
