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

namespace LOS_INSISTENTES.Comprar_Ofertar
{
    public partial class DetalleCompra : Form
    {
        Interfaz.Interfaz interfaz = new Interfaz.Interfaz();

        public Clases.Comprar compra { get; set; }
        public int idComprador { get; set; }

        public DetalleCompra(int idComprador, Clases.Comprar compra)
        {
            InitializeComponent();
            this.CenterToScreen();

            this.idComprador = idComprador;
            this.compra = compra;

            string lblCompra = "";

            if (!compra.Permite_Envios)
                chkEnvio.Checked = false;
            else
                chkEnvio.Checked = true;

            chkEnvio.Enabled = false;

            if (compra.Tipo == "Subasta")
            {
                this.Text = "Ofertar";
                lblCompra = "Usted está ofertando " + compra.Descripcion;
                lblStock.Text = "La oferta será por todo el stock: " + compra.Stock.ToString();
                lblCantidad.Text = "Monto: ($)";
                lblSubastaMinimo.Text = "Esta subasta tiene un monto\nmínimo de $" + Convert.ToString(compra.MontoCompra);
            }
            else
            {
                lblSubastaMinimo.Text = "";
                this.Text = "Comprar";
                lblStock.Text = "de " + compra.Stock.ToString();
                lblCompra = "Usted está comprando " + compra.Descripcion;
            }

            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@codPublicacion", compra.Cod_Publicacion);
            SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT convert(varchar(25), Fecha_Vencimiento, 103) as Fecha FROM LOS_INSISTENTES.Publicaciones WHERE Cod_Publicacion = @codPublicacion", listaParametros, BaseDeDatos.iniciarConexion());

            lblFinaliza.Text = "";

            if (lector.Read())
                lblFinaliza.Text = "Finaliza el " + lector["Fecha"].ToString();

            BaseDeDatos.cerrarConexion();

            lblPregunta.Text = lblCompra;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (compra.Tipo == "Subasta")
            {
                if (tCantidad.Text.Equals("") || Convert.ToInt32(tCantidad.Text) <= 0)
                {
                    Interfaz.Interfaz.emitirAviso("Por favor ingrese el monto de la oferta.");
                    return;
                }

                if (Convert.ToDouble(tCantidad.Text) <= compra.MontoCompra)
                {
                    Interfaz.Interfaz.emitirAviso("El monto mínimo de la subasta es de $" + Convert.ToString(compra.MontoCompra));
                    return;
                }

                if (Interfaz.Interfaz.emitirPregunta("¿Seguro desea ofertar el lote de " + compra.Stock + " " + compra.Descripcion + " por un monto de $" + tCantidad.Text + "?") != DialogResult.Yes)
                    return;

                double montoCompra = compra.MontoCompra;
                DateTime fechaOferta = Interfaz.Interfaz.fechaSistema;

                List<SqlParameter> listaParametros = new List<SqlParameter>();
                BaseDeDatos.agregarParametro(listaParametros, "@idComprador", idComprador);
                BaseDeDatos.agregarParametro(listaParametros, "@codPublicacion", compra.Cod_Publicacion);
                BaseDeDatos.agregarParametro(listaParametros, "@fechaOferta", fechaOferta);
                BaseDeDatos.agregarParametro(listaParametros, "@montoOferta", Convert.ToDouble(tCantidad.Text));
                BaseDeDatos.agregarParametro(listaParametros, "@conEnvio", Convert.ToInt32(chkEnvio.Checked));

                BaseDeDatos.ejecutarSP("sp_InsertarOferta", listaParametros);

                Interfaz.Interfaz.emitirAviso("Oferta agregada con éxito, se enterará si ganó al finalizar la subasta");

            } else {

                if (tCantidad.Text.Equals("") || Convert.ToInt32(tCantidad.Text) <= 0)
                {
                    Interfaz.Interfaz.emitirAviso("Por favor ingrese la cantidad que desea comprar.");
                    return;
                }

                if (Convert.ToInt32(tCantidad.Text) > compra.Stock)
                {
                    Interfaz.Interfaz.emitirAviso("No puede comprar más de " + compra.Stock.ToString() + " de productos.");
                    return;
                }

                if (Interfaz.Interfaz.emitirPregunta("¿Seguro desea comprar " + tCantidad.Text + " unidad(es) del producto " + compra.Descripcion + "?") != DialogResult.Yes)
                    return;

                double montoCompra = this.compra.MontoCompra * Convert.ToInt32(tCantidad.Text);
                DateTime fechaOferta = Interfaz.Interfaz.fechaSistema;

                List<SqlParameter> listaParametros = new List<SqlParameter>();
                BaseDeDatos.agregarParametro(listaParametros, "@idComprador", this.idComprador);
                BaseDeDatos.agregarParametro(listaParametros, "@codPublicacion", this.compra.Cod_Publicacion);
                BaseDeDatos.agregarParametro(listaParametros, "@montoCompra", montoCompra);
                BaseDeDatos.agregarParametro(listaParametros, "@fechaOferta", fechaOferta);
                BaseDeDatos.agregarParametro(listaParametros, "@conEnvio", Convert.ToInt32(chkEnvio.Checked));

                BaseDeDatos.agregarParametroRetorno(listaParametros, "@retorno", -200);

                int nroFactura = BaseDeDatos.ejecutarSP("sp_ComprarProducto", listaParametros);

                Interfaz.Interfaz.emitirAviso("Compra realizada con éxito.");

                // Facturas.DetalleFactura detalleFactura = new Facturas.DetalleFactura(nroFactura);
                // detalleFactura.ShowDialog();
            }
            this.Focus();
        }

        private void chkEnvio_Click(object sender, EventArgs e)
        {
            Interfaz.Interfaz.emitirAviso("El envío es obligatorio para este producto");
        }

        private void tCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e);
        }

    }
}
