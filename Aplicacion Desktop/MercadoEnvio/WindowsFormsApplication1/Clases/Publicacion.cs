using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOS_INSISTENTES.Clases
{
    public class Publicacion
    {
        public int codPublicacion { get; set; }
        public string descripcionPublicacion { get; set; }
        public string rubroPublicacion { get; set; }
        public string tipoPublicacion { get; set; }
        public string visibilidadPublicacion { get; set; }
        public string estadoPublicacion { get; set; }


        public Publicacion(
            int codPublicacion, string tipoPublicacion, string visibilidadPublicacion,
            string estadoPublicacion, string rubroPublicacion, string descripcionPublicacion)
        {
            this.codPublicacion = codPublicacion;
            this.descripcionPublicacion = descripcionPublicacion;
            this.rubroPublicacion = rubroPublicacion;
            this.tipoPublicacion = tipoPublicacion;
            this.visibilidadPublicacion = visibilidadPublicacion;
            this.estadoPublicacion = estadoPublicacion;
            this.rubroPublicacion = rubroPublicacion;
        }


        

    }
}
