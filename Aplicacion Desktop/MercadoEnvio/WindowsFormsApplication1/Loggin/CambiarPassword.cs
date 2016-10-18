using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace LOS_INSISTENTES.Loggin
{
    public partial class CambiarPassword : Form
    {
        public Boolean primeraVez { get; set; }
        public CambiarPassword(Boolean pVez)
        {            
            InitializeComponent();
            CenterToParent();
            this.primeraVez = pVez;

            if (primeraVez)
            {
                passViejoNH.Enabled = false;
                Interfaz.Interfaz.emitirAviso("Por seguridad y por unica vez, debera cambiar el password");
            }
        }

        private void pass2_TextChanged(object sender, EventArgs e)
        {
            pass2.PasswordChar = '*';
        }

        private void pass1_TextChanged(object sender, EventArgs e)
        {
            pass1.PasswordChar = '*';
        }

        private void passViejo_TextChanged(object sender, EventArgs e)
        {
            passViejoNH.PasswordChar = '*';
        }

        public Boolean chequearPassword(string password)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", Interfaz.Interfaz.usuario.ID_User);
            BaseDeDatos.agregarParametro(listaParametros, "@Password", password);
            SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT Password FROM LOS_INSISTENTES.Usuarios WHERE ID_User = @ID_User AND Password = @Password", listaParametros, BaseDeDatos.iniciarConexion());
            Boolean res = lector.HasRows;
            BaseDeDatos.cerrarConexion();
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!passViejoNH.Text.Equals("") || primeraVez == true) && !pass1.Text.Equals("") && !pass2.Text.Equals(""))
            {
                if (primeraVez == false)
                {
                    UTF8Encoding encoderHash = new UTF8Encoding();
                    SHA256Managed hasher = new SHA256Managed();
                    byte[] bytesDeHasheo = hasher.ComputeHash(encoderHash.GetBytes(passViejoNH.Text));
                    string passViejo = bytesDeHasheoToString(bytesDeHasheo);

                    if (chequearPassword(passViejo))
                    {
                        if (pass1.Text == pass2.Text)
                        {
                            Interfaz.Interfaz.usuario.cambiarPassword(pass1.Text);
                            Interfaz.Interfaz.emitirAviso("Contraseña modificada.");
                            this.Hide();
                        }
                        else
                        {
                            Interfaz.Interfaz.emitirAviso("Las contraseñas no coinciden.");
                        }
                    }
                    else
                    {
                        Interfaz.Interfaz.emitirAviso("El password viejo no es correcto.");
                    }
                }
                else
                {
                    if (pass1.Text == pass2.Text)
                    {
                        Interfaz.Interfaz.usuario.cambiarPassword(pass1.Text);
                        Interfaz.Interfaz.emitirAviso("Contraseña modificada.");
                        this.Hide();
                    }
                    else
                    {
                        Interfaz.Interfaz.emitirAviso("Las contraseñas no coinciden.");
                    }
                }
            }
            else
            {
                Interfaz.Interfaz.emitirAviso("Debe ingresar los datos solicitados.");
            }
        }

        private string bytesDeHasheoToString(byte[] array)
        {
            StringBuilder salida = new StringBuilder("");
            for (int i = 0; i < array.Length; i++)
            {
                salida.Append(array[i].ToString("X2"));
            }
            return salida.ToString();
        }


    }
}