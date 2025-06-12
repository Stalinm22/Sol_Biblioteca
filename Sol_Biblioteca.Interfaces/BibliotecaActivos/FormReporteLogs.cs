using System;
using System.IO;
using System.Windows.Forms;

namespace BibliotecaActivos
{
    public partial class FormReporteLogs : Form
    {
        public FormReporteLogs()
        {
            InitializeComponent();
            // Cargar logs al iniciar el formulario
            this.Load += FormReporteLogs_Load;
        }

        private void FormReporteLogs_Load(object sender, EventArgs e)
        {
            CargarLogs();
        }

        private void CargarLogs()
        {
            // ¡IMPORTANTE! Ruta donde se busca el archivo de logs (debe coincidir con Logger.cs)
            string rutaLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "errores.log");

            try
            {
                if (File.Exists(rutaLog))
                {
                    // Si el archivo existe, leemos todo su contenido y lo mostramos en el TextBox
                    txtLogs.Text = File.ReadAllText(rutaLog);
                    // Mueve el cursor al final para ver los logs más recientes
                    txtLogs.SelectionStart = txtLogs.Text.Length;
                    txtLogs.ScrollToCaret();
                }
                else
                {
                    // Si no existe, mostramos mensaje en el TextBox
                    txtLogs.Text = "No se encontró el archivo de logs. Asegúrate de que existan errores registrados.\r\n";

                    // Esto ayuda a depurar: muestra exactamente la ruta donde se está buscando
                    MessageBox.Show("No se encontró el archivo de logs.\n\nRuta esperada:\n" + rutaLog,
                                    "Archivo de Logs no Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Si algo falla al leer el archivo (por ejemplo, permisos), se muestra el error
                txtLogs.Text = "Error al leer el archivo de logs:\r\n" + ex.Message;

                MessageBox.Show("Ocurrió un error al leer el archivo:\n\n" + ex.Message,
                                "Error de Lectura de Logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarLogs(); // Vuelve a cargar los logs si haces clic en Recargar
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario cuando haces clic en Salir
        }

        // El resto del código de InitializeComponent() en FormReporteLogs.Designer.cs
        // no se incluye aquí, pero asegúrate de que tu TextBox se llame 'txtLogs'
        // y esté configurado como Multiline y con ScrollBars.
    }
}