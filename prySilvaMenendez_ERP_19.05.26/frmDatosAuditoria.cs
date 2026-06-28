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
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM AuditoriaInicioSesion");
            dgvDatosAuditoriaSesion.DataSource = tabla;
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
            cmbAccion.Items.Add("Ingreso a Administracion");
            cmbAccion.Items.Add("Ingreso a Recursos Humanos");
            cmbAccion.Items.Add("Ingreso al Sistema");
            cmbAccion.Items.Add("Ingreso a la Sección para Agregar Datos de Contacto Avanzados");
            cmbAccion.Items.Add("Se Agregó un Usuario");
            cmbAccion.Items.Add("Ingreso a Datos de Contacto");
            cmbAccion.Items.Add("Ingresó a la Sección para Dar de Alta un Usuario");
            cmbAccion.Items.Add("Ingresó a la Sección para Dar de Baja un Usuario");
            cmbAccion.Items.Add("Ingresó a Datos de Auditoria");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            volviendo = true;
            this.Close();
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtp1.Value.Date < dtp2.Value.Date)
            {
                MessageBox.Show("La Fecha Hasta no Puede ser Menor que la Fecha Desde.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbUsuarios.SelectedIndex == -1 && cmbAccion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar al Menos un Filtro.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbUsuarios.SelectedIndex != -1 && cmbAccion.SelectedIndex != -1)
            {
                DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM AuditoriaInicioSesion WHERE Usuario = '" + cmbUsuarios.Text + "' AND Accion = '" + cmbAccion.Text + "'");
                dgvDatosAuditoriaSesion.DataSource = tabla;
            }
            else if (cmbUsuarios.SelectedIndex != -1)
            {
                DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar( "SELECT * FROM AuditoriaInicioSesion WHERE Usuario = '" + cmbUsuarios.Text + "'");
                dgvDatosAuditoriaSesion.DataSource = tabla;
            }
            else if (cmbAccion.SelectedIndex != -1)
            {
                DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM AuditoriaInicioSesion WHERE Accion = '" + cmbAccion.Text + "'");
                dgvDatosAuditoriaSesion.DataSource = tabla;
            }
        }
        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar("SELECT * FROM AuditoriaInicioSesion");
            dgvDatosAuditoriaSesion.DataSource = tabla;
            cmbUsuarios.SelectedIndex = -1;
            cmbAccion.SelectedIndex = -1; 
        }
    }
}
