namespace Sol_Biblioteca.Interfaces
{
    partial class Form_Dashboard
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
            this.Pnl_menu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_cerrar_dashboard = new System.Windows.Forms.Button();
            this.Btn_Biblioteca = new System.Windows.Forms.Button();
            this.Btn_Activos = new System.Windows.Forms.Button();
            this.Btn_Facturacion = new System.Windows.Forms.Button();
            this.Btn_contabilidad = new System.Windows.Forms.Button();
            this.Btn_nomina = new System.Windows.Forms.Button();
            this.Pnl_cabecera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_visualizar_Formularios = new System.Windows.Forms.Panel();
            this.Btn_crearUsuario = new System.Windows.Forms.Button();
            this.Pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnl_cabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_menu
            // 
            this.Pnl_menu.BackColor = System.Drawing.Color.DimGray;
            this.Pnl_menu.Controls.Add(this.pictureBox1);
            this.Pnl_menu.Controls.Add(this.Btn_cerrar_dashboard);
            this.Pnl_menu.Controls.Add(this.Btn_Biblioteca);
            this.Pnl_menu.Controls.Add(this.Btn_Activos);
            this.Pnl_menu.Controls.Add(this.Btn_Facturacion);
            this.Pnl_menu.Controls.Add(this.Btn_contabilidad);
            this.Pnl_menu.Controls.Add(this.Btn_nomina);
            this.Pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.Pnl_menu.Name = "Pnl_menu";
            this.Pnl_menu.Size = new System.Drawing.Size(328, 804);
            this.Pnl_menu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sol_Biblioteca.Interfaces.Properties.Resources.biblioteca;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_cerrar_dashboard
            // 
            this.Btn_cerrar_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(70)))), ((int)(((byte)(17)))));
            this.Btn_cerrar_dashboard.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar_dashboard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cerrar_dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_cerrar_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cerrar_dashboard.Location = new System.Drawing.Point(12, 702);
            this.Btn_cerrar_dashboard.Name = "Btn_cerrar_dashboard";
            this.Btn_cerrar_dashboard.Size = new System.Drawing.Size(303, 93);
            this.Btn_cerrar_dashboard.TabIndex = 5;
            this.Btn_cerrar_dashboard.Text = "Cerrar";
            this.Btn_cerrar_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_cerrar_dashboard.UseVisualStyleBackColor = false;
            this.Btn_cerrar_dashboard.Click += new System.EventHandler(this.button6_Click);
            // 
            // Btn_Biblioteca
            // 
            this.Btn_Biblioteca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(96)))));
            this.Btn_Biblioteca.FlatAppearance.BorderSize = 0;
            this.Btn_Biblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Biblioteca.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Biblioteca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Biblioteca.Location = new System.Drawing.Point(12, 598);
            this.Btn_Biblioteca.Name = "Btn_Biblioteca";
            this.Btn_Biblioteca.Size = new System.Drawing.Size(303, 93);
            this.Btn_Biblioteca.TabIndex = 4;
            this.Btn_Biblioteca.Text = "Biblioteca";
            this.Btn_Biblioteca.UseVisualStyleBackColor = false;
            this.Btn_Biblioteca.Click += new System.EventHandler(this.Btn_Biblioteca_Click);
            // 
            // Btn_Activos
            // 
            this.Btn_Activos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(57)))));
            this.Btn_Activos.FlatAppearance.BorderSize = 0;
            this.Btn_Activos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Activos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Activos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Activos.Location = new System.Drawing.Point(12, 499);
            this.Btn_Activos.Name = "Btn_Activos";
            this.Btn_Activos.Size = new System.Drawing.Size(303, 93);
            this.Btn_Activos.TabIndex = 3;
            this.Btn_Activos.Text = "Activos";
            this.Btn_Activos.UseVisualStyleBackColor = false;
            this.Btn_Activos.Click += new System.EventHandler(this.Btn_Activos_Click);
            // 
            // Btn_Facturacion
            // 
            this.Btn_Facturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(75)))), ((int)(((byte)(8)))));
            this.Btn_Facturacion.FlatAppearance.BorderSize = 0;
            this.Btn_Facturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Facturacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Facturacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Facturacion.Location = new System.Drawing.Point(12, 400);
            this.Btn_Facturacion.Name = "Btn_Facturacion";
            this.Btn_Facturacion.Size = new System.Drawing.Size(303, 93);
            this.Btn_Facturacion.TabIndex = 2;
            this.Btn_Facturacion.Text = "Facturación";
            this.Btn_Facturacion.UseVisualStyleBackColor = false;
            this.Btn_Facturacion.Click += new System.EventHandler(this.Btn_Facturacion_Click);
            // 
            // Btn_contabilidad
            // 
            this.Btn_contabilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(46)))), ((int)(((byte)(3)))));
            this.Btn_contabilidad.FlatAppearance.BorderSize = 0;
            this.Btn_contabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_contabilidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_contabilidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_contabilidad.Location = new System.Drawing.Point(12, 301);
            this.Btn_contabilidad.Name = "Btn_contabilidad";
            this.Btn_contabilidad.Size = new System.Drawing.Size(303, 93);
            this.Btn_contabilidad.TabIndex = 1;
            this.Btn_contabilidad.Text = "Contabilidad";
            this.Btn_contabilidad.UseVisualStyleBackColor = false;
            this.Btn_contabilidad.Click += new System.EventHandler(this.Btn_contabilidad_Click);
            // 
            // Btn_nomina
            // 
            this.Btn_nomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_nomina.FlatAppearance.BorderSize = 0;
            this.Btn_nomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nomina.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nomina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_nomina.ImageKey = "(ninguno)";
            this.Btn_nomina.Location = new System.Drawing.Point(12, 202);
            this.Btn_nomina.Name = "Btn_nomina";
            this.Btn_nomina.Size = new System.Drawing.Size(303, 93);
            this.Btn_nomina.TabIndex = 0;
            this.Btn_nomina.Text = "Nómina";
            this.Btn_nomina.UseVisualStyleBackColor = false;
            this.Btn_nomina.Click += new System.EventHandler(this.Btn_nomina_Click);
            // 
            // Pnl_cabecera
            // 
            this.Pnl_cabecera.BackColor = System.Drawing.Color.Gray;
            this.Pnl_cabecera.Controls.Add(this.Btn_crearUsuario);
            this.Pnl_cabecera.Controls.Add(this.label1);
            this.Pnl_cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_cabecera.Location = new System.Drawing.Point(328, 0);
            this.Pnl_cabecera.Name = "Pnl_cabecera";
            this.Pnl_cabecera.Size = new System.Drawing.Size(1085, 78);
            this.Pnl_cabecera.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(451, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "::: GRUPO NÚMERO 3 :::";
            // 
            // Pnl_visualizar_Formularios
            // 
            this.Pnl_visualizar_Formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_visualizar_Formularios.Location = new System.Drawing.Point(328, 78);
            this.Pnl_visualizar_Formularios.Name = "Pnl_visualizar_Formularios";
            this.Pnl_visualizar_Formularios.Size = new System.Drawing.Size(1085, 726);
            this.Pnl_visualizar_Formularios.TabIndex = 3;
            // 
            // Btn_crearUsuario
            // 
            this.Btn_crearUsuario.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_crearUsuario.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_crearUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_crearUsuario.Location = new System.Drawing.Point(81, 12);
            this.Btn_crearUsuario.Name = "Btn_crearUsuario";
            this.Btn_crearUsuario.Size = new System.Drawing.Size(246, 59);
            this.Btn_crearUsuario.TabIndex = 1;
            this.Btn_crearUsuario.Text = "crear nuevo usuario";
            this.Btn_crearUsuario.UseVisualStyleBackColor = false;
            this.Btn_crearUsuario.Click += new System.EventHandler(this.Btn_crearUsuario_Click);
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1413, 804);
            this.Controls.Add(this.Pnl_visualizar_Formularios);
            this.Controls.Add(this.Pnl_cabecera);
            this.Controls.Add(this.Pnl_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Dashboard";
            this.Pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnl_cabecera.ResumeLayout(false);
            this.Pnl_cabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_menu;
        private System.Windows.Forms.Button Btn_nomina;
        private System.Windows.Forms.Button Btn_Biblioteca;
        private System.Windows.Forms.Button Btn_Activos;
        private System.Windows.Forms.Button Btn_Facturacion;
        private System.Windows.Forms.Button Btn_contabilidad;
        private System.Windows.Forms.Button Btn_cerrar_dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Pnl_cabecera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_visualizar_Formularios;
        private System.Windows.Forms.Button Btn_crearUsuario;
    }
}