namespace LOS_INSISTENTES.Generar_Publicación
{
    partial class GenerarPublicacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarPublicacion));
            this.grpPublicaciones = new System.Windows.Forms.GroupBox();
            this.dgPublicaciones = new System.Windows.Forms.DataGridView();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblPGratuitas = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpPublicaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPublicaciones)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPublicaciones
            // 
            this.grpPublicaciones.Controls.Add(this.dgPublicaciones);
            this.grpPublicaciones.Controls.Add(this.btnSiguiente);
            this.grpPublicaciones.Controls.Add(this.btnAnterior);
            this.grpPublicaciones.Location = new System.Drawing.Point(16, 97);
            this.grpPublicaciones.Name = "grpPublicaciones";
            this.grpPublicaciones.Size = new System.Drawing.Size(900, 428);
            this.grpPublicaciones.TabIndex = 17;
            this.grpPublicaciones.TabStop = false;
            this.grpPublicaciones.Text = "Tus publicaciones";
            // 
            // dgPublicaciones
            // 
            this.dgPublicaciones.AllowUserToAddRows = false;
            this.dgPublicaciones.AllowUserToDeleteRows = false;
            this.dgPublicaciones.AllowUserToOrderColumns = true;
            this.dgPublicaciones.AllowUserToResizeColumns = false;
            this.dgPublicaciones.AllowUserToResizeRows = false;
            this.dgPublicaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgPublicaciones.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgPublicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPublicaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPublicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPublicaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPublicaciones.Location = new System.Drawing.Point(10, 25);
            this.dgPublicaciones.Name = "dgPublicaciones";
            this.dgPublicaciones.ReadOnly = true;
            this.dgPublicaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgPublicaciones.RowHeadersVisible = false;
            this.dgPublicaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgPublicaciones.Size = new System.Drawing.Size(884, 330);
            this.dgPublicaciones.TabIndex = 5;
            this.dgPublicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHistorial_CellContentClick);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(477, 361);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 50);
            this.btnSiguiente.TabIndex = 12;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(379, 361);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 50);
            this.btnAnterior.TabIndex = 13;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.lblPGratuitas);
            this.grpFiltros.Controls.Add(this.btnAgregar);
            this.grpFiltros.Location = new System.Drawing.Point(14, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(896, 79);
            this.grpFiltros.TabIndex = 16;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Publicaciones";
            // 
            // lblPGratuitas
            // 
            this.lblPGratuitas.AutoSize = true;
            this.lblPGratuitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPGratuitas.ForeColor = System.Drawing.Color.Black;
            this.lblPGratuitas.Location = new System.Drawing.Point(300, 54);
            this.lblPGratuitas.Name = "lblPGratuitas";
            this.lblPGratuitas.Size = new System.Drawing.Size(316, 13);
            this.lblPGratuitas.TabIndex = 19;
            this.lblPGratuitas.Text = "Por ser usuario nuevo, tiene una publicación sin costo";
            this.lblPGratuitas.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(878, 23);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Nueva publicación";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // GenerarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 537);
            this.Controls.Add(this.grpPublicaciones);
            this.Controls.Add(this.grpFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GenerarPublicacion";
            this.Text = "Generar Publicación";
            this.grpPublicaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPublicaciones)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPublicaciones;
        private System.Windows.Forms.DataGridView dgPublicaciones;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPGratuitas;

    }
}