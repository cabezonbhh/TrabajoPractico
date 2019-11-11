using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeAutos.GUI.Reports
{
    public partial class frm_entrega_unidades : Form
    {
        public frm_entrega_unidades()
        {
            InitializeComponent();
        }

        private void frm_entrega_unidades_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
