namespace LOS_INSISTENTES.Generar_Publicación
{
    partial class DetallePublicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallePublicacion));
            this.btnAnterior = new System.Windows.Forms.Button();
            this.gPublicacion = new System.Windows.Forms.GroupBox();
            this.montoMinimo = new System.Windows.Forms.TextBox();
            this.lblMontoMinimo = new System.Windows.Forms.Label();
            this.dtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstVisibilidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRubro = new System.Windows.Forms.ComboBox();
            this.lblVisibilidadORubro = new System.Windows.Forms.Label();
            this.chkEnvios = new System.Windows.Forms.CheckBox();
            this.tPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tStock = new System.Windows.Forms.TextBox();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.gPublicacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(13, 299);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 62);
            this.btnAnterior.TabIndex = 12;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // gPublicacion
            // 
            this.gPublicacion.Controls.Add(this.montoMinimo);
            this.gPublicacion.Controls.Add(this.lblMontoMinimo);
            this.gPublicacion.Controls.Add(this.dtFechaVencimiento);
            this.gPublicacion.Controls.Add(this.lblFechaDesde);
            this.gPublicacion.Controls.Add(this.lstTipo);
            this.gPublicacion.Controls.Add(this.label4);
            this.gPublicacion.Controls.Add(this.lstVisibilidad);
            this.gPublicacion.Controls.Add(this.label3);
            this.gPublicacion.Controls.Add(this.lstEstado);
            this.gPublicacion.Controls.Add(this.label1);
            this.gPublicacion.Controls.Add(this.lstRubro);
            this.gPublicacion.Controls.Add(this.lblVisibilidadORubro);
            this.gPublicacion.Controls.Add(this.chkEnvios);
            this.gPublicacion.Controls.Add(this.tPrecio);
            this.gPublicacion.Controls.Add(this.lblPrecio);
            this.gPublicacion.Controls.Add(this.tStock);
            this.gPublicacion.Controls.Add(this.tDescripcion);
            this.gPublicacion.Controls.Add(this.lblStock);
            this.gPublicacion.Controls.Add(this.lblDescripcion);
            this.gPublicacion.Location = new System.Drawing.Point(15, 12);
            this.gPublicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gPublicacion.Name = "gPublicacion";
            this.gPublicacion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gPublicacion.Size = new System.Drawing.Size(493, 282);
            this.gPublicacion.TabIndex = 6;
            this.gPublicacion.TabStop = false;
            this.gPublicacion.Text = "Publicación";
            // 
            // montoMinimo
            // 
            this.montoMinimo.AllowDrop = true;
            this.montoMinimo.Location = new System.Drawing.Point(396, 235);
            this.montoMinimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.montoMinimo.Name = "montoMinimo";
            this.montoMinimo.Size = new System.Drawing.Size(83, 22);
            this.montoMinimo.TabIndex = 10;
            this.montoMinimo.Visible = false;
            this.montoMinimo.TextChanged += new System.EventHandler(this.montoMinimo_TextChanged);
            this.montoMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montoMinimo_KeyPress);
            // 
            // lblMontoMinimo
            // 
            this.lblMontoMinimo.AutoSize = true;
            this.lblMontoMinimo.Location = new System.Drawing.Point(319, 228);
            this.lblMontoMinimo.Name = "lblMontoMinimo";
            this.lblMontoMinimo.Size = new System.Drawing.Size(78, 34);
            this.lblMontoMinimo.TabIndex = 36;
            this.lblMontoMinimo.Text = "Monto\r\nMinimo ($):";
            this.lblMontoMinimo.Visible = false;
            // 
            // dtFechaVencimiento
            // 
            this.dtFechaVencimiento.CustomFormat = "  dd/MM/yyyy";
            this.dtFechaVencimiento.Enabled = false;
            this.dtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaVencimiento.Location = new System.Drawing.Point(353, 96);
            this.dtFechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaVencimiento.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtFechaVencimiento.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.Size = new System.Drawing.Size(124, 22);
            this.dtFechaVencimiento.TabIndex = 5;
            this.dtFechaVencimiento.Value = new System.DateTime(2016, 6, 10, 0, 0, 0, 0);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(215, 100);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(130, 17);
            this.lblFechaDesde.TabIndex = 34;
            this.lblFechaDesde.Text = "Fecha vencimiento:";
            // 
            // lstTipo
            // 
            this.lstTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipo.Enabled = false;
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Location = new System.Drawing.Point(100, 228);
            this.lstTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(195, 24);
            this.lstTipo.TabIndex = 9;
            this.lstTipo.SelectedIndexChanged += new System.EventHandler(this.lstTipo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tipo:";
            // 
            // lstVisibilidad
            // 
            this.lstVisibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstVisibilidad.Enabled = false;
            this.lstVisibilidad.FormattingEnabled = true;
            this.lstVisibilidad.Location = new System.Drawing.Point(100, 162);
            this.lstVisibilidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstVisibilidad.Name = "lstVisibilidad";
            this.lstVisibilidad.Size = new System.Drawing.Size(377, 24);
            this.lstVisibilidad.TabIndex = 7;
            this.lstVisibilidad.SelectedIndexChanged += new System.EventHandler(this.lstVisibilidad_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Visibilidad:";
            // 
            // lstEstado
            // 
            this.lstEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEstado.Enabled = false;
            this.lstEstado.FormattingEnabled = true;
            this.lstEstado.Location = new System.Drawing.Point(100, 196);
            this.lstEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstEstado.Name = "lstEstado";
            this.lstEstado.Size = new System.Drawing.Size(377, 24);
            this.lstEstado.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Estado:";
            // 
            // lstRubro
            // 
            this.lstRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstRubro.Enabled = false;
            this.lstRubro.FormattingEnabled = true;
            this.lstRubro.Location = new System.Drawing.Point(100, 129);
            this.lstRubro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstRubro.Name = "lstRubro";
            this.lstRubro.Size = new System.Drawing.Size(377, 24);
            this.lstRubro.TabIndex = 6;
            // 
            // lblVisibilidadORubro
            // 
            this.lblVisibilidadORubro.AutoSize = true;
            this.lblVisibilidadORubro.Location = new System.Drawing.Point(8, 133);
            this.lblVisibilidadORubro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisibilidadORubro.Name = "lblVisibilidadORubro";
            this.lblVisibilidadORubro.Size = new System.Drawing.Size(47, 17);
            this.lblVisibilidadORubro.TabIndex = 25;
            this.lblVisibilidadORubro.Text = "Rubro";
            // 
            // chkEnvios
            // 
            this.chkEnvios.AutoSize = true;
            this.chkEnvios.Enabled = false;
            this.chkEnvios.Location = new System.Drawing.Point(12, 96);
            this.chkEnvios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEnvios.Name = "chkEnvios";
            this.chkEnvios.Size = new System.Drawing.Size(123, 21);
            this.chkEnvios.TabIndex = 4;
            this.chkEnvios.Text = "Permite envíos";
            this.chkEnvios.UseVisualStyleBackColor = true;
            // 
            // tPrecio
            // 
            this.tPrecio.Location = new System.Drawing.Point(391, 235);
            this.tPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPrecio.Name = "tPrecio";
            this.tPrecio.Size = new System.Drawing.Size(83, 22);
            this.tPrecio.TabIndex = 3;
            this.tPrecio.Visible = false;
            this.tPrecio.TextChanged += new System.EventHandler(this.tPrecio_TextChanged);
            this.tPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPrecio_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(323, 238);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(74, 17);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio ($):";
            this.lblPrecio.Visible = false;
            // 
            // tStock
            // 
            this.tStock.Location = new System.Drawing.Point(100, 60);
            this.tStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tStock.Name = "tStock";
            this.tStock.Size = new System.Drawing.Size(83, 22);
            this.tStock.TabIndex = 2;
            this.tStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tStock_KeyPress);
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(100, 30);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(379, 22);
            this.tDescripcion.TabIndex = 1;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(8, 64);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 17);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "Stock:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(8, 33);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btnAccion
            // 
            this.btnAccion.Image = ((System.Drawing.Image)(resources.GetObject("btnAccion.Image")));
            this.btnAccion.Location = new System.Drawing.Point(408, 302);
            this.btnAccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(100, 59);
            this.btnAccion.TabIndex = 11;
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // DetallePublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 372);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.gPublicacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DetallePublicacion";
            this.Text = "Publicación";
            this.gPublicacion.ResumeLayout(false);
            this.gPublicacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.GroupBox gPublicacion;
        private System.Windows.Forms.TextBox tStock;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.CheckBox chkEnvios;
        private System.Windows.Forms.ComboBox lstTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lstVisibilidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lstEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstRubro;
        private System.Windows.Forms.Label lblVisibilidadORubro;
        private System.Windows.Forms.DateTimePicker dtFechaVencimiento;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.TextBox montoMinimo;
        private System.Windows.Forms.Label lblMontoMinimo;
        private System.Windows.Forms.TextBox tPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}