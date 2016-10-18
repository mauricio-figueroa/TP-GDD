namespace LOS_INSISTENTES.Facturas
{
    partial class DetalleFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleFactura));
            this.gFactura = new System.Windows.Forms.GroupBox();
            this.tFormaPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.gVendedor = new System.Windows.Forms.GroupBox();
            this.tCUIT = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tItems = new System.Windows.Forms.RichTextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.grpPublicacion = new System.Windows.Forms.GroupBox();
            this.tPrecio = new System.Windows.Forms.TextBox();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecioPublicacion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.gFactura.SuspendLayout();
            this.gVendedor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpPublicacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gFactura
            // 
            this.gFactura.Controls.Add(this.tFormaPago);
            this.gFactura.Controls.Add(this.label1);
            this.gFactura.Controls.Add(this.tFecha);
            this.gFactura.Controls.Add(this.label6);
            this.gFactura.Controls.Add(this.tTotal);
            this.gFactura.Controls.Add(this.label4);
            this.gFactura.Controls.Add(this.tNumero);
            this.gFactura.Controls.Add(this.lblNumero);
            this.gFactura.Location = new System.Drawing.Point(17, 163);
            this.gFactura.Name = "gFactura";
            this.gFactura.Size = new System.Drawing.Size(412, 136);
            this.gFactura.TabIndex = 3;
            this.gFactura.TabStop = false;
            this.gFactura.Text = "Factura";
            // 
            // tFormaPago
            // 
            this.tFormaPago.Location = new System.Drawing.Point(75, 45);
            this.tFormaPago.Name = "tFormaPago";
            this.tFormaPago.ReadOnly = true;
            this.tFormaPago.Size = new System.Drawing.Size(331, 20);
            this.tFormaPago.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Forma Pago:";
            // 
            // tFecha
            // 
            this.tFecha.Location = new System.Drawing.Point(74, 102);
            this.tFecha.Name = "tFecha";
            this.tFecha.ReadOnly = true;
            this.tFecha.Size = new System.Drawing.Size(331, 20);
            this.tFecha.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha;";
            // 
            // tTotal
            // 
            this.tTotal.Location = new System.Drawing.Point(74, 75);
            this.tTotal.Name = "tTotal";
            this.tTotal.ReadOnly = true;
            this.tTotal.Size = new System.Drawing.Size(331, 20);
            this.tTotal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total:";
            // 
            // tNumero
            // 
            this.tNumero.Location = new System.Drawing.Point(75, 17);
            this.tNumero.Name = "tNumero";
            this.tNumero.ReadOnly = true;
            this.tNumero.Size = new System.Drawing.Size(331, 20);
            this.tNumero.TabIndex = 3;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 20);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Número:";
            // 
            // gVendedor
            // 
            this.gVendedor.Controls.Add(this.tCUIT);
            this.gVendedor.Controls.Add(this.tNombre);
            this.gVendedor.Controls.Add(this.lblCUIT);
            this.gVendedor.Controls.Add(this.lblNombre);
            this.gVendedor.Location = new System.Drawing.Point(17, 13);
            this.gVendedor.Name = "gVendedor";
            this.gVendedor.Size = new System.Drawing.Size(412, 70);
            this.gVendedor.TabIndex = 2;
            this.gVendedor.TabStop = false;
            this.gVendedor.Text = "Vendedor";
            // 
            // tCUIT
            // 
            this.tCUIT.Location = new System.Drawing.Point(75, 42);
            this.tCUIT.Name = "tCUIT";
            this.tCUIT.ReadOnly = true;
            this.tCUIT.Size = new System.Drawing.Size(331, 20);
            this.tCUIT.TabIndex = 3;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(75, 17);
            this.tNombre.Name = "tNombre";
            this.tNombre.ReadOnly = true;
            this.tNombre.Size = new System.Drawing.Size(331, 20);
            this.tNombre.TabIndex = 2;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(6, 45);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(35, 13);
            this.lblCUIT.TabIndex = 1;
            this.lblCUIT.Text = "CUIT:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tItems);
            this.groupBox2.Location = new System.Drawing.Point(17, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 131);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // tItems
            // 
            this.tItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tItems.Location = new System.Drawing.Point(9, 21);
            this.tItems.Name = "tItems";
            this.tItems.ReadOnly = true;
            this.tItems.Size = new System.Drawing.Size(397, 99);
            this.tItems.TabIndex = 1;
            this.tItems.Text = "";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(17, 443);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 50);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // grpPublicacion
            // 
            this.grpPublicacion.Controls.Add(this.tPrecio);
            this.grpPublicacion.Controls.Add(this.tDescripcion);
            this.grpPublicacion.Controls.Add(this.lblPrecioPublicacion);
            this.grpPublicacion.Controls.Add(this.lblDescripcion);
            this.grpPublicacion.Location = new System.Drawing.Point(17, 89);
            this.grpPublicacion.Name = "grpPublicacion";
            this.grpPublicacion.Size = new System.Drawing.Size(412, 70);
            this.grpPublicacion.TabIndex = 6;
            this.grpPublicacion.TabStop = false;
            this.grpPublicacion.Text = "Publicación:";
            // 
            // tPrecio
            // 
            this.tPrecio.Location = new System.Drawing.Point(75, 42);
            this.tPrecio.Name = "tPrecio";
            this.tPrecio.ReadOnly = true;
            this.tPrecio.Size = new System.Drawing.Size(331, 20);
            this.tPrecio.TabIndex = 3;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(75, 17);
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ReadOnly = true;
            this.tDescripcion.Size = new System.Drawing.Size(331, 20);
            this.tDescripcion.TabIndex = 2;
            // 
            // lblPrecioPublicacion
            // 
            this.lblPrecioPublicacion.AutoSize = true;
            this.lblPrecioPublicacion.Location = new System.Drawing.Point(6, 45);
            this.lblPrecioPublicacion.Name = "lblPrecioPublicacion";
            this.lblPrecioPublicacion.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioPublicacion.TabIndex = 1;
            this.lblPrecioPublicacion.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 20);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // DetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 499);
            this.Controls.Add(this.grpPublicacion);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gFactura);
            this.Controls.Add(this.gVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetalleFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleFactura";
            this.gFactura.ResumeLayout(false);
            this.gFactura.PerformLayout();
            this.gVendedor.ResumeLayout(false);
            this.gVendedor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grpPublicacion.ResumeLayout(false);
            this.grpPublicacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gFactura;
        private System.Windows.Forms.TextBox tFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.GroupBox gVendedor;
        private System.Windows.Forms.TextBox tCUIT;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tFormaPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox tItems;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.GroupBox grpPublicacion;
        private System.Windows.Forms.TextBox tPrecio;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label lblPrecioPublicacion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}