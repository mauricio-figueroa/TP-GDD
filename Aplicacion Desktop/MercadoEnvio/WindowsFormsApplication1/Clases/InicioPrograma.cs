using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LOS_INSISTENTES
{
    class InicioPrograma
    {
        public InicioPrograma(){
    
    }

    public Boolean primeraVezPrograma(){
        List<SqlParameter> listaParametros = new List<SqlParameter>();
        BaseDeDatos.agregarParametro(listaParametros, "@nombreConfig", "PrimeraVezPrograma");
        SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT ValorConfig FROM LOS_INSISTENTES.Configuraciones WHERE NombreConfig = @nombreConfig", listaParametros, BaseDeDatos.iniciarConexion());

        
        lector.Read();
        int valorPrimeraVez = Convert.ToInt32(lector["ValorConfig"]);
        BaseDeDatos.cerrarConexion();
        if (valorPrimeraVez == 1)
        {
            this.cambiarValorPrimeraVez();
            return true;
            
        }
        else {
            return false;
          }
        
        
    }


    private void cambiarValorPrimeraVez() {
        List<SqlParameter> listaParametros = new List<SqlParameter>();
        BaseDeDatos.agregarParametro(listaParametros, "@habilitado", 0);
        BaseDeDatos.ejecutarSP("sp_deshabilitarPrimeraVez", listaParametros);
        BaseDeDatos.cerrarConexion();
    }

    }
}
