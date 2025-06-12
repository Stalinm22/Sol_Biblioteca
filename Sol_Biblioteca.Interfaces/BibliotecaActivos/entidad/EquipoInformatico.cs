using System;

namespace BibliotecaActivos.Entidad
{
    public class EquipoInformatico
    {
        public string IdEquipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string IdActivo { get; set; } // Clave foránea al Activo "parent"

        // *** PROPIEDADES CRUCIALES AÑADIDAS PARA LA DEPRECIACIÓN ***
        // Asegúrate que estos campos existen en tu tabla SYSTEM.EQUIPOS_INFORMATICOS
        public DateTime FECHA_ADQUISICION { get; set; }
        public decimal VALOR_COMPRA { get; set; }
        public int VIDA_UTIL_ANIOS { get; set; } // Vida útil en años (para cálculo de depreciación)
        public decimal VALOR_RESIDUAL { get; set; } // Valor de salvamento
        public decimal DEPRECIACION_ACUMULADA { get; set; } // Depreciación ya registrada hasta la fecha
        public int MESES_DEPRECIADOS { get; set; } // Cuántos meses ya se han depreciado
        // **********************************************************

        // Constructor si es necesario
        public EquipoInformatico() { }
    }
}