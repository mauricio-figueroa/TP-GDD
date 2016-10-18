using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOS_INSISTENTES.RolAbm
{
    public partial class ABMRol : Form
    {
        public ABMRol()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void agergarRol_Click(object sender, EventArgs e)
        {
            Form form = new AltaRol();
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
        }

        private void modificarRol_Click(object sender, EventArgs e)
        {
            Form form = new ModificaRol();
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
        }

        private void deshabilitarRol_Click(object sender, EventArgs e)
        {
            Form form = new BajaRol();
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
        }
    }
}
