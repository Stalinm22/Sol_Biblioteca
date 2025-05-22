using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Biblioteca.Interfaces
{
    public partial class Form_Login: Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }


        private void boton_acceder_Click(object sender, EventArgs e)
        {
            Form_Dashboard form_Dashboard = new Form_Dashboard();
            form_Dashboard.Show();
            
        }

        private void boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
