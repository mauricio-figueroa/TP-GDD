using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOS_INSISTENTES.ABMUsuario
{
    public partial class ABMEmpresa : Form
    {
        
        String usuario;
        String pass;

        public ABMEmpresa(String user, String pas)
        {
            this.usuario = user;
            this.pass = pas;
            InitializeComponent();
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new ABMUsuario.UsuarioNuevo(2);
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ABMUsuario.BajaEmpresa form = new ABMUsuario.BajaEmpresa();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABMUsuario.BajaEmpresa form = new ABMUsuario.BajaEmpresa();
            form.ShowDialog();
        }
    }
}
