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
using System.Configuration;

namespace LOS_INSISTENTES.Generar_Publicación
{
    public partial class DetallePublicacion : Form
    {

        public int codPublicacion { get; set; }
        public string estado { get; set; }

        public SqlConnection conexion { get; set; }
        public string accion;

        Interfaz.Interfaz interfaz = new Interfaz.Interfaz();

        public int idUser = Interfaz.Interfaz.usuario.ID_User;
        public int publiGratuitas = Interfaz.Interfaz.usuario.publicacionesGratuitas();

        public DetallePublicacion(int codPublicacion, string accion, string estado = "")
        {
            this.codPublicacion = codPublicacion;
            this.estado = estado;
            this.accion=accion;
            InitializeComponent();

            dtFechaVencimiento.Value = Interfaz.Interfaz.fechaSistema.AddDays(+1);

            // 28/06/2016 cambio la forma en que maneja las publicaciones gratuitas
            // string condicion = "";
            // if (publiGratuitas == 0)
            //    condicion = " WHERE Cod_Visibilidad != 4";

            // Si está activa no puede pasar a estado borrador
            string estadosOmitidos = "";
            if (estado == "Activa")
                estadosOmitidos += ",0";

            if (accion == "agregar")
                estadosOmitidos += ",3";


            this.CenterToScreen();

            interfaz.cargarComboIDValor(lstEstado, "SELECT Cod_EstadoPublicacion AS id, Descripcion as valor FROM LOS_INSISTENTES.Estados_Publicacion WHERE Cod_EstadoPublicacion NOT IN (-200" + estadosOmitidos + ") ORDER BY Descripcion;");
            interfaz.cargarComboIDValor(lstRubro, "SELECT ID_Rubro AS id, Descripcion as valor FROM LOS_INSISTENTES.Rubros ORDER BY Descripcion;");
            interfaz.cargarComboIDValor(lstTipo, "SELECT Cod_TipoPublicacion AS id, Descripcion as valor FROM LOS_INSISTENTES.Tipos_Publicacion ORDER BY Descripcion;");
            interfaz.cargarComboIDValor(lstVisibilidad, "SELECT Cod_Visibilidad AS id, Descripcion+ ' ($ ' + CONVERT(nvarchar(55),Costo_Publicacion) + ')'  as valor FROM LOS_INSISTENTES.Visibilidades ORDER BY Descripcion;");

            switch (accion)
            {
                default:
                case "ver":
                    lblMontoMinimo.Text = "Finalizo \n Subasta \n en ($):";
                    this.cargarVistaModificar();
                    estadoCampos(false);
                    break;
                case "agregar":
                    estadoCampos(true);
                    break;
                case "modificar":
                    this.cargarVistaModificar();
                    estadoCampos(true);
                    this.lstVisibilidad.Enabled = false;
                    this.lstTipo.Enabled = false;
                    break;
            }
        }

        public void cargarVistaModificar() {

            String query = "select * from LOS_INSISTENTES.Publicaciones where Cod_Publicacion=" +this.codPublicacion;
            SqlDataReader lector = BaseDeDatos.ejecutarReader(query, null, BaseDeDatos.iniciarConexion());
            lector.Read();

            tDescripcion.Text =Convert.ToString(lector["Descripcion"]);
            String prueba = Convert.ToString(lector["Descripcion"]);
            tStock.Text = Convert.ToString(lector["Stock"]);
            tPrecio.Text = Convert.ToString(lector["Precio"]);
            montoMinimo.Text = Convert.ToString(lector["Monto_Minimo"]);
            

            lstEstado.SelectedValue = Convert.ToInt32(lector["Cod_EstadoPublicacion"]);
            lstRubro.SelectedValue = Convert.ToInt32(lector["ID_Rubro"]);
            lstTipo.SelectedValue = Convert.ToInt32(lector["Cod_TipoPublicacion"]);

            int codVisibilidad = Convert.ToInt32(lector["Cod_Visibilidad"]);
          
            BaseDeDatos.cerrarConexion();
            lstVisibilidad.SelectedValue = codVisibilidad;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

      
        private void btnAccion_Click(object sender, EventArgs e)
        {
            switch (accion)
            {
                default:
                case "ver":
                    estadoCampos(false);
                    lblMontoMinimo.Text = "Finalizo Subasta en ($):";
                    break;
                case "agregar":
                    if (chequearCampos())
                        this.agregarNuevaPublicacion();
                    break;
                case "modificar":
                    if (chequearCampos())
                        this.modificarPublicacion();
                    break;
            }
      }

        public bool chequearCampos()
        {
            if (tDescripcion.Text.Equals(""))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese la descripción de la publicación.");

            if (tStock.Text.Equals(""))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese el stock la publicación.");

            if (Convert.ToInt32(tStock.Text) <= 0)
                return Interfaz.Interfaz.emitirAviso("El stock debe ser mayor a cero.");

            if (Convert.ToInt32(lstRubro.SelectedValue) == -1)
                return Interfaz.Interfaz.emitirAviso("Por favor seleccione el rubro de la publicación.");

            if (Convert.ToInt32(lstVisibilidad.SelectedValue) == -1)
                return Interfaz.Interfaz.emitirAviso("Por favor seleccione la visibilidad de la publicación.");

            if (Convert.ToInt32(lstEstado.SelectedValue) == -1)
                return Interfaz.Interfaz.emitirAviso("Por favor seleccione el estado de la publicación.");

            if (Convert.ToInt32(lstTipo.SelectedValue) == -1)
                return Interfaz.Interfaz.emitirAviso("Por favor seleccione el tipo de la publicación.");
            // Subasta
            if (montoMinimo.Text.Equals("") && montoMinimo.Visible)
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese el monto mínimo de la subasta.");

            if (Convert.ToDouble(montoMinimo.Text) <= 0 && montoMinimo.Visible)
                return Interfaz.Interfaz.emitirAviso("El monto mínimo debe ser mayor a cero.");

            // Compra inmediata
            if (tPrecio.Text.Equals("") && tPrecio.Visible)
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese el precio de la publicación.");

            if (Convert.ToDouble(tPrecio.Text) <= 0 && tPrecio.Visible)
                return Interfaz.Interfaz.emitirAviso("El precio debe ser mayor a cero.");

            if (dtFechaVencimiento.Value <= Interfaz.Interfaz.fechaSistema)
                return Interfaz.Interfaz.emitirAviso("La fecha de vencimiento debe ser mayor a la de hoy.");

            return true;
        }

        public void modificarPublicacion()
        {
            List<SqlParameter> listaDePArametrosParaModificarPubliacion = new List<SqlParameter>();


            BaseDeDatos.agregarParametro(listaDePArametrosParaModificarPubliacion, "@codVisibilidad", lstVisibilidad.SelectedValue);
            BaseDeDatos.agregarParametro(listaDePArametrosParaModificarPubliacion, "@codPublicacion", codPublicacion);
            BaseDeDatos.agregarParametro(listaDePArametrosParaModificarPubliacion, "@estadoPubl", lstEstado.SelectedValue);
            BaseDeDatos.agregarParametro(listaDePArametrosParaModificarPubliacion, "@tipoPubl", lstTipo.SelectedValue);
            BaseDeDatos.agregarParametro(listaDePArametrosParaModificarPubliacion, "@idRubro", lstRubro.SelectedValue);
            BaseDeDatos.agregarParametro(listaDePArametrosParaModificarPubliacion, "@descripcion", tDescripcion.Text);
            BaseDeDatos.agregarParametro(listaDePArametrosParaModificarPubliacion, "@stock", Convert.ToInt32(this.tStock.Text));
            BaseDeDatos.agregarParametro(listaDePArametrosParaModificarPubliacion, "@fechaVenc", dtFechaVencimiento.Text);
            BaseDeDatos.agregarParametro(listaDePArametrosParaModificarPubliacion, "@fechaInic", Interfaz.Interfaz.fechaSistema);
            //BaseDeDatos.agregarParametro(listaDePArametrosParaModificarPubliacion, "@precio", Convert.ToDouble(tPrecio.Text));
            BaseDeDatos.agregarParametro(listaDePArametrosParaModificarPubliacion, "@precio", Convert.ToDouble(montoMinimo.Text));
            BaseDeDatos.agregarParametro(listaDePArametrosParaModificarPubliacion, "@montoMinimo", Convert.ToDouble(montoMinimo.Text));
            BaseDeDatos.agregarParametro(listaDePArametrosParaModificarPubliacion, "@permiteEnvio", chkEnvios.Checked);

            BaseDeDatos.agregarParametroRetorno(listaDePArametrosParaModificarPubliacion, "@retorno", -1);

            BaseDeDatos.ejecutarSP("sp_ModificarPublicacion", listaDePArametrosParaModificarPubliacion);

            Interfaz.Interfaz.emitirAviso("Publicación #" + codPublicacion.ToString() + " modificada exitosamente.");

            if (Convert.ToInt32(lstEstado.SelectedValue) == 1)
                mostrarFactura(codPublicacion);

            DialogResult = DialogResult.OK;
        }

        public void agregarNuevaPublicacion() {

            List<SqlParameter> listaPArametrosAltaPublicacion = new List<SqlParameter>();

            BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@fechaInic", Interfaz.Interfaz.fechaSistema);
            BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@codVisibilidad", lstVisibilidad.SelectedValue);
            BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@estadoPubl", lstEstado.SelectedValue);
            BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@tipoPubl", lstTipo.SelectedValue);
            BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@idVendedor", Interfaz.Interfaz.usuario.ID_User);
            BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@idRubro", lstRubro.SelectedValue);
            BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@descripcion", tDescripcion.Text);
            BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@stock", Convert.ToInt32(this.tStock.Text));
            BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@fechaVenc", dtFechaVencimiento.Text);
            BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@precio", Convert.ToDouble(this.tPrecio.Text));

            double monto = 0;
            if (Convert.ToInt32(lstTipo.SelectedValue) == 0 && montoMinimo.Text != "")
            {
                monto = Convert.ToDouble(montoMinimo.Text);
                BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@MontoMinimo", monto);
            }
            else
            {
                BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@MontoMinimo", 0);
            }

            if (this.chkEnvios.Checked)
            {
                BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@permiteEnvio", 1);
            }
            else
            {
                BaseDeDatos.agregarParametro(listaPArametrosAltaPublicacion, "@permiteEnvio", 0);
            }
            BaseDeDatos.agregarParametroRetorno(listaPArametrosAltaPublicacion, "@retorno", -1);
            int retorno = BaseDeDatos.ejecutarSP("sp_AgregarPublicacion", listaPArametrosAltaPublicacion);

            Interfaz.Interfaz.emitirAviso("Publicación #" + retorno.ToString() + " agregada exitosamente.");

            if (Convert.ToInt32(lstEstado.SelectedValue) == 1)
                mostrarFactura(retorno);

            DialogResult = DialogResult.OK;
        }
     
        public void estadoCampos(bool estado)
        {
            btnAccion.Visible = estado;
            montoMinimo.Enabled = estado;
            chkEnvios.Enabled = estado;
            tDescripcion.Enabled = estado;
            tStock.Enabled = estado;
            tPrecio.Enabled = estado;            
            dtFechaVencimiento.Enabled = estado;
            lstEstado.Enabled = estado;
            lstRubro.Enabled = estado;
            lstTipo.Enabled = estado;
            lstVisibilidad.Enabled = estado;
            //this.verificarCheckPermiteEnvios();
        }

        private void lstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            montoMinimo.Visible = false;
            lblMontoMinimo.Visible = false;
            tPrecio.Visible = false;
            lblPrecio.Visible = false;

            if (Convert.ToInt32(lstTipo.SelectedValue) == 0)
            {
                montoMinimo.Visible = true;
                lblMontoMinimo.Visible = true;
            }
            else if (Convert.ToInt32(lstTipo.SelectedValue) == 1)
            {
                tPrecio.Visible = true;
                lblPrecio.Visible = true;
            }
        }

        private void lstVisibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.verificarCheckPermiteEnvios();
        }

        private void verificarCheckPermiteEnvios()
        {
            chkEnvios.Enabled = Clases.Visibilidad.permiteEnvio(Convert.ToInt32(lstVisibilidad.SelectedValue));
            chkEnvios.Checked = chkEnvios.Enabled;
        }

        private void tStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e);
        }

        private void tPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e, true);
        }

        private void montoMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e, true);
        }

        public static void mostrarFactura(int retorno)
        {
            String query = "select Nro_Factura from LOS_INSISTENTES.Item_factura where Cod_Publicacion=" + retorno.ToString();
            SqlDataReader lector = BaseDeDatos.ejecutarReader(query, null, BaseDeDatos.iniciarConexion());
            if (lector.HasRows) {

                lector.Read();

                int nroFactura = Convert.ToInt32(lector["Nro_Factura"]);

                BaseDeDatos.cerrarConexion();

                Facturas.DetalleFactura formFactura = new Facturas.DetalleFactura(nroFactura);
                BaseDeDatos.cerrarConexion();
                formFactura.ShowDialog();
            }
        }

        private void montoMinimo_TextChanged(object sender, EventArgs e)
        {
            if (accion != "ver" && !montoMinimo.Text.Equals("0,00"))
                tPrecio.Text = montoMinimo.Text;
        }

        private void tPrecio_TextChanged(object sender, EventArgs e)
        {
            if (accion != "ver" && !tPrecio.Text.Equals("0,00"))
                montoMinimo.Text = tPrecio.Text;
        }
    }
}
