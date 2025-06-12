using System;

namespace Sol_Biblioteca.Entidades
{
    public class Auditoria_Guamialama_ENT
    {
        public DateTime fecha_Guamialama { get; set; } // ¡Importante: Ahora es DateTime!
        public string hora_Guamialama { get; set; }
        public string usuario_Guamialama { get; set; }
        public string actividad_Guamialama { get; set; }
    }
}