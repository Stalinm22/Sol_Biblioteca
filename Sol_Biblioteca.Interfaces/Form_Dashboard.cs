using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Biblioteca.Interfaces
{
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login loginForm = new Form_Login();
            loginForm.Visible = true;
        }

        private void Btn_nomina_Click(object sender, EventArgs e)
        {
            // Limpia el panel antes de mostrar el nuevo formulario
            Pnl_visualizar_Formularios.Controls.Clear();

            // Crea una instancia del formulario que quieres mostrar
            Form_Nomina1 formNomina = new Form_Nomina1();
            formNomina.TopLevel = false;
            formNomina.FormBorderStyle = FormBorderStyle.None;
            formNomina.Dock = DockStyle.Fill;

            // Agrega el formulario al panel y lo muestra
            Pnl_visualizar_Formularios.Controls.Add(formNomina);
            formNomina.Show();
        }

        private void Btn_contabilidad_Click(object sender, EventArgs e)
        {
            // Limpia el panel antes de mostrar el nuevo formulario
            Pnl_visualizar_Formularios.Controls.Clear();

            // Crea una instancia del formulario que quieres mostrar
            Form_Contabilidad formContabilidad = new Form_Contabilidad();
            formContabilidad.TopLevel = false;
            formContabilidad.FormBorderStyle = FormBorderStyle.None;
            formContabilidad.Dock = DockStyle.Fill;

            // Agrega el formulario al panel y lo muestra
            Pnl_visualizar_Formularios.Controls.Add(formContabilidad);
            formContabilidad.Show();
        }

        private void Btn_Facturacion_Click(object sender, EventArgs e)
        {
            // Limpia el panel antes de mostrar el nuevo formulario
            Pnl_visualizar_Formularios.Controls.Clear();

            // Crea una instancia del formulario que quieres mostrar
            Form_Facturacion formFacturacion = new Form_Facturacion();
            formFacturacion.TopLevel = false;
            formFacturacion.FormBorderStyle = FormBorderStyle.None;
            formFacturacion.Dock = DockStyle.Fill;

            // Agrega el formulario al panel y lo muestra
            Pnl_visualizar_Formularios.Controls.Add(formFacturacion);
            formFacturacion.Show();
        }

        private void Btn_Activos_Click(object sender, EventArgs e)
        {
            // Limpia el panel antes de mostrar el nuevo formulario
            Pnl_visualizar_Formularios.Controls.Clear();

            // Crea una instancia del formulario que quieres mostrar
            Form_Activos formActivos = new Form_Activos();
            formActivos.TopLevel = false;
            formActivos.FormBorderStyle = FormBorderStyle.None;
            formActivos.Dock = DockStyle.Fill;

            // Agrega el formulario al panel y lo muestra
            Pnl_visualizar_Formularios.Controls.Add(formActivos);
            formActivos.Show();
        }

        private void Btn_Biblioteca_Click(object sender, EventArgs e)
        {
            // Limpia el panel antes de mostrar el nuevo formulario
            Pnl_visualizar_Formularios.Controls.Clear();

            // Crea una instancia del formulario que quieres mostrar
            Form_Biblioteca formBiblioteca = new Form_Biblioteca();
            formBiblioteca.TopLevel = false;
            formBiblioteca.FormBorderStyle = FormBorderStyle.None;
            formBiblioteca.Dock = DockStyle.Fill;

            // Agrega el formulario al panel y lo muestra
            Pnl_visualizar_Formularios.Controls.Add(formBiblioteca);
            formBiblioteca.Show();
        }
    }
}
