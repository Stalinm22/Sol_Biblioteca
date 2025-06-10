using Oracle.ManagedDataAccess.Client;
using Sol_Biblioteca.Entidades;
using System;
using System.Collections.Generic;

namespace Sol_Biblioteca.Datos
{
    public class D_autores
    {
        private OracleConnection conexion;

        public D_autores()
        {
            conexion = Conexion.getInstancia().CrearConexion();

        }

        public void InsertarAutor(E_autor autor)
        {
            using (OracleCommand cmd = new OracleCommand("INSERT INTO AUTORES (NOMBRE, APELLIDO, NACIONALIDAD, FECHA_NACIMIENTO) VALUES (:nombre, :apellido, :nacionalidad, :fecha)", conexion))
            {
                cmd.Parameters.Add(":nombre", autor.Nombre);
                cmd.Parameters.Add(":apellido", autor.Apellido);
                cmd.Parameters.Add(":nacionalidad", autor.Nacionalidad);
                cmd.Parameters.Add(":fecha", autor.FechaNacimiento);

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        public void ActualizarAutor(E_autor autor)
        {
            using (OracleCommand cmd = new OracleCommand("UPDATE AUTORES SET NOMBRE = :nombre, APELLIDO = :apellido, NACIONALIDAD = :nacionalidad, FECHA_NACIMIENTO = :fecha WHERE ID_AUTOR = :id", conexion))
            {
                cmd.Parameters.Add(":nombre", autor.Nombre);
                cmd.Parameters.Add(":apellido", autor.Apellido);
                cmd.Parameters.Add(":nacionalidad", autor.Nacionalidad);
                cmd.Parameters.Add(":fecha", autor.FechaNacimiento);
                cmd.Parameters.Add(":id", autor.IdAutor);

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        public void EliminarAutor(int idAutor)
        {
            using (OracleCommand cmd = new OracleCommand("DELETE FROM AUTORES WHERE ID_AUTOR = :id", conexion))
            {
                cmd.Parameters.Add(":id", idAutor);

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        public List<E_autor> ListarAutores()
        {
            List<E_autor> lista = new List<E_autor>();
            string sql = "SELECT * FROM AUTORES";
            OracleCommand cmd = new OracleCommand(sql, conexion);
            conexion.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new E_autor
                {
                    IdAutor = Convert.ToInt32(reader["ID_AUTOR"]),
                    Nombre = reader["NOMBRE"].ToString(),
                    Apellido = reader["APELLIDO"].ToString(),
                    Nacionalidad = reader["NACIONALIDAD"].ToString(),
                    FechaNacimiento = reader["FECHA_NACIMIENTO"] as DateTime?
                });
            }

            conexion.Close();
            return lista;
        }
    }

}
