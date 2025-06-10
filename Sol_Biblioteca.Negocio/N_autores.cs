using Sol_Biblioteca.Datos;
using Sol_Biblioteca.Entidades;
using System;
using System.Collections.Generic;


namespace Sol_Biblioteca.Negocio
{
    public class N_autores
    {
        private D_autores datos = new D_autores();

        public void CrearAutor(E_autor autor)
        {
            if (string.IsNullOrWhiteSpace(autor.Nombre))
                throw new Exception("Nombre requerido.");

            datos.InsertarAutor(autor);
        }

        public void ActualizarAutor(E_autor autor)
        {
            if (autor.IdAutor <= 0)
                throw new Exception("ID de autor inválido.");

            datos.ActualizarAutor(autor);
        }

        public void EliminarAutor(int idAutor)
        {
            if (idAutor <= 0)
                throw new Exception("ID inválido para eliminación.");

            datos.EliminarAutor(idAutor);
        }

        public List<E_autor> ObtenerAutores()
        {
            return datos.ListarAutores();
        }
    }
}
