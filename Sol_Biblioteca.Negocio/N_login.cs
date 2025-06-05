using System;
using System.Data;
using Sol_Biblioteca.Datos; // Asegúrate de tener esta referencia a la capa de datos

namespace Sol_Biblioteca.Negocio
{
    public class N_login
    {
        public static DataTable Acceder_us(string cUSUARIO, string cPASSWORD)
        {
            D_login Datos = new D_login();
            return Datos.Acceder_us(cUSUARIO, cPASSWORD);
        }
    }
}
