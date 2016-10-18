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
using LOS_INSISTENTES.ABMUsuario;

namespace LOS_INSISTENTES.ABMUsuario
{
    public partial class RolNuevo : Form
    {

        String usuario;
        String pass;

        public RolNuevo(String user,String pas)
        {
            this.usuario = user;
            this.pass = pas;
            InitializeComponent();
            CenterToParent();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            Form clienteAbmform=new ABMUsuario.ClienteABM("","");
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(clienteAbmform, panelContenido);
        }

        private void btnAltaEmpresa_Click(object sender, EventArgs e)
        {
            Form empresaAbmForm = new ABMUsuario.ABMEmpresa("", "");
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(empresaAbmForm, panelContenido);

        }
    }
}
