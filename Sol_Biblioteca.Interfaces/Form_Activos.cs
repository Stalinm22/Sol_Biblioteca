using BibliotecaActivos; // Asegúrate de tener esta línea para acceder a FormReporteLogs
using Sol_Biblioteca.Interfaces.BibliotecaActivos; // Mantén este si lo usas para otras interfaces
using System;
using System.Windows.Forms;

namespace Sol_Biblioteca.Interfaces
{
    public partial class Form_Activos : Form
    {
        public Form_Activos()
        {
            InitializeComponent();
        }

        private void Form_Activos_Load(object sender, EventArgs e)
        {
            // Cargar categorías
            cmbCategoria.Items.AddRange(new object[] {
                "CAT01 - Libro",
                "CAT02 - Material Audiovisual",
                "CAT03 - Equipo Informático",
                "CAT04 - Mobiliario",
                "CAT05 - Vehículo"
            });

            // Cargar estados
            cmbEstado.Items.AddRange(new object[] {
                "EST01 - Disponible",
                "EST02 - En préstamo",
                "EST03 - En reparación",
                "EST04 - Dado de baja"
            });

            // Cargar ubicaciones
            cmbUbicacion.Items.AddRange(new object[] {
                "UBI01 - Biblioteca Central",
                "UBI02 - Oficina Administrativa",
                "UBI03 - Almacén",
                "UBI04 - Sala de Lectura",
                "UBI05 - Departamento de IT"
            });

            // Cargar depreciaciones con las mismas categorías
            cmbDepresicaciones.Items.AddRange(new object[] {
                "CAT01 - Libro",
                "CAT02 - Material Audiovisual",
                "CAT03 - Equipo Informático",
                "CAT04 - Mobiliario",
                "CAT05 - Vehículo"
            });

            // Inicializar sin selección
            cmbCategoria.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            cmbUbicacion.SelectedIndex = -1;
            cmbDepresicaciones.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Primero verificar Depresicaciones
            if (cmbDepresicaciones.SelectedItem != null)
            {
                string seleccion = cmbDepresicaciones.SelectedItem.ToString();

                if (seleccion.StartsWith("CAT01")) // Libros
                {
                    using (FormDepreciacionLibros frm = new FormDepreciacionLibros())
                    {
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    return;
                }
                else if (seleccion.StartsWith("CAT02")) // Material Audiovisual
                {
                    using (FormDepreciacionMaterialAudioVisual frm = new FormDepreciacionMaterialAudioVisual())
                    {
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    return;
                }
                else if (seleccion.StartsWith("CAT03")) // Equipo Informático
                {
                    using (FormDepreciacionEquiposInformaticos frm = new FormDepreciacionEquiposInformaticos())
                    {
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    return;
                }
                else if (seleccion.StartsWith("CAT04")) // Mobiliario
                {
                    using (FormDepreciacionMoviliario frm = new FormDepreciacionMoviliario())
                    {
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    return;
                }
                else if (seleccion.StartsWith("CAT05")) // Vehículo
                {
                    using (FormDepreciacionVehiculos frm = new FormDepreciacionVehiculos())
                    {
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    return;
                }
            }

            // Luego verificar Categoría
            if (cmbCategoria.SelectedItem != null)
            {
                string seleccion = cmbCategoria.SelectedItem.ToString();

                if (seleccion.StartsWith("CAT01"))
                {
                    using (FormLibros frm = new FormLibros())
                    {
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    return;
                }
                else if (seleccion.StartsWith("CAT03"))
                {
                    using (FormEquiposInformaticos frm = new FormEquiposInformaticos())
                    {
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Esta categoría aún no tiene un formulario asociado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Verificar Estado
            if (cmbEstado.SelectedItem != null)
            {
                using (FormEstadoActivo frm = new FormEstadoActivo())
                {
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                return;
            }

            // Verificar Ubicación
            if (cmbUbicacion.SelectedItem != null)
            {
                using (FormUbicacionActivo frm = new FormUbicacionActivo())
                {
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                return;
            }

            MessageBox.Show("Seleccione al menos una opción para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Este es el método que se activa cuando haces clic en el botón "Ver Reporte Logs"
        private void btnVerReporteLogs_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario de reporte de logs
            FormReporteLogs reporte = new FormReporteLogs();
            // Muestra el formulario de logs de forma modal (bloquea el formulario padre hasta que se cierre)
            reporte.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar el sistema de gestión BibliotecaActivos-ENGH. ¡Vuelve pronto!");
            Application.Exit();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica adicional al cambiar categoría (si se desea)
        }

        private void btnGestionDepreciaciones_Click(object sender, EventArgs e)
        {
            // Instanciar y mostrar el nuevo formulario
            FormGestionDepreciaciones formGestionDepreciaciones = new FormGestionDepreciaciones();
            formGestionDepreciaciones.Show(); // O formGestionDepreciaciones.ShowDialog(); si quieres que sea modal
        }

    }
}