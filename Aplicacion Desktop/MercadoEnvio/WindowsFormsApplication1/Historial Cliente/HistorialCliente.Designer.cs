namespace LOS_INSISTENTES.Historial_Cliente
{
    partial class HistorialCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialCliente));
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.dgHistorial = new System.Windows.Forms.DataGridView();
            this.lblCompras = new System.Windows.Forms.Label();
            this.lblEstrellas = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // grpHistorial
            // 
            this.grpHistorial.Controls.Add(this.dgHistorial);
            this.grpHistorial.Controls.Add(this.lblCompras);
            this.grpHistorial.Controls.Add(this.lblEstrellas);
            this.grpHistorial.Controls.Add(this.btnAnterior);
            this.grpHistorial.Controls.Add(this.btnSiguiente);
            this.grpHistorial.Location = new System.Drawing.Point(13, 7);
            this.grpHistorial.Name = "grpHistorial";
            this.grpHistorial.Size = new System.Drawing.Size(758, 314);
            this.grpHistorial.TabIndex = 6;
            this.grpHistorial.TabStop = false;
            this.grpHistorial.Text = "Mi historial";
            // 
            // dgHistorial
            // 
            this.dgHistorial.AllowUserToAddRows = false;
            this.dgHistorial.AllowUserToDeleteRows = false;
            this.dgHistorial.AllowUserToResizeColumns = false;
            this.dgHistorial.AllowUserToResizeRows = false;
            this.dgHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgHistorial.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgHistorial.Location = new System.Drawing.Point(37, 21);
            this.dgHistorial.Name = "dgHistorial";
            this.dgHistorial.ReadOnly = true;
            this.dgHistorial.RowHeadersVisible = false;
            this.dgHistorial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgHistorial.ShowCellErrors = false;
            this.dgHistorial.ShowCellToolTips = false;
            this.dgHistorial.ShowEditingIcon = false;
            this.dgHistorial.ShowRowErrors = false;
            this.dgHistorial.Size = new System.Drawing.Size(684, 228);
            this.dgHistorial.TabIndex = 6;
            this.dgHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHistorial_CellContentClick);
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompras.Location = new System.Drawing.Point(63, 286);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(64, 13);
            this.lblCompras.TabIndex = 10;
            this.lblCompras.Text = "Usted tiene ";
            // 
            // lblEstrellas
            // 
            this.lblEstrellas.Image = ((System.Drawing.Image)(resources.GetObject("lblEstrellas.Image")));
            this.lblEstrellas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstrellas.Location = new System.Drawing.Point(63, 255);
            this.lblEstrellas.Name = "lblEstrellas";
            this.lblEstrellas.Size = new System.Drawing.Size(445, 28);
            this.lblEstrellas.TabIndex = 9;
            this.lblEstrellas.Text = "Usted tiene ";
            this.lblEstrellas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(548, 258);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 50);
            this.btnAnterior.TabIndex = 8;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(646, 258);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 50);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // HistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 333);
            this.Controls.Add(this.grpHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HistorialCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Historial del Cliente";
            this.grpHistorial.ResumeLayout(false);
            this.grpHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHistorial;
        private System.Windows.Forms.DataGridView dgHistorial;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Label lblEstrellas;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;

    }
}