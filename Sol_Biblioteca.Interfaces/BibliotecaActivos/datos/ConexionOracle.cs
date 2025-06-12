// Archivo: Sol_Biblioteca.Interfaces/BibliotecaActivos/Datos/ConexionOracle.cs

using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration; // ¡NECESARIO para ConfigurationManager!

// ¡¡IMPORTANTE: Usamos el NAMESPACE del LOGGER que acabamos de definir!!
using BibliotecaActivos.Utils;

namespace Sol_Biblioteca.Interfaces.BibliotecaActivos.Datos // Este es el namespace correcto para este archivo
{
    // Clase estática para manejar la conexión de forma centralizada y robusta
    public static class ConexionOracle
    {
        // Propiedad estática para la cadena de conexión, leída desde App.config
        private static string CadenaConexion
        {
            get
            {
                // El nombre "OracleBibliotecaConnection" debe coincidir con el 'name' en App.config
                string connString = ConfigurationManager.ConnectionStrings["OracleBibliotecaConnection"]?.ConnectionString;
                if (string.IsNullOrEmpty(connString))
                {
                    // Usa el Logger con el namespace corregido
                    Logger.RegistrarError(new Exception("Cadena de conexión 'OracleBibliotecaConnection' no encontrada o vacía en App.config."), "Error de configuración de conexión.");
                    throw new InvalidOperationException("La cadena de conexión 'OracleBibliotecaConnection' no se encuentra configurada en App.config.");
                }
                return connString;
            }
        }

        /// <summary>
        /// Abre una nueva conexión a la base de datos Oracle.
        /// </summary>
        /// <returns>Un objeto OracleConnection abierto.</returns>
        public static OracleConnection AbrirConexion()
        {
            OracleConnection con = null;
            try
            {
                con = new OracleConnection(CadenaConexion);
                con.Open();
                Logger.RegistrarInfo("Conexión a Oracle abierta exitosamente.");
                return con;
            }
            catch (OracleException ex)
            {
                Logger.RegistrarError(ex, "Error de Oracle al abrir la conexión.");
                throw new Exception("Error al conectar con la base de datos Oracle. Verifique la cadena de conexión y el estado de la base de datos.", ex);
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex, "Error inesperado al abrir la conexión a la base de datos.");
                throw new Exception("Error inesperado al intentar conectar con la base de datos.", ex);
            }
        }

        /// <summary>
        /// Cierra una conexión a la base de datos Oracle si está abierta.
        /// </summary>
        /// <param name="con">El objeto OracleConnection a cerrar.</param>
        public static void CerrarConexion(OracleConnection con)
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    con.Close();
                    con.Dispose(); // Libera los recursos asociados a la conexión
                    Logger.RegistrarInfo("Conexión a Oracle cerrada exitosamente.");
                }
                catch (OracleException ex)
                {
                    Logger.RegistrarError(ex, "Error de Oracle al cerrar la conexión.");
                }
                catch (Exception ex)
                {
                    Logger.RegistrarError(ex, "Error inesperado al cerrar la conexión a la base de datos.");
                }
            }
        }
    }
}