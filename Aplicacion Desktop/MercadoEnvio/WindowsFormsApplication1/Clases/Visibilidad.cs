using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LOS_INSISTENTES.Clases
{
    class Visibilidad
    {

        public static bool permiteEnvio(int codVisibilidad) {
            String query="select Permite_Envios from LOS_INSISTENTES.Visibilidades where Cod_Visibilidad="+codVisibilidad;

            SqlDataReader lector = BaseDeDatos.ejecutarReader(query, null, BaseDeDatos.iniciarConexion());

            bool resultado = false;

            if (lector.Read())
                resultado = Convert.ToBoolean(lector["Permite_Envios"]);

            BaseDeDatos.cerrarConexion();
            return resultado;
        }
    }
}
