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

namespace LOS_INSISTENTES.Generar_Publicación
{
    public partial class GenerarPublicacion : Form
    {
        public List<Clases.Publicacion> listadoPublicaciones = new List<Clases.Publicacion>();
        public SqlConnection conexion { get; set; }
        public int paginaActual { get; set; }

        int idUser = Interfaz.Interfaz.usuario.ID_User;

        Interfaz.Interfaz interfaz = new Interfaz.Interfaz();

        public GenerarPublicacion()
        {
            InitializeComponent();
            this.CenterToScreen();

            this.paginaActual = 1;

            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;

            actualizarPublicacionesGratuitas();

            int cantidadPublicaciones = obtenerPublicaciones(paginaActual);

            btnSiguiente.Enabled = !(cantidadPublicaciones <= 14);

        }

        public int obtenerPublicaciones (int pagina)
        {

            dgPublicaciones.AutoGenerateColumns = true;

            dgPublicaciones.DataSource = null;
            dgPublicaciones.Columns.Clear();
            listadoPublicaciones.Clear();

            int cont = 0;
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", idUser);
            BaseDeDatos.agregarParametro(listaParametros, "@Pagina", pagina);
            this.conexion = BaseDeDatos.iniciarConexion();
            SqlDataReader lector = BaseDeDatos.ejecutarReader("EXEC LOS_INSISTENTES.sp_ObtenerPublicacionesPorPagina @Pagina, @ID_User", listaParametros, conexion);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    cont++;

                    int codPublicacion = Convert.ToInt32(lector["Cod_Publicacion"].ToString());
                    string descripcionPublicacion = lector["Descripcion"].ToString();
                    string rubroPublicacion = lector["Rubro"].ToString();
                    string tipoPublicacion = lector["Tipo"].ToString();
                    string visibilidadPublicacion = lector["Visibilidad"].ToString();
                    string estadoPublicacion = lector["Estado"].ToString();

                    Clases.Publicacion publicacion = new Clases.Publicacion(codPublicacion, tipoPublicacion,
                        visibilidadPublicacion, estadoPublicacion, rubroPublicacion, descripcionPublicacion);

                    listadoPublicaciones.Add(publicacion);
                }

                dgPublicaciones.DataSource = listadoPublicaciones;

                dgPublicaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                dgPublicaciones.Columns[0].Visible = false;
                dgPublicaciones.Columns[1].HeaderText = "Descripción";
                dgPublicaciones.Columns[2].HeaderText = "Rubro";
                dgPublicaciones.Columns[3].HeaderText = "Tipo";
                dgPublicaciones.Columns[4].HeaderText = "Visibilidad";
                dgPublicaciones.Columns[5].HeaderText = "Estado";

                dgPublicaciones.Columns[1].Width = 240;
                dgPublicaciones.Columns[2].Width = 200;
                dgPublicaciones.Columns[3].Width = 120;
                dgPublicaciones.Columns[4].Width = 80;
                dgPublicaciones.Columns[5].Width = 80;

                dgPublicaciones.AutoGenerateColumns = false;

                DataGridViewImageColumn cModificar = new DataGridViewImageColumn();

                cModificar.Image = Properties.Resources.modificar;
                cModificar.Width = 40;
                cModificar.ToolTipText = "Modificar publicación";
                dgPublicaciones.Columns.Add(cModificar);

                DataGridViewImageColumn cPlay = new DataGridViewImageColumn();

                cPlay.Image = Properties.Resources.play;
                cPlay.Width = 40;
                cPlay.ToolTipText = "Publicar publicación";
                dgPublicaciones.Columns.Add(cPlay);

                DataGridViewImageColumn cPausa = new DataGridViewImageColumn();

                cPausa.Image = Properties.Resources.pausa;
                cPausa.Width = 40;
                cPausa.ToolTipText = "Pausar publicación";
                dgPublicaciones.Columns.Add(cPausa);

                DataGridViewImageColumn cFinalizar = new DataGridViewImageColumn();

                cFinalizar.Image = Properties.Resources.close;
                cFinalizar.Width = 40;
                cFinalizar.ToolTipText = "Finalizar publicación";
                dgPublicaciones.Columns.Add(cFinalizar);

                /*
                dgPublicaciones.Rows.Cast<DataGridViewRow>().ToList().ForEach (
                   f => {
                       Console.WriteLine(f.Cells[5].Value.ToString());
                       if (f.Cells[5].Value.ToString().Equals("Finalizada")) {
                           Console.WriteLine(f.Cells[5].Value.ToString());
                       }
                   });
                */

                dgPublicaciones.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            }
            else
            {
                Interfaz.Interfaz.ponerLabel(grpPublicaciones, "Aún no tiene publicaciones.");
            }
            BaseDeDatos.cerrarConexion();
            return cont;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.paginaActual++;

            btnAnterior.Enabled = true;

            if (obtenerPublicaciones(paginaActual) <= 14)
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.paginaActual--;

            btnSiguiente.Enabled = true;
            obtenerPublicaciones(paginaActual);

            if (this.paginaActual == 1)
            {
                btnAnterior.Enabled = false;
            }
        }

        private void dgHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            int codPublicacion = Convert.ToInt32(dgPublicaciones.Rows[dgPublicaciones.CurrentRow.Index].Cells[0].Value);
            string estado = Convert.ToString(dgPublicaciones.Rows[dgPublicaciones.CurrentRow.Index].Cells[5].Value);

            if (estado.Equals("Finalizada") && e.ColumnIndex > 5)
            {
                Interfaz.Interfaz.emitirAviso("El estado de la publicación no permite realizar ningún tipo de cambio.");
                return;
            }

            // Toco el botón de modificar
            if (e.ColumnIndex == 6)
            {
                if (estado.Equals("Pausada"))
                {
                    Interfaz.Interfaz.emitirAviso("No puede modificar una publiación pausada.");
                    return;
                }
                Generar_Publicación.DetallePublicacion detallePublicacion = new Generar_Publicación.DetallePublicacion(codPublicacion, "modificar", estado);
                if (detallePublicacion.ShowDialog() == DialogResult.OK)
                {
                    obtenerPublicaciones(paginaActual);
                    actualizarPublicacionesGratuitas();
                }
            }
            // Toco el botón de play
            else if (e.ColumnIndex == 7)
            {
                if (!estado.Equals("Pausada") && !estado.Equals("Borrador"))
                {
                    Interfaz.Interfaz.emitirAviso("Solo se pueden activar publicaciones pausadas o en borrador.");
                    return;
                }

                if (Interfaz.Interfaz.emitirPregunta("¿Seguro desea activar la publicación?") == DialogResult.Yes)
                {
                    BaseDeDatos.agregarParametro(listaParametros, "@codPublicacion", codPublicacion);

                    BaseDeDatos.ejecutarSP("sp_PublicarPublicacion", listaParametros);

                    Generar_Publicación.DetallePublicacion.mostrarFactura(codPublicacion);

                    obtenerPublicaciones(paginaActual);
                }
            }
            // Toco el botón de pausa
            else if (e.ColumnIndex == 8)
            {
                if (!estado.Equals("Activa"))
                {
                    Interfaz.Interfaz.emitirAviso("Solo se pueden pausar publicaciones activas.");
                    return;
                }

                if (Interfaz.Interfaz.emitirPregunta("¿Seguro desea pausar la publicación?") == DialogResult.Yes)
                {
                    BaseDeDatos.agregarParametro(listaParametros, "@codPublicacion", codPublicacion);
                    BaseDeDatos.ejecutarSP("sp_PausarPublicacion", listaParametros);
                    obtenerPublicaciones(paginaActual);
                }
            }
            // Toco el botón de finalizar
            else if (e.ColumnIndex == 9)
            {
                if (Interfaz.Interfaz.emitirPregunta("¿Seguro desea finalizar la publicación? No podrá realizar ninguna acción más sobre la misma.") == DialogResult.Yes)
                {
                    BaseDeDatos.agregarParametro(listaParametros, "@codPublicacion", codPublicacion);
                    BaseDeDatos.ejecutarSP("sp_FinalizarPublicacion", listaParametros);
                    obtenerPublicaciones(paginaActual);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Generar_Publicación.DetallePublicacion detallePublicacion = new Generar_Publicación.DetallePublicacion(0, "agregar");
            detallePublicacion.ShowDialog();
            obtenerPublicaciones(paginaActual);
            actualizarPublicacionesGratuitas();
        }

        private void actualizarPublicacionesGratuitas()
        {
            int publiGratuitas = Interfaz.Interfaz.usuario.publicacionesGratuitas();

            if (publiGratuitas > 0)
                lblPGratuitas.Visible = true;
            else
                lblPGratuitas.Visible = false;
        }
    }
}
