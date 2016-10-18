using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using LOS_INSISTENTES.Clases;
using System.Data.SqlClient;


namespace LOS_INSISTENTES
{
    public partial class LoginForm : Form
    {
        public const int CANTIDAD_MAXIMA_INTENTOS = 3;

        public LoginForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tUsuario.Text;
            UTF8Encoding encoderHash = new UTF8Encoding();
            SHA256Managed hasher = new SHA256Managed();
            byte[] bytesDeHasheo = hasher.ComputeHash(encoderHash.GetBytes(tPassword.Text));
            string password = Interfaz.Interfaz.bytesDeHasheoToString(bytesDeHasheo);
            Usuario usuario = new Usuario(0, username, password);

            if (tUsuario.Text.Equals("") || tPassword.Text.Equals(""))
            {
                Interfaz.Interfaz.emitirAviso("Por favor ingrese el usuario y la contraseña.");
                return;
            }

            if (!usuario.obtenerPK())
            {
                Interfaz.Interfaz.emitirAviso("El usuario no existe");
                return;
            }

            if (!usuario.habilitado())
            {
                Interfaz.Interfaz.emitirAviso("El usuario se encuentra inhabilitado.");
                return;
            }

            int primeraVezDespuesDeMigracion = usuario.primeraVez();
            if (primeraVezDespuesDeMigracion == 0)//-->no es la primera vez
            {
                if (usuario.verificarContrasenia())
                {
                    usuario.ResetearIntentosFallidos();
                    if (usuario.obtenerRoles())
                    {
                        if (usuario.Roles.Count() == 1)
                        {
                            this.Hide();
                            Loggin.SeleccionFuncionalidades formSeleccionFuncionalidades = new Loggin.SeleccionFuncionalidades(usuario, usuario.Roles[0].ID_Rol, true);
                            formSeleccionFuncionalidades.Show();
                        }
                        else
                        {
                            this.Hide();
                            Loggin.SeleccionRol formSeleccionRoles = new Loggin.SeleccionRol(usuario);
                            formSeleccionRoles.Show();
                        }
                    }
                    else
                    {
                        Interfaz.Interfaz.emitirAviso("El usuario no tiene roles asignados");
                    }
                }
                else
                {
                    usuario.sumarIntentoFallido();
                    if (usuario.cantidadIntentosFallidos() == CANTIDAD_MAXIMA_INTENTOS)
                    {
                        usuario.desHabilitarUsuario();
                        Interfaz.Interfaz.emitirAviso("Usuario inhabilitado.");
                    }
                    else
                    {
                        Interfaz.Interfaz.emitirAviso("Usuario o contraseña incorrecta, le quedan " + (CANTIDAD_MAXIMA_INTENTOS - usuario.intentosFallidos()).ToString() + " intentos");
                    }
                }
            }
            else
            {
                if (primeraVezDespuesDeMigracion == 2)
                {
                    if (usuario.verificarContraseniaSinHash(tPassword.Text))
                    {
                        Loggin.CambiarPassword formPass = new Loggin.CambiarPassword(true);
                        formPass.Show();
                    }
                    else
                    {
                        usuario.sumarIntentoFallido();
                        if (usuario.cantidadIntentosFallidos() == CANTIDAD_MAXIMA_INTENTOS)
                        {
                            usuario.desHabilitarUsuario();
                            Interfaz.Interfaz.emitirAviso("Usuario inhabilitado.");
                        }
                        else
                        {
                            Interfaz.Interfaz.emitirAviso("Usuario o contraseña incorrecta, le quedan " + (CANTIDAD_MAXIMA_INTENTOS - usuario.intentosFallidos()).ToString() + " intentos");
                        }
                    }
                }
                if (primeraVezDespuesDeMigracion == 1)
                {
                    Loggin.CambiarPassword formPass = new Loggin.CambiarPassword(true);
                    formPass.Show();
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}