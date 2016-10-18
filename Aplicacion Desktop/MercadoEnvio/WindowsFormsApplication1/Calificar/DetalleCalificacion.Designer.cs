namespace LOS_INSISTENTES.Calificar
{
    partial class DetalleCalificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleCalificacion));
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloCalificar = new System.Windows.Forms.Label();
            this.cmbPuntaje = new System.Windows.Forms.ComboBox();
            this.tDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnAccion = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(16, 52);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(46, 13);
            this.lblPuntaje.TabIndex = 4;
            this.lblPuntaje.Text = "Puntaje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripción:";
            // 
            // lblTituloCalificar
            // 
            this.lblTituloCalificar.AutoSize = true;
            this.lblTituloCalificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCalificar.Location = new System.Drawing.Point(19, 13);
            this.lblTituloCalificar.Name = "lblTituloCalificar";
            this.lblTituloCalificar.Size = new System.Drawing.Size(122, 20);
            this.lblTituloCalificar.TabIndex = 7;
            this.lblTituloCalificar.Text = "Descricipon acá";
            // 
            // cmbPuntaje
            // 
            this.cmbPuntaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuntaje.FormattingEnabled = true;
            this.cmbPuntaje.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbPuntaje.Location = new System.Drawing.Point(96, 48);
            this.cmbPuntaje.Name = "cmbPuntaje";
            this.cmbPuntaje.Size = new System.Drawing.Size(254, 21);
            this.cmbPuntaje.TabIndex = 8;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(96, 87);
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(254, 54);
            this.tDescripcion.TabIndex = 9;
            this.tDescripcion.Text = "";
            // 
            // btnAccion
            // 
            this.btnAccion.Image = ((System.Drawing.Image)(resources.GetObject("btnAccion.Image")));
            this.btnAccion.Location = new System.Drawing.Point(275, 172);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(75, 48);
            this.btnAccion.TabIndex = 12;
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(9, 170);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 50);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // DetalleCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 232);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.cmbPuntaje);
            this.Controls.Add(this.lblTituloCalificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuntaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DetalleCalificacion";
            this.Text = "Calificar compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloCalificar;
        private System.Windows.Forms.ComboBox cmbPuntaje;
        private System.Windows.Forms.RichTextBox tDescripcion;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Button btnAnterior;
    }
}