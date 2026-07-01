using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static prySilvaMenendez_ERP_19._05._26.clsConexion;

namespace prySilvaMenendez_ERP_19._05._26
{
    public partial class frmAgregarDatosContacto : Form
    {
        string nombreUsuario;
        string perfilUsuario;
        bool volviendo = false;

        public frmAgregarDatosContacto(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            perfilUsuario = perfil;
        }
        private void frmAgregarDatosContacto_Load(object sender, EventArgs e)
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
            clsConexion.ConexionBaseDeDatos.Desconectar();
            clsConexion.ConexionBaseDeDatos.Conectar();
            DataTable tabla = clsConexion.ConexionBaseDeDatos.Consultar(
    "SELECT * FROM Usuario WHERE RedSocialPrincipal = ''");

            MessageBox.Show(tabla.Rows.Count.ToString());   
            foreach (DataRow fila in tabla.Rows)
            {
                string usuario = fila["Nombre"].ToString() + " " + fila["Apellido"].ToString();
                cmbUsuarios.Items.Add(usuario);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Perfil");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtGmail.Text))
            {
                MessageBox.Show("El Gmail es Obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGmail.Focus();
                return;
            }
            if (!txtGmail.Text.Contains("@") || !txtGmail.Text.Contains("."))
            {
                MessageBox.Show("Debe Ingresar un Gmail Válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mskTelefono.Text))
            {
                MessageBox.Show("El Telefono es Obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTelefono.Focus();
                return;
            }
            if (cmbRedesSociales.SelectedIndex == -1)
            {
                MessageBox.Show("La Red Social es Obligatoria.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombreRedSocial.Text))
            {
                MessageBox.Show("El Nombre de la Red Social es Obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreRedSocial.Focus();
                return;
            }
            clsConexion.ConexionBaseDeDatos.Desconectar();
            clsConexion.ConexionBaseDeDatos.Conectar();
            string gmail = txtGmail.Text.Trim();
            string telefono = mskTelefono.Text.Trim();
            string redsocial = cmbRedesSociales.SelectedItem.ToString();
            string nombreredsocial = txtNombreRedSocial.Text.Trim();
            string activo = chkActivo.Checked ? "true" : "false";
            clsConexion.ConexionBaseDeDatos.Consultar("INSERT INTO Usuario (Gmail, Telefono, RedSocialPrincipal, NombreRedSocialPrincipal, Activo) VALUES ('" + gmail + "', '" + telefono + "', '" + redsocial + "', '" + nombreredsocial + "', " + activo + ")");
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Agregó Informacion Avanzado de un Usuario");
            MessageBox.Show("Informacion Avanzada Agregada Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtGmail.Text = "";
            mskTelefono.Text = "";
            txtNombreRedSocial.Text = "";
            cmbRedesSociales.SelectedIndex = -1;
            cmbUsuarios.SelectedIndex = -1;
            chkActivo.Checked = false;
        }
        private void cmbUsuarios_Enter(object sender, EventArgs e)
        {
            if (cmbUsuarios.Items.Count == 0)
            {
                MessageBox.Show("No Hay Usuarios Disponibles para Agregar Información");
            }
        }
        private void mskTelefono_Enter(object sender, EventArgs e)
        {
            mskTelefono.SelectionStart = 0;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            volviendo = true;
            this.Close();
        }

        private void frmAgregarDatosContacto_FormClosing(object sender, FormClosingEventArgs e)
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
