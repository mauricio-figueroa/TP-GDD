using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOS_INSISTENTES.Calificar
{
    public partial class DetalleCalificacion : Form
    {
        Interfaz.Interfaz interfaz = new Interfaz.Interfaz();

        public int codCalificacion { get; set; }

        public DetalleCalificacion (int codCalificacion, string descripcion)
        {
            InitializeComponent();
            this.CenterToScreen();

            this.codCalificacion = codCalificacion;
            lblTituloCalificar.Text = "Calificar compra " + descripcion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbPuntaje.Text.Equals(""))
            {
                Interfaz.Interfaz.emitirAviso("Por favor seleccione el puntaje.");
                return;
            }
            if (tDescripcion.Text.Equals(""))
            {
                Interfaz.Interfaz.emitirAviso("Por favor ingrese una descripción.");
                return;
            }

            DateTime fechaCalificacion = Interfaz.Interfaz.fechaSistema;

            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@codCalificacion", codCalificacion);
            BaseDeDatos.agregarParametro(listaParametros, "@puntaje", cmbPuntaje.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@descripcion", tDescripcion.Text);
            BaseDeDatos.agregarParametro(listaParametros, "@fecha", fechaCalificacion);

            BaseDeDatos.ejecutarSP("sp_ModificarCalificacion", listaParametros);

            DialogResult = DialogResult.OK;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
