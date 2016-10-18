namespace LOS_INSISTENTES.Comprar_Ofertar
{
    partial class DetalleCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleCompra));
            this.tCantidad = new System.Windows.Forms.TextBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.chkEnvio = new System.Windows.Forms.CheckBox();
            this.lblFinaliza = new System.Windows.Forms.Label();
            this.lblSubastaMinimo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tCantidad
            // 
            this.tCantidad.Location = new System.Drawing.Point(70, 33);
            this.tCantidad.Name = "tCantidad";
            this.tCantidad.Size = new System.Drawing.Size(47, 20);
            this.tCantidad.TabIndex = 0;
            this.tCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tCantidad_KeyPress);
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(12, 9);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(61, 13);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "Compra de:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(276, 89);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 48);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(12, 87);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 50);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(123, 36);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(19, 13);
            this.lblStock.TabIndex = 15;
            this.lblStock.Text = "de";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 36);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // chkEnvio
            // 
            this.chkEnvio.AutoSize = true;
            this.chkEnvio.Location = new System.Drawing.Point(15, 61);
            this.chkEnvio.Name = "chkEnvio";
            this.chkEnvio.Size = new System.Drawing.Size(55, 17);
            this.chkEnvio.TabIndex = 17;
            this.chkEnvio.Text = "Envío";
            this.chkEnvio.UseVisualStyleBackColor = true;
            this.chkEnvio.Click += new System.EventHandler(this.chkEnvio_Click);
            // 
            // lblFinaliza
            // 
            this.lblFinaliza.AutoSize = true;
            this.lblFinaliza.Location = new System.Drawing.Point(123, 62);
            this.lblFinaliza.Name = "lblFinaliza";
            this.lblFinaliza.Size = new System.Drawing.Size(65, 13);
            this.lblFinaliza.TabIndex = 18;
            this.lblFinaliza.Text = "Finaliza el ...";
            // 
            // lblSubastaMinimo
            // 
            this.lblSubastaMinimo.AutoSize = true;
            this.lblSubastaMinimo.Location = new System.Drawing.Point(108, 100);
            this.lblSubastaMinimo.Name = "lblSubastaMinimo";
            this.lblSubastaMinimo.Size = new System.Drawing.Size(106, 13);
            this.lblSubastaMinimo.TabIndex = 19;
            this.lblSubastaMinimo.Text = "Esta subasta tiene ...";
            // 
            // DetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 146);
            this.Controls.Add(this.lblSubastaMinimo);
            this.Controls.Add(this.lblFinaliza);
            this.Controls.Add(this.chkEnvio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.tCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "DetalleCompra";
            this.Text = "Comprar / Ofertar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tCantidad;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.CheckBox chkEnvio;
        private System.Windows.Forms.Label lblFinaliza;
        private System.Windows.Forms.Label lblSubastaMinimo;
    }
}