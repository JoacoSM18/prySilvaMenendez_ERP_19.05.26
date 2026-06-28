namespace prySilvaMenendez_ERP_19._05._26
{
    partial class frmDatosContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosContacto));
            this.dgvDatosContacto = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosContacto)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosContacto
            // 
            this.dgvDatosContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosContacto.Location = new System.Drawing.Point(16, 91);
            this.dgvDatosContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDatosContacto.Name = "dgvDatosContacto";
            this.dgvDatosContacto.ReadOnly = true;
            this.dgvDatosContacto.RowHeadersWidth = 62;
            this.dgvDatosContacto.Size = new System.Drawing.Size(900, 723);
            this.dgvDatosContacto.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(16, 837);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(112, 49);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 911);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(972, 32);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslblEstado
            // 
            this.statuslblEstado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.statuslblEstado.Name = "statuslblEstado";
            this.statuslblEstado.Size = new System.Drawing.Size(331, 25);
            this.statuslblEstado.Text = "Estado de Conexion de la Base de Datos";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(16, 45);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(104, 20);
            this.lblFechaHora.TabIndex = 12;
            this.lblFechaHora.Text = "Fecha y Hora";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(16, 25);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(44, 20);
            this.lblPerfil.TabIndex = 11;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(16, 5);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario";
            // 
            // frmDatosContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(972, 943);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dgvDatosContacto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDatosContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de Contacto de los Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDatosContacto_FormClosing);
            this.Load += new System.EventHandler(this.frmDatosContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosContacto)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosContacto;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslblEstado;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblUsuario;
    }
}