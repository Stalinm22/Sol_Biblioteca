
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms; 
using System;
using Sol_Biblioteca.Negocio;

namespace Sol_Biblioteca.Interfaces
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void boton_acceder_Click(object sender, EventArgs e)
        {
            string USUARIO = text_Usuario.Text.Trim();
            string PASSWORD = text_Paswword.Text.Trim();

            if (string.IsNullOrWhiteSpace(USUARIO) || string.IsNullOrWhiteSpace(PASSWORD))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Usar la capa de negocio
            DataTable dt = N_login.Acceder_us(USUARIO, PASSWORD);

            if (dt.Rows.Count > 0)
            {
                // Login exitoso
                Form_Dashboard form_Dashboard = new Form_Dashboard();
                form_Dashboard.Show();
                this.Hide();
            }
            else
            {
                // Login fallido
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
