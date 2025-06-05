using System.Windows.Forms;

namespace Sol_Biblioteca.Interfaces
{
    partial class FormNuevoUsuario
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
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_EliminarUsuario = new System.Windows.Forms.Button();
            this.Btn_ActualizarUsuario = new System.Windows.Forms.Button();
            this.Btn_Nuevo_Usuario = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_GuardarUsuario = new System.Windows.Forms.Button();
            this.Txt_password = new System.Windows.Forms.TextBox();
            this.Txt_nuevoUsuario = new System.Windows.Forms.TextBox();
            this.Lbl_password_Nuevo_Usuario = new System.Windows.Forms.Label();
            this.Lbl_nombre_Nuevo_Usuario = new System.Windows.Forms.Label();
            this.VerUsuarios = new System.Windows.Forms.TabPage();
            this.Btn_verUsuarios = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.VerUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Salir.Location = new System.Drawing.Point(637, 522);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(122, 132);
            this.Btn_Salir.TabIndex = 13;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_EliminarUsuario
            // 
            this.Btn_EliminarUsuario.BackColor = System.Drawing.Color.Lime;
            this.Btn_EliminarUsuario.FlatAppearance.BorderSize = 0;
            this.Btn_EliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EliminarUsuario.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EliminarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_EliminarUsuario.Location = new System.Drawing.Point(509, 522);
            this.Btn_EliminarUsuario.Name = "Btn_EliminarUsuario";
            this.Btn_EliminarUsuario.Size = new System.Drawing.Size(122, 132);
            this.Btn_EliminarUsuario.TabIndex = 12;
            this.Btn_EliminarUsuario.Text = "Eliminar";
            this.Btn_EliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // Btn_ActualizarUsuario
            // 
            this.Btn_ActualizarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_ActualizarUsuario.FlatAppearance.BorderSize = 0;
            this.Btn_ActualizarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ActualizarUsuario.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ActualizarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_ActualizarUsuario.Location = new System.Drawing.Point(381, 522);
            this.Btn_ActualizarUsuario.Name = "Btn_ActualizarUsuario";
            this.Btn_ActualizarUsuario.Size = new System.Drawing.Size(122, 132);
            this.Btn_ActualizarUsuario.TabIndex = 11;
            this.Btn_ActualizarUsuario.Text = "Actualizar";
            this.Btn_ActualizarUsuario.UseVisualStyleBackColor = false;
            // 
            // Btn_Nuevo_Usuario
            // 
            this.Btn_Nuevo_Usuario.BackColor = System.Drawing.Color.Green;
            this.Btn_Nuevo_Usuario.FlatAppearance.BorderSize = 0;
            this.Btn_Nuevo_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo_Usuario.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo_Usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Nuevo_Usuario.Location = new System.Drawing.Point(253, 522);
            this.Btn_Nuevo_Usuario.Name = "Btn_Nuevo_Usuario";
            this.Btn_Nuevo_Usuario.Size = new System.Drawing.Size(122, 132);
            this.Btn_Nuevo_Usuario.TabIndex = 10;
            this.Btn_Nuevo_Usuario.Text = "Nuevo";
            this.Btn_Nuevo_Usuario.UseVisualStyleBackColor = false;
            this.Btn_Nuevo_Usuario.Click += new System.EventHandler(this.Btn_Nuevo_Usuario_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.VerUsuarios);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 494);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_GuardarUsuario);
            this.tabPage1.Controls.Add(this.Txt_password);
            this.tabPage1.Controls.Add(this.Txt_nuevoUsuario);
            this.tabPage1.Controls.Add(this.Lbl_password_Nuevo_Usuario);
            this.tabPage1.Controls.Add(this.Lbl_nombre_Nuevo_Usuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1043, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btn_GuardarUsuario
            // 
            this.Btn_GuardarUsuario.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_GuardarUsuario.FlatAppearance.BorderSize = 0;
            this.Btn_GuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GuardarUsuario.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GuardarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_GuardarUsuario.Location = new System.Drawing.Point(471, 221);
            this.Btn_GuardarUsuario.Name = "Btn_GuardarUsuario";
            this.Btn_GuardarUsuario.Size = new System.Drawing.Size(235, 47);
            this.Btn_GuardarUsuario.TabIndex = 11;
            this.Btn_GuardarUsuario.Text = "Guardar";
            this.Btn_GuardarUsuario.UseVisualStyleBackColor = false;
            this.Btn_GuardarUsuario.Visible = false;
            this.Btn_GuardarUsuario.Click += new System.EventHandler(this.Btn_GuardarUsuario_Click);
            // 
            // Txt_password
            // 
            this.Txt_password.Location = new System.Drawing.Point(471, 165);
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.Size = new System.Drawing.Size(235, 22);
            this.Txt_password.TabIndex = 3;
            this.Txt_password.Visible = false;
            // 
            // Txt_nuevoUsuario
            // 
            this.Txt_nuevoUsuario.Location = new System.Drawing.Point(471, 116);
            this.Txt_nuevoUsuario.Name = "Txt_nuevoUsuario";
            this.Txt_nuevoUsuario.Size = new System.Drawing.Size(235, 22);
            this.Txt_nuevoUsuario.TabIndex = 2;
            this.Txt_nuevoUsuario.Visible = false;
            // 
            // Lbl_password_Nuevo_Usuario
            // 
            this.Lbl_password_Nuevo_Usuario.AutoSize = true;
            this.Lbl_password_Nuevo_Usuario.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_password_Nuevo_Usuario.Location = new System.Drawing.Point(256, 167);
            this.Lbl_password_Nuevo_Usuario.Name = "Lbl_password_Nuevo_Usuario";
            this.Lbl_password_Nuevo_Usuario.Size = new System.Drawing.Size(194, 20);
            this.Lbl_password_Nuevo_Usuario.TabIndex = 1;
            this.Lbl_password_Nuevo_Usuario.Text = "Ingrese paswword:";
            this.Lbl_password_Nuevo_Usuario.Visible = false;
            // 
            // Lbl_nombre_Nuevo_Usuario
            // 
            this.Lbl_nombre_Nuevo_Usuario.AutoSize = true;
            this.Lbl_nombre_Nuevo_Usuario.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre_Nuevo_Usuario.Location = new System.Drawing.Point(282, 115);
            this.Lbl_nombre_Nuevo_Usuario.Name = "Lbl_nombre_Nuevo_Usuario";
            this.Lbl_nombre_Nuevo_Usuario.Size = new System.Drawing.Size(168, 20);
            this.Lbl_nombre_Nuevo_Usuario.TabIndex = 0;
            this.Lbl_nombre_Nuevo_Usuario.Text = "Ingrese Usuario:";
            this.Lbl_nombre_Nuevo_Usuario.Visible = false;
            // 
            // VerUsuarios
            // 
            this.VerUsuarios.Controls.Add(this.Btn_verUsuarios);
            this.VerUsuarios.Controls.Add(this.dgvUsuarios);
            this.VerUsuarios.Location = new System.Drawing.Point(4, 25);
            this.VerUsuarios.Name = "VerUsuarios";
            this.VerUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.VerUsuarios.Size = new System.Drawing.Size(1043, 465);
            this.VerUsuarios.TabIndex = 1;
            this.VerUsuarios.Text = "Ver Usuarios";
            this.VerUsuarios.UseVisualStyleBackColor = true;
            // 
            // Btn_verUsuarios
            // 
            this.Btn_verUsuarios.BackColor = System.Drawing.Color.Orange;
            this.Btn_verUsuarios.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_verUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_verUsuarios.Location = new System.Drawing.Point(237, 332);
            this.Btn_verUsuarios.Name = "Btn_verUsuarios";
            this.Btn_verUsuarios.Size = new System.Drawing.Size(498, 46);
            this.Btn_verUsuarios.TabIndex = 1;
            this.Btn_verUsuarios.Text = "Ver Usuarios";
            this.Btn_verUsuarios.UseVisualStyleBackColor = false;
            this.Btn_verUsuarios.Click += new System.EventHandler(this.Btn_verUsuarios_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(237, 38);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(498, 288);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // FormNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 666);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_EliminarUsuario);
            this.Controls.Add(this.Btn_ActualizarUsuario);
            this.Controls.Add(this.Btn_Nuevo_Usuario);
            this.Name = "FormNuevoUsuario";
            this.Text = "FormNuevoUsuario";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.VerUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_EliminarUsuario;
        private System.Windows.Forms.Button Btn_ActualizarUsuario;
        private System.Windows.Forms.Button Btn_Nuevo_Usuario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage VerUsuarios;
        private System.Windows.Forms.Button Btn_GuardarUsuario;
        private System.Windows.Forms.TextBox Txt_password;
        private System.Windows.Forms.TextBox Txt_nuevoUsuario;
        private System.Windows.Forms.Label Lbl_password_Nuevo_Usuario;
        private System.Windows.Forms.Label Lbl_nombre_Nuevo_Usuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button Btn_verUsuarios;
    }
}