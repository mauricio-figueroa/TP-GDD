namespace LOS_INSISTENTES.ABMUsuario
{
    partial class AltaEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaEmpresa));
            this.tNombreDeContacto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tCuit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tCiudad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstRubro = new System.Windows.Forms.ComboBox();
            this.tMail = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tCodigoPostal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tRazonSocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tNombreDeContacto
            // 
            this.tNombreDeContacto.Location = new System.Drawing.Point(194, 277);
            this.tNombreDeContacto.Name = "tNombreDeContacto";
            this.tNombreDeContacto.Size = new System.Drawing.Size(275, 20);
            this.tNombreDeContacto.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(495, 277);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "(*)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 165);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Código Postal:";
            // 
            // tCuit
            // 
            this.tCuit.Location = new System.Drawing.Point(194, 240);
            this.tCuit.MaxLength = 11;
            this.tCuit.Name = "tCuit";
            this.tCuit.Size = new System.Drawing.Size(275, 20);
            this.tCuit.TabIndex = 7;
            this.tCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tCuit_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(495, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "(*)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Dirección - Nº Piso - Dto - Localidad:";
            // 
            // tCiudad
            // 
            this.tCiudad.Location = new System.Drawing.Point(194, 203);
            this.tCiudad.Name = "tCiudad";
            this.tCiudad.Size = new System.Drawing.Size(275, 20);
            this.tCiudad.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstRubro);
            this.groupBox1.Controls.Add(this.tMail);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.tNombreDeContacto);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tCuit);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tCiudad);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tCodigoPostal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tDireccion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tTelefono);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tRazonSocial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 392);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regístrate:";
            // 
            // lstRubro
            // 
            this.lstRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstRubro.FormattingEnabled = true;
            this.lstRubro.Location = new System.Drawing.Point(194, 310);
            this.lstRubro.Name = "lstRubro";
            this.lstRubro.Size = new System.Drawing.Size(275, 21);
            this.lstRubro.TabIndex = 9;
            // 
            // tMail
            // 
            this.tMail.Location = new System.Drawing.Point(194, 58);
            this.tMail.Name = "tMail";
            this.tMail.Size = new System.Drawing.Size(275, 20);
            this.tMail.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(294, 356);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(194, 356);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(394, 356);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Rubro:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 280);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 13);
            this.label22.TabIndex = 29;
            this.label22.Text = "Nombre de Contacto:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(495, 318);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "(*)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 243);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "CUIT:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(495, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "(*)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Ciudad:";
            // 
            // tCodigoPostal
            // 
            this.tCodigoPostal.Location = new System.Drawing.Point(194, 162);
            this.tCodigoPostal.MaxLength = 4;
            this.tCodigoPostal.Name = "tCodigoPostal";
            this.tCodigoPostal.Size = new System.Drawing.Size(275, 20);
            this.tCodigoPostal.TabIndex = 5;
            this.tCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tCodigoPostal_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(495, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "(*)";
            // 
            // tDireccion
            // 
            this.tDireccion.Location = new System.Drawing.Point(194, 129);
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(275, 20);
            this.tDireccion.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(495, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "(*)";
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(194, 93);
            this.tTelefono.MaxLength = 10;
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(275, 20);
            this.tTelefono.TabIndex = 3;
            this.tTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tTelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(495, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "(*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(495, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mail:";
            // 
            // tRazonSocial
            // 
            this.tRazonSocial.Location = new System.Drawing.Point(194, 19);
            this.tRazonSocial.Name = "tRazonSocial";
            this.tRazonSocial.Size = new System.Drawing.Size(275, 20);
            this.tRazonSocial.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(495, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razón Social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos Obligatorios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(495, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "(*)";
            // 
            // AltaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 401);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AltaEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Empresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tNombreDeContacto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tCuit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tCiudad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tCodigoPostal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tRazonSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tMail;
        private System.Windows.Forms.ComboBox lstRubro;
    }
}