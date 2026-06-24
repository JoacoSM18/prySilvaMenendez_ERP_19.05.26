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
        bool cerrarSesion = false;

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
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Ingresó a la Sección para Agregar Datos de Contacto");
            frmAgregarDatosContacto AgregarDatosContacto = new frmAgregarDatosContacto(nombreUsuario, perfilUsuario);
            this.Hide();
            AgregarDatosContacto.ShowDialog();
            this.Show();
        }
        private void btnRRHH_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Ingresó a Recursos Humanos");
            frmRRHH RRHH = new frmRRHH(nombreUsuario, perfilUsuario);
            this.Hide();
            RRHH.ShowDialog();
            this.Show();
        }
        private void btnVerAuditoria_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Ingresó a Datos de Auditoria");
            frmDatosAuditoria datosAuditoria = new frmDatosAuditoria(nombreUsuario, perfilUsuario);
            this.Hide();
            datosAuditoria.ShowDialog();
            this.Show();
        }
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Ingresó a la Sección para Dar de Baja un Usuario");
            frmDardeBaja darDeBajaUsuario = new frmDardeBaja(nombreUsuario, perfilUsuario);
            this.Hide();
            darDeBajaUsuario.ShowDialog();
            this.Show();
        }
        private void btnDardeAltaUsuario_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Ingresó a la Sección para Dar de Alta un Usuario");
            frmDardeAlta darDeAltaUsuario = new frmDardeAlta(nombreUsuario, perfilUsuario);
            this.Hide();
            darDeAltaUsuario.ShowDialog();
            this.Show();
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Ingresó a Datos de Contacto");
            frmDatosContacto datosContacto = new frmDatosContacto(nombreUsuario, perfilUsuario);
            datosContacto.ShowDialog();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            cerrarSesion = true;
            this.Close();
        }
        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrarSesion)
            {
                DialogResult resultado = MessageBox.Show("¿Desea Cerrar Sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    cerrarSesion = true;
                }
            }
        }
    }
}
