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
    public partial class frmDatosContacto : Form
    {
        string nombreUsuario;
        string perfilUsuario;
        public frmDatosContacto(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            perfilUsuario = perfil;
        }

        private void frmDatosContacto_Load(object sender, EventArgs e)
        {
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM Usuario"); dgvDatosContacto.DataSource = tabla;
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
            frmAgregarDatosContacto datosContacto = new frmAgregarDatosContacto(nombreUsuario, perfilUsuario);
            datosContacto.ShowDialog();
            this.Close();
        }
    }
}
