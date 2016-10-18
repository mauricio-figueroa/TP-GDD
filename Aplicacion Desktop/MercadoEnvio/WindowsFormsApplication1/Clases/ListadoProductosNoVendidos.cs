using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LOS_INSISTENTES.Clases
{
    public static class ListadoProductosNoVendidos
    {
        /*
        public string nombreVendedor { get; set; }
        public string DescripcionPublicacion { get; set; }
        public string DescripcionVisibilidad { get; set; }
        public int Stock { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }

        public ListadoProductosNoVendidos (string nombreVendedor, string DescripcionPublicacion, string DescripcionVisibilidad, int Stock, int Mes, int Anio)
        {
            this.nombreVendedor = nombreVendedor;
            this.DescripcionPublicacion = DescripcionPublicacion;
            this.DescripcionVisibilidad = DescripcionVisibilidad;
            this.Stock = Stock;
            this.Mes = Mes;
            this.Anio = Anio;
        }
         */

        public static DataTable obtenerListado(string visibilidad, int mes, int anio)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@DescripcionVisibilidad", visibilidad);
            BaseDeDatos.agregarParametro(listaParametros, "@mes", mes);
            BaseDeDatos.agregarParametro(listaParametros, "@anio", anio);

            String commandtext = "SELECT TOP 5 * FROM LOS_INSISTENTES.vw_ProductosNoVendidos WHERE " +
                                 "DescripcionVisibilidad = 'Bronce' AND Mes = 1 AND Año = 2015 " +
                                 "ORDER BY Stock DESC;";

            return BaseDeDatos.obtenerDataTable(commandtext, "T", listaParametros);
        }
    }
}
