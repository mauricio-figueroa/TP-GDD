namespace LOS_INSISTENTES.Loggin
{
    partial class CambiarPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarPassword));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.passViejoNH = new System.Windows.Forms.TextBox();
            this.agregarRol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agregarRol);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pass2);
            this.groupBox3.Location = new System.Drawing.Point(7, 182);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(288, 64);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Confirmar nueva contraseña";
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(13, 25);
            this.pass2.Margin = new System.Windows.Forms.Padding(4);
            this.pass2.Name = "pass2";
            this.pass2.PasswordChar = '*';
            this.pass2.Size = new System.Drawing.Size(260, 22);
            this.pass2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pass1);
            this.groupBox2.Location = new System.Drawing.Point(7, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(288, 64);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nueva contraseña";
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(13, 25);
            this.pass1.Margin = new System.Windows.Forms.Padding(4);
            this.pass1.Name = "pass1";
            this.pass1.PasswordChar = '*';
            this.pass1.Size = new System.Drawing.Size(260, 22);
            this.pass1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.passViejoNH);
            this.groupBox4.Location = new System.Drawing.Point(7, 22);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(288, 64);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contraseña vieja";
            // 
            // passViejoNH
            // 
            this.passViejoNH.Location = new System.Drawing.Point(13, 25);
            this.passViejoNH.Margin = new System.Windows.Forms.Padding(4);
            this.passViejoNH.Multiline = true;
            this.passViejoNH.Name = "passViejoNH";
            this.passViejoNH.PasswordChar = '*';
            this.passViejoNH.Size = new System.Drawing.Size(260, 24);
            this.passViejoNH.TabIndex = 0;
            // 
            // agregarRol
            // 
            this.agregarRol.Image = ((System.Drawing.Image)(resources.GetObject("agregarRol.Image")));
            this.agregarRol.Location = new System.Drawing.Point(195, 254);
            this.agregarRol.Margin = new System.Windows.Forms.Padding(4);
            this.agregarRol.Name = "agregarRol";
            this.agregarRol.Size = new System.Drawing.Size(100, 59);
            this.agregarRol.TabIndex = 13;
            this.agregarRol.UseVisualStyleBackColor = true;
            this.agregarRol.Click += new System.EventHandler(this.button1_Click);
            // 
            // CambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 366);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CambiarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de contraseña";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox passViejoNH;
        private System.Windows.Forms.Button agregarRol;

    }
}