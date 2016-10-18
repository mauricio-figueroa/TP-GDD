using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOS_INSISTENTES.Clases
{
    class Empresa
    {
        public int ID_User { get; set; }
        public string Razon_Social { get; set; }
        public string CUIT { get; set; }
        public string Mail { get; set; }
                  
        public Empresa(int ID_User, string Razon_Social, string CUIT, string Mail)
         {
             this.ID_User = ID_User;
             this.Razon_Social = Razon_Social;
             this.CUIT = CUIT;
             this.Mail = Mail;
         }

    }
}
