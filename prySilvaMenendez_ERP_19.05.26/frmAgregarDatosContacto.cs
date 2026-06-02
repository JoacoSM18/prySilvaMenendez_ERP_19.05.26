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
    public partial class frmAgregarDatosContacto : Form
    {
        string nombreUsuario;
        string perfilUsuario;
        public frmAgregarDatosContacto(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            perfilUsuario = perfil;
        }
        private void frmAgregarDatosContacto_Load(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.Desconectar();
            clsConexion.ConexionBaseDeDatos.Conectar();
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT Nombre, Apellido FROM Usuario");
            foreach (DataRow fila in tabla.Rows)
            {
                string usuario = fila["Nombre"].ToString() + " " + fila["Apellido"].ToString();
                cmbUsuarios.Items.Add(usuario);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Ingresó a Datos de Contacto");
            frmDatosContacto datosContacto = new frmDatosContacto();
            datosContacto.ShowDialog();
        }

        private void mskTelefono_Enter(object sender, EventArgs e)
        {
            mskTelefono.Select(0, 0);
        }
    }
}
