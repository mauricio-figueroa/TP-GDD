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
    public partial class ClienteABM : Form
    {
        String usuario;
        String pass;
        

        public ClienteABM(String user,String pas)
        {
            this.usuario = user;
            this.pass = pas;
            InitializeComponent();
            CenterToParent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new ABMUsuario.UsuarioNuevo(1);
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMUsuario.BajaCliente form = new ABMUsuario.BajaCliente();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABMUsuario.BajaCliente form = new ABMUsuario.BajaCliente();
            form.ShowDialog();
        }
    }
}
