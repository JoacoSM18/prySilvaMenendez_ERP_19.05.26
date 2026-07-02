using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_ERP_19._05._26
{
    public partial class frmDardeBaja : Form
    {
        string nombreUsuario;
        string perfilUsuario;
        bool volviendo = false;

        public frmDardeBaja(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            perfilUsuario = perfil;
        }

        private void frmDardeBaja_Load(object sender, EventArgs e)
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
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT DNI FROM Usuario WHERE Activo = True");
            foreach (DataRow fila in tabla.Rows)
            {
                string usuario = fila["DNI"].ToString();
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
            string dni = cmbUsuarios.SelectedItem.ToString();
            DialogResult resultado = MessageBox.Show("¿Está Seguro que Desea Dar de Baja este Usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                clsConexion.ConexionBaseDeDatos.Desconectar();
                clsConexion.ConexionBaseDeDatos.Conectar();
                try
                {
                    string sql = "UPDATE Usuario SET Activo = False WHERE DNI = '" + dni + "'";
                    OleDbCommand cmd = new OleDbCommand(sql, clsConexion.ConexionBaseDeDatos.conexion);
                    cmd.ExecuteNonQuery();
                    clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Dió de Baja un Usuario");
                    MessageBox.Show("Usuario Dado de Baja Correctamente");
                    cmbUsuarios.Items.Remove(dni);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Al Dar de Baja: " + ex.Message);
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            volviendo = true;
            this.Close();
        }

        private void frmDardeBaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!volviendo)
            {
                DialogResult resultado = MessageBox.Show("¿Desea Cerrar Sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    volviendo = true;
                }
            }
        }
    }

}
