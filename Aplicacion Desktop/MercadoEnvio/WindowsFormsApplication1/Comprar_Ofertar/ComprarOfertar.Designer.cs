namespace LOS_INSISTENTES.ComprarOfertar
{
    partial class ComprarOfertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprarOfertar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstRubros = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tDescripción = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.dgComprarOfertar = new System.Windows.Forms.DataGridView();
            this.grpPublicaciones = new System.Windows.Forms.GroupBox();
            this.btnUltimaPagina = new System.Windows.Forms.Button();
            this.btnPrimeraPagina = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgComprarOfertar)).BeginInit();
            this.grpPublicaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstRubros);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.tDescripción);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar:";
            // 
            // lstRubros
            // 
            this.lstRubros.FormattingEnabled = true;
            this.lstRubros.Location = new System.Drawing.Point(118, 19);
            this.lstRubros.Name = "lstRubros";
            this.lstRubros.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstRubros.Size = new System.Drawing.Size(280, 69);
            this.lstRubros.TabIndex = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(690, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 50);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(578, 65);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tDescripción
            // 
            this.tDescripción.Location = new System.Drawing.Point(407, 40);
            this.tDescripción.Name = "tDescripción";
            this.tDescripción.Size = new System.Drawing.Size(246, 20);
            this.tDescripción.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uno o más rubros:";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(429, 375);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(85, 60);
            this.btnSiguiente.TabIndex = 17;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(325, 376);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(85, 60);
            this.btnAnterior.TabIndex = 16;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // dgComprarOfertar
            // 
            this.dgComprarOfertar.AllowUserToAddRows = false;
            this.dgComprarOfertar.AllowUserToDeleteRows = false;
            this.dgComprarOfertar.AllowUserToOrderColumns = true;
            this.dgComprarOfertar.AllowUserToResizeColumns = false;
            this.dgComprarOfertar.AllowUserToResizeRows = false;
            this.dgComprarOfertar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgComprarOfertar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgComprarOfertar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgComprarOfertar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgComprarOfertar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgComprarOfertar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgComprarOfertar.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgComprarOfertar.Location = new System.Drawing.Point(10, 25);
            this.dgComprarOfertar.Name = "dgComprarOfertar";
            this.dgComprarOfertar.ReadOnly = true;
            this.dgComprarOfertar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgComprarOfertar.RowHeadersVisible = false;
            this.dgComprarOfertar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgComprarOfertar.Size = new System.Drawing.Size(784, 350);
            this.dgComprarOfertar.TabIndex = 5;
            this.dgComprarOfertar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgComprarOfertar_CellContentClick);
            // 
            // grpPublicaciones
            // 
            this.grpPublicaciones.Controls.Add(this.btnUltimaPagina);
            this.grpPublicaciones.Controls.Add(this.btnPrimeraPagina);
            this.grpPublicaciones.Controls.Add(this.dgComprarOfertar);
            this.grpPublicaciones.Controls.Add(this.btnSiguiente);
            this.grpPublicaciones.Controls.Add(this.btnAnterior);
            this.grpPublicaciones.Location = new System.Drawing.Point(12, 105);
            this.grpPublicaciones.Name = "grpPublicaciones";
            this.grpPublicaciones.Size = new System.Drawing.Size(814, 441);
            this.grpPublicaciones.TabIndex = 18;
            this.grpPublicaciones.TabStop = false;
            this.grpPublicaciones.Text = "Posibles compras y subastas";
            // 
            // btnUltimaPagina
            // 
            this.btnUltimaPagina.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimaPagina.Image")));
            this.btnUltimaPagina.Location = new System.Drawing.Point(538, 376);
            this.btnUltimaPagina.Name = "btnUltimaPagina";
            this.btnUltimaPagina.Size = new System.Drawing.Size(85, 60);
            this.btnUltimaPagina.TabIndex = 18;
            this.btnUltimaPagina.UseVisualStyleBackColor = true;
            this.btnUltimaPagina.Click += new System.EventHandler(this.btnUltimaPagina_Click);
            // 
            // btnPrimeraPagina
            // 
            this.btnPrimeraPagina.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimeraPagina.Image")));
            this.btnPrimeraPagina.Location = new System.Drawing.Point(221, 376);
            this.btnPrimeraPagina.Name = "btnPrimeraPagina";
            this.btnPrimeraPagina.Size = new System.Drawing.Size(85, 60);
            this.btnPrimeraPagina.TabIndex = 15;
            this.btnPrimeraPagina.UseVisualStyleBackColor = true;
            this.btnPrimeraPagina.Click += new System.EventHandler(this.btnPrimeraPagina_Click);
            // 
            // ComprarOfertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPublicaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ComprarOfertar";
            this.Text = "Comprar/Ofertar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgComprarOfertar)).EndInit();
            this.grpPublicaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tDescripción;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lstRubros;
        private System.Windows.Forms.DataGridView dgComprarOfertar;
        private System.Windows.Forms.GroupBox grpPublicaciones;
        private System.Windows.Forms.Button btnUltimaPagina;
        private System.Windows.Forms.Button btnPrimeraPagina;
    }
}