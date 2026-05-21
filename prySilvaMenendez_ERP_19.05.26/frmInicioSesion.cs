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
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM Usuario WHERE Gmail = '" + txtNombre.Text + "' AND Contraseña = '" + mskContraseña.Text.Trim() + "'");
            if (tabla.Rows.Count > 0)
            {
                clsConexion.ConexionBaseDeDatos.AuditarSesion(txtNombre.Text, true);
                string nombre = tabla.Rows[0]["Nombre"].ToString();
                string perfil = tabla.Rows[0]["Perfil"].ToString();
                if (perfil == "Administrador")
                {
                    frmAdmin admin = new frmAdmin();
                    admin.ShowDialog();
                }
                else if (perfil == "Recursos Humanos")
                {
                    frmRRHH rrhh = new frmRRHH();
                    rrhh.ShowDialog();
                }
                else
                {
                    frmPrincipal Principal = new frmPrincipal(nombre, perfil);
                    Principal.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                clsConexion.ConexionBaseDeDatos.AuditarSesion(txtNombre.Text, false);
                intentos--;
                MessageBox.Show("Usuario o Contraseña Incorrectos, Te Quedan " + intentos + " Intentos Disponibles", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (intentos <= 0) 
                {
                    this.Close();
                }
            }

            
        }
        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
