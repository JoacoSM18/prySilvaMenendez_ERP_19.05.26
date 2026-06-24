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
        private bool isGeocoding = false;
        private Task<string> geocodeTask = null;

        public frmRRHH(string nombre, string perfil)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            perfilUsuario = perfil;
        }

        private async void txtDireccion_Leave(object sender, EventArgs e)
        {
            await EnsureGeocodedAsync().ConfigureAwait(false);
        }
        private Task<string> EnsureGeocodedAsync()
        {
            if (isGeocoding && geocodeTask != null)
            {
                return geocodeTask;
            }

            geocodeTask = GeocodeAddressInternalAsync();
            return geocodeTask;
        }

        private async Task<string> GeocodeAddressInternalAsync()
        {
            if (isGeocoding)
            {
                if (geocodeTask != null)
                {
                    return await geocodeTask;
                }
            }

            isGeocoding = true;
            try
            {
                string direccion = string.Empty;
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => direccion = txtDireccion.Text.Trim()));
                }
                else
                {
                    direccion = txtDireccion.Text.Trim();
                }

                if (string.IsNullOrWhiteSpace(direccion))
                {
                    this.InvokeIfRequired(() => lblCoordenadasGeo.Text = "");
                    lastCoordinates = "";
                    return lastCoordinates;
                }

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

                string url = "https://nominatim.openstreetmap.org/search?q=" + Uri.EscapeDataString(query.ToString()) + "&format=json&limit=1";
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("prySilvaMenendez_ERP/1.0");
                    System.Net.Http.HttpResponseMessage resp = null;
                    try
                    {
                        resp = await client.GetAsync(url);
                    }
                    catch (Exception exHttp)
                    {
                        this.InvokeIfRequired(() => lblCoordenadasGeo.Text = "Error: " + exHttp.Message);
                        lastCoordinates = "";
                        return lastCoordinates;
                    }

                    if (!resp.IsSuccessStatusCode)
                    {
                        this.InvokeIfRequired(() => lblCoordenadasGeo.Text = "No se pudo obtener coordenadas");
                        lastCoordinates = "";
                        return lastCoordinates;
                    }

                    string content = await resp.Content.ReadAsStringAsync();
                    if (string.IsNullOrWhiteSpace(content) || content == "[]")
                    {
                        this.InvokeIfRequired(() => lblCoordenadasGeo.Text = "No encontrado");
                        lastCoordinates = "";
                        return lastCoordinates;
                    }

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
                            this.InvokeIfRequired(() => lblCoordenadasGeo.Text = lastCoordinates);
                            return lastCoordinates;
                        }
                    }

                    this.InvokeIfRequired(() => lblCoordenadasGeo.Text = "No se pudo parsear respuesta");
                    lastCoordinates = "";
                    return lastCoordinates;
                }
            }
            catch (Exception ex)
            {
                this.InvokeIfRequired(() => lblCoordenadasGeo.Text = "Error: " + ex.Message);
                lastCoordinates = "";
                return lastCoordinates;
            }
            finally
            {
                isGeocoding = false;
                geocodeTask = null;
            }
        }

        private async void btnMostrarMaps_Click(object sender, EventArgs e)
        {
            string coords = await EnsureGeocodedAsync();
            if (string.IsNullOrWhiteSpace(coords))
            {
                MessageBox.Show("No hay coordenadas para mostrar. Asegúrese de que la dirección fue geocodificada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string url = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(coords);
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch
            {
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
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El DNI es Obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El Nombre es Obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El Apellido es Obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbPerfiles.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Perfil");
                return;
            }
            if (cmbsProvincias.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una Provincia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbLocalidades.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una Localidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La Dirección es Obligatoria.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!txtNombre.Text.All(char.IsLetter))
            {
                MessageBox.Show("El Nombre Solo Debe Contener Letras.");
                return;
            }
            
            clsConexion.ConexionBaseDeDatos.Desconectar();
            clsConexion.ConexionBaseDeDatos.Conectar();
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

        private void btnAgregarDatosContacto_Click(object sender, EventArgs e)
        {
            clsConexion.ConexionBaseDeDatos.AuditarAccion(nombreUsuario, "Ingresó a la Sección para Agregar Datos de Contacto");
            frmAgregarDatosContacto AgregarDatosContacto = new frmAgregarDatosContacto(nombreUsuario, perfilUsuario);
            this.Hide();
            AgregarDatosContacto.ShowDialog();
            this.Show();
        }
    }
    static class ControlExtensions
    {
        public static void InvokeIfRequired(this Control c, Action action)
        {
            if (c == null) return;
            if (c.InvokeRequired)
            {
                c.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
