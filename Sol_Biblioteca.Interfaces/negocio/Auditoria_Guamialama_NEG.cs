using Sol_Biblioteca.Entidades;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms; // <<-- ¡NECESITAS AGREGAR ESTA LÍNEA PARA QUE FUNCIONE EL MESSAGEBOX.SHOW!

namespace Sol_Biblioteca.Negocio
{
    public class Auditoria_Guamialama_NEG
    {
        //private string cadenaConexion = "Tu cadena de conexión aquí"; // Bien que esté comentada o eliminada
        private string cadenaConexion; // <<-- ¡CORRECTO! Declarada pero no inicializada aquí.

        public Auditoria_Guamialama_NEG(string conexionQueVieneDelFormulario) // <<-- ¡CORRECTO! El constructor recibe la cadena.
        {
            this.cadenaConexion = conexionQueVieneDelFormulario; // <<-- ¡CORRECTO! Aquí se guarda la cadena.
        }

        public bool RegistrarAuditoria_Guamialama(Auditoria_Guamialama_ENT auditoria)
        {
            try
            {
                using (OracleConnection conexion = new OracleConnection(cadenaConexion))
                {
                    conexion.Open();
                    // <<-- ¡IMPORTANTE CORRECCIÓN AQUÍ!
                    // Los nombres de las columnas en el INSERT deben coincidir con tu tabla en Oracle.
                    // Ayer las cambiamos a: FECHA_GUAMIALAMA, HORA_GUAMIALAMA, USUARIO_GUAMIALAMA, ACTIVIDAD_GUAMIALAMA
                    // Aunque Oracle las maneje en mayúsculas, aquí en C# es mejor ser explícito con el nombre completo.
                    string query = @"INSERT INTO Auditoria_Guamialama (fecha_Guamialama, hora_Guamialama, usuario_Guamialama, actividad_Guamialama)
                                     VALUES (:fecha, :hora, :usuario, :actividad)"; // Los :parametro siguen siendo cortos y está bien.

                    using (OracleCommand comando = new OracleCommand(query, conexion))
                    {
                        // Estas líneas están correctas, mapean los parámetros con las propiedades de tu entidad.
                        comando.Parameters.Add(new OracleParameter("fecha", auditoria.fecha_Guamialama));
                        comando.Parameters.Add(new OracleParameter("hora", auditoria.hora_Guamialama));
                        comando.Parameters.Add(new OracleParameter("usuario", auditoria.usuario_Guamialama));
                        comando.Parameters.Add(new OracleParameter("actividad", auditoria.actividad_Guamialama));

                        comando.ExecuteNonQuery(); // Si hay un error aquí, irá al catch.
                        return true; // Si llega aquí, todo salió bien.
                    }
                }
            }
            catch (Exception ex)
            {
                // <<-- ¡CORRECCIÓN CRÍTICA AQUÍ!
                // Necesitas el MessageBox.Show para VER el error en tu aplicación de escritorio.
                // Console.WriteLine solo escribe en la ventana de "Output" de Visual Studio, no en la UI.
                MessageBox.Show("Error de NEGOCIO al registrar auditoría: " + ex.Message, "Error Auditoría DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Console.WriteLine("Error en auditoría: " + ex.Message); // Puedes comentarla o eliminarla si solo quieres el MessageBox
                return false; // Retorna false para indicar que el registro falló.
            }
        }
    }
}