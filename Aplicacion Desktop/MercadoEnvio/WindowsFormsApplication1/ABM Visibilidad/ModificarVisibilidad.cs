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
    public partial class ModificarVisibilidad : Form
    {
        private String codVisibilidad;
        private String nombreVisibilidad;
        public ModificarVisibilidad(String codigoVisibilidad)
        {
            
            InitializeComponent();
            CenterToParent();
            this.codVisibilidad = codigoVisibilidad;
            this.llenarVista(codigoVisibilidad);
            this.nombreVisibilidad = tbNombreVisibilidad.Text;
        }


        public void llenarVista(String codigoVisibilidad)
        {



            String query = "";
            SqlDataReader lector;
            query = "SELECT * from LOS_INSISTENTES.VisibilidadesTabla where Cod_Visibilidad = " + codigoVisibilidad;
            lector = BaseDeDatos.ejecutarReader(query, null, BaseDeDatos.iniciarConexion());
            lector.Read();
            tbNombreVisibilidad.Text = Convert.ToString(lector["Descripcion"]);
            txbCostoPublicacion.Text = Convert.ToString(lector["Costo_Publicacion"]);
            txbComisionEnvio.Text = Convert.ToString(lector["Comision_Envio"]);
            txbComisionVenta.Text = Convert.ToString(lector["Comision_Venta"]);

            if (Convert.ToInt32(lector["Habilitada"]) == 1)
            {
                chbHabilitado.Checked = true;
            }

            if (Convert.ToInt32(lector["Permite_Envios"]) == 1)
            {
                cbEnvio.Checked = true;
            }

            BaseDeDatos.cerrarConexion();
        }
        private bool chequearCampos()
        {
            if (tbNombreVisibilidad.Text.Equals(""))
            {
                Interfaz.Interfaz.emitirAviso("Ingrese  un nombre para la visibilidad ");
                return false;
            }

            if (BaseDeDatos.existeString(tbNombreVisibilidad.Text, "LOS_INSISTENTES.VisibilidadesTabla", "Descripcion") && !tbNombreVisibilidad.Text.Equals(nombreVisibilidad))
            {
                Interfaz.Interfaz.emitirAviso("Ya existe una visibilidad con ese nombre");
                return false;
            }

            if (txbCostoPublicacion.Text.Equals(""))
            {
                Interfaz.Interfaz.emitirAviso("Ingrese  CostoPublicacion ");
                return false;
            }

            if (txbComisionVenta.Text.Equals(""))
            {
                Interfaz.Interfaz.emitirAviso("Ingrese  Comision venta ");
                return false;
            }

            if (Convert.ToDouble(txbComisionEnvio.Text) < 0 || Convert.ToDouble(txbComisionEnvio.Text) > 1)
            {
                Interfaz.Interfaz.emitirAviso("La comision de Envio ser un valor entre 0 y 1");
                return false;
            }

            if (txbComisionEnvio.Text.Equals(""))
            {
                Interfaz.Interfaz.emitirAviso("Ingrese  Comision envio ");
                return false;
            }

            if (Convert.ToDouble(txbComisionVenta.Text) < 0 || Convert.ToDouble(txbComisionVenta.Text) > 1)
            {
                Interfaz.Interfaz.emitirAviso("La comision de venta ser un valor entre 0 y 1");
                return false;
            }

            return true;
        }

        private void agregarVisibilidad_Click(object sender, EventArgs e)
        {
            if (this.chequearCampos())
            {
                List<SqlParameter> listaParametros = new List<SqlParameter>();
                BaseDeDatos.agregarParametro(listaParametros, "@codVisibilidad", this.codVisibilidad);
                BaseDeDatos.agregarParametro(listaParametros, "@descripcion", tbNombreVisibilidad.Text);
                BaseDeDatos.agregarParametro(listaParametros, "@costoPublicacion", Convert.ToDouble(txbCostoPublicacion.Text));
                BaseDeDatos.agregarParametro(listaParametros, "@comisionEnvio", Convert.ToDouble(txbComisionEnvio.Text));
                BaseDeDatos.agregarParametro(listaParametros, "@comisionVenta", Convert.ToDouble(txbComisionVenta.Text));
                BaseDeDatos.agregarParametro(listaParametros, "@habilitada", Convert.ToInt32(chbHabilitado.Checked));
                BaseDeDatos.agregarParametro(listaParametros, "@permiteEnvio", Convert.ToInt32(cbEnvio.Checked));
                BaseDeDatos.ejecutarSP("sp_ModificarVisibilidad", listaParametros);
                BaseDeDatos.cerrarConexion();
                Interfaz.Interfaz.emitirAviso("Visibilidad modificada correctamente");
            }

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ABM_Visibilidad.ABMVisibilidad form = new ABM_Visibilidad.ABMVisibilidad();
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
        }

        private void txbCostoPublicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e, true);
        }

        private void txbComisionEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e, true);
        }

        private void txbComisionVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e, true);
        }
    }
}
