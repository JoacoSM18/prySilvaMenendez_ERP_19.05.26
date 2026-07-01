namespace prySilvaMenendez_ERP_19._05._26
{
    partial class frmAgregarDatosContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarDatosContacto));
            this.grbContacto = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreRedSocial = new System.Windows.Forms.TextBox();
            this.cmbRedesSociales = new System.Windows.Forms.ComboBox();
            this.lblUsuarioRedSocial = new System.Windows.Forms.Label();
            this.lblRedSocial = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblGmail = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblUusario = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grbContacto.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbContacto
            // 
            this.grbContacto.Controls.Add(this.button1);
            this.grbContacto.Controls.Add(this.txtGmail);
            this.grbContacto.Controls.Add(this.mskTelefono);
            this.grbContacto.Controls.Add(this.txtNombreRedSocial);
            this.grbContacto.Controls.Add(this.cmbRedesSociales);
            this.grbContacto.Controls.Add(this.lblUsuarioRedSocial);
            this.grbContacto.Controls.Add(this.lblRedSocial);
            this.grbContacto.Controls.Add(this.lblTelefono);
            this.grbContacto.Controls.Add(this.lblGmail);
            this.grbContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbContacto.Location = new System.Drawing.Point(21, 214);
            this.grbContacto.Name = "grbContacto";
            this.grbContacto.Size = new System.Drawing.Size(704, 275);
            this.grbContacto.TabIndex = 0;
            this.grbContacto.TabStop = false;
            this.grbContacto.Text = "Contacto";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(453, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregue Otra Red Social";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtGmail
            // 
            this.txtGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGmail.Location = new System.Drawing.Point(188, 40);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(210, 32);
            this.txtGmail.TabIndex = 8;
            // 
            // mskTelefono
            // 
            this.mskTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefono.Location = new System.Drawing.Point(188, 98);
            this.mskTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskTelefono.Mask = "000-000-0000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(142, 32);
            this.mskTelefono.TabIndex = 7;
            this.mskTelefono.Enter += new System.EventHandler(this.mskTelefono_Enter);
            // 
            // txtNombreRedSocial
            // 
            this.txtNombreRedSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRedSocial.Location = new System.Drawing.Point(408, 214);
            this.txtNombreRedSocial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreRedSocial.Name = "txtNombreRedSocial";
            this.txtNombreRedSocial.Size = new System.Drawing.Size(212, 32);
            this.txtNombreRedSocial.TabIndex = 6;
            // 
            // cmbRedesSociales
            // 
            this.cmbRedesSociales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRedesSociales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRedesSociales.FormattingEnabled = true;
            this.cmbRedesSociales.Items.AddRange(new object[] {
            "Instagram",
            "Facebook",
            "Twitter",
            "Tik Tok",
            "Telegram"});
            this.cmbRedesSociales.Location = new System.Drawing.Point(188, 152);
            this.cmbRedesSociales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRedesSociales.Name = "cmbRedesSociales";
            this.cmbRedesSociales.Size = new System.Drawing.Size(210, 34);
            this.cmbRedesSociales.TabIndex = 5;
            // 
            // lblUsuarioRedSocial
            // 
            this.lblUsuarioRedSocial.AutoSize = true;
            this.lblUsuarioRedSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioRedSocial.Location = new System.Drawing.Point(20, 223);
            this.lblUsuarioRedSocial.Name = "lblUsuarioRedSocial";
            this.lblUsuarioRedSocial.Size = new System.Drawing.Size(349, 26);
            this.lblUsuarioRedSocial.TabIndex = 4;
            this.lblUsuarioRedSocial.Text = "Nombre de Usuario en Red Social:\r\n";
            // 
            // lblRedSocial
            // 
            this.lblRedSocial.AutoSize = true;
            this.lblRedSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedSocial.Location = new System.Drawing.Point(20, 165);
            this.lblRedSocial.Name = "lblRedSocial";
            this.lblRedSocial.Size = new System.Drawing.Size(118, 26);
            this.lblRedSocial.TabIndex = 3;
            this.lblRedSocial.Text = "Red Social";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(20, 108);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(101, 26);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmail.Location = new System.Drawing.Point(20, 49);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(76, 26);
            this.lblGmail.TabIndex = 1;
            this.lblGmail.Text = "Gmail:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(622, 562);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 46);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.BackColor = System.Drawing.SystemColors.Control;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(156, 511);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(22, 21);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.UseVisualStyleBackColor = false;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(46, 506);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(78, 26);
            this.lblActivo.TabIndex = 5;
            this.lblActivo.Text = "Activo:";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(45, 152);
            this.cmbUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(180, 34);
            this.cmbUsuarios.TabIndex = 6;
            this.cmbUsuarios.Enter += new System.EventHandler(this.cmbUsuarios_Enter);
            // 
            // lblUusario
            // 
            this.lblUusario.AutoSize = true;
            this.lblUusario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUusario.Location = new System.Drawing.Point(40, 120);
            this.lblUusario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUusario.Name = "lblUusario";
            this.lblUusario.Size = new System.Drawing.Size(400, 26);
            this.lblUusario.TabIndex = 7;
            this.lblUusario.Text = "Elija un Usuario para Agregar sus Datos";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(21, 562);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(112, 46);
            this.btnAtras.TabIndex = 8;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 634);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslblEstado
            // 
            this.statuslblEstado.Name = "statuslblEstado";
            this.statuslblEstado.Size = new System.Drawing.Size(331, 25);
            this.statuslblEstado.Text = "Estado de Conexion de la Base de Datos";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(14, 57);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(104, 20);
            this.lblFechaHora.TabIndex = 12;
            this.lblFechaHora.Text = "Fecha y Hora";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(14, 29);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(44, 20);
            this.lblPerfil.TabIndex = 11;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(14, 2);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario";
            // 
            // frmAgregarDatosContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblUusario);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grbContacto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarDatosContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Datos de Contacto Avanzados de los Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgregarDatosContacto_FormClosing);
            this.Load += new System.EventHandler(this.frmAgregarDatosContacto_Load);
            this.grbContacto.ResumeLayout(false);
            this.grbContacto.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbContacto;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblUsuarioRedSocial;
        private System.Windows.Forms.Label lblRedSocial;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.TextBox txtNombreRedSocial;
        private System.Windows.Forms.ComboBox cmbRedesSociales;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblUusario;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslblEstado;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button button1;
    }
}