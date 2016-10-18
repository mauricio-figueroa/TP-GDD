using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOS_INSISTENTES.ABM_Visibilidad
{
    public partial class ABMVisibilidad : Form
    {
        public ABMVisibilidad()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void agergarVisibilidad_Click(object sender, EventArgs e)
        {
            ABM_Visibilidad.AltaVisibilidad form = new ABM_Visibilidad.AltaVisibilidad();
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
        }

        private void modificarVisibilidad_Click(object sender, EventArgs e)
        {
            ABM_Visibilidad.ABMSeleccionRol form = new ABM_Visibilidad.ABMSeleccionRol();
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
        }

        private void deshabilitarVisibilidad_Click(object sender, EventArgs e)
        {
            ABM_Visibilidad.BajaVisibilidad form = new ABM_Visibilidad.BajaVisibilidad();
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
        }


    }
}
