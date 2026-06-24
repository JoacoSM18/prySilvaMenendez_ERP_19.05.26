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
    public partial class frmDardeAlta : Form
    {
        string nombreUsuario;
        string perfilUsuario;
        bool volviendo = false;
        public frmDardeAlta(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            perfilUsuario = perfil;
        }
        private void frmDardeAlta_Load(object sender, EventArgs e)
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
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT Nombre, Apellido FROM Usuario WHERE Activo = False");
            foreach (DataRow fila in tabla.Rows)
            {
                string usuario = fila["Nombre"].ToString() + " " + fila["Apellido"].ToString();
                cmbUsuarios.Items.Add(usuario);
            }
        }

        private void btnDardeAlta_Click(object sender, EventArgs e)
        {

        }
    }
}
