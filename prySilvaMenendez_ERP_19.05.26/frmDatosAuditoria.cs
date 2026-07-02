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
    public partial class frmDatosAuditoria : Form
    {
        string nombreUsuario;
        string perfilUsuario;
        bool volviendo = false;

        public frmDatosAuditoria(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            perfilUsuario = perfil;
        }

        private void frmDatosAuditoria_Load(object sender, EventArgs e)
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
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM AuditoriaInicioSesion");
            dgvDatosAuditoriaSesion.DataSource = tabla;
            DataTable tablaUsuarios = clsConexion.ConexionBaseDeDatos.Consultar("SELECT DISTINCT Usuario FROM AuditoriaInicioSesion");
            foreach (DataRow fila in tablaUsuarios.Rows)
            {
                cmbUsuarios.Items.Add(fila["Usuario"].ToString());
            }
            DataTable tablaAcciones = clsConexion.ConexionBaseDeDatos.Consultar("SELECT DISTINCT Accion FROM AuditoriaInicioSesion WHERE Accion IS NOT NULL");
            foreach (DataRow fila in tablaAcciones.Rows)
            {
                cmbAccion.Items.Add(fila["Accion"].ToString());
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            volviendo = true;
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedIndex == -1 && cmbAccion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar al Menos un Filtro.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            DataTable tabla;
            if (cmbUsuarios.SelectedIndex != -1 && cmbAccion.SelectedIndex != -1)
            {
                tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM AuditoriaInicioSesion WHERE Usuario = '" + cmbUsuarios.Text + "' AND Accion = '" + cmbAccion.Text + "'");
            }
            else if (cmbUsuarios.SelectedIndex != -1)
            {
                tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM AuditoriaInicioSesion WHERE Usuario = '" + cmbUsuarios.Text + "'");
            }
            else
            {
                tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM AuditoriaInicioSesion WHERE Accion = '" + cmbAccion.Text + "'");
            }
            dgvDatosAuditoriaSesion.DataSource = tabla;
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No Se Encontraron Registros.","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM AuditoriaInicioSesion");
            dgvDatosAuditoriaSesion.DataSource = tabla;
            cmbUsuarios.SelectedIndex = -1;
            cmbAccion.SelectedIndex = -1; 
        }
        private void frmDatosAuditoria_FormClosing(object sender, FormClosingEventArgs e)
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
