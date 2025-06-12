using System;
using System.IO;
using System.Text;

namespace BibliotecaActivos.Utils
{
    public static class LogHelper
    {
        // Ruta del archivo log en la carpeta base de la aplicación
        private static readonly string rutaLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

        // Método para registrar cualquier mensaje en el log
        public static void Registrar(string mensaje)
        {
            try
            {
                string texto = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {mensaje}";
                File.AppendAllText(rutaLog, texto + Environment.NewLine, Encoding.UTF8);
            }
            catch
            {
                // Aquí podrías ignorar o manejar errores de escritura
            }
        }

        // Método para registrar errores, con prefijo [ERROR]
        public static void RegistrarError(string mensaje)
        {
            Registrar("[ERROR] " + mensaje);
        }

        // Método para leer el contenido completo del log
        public static string LeerLog()
        {
            try
            {
                if (File.Exists(rutaLog))
                {
                    return File.ReadAllText(rutaLog, Encoding.UTF8);
                }
                return "No hay registros en el log.";
            }
            catch (Exception ex)
            {
                return $"Error al leer el log: {ex.Message}";
            }
        }
    }
}
