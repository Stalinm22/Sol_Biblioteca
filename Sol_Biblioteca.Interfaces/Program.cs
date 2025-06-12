using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Biblioteca.Interfaces
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar el formulario de login como diálogo
            using (var loginForm = new Form_Login())
            {
                // Si el login fue exitoso (OK), iniciar Form_Activos como formulario principal
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form_Activos());
                }
                else
                {
                    // Si no fue OK, cerrar la aplicación (cancelado o fallido)
                    Application.Exit();
                }
            }
        }
    }
}
