using BibliotecaActivos.Formularios;
using Oracle.ManagedDataAccess.Client;
using Sol_Biblioteca.Interfaces.BibliotecaActivos;
using System;
using System.Data;
using System.Windows.Forms;

namespace BibliotecaActivos
{
    public partial class FormLibros : Form
    {
        private OracleConnection conexion;

        public FormLibros()
        {
            InitializeComponent();
        }

        private void FormLibros_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=system;Password=nicolas15;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=FREE)))";
                conexion = new OracleConnection(connectionString);
                conexion.Open();

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        private void FormLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        private void CargarDatos()
        {
            try
            {
                string query = "SELECT ID_LIBRO, ID_ACTIVO, ISBN, TITULO, AUTOR, EDITORIAL, ANO_PUBLICACION, GENERO, IDIOMA FROM LIBROS";
                OracleDataAdapter adaptador = new OracleDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvLibros.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtAnio.Text.Trim(), out int anioPublicacion))
                {
                    MessageBox.Show("El año debe ser un número válido.");
                    return;
                }

                string query = "INSERT INTO LIBROS (ID_LIBRO, ID_ACTIVO, ISBN, TITULO, AUTOR, EDITORIAL, ANO_PUBLICACION, GENERO, IDIOMA) " +
                               "VALUES (:idLibro, :idActivo, :isbn, :titulo, :autor, :editorial, :anio, :genero, :idioma)";
                using (OracleCommand cmd = new OracleCommand(query, conexion))
                {
                    cmd.Parameters.Add(":idLibro", txtID.Text.Trim());
                    cmd.Parameters.Add(":idActivo", txtIDActivo.Text.Trim());
                    cmd.Parameters.Add(":isbn", txtISBN.Text.Trim());
                    cmd.Parameters.Add(":titulo", txtTitulo.Text.Trim());
                    cmd.Parameters.Add(":autor", txtAutor.Text.Trim());
                    cmd.Parameters.Add(":editorial", txtEditorial.Text.Trim());
                    cmd.Parameters.Add(":anio", anioPublicacion);
                    cmd.Parameters.Add(":genero", txtGenero.Text.Trim());
                    cmd.Parameters.Add(":idioma", txtIdioma.Text.Trim());

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Libro insertado correctamente.");
                        LimpiarCampos();
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar el libro.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtAnio.Text.Trim(), out int anioPublicacion))
                {
                    MessageBox.Show("El año debe ser un número válido.");
                    return;
                }

                string query = "UPDATE LIBROS SET ID_ACTIVO=:idActivo, ISBN=:isbn, TITULO=:titulo, AUTOR=:autor, EDITORIAL=:editorial, ANO_PUBLICACION=:anio, GENERO=:genero, IDIOMA=:idioma " +
                               "WHERE ID_LIBRO=:idLibro";
                using (OracleCommand cmd = new OracleCommand(query, conexion))
                {
                    cmd.Parameters.Add(":idActivo", txtIDActivo.Text.Trim());
                    cmd.Parameters.Add(":isbn", txtISBN.Text.Trim());
                    cmd.Parameters.Add(":titulo", txtTitulo.Text.Trim());
                    cmd.Parameters.Add(":autor", txtAutor.Text.Trim());
                    cmd.Parameters.Add(":editorial", txtEditorial.Text.Trim());
                    cmd.Parameters.Add(":anio", anioPublicacion);
                    cmd.Parameters.Add(":genero", txtGenero.Text.Trim());
                    cmd.Parameters.Add(":idioma", txtIdioma.Text.Trim());
                    cmd.Parameters.Add(":idLibro", txtID.Text.Trim());

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Libro actualizado correctamente.");
                        LimpiarCampos();
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el libro.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM LIBROS WHERE ID_LIBRO=:idLibro";
                using (OracleCommand cmd = new OracleCommand(query, conexion))
                {
                    cmd.Parameters.Add(":idLibro", txtID.Text.Trim());

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Libro eliminado correctamente.");
                        LimpiarCampos();
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el libro.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM LIBROS WHERE ID_LIBRO = :idLibro";
                using (OracleCommand cmd = new OracleCommand(query, conexion))
                {
                    cmd.Parameters.Add(":idLibro", txtID.Text.Trim());
                    OracleDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtIDActivo.Text = reader["ID_ACTIVO"].ToString();
                        txtISBN.Text = reader["ISBN"].ToString();
                        txtTitulo.Text = reader["TITULO"].ToString();
                        txtAutor.Text = reader["AUTOR"].ToString();
                        txtEditorial.Text = reader["EDITORIAL"].ToString();
                        txtAnio.Text = reader["ANO_PUBLICACION"].ToString();
                        txtGenero.Text = reader["GENERO"].ToString();
                        txtIdioma.Text = reader["IDIOMA"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el libro con ese ID.");
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];
                txtID.Text = fila.Cells["ID_LIBRO"].Value.ToString();
                txtIDActivo.Text = fila.Cells["ID_ACTIVO"].Value.ToString();
                txtISBN.Text = fila.Cells["ISBN"].Value.ToString();
                txtTitulo.Text = fila.Cells["TITULO"].Value.ToString();
                txtAutor.Text = fila.Cells["AUTOR"].Value.ToString();
                txtEditorial.Text = fila.Cells["EDITORIAL"].Value.ToString();
                txtAnio.Text = fila.Cells["ANO_PUBLICACION"].Value.ToString();
                txtGenero.Text = fila.Cells["GENERO"].Value.ToString();
                txtIdioma.Text = fila.Cells["IDIOMA"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtIDActivo.Clear();
            txtISBN.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();
            txtAnio.Clear();
            txtGenero.Clear();
            txtIdioma.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporteActivos reporte = new FormReporteActivos();
            reporte.ShowDialog();
        }

        private void btnDepreciacion_Click(object sender, EventArgs e)
        {
            try
            {
                string idLibro = txtID.Text.Trim();
                string titulo = txtTitulo.Text.Trim();

                // Puedes obtener estos valores de los TextBox correspondientes o de la base de datos
                DateTime fechaAdquisicion = DateTime.Now; // Reemplaza con el valor real si lo tienes
                decimal costo = 0m; // Reemplaza con el valor real si lo tienes
                int vidaUtil = 0; // Reemplaza con el valor real si lo tienes
                decimal valorResidual = 0m; // Reemplaza con el valor real si lo tienes

                if (string.IsNullOrEmpty(idLibro) || string.IsNullOrEmpty(titulo))
                {
                    MessageBox.Show("Por favor seleccione un libro válido antes de calcular la depreciación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FormDepreciacionLibros formDepreciacion = new FormDepreciacionLibros(
                    idLibro,
                    titulo,
                    fechaAdquisicion,
                    costo,
                    vidaUtil,
                    valorResidual
                );
                formDepreciacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario de depreciación:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
