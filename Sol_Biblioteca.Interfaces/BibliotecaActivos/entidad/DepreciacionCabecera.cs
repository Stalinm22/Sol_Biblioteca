// Archivo: Sol_Biblioteca.Interfaces/BibliotecaActivos/entidad/DepreciacionCabecera.cs

// ELIMINAR O COMENTAR: using Sol_Biblioteca.Entidades; // ESTO ES LA CAUSA DE LOS ERRORES
using System;
using System.Collections.Generic;

// Asegúrate de que este namespace coincida con la estructura real de tu proyecto
// Según las imágenes y tu código, parece ser este.
namespace BibliotecaActivos.Entidad // <--- Namespace correcto para esta entidad
{
    public class DepreciacionCabecera
    {
        // Esta propiedad mapea al ID_CABECERA de la base de datos (la clave primaria REAL)
        // Que se autogenera en Oracle (NUMBER GENERATED ALWAYS AS IDENTITY)
        public int ID_CABECERA { get; set; }

        // Esta propiedad mapea al campo NUMERO_DEPRECIACION (VARCHAR2) en la base de datos
        // Será el "número" visible en la UI (ej. "DEP-001", "DEP-002")
        // Ahora se llama NUMERO_DEPRECIACION_UI según tu última definición
        public string NUMERO_DEPRECIACION_UI { get; set; }

        // Nombre de la propiedad ahora coincide con la columna FECHA de la DB
        public DateTime FECHA { get; set; }
        public string RESPONSABLE { get; set; }
        public string OBSERVACIONES { get; set; }

        // Propiedad para contener los detalles de esta cabecera
        public List<DepreciacionDetalle> Detalles { get; set; }

        public DepreciacionCabecera()
        {
            Detalles = new List<DepreciacionDetalle>(); // Inicializar la lista para evitar NullReferenceException
        }
    }
}