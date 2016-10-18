using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOS_INSISTENTES
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Ejecuto el PL que finaliza las subastas anteriores a la fecha del sistema
            Interfaz.Interfaz.finalizarSubastas();

            InicioPrograma inicioDePrograma = new InicioPrograma();
         
             if (inicioDePrograma.primeraVezPrograma())
            {
              Application.Run( new Bienvenida.Bienvenida());
            }
            else
            {
                Application.Run( new LoginForm());
            }
           
        }
    }
}
