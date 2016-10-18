using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace LOS_INSISTENTES.Clases
{
    public class Operacion
    {
        public int Cod_Publicacion { get; set; }
        public int Cod_Calificacion { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Operacion { get; set; }
        public double Monto_Oferta { get; set; }
        public string Tipo_Operacion { get; set; }

        public Operacion(int Cod_Publicacion, int Cod_Calificacion, string Descripcion, DateTime Fecha_Operacion, double Monto_Oferta, string Tipo_Operacion)
        {
            this.Cod_Publicacion = Cod_Publicacion;
            this.Cod_Calificacion = Cod_Calificacion;
            this.Descripcion = Descripcion;
            this.Fecha_Operacion = Fecha_Operacion;
            this.Monto_Oferta = Monto_Oferta;
            this.Tipo_Operacion = Tipo_Operacion;
        }

    }
}
