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
    public partial class AltaVisibilidad : Form
    {
        public AltaVisibilidad()
        {
            InitializeComponent();
            CenterToParent();
        }
        private bool chequearCampos() {
            if (tbNombreVisibilidad.Text.Equals("")) {
                Interfaz.Interfaz.emitirAviso("Ingrese  un nombre para la visibilidad "); 
                    return false;
            }

            if (BaseDeDatos.existeString(tbNombreVisibilidad.Text, "LOS_INSISTENTES.VisibilidadesTabla", "Descripcion"))
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

        private void txbComisionVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e, true);
        }

        private void txbComisionEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e, true);
        }

        private void txbCostoPublicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e, true);
        }

        private void agregarVisibilidad_Click(object sender, EventArgs e)
        {
            if (this.chequearCampos()) { 
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@descripcion", tbNombreVisibilidad.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@costoPublicacion", Convert.ToDouble(txbCostoPublicacion.Text));
            BaseDeDatos.agregarParametro(listaParametros, "@comisionEnvio", Convert.ToDouble(txbComisionEnvio.Text));
            BaseDeDatos.agregarParametro(listaParametros, "@comisionVenta", Convert.ToDouble(txbComisionVenta.Text));
            BaseDeDatos.agregarParametro(listaParametros, "@habilitada", Convert.ToInt32(chbHabilitado.Checked));
            BaseDeDatos.agregarParametro(listaParametros, "@permiteEnvio", Convert.ToInt32(cbEnvio.Checked));
            BaseDeDatos.agregarParametroRetorno(listaParametros, "@retorno", -200);
            BaseDeDatos.ejecutarSP("sp_AgregarVisibilidad", listaParametros);
            BaseDeDatos.cerrarConexion();
            Interfaz.Interfaz.emitirAviso("Visibilidad agregada correctamente");
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ABM_Visibilidad.ABMVisibilidad form = new ABM_Visibilidad.ABMVisibilidad();
            Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
            Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
        }

        private void txbCostoPublicacion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e, true);
        }

        private void txbComisionEnvio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e, true);
        }

        private void txbComisionVenta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e, true);
        }

        }


    }

