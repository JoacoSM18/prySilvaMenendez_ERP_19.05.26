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
    public partial class frmEliminarUsuario : Form
    {
        string nombreUsuario;
        string perfilUsuario;
        public frmEliminarUsuario(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            perfilUsuario = perfil;
        }

        private void frmEliminarUsuario_Load(object sender, EventArgs e)
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
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT Nombre, Apellido FROM Usuario");
            foreach (DataRow fila in tabla.Rows)
            {
                string usuario = fila["Nombre"].ToString() + " " + fila["Apellido"].ToString();
                cmbUsuarios.Items.Add(usuario);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string usuarioSeleccionado = cmbUsuarios.SelectedItem.ToString();
            string[] datos = usuarioSeleccionado.Split(' ');
            string nombre = datos[0];
            string apellido = datos[1];
            DialogResult resultado = MessageBox.Show("¿Está Seguro que Desea Eliminar este Usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                clsConexion.ConexionBaseDeDatos.Desconectar();
                clsConexion.ConexionBaseDeDatos.Conectar();
                clsConexion.ConexionBaseDeDatos.Consultar("DELETE FROM Usuario WHERE Nombre = '" + nombre + "' AND Apellido = '" + apellido + "'");
                clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Eliminó un Usuario");
                MessageBox.Show("Usuario Eliminado Correctamente");
                cmbUsuarios.Items.Remove(usuarioSeleccionado);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (perfilUsuario == "Administrador")
            {
                frmAdmin admin = new frmAdmin(nombreUsuario, perfilUsuario);
                admin.Show();
                this.Close();
            }
            else if (perfilUsuario == "Recursos Humanos")
            {
                frmInicioSesion inicioSesion = new frmInicioSesion();
                inicioSesion.Show();
                this.Close();
            }
        }
    }
}
