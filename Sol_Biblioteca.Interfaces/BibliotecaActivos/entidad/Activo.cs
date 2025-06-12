using System;
using System.Collections.Generic;

namespace BibliotecaActivos.Entidad
{
    public class Activo
    {
        public string IdActivo { get; set; }
        public string Descripcion { get; set; }

        // Mantenemos estas listas si tu diseño de UI las necesita para agrupar
        // Pero para la depreciación, trabajaremos directamente con Libro y EquipoInformatico
        public List<Libro> Libros { get; set; }
        public List<EquipoInformatico> Equipos { get; set; }

        // Las propiedades de depreciación se esperan en Libro y EquipoInformatico
        // Si tu tabla principal de Activos también tuviera estos campos para activos genéricos
        // que no son ni libros ni equipos, los añadirías aquí:
        /*
        public DateTime FECHA_ADQUISICION { get; set; }
        public decimal VALOR_COMPRA { get; set; }
        public int VIDA_UTIL_ANIOS { get; set; }
        public decimal VALOR_RESIDUAL { get; set; }
        public decimal DEPRECIACION_ACUMULADA { get; set; }
        public int MESES_DEPRECIADOS { get; set; }
        */

        public Activo()
        {
            Libros = new List<Libro>();
            Equipos = new List<EquipoInformatico>();
        }
    }
}