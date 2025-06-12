// Archivo: Sol_Biblioteca.Interfaces/BibliotecaActivos/FormGestionDepreciaciones.cs

using Sol_Biblioteca.Interfaces.Properties;
using System;
using System.Data;
using System.Windows.Forms;
using BibliotecaActivos.Entidad; // Para DepreciacionCabecera y DepreciacionDetalle

// CAMBIO AQUÍ: El using para persistencia debe coincidir con el namespace real de DepreciacionDAO
using BibliotecaActivos.persistencia; // Corregido el using

using System.Collections.Generic;
// Si sigues teniendo problemas con Microsoft.VisualBasic.Interaction.InputBox,
// puedes considerar usar un Form personalizado para la entrada de ID,
// o si es un proyecto de Windows Forms, añadir la referencia manualmente.
// Si no quieres añadir la referencia, puedes cambiar la línea por un MessageBox.Show con un campo de texto
// o un formulario más complejo.
// Para este ejemplo, asumiremos que se añadirá la referencia o se usará una alternativa.

namespace Sol_Biblioteca.Interfaces.BibliotecaActivos
{
    public partial class FormGestionDepreciaciones : Form
    {
        private enum EstadoFormulario { Nuevo, Modificar, Consultar, Nulo }
        private EstadoFormulario estadoActual;
        private int _idCabeceraActual = 0;

        public FormGestionDepreciaciones()
        {
            InitializeComponent();
            ConfigurarDataGridViewDetalle();
            AplicarRecursosTexto();
            LimpiarCamposCabecera();
            HabilitarControles(EstadoFormulario.Nulo);
            txtNumeroDepreciacion.ReadOnly = true;
        }

        private void AplicarRecursosTexto()
        {
            this.Text = Resources.Title;
            label1.Text = Resources.lblNumero_Text;
            label2.Text = Resources.lblFecha_Text;
            label3.Text = Resources.lblObservaciones_Text;
            label4.Text = Resources.lblResponsable_Text;
            btnNuevoCabecera.Text = Resources.btnNuevo_Text;
            btnGuardarCabecera.Text = Resources.btnGuardar_Text;
            btnModificarCabecera.Text = Resources.btnModificar_Text;
            btnEliminarCabecera.Text = Resources.btnEliminar_Text;
            btnBuscarCabecera.Text = Resources.btnBuscar_Text;
            btnDepreciarMesActual.Text = Resources.btnDepreciar_Text;
            btnCerrar.Text = Resources.btnCerrar_Text;
        }

        private void FormGestionDepreciaciones_Load(object sender, EventArgs e)
        {
            dtpFechaDepreciacion.Value = DateTime.Today;
        }

        private void ConfigurarDataGridViewDetalle()
        {
            dgvDetallesDepreciacion.AutoGenerateColumns = false;
            dgvDetallesDepreciacion.AllowUserToAddRows = false;
            dgvDetallesDepreciacion.AllowUserToDeleteRows = false;
            dgvDetallesDepreciacion.ReadOnly = true;

            dgvDetallesDepreciacion.Columns.Clear();
            dgvDetallesDepreciacion.Columns.Add("IdActivo", "ID Activo");
            dgvDetallesDepreciacion.Columns.Add("NombreActivo", "Nombre Activo");
            dgvDetallesDepreciacion.Columns.Add("FechaAdquisicion", "Fecha Adquisición");
            dgvDetallesDepreciacion.Columns.Add("CostoOriginal", "Costo Original");
            dgvDetallesDepreciacion.Columns.Add("VidaUtilAnios", "Vida Útil (Años)");
            dgvDetallesDepreciacion.Columns.Add("ValorResidual", "Valor Residual");
            dgvDetallesDepreciacion.Columns.Add("PeriodoDepreciacion", "Período Depreciación #");
            dgvDetallesDepreciacion.Columns.Add("ValorDepreciacionPeriodo", "Depreciación del Período");
            dgvDetallesDepreciacion.Columns.Add("DepreciacionAcumulada", "Depreciación Acumulada");
            dgvDetallesDepreciacion.Columns.Add("ValorEnLibros", "Valor en Libros Actual");

            foreach (DataGridViewColumn col in dgvDetallesDepreciacion.Columns)
            {
                if (col.Name.Contains("Costo") || col.Name.Contains("Valor") || col.Name.Contains("Depreciacion"))
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    col.DefaultCellStyle.Format = "C";
                }
            }
        }

        private void LimpiarCamposCabecera()
        {
            _idCabeceraActual = 0;
            txtNumeroDepreciacion.Text = string.Empty;
            dtpFechaDepreciacion.Value = DateTime.Today;
            txtObservaciones.Text = string.Empty;
            txtResponsable.Text = string.Empty;
            dgvDetallesDepreciacion.DataSource = null;
            dgvDetallesDepreciacion.Rows.Clear();
        }

        private void HabilitarControles(EstadoFormulario estado)
        {
            estadoActual = estado;

            txtObservaciones.ReadOnly = !(estado == EstadoFormulario.Nuevo || estado == EstadoFormulario.Modificar);
            txtResponsable.ReadOnly = !(estado == EstadoFormulario.Nuevo || estado == EstadoFormulario.Modificar);
            dtpFechaDepreciacion.Enabled = (estado == EstadoFormulario.Nuevo || estado == EstadoFormulario.Modificar);

            txtNumeroDepreciacion.ReadOnly = true;

            btnNuevoCabecera.Enabled = (estado == EstadoFormulario.Nulo || estado == EstadoFormulario.Consultar);
            btnGuardarCabecera.Enabled = (estado == EstadoFormulario.Nuevo || estado == EstadoFormulario.Modificar);
            btnModificarCabecera.Enabled = (estado == EstadoFormulario.Consultar && _idCabeceraActual > 0);
            btnEliminarCabecera.Enabled = (estado == EstadoFormulario.Consultar && _idCabeceraActual > 0);
            btnBuscarCabecera.Enabled = (estado == EstadoFormulario.Nulo || estado == EstadoFormulario.Consultar);
            btnDepreciarMesActual.Enabled = (estado == EstadoFormulario.Nuevo);
            btnCerrar.Enabled = true;
        }

        private void btnNuevoCabecera_Click(object sender, EventArgs e)
        {
            LimpiarCamposCabecera();
            HabilitarControles(EstadoFormulario.Nuevo);
            MessageBox.Show(
                "Ingrese los datos de la cabecera (Responsable, Observaciones) y luego haga clic en 'Depreciar Mes Actual' para generar los detalles. Después, 'Guardar'.",
                "Nuevo Registro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            txtResponsable.Focus();
        }

        private void btnGuardarCabecera_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResponsable.Text))
            {
                MessageBox.Show("Debe ingresar un responsable para la depreciación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResponsable.Focus();
                return;
            }
            if (estadoActual == EstadoFormulario.Nuevo && dgvDetallesDepreciacion.Rows.Count == 0)
            {
                MessageBox.Show("No se han generado detalles de depreciación. Haga clic en 'Depreciar Mes Actual'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DepreciacionCabecera cabecera = new DepreciacionCabecera
                {
                    FECHA = dtpFechaDepreciacion.Value,
                    RESPONSABLE = txtResponsable.Text.Trim(),
                    OBSERVACIONES = txtObservaciones.Text.Trim()
                };

                if (estadoActual == EstadoFormulario.Nuevo)
                {
                    int idGenerado = DepreciacionDAO.InsertarCabecera(cabecera);

                    if (idGenerado > 0)
                    {
                        _idCabeceraActual = idGenerado;
                        cabecera.ID_CABECERA = idGenerado;

                        string numeroDepreciacionUI = $"DEP-{dtpFechaDepreciacion.Value:yyyyMMdd}-{idGenerado}";
                        DepreciacionDAO.ActualizarNumeroDepreciacionUI(idGenerado, numeroDepreciacionUI);

                        txtNumeroDepreciacion.Text = numeroDepreciacionUI;
                        cabecera.NUMERO_DEPRECIACION_UI = numeroDepreciacionUI;

                        GuardarDetallesDepreciacion(idGenerado);

                        MessageBox.Show("Depreciación registrada exitosamente con el número: " + numeroDepreciacionUI, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar la cabecera de depreciación. No se generó un ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (estadoActual == EstadoFormulario.Modificar)
                {
                    if (_idCabeceraActual == 0)
                    {
                        MessageBox.Show("No hay una depreciación seleccionada para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cabecera.ID_CABECERA = _idCabeceraActual;
                    DepreciacionDAO.ActualizarCabecera(cabecera);

                    MessageBox.Show("Depreciación actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                HabilitarControles(EstadoFormulario.Consultar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar/actualizar la depreciación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarDetallesDepreciacion(int idCabeceraFK)
        {
            if (dgvDetallesDepreciacion.Rows.Count > 0)
            {
                // NOTA: Descomenta la siguiente línea solo si el proceso de "Depreciar Mes Actual"
                // puede ser ejecutado múltiples veces para la misma cabecera y necesitas
                // reemplazar los detalles existentes en lugar de añadir.
                // DepreciacionDAO.EliminarDetallesPorCabecera(idCabeceraFK);

                foreach (DataGridViewRow row in dgvDetallesDepreciacion.Rows)
                {
                    if (row.IsNewRow) continue;

                    try
                    {
                        DepreciacionDetalle detalle = new DepreciacionDetalle
                        {
                            ID_CABECERA_FK = idCabeceraFK,
                            ID_ACTIVO_FK = row.Cells["IdActivo"].Value?.ToString(),
                            PERIODO_DEPRECIACION_NUM = Convert.ToInt32(row.Cells["PeriodoDepreciacion"].Value),
                            VALOR_DEPRECIACION_PERIODO = Convert.ToDecimal(row.Cells["ValorDepreciacionPeriodo"].Value),
                            DEPRECIACION_ACUMULADA = Convert.ToDecimal(row.Cells["DepreciacionAcumulada"].Value),
                            VALOR_EN_LIBROS_ACTUAL = Convert.ToDecimal(row.Cells["ValorEnLibros"].Value)
                        };
                        DepreciacionDAO.InsertarDetalle(detalle);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al guardar detalle para activo {row.Cells["IdActivo"].Value}: {ex.Message}");
                        MessageBox.Show($"Error al guardar algunos detalles. Revise la consola para más información. {ex.Message}", "Error al Guardar Detalles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnModificarCabecera_Click(object sender, EventArgs e)
        {
            if (_idCabeceraActual == 0)
            {
                MessageBox.Show("Primero debe buscar y seleccionar una depreciación para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HabilitarControles(EstadoFormulario.Nulo);
                return;
            }

            HabilitarControles(EstadoFormulario.Modificar);
            MessageBox.Show(
                "Puede modificar las observaciones o el responsable y luego haga clic en 'Guardar'.",
                "Modificar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnEliminarCabecera_Click(object sender, EventArgs e)
        {
            if (_idCabeceraActual == 0)
            {
                MessageBox.Show("No hay una depreciación seleccionada para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HabilitarControles(EstadoFormulario.Nulo);
                return;
            }

            if (MessageBox.Show(
                "¿Está seguro de que desea eliminar esta depreciación y todos sus detalles? Esta acción es irreversible.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes)
            {
                try
                {
                    DepreciacionDAO.EliminarDetallesPorCabecera(_idCabeceraActual);
                    DepreciacionDAO.EliminarCabecera(_idCabeceraActual);

                    MessageBox.Show(
                        "Depreciación eliminada exitosamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    LimpiarCamposCabecera();
                    HabilitarControles(EstadoFormulario.Nulo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al eliminar la depreciación: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnBuscarCabecera_Click(object sender, EventArgs e)
        {
            // CAMBIO: Usamos FormBuscarId para simular la entrada de ID,
            // ya que Microsoft.VisualBasic.Interaction.InputBox puede causar problemas de referencia.
            // Si quieres usar InputBox, deberás añadir la referencia a Microsoft.VisualBasic en tu proyecto.
            // Para simplificar, aquí se propone un uso directo de MessageBox o un formulario simple si es necesario.

            // Alternativa simple con MessageBox (NO permite entrada de texto)
            // MessageBox.Show("Implementa aquí un formulario de búsqueda para seleccionar una depreciación.", "Buscar Depreciación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Alternativa con InputBox (requiere referencia a Microsoft.VisualBasic)
            string input = "";
            try
            {
                // Intenta usar el InputBox. Si el proyecto no tiene la referencia a Microsoft.VisualBasic,
                // esto causará un error en tiempo de ejecución o compilación.
                input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID de la depreciación a buscar:", "Buscar Depreciación", "1");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al usar InputBox. Asegúrate de tener la referencia a 'Microsoft.VisualBasic' añadida en tu proyecto. Detalle: " + ex.Message, "Error de Componente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir si hay error con InputBox
            }

            if (int.TryParse(input, out int idBuscado))
            {
                try
                {
                    DepreciacionCabecera cabeceraCargada = DepreciacionDAO.ObtenerCabeceraPorId(idBuscado);
                    if (cabeceraCargada != null)
                    {
                        _idCabeceraActual = cabeceraCargada.ID_CABECERA;
                        txtNumeroDepreciacion.Text = cabeceraCargada.NUMERO_DEPRECIACION_UI;
                        dtpFechaDepreciacion.Value = cabeceraCargada.FECHA;
                        txtResponsable.Text = cabeceraCargada.RESPONSABLE;
                        txtObservaciones.Text = cabeceraCargada.OBSERVACIONES;

                        List<DepreciacionDetalle> detalles = DepreciacionDAO.ObtenerDetallesPorCabecera(cabeceraCargada.ID_CABECERA);
                        CargarDetallesEnDataGridView(detalles);

                        HabilitarControles(EstadoFormulario.Consultar);
                        MessageBox.Show($"Depreciación {cabeceraCargada.NUMERO_DEPRECIACION_UI} cargada exitosamente.", "Búsqueda Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la depreciación con el ID especificado.", "No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCamposCabecera();
                        HabilitarControles(EstadoFormulario.Nulo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar la depreciación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCamposCabecera();
                    HabilitarControles(EstadoFormulario.Nulo);
                }
            }
            else
            {
                MessageBox.Show("ID de depreciación inválido. Ingrese un número entero.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCamposCabecera();
                HabilitarControles(EstadoFormulario.Nulo);
            }
        }

        private void CargarDetallesEnDataGridView(List<DepreciacionDetalle> detalles)
        {
            dgvDetallesDepreciacion.Rows.Clear();

            foreach (var detalle in detalles)
            {
                string nombreActivo = "Activo Desconocido (" + detalle.ID_ACTIVO_FK + ")";
                // Aquí deberías obtener los datos del activo real (nombre, fecha adquisición, costo, vida útil, valor residual)
                // desde tu ActivoDAO, usando detalle.ID_ACTIVO_FK.
                // Por ahora, usamos placeholders.
                DateTime fechaAdquisicionActivo = DateTime.MinValue; // Placeholder
                decimal costoActivo = 0m; // Placeholder
                int vidaUtilActivo = 0; // Placeholder
                decimal valorResidualActivo = 0m; // Placeholder

                dgvDetallesDepreciacion.Rows.Add(
                    detalle.ID_ACTIVO_FK,
                    nombreActivo,
                    fechaAdquisicionActivo.ToShortDateString(), // Formato de fecha
                    costoActivo,
                    vidaUtilActivo,
                    valorResidualActivo,
                    detalle.PERIODO_DEPRECIACION_NUM,
                    detalle.VALOR_DEPRECIACION_PERIODO,
                    detalle.DEPRECIACION_ACUMULADA,
                    detalle.VALOR_EN_LIBROS_ACTUAL
                );
            }
            foreach (DataGridViewColumn col in dgvDetallesDepreciacion.Columns)
            {
                if (col.Name.Contains("Costo") || col.Name.Contains("Valor") || col.Name.Contains("Depreciacion"))
                {
                    col.DefaultCellStyle.Format = "C";
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDepreciarMesActual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResponsable.Text))
            {
                MessageBox.Show("Debe ingresar un responsable antes de depreciar el mes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResponsable.Focus();
                return;
            }

            if (MessageBox.Show(
                "¿Desea calcular y registrar la depreciación para TODOS los activos para el mes actual?",
                "Confirmar Depreciación Masiva",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.No)
            {
                return;
            }

            try
            {
                dgvDetallesDepreciacion.Rows.Clear();

                // --- INICIO: REEMPLAZA ESTO CON LA OBTENCIÓN DE ACTIVOS REALES DE TU ActivoDAO ---
                DataTable dtActivos = new DataTable();
                dtActivos.Columns.Add("ID", typeof(string));
                dtActivos.Columns.Add("Nombre", typeof(string));
                dtActivos.Columns.Add("FechaAdquisicion", typeof(DateTime));
                dtActivos.Columns.Add("Costo", typeof(decimal));
                dtActivos.Columns.Add("VidaUtil", typeof(int));
                dtActivos.Columns.Add("ValorResidual", typeof(decimal));

                dtActivos.Rows.Add("LIB-001", "El Quijote", new DateTime(2022, 1, 15), 50.00m, 5, 5.00m);
                dtActivos.Rows.Add("EQ-005", "Portátil HP", new DateTime(2023, 3, 10), 1200.00m, 3, 120.00m);
                dtActivos.Rows.Add("MOB-010", "Escritorio Roble", new DateTime(2021, 6, 20), 300.00m, 10, 30.00m);
                // --- FIN: SIMULACIÓN ---

                foreach (DataRow row in dtActivos.Rows)
                {
                    string idActivo = row["ID"].ToString();
                    string nombreActivo = row["Nombre"].ToString();
                    DateTime fechaAdquisicion = (DateTime)row["FechaAdquisicion"];
                    decimal costo = (decimal)row["Costo"];
                    int vidaUtilAnios = (int)row["VidaUtil"];
                    decimal valorResidual = (decimal)row["ValorResidual"];

                    decimal baseDepreciable = costo - valorResidual;
                    decimal depreciacionAnual = (vidaUtilAnios > 0) ? Math.Round(baseDepreciable / vidaUtilAnios, 2) : 0m;
                    decimal depreciacionMensual = Math.Round(depreciacionAnual / 12, 2);

                    int periodoDepreciacion = (DateTime.Now.Year - fechaAdquisicion.Year) * 12 +
                                              (DateTime.Now.Month - fechaAdquisicion.Month) + 1;

                    if (periodoDepreciacion < 0) periodoDepreciacion = 0;

                    decimal depAcumuladaSimulada = depreciacionMensual * periodoDepreciacion;
                    decimal valorEnLibrosSimulado = costo - depAcumuladaSimulada;

                    if (valorEnLibrosSimulado < valorResidual)
                    {
                        valorEnLibrosSimulado = valorResidual;
                        depAcumuladaSimulada = costo - valorResidual;
                        decimal valorEnLibrosAntesEstePeriodo = costo - (depAcumuladaSimulada - depreciacionMensual);
                        if (valorEnLibrosAntesEstePeriodo > valorResidual)
                        {
                            depreciacionMensual = valorEnLibrosAntesEstePeriodo - valorResidual;
                        }
                        else
                        {
                            depreciacionMensual = 0;
                        }
                    }

                    dgvDetallesDepreciacion.Rows.Add(
                        idActivo,
                        nombreActivo,
                        fechaAdquisicion.ToShortDateString(),
                        costo,
                        vidaUtilAnios,
                        valorResidual,
                        periodoDepreciacion,
                        depreciacionMensual,
                        depAcumuladaSimulada,
                        valorEnLibrosSimulado
                    );
                }

                MessageBox.Show(
                    "Depreciación para el mes actual calculada y lista para guardar. ¡No olvides hacer clic en 'Guardar'!",
                    "Depreciación Generada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                HabilitarControles(EstadoFormulario.Nuevo);
                btnDepreciarMesActual.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al calcular la depreciación de los activos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}