using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOS_INSISTENTES.Clases
{
    public class Cliente
    {
        /*
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int num_doc { get; set; }
        public string tipo_doc { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public int codigo_postal { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public DateTime fecha_creacion { get; set; }

         public Cliente (string nombre, string apellido, int num_doc, string tipo_doc, string mail, int telefono, string direccion, int codigo_postal, DateTime fecha_nacimiento, DateTime fecha_creacion)
         {
             this.nombre = nombre;
             this.apellido = apellido;
             this.num_doc = num_doc;
             this.tipo_doc = tipo_doc;
             this.mail = mail;
             this.telefono = telefono;
             this.direccion = direccion;
             this.codigo_postal = codigo_postal;
             this.fecha_nacimiento = fecha_nacimiento;
             this.fecha_creacion = fecha_creacion;
        }
        */

        public int ID_User { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo_Doc { get; set; }
        public int Num_Doc { get; set; }
        public string Mail { get; set; }
           
                  
        //Sobrecargo para la baja de cliente
        public Cliente(int ID_User, string Nombre, string Apellido, string Tipo_Doc, int Num_Doc, string Mail)
         {
             this.ID_User = ID_User;
             this.Nombre = Nombre;
             this.Apellido = Apellido;
             this.Tipo_Doc = Tipo_Doc;
             this.Num_Doc = Num_Doc;
             this.Mail = Mail;
             
         }
    }
}
