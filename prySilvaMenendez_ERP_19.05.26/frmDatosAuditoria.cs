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
        string nombreUsuario;
        string perfilUsuario;
        public frmDatosAuditoria(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            perfilUsuario = perfil;
        }

        private void frmDatosAuditoria_Load(object sender, EventArgs e)
        {
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM AuditoriaInicioSesion"); dgvDatosAuditoriaSesion.DataSource = tabla;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin(nombreUsuario,perfilUsuario);
            admin.ShowDialog();
        }
    }
}
