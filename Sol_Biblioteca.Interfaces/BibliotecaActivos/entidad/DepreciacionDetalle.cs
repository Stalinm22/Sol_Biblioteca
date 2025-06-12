using System;

// Asegúrate de que este namespace coincida con la estructura real de tu proyecto
// Podría ser Sol_Biblioteca.Interface.BibliotecaActivos.Entidades,
// o Sol_Biblioteca.Entidades si "entidad" es solo una carpeta y no parte del namespace
namespace BibliotecaActivos.Entidad // <--- Namespace ajustado
{
    public class DepreciacionDetalle
    {
        public int ID_DETALLE { get; set; } // Mapea a ID_DETALLE en DB (autogenerado)

        // Esta clave foránea ahora mapea al ID_CABECERA (NUMBER) de la cabecera
        public int ID_CABECERA_FK { get; set; }

        // ¡CORRECCIÓN CRÍTICA! Ajustado a string (VARCHAR2) para coincidir con la definición de ID_ACTIVO en la DB
        public string ID_ACTIVO_FK { get; set; }

        // Nombre de la propiedad ahora coincide con la columna PERIODO_DEPRECIACION_NUM de la DB
        public int PERIODO_DEPRECIACION_NUM { get; set; }
        public decimal VALOR_DEPRECIACION_PERIODO { get; set; }
        public decimal DEPRECIACION_ACUMULADA { get; set; }
        // Nombre de la propiedad ahora coincide con la columna VALOR_EN_LIBROS_ACTUAL de la DB
        public decimal VALOR_EN_LIBROS_ACTUAL { get; set; }

        // Propiedades para mostrar información adicional del activo en el detalle en la UI
        // (Estas no se guardan en DETALLE_DEPRECIACION, se obtienen por JOIN o lógica de negocio)
        public string NOMBRE_ACTIVO { get; set; }
        public DateTime FECHA_ADQUISICION_ACTIVO { get; set; }
        public decimal COSTO_ORIGINAL_ACTIVO { get; set; }
        public int VIDA_UTIL_ACTIVO_ANIOS { get; set; }
        public decimal VALOR_RESIDUAL_ACTIVO { get; set; }
    }
}