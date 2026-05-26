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
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grbAgregar.SuspendLayout();
            this.lblDomicilio.SuspendLayout();
            this.grbEliminar.SuspendLayout();
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
            this.grbAgregar.Location = new System.Drawing.Point(9, 70);
            this.grbAgregar.Name = "grbAgregar";
            this.grbAgregar.Size = new System.Drawing.Size(581, 214);
            this.grbAgregar.TabIndex = 0;
            this.grbAgregar.TabStop = false;
            this.grbAgregar.Text = "Agregar Usuario";
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
            this.cmbPerfiles.Location = new System.Drawing.Point(64, 145);
            this.cmbPerfiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.Size = new System.Drawing.Size(121, 28);
            this.cmbPerfiles.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 109);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(94, 26);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(78, 73);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(94, 26);
            this.txtApellido.TabIndex = 9;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(78, 39);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(94, 26);
            this.txtDNI.TabIndex = 8;
            // 
            // lblAgregarPerfil
            // 
            this.lblAgregarPerfil.AutoSize = true;
            this.lblAgregarPerfil.Location = new System.Drawing.Point(5, 151);
            this.lblAgregarPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgregarPerfil.Name = "lblAgregarPerfil";
            this.lblAgregarPerfil.Size = new System.Drawing.Size(48, 20);
            this.lblAgregarPerfil.TabIndex = 7;
            this.lblAgregarPerfil.Text = "Perfil:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(469, 181);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Controls.Add(this.lblCoordenadasGeo);
            this.lblDomicilio.Controls.Add(this.cmbLocalidades);
            this.lblDomicilio.Controls.Add(this.cmbsProvincias);
            this.lblDomicilio.Controls.Add(this.txtDireccion);
            this.lblDomicilio.Controls.Add(this.lblGeo);
            this.lblDomicilio.Controls.Add(this.lblDireccion);
            this.lblDomicilio.Controls.Add(this.lblLocalidad);
            this.lblDomicilio.Controls.Add(this.lblProvincia);
            this.lblDomicilio.Location = new System.Drawing.Point(200, 17);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(375, 153);
            this.lblDomicilio.TabIndex = 5;
            this.lblDomicilio.TabStop = false;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblCoordenadasGeo
            // 
            this.lblCoordenadasGeo.Location = new System.Drawing.Point(81, 126);
            this.lblCoordenadasGeo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoordenadasGeo.Name = "lblCoordenadasGeo";
            this.lblCoordenadasGeo.Size = new System.Drawing.Size(140, 19);
            this.lblCoordenadasGeo.TabIndex = 7;
            this.lblCoordenadasGeo.Text = " ";
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(84, 56);
            this.cmbLocalidades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(138, 28);
            this.cmbLocalidades.TabIndex = 6;
            // 
            // cmbsProvincias
            // 
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
            "Tierra del Fueg",
            "Tucumán"});
            this.cmbsProvincias.Location = new System.Drawing.Point(84, 21);
            this.cmbsProvincias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbsProvincias.Name = "cmbsProvincias";
            this.cmbsProvincias.Size = new System.Drawing.Size(130, 28);
            this.cmbsProvincias.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(84, 92);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(138, 26);
            this.txtDireccion.TabIndex = 4;
            // 
            // lblGeo
            // 
            this.lblGeo.AutoSize = true;
            this.lblGeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeo.Location = new System.Drawing.Point(2, 128);
            this.lblGeo.Name = "lblGeo";
            this.lblGeo.Size = new System.Drawing.Size(41, 18);
            this.lblGeo.TabIndex = 3;
            this.lblGeo.Text = "Geo:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(2, 98);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 18);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(2, 62);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(75, 18);
            this.lblLocalidad.TabIndex = 1;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(2, 25);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(73, 18);
            this.lblProvincia.TabIndex = 0;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(5, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(5, 79);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(63, 18);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(5, 45);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(37, 18);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.lblEliminar);
            this.grbEliminar.Controls.Add(this.cmbUsuarios);
            this.grbEliminar.Controls.Add(this.btnEliminar);
            this.grbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEliminar.Location = new System.Drawing.Point(8, 296);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Size = new System.Drawing.Size(303, 148);
            this.grbEliminar.TabIndex = 1;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Eliminar Usuario";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(2, 31);
            this.lblEliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(248, 17);
            this.lblEliminar.TabIndex = 2;
            this.lblEliminar.Text = "Seleccione un Usuario para Eliminarlo";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(9, 56);
            this.cmbUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(177, 28);
            this.cmbUsuarios.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(188, 86);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 30);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(2, 37);
            this.lblFechaHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(88, 16);
            this.lblFechaHora.TabIndex = 6;
            this.lblFechaHora.Text = "Fecha y Hora";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(2, 21);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(37, 16);
            this.lblPerfil.TabIndex = 5;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(2, 6);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // frmRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 469);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRRHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos Humanos";
            this.Load += new System.EventHandler(this.frmRRHH_Load);
            this.grbAgregar.ResumeLayout(false);
            this.grbAgregar.PerformLayout();
            this.lblDomicilio.ResumeLayout(false);
            this.lblDomicilio.PerformLayout();
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAgregar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.GroupBox grbEliminar;
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
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.ComboBox cmbPerfiles;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblAgregarPerfil;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.ComboBox cmbsProvincias;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblCoordenadasGeo;
    }
}