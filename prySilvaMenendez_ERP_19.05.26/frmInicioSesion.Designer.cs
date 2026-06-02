namespace prySilvaMenendez_ERP_19._05._26
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.mskContraseña = new System.Windows.Forms.MaskedTextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.cmbPerfiles = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkMostrar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(57, 33);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(77, 22);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(57, 81);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(108, 22);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(216, 28);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(136, 27);
            this.txtUsuario.TabIndex = 2;
            // 
            // mskContraseña
            // 
            this.mskContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskContraseña.Location = new System.Drawing.Point(216, 77);
            this.mskContraseña.Name = "mskContraseña";
            this.mskContraseña.PasswordChar = '*';
            this.mskContraseña.Size = new System.Drawing.Size(178, 27);
            this.mskContraseña.TabIndex = 3;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(353, 186);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(130, 32);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "&INICIAR &SESION";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbPerfiles.Location = new System.Drawing.Point(216, 127);
            this.cmbPerfiles.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.Size = new System.Drawing.Size(157, 26);
            this.cmbPerfiles.TabIndex = 5;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(57, 133);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(56, 22);
            this.lblPerfil.TabIndex = 6;
            this.lblPerfil.Text = "Perfil:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(59, 186);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkMostrar
            // 
            this.chkMostrar.AutoSize = true;
            this.chkMostrar.Location = new System.Drawing.Point(400, 84);
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.Size = new System.Drawing.Size(118, 17);
            this.chkMostrar.TabIndex = 8;
            this.chkMostrar.Text = "Mostrar Contraseña";
            this.chkMostrar.UseVisualStyleBackColor = true;
            this.chkMostrar.CheckedChanged += new System.EventHandler(this.chkMostrar_CheckedChanged);
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(521, 240);
            this.Controls.Add(this.chkMostrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.cmbPerfiles);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.mskContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.frmInicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox mskContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.ComboBox cmbPerfiles;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkMostrar;
    }
}