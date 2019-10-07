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
    }
}
