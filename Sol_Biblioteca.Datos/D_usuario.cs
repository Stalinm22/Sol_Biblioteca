using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Sol_Biblioteca.Datos
{
    public class D_usuario
    {
        public DataTable ObtenerUsuarios()
        {
            DataTable tabla = new DataTable();
            using (OracleConnection conn = new Conexion().CrearConexion())
            {
                using (OracleCommand cmd = new OracleCommand("SELECT ID_USUARIO, USUARIO FROM USUARIOS", conn))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            return tabla;
        }
    }
}
