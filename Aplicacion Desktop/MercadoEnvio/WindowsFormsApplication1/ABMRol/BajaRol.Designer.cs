namespace LOS_INSISTENTES.RolAbm
{
    partial class BajaRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaRol));
            this.label1 = new System.Windows.Forms.Label();
            this.lstRoles = new System.Windows.Forms.ComboBox();
            this.agregarRol = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Que rol desea dar de baja (lógica)?";
            // 
            // lstRoles
            // 
            this.lstRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstRoles.FormattingEnabled = true;
            this.lstRoles.Location = new System.Drawing.Point(24, 106);
            this.lstRoles.Margin = new System.Windows.Forms.Padding(2);
            this.lstRoles.Name = "lstRoles";
            this.lstRoles.Size = new System.Drawing.Size(218, 21);
            this.lstRoles.TabIndex = 1;
            // 
            // agregarRol
            // 
            this.agregarRol.Image = ((System.Drawing.Image)(resources.GetObject("agregarRol.Image")));
            this.agregarRol.Location = new System.Drawing.Point(167, 209);
            this.agregarRol.Name = "agregarRol";
            this.agregarRol.Size = new System.Drawing.Size(75, 48);
            this.agregarRol.TabIndex = 14;
            this.agregarRol.UseVisualStyleBackColor = true;
            this.agregarRol.Click += new System.EventHandler(this.deshabilitarBtn_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(24, 209);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 50);
            this.btnAnterior.TabIndex = 13;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstRoles);
            this.groupBox1.Controls.Add(this.agregarRol);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 280);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baja (lógica) de rol";
            // 
            // BajaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 300);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "BajaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstRoles;
        private System.Windows.Forms.Button agregarRol;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}