namespace prySilvaMenendez_ERP_19._05._26
{
    partial class frmDardeBaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDardeBaja));
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.statuslblEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.statuslblEstado.SuspendLayout();
            this.grbEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(16, 43);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(104, 20);
            this.lblFechaHora.TabIndex = 16;
            this.lblFechaHora.Text = "Fecha y Hora";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(16, 23);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(44, 20);
            this.lblPerfil.TabIndex = 15;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(16, 3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuario";
            // 
            // statuslblEstado
            // 
            this.statuslblEstado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.statuslblEstado.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statuslblEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statuslblEstado.Location = new System.Drawing.Point(0, 459);
            this.statuslblEstado.Name = "statuslblEstado";
            this.statuslblEstado.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statuslblEstado.Size = new System.Drawing.Size(562, 32);
            this.statuslblEstado.TabIndex = 17;
            this.statuslblEstado.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(331, 25);
            this.toolStripStatusLabel1.Text = "Estado de Conexion de la Base de Datos";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(18, 395);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(90, 40);
            this.btnAtras.TabIndex = 18;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.lblEliminar);
            this.grbEliminar.Controls.Add(this.cmbUsuarios);
            this.grbEliminar.Controls.Add(this.btnEliminar);
            this.grbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEliminar.Location = new System.Drawing.Point(45, 123);
            this.grbEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEliminar.Size = new System.Drawing.Size(454, 228);
            this.grbEliminar.TabIndex = 19;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Dar de Baja un Usuario";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(3, 48);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(374, 25);
            this.lblEliminar.TabIndex = 2;
            this.lblEliminar.Text = "Seleccione un Usuario para Darlo de Baja";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(14, 86);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(264, 37);
            this.cmbUsuarios.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(286, 162);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(152, 46);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Dar de Baja";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmDardeBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(562, 491);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.statuslblEstado);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDardeBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar un Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDardeBaja_FormClosing);
            this.Load += new System.EventHandler(this.frmDardeBaja_Load);
            this.statuslblEstado.ResumeLayout(false);
            this.statuslblEstado.PerformLayout();
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.StatusStrip statuslblEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Button btnEliminar;
    }
}