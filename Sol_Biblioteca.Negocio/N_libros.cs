using Sol_Biblioteca.Datos;
using Sol_Biblioteca.Entidades;
using System;
using System.Collections.Generic;


namespace Sol_Biblioteca.Negocio
{
    public class N_libros
    {
        private D_libros datos = new D_libros();

        public void CrearLibro(E_libro libro)
        {
            if (string.IsNullOrWhiteSpace(libro.Titulo))
                throw new Exception("Título es obligatorio.");

            datos.InsertarLibro(libro);
        }

        public void ActualizarLibro(E_libro libro)
        {
            if (libro.IdLibro <= 0)
                throw new Exception("ID de libro inválido.");

            datos.ActualizarLibro(libro);
        }

        public void EliminarLibro(int idLibro)
        {
            if (idLibro <= 0)
                throw new Exception("ID inválido para eliminación.");

            datos.EliminarLibro(idLibro);
        }

        public List<E_libro> ObtenerLibros()
        {
            return datos.ListarLibros();
        }
    }

}
