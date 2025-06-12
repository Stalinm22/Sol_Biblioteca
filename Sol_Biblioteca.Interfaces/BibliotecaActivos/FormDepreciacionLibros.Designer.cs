namespace Sol_Biblioteca.Interfaces.BibliotecaActivos
{
    partial class FormDepreciacionLibros
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtIdLibro = new System.Windows.Forms.TextBox();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.dtpFechaAdquisicion = new System.Windows.Forms.DateTimePicker();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtVidaUtil = new System.Windows.Forms.TextBox();
            this.txtValorResidual = new System.Windows.Forms.TextBox();
            this.dgvDepreciacion = new System.Windows.Forms.DataGridView();
            this.chartDepreciacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelControles = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panelGrafico = new System.Windows.Forms.Panel();
            this.panelTabla = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepreciacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepreciacion)).BeginInit();
            this.panelControles.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelGrafico.SuspendLayout();
            this.panelTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdLibro
            // 
            this.txtIdLibro.Location = new System.Drawing.Point(130, 15);
            this.txtIdLibro.Name = "txtIdLibro";
            this.txtIdLibro.ReadOnly = true;
            this.txtIdLibro.Size = new System.Drawing.Size(100, 26);
            this.txtIdLibro.TabIndex = 0;
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(130, 55);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.ReadOnly = true;
            this.txtTituloLibro.Size = new System.Drawing.Size(300, 26);
            this.txtTituloLibro.TabIndex = 1;
            // 
            // dtpFechaAdquisicion
            // 
            this.dtpFechaAdquisicion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAdquisicion.Location = new System.Drawing.Point(130, 95);
            this.dtpFechaAdquisicion.Name = "dtpFechaAdquisicion";
            this.dtpFechaAdquisicion.Size = new System.Drawing.Size(150, 26);
            this.dtpFechaAdquisicion.TabIndex = 2;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(130, 135);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 26);
            this.txtCosto.TabIndex = 3;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVidaUtil
            // 
            this.txtVidaUtil.Location = new System.Drawing.Point(130, 175);
            this.txtVidaUtil.Name = "txtVidaUtil";
            this.txtVidaUtil.Size = new System.Drawing.Size(100, 26);
            this.txtVidaUtil.TabIndex = 4;
            this.txtVidaUtil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorResidual
            // 
            this.txtValorResidual.Location = new System.Drawing.Point(130, 215);
            this.txtValorResidual.Name = "txtValorResidual";
            this.txtValorResidual.Size = new System.Drawing.Size(100, 26);
            this.txtValorResidual.TabIndex = 5;
            this.txtValorResidual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvDepreciacion
            // 
            this.dgvDepreciacion.AllowUserToAddRows = false;
            this.dgvDepreciacion.AllowUserToDeleteRows = false;
            this.dgvDepreciacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepreciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepreciacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepreciacion.Location = new System.Drawing.Point(0, 0);
            this.dgvDepreciacion.Name = "dgvDepreciacion";
            this.dgvDepreciacion.ReadOnly = true;
            this.dgvDepreciacion.RowHeadersWidth = 62;
            this.dgvDepreciacion.RowTemplate.Height = 28;
            this.dgvDepreciacion.Size = new System.Drawing.Size(776, 200);
            this.dgvDepreciacion.TabIndex = 6;
            // 
            // chartDepreciacion
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDepreciacion.ChartAreas.Add(chartArea1);
            this.chartDepreciacion.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDepreciacion.Legends.Add(legend1);
            this.chartDepreciacion.Location = new System.Drawing.Point(0, 0);
            this.chartDepreciacion.Name = "chartDepreciacion";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Valor en Libros";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Depreciación Acumulada";
            this.chartDepreciacion.Series.Add(series1);
            this.chartDepreciacion.Series.Add(series2);
            this.chartDepreciacion.Size = new System.Drawing.Size(776, 200);
            this.chartDepreciacion.TabIndex = 7;
            this.chartDepreciacion.Text = "chart1";
            // 
            // lblResumen
            // 
            this.lblResumen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblResumen.Location = new System.Drawing.Point(0, 630);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(800, 40);
            this.lblResumen.TabIndex = 8;
            this.lblResumen.Text = "Resumen de depreciación";
            this.lblResumen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(20, 10);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 35);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(150, 10);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(120, 35);
            this.btnExportar.TabIndex = 10;
            this.btnExportar.Text = "Exportar CSV";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(280, 10);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 35);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(410, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 35);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Teal;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(540, 10);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(50, 35);
            this.btnInfo.TabIndex = 13;
            this.btnInfo.Text = "?";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID Libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Título Libro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha Adquisición:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Costo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Vida Útil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Valor Residual:";
            // 
            // panelControles
            // 
            this.panelControles.Controls.Add(this.label1);
            this.panelControles.Controls.Add(this.label6);
            this.panelControles.Controls.Add(this.txtIdLibro);
            this.panelControles.Controls.Add(this.label5);
            this.panelControles.Controls.Add(this.txtTituloLibro);
            this.panelControles.Controls.Add(this.label4);
            this.panelControles.Controls.Add(this.dtpFechaAdquisicion);
            this.panelControles.Controls.Add(this.label3);
            this.panelControles.Controls.Add(this.txtCosto);
            this.panelControles.Controls.Add(this.label2);
            this.panelControles.Controls.Add(this.txtVidaUtil);
            this.panelControles.Controls.Add(this.txtValorResidual);
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControles.Location = new System.Drawing.Point(0, 0);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(800, 260);
            this.panelControles.TabIndex = 20;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnCalcular);
            this.panelBotones.Controls.Add(this.btnInfo);
            this.panelBotones.Controls.Add(this.btnExportar);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotones.Location = new System.Drawing.Point(0, 260);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(800, 60);
            this.panelBotones.TabIndex = 21;
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.dgvDepreciacion);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabla.Location = new System.Drawing.Point(0, 320);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(800, 200);
            this.panelTabla.TabIndex = 22;
            // 
            // panelGrafico
            // 
            this.panelGrafico.Controls.Add(this.chartDepreciacion);
            this.panelGrafico.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGrafico.Location = new System.Drawing.Point(0, 520);
            this.panelGrafico.Name = "panelGrafico";
            this.panelGrafico.Size = new System.Drawing.Size(800, 200);
            this.panelGrafico.TabIndex = 23;
            // 
            // FormDepreciacionLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.panelGrafico);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelControles);
            this.Name = "FormDepreciacionLibros";
            this.Text = "Depreciación de Libros";
            this.Load += new System.EventHandler(this.FormDepreciacionLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepreciacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepreciacion)).EndInit();
            this.panelControles.ResumeLayout(false);
            this.panelControles.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.panelGrafico.ResumeLayout(false);
            this.panelTabla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdLibro;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.DateTimePicker dtpFechaAdquisicion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtVidaUtil;
        private System.Windows.Forms.TextBox txtValorResidual;
        private System.Windows.Forms.DataGridView dgvDepreciacion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDepreciacion;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.Panel panelGrafico;
    }
}