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
using LOS_INSISTENTES.Interfaz;
using LOS_INSISTENTES.Clases;

using System.Text.RegularExpressions;

namespace LOS_INSISTENTES.ABMUsuario
{
    public partial class AltaCliente : Form
    {
        public string username { get; set; }
        public string password { get; set; }

        public string accion { get; set; }

        public string rolAsignado { get; set; }

        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipoDeDocumento { get; set; }
        public string numeroDeDocumento { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public string codigoPostal { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaCreacion { get; set; }

        public AltaCliente(String user,String pass, String accion)
        {
            this.username = user;
            this.password = pass;
            this.accion = accion;
            InitializeComponent();

            if (accion.Equals("modificar"))
            {
                cargarVistaModificar();
                btnRegistrar.Text = "Modificar";
                this.Text = "Modificar cliente";
            }

            cbTipoDocumento.SelectedIndex = 4;
        }

        public void cargarVistaModificar()
        {
            String query = "SELECT * FROM LOS_INSISTENTES.Clientes WHERE ID_User=" + this.username;
            SqlDataReader lector = BaseDeDatos.ejecutarReader(query, null, BaseDeDatos.iniciarConexion());
            if (lector.Read())
            {

                tNombre.Text = Convert.ToString(lector["Nombre"]);
                tApellido.Text = Convert.ToString(lector["Apellido"]);
                tMail.Text = Convert.ToString(lector["Mail"]);
                cbTipoDocumento.Text = Convert.ToString(lector["tipo_doc"]);
                tNumeroDocumento.Text = Convert.ToString(lector["Num_Doc"]);
                tTelefono.Text = Convert.ToString(lector["Telefono"]);
                tDireccion.Text = Convert.ToString(lector["Direccion"]);
                tCodigoPostal.Text = Convert.ToString(lector["Codigo_Postal"]);

                dtFecha.Text = Convert.ToString(lector["Fecha_Nacimiento"]);

                this.username = this.username;
            }

            BaseDeDatos.cerrarConexion();
        }

        private void ModificarCliente()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", this.username);

            BaseDeDatos.agregarParametro(listaParametros, "@tipoDoc", this.cbTipoDocumento.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@numDoc", this.tNumeroDocumento.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@nombre", this.tNombre.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@apellido", this.tApellido.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@mail", this.tMail.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@telefono", this.tTelefono.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@direccion", this.tDireccion.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@codigoPostal", this.tCodigoPostal.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@fechaNac", DateTime.Now);

            int resultado = BaseDeDatos.ejecutarSP("sp_ModificarCliente", listaParametros);

            if (resultado == 1)
                Interfaz.Interfaz.emitirAviso("Cliente modificado exitosamente");
            else
                Interfaz.Interfaz.emitirAviso("Ya existe un cliente con el tipo y DNI " + tNumeroDocumento.Text + ".");
        }

        //Chequeo que los campos obligatorios sean ingresados
        public bool chequearCampos()
        {
            if (tNombre.Text.Equals(""))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese el nombre del cliente.");

            if (tApellido.Text.Equals(""))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese el apellido del cliente.");

            if (tNumeroDocumento.Text.Equals(""))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese el tipo y número de documento del cliente.");

            if (!Interfaz.Interfaz.testEmail(tMail.Text))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese un correo válido.");

            if (tTelefono.Text.Equals(""))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese el teléfono.");

            if (tDireccion.Text.Equals(""))
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese la dirección.");

            if (tCodigoPostal.Text.Equals("") || tCodigoPostal.TextLength < 4)
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese un código postal válido.");

            if (dtFecha.Value > Interfaz.Interfaz.fechaSistema)
                return Interfaz.Interfaz.emitirAviso("Por favor ingrese una fecha de nacimiento válida.");

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Interfaz.Interfaz.limpiarInterfaz(this);
        }

        public void cargarUsuarioEnBaseDeDatos() {

            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@username", this.username);
            BaseDeDatos.agregarParametro(listaParametros, "@password", this.password);

            BaseDeDatos.agregarParametro(listaParametros, "@tipoDoc", this.cbTipoDocumento.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@numDoc", this.tNumeroDocumento.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@nombre", this.tNombre.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@apellido", this.tApellido.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@mail", this.tMail.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@telefono", this.tTelefono.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@direccion", this.tDireccion.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@codigoPostal", this.tCodigoPostal.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@fechaNac", this.dtFecha.Value);
            BaseDeDatos.agregarParametro(listaParametros, "@fechaCreacion", Interfaz.Interfaz.fechaSistema);
            BaseDeDatos.agregarParametroRetorno(listaParametros, "@retorno", -200);

            int resultado = BaseDeDatos.ejecutarSP("sp_AgregarCliente", listaParametros);
            string mensaje = "";

            switch (resultado)
            {
                case 0:
                    mensaje = "Cliente agregado exitosamente";
                    break;
                case -1:
                    mensaje = "El usuario ya existe";
                    break;
                case -2:
                    mensaje = "El cliente ya existe";
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
                    cargarUsuarioEnBaseDeDatos();
                else if (accion.Equals("modificar"))
                    ModificarCliente();

                DialogResult = DialogResult.OK;
            }
        }

        public Boolean campoVacio(TextBox textbox)
        {
            return textbox.Text.Equals("");
        }

        private void tNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloLetras(e);
        }

        private void tApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloLetras(e);
        }

        private void cbTipoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e);
        }

        private void tCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e);
        }

        private void tNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e);
        }

        private void cbMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}