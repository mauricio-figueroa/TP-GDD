namespace LOS_INSISTENTES.ABM_Visibilidad
{
    partial class ABMVisibilidad
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
            this.grpABMRol = new System.Windows.Forms.GroupBox();
            this.deshabilitarVisibilidad = new System.Windows.Forms.Button();
            this.agergarVisibilidad = new System.Windows.Forms.Button();
            this.modificarVisibilidad = new System.Windows.Forms.Button();
            this.grpABMRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpABMRol
            // 
            this.grpABMRol.Controls.Add(this.deshabilitarVisibilidad);
            this.grpABMRol.Controls.Add(this.agergarVisibilidad);
            this.grpABMRol.Controls.Add(this.modificarVisibilidad);
            this.grpABMRol.Location = new System.Drawing.Point(13, 13);
            this.grpABMRol.Margin = new System.Windows.Forms.Padding(4);
            this.grpABMRol.Name = "grpABMRol";
            this.grpABMRol.Padding = new System.Windows.Forms.Padding(4);
            this.grpABMRol.Size = new System.Drawing.Size(363, 304);
            this.grpABMRol.TabIndex = 5;
            this.grpABMRol.TabStop = false;
            this.grpABMRol.Text = "¿Qué desea hacer?";
            // 
            // deshabilitarVisibilidad
            // 
            this.deshabilitarVisibilidad.Location = new System.Drawing.Point(90, 177);
            this.deshabilitarVisibilidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deshabilitarVisibilidad.Name = "deshabilitarVisibilidad";
            this.deshabilitarVisibilidad.Size = new System.Drawing.Size(167, 26);
            this.deshabilitarVisibilidad.TabIndex = 3;
            this.deshabilitarVisibilidad.Text = "Eliminar Visibilidad";
            this.deshabilitarVisibilidad.UseVisualStyleBackColor = true;
            this.deshabilitarVisibilidad.Click += new System.EventHandler(this.deshabilitarVisibilidad_Click);
            // 
            // agergarVisibilidad
            // 
            this.agergarVisibilidad.Location = new System.Drawing.Point(90, 93);
            this.agergarVisibilidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agergarVisibilidad.Name = "agergarVisibilidad";
            this.agergarVisibilidad.Size = new System.Drawing.Size(167, 29);
            this.agergarVisibilidad.TabIndex = 1;
            this.agergarVisibilidad.Text = "Alta visibilidad";
            this.agergarVisibilidad.UseVisualStyleBackColor = true;
            this.agergarVisibilidad.Click += new System.EventHandler(this.agergarVisibilidad_Click);
            // 
            // modificarVisibilidad
            // 
            this.modificarVisibilidad.Location = new System.Drawing.Point(90, 134);
            this.modificarVisibilidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificarVisibilidad.Name = "modificarVisibilidad";
            this.modificarVisibilidad.Size = new System.Drawing.Size(167, 32);
            this.modificarVisibilidad.TabIndex = 2;
            this.modificarVisibilidad.Text = "Modificar Visibilidad";
            this.modificarVisibilidad.UseVisualStyleBackColor = true;
            this.modificarVisibilidad.Click += new System.EventHandler(this.modificarVisibilidad_Click);
            // 
            // ABMVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 330);
            this.Controls.Add(this.grpABMRol);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ABMVisibilidad";
            this.Text = "Administrador de Visibilidades";
            this.grpABMRol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpABMRol;
        private System.Windows.Forms.Button deshabilitarVisibilidad;
        private System.Windows.Forms.Button agergarVisibilidad;
        private System.Windows.Forms.Button modificarVisibilidad;
    }
}