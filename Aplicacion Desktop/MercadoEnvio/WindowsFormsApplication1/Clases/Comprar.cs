using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOS_INSISTENTES.Clases
{
    public class Comprar
    {
        public int Cod_Publicacion { get; set; }
        public int Stock { get; set; }
        public bool Permite_Envios { get; set; }
        public string Descripcion { get; set; }
        public string Rubro { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public double MontoCompra { get; set; }

       


        public Comprar(int Cod_Publicacion, int Stock, bool Permite_Envios, string Descripcion, string Rubro, string Tipo, string Estado, double MontoCompra)
        {

           this.Cod_Publicacion = Cod_Publicacion;
           this.Stock = Stock;
           this.Permite_Envios = Permite_Envios;
           this.Descripcion = Descripcion;
           this.Rubro = Rubro;
           this.Tipo = Tipo;
           this.Estado = Estado;
           this.MontoCompra = MontoCompra;
        }



    }
}
