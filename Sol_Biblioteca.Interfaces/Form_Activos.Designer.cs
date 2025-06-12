namespace Sol_Biblioteca.Interfaces
{
    partial class Form_Activos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbUbicacion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerReporteLogs;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox cmbDepresicaciones;
        private System.Windows.Forms.Label lblDepresicaciones;

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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbUbicacion = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerReporteLogs = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblDepresicaciones = new System.Windows.Forms.Label();
            this.cmbDepresicaciones = new System.Windows.Forms.ComboBox();
            this.btnGestionDepreciaciones = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
HEAD
            this.Pnl_nomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(57)))));
            this.Pnl_nomina.Controls.Add(this.label1);
            this.Pnl_nomina.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_nomina.Location = new System.Drawing.Point(0, 0);
            this.Pnl_nomina.Name = "Pnl_nomina";
            this.Pnl_nomina.Size = new System.Drawing.Size(1085, 50);
            this.Pnl_nomina.TabIndex = 1;

            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(30, 76);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(300, 33);
            this.cmbCategoria.TabIndex = 0;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
ff8d4f9 (Subida  de módulo BibliotecaActivos con archivos de configuración, .cs.Designer .resx, y ajustes en formularios,  pagina completa)
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(30, 152);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(300, 33);
            this.cmbEstado.TabIndex = 1;
            // 
            // cmbUbicacion
            // 
HEAD
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 56);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 639);
            this.tabControl1.TabIndex = 2;

            this.cmbUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUbicacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbUbicacion.FormattingEnabled = true;
            this.cmbUbicacion.Location = new System.Drawing.Point(30, 229);
            this.cmbUbicacion.Name = "cmbUbicacion";
            this.cmbUbicacion.Size = new System.Drawing.Size(300, 33);
            this.cmbUbicacion.TabIndex = 2;
ff8d4f9 (Subida  de módulo BibliotecaActivos con archivos de configuración, .cs.Designer .resx, y ajustes en formularios,  pagina completa)
            // 
            // btnBuscar
            // 
HEAD
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ver";
            this.tabPage1.UseVisualStyleBackColor = true;

            this.btnBuscar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(13, 352);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonRounded_Paint);
ff8d4f9 (Subida  de módulo BibliotecaActivos con archivos de configuración, .cs.Designer .resx, y ajustes en formularios,  pagina completa)
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(126, 449);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "❌ Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonRounded_Paint);
            // 
            // btnVerReporteLogs
            // 
            this.btnVerReporteLogs.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerReporteLogs.FlatAppearance.BorderSize = 0;
            this.btnVerReporteLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReporteLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerReporteLogs.ForeColor = System.Drawing.Color.White;
            this.btnVerReporteLogs.Location = new System.Drawing.Point(175, 353);
            this.btnVerReporteLogs.Name = "btnVerReporteLogs";
            this.btnVerReporteLogs.Size = new System.Drawing.Size(170, 35);
            this.btnVerReporteLogs.TabIndex = 4;
            this.btnVerReporteLogs.Text = "📊 Ver Reporte Logs";
            this.btnVerReporteLogs.UseVisualStyleBackColor = false;
            this.btnVerReporteLogs.Click += new System.EventHandler(this.btnVerReporteLogs_Click);
            this.btnVerReporteLogs.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonRounded_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(70, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(251, 45);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Activos - ENGH";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCategoria.Location = new System.Drawing.Point(25, 32);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(108, 28);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEstado.Location = new System.Drawing.Point(25, 112);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(80, 28);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado:";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUbicacion.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUbicacion.Location = new System.Drawing.Point(23, 188);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(110, 28);
            this.lblUbicacion.TabIndex = 9;
            this.lblUbicacion.Text = "Ubicación:";
            // 
            // panelMain
            // 
HEAD
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Salir.Location = new System.Drawing.Point(956, 520);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(122, 132);
            this.Btn_Salir.TabIndex = 9;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;

            this.panelMain.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.btnGestionDepreciaciones);
            this.panelMain.Controls.Add(this.lblTitulo);
            this.panelMain.Controls.Add(this.lblCategoria);
            this.panelMain.Controls.Add(this.cmbCategoria);
            this.panelMain.Controls.Add(this.lblEstado);
            this.panelMain.Controls.Add(this.cmbEstado);
            this.panelMain.Controls.Add(this.lblUbicacion);
            this.panelMain.Controls.Add(this.cmbUbicacion);
            this.panelMain.Controls.Add(this.lblDepresicaciones);
            this.panelMain.Controls.Add(this.cmbDepresicaciones);
            this.panelMain.Controls.Add(this.btnBuscar);
            this.panelMain.Controls.Add(this.btnVerReporteLogs);
            this.panelMain.Controls.Add(this.btnSalir);
            this.panelMain.Location = new System.Drawing.Point(146, 131);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(369, 504);
            this.panelMain.TabIndex = 0;
ff8d4f9 (Subida  de módulo BibliotecaActivos con archivos de configuración, .cs.Designer .resx, y ajustes en formularios,  pagina completa)
            // 
            // lblDepresicaciones
            // 
HEAD
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(58)))), ((int)(((byte)(0)))));
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Eliminar.Location = new System.Drawing.Point(956, 382);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(122, 132);
            this.Btn_Eliminar.TabIndex = 8;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;

            this.lblDepresicaciones.AutoSize = true;
            this.lblDepresicaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDepresicaciones.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDepresicaciones.Location = new System.Drawing.Point(25, 271);
            this.lblDepresicaciones.Name = "lblDepresicaciones";
            this.lblDepresicaciones.Size = new System.Drawing.Size(170, 28);
            this.lblDepresicaciones.TabIndex = 10;
            this.lblDepresicaciones.Text = "Depresicaciones:";
ff8d4f9 (Subida  de módulo BibliotecaActivos con archivos de configuración, .cs.Designer .resx, y ajustes en formularios,  pagina completa)
            // 
            // cmbDepresicaciones
            // 
 HEAD
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.Btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Actualizar.Location = new System.Drawing.Point(956, 244);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(122, 132);
            this.Btn_Actualizar.TabIndex = 7;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = false;

            this.cmbDepresicaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepresicaciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDepresicaciones.FormattingEnabled = true;
            this.cmbDepresicaciones.Location = new System.Drawing.Point(30, 302);
            this.cmbDepresicaciones.Name = "cmbDepresicaciones";
            this.cmbDepresicaciones.Size = new System.Drawing.Size(300, 33);
            this.cmbDepresicaciones.TabIndex = 11;
 ff8d4f9 (Subida  de módulo BibliotecaActivos con archivos de configuración, .cs.Designer .resx, y ajustes en formularios,  pagina completa)
            // 
            // btnGestionDepreciaciones
            // 
 HEAD
            this.Btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Nuevo.Location = new System.Drawing.Point(956, 106);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(122, 132);
            this.Btn_Nuevo.TabIndex = 6;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // Form_Activos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1085, 704);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Pnl_nomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Activos";
            this.Text = " ";
            this.Pnl_nomina.ResumeLayout(false);
            this.Pnl_nomina.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();

            this.btnGestionDepreciaciones.BackColor = System.Drawing.Color.Purple;
            this.btnGestionDepreciaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionDepreciaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGestionDepreciaciones.ForeColor = System.Drawing.Color.White;
            this.btnGestionDepreciaciones.Location = new System.Drawing.Point(30, 394);
            this.btnGestionDepreciaciones.Name = "btnGestionDepreciaciones";
            this.btnGestionDepreciaciones.Size = new System.Drawing.Size(300, 49);
            this.btnGestionDepreciaciones.TabIndex = 4;
            this.btnGestionDepreciaciones.Text = "📊Gestión de Depreciaciones";
            this.btnGestionDepreciaciones.UseVisualStyleBackColor = false;
            this.btnGestionDepreciaciones.Click += new System.EventHandler(this.btnGestionDepreciaciones_Click);
            // 
            // Form_Activos
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 720);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Activos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Activos - ENGH";
            this.Load += new System.EventHandler(this.Form_Activos_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
 ff8d4f9 (Subida  de módulo BibliotecaActivos con archivos de configuración, .cs.Designer .resx, y ajustes en formularios,  pagina completa)
            this.ResumeLayout(false);

        }

        // Método para hacer los botones con bordes redondeados
        private void ButtonRounded_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 15; // Radio para bordes redondeados
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btn.Region = new System.Drawing.Region(path);
        }

        private System.Windows.Forms.Button btnGestionDepreciaciones;
    }
}