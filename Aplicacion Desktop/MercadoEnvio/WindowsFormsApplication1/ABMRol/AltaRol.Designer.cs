namespace LOS_INSISTENTES.RolAbm
{
    partial class AltaRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaRol));
            this.tRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.agregarRol = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.grpAltaRol = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpAltaRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // tRol
            // 
            this.tRol.Location = new System.Drawing.Point(109, 23);
            this.tRol.Margin = new System.Windows.Forms.Padding(2);
            this.tRol.Name = "tRol";
            this.tRol.Size = new System.Drawing.Size(142, 20);
            this.tRol.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // lstFuncionalidades
            // 
            this.lstFuncionalidades.FormattingEnabled = true;
            this.lstFuncionalidades.Location = new System.Drawing.Point(26, 82);
            this.lstFuncionalidades.Margin = new System.Windows.Forms.Padding(2);
            this.lstFuncionalidades.Name = "lstFuncionalidades";
            this.lstFuncionalidades.Size = new System.Drawing.Size(225, 109);
            this.lstFuncionalidades.TabIndex = 2;
            // 
            // agregarRol
            // 
            this.agregarRol.Image = ((System.Drawing.Image)(resources.GetObject("agregarRol.Image")));
            this.agregarRol.Location = new System.Drawing.Point(176, 213);
            this.agregarRol.Name = "agregarRol";
            this.agregarRol.Size = new System.Drawing.Size(75, 48);
            this.agregarRol.TabIndex = 12;
            this.agregarRol.UseVisualStyleBackColor = true;
            this.agregarRol.Click += new System.EventHandler(this.agregarRol_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(26, 213);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 50);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // grpAltaRol
            // 
            this.grpAltaRol.Controls.Add(this.label2);
            this.grpAltaRol.Controls.Add(this.agregarRol);
            this.grpAltaRol.Controls.Add(this.btnAnterior);
            this.grpAltaRol.Controls.Add(this.tRol);
            this.grpAltaRol.Controls.Add(this.lstFuncionalidades);
            this.grpAltaRol.Controls.Add(this.label1);
            this.grpAltaRol.Location = new System.Drawing.Point(11, 9);
            this.grpAltaRol.Name = "grpAltaRol";
            this.grpAltaRol.Size = new System.Drawing.Size(270, 280);
            this.grpAltaRol.TabIndex = 13;
            this.grpAltaRol.TabStop = false;
            this.grpAltaRol.Text = "Alta de nuevo rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Funcionalidades:";
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 300);
            this.Controls.Add(this.grpAltaRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AltaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Rol";
            this.grpAltaRol.ResumeLayout(false);
            this.grpAltaRol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox lstFuncionalidades;
        private System.Windows.Forms.Button agregarRol;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.GroupBox grpAltaRol;
        private System.Windows.Forms.Label label2;
    }
}