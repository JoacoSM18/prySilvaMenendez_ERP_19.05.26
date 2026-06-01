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
    public partial class frmRRHH : Form
    {
        string nombreUsuario;
        string perfilUsuario;
        public frmRRHH(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            perfilUsuario = perfil;
        }
        private void frmRRHH_Load(object sender, EventArgs e)
        {

            lblUsuario.Text = nombreUsuario;
            lblPerfil.Text = perfilUsuario;
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            clsConexion.ConexionBaseDeDatos.Desconectar();
            clsConexion.ConexionBaseDeDatos.Conectar();
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT Nombre, Apellido FROM Usuario");
            foreach (DataRow fila in tabla.Rows)
            {
                string usuario = fila["Nombre"].ToString() + " " + fila["Apellido"].ToString();
                cmbUsuarios.Items.Add(usuario);
            }
            DataTable tablaLocalidades = clsConexion.ConexionBaseDeDatos.Consultar("SELECT Localidades FROM Localidades");
            MessageBox.Show("Filas: " + tablaLocalidades.Rows.Count.ToString());
            foreach (DataRow fila in tablaLocalidades.Rows)
            {
                cmbLocalidades.Items.Add(fila["Localidades"].ToString());
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.Desconectar();
            clsConexion.ConexionBaseDeDatos.Conectar();
            if (cmbPerfiles.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Perfil");
                return;
            }
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string perfil = cmbPerfiles.SelectedItem.ToString();
            string dni = txtDNI.Text.Trim();
            string provincia = cmbsProvincias.SelectedItem.ToString();
            string localidad = cmbLocalidades.SelectedItem.ToString();
            string direccion = txtDireccion.Text.Trim();
            clsConexion.ConexionBaseDeDatos.Consultar("INSERT INTO Usuario (Nombre, Apellido, Perfil, DNI, Provincia, Localidad, Direccion) VALUES ('" + nombre + "', '" + apellido + "', '" + perfil + "', '" + dni + "', '" + provincia + "', '" + localidad + "', '" + direccion + "')" );
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario,"Agregó un Usuario");
            MessageBox.Show("Usuario Agregado Correctamente","Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario,"Eliminó un Usuario");
                MessageBox.Show("Usuario Eliminado Correctamente");
                cmbUsuarios.Items.Remove(usuarioSeleccionado);
            }
        }
    }
}
