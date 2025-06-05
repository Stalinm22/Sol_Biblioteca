using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_Biblioteca.Negocio;

namespace Sol_Biblioteca.Interfaces
{
    public partial class FormNuevoUsuario : Form
    {
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Nuevo_Usuario_Click(object sender, EventArgs e)
        {
            Lbl_nombre_Nuevo_Usuario.Visible = true;
            Lbl_password_Nuevo_Usuario.Visible = true;
            Txt_nuevoUsuario.Visible = true;
            Txt_password.Visible = true;
            Btn_GuardarUsuario.Visible = true;
        }

        private void Btn_GuardarUsuario_Click(object sender, EventArgs e)
        {
            string usuario = Txt_nuevoUsuario.Text.Trim();
            string password = Txt_password.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                N_usuarios.InsertarUsuario(usuario, password);
                MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_nuevoUsuario.Clear();
                Txt_password.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = N_usuario.ObtenerUsuarios();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Ver Usuarios")
            {
                CargarUsuarios();
            }
        }

        private void Btn_verUsuarios_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

    
    }
}
