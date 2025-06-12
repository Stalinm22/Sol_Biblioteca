namespace Sol_Biblioteca.Interfaces.BibliotecaActivos
{
    partial class FormGestionDepreciaciones
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
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaDepreciacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroDepreciacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBotonesCabecera = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnDepreciarMesActual = new System.Windows.Forms.Button();
            this.btnBuscarCabecera = new System.Windows.Forms.Button();
            this.btnEliminarCabecera = new System.Windows.Forms.Button();
            this.btnModificarCabecera = new System.Windows.Forms.Button();
            this.btnGuardarCabecera = new System.Windows.Forms.Button();
            this.btnNuevoCabecera = new System.Windows.Forms.Button();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.dgvDetallesDepreciacion = new System.Windows.Forms.DataGridView();
            this.panelCabecera.SuspendLayout();
            this.panelBotonesCabecera.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesDepreciacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.Controls.Add(this.txtResponsable);
            this.panelCabecera.Controls.Add(this.label4);
            this.panelCabecera.Controls.Add(this.txtObservaciones);
            this.panelCabecera.Controls.Add(this.label3);
            this.panelCabecera.Controls.Add(this.dtpFechaDepreciacion);
            this.panelCabecera.Controls.Add(this.label2);
            this.panelCabecera.Controls.Add(this.txtNumeroDepreciacion);
            this.panelCabecera.Controls.Add(this.label1);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(900, 150);
            this.panelCabecera.TabIndex = 0;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(580, 20);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(200, 26);
            this.txtResponsable.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Responsable:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(120, 60);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(660, 70);
            this.txtObservaciones.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Observaciones:";
            // 
            // dtpFechaDepreciacion
            // 
            this.dtpFechaDepreciacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDepreciacion.Location = new System.Drawing.Point(310, 20);
            this.dtpFechaDepreciacion.Name = "dtpFechaDepreciacion";
            this.dtpFechaDepreciacion.Size = new System.Drawing.Size(150, 26);
            this.dtpFechaDepreciacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // txtNumeroDepreciacion
            // 
            this.txtNumeroDepreciacion.Location = new System.Drawing.Point(120, 20);
            this.txtNumeroDepreciacion.Name = "txtNumeroDepreciacion";
            this.txtNumeroDepreciacion.ReadOnly = true;
            this.txtNumeroDepreciacion.Size = new System.Drawing.Size(100, 26);
            this.txtNumeroDepreciacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // panelBotonesCabecera
            // 
            this.panelBotonesCabecera.Controls.Add(this.btnCerrar);
            this.panelBotonesCabecera.Controls.Add(this.btnDepreciarMesActual);
            this.panelBotonesCabecera.Controls.Add(this.btnBuscarCabecera);
            this.panelBotonesCabecera.Controls.Add(this.btnEliminarCabecera);
            this.panelBotonesCabecera.Controls.Add(this.btnModificarCabecera);
            this.panelBotonesCabecera.Controls.Add(this.btnGuardarCabecera);
            this.panelBotonesCabecera.Controls.Add(this.btnNuevoCabecera);
            this.panelBotonesCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotonesCabecera.Location = new System.Drawing.Point(0, 150);
            this.panelBotonesCabecera.Name = "panelBotonesCabecera";
            this.panelBotonesCabecera.Size = new System.Drawing.Size(900, 60);
            this.panelBotonesCabecera.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(780, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnDepreciarMesActual
            // 
            this.btnDepreciarMesActual.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDepreciarMesActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepreciarMesActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepreciarMesActual.ForeColor = System.Drawing.Color.White;
            this.btnDepreciarMesActual.Location = new System.Drawing.Point(580, 10);
            this.btnDepreciarMesActual.Name = "btnDepreciarMesActual";
            this.btnDepreciarMesActual.Size = new System.Drawing.Size(180, 40);
            this.btnDepreciarMesActual.TabIndex = 5;
            this.btnDepreciarMesActual.UseVisualStyleBackColor = false;
            this.btnDepreciarMesActual.Click += new System.EventHandler(this.btnDepreciarMesActual_Click);
            // 
            // btnBuscarCabecera
            // 
            this.btnBuscarCabecera.Location = new System.Drawing.Point(430, 15);
            this.btnBuscarCabecera.Name = "btnBuscarCabecera";
            this.btnBuscarCabecera.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarCabecera.TabIndex = 4;
            this.btnBuscarCabecera.UseVisualStyleBackColor = true;
            this.btnBuscarCabecera.Click += new System.EventHandler(this.btnBuscarCabecera_Click);
            // 
            // btnEliminarCabecera
            // 
            this.btnEliminarCabecera.Location = new System.Drawing.Point(325, 15);
            this.btnEliminarCabecera.Name = "btnEliminarCabecera";
            this.btnEliminarCabecera.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarCabecera.TabIndex = 3;
            this.btnEliminarCabecera.UseVisualStyleBackColor = true;
            this.btnEliminarCabecera.Click += new System.EventHandler(this.btnEliminarCabecera_Click);
            // 
            // btnModificarCabecera
            // 
            this.btnModificarCabecera.Location = new System.Drawing.Point(220, 15);
            this.btnModificarCabecera.Name = "btnModificarCabecera";
            this.btnModificarCabecera.Size = new System.Drawing.Size(100, 30);
            this.btnModificarCabecera.TabIndex = 2;
            this.btnModificarCabecera.UseVisualStyleBackColor = true;
            this.btnModificarCabecera.Click += new System.EventHandler(this.btnModificarCabecera_Click);
            // 
            // btnGuardarCabecera
            // 
            this.btnGuardarCabecera.Location = new System.Drawing.Point(115, 15);
            this.btnGuardarCabecera.Name = "btnGuardarCabecera";
            this.btnGuardarCabecera.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarCabecera.TabIndex = 1;
            this.btnGuardarCabecera.UseVisualStyleBackColor = true;
            this.btnGuardarCabecera.Click += new System.EventHandler(this.btnGuardarCabecera_Click);
            // 
            // btnNuevoCabecera
            // 
            this.btnNuevoCabecera.Location = new System.Drawing.Point(10, 15);
            this.btnNuevoCabecera.Name = "btnNuevoCabecera";
            this.btnNuevoCabecera.Size = new System.Drawing.Size(100, 30);
            this.btnNuevoCabecera.TabIndex = 0;
            this.btnNuevoCabecera.UseVisualStyleBackColor = true;
            this.btnNuevoCabecera.Click += new System.EventHandler(this.btnNuevoCabecera_Click);
            // 
            // panelDetalle
            // 
            this.panelDetalle.Controls.Add(this.dgvDetallesDepreciacion);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.Location = new System.Drawing.Point(0, 210);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(900, 390);
            this.panelDetalle.TabIndex = 2;
            // 
            // dgvDetallesDepreciacion
            // 
            this.dgvDetallesDepreciacion.AllowUserToAddRows = false;
            this.dgvDetallesDepreciacion.AllowUserToDeleteRows = false;
            this.dgvDetallesDepreciacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallesDepreciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesDepreciacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetallesDepreciacion.Location = new System.Drawing.Point(0, 0);
            this.dgvDetallesDepreciacion.Name = "dgvDetallesDepreciacion";
            this.dgvDetallesDepreciacion.ReadOnly = true;
            this.dgvDetallesDepreciacion.RowHeadersWidth = 62;
            this.dgvDetallesDepreciacion.RowTemplate.Height = 28;
            this.dgvDetallesDepreciacion.Size = new System.Drawing.Size(900, 390);
            this.dgvDetallesDepreciacion.TabIndex = 0;
            // 
            // FormGestionDepreciaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.panelBotonesCabecera);
            this.Controls.Add(this.panelCabecera);
            this.Name = "FormGestionDepreciaciones";
            this.Load += new System.EventHandler(this.FormGestionDepreciaciones_Load);
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            this.panelBotonesCabecera.ResumeLayout(false);
            this.panelDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesDepreciacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaDepreciacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroDepreciacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBotonesCabecera;
        private System.Windows.Forms.Button btnBuscarCabecera;
        private System.Windows.Forms.Button btnEliminarCabecera;
        private System.Windows.Forms.Button btnModificarCabecera;
        private System.Windows.Forms.Button btnGuardarCabecera;
        private System.Windows.Forms.Button btnNuevoCabecera;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.DataGridView dgvDetallesDepreciacion;
        private System.Windows.Forms.Button btnDepreciarMesActual;
        private System.Windows.Forms.Button btnCerrar;
    }
}