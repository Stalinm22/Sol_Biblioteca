using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Sol_Biblioteca.Datos
{
    public class Conexion
    {
        public static Conexion Con = null;
        public Conexion()
        {
        }

        public OracleConnection CrearConexion()
        {
            // Cadena de conexión corregida y uso del constructor adecuado
            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
                                     "(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));" +
                                     "User Id=KLEVER;Password=Fioresam1417$;";
            try
            {
                OracleConnection Cadena = new OracleConnection(connectionString);
                Cadena.Open(); // ¡Abre la conexión aquí!
                return Cadena;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}