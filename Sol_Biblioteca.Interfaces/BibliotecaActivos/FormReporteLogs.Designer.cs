namespace BibliotecaActivos
{
    partial class FormReporteLogs
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnSalir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(12, 12);
            this.txtLogs.Multiline = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(560, 300);
            this.txtLogs.TabIndex = 0;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(12, 320);
            this.btnRecargar.Size = new System.Drawing.Size(100, 30);
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(472, 320);
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormReporteLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormReporteLogs";
            this.Text = "Reporte de Logs";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
