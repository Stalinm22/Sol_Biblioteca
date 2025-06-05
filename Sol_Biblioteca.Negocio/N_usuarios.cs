using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sol_Biblioteca.Datos;
using System.Data;

namespace Sol_Biblioteca.Negocio
{
    public class N_usuarios
    {
        public static void InsertarUsuario(string usuario, string password)
        {
            D_usuarios datos = new D_usuarios();
            datos.InsertarUsuario(usuario, password);
        }
    }
}