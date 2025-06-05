using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Sol_Biblioteca.Datos
{
    public class D_login
    {
        public DataTable Acceder_us(string cUSUARIO, string cPASSWORD)
        {
            DataTable tabla = new DataTable();

            using (OracleConnection conn = new Conexion().CrearConexion())
            {
                using (OracleCommand cmd = new OracleCommand("USP_LOGIN", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.Add("p_Usuario", OracleDbType.Varchar2, 50).Value = cUSUARIO;
                    cmd.Parameters.Add("p_Password", OracleDbType.Varchar2, 100).Value = cPASSWORD;

                    // Parámetro de salida (cursor)
                    cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

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