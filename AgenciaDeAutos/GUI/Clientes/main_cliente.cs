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
    public partial class main_cliente : Form
    {
        private ClienteService service;
        public main_cliente()
        {
            InitializeComponent();
            service = new ClienteService();
        }

        private void cargarGrilla()
        {
            IList<Cliente> clientes = service.obtenerClientes();
            dgv_clientes.Rows.Clear();
            foreach(Cliente cliente in clientes)
            {
                dgv_clientes.Rows.Add(new Object[] { cliente.IdCliente.ToString(), cliente.Nombre.ToString(), cliente.Apellido.ToString(), cliente.Dni.ToString()});
            }
        }

        private void main_cliente_Load(object sender, EventArgs e)
        {
            this.cargarGrilla();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Form aux = new frm_nuevo_cliente(service);
            aux.ShowDialog();
            this.Dispose();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_clientes.CurrentRow != null)
            {
                service.ClienteSeleccionado = Convert.ToInt32(dgv_clientes.CurrentRow.Cells["col_id_cliente"].Value.ToString());
                this.Dispose();
                new frm_edit_cliente(service).ShowDialog();
            }
            else
                MessageBox.Show("No ha seleccionado ningun cliente","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_clientes.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminar el cliente?", "ALETA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgv_clientes.CurrentRow.Cells["col_id_cliente"].Value);
                    bool respuesta = service.borrarCliente(id);
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
                MessageBox.Show("No se selecciono ningun cliente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.cargarGrilla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cancelar", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
                this.Dispose();
        }
    }
}
