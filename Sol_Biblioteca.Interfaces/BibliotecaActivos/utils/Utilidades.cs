using System;
using System.IO;

namespace BibliotecaActivos.Utils
{
    public static class Utilidades
    {
        private static readonly string rutaLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

        public static void EscribirLog(string mensaje)
        {
            try
            {
                string texto = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {mensaje}";
                File.AppendAllText(rutaLog, texto + Environment.NewLine);
            }
            catch
            {
                // Opcional: aquí podrías manejar errores al escribir el log (por ejemplo, ignorarlos)
            }
        }
    }
}
