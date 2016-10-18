namespace LOS_INSISTENTES.ABMUsuario
{
    partial class BajaEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaEmpresa));
            this.dgEmpresa = new System.Windows.Forms.DataGridView();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.tCUIT = new System.Windows.Forms.TextBox();
            this.chCUIT = new System.Windows.Forms.CheckBox();
            this.tRazonSocial = new System.Windows.Forms.TextBox();
            this.chRazonSocial = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chMail = new System.Windows.Forms.CheckBox();
            this.tMail = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpresa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgEmpresa
            // 
            this.dgEmpresa.AllowUserToAddRows = false;
            this.dgEmpresa.AllowUserToDeleteRows = false;
            this.dgEmpresa.AllowUserToOrderColumns = true;
            this.dgEmpresa.AllowUserToResizeColumns = false;
            this.dgEmpresa.AllowUserToResizeRows = false;
            this.dgEmpresa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgEmpresa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEmpresa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEmpresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgEmpresa.Location = new System.Drawing.Point(23, 290);
            this.dgEmpresa.Name = "dgEmpresa";
            this.dgEmpresa.ReadOnly = true;
            this.dgEmpresa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgEmpresa.RowHeadersVisible = false;
            this.dgEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgEmpresa.Size = new System.Drawing.Size(689, 249);
            this.dgEmpresa.TabIndex = 15;
            this.dgEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpresa_CellContentClick);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(637, 545);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 50);
            this.btnSiguiente.TabIndex = 13;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(431, 232);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(533, 545);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 50);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // tCUIT
            // 
            this.tCUIT.Location = new System.Drawing.Point(37, 152);
            this.tCUIT.MaxLength = 14;
            this.tCUIT.Name = "tCUIT";
            this.tCUIT.Size = new System.Drawing.Size(469, 20);
            this.tCUIT.TabIndex = 6;
            // 
            // chCUIT
            // 
            this.chCUIT.AutoSize = true;
            this.chCUIT.Location = new System.Drawing.Point(21, 128);
            this.chCUIT.Name = "chCUIT";
            this.chCUIT.Size = new System.Drawing.Size(51, 17);
            this.chCUIT.TabIndex = 5;
            this.chCUIT.Text = "CUIT";
            this.chCUIT.UseVisualStyleBackColor = true;
            this.chCUIT.CheckedChanged += new System.EventHandler(this.chCUIT_CheckedChanged);
            // 
            // tRazonSocial
            // 
            this.tRazonSocial.Location = new System.Drawing.Point(37, 87);
            this.tRazonSocial.Name = "tRazonSocial";
            this.tRazonSocial.Size = new System.Drawing.Size(469, 20);
            this.tRazonSocial.TabIndex = 4;
            // 
            // chRazonSocial
            // 
            this.chRazonSocial.AutoSize = true;
            this.chRazonSocial.Location = new System.Drawing.Point(21, 63);
            this.chRazonSocial.Name = "chRazonSocial";
            this.chRazonSocial.Size = new System.Drawing.Size(89, 17);
            this.chRazonSocial.TabIndex = 3;
            this.chRazonSocial.Text = "Razón Social";
            this.chRazonSocial.UseVisualStyleBackColor = true;
            this.chRazonSocial.CheckedChanged += new System.EventHandler(this.chRazonSocial_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(325, 233);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "(Puede seleccionar simultaneamente)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.chMail);
            this.groupBox1.Controls.Add(this.tMail);
            this.groupBox1.Controls.Add(this.tCUIT);
            this.groupBox1.Controls.Add(this.chCUIT);
            this.groupBox1.Controls.Add(this.tRazonSocial);
            this.groupBox1.Controls.Add(this.chRazonSocial);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 272);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el/los campos a filtrar:";
            // 
            // chMail
            // 
            this.chMail.AutoSize = true;
            this.chMail.Location = new System.Drawing.Point(22, 183);
            this.chMail.Name = "chMail";
            this.chMail.Size = new System.Drawing.Size(45, 17);
            this.chMail.TabIndex = 40;
            this.chMail.Text = "Mail";
            this.chMail.UseVisualStyleBackColor = true;
            this.chMail.CheckedChanged += new System.EventHandler(this.chMail_CheckedChanged);
            // 
            // tMail
            // 
            this.tMail.Location = new System.Drawing.Point(38, 206);
            this.tMail.Name = "tMail";
            this.tMail.Size = new System.Drawing.Size(469, 20);
            this.tMail.TabIndex = 10;
            // 
            // btnVolver
            // 
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(23, 545);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 50);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // BajaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 602);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgEmpresa);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BajaEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja/Modificación de empresa";
            this.Load += new System.EventHandler(this.BajaEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpresa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmpresa;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.TextBox tCUIT;
        private System.Windows.Forms.CheckBox chCUIT;
        private System.Windows.Forms.TextBox tRazonSocial;
        private System.Windows.Forms.CheckBox chRazonSocial;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chMail;
        private System.Windows.Forms.TextBox tMail;
        private System.Windows.Forms.Button btnVolver;
    }
}