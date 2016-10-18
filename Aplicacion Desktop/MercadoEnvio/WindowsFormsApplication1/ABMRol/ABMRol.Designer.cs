namespace LOS_INSISTENTES.RolAbm
{
    partial class ABMRol
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
            this.agergarRol = new System.Windows.Forms.Button();
            this.modificarRol = new System.Windows.Forms.Button();
            this.deshabilitarRol = new System.Windows.Forms.Button();
            this.grpABMRol = new System.Windows.Forms.GroupBox();
            this.grpABMRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // agergarRol
            // 
            this.agergarRol.Location = new System.Drawing.Point(120, 107);
            this.agergarRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agergarRol.Name = "agergarRol";
            this.agergarRol.Size = new System.Drawing.Size(123, 34);
            this.agergarRol.TabIndex = 1;
            this.agergarRol.Text = "Agregar Rol";
            this.agergarRol.UseVisualStyleBackColor = true;
            this.agergarRol.Click += new System.EventHandler(this.agergarRol_Click);
            // 
            // modificarRol
            // 
            this.modificarRol.Location = new System.Drawing.Point(120, 148);
            this.modificarRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificarRol.Name = "modificarRol";
            this.modificarRol.Size = new System.Drawing.Size(123, 37);
            this.modificarRol.TabIndex = 2;
            this.modificarRol.Text = "Modificar Rol";
            this.modificarRol.UseVisualStyleBackColor = true;
            this.modificarRol.Click += new System.EventHandler(this.modificarRol_Click);
            // 
            // deshabilitarRol
            // 
            this.deshabilitarRol.Location = new System.Drawing.Point(120, 191);
            this.deshabilitarRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deshabilitarRol.Name = "deshabilitarRol";
            this.deshabilitarRol.Size = new System.Drawing.Size(123, 31);
            this.deshabilitarRol.TabIndex = 3;
            this.deshabilitarRol.Text = "Eliminar Rol";
            this.deshabilitarRol.UseVisualStyleBackColor = true;
            this.deshabilitarRol.Click += new System.EventHandler(this.deshabilitarRol_Click);
            // 
            // grpABMRol
            // 
            this.grpABMRol.Controls.Add(this.deshabilitarRol);
            this.grpABMRol.Controls.Add(this.agergarRol);
            this.grpABMRol.Controls.Add(this.modificarRol);
            this.grpABMRol.Location = new System.Drawing.Point(17, 15);
            this.grpABMRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpABMRol.Name = "grpABMRol";
            this.grpABMRol.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpABMRol.Size = new System.Drawing.Size(360, 345);
            this.grpABMRol.TabIndex = 4;
            this.grpABMRol.TabStop = false;
            this.grpABMRol.Text = "¿Qué desea hacer?";
            // 
            // ABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 369);
            this.Controls.Add(this.grpABMRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ABMRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM de Roles";
            this.grpABMRol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button agergarRol;
        private System.Windows.Forms.Button modificarRol;
        private System.Windows.Forms.Button deshabilitarRol;
        private System.Windows.Forms.GroupBox grpABMRol;
    }
}