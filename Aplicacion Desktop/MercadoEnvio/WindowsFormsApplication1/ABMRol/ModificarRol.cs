using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOS_INSISTENTES.RolAbm
{
    public partial class ModificaRol : Form
    {

        Interfaz.Interfaz interfaz = new Interfaz.Interfaz();

        public ModificaRol()
        {
            InitializeComponent();
            CenterToParent();
            this.llenaChkListBox();
            this.listarRoles();
        }

        public void listarRoles()
        {
            interfaz.cargarComboIDValor(lstRoles, "select ID_Rol as id, Nombre as valor from LOS_INSISTENTES.Roles");
        }

        private void llenaChkListBox()
        {
            Interfaz.Interfaz.llenarChkListBox(lstFuncionalidades, "select ID_Funcionalidad as id, Nombre as valor from LOS_INSISTENTES.Funcionalidades");
        }

        private void modificarRol_Click(object sender, EventArgs e)
        {
            if (tRol.Text.Equals(""))
            {
                Interfaz.Interfaz.emitirAviso("Ingrese el nuevo nombre.");
                return;
            }

            if (!BaseDeDatos.existeString(tRol.Text, "LOS_INSISTENTES.Roles", "Nombre") || tRol.Text == lstRoles.Text)
            {
                List<int> listaFuncionalidades = new List<int>();

                foreach (object itemChecked in lstFuncionalidades.CheckedItems)
                {
                    DataRowView castedItem = itemChecked as DataRowView;
                    listaFuncionalidades.Add(Convert.ToInt32(castedItem["id"]));
                }
                int idRol = Convert.ToInt32(lstRoles.SelectedValue);

                Clases.Rol.modificarRol(idRol, tRol.Text, chkHabilitado.Checked, listaFuncionalidades);

                Form form = new ABMRol();
                Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
                Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
            }
            else
            {
                Interfaz.Interfaz.emitirAviso("El rol ya existe, elija otro nombre.");
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Form form = new ABMRol();
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
        }

        private void lstRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idRol = Convert.ToInt32(lstRoles.SelectedValue);
            tRol.Enabled = true;
            lstFuncionalidades.ClearSelected();
            if (idRol != -1)
            {
                String query = "";
                SqlDataReader lector;
                query = "SELECT * from LOS_INSISTENTES.Roles where ID_Rol = " + idRol;
                lector = BaseDeDatos.ejecutarReader(query, null, BaseDeDatos.iniciarConexion());
                lector.Read();

                tRol.Text = Convert.ToString(lector["Nombre"]);
                chkHabilitado.Checked = Convert.ToBoolean(lector["Habilitado"]);
                chkHabilitado.Enabled = !Convert.ToBoolean(lector["Habilitado"]);

                BaseDeDatos.cerrarConexion();

                query = "SELECT * from LOS_INSISTENTES.Funcionalidad_Rol where ID_Rol = " + idRol.ToString();
                lector = BaseDeDatos.ejecutarReader(query, null, BaseDeDatos.iniciarConexion());
                List<int> funcionalidadesHabilitadas = new List<int>();

                if (lector.HasRows) {

                    while (lector.Read())
                    {
                        int idFuncionalidad = Convert.ToInt32(lector["ID_Funcionalidad"]);
                        funcionalidadesHabilitadas.Add(idFuncionalidad);
                    }

                    List<int> listaCheck = new List<int>();

                    int i = 0;
                    foreach (object itemChecked in lstFuncionalidades.Items)
                    {
                        DataRowView castedItem = itemChecked as DataRowView;
                        int idFuncionalidad = Convert.ToInt32(castedItem["ID"]);

                        if (funcionalidadesHabilitadas.Contains(idFuncionalidad))
                            listaCheck.Add(i);

                        i++;
                    }

                    for (i = 0; i < lstFuncionalidades.Items.Count; i++)
                        lstFuncionalidades.SetItemChecked(i, listaCheck.Contains(i));

                }

                BaseDeDatos.cerrarConexion();
            }
        }

    }
}
