namespace LOS_INSISTENTES.RolAbm
{
    partial class ModificaRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaRol));
            this.lstFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.tRol = new System.Windows.Forms.TextBox();
            this.modificarRol = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.lstRoles = new System.Windows.Forms.ComboBox();
            this.grpCambiaRol = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCambiaRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFuncionalidades
            // 
            this.lstFuncionalidades.FormattingEnabled = true;
            this.lstFuncionalidades.Location = new System.Drawing.Point(31, 96);
            this.lstFuncionalidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstFuncionalidades.Name = "lstFuncionalidades";
            this.lstFuncionalidades.Size = new System.Drawing.Size(299, 123);
            this.lstFuncionalidades.TabIndex = 15;
            // 
            // tRol
            // 
            this.tRol.Enabled = false;
            this.tRol.Location = new System.Drawing.Point(151, 59);
            this.tRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tRol.Name = "tRol";
            this.tRol.Size = new System.Drawing.Size(179, 22);
            this.tRol.TabIndex = 13;
            // 
            // modificarRol
            // 
            this.modificarRol.Image = ((System.Drawing.Image)(resources.GetObject("modificarRol.Image")));
            this.modificarRol.Location = new System.Drawing.Point(231, 272);
            this.modificarRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modificarRol.Name = "modificarRol";
            this.modificarRol.Size = new System.Drawing.Size(100, 59);
            this.modificarRol.TabIndex = 17;
            this.modificarRol.UseVisualStyleBackColor = true;
            this.modificarRol.Click += new System.EventHandler(this.modificarRol_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(31, 272);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 62);
            this.btnAnterior.TabIndex = 16;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(35, 242);
            this.chkHabilitado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(82, 21);
            this.chkHabilitado.TabIndex = 18;
            this.chkHabilitado.Text = "Habilitar";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // lstRoles
            // 
            this.lstRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstRoles.FormattingEnabled = true;
            this.lstRoles.Location = new System.Drawing.Point(151, 25);
            this.lstRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstRoles.Name = "lstRoles";
            this.lstRoles.Size = new System.Drawing.Size(179, 24);
            this.lstRoles.TabIndex = 19;
            this.lstRoles.SelectedIndexChanged += new System.EventHandler(this.lstRoles_SelectedIndexChanged);
            // 
            // grpCambiaRol
            // 
            this.grpCambiaRol.Controls.Add(this.label2);
            this.grpCambiaRol.Controls.Add(this.label1);
            this.grpCambiaRol.Controls.Add(this.lstRoles);
            this.grpCambiaRol.Controls.Add(this.modificarRol);
            this.grpCambiaRol.Controls.Add(this.chkHabilitado);
            this.grpCambiaRol.Controls.Add(this.tRol);
            this.grpCambiaRol.Controls.Add(this.lstFuncionalidades);
            this.grpCambiaRol.Controls.Add(this.btnAnterior);
            this.grpCambiaRol.Location = new System.Drawing.Point(15, 11);
            this.grpCambiaRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCambiaRol.Name = "grpCambiaRol";
            this.grpCambiaRol.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCambiaRol.Size = new System.Drawing.Size(360, 345);
            this.grpCambiaRol.TabIndex = 20;
            this.grpCambiaRol.TabStop = false;
            this.grpCambiaRol.Text = "Modificar rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nuevo nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Rol:";
            // 
            // ModificaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 369);
            this.Controls.Add(this.grpCambiaRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ModificaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Rol";
            this.grpCambiaRol.ResumeLayout(false);
            this.grpCambiaRol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button modificarRol;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.CheckedListBox lstFuncionalidades;
        private System.Windows.Forms.TextBox tRol;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.ComboBox lstRoles;
        private System.Windows.Forms.GroupBox grpCambiaRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}