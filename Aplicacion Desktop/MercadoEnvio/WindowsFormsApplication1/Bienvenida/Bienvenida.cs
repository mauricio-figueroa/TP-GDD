using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOS_INSISTENTES.Bienvenida
{
    public partial class Bienvenida : Form
    {

        public static string saltoDeLinea = "\r\n";
        public static string dobleSaltoDeLinte = saltoDeLinea + saltoDeLinea;
        public string textoBienvenida = "Bienvenidos a nuestra querida implementación de Mercado Envíos." + dobleSaltoDeLinte + saltoDeLinea + "Grupo: LOS_INSISTENTES" + dobleSaltoDeLinte + "Número de Grupo: 6" + dobleSaltoDeLinte + "Integrantes: " +saltoDeLinea+ "      -Riveros, Matias." + saltoDeLinea + "      -Gonzalez, Carolina." + saltoDeLinea + "      -Fontán, Micaela." + saltoDeLinea + "      -Figueroa, Mauricio";
        public Bienvenida()
        {
            InitializeComponent();
            this.CenterToScreen();

            textBoxBienvenida.Text = textoBienvenida;           
            textBoxBienvenida.AppendText(".");
            textBoxBienvenida.ReadOnly = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

    
    }
}
