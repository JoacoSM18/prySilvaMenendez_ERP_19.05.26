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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosContacto
            // 
            this.dgvDatosContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosContacto.Location = new System.Drawing.Point(16, 23);
            this.dgvDatosContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDatosContacto.Name = "dgvDatosContacto";
            this.dgvDatosContacto.RowHeadersWidth = 62;
            this.dgvDatosContacto.Size = new System.Drawing.Size(934, 831);
            this.dgvDatosContacto.TabIndex = 0;
            // 
            // frmDatosContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 869);
            this.Controls.Add(this.dgvDatosContacto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDatosContacto";
            this.Text = "Datos de Contacto de los Usuarios";
            this.Load += new System.EventHandler(this.frmDatosContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosContacto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosContacto;
    }
}