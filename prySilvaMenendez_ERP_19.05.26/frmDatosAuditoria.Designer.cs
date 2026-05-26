namespace prySilvaMenendez_ERP_19._05._26
{
    partial class frmDatosAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosAuditoria));
            this.dgvDatosAuditoriaSesion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAuditoriaSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosAuditoriaSesion
            // 
            this.dgvDatosAuditoriaSesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAuditoriaSesion.Location = new System.Drawing.Point(8, 14);
            this.dgvDatosAuditoriaSesion.Name = "dgvDatosAuditoriaSesion";
            this.dgvDatosAuditoriaSesion.Size = new System.Drawing.Size(636, 567);
            this.dgvDatosAuditoriaSesion.TabIndex = 0;
            // 
            // frmDatosAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 590);
            this.Controls.Add(this.dgvDatosAuditoriaSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatosAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de Auditoria de Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAuditoriaSesion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosAuditoriaSesion;
    }
}