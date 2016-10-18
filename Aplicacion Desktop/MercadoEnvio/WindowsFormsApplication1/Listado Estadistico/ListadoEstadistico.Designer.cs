namespace LOS_INSISTENTES.Listado_Estadistico
{
    partial class ListadoEstadistico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoEstadistico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gFiltros = new System.Windows.Forms.GroupBox();
            this.lstMes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatosObligatorios = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstVisibilidadORubro = new System.Windows.Forms.ComboBox();
            this.lblVisibilidadORubro = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstTrimestre = new System.Windows.Forms.ComboBox();
            this.TrimestreLabel = new System.Windows.Forms.Label();
            this.tAnio = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lstListado = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.gTopFive = new System.Windows.Forms.GroupBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.dgTopFive = new System.Windows.Forms.DataGridView();
            this.gFiltros.SuspendLayout();
            this.gTopFive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTopFive)).BeginInit();
            this.SuspendLayout();
            // 
            // gFiltros
            // 
            this.gFiltros.Controls.Add(this.lstMes);
            this.gFiltros.Controls.Add(this.label7);
            this.gFiltros.Controls.Add(this.label6);
            this.gFiltros.Controls.Add(this.label1);
            this.gFiltros.Controls.Add(this.lblDatosObligatorios);
            this.gFiltros.Controls.Add(this.label5);
            this.gFiltros.Controls.Add(this.lstVisibilidadORubro);
            this.gFiltros.Controls.Add(this.lblVisibilidadORubro);
            this.gFiltros.Controls.Add(this.lblMes);
            this.gFiltros.Controls.Add(this.btnBuscar);
            this.gFiltros.Controls.Add(this.lstTrimestre);
            this.gFiltros.Controls.Add(this.TrimestreLabel);
            this.gFiltros.Controls.Add(this.tAnio);
            this.gFiltros.Controls.Add(this.lblAnio);
            this.gFiltros.Location = new System.Drawing.Point(12, 12);
            this.gFiltros.Name = "gFiltros";
            this.gFiltros.Size = new System.Drawing.Size(506, 178);
            this.gFiltros.TabIndex = 1;
            this.gFiltros.TabStop = false;
            this.gFiltros.Text = "Filtros de Búsqueda";
            // 
            // lstMes
            // 
            this.lstMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstMes.FormattingEnabled = true;
            this.lstMes.Location = new System.Drawing.Point(136, 95);
            this.lstMes.Name = "lstMes";
            this.lstMes.Size = new System.Drawing.Size(93, 21);
            this.lstMes.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(325, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(118, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(118, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "(*)";
            // 
            // lblDatosObligatorios
            // 
            this.lblDatosObligatorios.AutoSize = true;
            this.lblDatosObligatorios.Location = new System.Drawing.Point(136, 139);
            this.lblDatosObligatorios.Name = "lblDatosObligatorios";
            this.lblDatosObligatorios.Size = new System.Drawing.Size(93, 13);
            this.lblDatosObligatorios.TabIndex = 25;
            this.lblDatosObligatorios.Text = "Datos Obligatorios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(119, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "(*)";
            // 
            // lstVisibilidadORubro
            // 
            this.lstVisibilidadORubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstVisibilidadORubro.FormattingEnabled = true;
            this.lstVisibilidadORubro.Location = new System.Drawing.Point(311, 95);
            this.lstVisibilidadORubro.Name = "lstVisibilidadORubro";
            this.lstVisibilidadORubro.Size = new System.Drawing.Size(178, 21);
            this.lstVisibilidadORubro.TabIndex = 5;
            // 
            // lblVisibilidadORubro
            // 
            this.lblVisibilidadORubro.AutoSize = true;
            this.lblVisibilidadORubro.Location = new System.Drawing.Point(249, 98);
            this.lblVisibilidadORubro.Name = "lblVisibilidadORubro";
            this.lblVisibilidadORubro.Size = new System.Drawing.Size(56, 13);
            this.lblVisibilidadORubro.TabIndex = 23;
            this.lblVisibilidadORubro.Text = "Visibilidad:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(47, 98);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 20;
            this.lblMes.Text = "Mes:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(415, 125);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 45);
            this.btnBuscar.TabIndex = 100;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstTrimestre
            // 
            this.lstTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTrimestre.FormattingEnabled = true;
            this.lstTrimestre.Location = new System.Drawing.Point(343, 26);
            this.lstTrimestre.Name = "lstTrimestre";
            this.lstTrimestre.Size = new System.Drawing.Size(147, 21);
            this.lstTrimestre.TabIndex = 2;
            this.lstTrimestre.SelectedIndexChanged += new System.EventHandler(this.lstTrimestre_SelectedIndexChanged);
            // 
            // TrimestreLabel
            // 
            this.TrimestreLabel.AutoSize = true;
            this.TrimestreLabel.Location = new System.Drawing.Point(274, 29);
            this.TrimestreLabel.Name = "TrimestreLabel";
            this.TrimestreLabel.Size = new System.Drawing.Size(53, 13);
            this.TrimestreLabel.TabIndex = 2;
            this.TrimestreLabel.Text = "Trimestre:";
            // 
            // tAnio
            // 
            this.tAnio.Location = new System.Drawing.Point(136, 26);
            this.tAnio.Name = "tAnio";
            this.tAnio.Size = new System.Drawing.Size(93, 20);
            this.tAnio.TabIndex = 1;
            this.tAnio.TextChanged += new System.EventHandler(this.tAnio_TextChanged);
            this.tAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tAnio_KeyPress);
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(37, 29);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 0;
            this.lblAnio.Text = "Año:";
            // 
            // lstListado
            // 
            this.lstListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstListado.FormattingEnabled = true;
            this.lstListado.Location = new System.Drawing.Point(148, 73);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(354, 21);
            this.lstListado.TabIndex = 3;
            this.lstListado.SelectedIndexChanged += new System.EventHandler(this.lstListado_SelectedIndexChanged);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(34, 76);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(83, 13);
            this.lblAño.TabIndex = 4;
            this.lblAño.Text = "Tipo de Listado:";
            // 
            // gTopFive
            // 
            this.gTopFive.Controls.Add(this.lblDetalle);
            this.gTopFive.Controls.Add(this.dgTopFive);
            this.gTopFive.Location = new System.Drawing.Point(13, 196);
            this.gTopFive.Name = "gTopFive";
            this.gTopFive.Size = new System.Drawing.Size(508, 164);
            this.gTopFive.TabIndex = 5;
            this.gTopFive.TabStop = false;
            this.gTopFive.Text = "TOP FIVE";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(17, 20);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(121, 20);
            this.lblDetalle.TabIndex = 201;
            this.lblDetalle.Text = "Acá descripción";
            this.lblDetalle.Visible = false;
            // 
            // dgTopFive
            // 
            this.dgTopFive.AllowUserToAddRows = false;
            this.dgTopFive.AllowUserToDeleteRows = false;
            this.dgTopFive.AllowUserToResizeColumns = false;
            this.dgTopFive.AllowUserToResizeRows = false;
            this.dgTopFive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTopFive.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgTopFive.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgTopFive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTopFive.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgTopFive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTopFive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTopFive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTopFive.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgTopFive.Location = new System.Drawing.Point(6, 49);
            this.dgTopFive.MinimumSize = new System.Drawing.Size(496, 102);
            this.dgTopFive.Name = "dgTopFive";
            this.dgTopFive.ReadOnly = true;
            this.dgTopFive.RowHeadersVisible = false;
            this.dgTopFive.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgTopFive.ShowCellErrors = false;
            this.dgTopFive.ShowCellToolTips = false;
            this.dgTopFive.ShowEditingIcon = false;
            this.dgTopFive.ShowRowErrors = false;
            this.dgTopFive.Size = new System.Drawing.Size(496, 102);
            this.dgTopFive.TabIndex = 200;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 368);
            this.Controls.Add(this.gTopFive);
            this.Controls.Add(this.lstListado);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.gFiltros);
            this.MaximizeBox = false;
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadístico";
            this.gFiltros.ResumeLayout(false);
            this.gFiltros.PerformLayout();
            this.gTopFive.ResumeLayout(false);
            this.gTopFive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTopFive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gFiltros;
        private System.Windows.Forms.ComboBox lstVisibilidadORubro;
        private System.Windows.Forms.Label lblVisibilidadORubro;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox lstTrimestre;
        private System.Windows.Forms.Label TrimestreLabel;
        private System.Windows.Forms.TextBox tAnio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.ComboBox lstListado;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.GroupBox gTopFive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatosObligatorios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox lstMes;
        private System.Windows.Forms.DataGridView dgTopFive;
        private System.Windows.Forms.Label lblDetalle;
    }
}