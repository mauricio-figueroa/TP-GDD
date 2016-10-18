namespace LOS_INSISTENTES.Loggin
{
    partial class SeleccionFuncionalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionFuncionalidades));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.cbFuncionalidades = new System.Windows.Forms.ComboBox();
            this.grpFuncionalidades = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.lblElegido = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpFuncionalidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFuncionalidades
            // 
            this.cbFuncionalidades.FormattingEnabled = true;
            this.cbFuncionalidades.Location = new System.Drawing.Point(404, 18);
            this.cbFuncionalidades.Name = "cbFuncionalidades";
            this.cbFuncionalidades.Size = new System.Drawing.Size(221, 21);
            this.cbFuncionalidades.TabIndex = 0;
            this.cbFuncionalidades.SelectedIndexChanged += new System.EventHandler(this.cbFuncionalidades_SelectedIndexChanged);
            // 
            // grpFuncionalidades
            // 
            this.grpFuncionalidades.Controls.Add(this.lblTitulo);
            this.grpFuncionalidades.Controls.Add(this.cbFuncionalidades);
            this.grpFuncionalidades.Location = new System.Drawing.Point(10, 7);
            this.grpFuncionalidades.Name = "grpFuncionalidades";
            this.grpFuncionalidades.Size = new System.Drawing.Size(678, 51);
            this.grpFuncionalidades.TabIndex = 4;
            this.grpFuncionalidades.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(230, 20);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Bienvenido a MercadoEnvio";
            // 
            // panelContenido
            // 
            this.panelContenido.Location = new System.Drawing.Point(15, 102);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(675, 208);
            this.panelContenido.TabIndex = 5;
            // 
            // lblElegido
            // 
            this.lblElegido.AutoSize = true;
            this.lblElegido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegido.Location = new System.Drawing.Point(20, 67);
            this.lblElegido.Name = "lblElegido";
            this.lblElegido.Size = new System.Drawing.Size(257, 31);
            this.lblElegido.TabIndex = 6;
            this.lblElegido.Text = "La opción que elija";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(586, 323);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 28);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // SeleccionFuncionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(700, 355);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblElegido);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.grpFuncionalidades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SeleccionFuncionalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de funcionalidades";
            this.Load += new System.EventHandler(this.SeleccionFuncionalidades_Load_1);
            this.grpFuncionalidades.ResumeLayout(false);
            this.grpFuncionalidades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ComboBox cbFuncionalidades;
        private System.Windows.Forms.GroupBox grpFuncionalidades;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lblElegido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
    }
}