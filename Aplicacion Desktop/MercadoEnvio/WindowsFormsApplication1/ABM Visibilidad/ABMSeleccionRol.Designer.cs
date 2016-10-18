namespace LOS_INSISTENTES.ABM_Visibilidad
{
    partial class ABMSeleccionRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMSeleccionRol));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstVisibilidades = new System.Windows.Forms.ComboBox();
            this.btModificarVisibilidad = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstVisibilidades);
            this.groupBox1.Controls.Add(this.btModificarVisibilidad);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(366, 275);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lstVisibilidades
            // 
            this.lstVisibilidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstVisibilidades.FormattingEnabled = true;
            this.lstVisibilidades.Location = new System.Drawing.Point(48, 88);
            this.lstVisibilidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstVisibilidades.Name = "lstVisibilidades";
            this.lstVisibilidades.Size = new System.Drawing.Size(289, 24);
            this.lstVisibilidades.TabIndex = 1;
            // 
            // btModificarVisibilidad
            // 
            this.btModificarVisibilidad.Image = ((System.Drawing.Image)(resources.GetObject("btModificarVisibilidad.Image")));
            this.btModificarVisibilidad.Location = new System.Drawing.Point(223, 182);
            this.btModificarVisibilidad.Margin = new System.Windows.Forms.Padding(4);
            this.btModificarVisibilidad.Name = "btModificarVisibilidad";
            this.btModificarVisibilidad.Size = new System.Drawing.Size(100, 56);
            this.btModificarVisibilidad.TabIndex = 14;
            this.btModificarVisibilidad.UseVisualStyleBackColor = true;
            this.btModificarVisibilidad.Click += new System.EventHandler(this.btModificarVisibilidad_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(32, 182);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 59);
            this.btnAnterior.TabIndex = 13;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Que Visibilidad desea Modificar?";
            // 
            // ABMSeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 304);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABMSeleccionRol";
            this.Text = "ABMSeleccionRol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox lstVisibilidades;
        private System.Windows.Forms.Button btModificarVisibilidad;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label label1;
    }
}