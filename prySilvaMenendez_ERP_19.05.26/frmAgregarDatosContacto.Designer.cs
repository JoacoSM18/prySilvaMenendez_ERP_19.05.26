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
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreRedSocial = new System.Windows.Forms.TextBox();
            this.cmbRedesSociales = new System.Windows.Forms.ComboBox();
            this.lblUsuarioRedSocial = new System.Windows.Forms.Label();
            this.lblRedSocial = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblGmail = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.grbContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbContacto
            // 
            this.grbContacto.Controls.Add(this.txtGmail);
            this.grbContacto.Controls.Add(this.mskTelefono);
            this.grbContacto.Controls.Add(this.txtNombreRedSocial);
            this.grbContacto.Controls.Add(this.cmbRedesSociales);
            this.grbContacto.Controls.Add(this.lblUsuarioRedSocial);
            this.grbContacto.Controls.Add(this.lblRedSocial);
            this.grbContacto.Controls.Add(this.lblTelefono);
            this.grbContacto.Controls.Add(this.lblGmail);
            this.grbContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbContacto.Location = new System.Drawing.Point(30, 29);
            this.grbContacto.Name = "grbContacto";
            this.grbContacto.Size = new System.Drawing.Size(704, 275);
            this.grbContacto.TabIndex = 0;
            this.grbContacto.TabStop = false;
            this.grbContacto.Text = "Contacto";
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
            this.txtNombreRedSocial.Location = new System.Drawing.Point(428, 214);
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
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(610, 371);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 46);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodo.Location = new System.Drawing.Point(262, 371);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(256, 46);
            this.btnVerTodo.TabIndex = 3;
            this.btnVerTodo.Text = "Ver Todos los Datos";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.BackColor = System.Drawing.SystemColors.Control;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(159, 343);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(22, 21);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.UseVisualStyleBackColor = false;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(50, 338);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(78, 26);
            this.lblActivo.TabIndex = 5;
            this.lblActivo.Text = "Activo:";
            // 
            // frmAgregarDatosContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.btnVerTodo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grbContacto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarDatosContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Datos de Contactos de los Usuarios";
            this.Load += new System.EventHandler(this.frmAgregarDatosContacto_Load);
            this.grbContacto.ResumeLayout(false);
            this.grbContacto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbContacto;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Label lblUsuarioRedSocial;
        private System.Windows.Forms.Label lblRedSocial;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.TextBox txtNombreRedSocial;
        private System.Windows.Forms.ComboBox cmbRedesSociales;
    }
}