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

namespace LOS_INSISTENTES.ABM_Visibilidad
{
    public partial class BajaVisibilidad : Form
    {
        Interfaz.Interfaz interfaz;
        public BajaVisibilidad()
        {
            interfaz = new Interfaz.Interfaz();           
            InitializeComponent();
            CenterToParent();
            this.listarVisibilidades();
        }


        public void listarVisibilidades()
        {
            interfaz.cargarComboIDValor(lstVisibilidades, "select Cod_Visibilidad as id, Descripcion as valor from LOS_INSISTENTES.Visibilidades where Habilitada = 1");
        }

        private void btModificarVisibilidad_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lstVisibilidades.SelectedValue) != -1)
            {
                List<SqlParameter> listaParametros = new List<SqlParameter>();
                BaseDeDatos.agregarParametro(listaParametros, "@CodVisibilidad", lstVisibilidades.SelectedValue);
                int resultado = BaseDeDatos.ejecutarSP("sp_EliminarVisibilidad", listaParametros);
                BaseDeDatos.cerrarConexion();

                if (resultado == 1)
                    Interfaz.Interfaz.emitirAviso("Visibilidad dada de baja correctamente");
            }
            else {
                Interfaz.Interfaz.emitirAviso("Seleccione una opcion");
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
