using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_ERP_19._05._26
{
    public partial class frmAgregarDatosContacto : Form
    {
        public frmAgregarDatosContacto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            frmDatosContacto datosContacto = new frmDatosContacto();
            datosContacto.ShowDialog();
        }
    }
}
