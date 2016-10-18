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
using LOS_INSISTENTES.Interfaz;

namespace LOS_INSISTENTES.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {

        Interfaz.Interfaz interfaz = new Interfaz.Interfaz();

        int cantidadTop = Convert.ToInt32(Interfaz.Interfaz.obtenerConfiguracion("CantidadTop"));

        public ListadoEstadistico()
        {
            InitializeComponent();
            CenterToParent();

            this.lstMes.Enabled = false;
            lblVisibilidadORubro.Visible = false;
            lstVisibilidadORubro.Visible = false;
            this.lstListado.Enabled = false;
            this.lstTrimestre.Enabled = false;

            this.tAnio.MaxLength = 4;

            // Cargo combo trimestre
            this.lstTrimestre.Items.Add(1);
            this.lstTrimestre.Items.Add(2);
            this.lstTrimestre.Items.Add(3);
            this.lstTrimestre.Items.Add(4);

            // Cargando Combo de tipos de listados
            this.lstListado.Items.Add("Vendedores con mayor cantidad de productos no vendidos");
            this.lstListado.Items.Add("Clientes con mayor cantidad de productos comprados");
            this.lstListado.Items.Add("Vendedores con mayor cantidad de facturas");
            this.lstListado.Items.Add("Vendedores con mayor monto facturado");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgTopFive.Columns.Clear();
            lblDetalle.Visible = false;
            if (chequearCampos())
            {
                string visibilidadORubro = lstVisibilidadORubro.Text;

                int mes = (lstTrimestre.SelectedIndex * 3) + lstMes.SelectedIndex + 1;
                int anio = Convert.ToInt32(tAnio.Text);

                string detalle = "";

                object datos = null;

                switch (lstListado.SelectedIndex)
                {
                    // Vendedores con mayor cantidad de productos no vendidos
                    case 0:
                        datos = this.obtenerListadoProductosNoVendidos(Convert.ToInt32(this.lstVisibilidadORubro.SelectedValue), mes, anio);
                        detalle = "Productos " + visibilidadORubro + " no vendidos en " + lstMes.Text + " del " + tAnio.Text;
                        break;
                    // Clientes con mayor cantidad de productos comprados
                    case 1:
                        datos = this.obtenerListadoProductosComprados(Convert.ToInt32(this.lstVisibilidadORubro.SelectedValue), mes, anio);
                        detalle = "Compras de " + lstVisibilidadORubro.Text + " en " + lstMes.Text + " del " + tAnio.Text;
                        break;
                    // Vendedores con mayor cantidad de facturas
                    case 2:
                        detalle = "Facturas emitidas en " + lstMes.Text + " del " + tAnio.Text;
                        datos = this.obtenerCantidadFacturas(mes, anio);
                        break;
                    case 3:
                        // Vendedores con mayor monto facturado
                        detalle = "Montos facturados en " + lstMes.Text + " del " + tAnio.Text;
                        datos = this.obtenerMontoFacturado(mes, anio);
                        break;
                }

                if (datos == null)
                    Interfaz.Interfaz.emitirAviso("No hay datos para mostrar con el filtro seleccionado.");
                else
                {
                    lblDetalle.Text = detalle;
                    lblDetalle.Show();
                    dgTopFive.DataSource = datos;
                    dgTopFive.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
                }
            }
        }

        private Boolean chequearCampos()
        {
            bool salida = true;

            if (interfaz.campoVacio(tAnio))
                salida = Interfaz.Interfaz.emitirAviso("Por favor, ingrese el año.");

            if (lstTrimestre.Enabled == true && interfaz.cboxVacio(lstTrimestre))
                salida = Interfaz.Interfaz.emitirAviso("Por favor, ingrese el trimestre.");

            if (lstListado.Enabled == true && interfaz.cboxVacio(lstListado))
                salida = Interfaz.Interfaz.emitirAviso("Por favor, seleccione el tipo de listado.");

            if (lstVisibilidadORubro.Visible == true && Convert.ToInt32(lstVisibilidadORubro.SelectedValue) == -1)
                salida = Interfaz.Interfaz.emitirAviso("Para el listado seleccionado debe seleccionar un " + lblVisibilidadORubro.Text);

            return salida;
        }


        private void lstTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstListado.Enabled = true;

            this.lstMes.Items.Clear();

            int primerMes = lstTrimestre.SelectedIndex * 3;

            this.lstMes.Items.Add(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(interfaz.monthNames[primerMes]));
            this.lstMes.Items.Add(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(interfaz.monthNames[primerMes + 1]));
            this.lstMes.Items.Add(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(interfaz.monthNames[primerMes + 2]));

            this.lstMes.SelectedIndex = 0;
        }

        private void tAnio_TextChanged(object sender, EventArgs e)
        {
            this.lstTrimestre.Enabled = true;
        }

        private void tAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e);
        }

        private void lstListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Acá defino qué query ejecutar y qué campos habilitar

            this.lstMes.Enabled = true;

            this.lstVisibilidadORubro.Enabled = true;
            this.lstVisibilidadORubro.Visible = true;
            this.lblVisibilidadORubro.Visible = true;

            string query = "";

            switch (lstListado.SelectedIndex)
            {
                // Vendedores con mayor cantidad de productos no vendidos
                case 0:
                        this.lblVisibilidadORubro.Text = "Visibilidad";
                        query = "SELECT Cod_Visibilidad as id, Descripcion as valor FROM LOS_INSISTENTES.Visibilidades ORDER BY Descripcion";
                        interfaz.cargarComboIDValor(lstVisibilidadORubro, query);
                        break;
                // Clientes con mayor cantidad de productos comprados
                case 1:
                        this.lblVisibilidadORubro.Text = "Rubro";
                        query = "SELECT ID_Rubro as id, Descripcion as valor FROM LOS_INSISTENTES.Rubros ORDER BY Descripcion";
                        interfaz.cargarComboIDValor(lstVisibilidadORubro, query);
                        break;
                // Vendedores con mayor cantidad de facturas
                case 2: 
                        this.lstVisibilidadORubro.Visible = false;
                        this.lblVisibilidadORubro.Visible = false;
                        this.lstVisibilidadORubro.Enabled = false;
                        break;
                // Vendedores con mayor monto facturado
                case 3:
                        this.lstVisibilidadORubro.Visible = false;
                        this.lblVisibilidadORubro.Visible = false;
                        this.lstVisibilidadORubro.Enabled = false;
                        break;
            }
        }

        private object obtenerListadoProductosNoVendidos(int codVisibilidad, int mes, int anio)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@Cod_Visibilidad", codVisibilidad);
            BaseDeDatos.agregarParametro(listaParametros, "@mes", mes);
            BaseDeDatos.agregarParametro(listaParametros, "@anio", anio);

            String commandtext = "SELECT TOP " + cantidadTop + " Vendedor, Publicacion, Stock FROM LOS_INSISTENTES.vw_ProductosNoVendidos WHERE " +
                                 "Cod_Visibilidad = @Cod_Visibilidad AND Mes = @mes AND Año = @anio " +
                                 "ORDER BY Stock DESC;";

            return BaseDeDatos.obtenerDataTable(commandtext, "T", listaParametros);
        }

        private object obtenerListadoProductosComprados(int idRubro, int mes, int anio)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_Rubro", idRubro);
            BaseDeDatos.agregarParametro(listaParametros, "@mes", mes);
            BaseDeDatos.agregarParametro(listaParametros, "@anio", anio);

            String commandtext = "SELECT TOP " + cantidadTop + " Comprador, Cantidad FROM LOS_INSISTENTES.vw_CantidadProductosComprados WHERE " +
                                 "ID_Rubro = @ID_Rubro AND Mes = @mes AND Año = @anio " +
                                 "ORDER BY Cantidad DESC;";

            return BaseDeDatos.obtenerDataTable(commandtext, "T", listaParametros);
        }

        private object obtenerCantidadFacturas(int mes, int anio)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@mes", mes);
            BaseDeDatos.agregarParametro(listaParametros, "@anio", anio);

            String commandtext = "SELECT TOP " + cantidadTop + " Vendedor, Cantidad FROM LOS_INSISTENTES.vw_CantidadFacturasPorMes WHERE " +
                                 "Mes = @mes AND Año = @anio " +
                                 "ORDER BY Cantidad DESC;";

            return BaseDeDatos.obtenerDataTable(commandtext, "T", listaParametros);
        }

        private object obtenerMontoFacturado(int mes, int anio)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@mes", mes);
            BaseDeDatos.agregarParametro(listaParametros, "@anio", anio);

            String commandtext = "SELECT TOP " + cantidadTop + " Vendedor, Total FROM LOS_INSISTENTES.vw_FacturacionTotalPorMes WHERE " +
                                 "Mes = @mes AND Año = @anio " +
                                 "ORDER BY Total DESC;";

            return BaseDeDatos.obtenerDataTable(commandtext, "T", listaParametros);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
