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
    public partial class frmInicioSesion : Form
    {
        int intentos = 3;
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.Desconectar();
            clsConexion.ConexionBaseDeDatos.Conectar();
            if (cmbPerfiles.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Perfil", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string usuarioCompleto = txtUsuario.Text.Trim();
            if (usuarioCompleto.Contains(" "))
            {
                MessageBox.Show("El Usuario Debe Escribirse Sin Espacios","Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Clear();
                txtUsuario.Focus();
                return;
            }

            if (usuarioCompleto.Length < 2)
            {
                MessageBox.Show("Ingrese la Inicial del Nombre Seguida del Apellido","Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Clear();
                txtUsuario.Focus();
                return;
            }

            if (!char.IsUpper(usuarioCompleto[0]))
            {
                MessageBox.Show("La Inicial del Nombre Debe Ser MAYÚSCULA","Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Clear();
                txtUsuario.Focus();
                return;
            }
            string inicial = usuarioCompleto.Substring(0, 1);
            string apellido = usuarioCompleto.Substring(1);
            string perfilSeleccionado = cmbPerfiles.SelectedItem.ToString();
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM Usuario WHERE LEFT(Nombre, 1) = '" + inicial + "' " +"AND Apellido = '" + apellido + "' " +"AND Contraseña = '" + mskContraseña.Text.Trim() + "' " +"AND Perfil = '" + perfilSeleccionado + "' " +"AND Activo = True");
            if (tabla.Rows.Count > 0)
            {
                clsConexion.ConexionBaseDeDatos.AuditarSesion(txtUsuario.Text, true);
                string nombre = tabla.Rows[0]["Nombre"].ToString() + " " + tabla.Rows[0]["Apellido"].ToString();
                string perfilUsuario = tabla.Rows[0]["Perfil"].ToString();
                if (perfilUsuario == "Administrador")
                {
                    clsConexion.ConexionBaseDeDatos.AuditarAccion(nombre, "Ingresó a Administración");
                    frmAdmin admin = new frmAdmin(nombre, perfilUsuario);
                    admin.ShowDialog();
                    this.Close();
                }
                else if (perfilUsuario == "Recursos Humanos")
                {
                    clsConexion.ConexionBaseDeDatos.AuditarAccion(nombre, "Ingresó a Recursos Humanos");
                    frmRRHH rrhh = new frmRRHH(nombre, perfilUsuario);
                    rrhh.ShowDialog();
                    this.Close();
                }
                else
                {
                    clsConexion.ConexionBaseDeDatos.AuditarAccion(nombre, "Ingresó al Sistema");
                    frmPrincipal principal = new frmPrincipal(nombre, perfilUsuario);
                    principal.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                clsConexion.ConexionBaseDeDatos.AuditarSesion(txtUsuario.Text, false);
                intentos--;
                MessageBox.Show("Usuario o Contraseña Incorrectos, Te Quedan " + intentos + " Intentos Disponibles",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Clear();
                mskContraseña.Clear();
                cmbPerfiles.SelectedIndex = -1;

                if (intentos <= 0)
                {
                    this.Close();
                }
            }
        }
        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked)
            {
                mskContraseña.PasswordChar = '\0';
            }
            else
            {
                mskContraseña.PasswordChar = '*';
            }
        }
    }
}
