using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace LOS_INSISTENTES
{
    class BaseDeDatos
    {
        static SqlConnection conexion = new SqlConnection();
        static string stringConexion;


        public static Boolean existeString(string valor, string nombreTabla, string nombreColumna)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            agregarParametro(listaParametros, "@valor", valor);
            String query = "SELECT * FROM " + nombreTabla + " WHERE " + nombreColumna + " = @valor";
            SqlDataReader lector = ejecutarReader(query, listaParametros, iniciarConexion());
            Boolean res = lector.HasRows;

            cerrarConexion();
            return res;
        }



        public static void agregarParametro(List<SqlParameter> lista, string parametro, object valor)
        {
            lista.Add(new SqlParameter(parametro, valor));
        }

        public static void agregarParametroRetorno(List<SqlParameter> lista, string parametro, object valor)
        {
            SqlParameter retorno = new SqlParameter(parametro, valor);
            retorno.Direction = System.Data.ParameterDirection.Output;
            lista.Add(retorno);
        }

        
        public static SqlConnection iniciarConexion()
        {
            try
            {
                // Acá se deberían usar distintos usuarios de conexión si es o no admin ... No aplica
                stringConexion = ConfigurationManager.AppSettings["ConnectionString"];
                conexion.ConnectionString = stringConexion;
                conexion.Open();
            }
            catch (SqlException)
            {   
                Interfaz.Interfaz.emitirAviso("Error en la conexión a la base de datos");
            }
            return conexion;
        }

        
        public static SqlDataReader ejecutarReader(string stringQuery, List<SqlParameter> parametros, SqlConnection conexion) // PARA SELECT
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = stringQuery;
                if (parametros != null)
                    foreach (SqlParameter parametro in parametros)
                    {
                        if (parametro.Value == null)
                            parametro.Value = DBNull.Value;
                        comando.Parameters.Add(parametro);
                    }
                return comando.ExecuteReader();
            }
            catch (SqlException e)
            {
                Interfaz.Interfaz.emitirAviso("" + e.Message);
                return null;
            }
        }

        public static void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (SqlException)
            {

            }
        }

        public static int ejecutarSP(string commandtext, List<SqlParameter> ListaParametro)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = iniciarConexion();
                comando.CommandText = Interfaz.Interfaz.esquemaBD + "." + commandtext;
                comando.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter elemento in ListaParametro)
                    comando.Parameters.Add(elemento);

                int resultadoQuery = comando.ExecuteNonQuery();
                comando.Connection.Close();

                if (comando.Parameters.Contains("@retorno") && comando.Parameters["@retorno"].Value != DBNull.Value)
                    return Convert.ToInt32(comando.Parameters["@retorno"].Value);

                return resultadoQuery;              
            }
            catch (SqlException e)
            {
                Interfaz.Interfaz.emitirAviso("" + e.Message);
                return -10;
            }
        }

        public static SqlDataReader ObtenerDataReader(string commandtext, string commandtype, List<SqlParameter> ListaParametro) //(con parametros)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = iniciarConexion();
                comando.CommandText = commandtext;
                foreach (SqlParameter elemento in ListaParametro)
                {
                    comando.Parameters.Add(elemento);
                }
                switch (commandtype)
                {
                    case "T":
                        comando.CommandType = CommandType.Text;
                        break;
                    case "TD":
                        comando.CommandType = CommandType.TableDirect;
                        break;
                    case "SP":
                        comando.CommandType = CommandType.StoredProcedure;
                        break;
                }
                return comando.ExecuteReader();
            }
            catch (SqlException e)
            {
                Interfaz.Interfaz.emitirAviso("" + e.Message);
                return null;
            }
        }

        public static DataTable obtenerDataTable(string commandtext, string commandtype, List<SqlParameter> ListaParametro) //(con parametros)
        {
            DataTable result = null;

           int count = 0;

            try
            {
                SqlDataReader dr = ObtenerDataReader(commandtext, commandtype, ListaParametro);
                if (dr.HasRows)
                {

                    result = new DataTable();

                    while (dr.Read())
                    {
                        DataRow row = result.NewRow();
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            if (count == 0)
                                result.Columns.Add(dr.GetName(i));

                            row[i] = dr[i];
                        }
                        result.Rows.Add(row);
                        count++;
                    }
                }
                dr.Close();
            }
            finally
            {
                try
                {
                    conexion.Close();
                    conexion.Dispose();
                }
                catch { }
            }


            return result;

        }


      
    }

}

