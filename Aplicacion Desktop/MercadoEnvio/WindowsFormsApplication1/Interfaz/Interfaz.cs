using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agrego
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Drawing;



namespace LOS_INSISTENTES.Interfaz
{
    class Interfaz
    {
        public static Clases.Usuario usuario { get; set; }

        public string[] monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

        // public static DateTime fechaSistema = Convert.ToDateTime(obtenerConfiguracion("FechaSistema"));
        public static DateTime fechaSistema = Convert.ToDateTime(ConfigurationManager.AppSettings["FechaSistema"]);
        

        public static string esquemaBD = obtenerConfiguracion("EsquemaBD");

        public static string leyendaSubastas = "";

        public static void loguearUsuario(Clases.Usuario usuarioActual)
        {
            usuario = usuarioActual;
        }

        public static bool testEmail(String email)
        {
            if (String.IsNullOrEmpty(email))
                return false;

            return email.Contains("@") && email.Contains(".");
        }

        public static bool testCuit(String cuit)
        {
            if (String.IsNullOrEmpty(cuit))
                return false;

            return cuit.Contains("-") && cuit.Contains("-");
        }

        public static void finalizarSubastas()
        {
            //MessageBox.Show("Recordar descomentar");
            //return;
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@FechaSistema", fechaSistema);
            int cantSubastas = BaseDeDatos.ejecutarSP("sp_FinalizarSubastas", listaParametros);
            BaseDeDatos.cerrarConexion();
            if (cantSubastas > 0)
                leyendaSubastas = "Se actualizaron las subastas con al día de la fecha.";
        }

        //Para validar letras
        public static void soloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false; //Valido si es una letra
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;  //Valido si es una tecla de control (Ejemplo borrar)
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false; //Valido si es una tecla para Espacios
                }
                else
                {
                    e.Handled = true; //No activar tecla
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }


        //Para validar numeros
        public static void soloNumeros(KeyPressEventArgs e, bool conComas = false)
        {
            try
            {
                if (Char.IsPunctuation(e.KeyChar) && conComas && e.KeyChar.Equals(',')) {
                    e.Handled = false;
                }
                else if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false; //Valido si es un numero
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;  //Valido si es una tecla de control (Ejemplo borrar)
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    //e.Handled = false; //Valido si es una tecla para Espacios
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true; //No activar tecla
                }
            }
            catch (Exception)
            {

            }
        }


        //Para limpiar
        public static void limpiarInterfaz(Control con)
        {
            foreach (Control c in con.Controls)
            {
                var box = c as TextBox;

                var datetimepicker = c as DateTimePicker;

                var combo = c as ComboBox;

                
                //Limpia textbox
                if (box != null)
                {
                    box.Text = string.Empty;
                }
               
                

                //Limpia comboBox para tipo de DNI
                if (combo != null)
                {
                    combo.Text = string.Empty;
                    combo.SelectedIndex = -1;
                }

                //Limpiar fecha
                if (datetimepicker != null)
                {
                    datetimepicker.ResetText();
                }


                limpiarInterfaz(c);

            }
        }

        public static void limpiarCheckboxList(CheckedListBox cbl)
        {
            foreach (int i in cbl.CheckedIndices)
            {
                cbl.SetItemCheckState(i, CheckState.Unchecked);
                cbl.SetSelected(i, false);
            }

        }
        public static bool esNumerico(string val, System.Globalization.NumberStyles NumberStyle)
        {
            Double result;
            return Double.TryParse(val, NumberStyle, System.Globalization.CultureInfo.CurrentCulture, out result);
        }

        public Boolean campoVacio(TextBox textbox)
        {
            return textbox.Text.Equals("");
        }

        public Boolean cboxVacio(ComboBox combobox)
        {
            if (combobox.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string obtenerConfiguracion(string nombreConfig)
        {
            string resultado = "";

            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@nombreConfig", nombreConfig);
            SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT ValorConfig FROM LOS_INSISTENTES.Configuraciones WHERE NombreConfig = @nombreConfig", listaParametros, BaseDeDatos.iniciarConexion());

            if (lector.Read())
                resultado = Convert.ToString(lector["ValorConfig"]);

            BaseDeDatos.cerrarConexion();
            return resultado;
        }
        
        // Hay que pasarle si o si dos campos: id y valor
        public void cargarComboIDValor(ComboBox combo, String querySQL)
        {
            SqlDataReader valores = BaseDeDatos.ejecutarReader(querySQL, null, BaseDeDatos.iniciarConexion());

            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("valor");
            dt.Rows.Add("-1", "Seleccione una opción ....");
            dt.Load(valores);

            BaseDeDatos.cerrarConexion();

            combo.DataSource = null;
            combo.ValueMember = "id";
            combo.DisplayMember = "valor";
            combo.DataSource = dt;
        }

        public void cargarComboIDValor(ListBox combo, String querySQL)
        {
            SqlDataReader valores = BaseDeDatos.ejecutarReader(querySQL, null, BaseDeDatos.iniciarConexion());

            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("valor");
            dt.Load(valores);

            BaseDeDatos.cerrarConexion();

            combo.DataSource = null;
            combo.ValueMember = "id";
            combo.DisplayMember = "valor";
            combo.DataSource = dt;
        }

        public void cargarComboIDValor(CheckedListBox combo, String querySQL)
        {
            SqlDataReader valores = BaseDeDatos.ejecutarReader(querySQL, null, BaseDeDatos.iniciarConexion());

            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("valor");
            dt.Load(valores);

            BaseDeDatos.cerrarConexion();

            combo.DataSource = null;
            combo.ValueMember = "id";
            combo.DisplayMember = "valor";
            combo.DataSource = dt;
        }


        public static void llenarChkListBox(CheckedListBox chkListBox, String querySQL)
        {
            SqlDataReader valores = BaseDeDatos.ejecutarReader(querySQL, null, BaseDeDatos.iniciarConexion());

            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("valor");
            dt.Load(valores);
            
            BaseDeDatos.cerrarConexion();

            chkListBox.DataSource = dt;
            chkListBox.ValueMember = "id";
            chkListBox.DisplayMember = "valor";
            chkListBox.DataSource = dt;
           
           
        }

        public static bool emitirAviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        public static DialogResult emitirPregunta(string mensaje)
        {
            return MessageBox.Show(mensaje, "Pregunta a usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        public static string bytesDeHasheoToString(byte[] array)
        {
            StringBuilder salida = new StringBuilder("");
            for (int i = 0; i < array.Length; i++)
            {
                salida.Append(array[i].ToString("X2"));
            }
            return salida.ToString();
        }

        public static void ponerLabel(GroupBox groupbox, string textoNotificacion = "Aún no hay datos disponibles.")
        {
            Label lblNotificacion = new Label()
            {
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Serif", 20, FontStyle.Bold),
                Name = "lblNotificacion"
            };
            lblNotificacion.Text = textoNotificacion;
            groupbox.Controls.Add(lblNotificacion);
            lblNotificacion.BringToFront();
        }

        public static void quitarLabel(GroupBox groupbox)
        {
            groupbox.Controls.Remove(groupbox.Controls.OfType<Label>().Where(c => c.Name == "lblNotificacion").FirstOrDefault());
        }
    }
}
