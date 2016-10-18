using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOS_INSISTENTES.Historial_Cliente
{
    public partial class HistorialCliente : Form
    {
        public List<Clases.Operacion> listadoOperaciones = new List<Clases.Operacion>();
        public int paginaActual { get; set; }
        public int idUser = Interfaz.Interfaz.usuario.ID_User;

        public int cantEstrellas = 0;
        public double promedio = 0;

        public int cantComprasSinCalificar = Interfaz.Interfaz.usuario.ObtenerComprasSinCalificar();

        public int obtenerOperaciones (int pagina)
        {
            dgHistorial.AutoGenerateColumns = true;

            dgHistorial.DataSource = null;
            dgHistorial.Columns.Clear();
            listadoOperaciones.Clear();

            int cont = 0;
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@Pagina", pagina);
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", idUser);
            SqlDataReader lector = BaseDeDatos.ejecutarReader("EXEC LOS_INSISTENTES.sp_ObtenerComprasYSubastasPorPagina @Pagina, @ID_User", listaParametros, BaseDeDatos.iniciarConexion());
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    cont++;

                    int Cod_Operacion = Convert.ToInt32(lector["Cod_Publicacion"].ToString());
                    string Descripcion = lector["Descripcion"].ToString();
                    string Tipo_Operacion = lector["Tipo"].ToString();
                    double Monto_Oferta = Convert.ToDouble(lector["Monto_Oferta"]);
                    DateTime Fecha_Operacion = Convert.ToDateTime(lector["Fecha_Operacion"].ToString());


                    Clases.Operacion operacion = new Clases.Operacion(Cod_Operacion, 0, Descripcion, Fecha_Operacion, Monto_Oferta, Tipo_Operacion);

                    listadoOperaciones.Add(operacion);
                }

                dgHistorial.DataSource = listadoOperaciones;

                dgHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;


                dgHistorial.Columns[0].Visible = false;
                dgHistorial.Columns[1].Visible = false;
                dgHistorial.Columns[2].HeaderText = "Descripción";
                dgHistorial.Columns[3].HeaderText = "Fecha";
                dgHistorial.Columns[4].HeaderText = "Monto";
                dgHistorial.Columns[5].HeaderText = "Tipo";

                dgHistorial.Columns[2].Width = 280;
                dgHistorial.Columns[3].Width = 120;
                dgHistorial.Columns[4].Width = 120;
                dgHistorial.Columns[5].Width = 120;

                dgHistorial.AutoGenerateColumns = false;

                DataGridViewImageColumn cDetalles = new DataGridViewImageColumn();

                cDetalles.Image = Properties.Resources.ver;
                cDetalles.Width = 40;
                dgHistorial.Columns.Add(cDetalles);

                dgHistorial.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            }
            else
            {
                Interfaz.Interfaz.ponerLabel(grpHistorial, "Su historial se encuentra vacío.");
            }
            BaseDeDatos.cerrarConexion();
            return cont;
        }

        public void ObtenerResumenEstrellas()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_user", idUser);
            SqlDataReader lectorResumen = BaseDeDatos.ejecutarReader("SELECT * FROM LOS_INSISTENTES.vw_ResumenEstrellas WHERE ID_User = @ID_User", listaParametros, BaseDeDatos.iniciarConexion());
            if (lectorResumen.Read())
            {
                this.cantEstrellas = Convert.ToInt32(lectorResumen["Cant_Estrellas"]);
                this.promedio = Convert.ToDouble(lectorResumen["Promedio"]);
            }
            BaseDeDatos.cerrarConexion();
        }

        public HistorialCliente()
        {
            InitializeComponent();
            CenterToScreen();

            paginaActual = 1;

            btnAnterior.Enabled = false;

            if (obtenerOperaciones(paginaActual) <= 9)
                btnSiguiente.Enabled = false;
            else
                btnSiguiente.Enabled = true;

            ObtenerResumenEstrellas();

            lblEstrellas.Text = "      Usted tiene " + cantEstrellas + " estrellas con un promedio de " + promedio;
            lblCompras.Text = "      Usted tiene " + cantComprasSinCalificar + " compras por calificar.";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaActual++;

            btnAnterior.Enabled = true;

            if (obtenerOperaciones(paginaActual) <= 9)
                btnSiguiente.Enabled = false;
            else
                btnSiguiente.Enabled = true;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            paginaActual--;

            btnSiguiente.Enabled = true;
            obtenerOperaciones(paginaActual);

            if (paginaActual == 1)
                btnAnterior.Enabled = false;
        }

        private void dgHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int codPublicacion = Convert.ToInt32(dgHistorial.Rows[dgHistorial.CurrentRow.Index].Cells[0].Value);
                Generar_Publicación.DetallePublicacion detallePublicacion = new Generar_Publicación.DetallePublicacion(codPublicacion, "ver");
                detallePublicacion.ShowDialog();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

    }
}
