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
    public partial class ABMSeleccionRol : Form
    {
        Interfaz.Interfaz interfaz;
        public ABMSeleccionRol()
        {
            interfaz = new Interfaz.Interfaz();
            InitializeComponent();
            CenterToParent();
            this.listarVisibilidades();
        }

        public void listarVisibilidades()
        {
            interfaz.cargarComboIDValor(lstVisibilidades, "select Cod_Visibilidad as id, Descripcion as valor from LOS_INSISTENTES.VisibilidadesTabla");
        }

        private void btModificarVisibilidad_Click(object sender, EventArgs e)
        {
            
           
         
           
            
            if (Convert.ToInt32(lstVisibilidades.SelectedValue) != -1)
            {
                ABM_Visibilidad.ModificarVisibilidad form = new ABM_Visibilidad.ModificarVisibilidad(lstVisibilidades.SelectedValue.ToString());
                Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
                Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);

              
                
            }
            else
            {
                Interfaz.Interfaz.emitirAviso("seleccione una opcion");
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ABM_Visibilidad.ABMVisibilidad form = new ABM_Visibilidad.ABMVisibilidad();
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
        }


    }
}
