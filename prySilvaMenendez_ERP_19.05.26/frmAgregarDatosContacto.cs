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
            if (string.IsNullOrWhiteSpace(txtGmail.Text) ||
                string.IsNullOrWhiteSpace(txtNombreRedSocial.Text) ||
                string.IsNullOrWhiteSpace(mskTelefono.Text) ||
                cmbRedesSociales.SelectedIndex == -1 ||
                cmbUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Por Favor Complete Todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            clsConexion.ConexionBaseDeDatos.Desconectar();
            clsConexion.ConexionBaseDeDatos.Conectar();
            if (cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Perfil");
                return;
            }
            string gmail = txtGmail.Text.Trim();
            string telefono = mskTelefono.Text.Trim();
            string redsocial = cmbRedesSociales.SelectedItem.ToString();
            string nombreredsocial = txtNombreRedSocial.Text.Trim();
            string activo = chkActivo.Checked ? "true" : "false";
            clsConexion.ConexionBaseDeDatos.Consultar("INSERT INTO Usuario (Gmail, Telefono, RedSocial, NombreRedSocial, Activo) VALUES ('" + gmail + "', '" + telefono + "', '" + redsocial + "', '" + nombreredsocial + "', " + activo + ")");
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Agregó un Usuario");
            MessageBox.Show("Usuario Agregado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtGmail.Text = "";
            mskTelefono.Text = "";
            txtNombreRedSocial.Text = "";
            cmbRedesSociales.SelectedIndex = -1;
            cmbUsuarios.SelectedIndex = -1;
            chkActivo.Checked = false;
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin(nombreUsuario, perfilUsuario);
            admin.ShowDialog();
            this.Close();
        }
    }
}
