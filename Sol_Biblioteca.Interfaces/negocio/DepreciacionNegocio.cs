// Archivo: Sol_Biblioteca.Interfaces/BibliotecaActivos/negocio/DepreciacionNegocio.cs

using BibliotecaActivos.Entidad; // Para DepreciacionCabecera y DepreciacionDetalle (mantener consistente con el DAO)
using BibliotecaActivos.persistencia; // <--- Correcto: Para llamar a DepreciacionDAO
// using BibliotecaActivos.Interfaces.BibliotecaActivos; // Esta línea podría ser innecesaria aquí, a menos que EstadoFormulario esté realmente aquí.
// Si EstadoFormulario está en FormGestionDepreciaciones, el formulario mismo deberá ser quien pase el enum.
// O si es un enum general, debe estar en una capa más baja (Entidades o Utils).
// Por ahora, para evitar dependencias circulares (Negocio a UI), la comentaré.
// Si te da error de compilación sobre 'FormGestionDepreciaciones.EstadoFormulario', me avisas y lo reubicamos.

// Referencia a la capa de datos para acceder a RepositorioActivos y DepreciacionDAO
using Sol_Biblioteca.Interfaces.BibliotecaActivos.Datos; // <--- ¡Añadido! Para RepositorioActivos
using System;
using System.Data; // Necesario para DataTable

namespace BibliotecaActivos.negocio // <--- Namespace Correcto
{
    public static class DepreciacionNegocio
    {
        // Se asume que FormGestionDepreciaciones.EstadoFormulario es un enum público
        // Si no está globalmente accesible, considera moverlo a un archivo .cs en la carpeta Entidad o Utils.
        // Por ahora, lo dejaré aquí y veremos si da error de compilación.
       

        public static DepreciacionCabecera GuardarDepreciacion(DepreciacionCabecera cabecera, EstadoFormulario estado) // Eliminado 'FormGestionDepreciaciones.'
        {
            // Aquí iría la lógica para decidir si es INSERT o UPDATE de la cabecera
            if (estado == EstadoFormulario.Nuevo) // <--- Aquí ya no lleva prefijo
            {
                int idGenerado = DepreciacionDAO.InsertarCabecera(cabecera);
                cabecera.ID_CABECERA = idGenerado;

                cabecera.NUMERO_DEPRECIACION_UI = $"DEP-{idGenerado:0000}";
                DepreciacionDAO.ActualizarNumeroDepreciacionUI(cabecera.ID_CABECERA, cabecera.NUMERO_DEPRECIACION_UI);

                foreach (var detalle in cabecera.Detalles)
                {
                    detalle.ID_CABECERA_FK = idGenerado;
                    DepreciacionDAO.InsertarDetalle(detalle);
                }
            }
            else if (estado == EstadoFormulario.Modificar)  // Eliminado 'FormGestionDepreciaciones.'
            {
                // Asegúrate de implementar ActualizarCabecera y EliminarDetallesPorCabecera en DepreciacionDAO
                // Si no los tienes aún, el compilador te lo indicará.
                DepreciacionDAO.ActualizarCabecera(cabecera);
                DepreciacionDAO.EliminarDetallesPorCabecera(cabecera.ID_CABECERA);
                foreach (var detalle in cabecera.Detalles)
                {
                    detalle.ID_CABECERA_FK = cabecera.ID_CABECERA;
                    DepreciacionDAO.InsertarDetalle(detalle);
                }
            }
            return cabecera;
        }

        public static void EliminarDepreciacion(int idCabecera)
        {
            // Asegúrate de implementar EliminarDetallesPorCabecera y EliminarCabecera en DepreciacionDAO
            DepreciacionDAO.EliminarDetallesPorCabecera(idCabecera);
            DepreciacionDAO.EliminarCabecera(idCabecera);
        }

        public static DepreciacionCabecera ObtenerDepreciacionPorId(int idCabecera)
        {
            // Implementa este método en DepreciacionDAO y llama aquí
            // Ejemplo:
            // DepreciacionCabecera cabecera = DepreciacionDAO.ObtenerCabecera(idCabecera);
            // if (cabecera != null) {
            //      cabecera.Detalles = DepreciacionDAO.ObtenerDetallesPorCabecera(idCabecera);
            // }
            // return cabecera;
            return null; // Placeholder
        }

        // Este método obtiene los activos para el cálculo de la depreciación.
        // ¡Ahora llama a RepositorioActivos que está en la capa de Datos!
        public static DataTable ObtenerActivosParaDepreciacionDesdeNegocio()
        {
            RepositorioActivos repoActivos = new RepositorioActivos(); // Instancia RepositorioActivos
            return repoActivos.ObtenerTodosLosActivosParaDepreciacion(); // Llama al método de RepositorioActivos
        }
    }
}