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
            bool conectado = clsConexion.ConexionBaseDeDatos.Conectar();
            if (conectado)
            {
                statuslblEstado.Text = "Conectado a la Base de Datos";
                statuslblEstado.BackColor = Color.Green;

            }
            else
            {
                statuslblEstado.Text = "Error al Conectar a la Base de Datos";
                statuslblEstado.BackColor = Color.Red;
            }
        }

        private void btnAgregarDatosContacto_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario,"Ingresó a la Sección para Agregar Datos de Contacto");
            frmAgregarDatosContacto AgregarDatosContacto = new frmAgregarDatosContacto(nombreUsuario, perfilUsuario);
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
            frmDatosAuditoria datosAuditoria = new frmDatosAuditoria(nombreUsuario,perfilUsuario);
            datosAuditoria.ShowDialog();
        }

        private void grbAcciones_Enter(object sender, EventArgs e)
        {

        }
    }
}
