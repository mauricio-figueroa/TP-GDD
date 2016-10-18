using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace LOS_INSISTENTES.Clases
{
    public class Usuario
    {
        public int ID_User { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Intentos_Login { get; set; }
        public int Habilitado { get; set; }
        public int Primera_Vez { get; set; }
        public int Cant_Publi_Gratuitas { get; set; }

        public List<Rol> Roles = new List<Rol>();

        public Usuario(int id, string username, string password)
        {
            this.ID_User = id;
            this.Username = username;
            this.Password = password;
            Interfaz.Interfaz.loguearUsuario(this);
        }

        public Boolean verificarContrasenia()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@Username", this.Username);
            BaseDeDatos.agregarParametro(listaParametros, "@Password", this.Password);
            SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT Username, Password FROM LOS_INSISTENTES.Usuarios WHERE Username = @Username AND PASSWORD = @Password", listaParametros, BaseDeDatos.iniciarConexion());
            Boolean res = lector.HasRows;
            BaseDeDatos.cerrarConexion();
            return res;
        }

                public Boolean verificarContraseniaSinHash(string password)
                {
                    List<SqlParameter> listaParametros = new List<SqlParameter>();
                    BaseDeDatos.agregarParametro(listaParametros, "@ID_User", this.ID_User);
                    SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT Password FROM LOS_INSISTENTES.Usuarios WHERE ID_User = @ID_User", listaParametros, BaseDeDatos.iniciarConexion());
                    lector.Read();
                    if (password == Convert.ToString(lector["Password"]))
                    {
                        BaseDeDatos.cerrarConexion();
                        return true;
                    }
                    else
                    {
                        BaseDeDatos.cerrarConexion();
                        return false;
                    }

                }

        public void ResetearIntentosFallidos()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", this.ID_User);
            BaseDeDatos.ejecutarSP("sp_ResetIntentosLogin", listaParametros);
            BaseDeDatos.cerrarConexion();
        }

        public void sumarIntentoFallido()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", this.ID_User);
            BaseDeDatos.ejecutarSP("sp_SumarIntentoLogin", listaParametros);
            BaseDeDatos.cerrarConexion();
        }

        public int intentosFallidos()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", this.ID_User);
            SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT Intentos_Login FROM LOS_INSISTENTES.Usuarios WHERE ID_User = @ID_User", listaParametros, BaseDeDatos.iniciarConexion());
            lector.Read();
            int res = Convert.ToInt32(lector["Intentos_Login"]);
            BaseDeDatos.cerrarConexion();
            return res;
        }

        public int ObtenerComprasSinCalificar()
        {
            // Hay que revisar este query a nivel BBDD
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_user", this.ID_User);
            SqlDataReader lectorResumen = BaseDeDatos.ejecutarReader("SELECT * FROM LOS_INSISTENTES.vw_CantComprasSinCalificar WHERE ID_User = @ID_User", listaParametros, BaseDeDatos.iniciarConexion());
            int resultado = 0;
            if (lectorResumen.Read())
            {
                resultado = Convert.ToInt32(lectorResumen["CantComprasSinCalificar"]);
            }
            BaseDeDatos.cerrarConexion();
            return resultado;
        }

        public int cantidadIntentosFallidos()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", this.ID_User);
            SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT Intentos_Login FROM LOS_INSISTENTES.Usuarios WHERE ID_User = @ID_User", listaParametros, BaseDeDatos.iniciarConexion());
            if (lector.HasRows)
            {
                lector.Read();
                int resultado = Convert.ToInt32(lector["Intentos_Login"]);
                BaseDeDatos.cerrarConexion();
                return resultado;
            }
            else
            {
                BaseDeDatos.cerrarConexion();
                return -1;
            }
        }




        public Boolean obtenerPK()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@Username", this.Username);

            //FIJARSE BIEN LOS PARAMETROS DE ESE SELECT. LOS NOMBRES DE LA BD Y LAS TABLAS
            SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT ID_User FROM LOS_INSISTENTES.Usuarios WHERE Username = @Username", listaParametros, BaseDeDatos.iniciarConexion());
            if (lector.HasRows)
            {
                lector.Read();
                this.ID_User = Convert.ToInt32(lector["ID_User"]);
                BaseDeDatos.cerrarConexion();
                return true;
            }
            else
            {
                BaseDeDatos.cerrarConexion();
                return false;
            }
        }


        public Boolean habilitado()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", this.ID_User);
            SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT Habilitado FROM LOS_INSISTENTES.Usuarios WHERE ID_User = @ID_User", listaParametros, BaseDeDatos.iniciarConexion());
            lector.Read();
            if (Convert.ToInt32(lector["Habilitado"]) == 1)
            {
                BaseDeDatos.cerrarConexion();
                return true;
            }
            else
            {
                BaseDeDatos.cerrarConexion();
                return false;
            }
        }

        public Boolean validarConstrasenia()
        {

            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@Username", this.Username);
            BaseDeDatos.agregarParametro(listaParametros, "@Password", this.Password);
            SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT * FROM LOS_INSISTENTES.Usuarios WHERE Username = @Username AND PASSWORD = @Password", listaParametros, BaseDeDatos.iniciarConexion());
            Boolean respuesta = lector.HasRows;
            BaseDeDatos.cerrarConexion();
            return respuesta;
        }


    

        public void desHabilitarUsuario()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", this.ID_User);
            BaseDeDatos.ejecutarSP("sp_DeshabilitarUsuario", listaParametros);
            BaseDeDatos.cerrarConexion();
        }



        public Boolean obtenerRoles()
        {
            List<SqlParameter> listaParametros1 = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros1, "@ID_User", this.ID_User);
            SqlConnection conexion = BaseDeDatos.iniciarConexion();
            SqlDataReader lectorRolesUsuario = BaseDeDatos.ejecutarReader("SELECT ID_Rol FROM LOS_INSISTENTES.Roles_Usuarios WHERE ID_User = @ID_User", listaParametros1, conexion);
            if (lectorRolesUsuario.HasRows)                
            {
                while (lectorRolesUsuario.Read())
                {
                    List<SqlParameter> listaParametros2 = new List<SqlParameter>();
                    BaseDeDatos.agregarParametro(listaParametros2, "@ID_Rol", Convert.ToInt32(lectorRolesUsuario["ID_Rol"]));
                    SqlDataReader lectorRoles = BaseDeDatos.ejecutarReader("SELECT Nombre, Habilitado FROM LOS_INSISTENTES.Roles WHERE ID_Rol = @ID_Rol", listaParametros2, conexion);
                    lectorRoles.Read();
                    Rol nuevoRol = new Rol(Convert.ToInt32(lectorRolesUsuario["ID_Rol"]), lectorRoles["Nombre"].ToString(), (bool)lectorRoles["Habilitado"]);
                    nuevoRol.obtenerFuncionalidades(conexion);
                    this.Roles.Add(nuevoRol);
                }
                BaseDeDatos.cerrarConexion();
                return true;
            }
            else
            {
                BaseDeDatos.cerrarConexion();
                return false;
            }
        }


        public void cambiarPassword(string nuevoPass)
        {
            UTF8Encoding encoderHash = new UTF8Encoding();
            SHA256Managed hasher = new SHA256Managed();
            byte[] bytesDeHasheo = hasher.ComputeHash(encoderHash.GetBytes(nuevoPass));
            string password = Interfaz.Interfaz.bytesDeHasheoToString(bytesDeHasheo);

            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", this.ID_User);
            BaseDeDatos.agregarParametro(listaParametros, "@Password", password);
            BaseDeDatos.ejecutarSP("sp_CambiarPassword", listaParametros);
            BaseDeDatos.cerrarConexion();
        }

        public int primeraVez()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", this.ID_User);
            SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT Primera_Vez FROM LOS_INSISTENTES.Usuarios WHERE ID_User = @ID_User", listaParametros, BaseDeDatos.iniciarConexion());
            lector.Read();
            int pVez = Convert.ToInt32(lector["Primera_Vez"]);
            if (pVez == 0)
            {
                BaseDeDatos.cerrarConexion();
                return pVez;
            }
            else
            {
                BaseDeDatos.cerrarConexion();
                return pVez;
            }
        }

        public int publicacionesGratuitas()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", this.ID_User);
            SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT Publi_Gratuitas FROM LOS_INSISTENTES.Usuarios WHERE ID_User = @ID_User", listaParametros, BaseDeDatos.iniciarConexion());
            lector.Read();
            int publiGratuitas = Convert.ToInt32(lector["Publi_Gratuitas"]);
            BaseDeDatos.cerrarConexion();
            return publiGratuitas;
        }
    }
}

