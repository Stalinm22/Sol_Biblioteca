// Archivo: Sol_Biblioteca.Interfaces/BibliotecaActivos/Datos/RepositorioActivos.cs

using BibliotecaActivos.Entidad; // Asumiendo que tus entidades están en este namespace
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data; // NECESARIO para DataTable

// IMPORTANTE: Usamos el NAMESPACE de la conexión que acabamos de definir en su propio archivo
using Sol_Biblioteca.Interfaces.BibliotecaActivos.Datos;

namespace Sol_Biblioteca.Interfaces.BibliotecaActivos.Datos // Este es el namespace correcto para este archivo
{
    // Tu clase RepositorioActivos existente, ahora usando la clase estática ConexionOracle
    public class RepositorioActivos
    {
        public List<Activo> ObtenerActivosConDetalles()
        {
            List<Activo> activos = ObtenerActivos();

            foreach (var activo in activos)
            {
                activo.Libros = ObtenerLibrosPorActivo(activo.IdActivo);
                activo.Equipos = ObtenerEquiposPorActivo(activo.IdActivo);
            }

            return activos;
        }

        private List<Activo> ObtenerActivos()
        {
            List<Activo> lista = new List<Activo>();

            // Ahora usa ConexionOracle.AbrirConexion() que está en su propio archivo
            using (var con = ConexionOracle.AbrirConexion())
            using (var cmd = new OracleCommand("SELECT ID_ACTIVO, DESCRIPCION FROM SYSTEM.ACTIVOS", con))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Activo
                    {
                        IdActivo = reader["ID_ACTIVO"].ToString(),
                        Descripcion = reader["DESCRIPCION"]?.ToString()
                    });
                }
            }
            return lista;
        }

        private List<Libro> ObtenerLibrosPorActivo(string idActivo)
        {
            List<Libro> libros = new List<Libro>();

            using (var con = ConexionOracle.AbrirConexion())
            using (var cmd = new OracleCommand(
                "SELECT L.ID_LIBRO, L.TITULO, L.FECHA_ADQUISICION, L.VALOR_COMPRA, L.VIDA_UTIL_ANIOS, L.VALOR_RESIDUAL, L.DEPRECIACION_ACUMULADA, L.MESES_DEPRECIADOS " +
                "FROM SYSTEM.LIBROS L WHERE L.ID_ACTIVO = :id", con))
            {
                cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = idActivo;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        libros.Add(new Libro
                        {
                            IdLibro = reader["ID_LIBRO"].ToString(),
                            Titulo = reader["TITULO"]?.ToString(),
                            IdActivo = idActivo,
                            FECHA_ADQUISICION = reader.GetDateTime(reader.GetOrdinal("FECHA_ADQUISICION")),
                            VALOR_COMPRA = reader.GetDecimal(reader.GetOrdinal("VALOR_COMPRA")),
                            VIDA_UTIL_ANIOS = reader.GetInt32(reader.GetOrdinal("VIDA_UTIL_ANIOS")),
                            VALOR_RESIDUAL = reader.GetDecimal(reader.GetOrdinal("VALOR_RESIDUAL")),
                            DEPRECIACION_ACUMULADA = reader.GetDecimal(reader.GetOrdinal("DEPRECIACION_ACUMULADA")),
                            MESES_DEPRECIADOS = reader.GetInt32(reader.GetOrdinal("MESES_DEPRECIADOS"))
                        });
                    }
                }
            }
            return libros;
        }

        private List<EquipoInformatico> ObtenerEquiposPorActivo(string idActivo)
        {
            List<EquipoInformatico> equipos = new List<EquipoInformatico>();

            using (var con = ConexionOracle.AbrirConexion())
            using (var cmd = new OracleCommand(
                "SELECT E.ID_EQUIPO, E.MARCA, E.MODELO, E.FECHA_ADQUISICION, E.VALOR_COMPRA, E.VIDA_UTIL_ANIOS, E.VALOR_RESIDUAL, E.DEPRECIACION_ACUMULADA, E.MESES_DEPRECIADOS " +
                "FROM SYSTEM.EQUIPOS_INFORMATICOS E WHERE E.ID_ACTIVO = :id", con))
            {
                cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = idActivo;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equipos.Add(new EquipoInformatico
                        {
                            IdEquipo = reader["ID_EQUIPO"].ToString(),
                            Marca = reader["MARCA"]?.ToString(),
                            Modelo = reader["MODELO"]?.ToString(),
                            IdActivo = idActivo,
                            FECHA_ADQUISICION = reader.GetDateTime(reader.GetOrdinal("FECHA_ADQUISICION")),
                            VALOR_COMPRA = reader.GetDecimal(reader.GetOrdinal("VALOR_COMPRA")),
                            VIDA_UTIL_ANIOS = reader.GetInt32(reader.GetOrdinal("VIDA_UTIL_ANIOS")),
                            VALOR_RESIDUAL = reader.GetDecimal(reader.GetOrdinal("VALOR_RESIDUAL")),
                            DEPRECIACION_ACUMULADA = reader.GetDecimal(reader.GetOrdinal("DEPRECIACION_ACUMULADA")),
                            MESES_DEPRECIADOS = reader.GetInt32(reader.GetOrdinal("MESES_DEPRECIADOS"))
                        });
                    }
                }
            }
            return equipos;
        }

        // --- ¡NUEVO MÉTODO AGREGADO AQUÍ! PARA OBTENER ACTIVOS PARA DEPRECIACIÓN EN UN DATATABLE ---
        public DataTable ObtenerTodosLosActivosParaDepreciacion()
        {
            DataTable dt = new DataTable();
            string sql = @"
                SELECT
                    A.ID_ACTIVO,
                    A.NOMBRE,
                    A.FECHA_ADQUISICION,
                    A.COSTO_ORIGINAL,
                    A.VIDA_UTIL_ANIOS,
                    A.VALOR_RESIDUAL,
                    NVL(DD.DEPRECIACION_ACUMULADA, 0) AS ULTIMA_DEPRECIACION_ACUMULADA,
                    NVL(DD.PERIODO_DEPRECIACION_NUM, 0) AS MESES_DEPRECIADOS_HASTA_ULTIMA
                FROM BIBLIOTECAACTIVOS.ACTIVOS A
                LEFT JOIN (
                    SELECT
                        ID_ACTIVO_FK,
                        DEPRECIACION_ACUMULADA,
                        PERIODO_DEPRECIACION_NUM,
                        ROW_NUMBER() OVER (PARTITION BY ID_ACTIVO_FK ORDER BY C.FECHA DESC, DD.PERIODO_DEPRECIACION_NUM DESC) as rn
                    FROM BIBLIOTECAACTIVOS.DETALLE_DEPRECIACION DD
                    JOIN BIBLIOTECAACTIVOS.CABECERA_DEPRECIACION C ON DD.ID_CABECERA_FK = C.ID_CABECERA
                ) DD ON A.ID_ACTIVO = DD.ID_ACTIVO_FK AND DD.rn = 1
                ORDER BY A.ID_ACTIVO";

            using (OracleConnection con = ConexionOracle.AbrirConexion()) // Usa la clase ConexionOracle que ahora está en su propio archivo
            {
                using (OracleCommand cmd = new OracleCommand(sql, con))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
        // --- FIN DE MÉTODO AGREGADO ---
    }
}