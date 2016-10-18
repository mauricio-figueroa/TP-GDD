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
    public partial class CalificarVendedor : Form
    {
        public List<Clases.Operacion> listadoOperacionesSinCalificar = new List<Clases.Operacion>();
        public SqlConnection conexion { get; set; }
        public int paginaActual { get; set; }
        public int idUser = Interfaz.Interfaz.usuario.ID_User;

        public CalificarVendedor()
        {
            InitializeComponent();
            this.CenterToScreen();

            this.paginaActual = 1;
            obtenerOperacionesSinCalificar(paginaActual);

            

           dgUltimasCalificacioens.DataSource =  obtenerUltimasCalificaciones(idUser);

          
        }

        public void actualizarTotales()
        {
            //Tipo de compra es 1
            llenarLabel(lblEstrellaC1, 1, 1);
            llenarLabel(lblEstrellaC2, 2, 1);
            llenarLabel(lblEstrellaC3, 3, 1);
            llenarLabel(lblEstrellaC4, 4, 1);
            llenarLabel(lblEstrellaC5, 5, 1);

            int totalCompras = Convert.ToInt32(lblEstrellaC1.Text) + Convert.ToInt32(lblEstrellaC2.Text) + Convert.ToInt32(lblEstrellaC3.Text) + Convert.ToInt32(lblEstrellaC4.Text) + Convert.ToInt32(lblEstrellaC5.Text);
            lblComprasTotal.Text = totalCompras.ToString();


            //Tipo de subasta es 0
            llenarLabel(lblEstrellaS1, 1, 0);
            llenarLabel(lblEstrellaS2, 2, 0);
            llenarLabel(lblEstrellaS3, 3, 0);
            llenarLabel(lblEstrellaS4, 4, 0);
            llenarLabel(lblEstrellaS5, 5, 0);

            int totalSubastas = Convert.ToInt32(lblEstrellaS1.Text) + Convert.ToInt32(lblEstrellaS2.Text) + Convert.ToInt32(lblEstrellaS3.Text) + Convert.ToInt32(lblEstrellaS4.Text) + Convert.ToInt32(lblEstrellaS5.Text);
            lblTotalSubastas.Text = totalSubastas.ToString();
        }

        public void llenarLabel(Label lbl, int estrellas, int tipo)
        {
            lbl.Text = obtenerCantidadDeEstrellas(estrellas, tipo);
            lbl.TextAlign = ContentAlignment.MiddleRight;
        }

       

        public String obtenerCantidadDeEstrellas(int estrella, int tipo)
        {
            string retorno = "0";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", idUser);
            BaseDeDatos.agregarParametro(listaParametros, "@Estrella", estrella);
            BaseDeDatos.agregarParametro(listaParametros, "@Tipo", tipo);
            SqlDataReader lector = BaseDeDatos.ejecutarReader("SELECT COUNT(*) AS Total FROM LOS_INSISTENTES.Calificaciones ca JOIN LOS_INSISTENTES.Compras co on co.Cod_Calificacion = ca.Cod_Calificacion JOIN LOS_INSISTENTES.Publicaciones p ON p.cod_publicacion  = co.cod_publicacion WHERE p.cod_tipoPublicacion = @Tipo AND Puntaje = @Estrella AND ID_Comprador = @ID_User;", listaParametros, BaseDeDatos.iniciarConexion());


            if (lector.Read())
            {
                retorno = Convert.ToString(lector["Total"]);
            }

            BaseDeDatos.cerrarConexion();
            return retorno;
                 

        }

        private object obtenerUltimasCalificaciones(int idComprador)
        {

            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_Comprador", idComprador);


            String commandtext = "SELECT TOP 5 Producto, Vendedor, Fecha, Puntaje, Descripcion FROM LOS_INSISTENTES.vw_UltimasCincoCalificaciones WHERE ID_Comprador = @ID_Comprador order by Cod_Calificacion DESC";

            return BaseDeDatos.obtenerDataTable(commandtext, "T", listaParametros);
        }


        public int obtenerOperacionesSinCalificar(int pagina)
        {

            dgCalificar.AutoGenerateColumns = true;

            dgCalificar.DataSource = null;
            dgCalificar.Columns.Clear();
            listadoOperacionesSinCalificar.Clear();

            int cont = 0;
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", idUser);
            BaseDeDatos.agregarParametro(listaParametros, "@Pagina", pagina);
            this.conexion = BaseDeDatos.iniciarConexion();
            SqlDataReader lector = BaseDeDatos.ejecutarReader("EXEC LOS_INSISTENTES.sp_ObtenerCalificacionesPendientes @Pagina, @ID_User", listaParametros, conexion);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    cont++;

                    int Cod_Operacion = Convert.ToInt32(lector["Cod_Publicacion"].ToString());
                    int Cod_Calificacion = Convert.ToInt32(lector["Cod_Calificacion"].ToString());
                    string Descripcion = lector["Descripcion"].ToString();
                    string Tipo_Operacion = lector["Tipo"].ToString();
                    double Monto_Oferta = Convert.ToDouble(lector["Monto_Compra"]);
                    DateTime Fecha_Operacion = Convert.ToDateTime(lector["Fecha_Operacion"].ToString());

                    Clases.Operacion operacion = new Clases.Operacion(Cod_Operacion, Cod_Calificacion, Descripcion, Fecha_Operacion, Monto_Oferta, Tipo_Operacion);

                    listadoOperacionesSinCalificar.Add(operacion);
                }

                dgCalificar.DataSource = listadoOperacionesSinCalificar;

                dgCalificar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;


                dgCalificar.Columns[0].Visible = false;
                dgCalificar.Columns[1].Visible = false;
                dgCalificar.Columns[2].HeaderText = "Descripción";
                dgCalificar.Columns[3].HeaderText = "Fecha";
                dgCalificar.Columns[4].HeaderText = "Monto";
                dgCalificar.Columns[5].HeaderText = "Tipo";

                dgCalificar.Columns[2].Width = 280;
                dgCalificar.Columns[3].Width = 80;
                dgCalificar.Columns[4].Width = 80;
                dgCalificar.Columns[5].Width = 120;

                dgCalificar.AutoGenerateColumns = false;

                DataGridViewButtonColumn bCalificar = new DataGridViewButtonColumn();

                dgCalificar.Columns.Add(bCalificar);
                bCalificar.HeaderText = "Calificar";
                bCalificar.Text = "Calificar";
                bCalificar.Name = "btnCalificar";
                bCalificar.Width = 120;
                bCalificar.UseColumnTextForButtonValue = true;
                bCalificar.Resizable = DataGridViewTriState.False;

                dgCalificar.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
                Interfaz.Interfaz.quitarLabel(grpHistorial);
            }
            else
            {
                Interfaz.Interfaz.ponerLabel(grpHistorial, "No hay compras para calificar");
            }
            BaseDeDatos.cerrarConexion();
            actualizarTotales();
            return cont;
        }

       
        private void dgCalificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int codCalificacion = Convert.ToInt32(dgCalificar.Rows[dgCalificar.CurrentRow.Index].Cells[1].Value);
                string descripcion = Convert.ToString(dgCalificar.Rows[dgCalificar.CurrentRow.Index].Cells[2].Value);
                Calificar.DetalleCalificacion detalleCalificacion = new Calificar.DetalleCalificacion(codCalificacion, descripcion);
                if (detalleCalificacion.ShowDialog() == DialogResult.OK)
                {
                    obtenerOperacionesSinCalificar(paginaActual);

                    dgUltimasCalificacioens.DataSource = obtenerUltimasCalificaciones(idUser);
                }
            }
        }

        private void dgUltimasCalificacioens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CalificarVendedor_Load(object sender, EventArgs e)
        {

        }

       
    }
}
