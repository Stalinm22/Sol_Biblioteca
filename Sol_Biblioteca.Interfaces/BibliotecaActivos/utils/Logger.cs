using System;
using System.IO;

namespace BibliotecaActivos.Utils // ¡¡ESTE ES EL NAMESPACE CORRECTO PARA EL LOGGER!!
{
    public static class Logger
    {
        // La ruta donde se guardará el archivo de log.
        // Se combinará con el directorio base de la aplicación, es decir, donde se ejecuta el .exe
        private static readonly string rutaLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "errores.log");

        /// <summary>
        /// Registra un mensaje de error en el archivo de log.
        /// </summary>
        /// <param name="ex">La excepción que ocurrió.</param>
        /// <param name="mensajeAdicional">Un mensaje opcional para añadir más contexto.</param>
        public static void RegistrarError(Exception ex, string mensajeAdicional = null)
        {
            try
            {
                string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] ERROR: ";
                if (!string.IsNullOrEmpty(mensajeAdicional))
                {
                    logEntry += $"{mensajeAdicional} - ";
                }
                logEntry += $"Mensaje: {ex.Message}";
                if (ex.InnerException != null)
                {
                    logEntry += $" | InnerException: {ex.InnerException.Message}";
                }
                logEntry += $" | StackTrace: {ex.StackTrace}{Environment.NewLine}";

                File.AppendAllText(rutaLog, logEntry);
            }
            catch (Exception logEx)
            {
                // Si el log falla, no podemos hacer mucho, pero podemos mostrar un mensaje de depuración.
                // En producción, esto se gestionaría de otra manera (ej. Event Log).
                Console.WriteLine($"Error al registrar el log: {logEx.Message}");
            }
        }

        /// <summary>
        /// Registra un mensaje informativo en el archivo de log.
        /// </summary>
        /// <param name="mensaje">El mensaje informativo a registrar.</param>
        public static void RegistrarInfo(string mensaje)
        {
            try
            {
                string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] INFO: {mensaje}{Environment.NewLine}";
                File.AppendAllText(rutaLog, logEntry);
            }
            catch (Exception logEx)
            {
                Console.WriteLine($"Error al registrar el log informativo: {logEx.Message}");
            }
        }
    }
}