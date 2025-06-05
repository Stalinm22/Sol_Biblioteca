using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Sol_Biblioteca.Datos;

namespace Sol_Biblioteca.Datos
{
    public class D_usuarios
    {
        public void InsertarUsuario(string usuario, string password)
        {
            using (OracleConnection conn = new Conexion().CrearConexion())
            {
                using (OracleCommand cmd = new OracleCommand("USP_INSERTAR_USUARIO", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Usuario", OracleDbType.Varchar2, 50).Value = usuario;
                    cmd.Parameters.Add("p_Password", OracleDbType.Varchar2, 100).Value = password;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}
