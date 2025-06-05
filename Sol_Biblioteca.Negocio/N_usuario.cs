using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sol_Biblioteca.Datos;

namespace Sol_Biblioteca.Negocio
{
    public class N_usuario
    {
        public static DataTable ObtenerUsuarios()
        {
            D_usuario datos = new D_usuario();
            return datos.ObtenerUsuarios();
        }
    }
}
