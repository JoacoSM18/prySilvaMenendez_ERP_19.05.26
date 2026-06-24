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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.grbAcciones = new System.Windows.Forms.GroupBox();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.btnDardeBajaUsuario = new System.Windows.Forms.Button();
            this.btnVerAuditoria = new System.Windows.Forms.Button();
            this.btnAgregarDatosContacto = new System.Windows.Forms.Button();
            this.btnRRHH = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnDardeAltaUsuario = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.grbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 693);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(722, 32);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslblEstado
            // 
            this.statuslblEstado.Name = "statuslblEstado";
            this.statuslblEstado.Size = new System.Drawing.Size(331, 25);
            this.statuslblEstado.Text = "Estado de Conexion de la Base de Datos";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(15, 605);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(112, 46);
            this.btnAtras.TabIndex = 27;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // grbAcciones
            // 
            this.grbAcciones.Controls.Add(this.btnDardeAltaUsuario);
            this.grbAcciones.Controls.Add(this.btnVerTodo);
            this.grbAcciones.Controls.Add(this.btnDardeBajaUsuario);
            this.grbAcciones.Controls.Add(this.btnVerAuditoria);
            this.grbAcciones.Controls.Add(this.btnAgregarDatosContacto);
            this.grbAcciones.Controls.Add(this.btnRRHH);
            this.grbAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAcciones.Location = new System.Drawing.Point(40, 162);
            this.grbAcciones.Name = "grbAcciones";
            this.grbAcciones.Size = new System.Drawing.Size(626, 435);
            this.grbAcciones.TabIndex = 26;
            this.grbAcciones.TabStop = false;
            this.grbAcciones.Text = "Acciones";
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodo.Location = new System.Drawing.Point(20, 327);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(250, 85);
            this.btnVerTodo.TabIndex = 28;
            this.btnVerTodo.Text = "Ver Todos los Datos de Contacto";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // btnDardeBajaUsuario
            // 
            this.btnDardeBajaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDardeBajaUsuario.Location = new System.Drawing.Point(20, 204);
            this.btnDardeBajaUsuario.Name = "btnDardeBajaUsuario";
            this.btnDardeBajaUsuario.Size = new System.Drawing.Size(250, 85);
            this.btnDardeBajaUsuario.TabIndex = 7;
            this.btnDardeBajaUsuario.Text = "Dar de Baja un Usuario";
            this.btnDardeBajaUsuario.UseVisualStyleBackColor = true;
            this.btnDardeBajaUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnVerAuditoria
            // 
            this.btnVerAuditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAuditoria.Location = new System.Drawing.Point(310, 327);
            this.btnVerAuditoria.Name = "btnVerAuditoria";
            this.btnVerAuditoria.Size = new System.Drawing.Size(296, 85);
            this.btnVerAuditoria.TabIndex = 6;
            this.btnVerAuditoria.Text = "Ver Información Auditoría de Sesion";
            this.btnVerAuditoria.UseVisualStyleBackColor = true;
            this.btnVerAuditoria.Click += new System.EventHandler(this.btnVerAuditoria_Click);
            // 
            // btnAgregarDatosContacto
            // 
            this.btnAgregarDatosContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDatosContacto.Location = new System.Drawing.Point(310, 54);
            this.btnAgregarDatosContacto.Name = "btnAgregarDatosContacto";
            this.btnAgregarDatosContacto.Size = new System.Drawing.Size(296, 105);
            this.btnAgregarDatosContacto.TabIndex = 5;
            this.btnAgregarDatosContacto.Text = "Agregar Datos de Contacto de los Usuarios";
            this.btnAgregarDatosContacto.UseVisualStyleBackColor = true;
            this.btnAgregarDatosContacto.Click += new System.EventHandler(this.btnAgregarDatosContacto_Click);
            // 
            // btnRRHH
            // 
            this.btnRRHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRRHH.Location = new System.Drawing.Point(20, 54);
            this.btnRRHH.Name = "btnRRHH";
            this.btnRRHH.Size = new System.Drawing.Size(250, 105);
            this.btnRRHH.TabIndex = 4;
            this.btnRRHH.Text = "Ingresar al Área de Recursos Humanos";
            this.btnRRHH.UseVisualStyleBackColor = true;
            this.btnRRHH.Click += new System.EventHandler(this.btnRRHH_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(141, 98);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(447, 36);
            this.lblBienvenida.TabIndex = 25;
            this.lblBienvenida.Text = "Bienvenido ADMINISTRADOR";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(10, 58);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(124, 24);
            this.lblFechaHora.TabIndex = 24;
            this.lblFechaHora.Text = "Fecha y Hora";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(10, 35);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(51, 24);
            this.lblPerfil.TabIndex = 23;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(10, 11);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 24);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnDardeAltaUsuario
            // 
            this.btnDardeAltaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDardeAltaUsuario.Location = new System.Drawing.Point(310, 204);
            this.btnDardeAltaUsuario.Name = "btnDardeAltaUsuario";
            this.btnDardeAltaUsuario.Size = new System.Drawing.Size(296, 85);
            this.btnDardeAltaUsuario.TabIndex = 29;
            this.btnDardeAltaUsuario.Text = "Dar de Alta un Usuario";
            this.btnDardeAltaUsuario.UseVisualStyleBackColor = true;
            this.btnDardeAltaUsuario.Click += new System.EventHandler(this.btnDardeAltaUsuario_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(722, 725);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.grbAcciones);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grbAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslblEstado;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox grbAcciones;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnDardeBajaUsuario;
        private System.Windows.Forms.Button btnVerAuditoria;
        private System.Windows.Forms.Button btnAgregarDatosContacto;
        private System.Windows.Forms.Button btnRRHH;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Button btnDardeAltaUsuario;
    }
}