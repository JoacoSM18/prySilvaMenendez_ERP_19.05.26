namespace prySilvaMenendez_ERP_19._05._26
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.grbAcciones = new System.Windows.Forms.GroupBox();
            this.btnVerAuditoria = new System.Windows.Forms.Button();
            this.btnVerDatosContacto = new System.Windows.Forms.Button();
            this.btnRRHH = new System.Windows.Forms.Button();
            this.grbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(2, 31);
            this.lblFechaHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(88, 16);
            this.lblFechaHora.TabIndex = 9;
            this.lblFechaHora.Text = "Fecha y Hora";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(2, 16);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(37, 16);
            this.lblPerfil.TabIndex = 8;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(2, 0);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(98, 58);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(304, 25);
            this.lblBienvenida.TabIndex = 11;
            this.lblBienvenida.Text = "Bienvenido ADMINISTRADOR";
            // 
            // grbAcciones
            // 
            this.grbAcciones.Controls.Add(this.btnVerAuditoria);
            this.grbAcciones.Controls.Add(this.btnVerDatosContacto);
            this.grbAcciones.Controls.Add(this.btnRRHH);
            this.grbAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAcciones.Location = new System.Drawing.Point(31, 99);
            this.grbAcciones.Margin = new System.Windows.Forms.Padding(2);
            this.grbAcciones.Name = "grbAcciones";
            this.grbAcciones.Padding = new System.Windows.Forms.Padding(2);
            this.grbAcciones.Size = new System.Drawing.Size(417, 368);
            this.grbAcciones.TabIndex = 13;
            this.grbAcciones.TabStop = false;
            this.grbAcciones.Text = "Acciones";
            // 
            // btnVerAuditoria
            // 
            this.btnVerAuditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAuditoria.Location = new System.Drawing.Point(12, 152);
            this.btnVerAuditoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerAuditoria.Name = "btnVerAuditoria";
            this.btnVerAuditoria.Size = new System.Drawing.Size(167, 82);
            this.btnVerAuditoria.TabIndex = 2;
            this.btnVerAuditoria.Text = "Ver Información Auditoría de Sesion";
            this.btnVerAuditoria.UseVisualStyleBackColor = true;
            this.btnVerAuditoria.Click += new System.EventHandler(this.btnVerAuditoria_Click);
            // 
            // btnVerDatosContacto
            // 
            this.btnVerDatosContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDatosContacto.Location = new System.Drawing.Point(206, 64);
            this.btnVerDatosContacto.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerDatosContacto.Name = "btnVerDatosContacto";
            this.btnVerDatosContacto.Size = new System.Drawing.Size(197, 68);
            this.btnVerDatosContacto.TabIndex = 1;
            this.btnVerDatosContacto.Text = "Agregar Datos de Contacto de los Usuarios";
            this.btnVerDatosContacto.UseVisualStyleBackColor = true;
            this.btnVerDatosContacto.Click += new System.EventHandler(this.btnVerDatosContacto_Click);
            // 
            // btnRRHH
            // 
            this.btnRRHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRRHH.Location = new System.Drawing.Point(12, 64);
            this.btnRRHH.Margin = new System.Windows.Forms.Padding(2);
            this.btnRRHH.Name = "btnRRHH";
            this.btnRRHH.Size = new System.Drawing.Size(167, 68);
            this.btnRRHH.TabIndex = 0;
            this.btnRRHH.Text = "Ingresar al Área de Recursos Humanos";
            this.btnRRHH.UseVisualStyleBackColor = true;
            this.btnRRHH.Click += new System.EventHandler(this.btnRRHH_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 514);
            this.Controls.Add(this.grbAcciones);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.grbAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.GroupBox grbAcciones;
        private System.Windows.Forms.Button btnVerDatosContacto;
        private System.Windows.Forms.Button btnRRHH;
        private System.Windows.Forms.Button btnVerAuditoria;
    }
}