using Oracle.ManagedDataAccess.Client;
using Sol_Biblioteca.Entidades;
using System;
using System.Collections.Generic;

namespace Sol_Biblioteca.Datos
{
    public class D_libros
    {
        private OracleConnection conexion;

        public D_libros()
        {
            conexion = Conexion.getInstancia().CrearConexion();

        }

        public void InsertarLibro(E_libro libro)
        {
            using (OracleCommand cmd = new OracleCommand("INSERT INTO LIBROS (ID_ACTIVO, ID_AUTOR, ISBN, TITULO, EDITORIAL, ANO_PUBLICACION, GENERO, IDIOMA) VALUES (:id_activo, :id_autor, :isbn, :titulo, :editorial, :ano_pub, :genero, :idioma)", conexion))
            {
                cmd.Parameters.Add(":id_activo", libro.IdActivo);
                cmd.Parameters.Add(":id_autor", libro.IdAutor);
                cmd.Parameters.Add(":isbn", libro.ISBN);
                cmd.Parameters.Add(":titulo", libro.Titulo);
                cmd.Parameters.Add(":editorial", libro.Editorial);
                cmd.Parameters.Add(":ano_pub", libro.AnoPublicacion);
                cmd.Parameters.Add(":genero", libro.Genero);
                cmd.Parameters.Add(":idioma", libro.Idioma);

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        public void ActualizarLibro(E_libro libro)
        {
            using (OracleCommand cmd = new OracleCommand("UPDATE LIBROS SET ID_ACTIVO = :id_activo, ID_AUTOR = :id_autor, ISBN = :isbn, TITULO = :titulo, EDITORIAL = :editorial, ANO_PUBLICACION = :ano_pub, GENERO = :genero, IDIOMA = :idioma WHERE ID_LIBRO = :id", conexion))
            {
                cmd.Parameters.Add(":id_activo", libro.IdActivo);
                cmd.Parameters.Add(":id_autor", libro.IdAutor);
                cmd.Parameters.Add(":isbn", libro.ISBN);
                cmd.Parameters.Add(":titulo", libro.Titulo);
                cmd.Parameters.Add(":editorial", libro.Editorial);
                cmd.Parameters.Add(":ano_pub", libro.AnoPublicacion);
                cmd.Parameters.Add(":genero", libro.Genero);
                cmd.Parameters.Add(":idioma", libro.Idioma);
                cmd.Parameters.Add(":id", libro.IdLibro);

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        public void EliminarLibro(int idLibro)
        {
            using (OracleCommand cmd = new OracleCommand("DELETE FROM LIBROS WHERE ID_LIBRO = :id", conexion))
            {
                cmd.Parameters.Add(":id", idLibro);

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        public List<E_libro> ListarLibros()
        {
            List<E_libro> lista = new List<E_libro>();
            string sql = "SELECT * FROM LIBROS";
            OracleCommand cmd = new OracleCommand(sql, conexion);
            conexion.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new E_libro
                {
                    IdLibro = Convert.ToInt32(reader["ID_LIBRO"]),
                    IdActivo = Convert.ToInt32(reader["ID_ACTIVO"]),
                    IdAutor = Convert.ToInt32(reader["ID_AUTOR"]),
                    ISBN = reader["ISBN"].ToString(),
                    Titulo = reader["TITULO"].ToString(),
                    Editorial = reader["EDITORIAL"].ToString(),
                    AnoPublicacion = Convert.ToInt32(reader["ANO_PUBLICACION"]),
                    Genero = reader["GENERO"].ToString(),
                    Idioma = reader["IDIOMA"].ToString()
                });
            }

            conexion.Close();
            return lista;
        }
    }
}
