using BibliotecaActivos.Utils;
using Oracle.ManagedDataAccess.Client;
using Sol_Biblioteca.Entidades;
using Sol_Biblioteca.Negocio;
using System;
using System.Windows.Forms;

namespace BibliotecaActivos
{
    public partial class FormEquiposInformaticos : Form
    {
        // Cadena de conexión a Oracle (mejor dejar en config externo en producción)
        private const string CONEXION_ORACLE =
            "User Id=system;Password=nicolas15;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=FREE)))";

        private readonly Auditoria_Guamialama_NEG auditoriaNegocio; // <<-- ¡Correcto! Declarada, no inicializada aquí.
        private string usuarioActual = "nicolasguamialama"; //

        public FormEquiposInformaticos()
        {
            InitializeComponent();
            auditoriaNegocio = new Auditoria_Guamialama_NEG(CONEXION_ORACLE); // <<-- ¡Correcto! Aquí le pasamos la cadena.
            CargarListaDeEquipos();
        }

        // Evento click botón Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idEquipo = txtIdEquipo.Text.Trim();

            if (string.IsNullOrEmpty(idEquipo))
            {
                MessageBox.Show("Por favor, ingresa el ID del equipo (Ej: EQU01).", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CargarEquipoPorId(idEquipo);
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                BibliotecaActivos.Utils.Logger.RegistrarError(ex);
                MessageBox.Show($"Ocurrió un error al buscar el equipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carga los datos de un equipo según el ID ingresado
        private void CargarEquipoPorId(string idEquipo)
        {
            using (var conn = new OracleConnection(CONEXION_ORACLE))
            {
                conn.Open();

                string query = @"
                    SELECT ID_ACTIVO, TIPO_EQUIPO, MARCA, MODELO, NUMERO_SERIE,
                            PROCESADOR, MEMORIA_RAM, ALMACENAMIENTO, SISTEMA_OPERATIVO
                    FROM EQUIPOS_INFORMATICOS
                    WHERE ID_EQUIPO = :idEquipo";

                using (var cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":idEquipo", OracleDbType.Varchar2).Value = idEquipo;

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtIdActivo.Text = reader["ID_ACTIVO"].ToString();
                            txtTipoEquipo.Text = reader["TIPO_EQUIPO"].ToString();
                            txtMarca.Text = reader["MARCA"].ToString();
                            txtModelo.Text = reader["MODELO"].ToString();
                            txtNumeroSerie.Text = reader["NUMERO_SERIE"].ToString();
                            txtProcesador.Text = reader["PROCESADOR"].ToString();
                            txtMemoriaRam.Text = reader["MEMORIA_RAM"].ToString();
                            txtAlmacenamiento.Text = reader["ALMACENAMIENTO"].ToString();
                            txtSistemaOperativo.Text = reader["SISTEMA_OPERATIVO"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un equipo con ese ID.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos(false);
                        }
                    }
                }
            }
        }

        // Limpia los campos del formulario, opcionalmente limpia txtIdEquipo
        private void LimpiarCampos(bool limpiarIdEquipo = true)
        {
            if (limpiarIdEquipo)
                txtIdEquipo.Clear();

            txtIdActivo.Clear();
            txtTipoEquipo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtNumeroSerie.Clear();
            txtProcesador.Clear();
            txtMemoriaRam.Clear();
            txtAlmacenamiento.Clear();
            txtSistemaOperativo.Clear();
        }

        // Carga la lista de IDs de equipos en el ListBox
        private void CargarListaDeEquipos()
        {
            lstIdEquipos.Items.Clear();

            try
            {
                using (var conn = new OracleConnection(CONEXION_ORACLE))
                {
                    conn.Open();

                    string query = "SELECT ID_EQUIPO FROM EQUIPOS_INFORMATICOS ORDER BY ID_EQUIPO";

                    using (var cmd = new OracleCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lstIdEquipos.Items.Add(reader["ID_EQUIPO"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                BibliotecaActivos.Utils.Logger.RegistrarError(ex);
                MessageBox.Show("Error al cargar los equipos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Al seleccionar un ID del ListBox, se refleja en txtIdEquipo
        private void lstIdEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIdEquipos.SelectedItem != null)
            {
                txtIdEquipo.Text = lstIdEquipos.SelectedItem.ToString();
            }
        }

        // Insertar un nuevo equipo
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string idEquipo = txtIdEquipo.Text.Trim();
            string idActivo = txtIdActivo.Text.Trim();
            string tipo = txtTipoEquipo.Text.Trim();
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string numeroSerie = txtNumeroSerie.Text.Trim();
            string procesador = txtProcesador.Text.Trim();
            string ram = txtMemoriaRam.Text.Trim();
            string almacenamiento = txtAlmacenamiento.Text.Trim();
            string sistema = txtSistemaOperativo.Text.Trim();

            if (string.IsNullOrEmpty(idEquipo) || string.IsNullOrEmpty(idActivo))
            {
                MessageBox.Show("Debe ingresar el ID del equipo y el ID del activo.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new OracleConnection(CONEXION_ORACLE))
                {
                    conn.Open();

                    // Verificar existencia
                    string checkQuery = "SELECT COUNT(*) FROM EQUIPOS_INFORMATICOS WHERE ID_EQUIPO = :idEquipo";

                    using (var checkCmd = new OracleCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.Add(":idEquipo", OracleDbType.Varchar2).Value = idEquipo;

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Ya existe un equipo con ese ID.", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            BibliotecaActivos.Utils.Logger.RegistrarInfo($"Intento de insertar equipo con ID duplicado: {idEquipo}");
                            return;
                        }
                    }

                    // Insertar
                    string insertQuery = @"
                        INSERT INTO EQUIPOS_INFORMATICOS
                        (ID_EQUIPO, ID_ACTIVO, TIPO_EQUIPO, MARCA, MODELO, NUMERO_SERIE,
                         PROCESADOR, MEMORIA_RAM, ALMACENAMIENTO, SISTEMA_OPERATIVO)
                        VALUES
                        (:idEquipo, :idActivo, :tipo, :marca, :modelo, :numeroSerie, :procesador, :ram, :almacenamiento, :sistema)";

                    using (var insertCmd = new OracleCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.Add(":idEquipo", OracleDbType.Varchar2).Value = idEquipo;
                        insertCmd.Parameters.Add(":idActivo", OracleDbType.Varchar2).Value = idActivo;
                        insertCmd.Parameters.Add(":tipo", OracleDbType.Varchar2).Value = tipo;
                        insertCmd.Parameters.Add(":marca", OracleDbType.Varchar2).Value = marca;
                        insertCmd.Parameters.Add(":modelo", OracleDbType.Varchar2).Value = modelo;
                        insertCmd.Parameters.Add(":numeroSerie", OracleDbType.Varchar2).Value = numeroSerie;
                        insertCmd.Parameters.Add(":procesador", OracleDbType.Varchar2).Value = procesador;
                        insertCmd.Parameters.Add(":ram", OracleDbType.Varchar2).Value = ram;
                        insertCmd.Parameters.Add(":almacenamiento", OracleDbType.Varchar2).Value = almacenamiento;
                        insertCmd.Parameters.Add(":sistema", OracleDbType.Varchar2).Value = sistema;

                        int filas = insertCmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Equipo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            CargarListaDeEquipos();
                            RegistrarAuditoria_Guamialama("insertar"); // <<-- ¡CORREGIDO! SE REGISTRA AQUÍ, AL TENER ÉXITO.
                        }
                        else
                        {
                            // RegistrarAuditoria_Guamialama("insertar"); // <<-- ¡REMOVIDO DE AQUÍ! NO SE REGISTRA SI NO SE INSERTA EL EQUIPO.
                            MessageBox.Show("No se pudo insertar el equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(ex);
                BibliotecaActivos.Utils.Logger.RegistrarError(ex);
                MessageBox.Show("Error al insertar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eliminar un equipo por ID
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idEquipo = txtIdEquipo.Text.Trim();

            if (string.IsNullOrEmpty(idEquipo))
            {
                MessageBox.Show("Por favor ingresa el ID del equipo para eliminar.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BibliotecaActivos.Utils.Logger.RegistrarInfo($"Intento de eliminar equipo con ID inexistente: {idEquipo}");
                return;
            }

            var resultado = MessageBox.Show($"¿Seguro que deseas eliminar el equipo {idEquipo}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes) return;

            try
            {
                using (var conn = new OracleConnection(CONEXION_ORACLE))
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM EQUIPOS_INFORMATICOS WHERE ID_EQUIPO = :idEquipo";

                    using (var cmd = new OracleCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.Add(":idEquipo", OracleDbType.Varchar2).Value = idEquipo;

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Equipo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            CargarListaDeEquipos();
                            RegistrarAuditoria_Guamialama("eliminar"); // <<-- ¡CORREGIDO! SE REGISTRA AQUÍ, AL TENER ÉXITO.
                        }
                        else
                        {
                            
                            MessageBox.Show("No se encontró un equipo con ese ID.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // RegistrarAuditoria_Guamialama("eliminar"); // <<-- ¡REMOVIDO DE AQUÍ! NO SE REGISTRA SI LA OPERACIÓN FALLA.
                Logger.RegistrarError(ex);
                BibliotecaActivos.Utils.Logger.RegistrarError(ex);
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Actualizar un equipo
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idEquipo = txtIdEquipo.Text.Trim();
            string idActivo = txtIdActivo.Text.Trim();
            string tipo = txtTipoEquipo.Text.Trim();
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string numeroSerie = txtNumeroSerie.Text.Trim();
            string procesador = txtProcesador.Text.Trim();
            string ram = txtMemoriaRam.Text.Trim();
            string almacenamiento = txtAlmacenamiento.Text.Trim();
            string sistema = txtSistemaOperativo.Text.Trim();

            if (string.IsNullOrEmpty(idEquipo))
            {
                MessageBox.Show("Por favor ingresa el ID del equipo a actualizar.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new OracleConnection(CONEXION_ORACLE))
                {
                    conn.Open();

                    string updateQuery = @"
                        UPDATE EQUIPOS_INFORMATICOS
                        SET ID_ACTIVO = :idActivo,
                            TIPO_EQUIPO = :tipo,
                            MARCA = :marca,
                            MODELO = :modelo,
                            NUMERO_SERIE = :numeroSerie,
                            PROCESADOR = :procesador,
                            MEMORIA_RAM = :ram,
                            ALMACENAMIENTO = :almacenamiento,
                            SISTEMA_OPERATIVO = :sistema
                        WHERE ID_EQUIPO = :idEquipo";

                    using (var cmd = new OracleCommand(updateQuery, conn))
                    {
                        cmd.Parameters.Add(":idActivo", OracleDbType.Varchar2).Value = idActivo;
                        cmd.Parameters.Add(":tipo", OracleDbType.Varchar2).Value = tipo;
                        cmd.Parameters.Add(":marca", OracleDbType.Varchar2).Value = marca;
                        cmd.Parameters.Add(":modelo", OracleDbType.Varchar2).Value = modelo;
                        cmd.Parameters.Add(":numeroSerie", OracleDbType.Varchar2).Value = numeroSerie;
                        cmd.Parameters.Add(":procesador", OracleDbType.Varchar2).Value = procesador;
                        cmd.Parameters.Add(":ram", OracleDbType.Varchar2).Value = ram;
                        cmd.Parameters.Add(":almacenamiento", OracleDbType.Varchar2).Value = almacenamiento;
                        cmd.Parameters.Add(":sistema", OracleDbType.Varchar2).Value = sistema;
                        cmd.Parameters.Add(":idEquipo", OracleDbType.Varchar2).Value = idEquipo;

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Equipo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            CargarListaDeEquipos();
                            // ¡ESTA ES LA LÍNEA CLAVE QUE DEBES AÑADIR/MOVER AQUÍ!
                            RegistrarAuditoria_Guamialama("actualizar");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un equipo con ese ID para actualizar.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ¡IMPORTANTE!: Si tenías la llamada a RegistrarAuditoria_Guamialama("actualizar"); aquí, DEBES QUITARLA.
                // La auditoría se registra solo cuando la operación fue EXITOSA.
                // RegistrarAuditoria_Guamialama("actualizar"); // <<-- ¡QUITA ESTA LÍNEA SI ESTABA AQUÍ!
                Logger.RegistrarError(ex);
                BibliotecaActivos.Utils.Logger.RegistrarError(ex);
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Salir - cerrar formulario con mensaje
        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar la gestión de equipos informáticos. ¡Hasta pronto!", "Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra este formulario y regresa al formulario anterior (puedes ajustar según tu flujo)
        }

        private void btnVerReporteLogs_Click(object sender, EventArgs e)
        {
            // Aquí puedes abrir el archivo de logs o mostrarlo en un formulario, ejemplo:
            // Asegúrate de que la ruta sea correcta o que el archivo de logs se encuentre en el mismo directorio que el ejecutable.
            // Ojo: Si el archivo logs.txt no existe, notepad lo creará, pero si Logger.RegistrarError lo guarda en otra ruta,
            // debes poner esa ruta específica aquí.
            System.Diagnostics.Process.Start("notepad.exe", "logs.txt"); // Asumiendo que logs.txt se crea en el mismo directorio.
        }

        private void RegistrarAuditoria_Guamialama(string actividad)
        {
            var auditoria = new Auditoria_Guamialama_ENT
            {
                fecha_Guamialama = DateTime.Now, // <<-- ¡Correcto! Ya no es texto, es una fecha directa.
                hora_Guamialama = DateTime.Now.ToString("HH:mm:ss"), // <<-- ¡Correcto! Con segundos para más precisión.
                usuario_Guamialama = usuarioActual,
                actividad_Guamialama = actividad
            };

            // Intenta registrar la auditoría. Si hay un problema en la DB de auditoría, el MessageBox.Show en Auditoria_Guamialama_NEG lo mostrará.
            if (!auditoriaNegocio.RegistrarAuditoria_Guamialama(auditoria))
            {
                // Este MessageBox YA LO TIENES. Es una advertencia si la auditoría falla, pero no detiene la operación principal.
                MessageBox.Show("No se pudo registrar la auditoría", "Advertencia",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}