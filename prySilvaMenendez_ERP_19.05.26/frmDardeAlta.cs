using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT DNI FROM Usuario WHERE Activo = False");
            foreach (DataRow fila in tabla.Rows)
            {
                string usuario = fila["DNI"].ToString();
                cmbUsuarios.Items.Add(usuario);
            }
        }

        private void btnDardeAlta_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string dni= cmbUsuarios.SelectedItem.ToString();
            DialogResult resultado = MessageBox.Show("¿Está Seguro que Desea Dar de Alta a este Usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                clsConexion.ConexionBaseDeDatos.Desconectar();
                clsConexion.ConexionBaseDeDatos.Conectar();
                try
                {
                    string sql = "UPDATE Usuario SET Activo = True WHERE DNI = '" + dni + "'";
                    OleDbCommand cmd = new OleDbCommand(sql, clsConexion.ConexionBaseDeDatos.conexion);
                    cmd.ExecuteNonQuery();
                    clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Dió de Alta un Usuario");
                    MessageBox.Show("Usuario Dado de Alta Correctamente");
                    cmbUsuarios.Items.Remove(dni);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Al Dar de Alta: " + ex.Message);
                }
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            volviendo = true;
            this.Close();
        }

        private void frmDardeAlta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !volviendo && !Program.SalirConfirmado)
            {
                DialogResult resultado = MessageBox.Show("¿Desea Cerrar Sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Program.SalirConfirmado = true;
                    Application.Exit();
                }
            }
        }

    }
}

