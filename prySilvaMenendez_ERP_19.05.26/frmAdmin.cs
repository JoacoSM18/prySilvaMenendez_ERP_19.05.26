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
    public partial class frmAdmin : Form
    {
        string nombreUsuario;
        string perfilUsuario;
        public frmAdmin(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            perfilUsuario = perfil;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = nombreUsuario;
            lblPerfil.Text = perfilUsuario;
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnVerDatosContacto_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario,"Ingresó a Datos de Contacto");
            frmAgregarDatosContacto AgregarDatosContacto = new frmAgregarDatosContacto();
            AgregarDatosContacto.ShowDialog();
        }

        private void btnRRHH_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Ingresó a Recursos Humanos");
            frmRRHH RRHH = new frmRRHH(nombreUsuario, perfilUsuario);
            RRHH.ShowDialog();
        }

        private void btnVerAuditoria_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Ingresó a Datos de Auditoria");
            frmDatosAuditoria datosAuditoria = new frmDatosAuditoria();
            datosAuditoria.ShowDialog();
        }
    }
}
