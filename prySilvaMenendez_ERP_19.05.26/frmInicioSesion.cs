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
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.Conectar();
            clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM Usuarios WHERE Usuario = '" + txtNombre.Text + "' AND Contraseña = '" + mskContraseña.Text + "'");
            if (txtNombre.Text == "admin" && mskContraseña.Text == "1234")
            {
                frmPrincipal Principal = new frmPrincipal();
                Principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
