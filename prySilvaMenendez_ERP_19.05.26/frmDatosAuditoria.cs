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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDatosAuditoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("¿Desea Cerrar Sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
