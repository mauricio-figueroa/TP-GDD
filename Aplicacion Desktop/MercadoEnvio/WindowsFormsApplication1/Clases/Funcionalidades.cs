using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace LOS_INSISTENTES.Clases
{
    class Funcionalidades
    {
        public static List<Funcionalidad> obtenerTodasLasFuncionalidades(SqlConnection conexion)
        {
            List<Funcionalidad> listaFuncionalidades = new List<Funcionalidad>();

            SqlDataReader lectorFuncionalidades = BaseDeDatos.ejecutarReader("SELECT ID_Funcionalidad, Nombre FROM LOS_INSISTENTES.Funcionalidades", null, conexion);

            if (lectorFuncionalidades.HasRows)
            {
                while (lectorFuncionalidades.Read())
                {
                    Funcionalidad unaFuncionalidad = new Funcionalidad((int)(decimal)lectorFuncionalidades["ID_Funcionalidad"], (string)lectorFuncionalidades["Nombre"]);
                    listaFuncionalidades.Add(unaFuncionalidad);
                }
            }
            BaseDeDatos.cerrarConexion();
            return listaFuncionalidades;
        }

        public static List<Funcionalidad> obtenerFuncionalidades(SqlConnection conexion, int ID_Rol)
        {
            List<Funcionalidad> listaFuncionalidades = new List<Funcionalidad>();

            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_Rol", ID_Rol);
            SqlDataReader lectorFuncionalidades = BaseDeDatos.ejecutarReader("SELECT f.ID_Funcionalidad, f.Nombre FROM LOS_INSISTENTES.Funcionalidades f, LOS_INSISTENTES.Funcionalidad_Rol fr WHERE fr.ID_Rol = @ID_Rol AND fr.ID_Funcionalidad = f.ID_Funcionalidad", listaParametros, conexion);

            if (lectorFuncionalidades.HasRows)
            {
                while (lectorFuncionalidades.Read())
                {
                    Funcionalidad unaFuncionalidad = new Funcionalidad((int)(decimal)lectorFuncionalidades["ID_Funcionalidad"], (string)lectorFuncionalidades["Nombre"]);
                    listaFuncionalidades.Add(unaFuncionalidad);
                }
            }
            BaseDeDatos.cerrarConexion();
            return listaFuncionalidades;
        }

        public static void AgregarFuncionalidadRol(string nombre, Funcionalidad unaFunc)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@rol", nombre));
            listaParametros.Add(new SqlParameter("@funcionalidad", unaFunc.Nombre));

            BaseDeDatos.ejecutarSP("AgregarFuncionalidadRol", listaParametros);
            BaseDeDatos.cerrarConexion();

        }

       public static void BorrarFuncionalidadRol(string nombreRol, string nombreFunc)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@rol", nombreRol));
            listaParametros.Add(new SqlParameter("@funcionalidad", nombreFunc));

            BaseDeDatos.ejecutarSP("QuitarFuncionalidadRol", listaParametros);
            BaseDeDatos.cerrarConexion();
        }

    }
}
