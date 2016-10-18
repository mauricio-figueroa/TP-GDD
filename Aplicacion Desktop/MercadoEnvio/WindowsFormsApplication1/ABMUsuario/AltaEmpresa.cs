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
using System.Security.Cryptography;
using LOS_INSISTENTES.Clases;


namespace LOS_INSISTENTES.ABMUsuario
{
    public partial class AltaEmpresa : Form
    {
        public string username { get; set; }
        public string password { get; set; }
        public string accion { get; set; }

        Interfaz.Interfaz interfaz = new Interfaz.Interfaz();

        public AltaEmpresa(String user,String pass, String accion)
        {
            this.username = user;
            this.password = pass;
            this.accion = accion;
            InitializeComponent();
            interfaz.cargarComboIDValor(lstRubro, "SELECT ID_Rubro AS id, Descripcion as valor FROM LOS_INSISTENTES.Rubros ORDER BY Descripcion;");

            if (accion.Equals("modificar"))
            {
                cargarVistaModificar();
                btnRegistrar.Text = "Modificar";
                this.Text = "Modificar empresa";
            }
        }

        public void cargarVistaModificar()
        {
            String query = "select * from LOS_INSISTENTES.Empresas where ID_User = " + this.username;
            SqlDataReader lector = BaseDeDatos.ejecutarReader(query, null, BaseDeDatos.iniciarConexion());
            lector.Read();

            tRazonSocial.Text = Convert.ToString(lector["Razon_Social"]);
            tCuit.Text = Convert.ToString(lector["CUIT"]);
            tTelefono.Text = Convert.ToString(lector["Telefono"]);
            tDireccion.Text = Convert.ToString(lector["Direccion"]);
            tCodigoPostal.Text = Convert.ToString(lector["Codigo_Postal"]);
            tCiudad.Text = Convert.ToString(lector["Ciudad"]);
            tMail.Text = Convert.ToString(lector["Mail"]);
            tNombreDeContacto.Text = Convert.ToString(lector["Nombre_Contacto"]);

            lstRubro.SelectedValue = Convert.ToInt32(lector["ID_Rubro_Principal"]);
            BaseDeDatos.cerrarConexion();
        }

        private void ModificarEmpresa()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", this.username);

            BaseDeDatos.agregarParametro(listaParametros, "@razonSocial", this.tRazonSocial.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@cuit", this.tCuit.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@telefono", this.tTelefono.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@direccion", this.tDireccion.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@ciudad", this.tCiudad.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@codigoPostal", this.tCodigoPostal.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@mail", this.tMail.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@nombreContacto", this.tNombreDeContacto.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@idRubro", this.lstRubro.SelectedValue);

            int resultado = BaseDeDatos.ejecutarSP("sp_ModificarEmpresa", listaParametros);

            if (resultado == 1)
                Interfaz.Interfaz.emitirAviso("Empresa modificada con éxito.");
            else
                Interfaz.Interfaz.emitirAviso("Ya existe una empresa con ese CUIT y Razón Social.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Interfaz.Interfaz.limpiarInterfaz(this);
        }

        //Chequeo que los campos obligatorios sean ingresados
        public bool chequearCampos()
        {
            if (tRazonSocial.Text.Equals(""))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese la razón social.");

            if (!Interfaz.Interfaz.testEmail(tMail.Text))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese un correo válido.");

            if (tTelefono.Text.Equals(""))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese el teléfono.");

            if (tDireccion.Text.Equals(""))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese la dirección.");

            if (tCodigoPostal.Text.Equals("") || tCodigoPostal.TextLength < 4)
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese un código postal válido.");

            if (tCiudad.Text.Equals(""))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese la ciudad.");

            if (tCuit.Text.Equals("") || tCuit.TextLength < 11)
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese un CUIT válido.");

            if (tNombreDeContacto.Text.Equals(""))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese el nombre de contacto.");

            if (Convert.ToInt32(lstRubro.SelectedValue) == -1)
                return Interfaz.Interfaz.emitirAviso("Por favor seleccione el rubro.");

            return true;
        }

        public void cargaEmpresaEnBaseDeDatos()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@username", this.username);
            BaseDeDatos.agregarParametro(listaParametros, "@password", this.password);

            BaseDeDatos.agregarParametro(listaParametros, "@razonSocial", this.tRazonSocial.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@cuit", this.tCuit.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@telefono", this.tTelefono.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@direccion", this.tDireccion.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@ciudad", this.tCiudad.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@codigoPostal", this.tCodigoPostal.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@mail", this.tMail.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@nombreContacto", this.tNombreDeContacto.Text);
            
            BaseDeDatos.agregarParametro(listaParametros, "@idRubro", this.lstRubro.SelectedValue);
            BaseDeDatos.agregarParametroRetorno(listaParametros, "@retorno", -200);
            
            int resultado = BaseDeDatos.ejecutarSP("sp_AgregarEmpresa", listaParametros);
            string mensaje = "";

            switch (resultado)
            {
                case 0:
                    mensaje = "Empresa agregada exitosamente";
                    break;
                case -1:
                    mensaje = "El Usuario ya existe";
                    break;
                case -2:
                    mensaje = "La Empresa ya existe";
                    break;
                case -10:
                    mensaje = "Excepción de base de datos, revisar";
                    break;
            }

            Interfaz.Interfaz.emitirAviso(mensaje);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (chequearCampos())
            {
                if (accion.Equals("alta"))
                    cargaEmpresaEnBaseDeDatos();
                else if (accion.Equals("modificar"))
                    ModificarEmpresa();

                DialogResult = DialogResult.OK;
            }
        }

        private void tCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e);
        }

        private void tCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e);
        }

        private void tTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e);
        }
    }
}
