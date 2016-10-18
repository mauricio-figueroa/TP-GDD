namespace LOS_INSISTENTES.Facturas
{
    partial class Facturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.chkDescripcion = new System.Windows.Forms.CheckBox();
            this.tImporteHasta = new System.Windows.Forms.TextBox();
            this.tImporteDesde = new System.Windows.Forms.TextBox();
            this.chkImporte = new System.Windows.Forms.CheckBox();
            this.lblImporteHasta = new System.Windows.Forms.Label();
            this.lblImporteDesde = new System.Windows.Forms.Label();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.grpFacturas = new System.Windows.Forms.GroupBox();
            this.dgFacturas = new System.Windows.Forms.DataGridView();
            this.grpFiltros.SuspendLayout();
            this.grpFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(368, 265);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 50);
            this.btnAnterior.TabIndex = 6;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(466, 265);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 50);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.btnFiltrar);
            this.grpFiltros.Controls.Add(this.tDescripcion);
            this.grpFiltros.Controls.Add(this.chkDescripcion);
            this.grpFiltros.Controls.Add(this.tImporteHasta);
            this.grpFiltros.Controls.Add(this.tImporteDesde);
            this.grpFiltros.Controls.Add(this.chkImporte);
            this.grpFiltros.Controls.Add(this.lblImporteHasta);
            this.grpFiltros.Controls.Add(this.lblImporteDesde);
            this.grpFiltros.Controls.Add(this.chkFecha);
            this.grpFiltros.Controls.Add(this.dtFechaHasta);
            this.grpFiltros.Controls.Add(this.lblFechaHasta);
            this.grpFiltros.Controls.Add(this.dtFechaDesde);
            this.grpFiltros.Controls.Add(this.lblFechaDesde);
            this.grpFiltros.Location = new System.Drawing.Point(13, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(547, 185);
            this.grpFiltros.TabIndex = 10;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(421, 111);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 50);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // tDescripcion
            // 
            this.tDescripcion.Enabled = false;
            this.tDescripcion.Location = new System.Drawing.Point(154, 128);
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(154, 20);
            this.tDescripcion.TabIndex = 45;
            // 
            // chkDescripcion
            // 
            this.chkDescripcion.AutoSize = true;
            this.chkDescripcion.Location = new System.Drawing.Point(23, 130);
            this.chkDescripcion.Name = "chkDescripcion";
            this.chkDescripcion.Size = new System.Drawing.Size(99, 17);
            this.chkDescripcion.TabIndex = 44;
            this.chkDescripcion.Text = "Por descripción";
            this.chkDescripcion.UseVisualStyleBackColor = true;
            this.chkDescripcion.CheckedChanged += new System.EventHandler(this.chkDescripcion_CheckedChanged);
            // 
            // tImporteHasta
            // 
            this.tImporteHasta.Enabled = false;
            this.tImporteHasta.Location = new System.Drawing.Point(402, 75);
            this.tImporteHasta.Name = "tImporteHasta";
            this.tImporteHasta.Size = new System.Drawing.Size(94, 20);
            this.tImporteHasta.TabIndex = 43;
            this.tImporteHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tImporteHasta_KeyPress);
            // 
            // tImporteDesde
            // 
            this.tImporteDesde.Enabled = false;
            this.tImporteDesde.Location = new System.Drawing.Point(215, 75);
            this.tImporteDesde.Name = "tImporteDesde";
            this.tImporteDesde.Size = new System.Drawing.Size(94, 20);
            this.tImporteDesde.TabIndex = 42;
            this.tImporteDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tImporteDesde_KeyPress);
            // 
            // chkImporte
            // 
            this.chkImporte.AutoSize = true;
            this.chkImporte.Location = new System.Drawing.Point(24, 78);
            this.chkImporte.Name = "chkImporte";
            this.chkImporte.Size = new System.Drawing.Size(79, 17);
            this.chkImporte.TabIndex = 41;
            this.chkImporte.Text = "Por importe";
            this.chkImporte.UseVisualStyleBackColor = true;
            this.chkImporte.CheckedChanged += new System.EventHandler(this.chkImporte_CheckedChanged);
            // 
            // lblImporteHasta
            // 
            this.lblImporteHasta.AutoSize = true;
            this.lblImporteHasta.Location = new System.Drawing.Point(346, 79);
            this.lblImporteHasta.Name = "lblImporteHasta";
            this.lblImporteHasta.Size = new System.Drawing.Size(38, 13);
            this.lblImporteHasta.TabIndex = 39;
            this.lblImporteHasta.Text = "Hasta:";
            // 
            // lblImporteDesde
            // 
            this.lblImporteDesde.AutoSize = true;
            this.lblImporteDesde.Location = new System.Drawing.Point(151, 79);
            this.lblImporteDesde.Name = "lblImporteDesde";
            this.lblImporteDesde.Size = new System.Drawing.Size(41, 13);
            this.lblImporteDesde.TabIndex = 37;
            this.lblImporteDesde.Text = "Desde:";
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(24, 26);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(72, 17);
            this.chkFecha.TabIndex = 36;
            this.chkFecha.Text = "Por fecha";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.CustomFormat = "  dd/MM/yyyy";
            this.dtFechaHasta.Enabled = false;
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaHasta.Location = new System.Drawing.Point(402, 24);
            this.dtFechaHasta.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtFechaHasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(94, 20);
            this.dtFechaHasta.TabIndex = 35;
            this.dtFechaHasta.Value = new System.DateTime(2016, 6, 10, 0, 0, 0, 0);
            this.dtFechaHasta.ValueChanged += new System.EventHandler(this.dtFechaHasta_ValueChanged);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(346, 27);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(38, 13);
            this.lblFechaHasta.TabIndex = 34;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.CustomFormat = "  dd/MM/yyyy";
            this.dtFechaDesde.Enabled = false;
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaDesde.Location = new System.Drawing.Point(215, 24);
            this.dtFechaDesde.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtFechaDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(94, 20);
            this.dtFechaDesde.TabIndex = 33;
            this.dtFechaDesde.Value = new System.DateTime(2016, 6, 10, 0, 0, 0, 0);
            this.dtFechaDesde.ValueChanged += new System.EventHandler(this.dtFechaDesde_ValueChanged);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(151, 27);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(41, 13);
            this.lblFechaDesde.TabIndex = 32;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // grpFacturas
            // 
            this.grpFacturas.Controls.Add(this.dgFacturas);
            this.grpFacturas.Controls.Add(this.btnSiguiente);
            this.grpFacturas.Controls.Add(this.btnAnterior);
            this.grpFacturas.Location = new System.Drawing.Point(15, 203);
            this.grpFacturas.Name = "grpFacturas";
            this.grpFacturas.Size = new System.Drawing.Size(547, 321);
            this.grpFacturas.TabIndex = 11;
            this.grpFacturas.TabStop = false;
            this.grpFacturas.Text = "Todas las facturas";
            // 
            // dgFacturas
            // 
            this.dgFacturas.AllowUserToAddRows = false;
            this.dgFacturas.AllowUserToDeleteRows = false;
            this.dgFacturas.AllowUserToOrderColumns = true;
            this.dgFacturas.AllowUserToResizeColumns = false;
            this.dgFacturas.AllowUserToResizeRows = false;
            this.dgFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgFacturas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFacturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgFacturas.Location = new System.Drawing.Point(47, 31);
            this.dgFacturas.Name = "dgFacturas";
            this.dgFacturas.ReadOnly = true;
            this.dgFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgFacturas.RowHeadersVisible = false;
            this.dgFacturas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgFacturas.Size = new System.Drawing.Size(444, 228);
            this.dgFacturas.TabIndex = 5;
            this.dgFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFacturas_CellContentClick);
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 536);
            this.Controls.Add(this.grpFacturas);
            this.Controls.Add(this.grpFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Facturas";
            this.Text = "Form1";
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.grpFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.GroupBox grpFacturas;
        private System.Windows.Forms.DataGridView dgFacturas;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.CheckBox chkImporte;
        private System.Windows.Forms.Label lblImporteHasta;
        private System.Windows.Forms.Label lblImporteDesde;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.TextBox tImporteDesde;
        private System.Windows.Forms.TextBox tImporteHasta;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.CheckBox chkDescripcion;
        private System.Windows.Forms.Button btnFiltrar;


    }
}