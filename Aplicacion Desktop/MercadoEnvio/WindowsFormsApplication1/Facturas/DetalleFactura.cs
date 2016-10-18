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

namespace LOS_INSISTENTES.Facturas
{
    public partial class DetalleFactura : Form
    {
        public int nroFactura { get; set; }

        public int idUser = Interfaz.Interfaz.usuario.ID_User;

        public DetalleFactura(int nroFactura)
        {
            this.nroFactura = nroFactura;
            InitializeComponent();

            CenterToScreen();

            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", idUser);
            SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT Razon_Social, CUIT FROM LOS_INSISTENTES.Empresas WHERE ID_User = @ID_User", listaParametros, BaseDeDatos.iniciarConexion());

            if (lector.Read())
            {
                tNombre.Text = Convert.ToString(lector["Razon_Social"]);
                tCUIT.Text = Convert.ToString(lector["CUIT"]);
            }

            BaseDeDatos.cerrarConexion();

            // Datos del vendedor

            listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@nroFactura", nroFactura);
            lector = BaseDeDatos.ejecutarReader("SELECT Nro_Factura, Forma_Pago, Total_Facturacion, convert(varchar(25), Factura_Fecha, 103) as Factura_Fecha FROM LOS_INSISTENTES.Facturas WHERE Nro_Factura = @nroFactura", listaParametros, BaseDeDatos.iniciarConexion());

            if (lector.Read())
            {
                // Datos de la factura
                tNumero.Text = Convert.ToString(lector["Nro_Factura"]);
                tFormaPago.Text = Convert.ToString(lector["Forma_Pago"]);
                tTotal.Text = "$ " + Convert.ToString(lector["Total_Facturacion"]);
                tFecha.Text = Convert.ToString(lector["Factura_Fecha"]);
            }

            BaseDeDatos.cerrarConexion();

            listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@nroFactura", nroFactura);
            lector = BaseDeDatos.ejecutarReader("SELECT * FROM LOS_INSISTENTES.Item_Factura WHERE Nro_Factura = @nroFactura ORDER BY Concepto", listaParametros, BaseDeDatos.iniciarConexion());

            tItems.Text = "";

            int codPublicacion = 0;

            while (lector.Read())
            {
                string concepto = Convert.ToString(lector["Concepto"]);
                string monto = Convert.ToString(lector["Item_Monto"]);
                string cantidad = Convert.ToString(lector["Item_Cantidad"]);
                codPublicacion = Convert.ToInt32(lector["Cod_Publicacion"]);

                tItems.Text += cantidad + "\t" + concepto + "\t";
                if (concepto.Length < 20)
                    tItems.Text += "\t\t\t\t\t";
                else if (concepto.Length < 30)
                    tItems.Text += "\t\t\t";
                else if (concepto.Length < 40)
                    tItems.Text += "\t\t";

                tItems.Text += "$ " + monto + "\n";
            }

            BaseDeDatos.cerrarConexion();

            if (codPublicacion != 0)
            {
                listaParametros = new List<SqlParameter>();
                BaseDeDatos.agregarParametro(listaParametros, "@codPublicacion", codPublicacion);
                lector = BaseDeDatos.ejecutarReader("SELECT * FROM LOS_INSISTENTES.Publicaciones WHERE Cod_Publicacion = @codPublicacion", listaParametros, BaseDeDatos.iniciarConexion());

                if (lector.Read())
                {
                    string descripcion = Convert.ToString(lector["Descripcion"]);
                    string precio = Convert.ToString(lector["Precio"]);

                    tPrecio.Text = precio;
                    tDescripcion.Text = descripcion;
                }
                BaseDeDatos.cerrarConexion();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
