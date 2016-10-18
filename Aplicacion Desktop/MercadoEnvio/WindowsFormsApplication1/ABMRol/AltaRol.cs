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
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
            CenterToParent();
            this.llenaChkListBox();
        }

        private void llenaChkListBox() {
            Interfaz.Interfaz.llenarChkListBox(lstFuncionalidades,"select ID_Funcionalidad as id, Nombre as valor from LOS_INSISTENTES.Funcionalidades");
        }

        private void agregarRol_Click(object sender, EventArgs e)
        {
            if (tRol.Text.Equals(""))
            {
                Interfaz.Interfaz.emitirAviso("Por favor ingrese un nombre para el rol.");
                return;
            }
            else
            {
                int cant = lstFuncionalidades.CheckedItems.Count;
                if (cant < 1)
                {
                    Interfaz.Interfaz.emitirAviso("Por favor seleccione al menos una funcionalidad para el rol.");
                }
                else
                {


                    if (!BaseDeDatos.existeString(tRol.Text, "LOS_INSISTENTES.Roles", "Nombre"))
                    {
                        List<int> listaFuncionalidades = new List<int>();

                        foreach (object itemChecked in lstFuncionalidades.CheckedItems)
                        {
                            DataRowView castedItem = itemChecked as DataRowView;
                            listaFuncionalidades.Add(Convert.ToInt32(castedItem["id"]));
                        }

                        Clases.Rol.agregarRol(tRol.Text, listaFuncionalidades);

                        Form form = new ABMRol();
                        Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
                        Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);

                    }
                    else
                    {
                        Interfaz.Interfaz.emitirAviso("El rol ya existe, elija otro nombre.");
                    }
                }
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
