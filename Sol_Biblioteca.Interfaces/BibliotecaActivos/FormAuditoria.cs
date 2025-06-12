using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace BibliotecaActivos.Utils
{
    public class AuditoriaHelper
    {
        private const string connectionString = "User Id=SYSTEM;Password=tu_contraseña;Data Source=localhost:1521/FREE;";

        public static void RegistrarAuditoria(string usuario, string actividad)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Auditoria_xxxx 
                                   (fecha_xxxx, hora_xxxx, usuariouamialama, actividad_xxxx)
                                   VALUES (SYSDATE, TO_CHAR(SYSDATE, 'HH24:MI:SS'), :usuario, :actividad)";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(":usuario", OracleDbType.Varchar2).Value = usuario;
                        cmd.Parameters.Add(":actividad", OracleDbType.Varchar2).Value = actividad;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Aquí puedes usar un logger, mostrar MessageBox, o guardar el error
                Console.WriteLine("Error al insertar auditoría: " + ex.Message);
            }
        }
    }
}
