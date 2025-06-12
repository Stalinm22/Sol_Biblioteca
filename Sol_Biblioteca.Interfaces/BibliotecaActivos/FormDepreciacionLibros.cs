using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sol_Biblioteca.Interfaces.BibliotecaActivos
{
    public partial class FormDepreciacionLibros : Form
    {
        public string IdLibro { get; set; }
        public string TituloLibro { get; set; }

        public FormDepreciacionLibros()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ConfigurarGrafico();
        }

        public FormDepreciacionLibros(string idLibro, string titulo, DateTime fechaAdquisicion,
                                      decimal costoAdquisicion, int vidaUtil, decimal valorSalvamento)
            : this()
        {
            this.IdLibro = idLibro;
            this.TituloLibro = titulo;

            txtIdLibro.Text = idLibro;
            txtTituloLibro.Text = titulo;
            dtpFechaAdquisicion.Value = fechaAdquisicion;
            txtCosto.Text = costoAdquisicion.ToString("0.00");
            txtVidaUtil.Text = vidaUtil.ToString();
            txtValorResidual.Text = valorSalvamento.ToString("0.00");

            CalcularDepreciacionLibros();
        }

        private void FormDepreciacionLibros_Load(object sender, EventArgs e)
        {
            // Valores por defecto si no hay datos
            if (string.IsNullOrEmpty(txtCosto.Text) || txtCosto.Text == "0")
            {
                dtpFechaAdquisicion.Value = DateTime.Today;
                txtVidaUtil.Text = "5";
                txtValorResidual.Text = "10";
                txtCosto.Text = "100";
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvDepreciacion.AutoGenerateColumns = false;
            dgvDepreciacion.AllowUserToAddRows = false;

            // Configurar columnas
            dgvDepreciacion.Columns.Clear();
            dgvDepreciacion.Columns.Add("Año", "Año");
            dgvDepreciacion.Columns.Add("ValorInicial", "Valor Inicial");
            dgvDepreciacion.Columns.Add("DepreciacionAnual", "Depreciación Anual");
            dgvDepreciacion.Columns.Add("DepreciacionAcumulada", "Depreciación Acumulada");
            dgvDepreciacion.Columns.Add("ValorEnLibros", "Valor en Libros");

            // Formato monetario para todas las columnas excepto "Año"
            foreach (DataGridViewColumn col in dgvDepreciacion.Columns)
            {
                if (col.Name != "Año")
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    col.DefaultCellStyle.Format = "C";
                }
            }
        }

        private void ConfigurarGrafico()
        {
            chartDepreciacion.Series.Clear();
            chartDepreciacion.Titles.Clear();
            chartDepreciacion.Titles.Add("Depreciación de Libros a lo largo del tiempo");
            chartDepreciacion.ChartAreas[0].AxisX.Title = "Año";
            chartDepreciacion.ChartAreas[0].AxisY.Title = "Valor ($)";
            chartDepreciacion.ChartAreas[0].AxisX.Interval = 1;
            chartDepreciacion.ChartAreas[0].AxisY.LabelStyle.Format = "C0";
            chartDepreciacion.ChartAreas[0].AxisY.Minimum = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;
            CalcularDepreciacionLibros();
        }

        private bool ValidarDatos()
        {
            if (!decimal.TryParse(txtCosto.Text, out decimal costo) || costo <= 0)
            {
                MessageBox.Show("Ingrese un costo de adquisición válido y mayor a cero.",
                                "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCosto.Focus();
                return false;
            }

            if (!decimal.TryParse(txtValorResidual.Text, out decimal valorResidual) || valorResidual < 0)
            {
                MessageBox.Show("Ingrese un valor de salvamento (residual) válido y no negativo.",
                                "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorResidual.Focus();
                return false;
            }

            if (!int.TryParse(txtVidaUtil.Text, out int vidaUtil) || vidaUtil <= 0)
            {
                MessageBox.Show("Ingrese una vida útil estimada válida y mayor a cero.",
                                "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVidaUtil.Focus();
                return false;
            }

            if (valorResidual >= costo)
            {
                MessageBox.Show("El valor de salvamento debe ser menor que el costo de adquisición.",
                                "Error de Lógica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorResidual.Focus();
                return false;
            }

            return true;
        }

        private void CalcularDepreciacionLibros()
        {
            decimal costo = decimal.Parse(txtCosto.Text);
            decimal valorResidual = decimal.Parse(txtValorResidual.Text);
            int vidaUtil = int.Parse(txtVidaUtil.Text);

            decimal baseDepreciable = costo - valorResidual;
            decimal depreciacionAnual = Math.Round(baseDepreciable / vidaUtil, 2);

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Año", typeof(int));
            tabla.Columns.Add("ValorInicial", typeof(decimal));
            tabla.Columns.Add("DepreciacionAnual", typeof(decimal));
            tabla.Columns.Add("DepreciacionAcumulada", typeof(decimal));
            tabla.Columns.Add("ValorEnLibros", typeof(decimal));

            chartDepreciacion.Series.Clear();
            Series serieValorEnLibros = chartDepreciacion.Series.Add("Valor en Libros");
            serieValorEnLibros.ChartType = SeriesChartType.Line;
            serieValorEnLibros.Color = Color.Blue;
            serieValorEnLibros.BorderWidth = 3;

            Series serieDepreciacionAcumulada = chartDepreciacion.Series.Add("Depreciación Acumulada");
            serieDepreciacionAcumulada.ChartType = SeriesChartType.Line;
            serieDepreciacionAcumulada.Color = Color.Red;
            serieDepreciacionAcumulada.BorderWidth = 2;

            decimal depreciacionAcumulada = 0;
            decimal valorEnLibros = costo;

            for (int anio = 1; anio <= vidaUtil; anio++)
            {
                decimal valorInicial = valorEnLibros;
                depreciacionAcumulada += depreciacionAnual;
                valorEnLibros = costo - depreciacionAcumulada;

                if (valorEnLibros < valorResidual)
                    valorEnLibros = valorResidual;

                tabla.Rows.Add(anio, valorInicial, depreciacionAnual, depreciacionAcumulada, valorEnLibros);

                serieValorEnLibros.Points.AddXY(anio, valorEnLibros);
                serieDepreciacionAcumulada.Points.AddXY(anio, depreciacionAcumulada);
            }

            dgvDepreciacion.DataSource = tabla;
            lblResumen.Text = $"Depreciación calculada por el método de línea recta.\n" +
                              $"Costo: {costo:C} | Salvamento: {valorResidual:C} | Vida útil: {vidaUtil} años\n" +
                              $"Depreciación anual: {depreciacionAnual:C}";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvDepreciacion.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.",
                                "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo CSV (*.csv)|*.csv";
                sfd.FileName = $"Depreciacion_{IdLibro}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            // Encabezados
                            for (int i = 0; i < dgvDepreciacion.Columns.Count; i++)
                            {
                                sw.Write(dgvDepreciacion.Columns[i].HeaderText);
                                if (i < dgvDepreciacion.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();

                            // Filas
                            foreach (DataGridViewRow row in dgvDepreciacion.Rows)
                            {
                                for (int i = 0; i < dgvDepreciacion.Columns.Count; i++)
                                {
                                    if (row.Cells[i].Value != null)
                                        sw.Write(row.Cells[i].Value);
                                    if (i < dgvDepreciacion.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }

                        MessageBox.Show("Exportación realizada correctamente.",
                                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar: " + ex.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCosto.Text = string.Empty;
            txtValorResidual.Text = string.Empty;
            txtVidaUtil.Text = string.Empty;
            dgvDepreciacion.DataSource = null;
            chartDepreciacion.Series.Clear();
            lblResumen.Text = string.Empty;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta herramienta calcula la depreciación de un libro usando el método de línea recta.\n\n" +
                            "Fórmula: Depreciación Anual = (Costo - Valor Residual) / Vida Útil",
                            "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}