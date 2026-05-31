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
    public partial class frmDatosAuditoria : Form
    {
        public frmDatosAuditoria()
        {
            InitializeComponent();
        }

        private void frmDatosAuditoria_Load(object sender, EventArgs e)
        {
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM AuditoriaInicioSesion"); dgvDatosAuditoriaSesion.DataSource = tabla;
        }
    }
}
