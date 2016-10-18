using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace LOS_INSISTENTES.Clases
{
    public class Factura
    {
        public int Nro_Factura { get; set; }
        public string Forma_Pago { get; set; }
        public double Total_Facturacion { get; set; }
        public DateTime Factura_Fecha { get; set; }
        public string NombreComprador { get; set; }

        public Factura (int Nro_Factura, string Forma_Pago, double Total_Facturacion, DateTime Factura_Fecha, string NombreComprador)
        {
            this.Nro_Factura = Nro_Factura;
            this.Forma_Pago = Forma_Pago;
            this.Total_Facturacion = Total_Facturacion;
            this.Factura_Fecha = Factura_Fecha;
            this.NombreComprador = NombreComprador;
        }

    }
}
