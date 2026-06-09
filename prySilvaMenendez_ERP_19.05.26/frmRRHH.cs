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
        private string lastCoordinates = "";
        public frmRRHH(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            perfilUsuario = perfil;
        }

        private async void txtDireccion_Leave(object sender, EventArgs e)
        {
            // When the user leaves the address textbox, try to geocode the full address
            string direccion = txtDireccion.Text.Trim();
            if (string.IsNullOrWhiteSpace(direccion))
            {
                lblCoordenadasGeo.Text = "";
                lastCoordinates = "";
                return;
            }

            // Build a query using address, locality and province if selected
            StringBuilder query = new StringBuilder();
            query.Append(direccion);
            if (cmbLocalidades.SelectedItem != null)
            {
                query.Append(", ").Append(cmbLocalidades.SelectedItem.ToString());
            }
            if (cmbsProvincias.SelectedItem != null)
            {
                query.Append(", ").Append(cmbsProvincias.SelectedItem.ToString());
            }

            try
            {
                // Use OpenStreetMap Nominatim API for geocoding (no key required)
                string url = "https://nominatim.openstreetmap.org/search?q=" + Uri.EscapeDataString(query.ToString()) + "&format=json&limit=1";
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("prySilvaMenendez_ERP/1.0");
                    var resp = await client.GetAsync(url);
                    if (!resp.IsSuccessStatusCode)
                    {
                        lblCoordenadasGeo.Text = "No se pudo obtener coordenadas";
                        lastCoordinates = "";
                        return;
                    }
                    string content = await resp.Content.ReadAsStringAsync();
                    // Parse minimal JSON to extract lat and lon
                    // Expecting an array with at least one object {"lat":"...","lon":"..."}
                    if (string.IsNullOrWhiteSpace(content) || content == "[]")
                    {
                        lblCoordenadasGeo.Text = "No encontrado";
                        lastCoordinates = "";
                        return;
                    }
                    // crude parsing without adding JSON libs
                    int latIndex = content.IndexOf("\"lat\":\"");
                    int lonIndex = content.IndexOf("\"lon\":\"");
                    if (latIndex >= 0 && lonIndex >= 0)
                    {
                        int latStart = latIndex + 7;
                        int latEnd = content.IndexOf('"', latStart);
                        int lonStart = lonIndex + 7;
                        int lonEnd = content.IndexOf('"', lonStart);
                        if (latEnd > latStart && lonEnd > lonStart)
                        {
                            string lat = content.Substring(latStart, latEnd - latStart);
                            string lon = content.Substring(lonStart, lonEnd - lonStart);
                            lastCoordinates = lat + "," + lon;
                            lblCoordenadasGeo.Text = lastCoordinates;
                            return;
                        }
                    }
                    lblCoordenadasGeo.Text = "No se pudo parsear respuesta";
                    lastCoordinates = "";
                }
            }
            catch (Exception ex)
            {
                lblCoordenadasGeo.Text = "Error: " + ex.Message;
                lastCoordinates = "";
            }
        }

        private void btnMostrarMaps_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastCoordinates))
            {
                MessageBox.Show("No hay coordenadas para mostrar. Asegúrese de que la dirección fue geocodificada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Build Google Maps url for coordinates
            // Use https://www.google.com/maps/search/?api=1&query=lat,lon
            string url = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(lastCoordinates);
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch
            {
                // Fallback for .NET Framework starting process
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("cmd", "/c start " + url) { CreateNoWindow = true });
            }
        }
        private void frmRRHH_Load(object sender, EventArgs e)
        {
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
            lblUsuario.Text = nombreUsuario;
            lblPerfil.Text = perfilUsuario;
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            clsConexion.ConexionBaseDeDatos.Desconectar();
            clsConexion.ConexionBaseDeDatos.Conectar();
            DataTable tablaLocalidades = clsConexion.ConexionBaseDeDatos.Consultar("SELECT Localidades FROM Localidades");
            foreach (DataRow fila in tablaLocalidades.Rows)
            {
                cmbLocalidades.Items.Add(fila["Localidades"].ToString());
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                cmbLocalidades.SelectedIndex == -1 ||
                cmbsProvincias.SelectedIndex == -1)
            {
                MessageBox.Show("Por Favor Complete Todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            cmbLocalidades.SelectedIndex = -1;
            cmbsProvincias.SelectedIndex = -1;
            cmbPerfiles.SelectedIndex = -1;
        }

        private void grbAgregar_Enter(object sender, EventArgs e)
        {

        }
        bool cerrando = false;
        private void btnAtras_Click(object sender, EventArgs e)
        {
            cerrando = true;
            this.Close();
        }

        private void cmbsProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsProvincias.SelectedItem == null)
            {
                return;
            }
            if (cmbsProvincias.SelectedItem.ToString() != "Córdoba")
            {
                cmbLocalidades.Enabled = false;
                cmbLocalidades.SelectedIndex = -1;
                lblMensaje.Visible = true;
            }
            else
            {
                cmbLocalidades.Enabled = true;
                lblMensaje.Visible = false;
            }
        }

        private void frmRRHH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !cerrando)
            {
                DialogResult resultado = MessageBox.Show("¿Desea Cerrar Sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
