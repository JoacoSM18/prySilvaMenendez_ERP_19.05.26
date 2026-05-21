namespace prySilvaMenendez_ERP_19._05._26
{
    partial class frmRRHH
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
            this.grbAgregar = new System.Windows.Forms.GroupBox();
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAgregar
            // 
            this.grbAgregar.Controls.Add(this.label1);
            this.grbAgregar.Location = new System.Drawing.Point(12, 16);
            this.grbAgregar.Name = "grbAgregar";
            this.grbAgregar.Size = new System.Drawing.Size(254, 261);
            this.grbAgregar.TabIndex = 0;
            this.grbAgregar.TabStop = false;
            this.grbAgregar.Text = "Agregar Usuario";
            // 
            // grbEliminar
            // 
            this.grbEliminar.Location = new System.Drawing.Point(296, 16);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Size = new System.Drawing.Size(300, 261);
            this.grbEliminar.TabIndex = 1;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Eliminar Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // frmRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbAgregar);
            this.Name = "frmRRHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos Humanos";
            this.grbAgregar.ResumeLayout(false);
            this.grbAgregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbEliminar;
    }
}