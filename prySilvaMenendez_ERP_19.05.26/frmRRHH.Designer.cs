namespace prySilvaMenendez_ERP_19._05._26
{
    partial class frmRRHH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRRHH));
            this.grbAgregar = new System.Windows.Forms.GroupBox();
            this.cmbPerfiles = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblAgregarPerfil = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblDomicilio = new System.Windows.Forms.GroupBox();
            this.btnMostrarMaps = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblCoordenadasGeo = new System.Windows.Forms.Label();
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.cmbsProvincias = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblGeo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAgregarDatosContacto = new System.Windows.Forms.Button();
            this.grbAgregar.SuspendLayout();
            this.lblDomicilio.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAgregar
            // 
            this.grbAgregar.Controls.Add(this.cmbPerfiles);
            this.grbAgregar.Controls.Add(this.txtNombre);
            this.grbAgregar.Controls.Add(this.txtApellido);
            this.grbAgregar.Controls.Add(this.txtDNI);
            this.grbAgregar.Controls.Add(this.lblAgregarPerfil);
            this.grbAgregar.Controls.Add(this.btnAgregar);
            this.grbAgregar.Controls.Add(this.lblDomicilio);
            this.grbAgregar.Controls.Add(this.lblNombre);
            this.grbAgregar.Controls.Add(this.lblApellido);
            this.grbAgregar.Controls.Add(this.lblDNI);
            this.grbAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAgregar.Location = new System.Drawing.Point(14, 108);
            this.grbAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbAgregar.Name = "grbAgregar";
            this.grbAgregar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbAgregar.Size = new System.Drawing.Size(890, 334);
            this.grbAgregar.TabIndex = 0;
            this.grbAgregar.TabStop = false;
            this.grbAgregar.Text = "Agregar Usuario";
            this.grbAgregar.Enter += new System.EventHandler(this.grbAgregar_Enter);
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfiles.FormattingEnabled = true;
            this.cmbPerfiles.Items.AddRange(new object[] {
            "Administrador",
            "Cliente",
            "Moderador",
            "Editor",
            "Recursos Humanos",
            "Gerente",
            "Soporte Tecnico",
            "Community Manager",
            "Diseñador",
            "Vendedor"});
            this.cmbPerfiles.Location = new System.Drawing.Point(96, 223);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.Size = new System.Drawing.Size(180, 37);
            this.cmbPerfiles.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 168);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 35);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(117, 112);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(139, 35);
            this.txtApellido.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(117, 60);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(139, 35);
            this.txtDNI.TabIndex = 0;
            // 
            // lblAgregarPerfil
            // 
            this.lblAgregarPerfil.AutoSize = true;
            this.lblAgregarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarPerfil.Location = new System.Drawing.Point(8, 232);
            this.lblAgregarPerfil.Name = "lblAgregarPerfil";
            this.lblAgregarPerfil.Size = new System.Drawing.Size(68, 26);
            this.lblAgregarPerfil.TabIndex = 7;
            this.lblAgregarPerfil.Text = "Perfil:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(704, 283);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 43);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Controls.Add(this.btnMostrarMaps);
            this.lblDomicilio.Controls.Add(this.lblMensaje);
            this.lblDomicilio.Controls.Add(this.lblCoordenadasGeo);
            this.lblDomicilio.Controls.Add(this.cmbLocalidades);
            this.lblDomicilio.Controls.Add(this.cmbsProvincias);
            this.lblDomicilio.Controls.Add(this.txtDireccion);
            this.lblDomicilio.Controls.Add(this.lblGeo);
            this.lblDomicilio.Controls.Add(this.lblDireccion);
            this.lblDomicilio.Controls.Add(this.lblLocalidad);
            this.lblDomicilio.Controls.Add(this.lblProvincia);
            this.lblDomicilio.Location = new System.Drawing.Point(300, 26);
            this.lblDomicilio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblDomicilio.Size = new System.Drawing.Size(570, 240);
            this.lblDomicilio.TabIndex = 5;
            this.lblDomicilio.TabStop = false;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // btnMostrarMaps
            // 
            this.btnMostrarMaps.Location = new System.Drawing.Point(333, 194);
            this.btnMostrarMaps.Name = "btnMostrarMaps";
            this.btnMostrarMaps.Size = new System.Drawing.Size(230, 43);
            this.btnMostrarMaps.TabIndex = 9;
            this.btnMostrarMaps.Text = "Mostrar en Maps";
            this.btnMostrarMaps.UseVisualStyleBackColor = true;
            this.btnMostrarMaps.Click += new System.EventHandler(this.btnMostrarMaps_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(340, 86);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(176, 52);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.Text = "No Disponible Para Su Provincia";
            this.lblMensaje.Visible = false;
            // 
            // lblCoordenadasGeo
            // 
            this.lblCoordenadasGeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordenadasGeo.Location = new System.Drawing.Point(122, 194);
            this.lblCoordenadasGeo.Name = "lblCoordenadasGeo";
            this.lblCoordenadasGeo.Size = new System.Drawing.Size(188, 29);
            this.lblCoordenadasGeo.TabIndex = 7;
            this.lblCoordenadasGeo.Text = " ";
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(126, 86);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(205, 37);
            this.cmbLocalidades.TabIndex = 6;
            // 
            // cmbsProvincias
            // 
            this.cmbsProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsProvincias.FormattingEnabled = true;
            this.cmbsProvincias.Items.AddRange(new object[] {
            "Buenos Aires",
            "Ciudad Autónoma de Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego",
            "Tucumán"});
            this.cmbsProvincias.Location = new System.Drawing.Point(126, 32);
            this.cmbsProvincias.Name = "cmbsProvincias";
            this.cmbsProvincias.Size = new System.Drawing.Size(205, 37);
            this.cmbsProvincias.TabIndex = 5;
            this.cmbsProvincias.SelectedIndexChanged += new System.EventHandler(this.cmbsProvincias_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(126, 142);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(205, 35);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // lblGeo
            // 
            this.lblGeo.AutoSize = true;
            this.lblGeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeo.Location = new System.Drawing.Point(3, 197);
            this.lblGeo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeo.Name = "lblGeo";
            this.lblGeo.Size = new System.Drawing.Size(59, 26);
            this.lblGeo.TabIndex = 3;
            this.lblGeo.Text = "Geo:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(3, 151);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(109, 26);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(3, 95);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(111, 26);
            this.lblLocalidad.TabIndex = 1;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(3, 38);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(108, 26);
            this.lblProvincia.TabIndex = 0;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(8, 175);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 26);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(8, 122);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(96, 26);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(8, 69);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(56, 26);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(15, 49);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(104, 20);
            this.lblFechaHora.TabIndex = 6;
            this.lblFechaHora.Text = "Fecha y Hora";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(15, 25);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(44, 20);
            this.lblPerfil.TabIndex = 5;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(15, 2);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(14, 466);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(108, 49);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(927, 32);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslblEstado
            // 
            this.statuslblEstado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.statuslblEstado.Name = "statuslblEstado";
            this.statuslblEstado.Size = new System.Drawing.Size(331, 25);
            this.statuslblEstado.Text = "Estado de Conexion de la Base de Datos";
            // 
            // btnAgregarDatosContacto
            // 
            this.btnAgregarDatosContacto.BackColor = System.Drawing.SystemColors.Window;
            this.btnAgregarDatosContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDatosContacto.Location = new System.Drawing.Point(520, 470);
            this.btnAgregarDatosContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarDatosContacto.Name = "btnAgregarDatosContacto";
            this.btnAgregarDatosContacto.Size = new System.Drawing.Size(384, 43);
            this.btnAgregarDatosContacto.TabIndex = 9;
            this.btnAgregarDatosContacto.Text = "Agregar Datos de Contacto Avanzados";
            this.btnAgregarDatosContacto.UseVisualStyleBackColor = false;
            this.btnAgregarDatosContacto.Click += new System.EventHandler(this.btnAgregarDatosContacto_Click);
            // 
            // frmRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(927, 569);
            this.Controls.Add(this.btnAgregarDatosContacto);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.grbAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRRHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos Humanos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRRHH_FormClosing);
            this.Load += new System.EventHandler(this.frmRRHH_Load);
            this.grbAgregar.ResumeLayout(false);
            this.grbAgregar.PerformLayout();
            this.lblDomicilio.ResumeLayout(false);
            this.lblDomicilio.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAgregar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox lblDomicilio;
        private System.Windows.Forms.Label lblGeo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbPerfiles;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblAgregarPerfil;
        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.ComboBox cmbsProvincias;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblCoordenadasGeo;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslblEstado;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnMostrarMaps;
        private System.Windows.Forms.Button btnAgregarDatosContacto;
    }
}