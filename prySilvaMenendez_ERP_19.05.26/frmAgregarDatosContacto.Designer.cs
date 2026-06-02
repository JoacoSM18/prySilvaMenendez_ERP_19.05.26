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
            this.grbContacto.Location = new System.Drawing.Point(20, 19);
            this.grbContacto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbContacto.Name = "grbContacto";
            this.grbContacto.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbContacto.Size = new System.Drawing.Size(469, 179);
            this.grbContacto.TabIndex = 0;
            this.grbContacto.TabStop = false;
            this.grbContacto.Text = "Contacto";
            // 
            // txtGmail
            // 
            this.txtGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGmail.Location = new System.Drawing.Point(125, 26);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(141, 24);
            this.txtGmail.TabIndex = 8;
            // 
            // mskTelefono
            // 
            this.mskTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefono.Location = new System.Drawing.Point(125, 64);
            this.mskTelefono.Mask = "000-000-0000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(96, 24);
            this.mskTelefono.TabIndex = 7;
            this.mskTelefono.Enter += new System.EventHandler(this.mskTelefono_Enter);
            // 
            // txtNombreRedSocial
            // 
            this.txtNombreRedSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRedSocial.Location = new System.Drawing.Point(285, 139);
            this.txtNombreRedSocial.Name = "txtNombreRedSocial";
            this.txtNombreRedSocial.Size = new System.Drawing.Size(143, 24);
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
            this.cmbRedesSociales.Location = new System.Drawing.Point(125, 99);
            this.cmbRedesSociales.Name = "cmbRedesSociales";
            this.cmbRedesSociales.Size = new System.Drawing.Size(141, 26);
            this.cmbRedesSociales.TabIndex = 5;
            // 
            // lblUsuarioRedSocial
            // 
            this.lblUsuarioRedSocial.AutoSize = true;
            this.lblUsuarioRedSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioRedSocial.Location = new System.Drawing.Point(13, 145);
            this.lblUsuarioRedSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarioRedSocial.Name = "lblUsuarioRedSocial";
            this.lblUsuarioRedSocial.Size = new System.Drawing.Size(238, 18);
            this.lblUsuarioRedSocial.TabIndex = 4;
            this.lblUsuarioRedSocial.Text = "Nombre de Usuario en Red Social:\r\n";
            // 
            // lblRedSocial
            // 
            this.lblRedSocial.AutoSize = true;
            this.lblRedSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedSocial.Location = new System.Drawing.Point(13, 107);
            this.lblRedSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRedSocial.Name = "lblRedSocial";
            this.lblRedSocial.Size = new System.Drawing.Size(80, 18);
            this.lblRedSocial.TabIndex = 3;
            this.lblRedSocial.Text = "Red Social";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(13, 70);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 18);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmail.Location = new System.Drawing.Point(13, 32);
            this.lblGmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(51, 18);
            this.lblGmail.TabIndex = 1;
            this.lblGmail.Text = "Gmail:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(407, 241);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 30);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodo.Location = new System.Drawing.Point(175, 241);
            this.btnVerTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(171, 30);
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
            this.chkActivo.Location = new System.Drawing.Point(106, 223);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(15, 14);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.UseVisualStyleBackColor = false;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(33, 220);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(52, 18);
            this.lblActivo.TabIndex = 5;
            this.lblActivo.Text = "Activo:";
            // 
            // frmAgregarDatosContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.btnVerTodo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grbContacto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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