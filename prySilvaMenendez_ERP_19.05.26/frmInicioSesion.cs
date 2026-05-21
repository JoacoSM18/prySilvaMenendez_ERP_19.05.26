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
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM Usuarios WHERE Gmail = '" + txtNombre.Text + "' AND Contraseña = '" + mskContraseña.Text + "'");
            if (tabla.Rows.Count > 0)
            {
                frmPrincipal Principal = new frmPrincipal();
                Principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
            }
        }
    }
}
