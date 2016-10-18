namespace LOS_INSISTENTES.ABMUsuario
{
    partial class BajaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chMail = new System.Windows.Forms.CheckBox();
            this.cbTipoDeDocumento = new System.Windows.Forms.ComboBox();
            this.tMail = new System.Windows.Forms.TextBox();
            this.chNumeroDeDocumento = new System.Windows.Forms.CheckBox();
            this.tNumeroDeDocumento = new System.Windows.Forms.TextBox();
            this.chTipoDeDocumento = new System.Windows.Forms.CheckBox();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.chApellido = new System.Windows.Forms.CheckBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.chNombre = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.chMail);
            this.groupBox1.Controls.Add(this.cbTipoDeDocumento);
            this.groupBox1.Controls.Add(this.tMail);
            this.groupBox1.Controls.Add(this.chNumeroDeDocumento);
            this.groupBox1.Controls.Add(this.tNumeroDeDocumento);
            this.groupBox1.Controls.Add(this.chTipoDeDocumento);
            this.groupBox1.Controls.Add(this.tApellido);
            this.groupBox1.Controls.Add(this.chApellido);
            this.groupBox1.Controls.Add(this.tNombre);
            this.groupBox1.Controls.Add(this.chNombre);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el/los campos a filtrar:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(467, 186);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(386, 186);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // chMail
            // 
            this.chMail.AutoSize = true;
            this.chMail.Location = new System.Drawing.Point(21, 163);
            this.chMail.Name = "chMail";
            this.chMail.Size = new System.Drawing.Size(45, 17);
            this.chMail.TabIndex = 40;
            this.chMail.Text = "Mail";
            this.chMail.UseVisualStyleBackColor = true;
            this.chMail.CheckedChanged += new System.EventHandler(this.chMail_CheckedChanged);
            // 
            // cbTipoDeDocumento
            // 
            this.cbTipoDeDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDeDocumento.FormattingEnabled = true;
            this.cbTipoDeDocumento.Items.AddRange(new object[] {
            "CI",
            "DNI",
            "LC",
            "LE",
            "DU"});
            this.cbTipoDeDocumento.Location = new System.Drawing.Point(37, 136);
            this.cbTipoDeDocumento.Name = "cbTipoDeDocumento";
            this.cbTipoDeDocumento.Size = new System.Drawing.Size(237, 21);
            this.cbTipoDeDocumento.TabIndex = 39;
            // 
            // tMail
            // 
            this.tMail.Location = new System.Drawing.Point(37, 186);
            this.tMail.Name = "tMail";
            this.tMail.Size = new System.Drawing.Size(237, 20);
            this.tMail.TabIndex = 10;
            // 
            // chNumeroDeDocumento
            // 
            this.chNumeroDeDocumento.AutoSize = true;
            this.chNumeroDeDocumento.Location = new System.Drawing.Point(305, 113);
            this.chNumeroDeDocumento.Name = "chNumeroDeDocumento";
            this.chNumeroDeDocumento.Size = new System.Drawing.Size(136, 17);
            this.chNumeroDeDocumento.TabIndex = 9;
            this.chNumeroDeDocumento.Text = "Número de Documento";
            this.chNumeroDeDocumento.UseVisualStyleBackColor = true;
            this.chNumeroDeDocumento.CheckedChanged += new System.EventHandler(this.chNumeroDeDocumento_CheckedChanged);
            // 
            // tNumeroDeDocumento
            // 
            this.tNumeroDeDocumento.Location = new System.Drawing.Point(305, 137);
            this.tNumeroDeDocumento.MaxLength = 8;
            this.tNumeroDeDocumento.Name = "tNumeroDeDocumento";
            this.tNumeroDeDocumento.Size = new System.Drawing.Size(237, 20);
            this.tNumeroDeDocumento.TabIndex = 8;
            // 
            // chTipoDeDocumento
            // 
            this.chTipoDeDocumento.AutoSize = true;
            this.chTipoDeDocumento.Location = new System.Drawing.Point(16, 113);
            this.chTipoDeDocumento.Name = "chTipoDeDocumento";
            this.chTipoDeDocumento.Size = new System.Drawing.Size(120, 17);
            this.chTipoDeDocumento.TabIndex = 7;
            this.chTipoDeDocumento.Text = "Tipo de Documento";
            this.chTipoDeDocumento.UseVisualStyleBackColor = true;
            this.chTipoDeDocumento.CheckedChanged += new System.EventHandler(this.chTipoDeDocumento_CheckedChanged);
            // 
            // tApellido
            // 
            this.tApellido.Location = new System.Drawing.Point(305, 86);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(237, 20);
            this.tApellido.TabIndex = 6;
            // 
            // chApellido
            // 
            this.chApellido.AutoSize = true;
            this.chApellido.Location = new System.Drawing.Point(305, 63);
            this.chApellido.Name = "chApellido";
            this.chApellido.Size = new System.Drawing.Size(63, 17);
            this.chApellido.TabIndex = 5;
            this.chApellido.Text = "Apellido";
            this.chApellido.UseVisualStyleBackColor = true;
            this.chApellido.CheckedChanged += new System.EventHandler(this.chApellido_CheckedChanged);
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(37, 87);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(237, 20);
            this.tNombre.TabIndex = 4;
            // 
            // chNombre
            // 
            this.chNombre.AutoSize = true;
            this.chNombre.Location = new System.Drawing.Point(21, 63);
            this.chNombre.Name = "chNombre";
            this.chNombre.Size = new System.Drawing.Size(63, 17);
            this.chNombre.TabIndex = 3;
            this.chNombre.Text = "Nombre";
            this.chNombre.UseVisualStyleBackColor = true;
            this.chNombre.CheckedChanged += new System.EventHandler(this.cbNombre_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(305, 186);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "(Puede seleccionar simultaneamente)";
            // 
            // dgCliente
            // 
            this.dgCliente.AllowUserToAddRows = false;
            this.dgCliente.AllowUserToDeleteRows = false;
            this.dgCliente.AllowUserToOrderColumns = true;
            this.dgCliente.AllowUserToResizeColumns = false;
            this.dgCliente.AllowUserToResizeRows = false;
            this.dgCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCliente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCliente.Location = new System.Drawing.Point(15, 240);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.ReadOnly = true;
            this.dgCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgCliente.RowHeadersVisible = false;
            this.dgCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgCliente.Size = new System.Drawing.Size(577, 226);
            this.dgCliente.TabIndex = 11;
            this.dgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellContentClick);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(427, 472);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 50);
            this.btnAnterior.TabIndex = 10;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(508, 472);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 50);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
            // 
            // btnVolver
            // 
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(12, 472);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 50);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // BajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 526);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgCliente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BajaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de Cliente";
            this.Load += new System.EventHandler(this._3ClienteBaja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.CheckBox chApellido;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.CheckBox chNombre;
        private System.Windows.Forms.TextBox tMail;
        private System.Windows.Forms.CheckBox chNumeroDeDocumento;
        private System.Windows.Forms.TextBox tNumeroDeDocumento;
        private System.Windows.Forms.CheckBox chTipoDeDocumento;
        private System.Windows.Forms.CheckBox chMail;
        private System.Windows.Forms.ComboBox cbTipoDeDocumento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVolver;
    }
}