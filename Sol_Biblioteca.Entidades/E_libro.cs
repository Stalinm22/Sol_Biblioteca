namespace Sol_Biblioteca.Entidades
{
    public class E_libro
    {
        public int IdLibro { get; set; }
        public int IdActivo { get; set; }
        public int IdAutor { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public int AnoPublicacion { get; set; }
        public string Genero { get; set; }
        public string Idioma { get; set; }
    }
}
