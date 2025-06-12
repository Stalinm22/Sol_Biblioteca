using System;
using System.Windows.Forms;

namespace BibliotecaActivos
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.AddRange(new object[] {
                "CAT01 - Libro",
                "CAT02 - Material Audiovisual",
                "CAT03 - Equipo Informático",
                "CAT04 - Mobiliario",
                "CAT05 - Vehículo"
            });

            cmbEstado.Items.AddRange(new object[] {
                "EST01 - Disponible",
                "EST02 - En préstamo",
                "EST03 - En reparación",
                "EST04 - Dado de baja"
            });

            cmbUbicacion.Items.AddRange(new object[] {
                "UBI01 - Biblioteca Central",
                "UBI02 - Oficina Administrativa",
                "UBI03 - Almacén",
                "UBI04 - Sala de Lectura",
                "UBI05 - Departamento de IT"
            });
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem != null)
            {
                string seleccion = cmbCategoria.SelectedItem.ToString();

                if (seleccion.StartsWith("CAT03"))
                {
                    FormEquiposInformaticos frm = new FormEquiposInformaticos();
                    frm.Show();
                    this.Hide();
                }
                else if (seleccion.StartsWith("CAT01"))
                {
                    FormLibros frm = new FormLibros();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Esta categoría aún no tiene formulario asociado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (cmbEstado.SelectedItem != null)
            {
                FormEstadoActivo frm = new FormEstadoActivo();
                frm.Show();
                this.Hide();
            }
            else if (cmbUbicacion.SelectedItem != null)
            {
                FormUbicacionActivo frm = new FormUbicacionActivo();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seleccione una opción antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar el sistema de gestión BibliotecaActivos-ENGH. ¡Vuelve pronto!");
            Application.Exit();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Puedes dejar esto vacío si no hay lógica por ahora
        }

        private void btnVerReporteLogs_Click(object sender, EventArgs e)
        {
            FormReporteLogs reporte = new FormReporteLogs();
            reporte.ShowDialog();
        }
    }
}
