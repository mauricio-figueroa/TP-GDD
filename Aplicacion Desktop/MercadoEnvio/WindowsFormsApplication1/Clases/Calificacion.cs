using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOS_INSISTENTES.Clases
{
    public class Calificacion
    {
        public int Cod_Calificacion { get; set; }
        public int Puntaje { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Calificacion { get; set; }

        public Calificacion(int Cod_Calificacion, int Puntaje, string Descripcion, DateTime Fecha_Calificacion)
        {
            this.Cod_Calificacion = Cod_Calificacion;
            this.Puntaje = Puntaje;
            this.Descripcion = Descripcion;
            this.Fecha_Calificacion = Fecha_Calificacion;
        }
    }
}
