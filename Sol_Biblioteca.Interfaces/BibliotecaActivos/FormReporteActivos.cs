using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace BibliotecaActivos.Formularios
{
    public partial class FormReporteActivos : Form
    {
        private readonly string connectionString = "Data Source=localhost:1521/FREE;User Id=system;Password=nicolas15;";

        public FormReporteActivos()
        {
            InitializeComponent();
            CargarReporte();
        }

        private void CargarReporte()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            L.ID_LIBRO,
                            L.TITULO,
                            L.AUTOR,
                            L.EDITORIAL,
                            L.ANO_PUBLICACION,
                            L.GENERO,
                            L.IDIOMA,
                            A.ID_ACTIVO,
                            A.DESCRIPCION AS NOMBRE_ACTIVO,
                            E.ID_EQUIPO,
                            E.MARCA,
                            E.MODELO,
                            P.ID_PRESTAMO,
                            P.ESTADO_PRESTAMO,
                            P.NOMBRE_USUARIO,
                            P.FECHA_PRESTAMO
                        FROM SYSTEM.LIBROS L
                        JOIN SYSTEM.ACTIVOS A ON L.ID_ACTIVO = A.ID_ACTIVO
                        LEFT JOIN SYSTEM.EQUIPOS_INFORMATICOS E ON A.ID_ACTIVO = E.ID_ACTIVO
                        LEFT JOIN SYSTEM.PRESTAMOS P ON L.ID_LIBRO = P.ID_LIBRO
                        ORDER BY P.FECHA_PRESTAMO DESC NULLS LAST";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
