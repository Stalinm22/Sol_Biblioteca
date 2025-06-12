using System;
using System.Windows.Forms;

namespace BibliotecaActivos
{
    public partial class FormReporteLibros : Form
    {
        public FormReporteLibros()
        {
            InitializeComponent();
            this.Text = "Reporte de Libros";
            this.Width = 400;
            this.Height = 200;

            Label lblMensaje = new Label()
            {
                Text = "Reporte de Libros - Funcionalidad en construcción.",
                AutoSize = true,
                Left = 30,
                Top = 50,
                Font = new System.Drawing.Font("Arial", 12)
            };

            this.Controls.Add(lblMensaje);
        }
    }
}
