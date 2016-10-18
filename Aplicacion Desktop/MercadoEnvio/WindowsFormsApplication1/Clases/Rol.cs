using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LOS_INSISTENTES.Clases
{
    public class Rol
    {
        public int ID_Rol { get; set; }
        public string Nombre { get; set; }
        public bool Habilitado { get; set; }

        public Rol(int id_rol, string nombre, bool habilitado)
        {
            this.ID_Rol = id_rol;
            this.Nombre = nombre;
            this.Habilitado = habilitado;
        }

        public Rol(string nombre, bool habilitado)
        {
           this.Nombre = nombre;
           this.Habilitado = habilitado;
        }

        public List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

        public void obtenerFuncionalidades(SqlConnection conexion)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_Rol", this.ID_Rol);
            SqlDataReader lectorFuncionalidades = BaseDeDatos.ejecutarReader("SELECT ID_Funcionalidad FROM LOS_INSISTENTES.Funcionalidad_Rol WHERE ID_Rol = @ID_Rol", listaParametros, conexion);
            if (lectorFuncionalidades.HasRows)
            {
                while (lectorFuncionalidades.Read())
                {
                    Funcionalidad funcionalidad = new Funcionalidad(Convert.ToInt32(lectorFuncionalidades["ID_Funcionalidad"]));
                    this.funcionalidades.Add(funcionalidad);
                }
            }
        }

        public static int obtenerID(string nombreRol)
        {
            int idRol;
            List<SqlParameter> listaParametros = new List<SqlParameter>();

            listaParametros.Clear();

            BaseDeDatos.agregarParametro(listaParametros, "@nombre", "Cliente");

            string commandText = "SELECT ID_Rol FROM LOS_INSISTENTES..Roles WHERE Nombre = @nombre";

            SqlDataReader lector = BaseDeDatos.ObtenerDataReader(commandText, "T", listaParametros);

            if (lector.HasRows)
            {
                lector.Read();
                idRol = Convert.ToInt32(lector["ID_Rol"]);

            }
            else
                idRol = -1;

            BaseDeDatos.cerrarConexion();
            return idRol;
        }

        public static void DeshabilitarRol(int idRol)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_Rol", idRol);
            BaseDeDatos.ejecutarSP("sp_DeshabilitarRol", listaParametros);
            BaseDeDatos.cerrarConexion();
        }

        public static void agregarRol(string nombreRol, List<int> listaFuncionalidades) {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@nombreRol", nombreRol);
            BaseDeDatos.agregarParametroRetorno(listaParametros, "@retorno", -1);
            int idRol = BaseDeDatos.ejecutarSP("sp_agregarRolNuevo", listaParametros);
            if (idRol > 0)
            {
                agregarFuncionalidadesRol(listaFuncionalidades, idRol);
                Interfaz.Interfaz.emitirAviso("Rol agregado exitosamente");
            }
            else
            {
                Interfaz.Interfaz.emitirAviso("No se pudo agregar el rol.");
            }
            BaseDeDatos.cerrarConexion();       
        }

        public static void modificarRol(int idRol, string nombreRol, bool habilitado, List<int> listaFuncionalidades)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_Rol", idRol);
            BaseDeDatos.agregarParametro(listaParametros, "@nombre", nombreRol);
            BaseDeDatos.agregarParametro(listaParametros, "@habilitado", habilitado);
            BaseDeDatos.ejecutarSP("sp_ModificarRol", listaParametros);
            agregarFuncionalidadesRol(listaFuncionalidades, idRol);
            BaseDeDatos.cerrarConexion();
            Interfaz.Interfaz.emitirAviso("Rol modificado exitosamente.");
        }

        public static void agregarFuncionalidadesRol(List<int> idsFuncionalidades, int idRol) {

            foreach (int idFuncionalidad in idsFuncionalidades)
            {
                List<SqlParameter> listaParametrosFuncionalidades = new List<SqlParameter>();
                BaseDeDatos.agregarParametro(listaParametrosFuncionalidades, "@idRol", idRol);
                BaseDeDatos.agregarParametro(listaParametrosFuncionalidades, "@idFuncionalidad", idFuncionalidad);
                BaseDeDatos.ejecutarSP("sp_AgregarFuncionalidadRol", listaParametrosFuncionalidades);

                BaseDeDatos.cerrarConexion();
            }        
        }
    }
}
