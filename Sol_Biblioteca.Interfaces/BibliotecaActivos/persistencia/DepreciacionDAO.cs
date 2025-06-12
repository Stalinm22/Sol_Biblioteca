// Archivo: Sol_Biblioteca.Interfaces/BibliotecaActivos/persistencia/DepreciacionDAO.cs

using BibliotecaActivos.Entidad;
using Oracle.ManagedDataAccess.Client;
using Sol_Biblioteca.Interfaces.BibliotecaActivos.Datos;
using System;
using System.Collections.Generic;
using System.Data;

namespace BibliotecaActivos.persistencia
{
    public static class DepreciacionDAO
    {
        public static int InsertarCabecera(DepreciacionCabecera cabecera)
        {
            int idGenerado = 0;
            string sql = "INSERT INTO BIBLIOTECAACTIVOS.CABECERA_DEPRECIACION (FECHA, RESPONSABLE, OBSERVACIONES) " +
                         "VALUES (:p_fecha, :p_responsable, :p_observaciones) RETURNING ID_CABECERA INTO :p_id_cabecera";

            using (OracleConnection con = ConexionOracle.AbrirConexion())
            {
                using (OracleCommand cmd = new OracleCommand(sql, con))
                {
                    cmd.Parameters.Add("p_fecha", OracleDbType.Date).Value = cabecera.FECHA;
                    cmd.Parameters.Add("p_responsable", OracleDbType.Varchar2).Value = cabecera.RESPONSABLE;
                    cmd.Parameters.Add("p_observaciones", OracleDbType.Varchar2).Value = cabecera.OBSERVACIONES;

                    OracleParameter p_id_cabecera = new OracleParameter("p_id_cabecera", OracleDbType.Decimal);
                    p_id_cabecera.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p_id_cabecera);

                    cmd.ExecuteNonQuery();
                    idGenerado = Convert.ToInt32(p_id_cabecera.Value);
                }
            }
            return idGenerado;
        }

        // CAMBIO: Usar p_numero_depreciacion en la SQL y el valor se pasará del NUMERO_DEPRECIACION_UI
        public static void ActualizarNumeroDepreciacionUI(int idCabecera, string numeroDepreciacionUI)
        {
            // El nombre de la columna en la BD es NUMERO_DEPRECIACION, no NUMERO_DEPRECIACION_UI
            string sql = "UPDATE BIBLIOTECAACTIVOS.CABECERA_DEPRECIACION SET NUMERO_DEPRECIACION = :p_numero_depreciacion WHERE ID_CABECERA = :p_id_cabecera";
            using (OracleConnection con = ConexionOracle.AbrirConexion())
            {
                using (OracleCommand cmd = new OracleCommand(sql, con))
                {
                    cmd.Parameters.Add("p_numero_depreciacion", OracleDbType.Varchar2).Value = numeroDepreciacionUI; // Aquí pasamos el string generado
                    cmd.Parameters.Add("p_id_cabecera", OracleDbType.Decimal).Value = idCabecera;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void InsertarDetalle(DepreciacionDetalle detalle)
        {
            string sql = "INSERT INTO BIBLIOTECAACTIVOS.DETALLE_DEPRECIACION (ID_CABECERA_FK, ID_ACTIVO_FK, PERIODO_DEPRECIACION_NUM, VALOR_DEPRECIACION_PERIODO, DEPRECIACION_ACUMULADA, VALOR_EN_LIBROS_ACTUAL) " +
                         "VALUES (:p_id_cabecera_fk, :p_id_activo_fk, :p_periodo, :p_valor_periodo, :p_depreciacion_acumulada, :p_valor_en_libros)";

            using (OracleConnection con = ConexionOracle.AbrirConexion())
            {
                using (OracleCommand cmd = new OracleCommand(sql, con))
                {
                    cmd.Parameters.Add("p_id_cabecera_fk", OracleDbType.Decimal).Value = detalle.ID_CABECERA_FK;
                    cmd.Parameters.Add("p_id_activo_fk", OracleDbType.Varchar2).Value = detalle.ID_ACTIVO_FK;
                    cmd.Parameters.Add("p_periodo", OracleDbType.Decimal).Value = detalle.PERIODO_DEPRECIACION_NUM;
                    cmd.Parameters.Add("p_valor_periodo", OracleDbType.Decimal).Value = detalle.VALOR_DEPRECIACION_PERIODO;
                    cmd.Parameters.Add("p_depreciacion_acumulada", OracleDbType.Decimal).Value = detalle.DEPRECIACION_ACUMULADA;
                    cmd.Parameters.Add("p_valor_en_libros", OracleDbType.Decimal).Value = detalle.VALOR_EN_LIBROS_ACTUAL;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ActualizarCabecera(DepreciacionCabecera cabecera)
        {
            string sql = "UPDATE BIBLIOTECAACTIVOS.CABECERA_DEPRECIACION SET " +
                         "FECHA = :p_fecha, RESPONSABLE = :p_responsable, OBSERVACIONES = :p_observaciones " +
                         "WHERE ID_CABECERA = :p_id_cabecera";

            using (OracleConnection con = ConexionOracle.AbrirConexion())
            {
                using (OracleCommand cmd = new OracleCommand(sql, con))
                {
                    cmd.Parameters.Add("p_fecha", OracleDbType.Date).Value = cabecera.FECHA;
                    cmd.Parameters.Add("p_responsable", OracleDbType.Varchar2).Value = cabecera.RESPONSABLE;
                    cmd.Parameters.Add("p_observaciones", OracleDbType.Varchar2).Value = cabecera.OBSERVACIONES;
                    cmd.Parameters.Add("p_id_cabecera", OracleDbType.Decimal).Value = cabecera.ID_CABECERA;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void EliminarDetallesPorCabecera(int idCabecera)
        {
            string sql = "DELETE FROM BIBLIOTECAACTIVOS.DETALLE_DEPRECIACION WHERE ID_CABECERA_FK = :p_id_cabecera_fk";

            using (OracleConnection con = ConexionOracle.AbrirConexion())
            {
                using (OracleCommand cmd = new OracleCommand(sql, con))
                {
                    cmd.Parameters.Add("p_id_cabecera_fk", OracleDbType.Decimal).Value = idCabecera;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void EliminarCabecera(int idCabecera)
        {
            string sql = "DELETE FROM BIBLIOTECAACTIVOS.CABECERA_DEPRECIACION WHERE ID_CABECERA = :p_id_cabecera";

            using (OracleConnection con = ConexionOracle.AbrirConexion())
            {
                using (OracleCommand cmd = new OracleCommand(sql, con))
                {
                    cmd.Parameters.Add("p_id_cabecera", OracleDbType.Decimal).Value = idCabecera;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // *** AÑADIR este método para que la función Buscar pueda cargar una cabecera ***
        public static DepreciacionCabecera ObtenerCabeceraPorId(int idCabecera)
        {
            DepreciacionCabecera cabecera = null;
            string sql = "SELECT ID_CABECERA, NUMERO_DEPRECIACION, FECHA, RESPONSABLE, OBSERVACIONES " +
                         "FROM BIBLIOTECAACTIVOS.CABECERA_DEPRECIACION WHERE ID_CABECERA = :p_id_cabecera";

            using (OracleConnection con = ConexionOracle.AbrirConexion())
            {
                using (OracleCommand cmd = new OracleCommand(sql, con))
                {
                    cmd.Parameters.Add("p_id_cabecera", OracleDbType.Decimal).Value = idCabecera;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cabecera = new DepreciacionCabecera
                            {
                                ID_CABECERA = Convert.ToInt32(reader["ID_CABECERA"]),
                                NUMERO_DEPRECIACION_UI = reader["NUMERO_DEPRECIACION"].ToString(), // Mapea a la propiedad _UI
                                FECHA = Convert.ToDateTime(reader["FECHA"]),
                                RESPONSABLE = reader["RESPONSABLE"].ToString(),
                                OBSERVACIONES = reader["OBSERVACIONES"].ToString()
                            };
                        }
                    }
                }
            }
            return cabecera;
        }

        // *** AÑADIR este método para que la función Buscar pueda cargar los detalles ***
        public static List<DepreciacionDetalle> ObtenerDetallesPorCabecera(int idCabeceraFk)
        {
            List<DepreciacionDetalle> detalles = new List<DepreciacionDetalle>();
            // Ajusta los nombres de las columnas si son diferentes en tu BD
            string sql = "SELECT ID_DETALLE, ID_CABECERA_FK, ID_ACTIVO_FK, PERIODO_DEPRECIACION_NUM, " +
                         "VALOR_DEPRECIACION_PERIODO, DEPRECIACION_ACUMULADA, VALOR_EN_LIBROS_ACTUAL " +
                         "FROM BIBLIOTECAACTIVOS.DETALLE_DEPRECIACION WHERE ID_CABECERA_FK = :p_id_cabecera_fk";

            using (OracleConnection con = ConexionOracle.AbrirConexion())
            {
                using (OracleCommand cmd = new OracleCommand(sql, con))
                {
                    cmd.Parameters.Add("p_id_cabecera_fk", OracleDbType.Decimal).Value = idCabeceraFk;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            detalles.Add(new DepreciacionDetalle
                            {
                                // Asume que DepreciacionDetalle también tiene un ID_DETALLE (PK)
                                ID_DETALLE = Convert.ToInt32(reader["ID_DETALLE"]), // Ajusta si el nombre de columna es diferente
                                ID_CABECERA_FK = Convert.ToInt32(reader["ID_CABECERA_FK"]),
                                ID_ACTIVO_FK = reader["ID_ACTIVO_FK"].ToString(),
                                PERIODO_DEPRECIACION_NUM = Convert.ToInt32(reader["PERIODO_DEPRECIACION_NUM"]),
                                VALOR_DEPRECIACION_PERIODO = Convert.ToDecimal(reader["VALOR_DEPRECIACION_PERIODO"]),
                                DEPRECIACION_ACUMULADA = Convert.ToDecimal(reader["DEPRECIACION_ACUMULADA"]),
                                VALOR_EN_LIBROS_ACTUAL = Convert.ToDecimal(reader["VALOR_EN_LIBROS_ACTUAL"])
                            });
                        }
                    }
                }
            }
            return detalles;
        }
    }
}