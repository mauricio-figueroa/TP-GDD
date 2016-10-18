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
    public partial class BajaRol : Form
    {
        Interfaz.Interfaz interfaz;
        public BajaRol()
        {
            interfaz = new Interfaz.Interfaz();
            InitializeComponent();
            CenterToParent();
            this.listarRoles();
        }

        public void listarRoles()
        {
            interfaz.cargarComboIDValor(lstRoles, "select ID_Rol as id, Nombre as valor from LOS_INSISTENTES.Roles WHERE habilitado = 1");
        }

        private void deshabilitarBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lstRoles.SelectedValue) == -1)
            {
                Interfaz.Interfaz.emitirAviso("Elija un rol.");
                return;
            }

            if (Interfaz.Interfaz.emitirPregunta("¿Seguro desea dar de baja el rol " + lstRoles.Text + "? Se deshabilitarán los usuarios asociados al mismo.") == DialogResult.Yes)
            {
                Clases.Rol.DeshabilitarRol(Convert.ToInt32(lstRoles.SelectedValue));
                Interfaz.Interfaz.emitirAviso("Rol deshabilitado exitosamente.");
                Form form = new ABMRol();
                Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
                Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Form form = new ABMRol();
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
        }

    }
}

