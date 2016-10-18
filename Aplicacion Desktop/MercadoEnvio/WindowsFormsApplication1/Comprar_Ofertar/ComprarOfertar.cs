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
using LOS_INSISTENTES.Clases;
using LOS_INSISTENTES.Interfaz;

namespace LOS_INSISTENTES.ComprarOfertar
{
     public partial class ComprarOfertar : Form
    {
        public int paginaFinal { get; set; }
        public List<Clases.Comprar> listadoComprarOfertar = new List<Clases.Comprar>();
        public SqlConnection conexion { get; set; }
        public int paginaActual { get; set; }

        public int idUser = Interfaz.Interfaz.usuario.ID_User;

        Interfaz.Interfaz interfaz = new Interfaz.Interfaz();

        public ComprarOfertar()
        {
            InitializeComponent();
            this.CenterToScreen();

            this.dgComprarOfertar.BorderStyle = BorderStyle.None;

            interfaz.cargarComboIDValor(lstRubros, "SELECT ID_Rubro AS id, Descripcion as valor FROM LOS_INSISTENTES.Rubros ORDER BY Descripcion;");

            lstRubros.ClearSelected();

            this.paginaActual = 1;

            Interfaz.Interfaz.ponerLabel(grpPublicaciones, "Por favor seleccion un filtro de búsqueda\n para sus compras.");
        }


        public int obtenerComprarOfertar(int pagina)
        {
            
            dgComprarOfertar.AutoGenerateColumns = true;

            dgComprarOfertar.DataSource = null;
            dgComprarOfertar.Columns.Clear();
            listadoComprarOfertar.Clear();

            string idRubros = null;

            foreach (var idRubro in lstRubros.SelectedItems)
                idRubros += idRubros + "," + ((DataRowView)idRubro)["id"].ToString();

            if (idRubros != null)
                idRubros = idRubros.Substring(1, idRubros.Length - 1);

            string descripcion = tDescripción.Text;

            int cont = 0;

            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", idUser);
            BaseDeDatos.agregarParametro(listaParametros, "@ID_Rubros", idRubros);
            BaseDeDatos.agregarParametro(listaParametros, "@Descripcion", descripcion);
            this.conexion = BaseDeDatos.iniciarConexion();
            SqlDataReader lector = BaseDeDatos.ejecutarReader("LOS_INSISTENTES.sp_ObtenerCantidadPaginasPosiblesCompras @ID_User, @ID_Rubros, @Descripcion", listaParametros, conexion);
            if (lector.HasRows)
            {
                lector.Read();
                paginaFinal = Convert.ToInt32(lector["Paginas"])+1;
                BaseDeDatos.cerrarConexion();
            }
                
            listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", idUser);
            BaseDeDatos.agregarParametro(listaParametros, "@Pagina", pagina);
            BaseDeDatos.agregarParametro(listaParametros, "@ID_Rubros", idRubros);
            BaseDeDatos.agregarParametro(listaParametros, "@Descripcion", descripcion);
            this.conexion = BaseDeDatos.iniciarConexion();
            lector = BaseDeDatos.ejecutarReader("LOS_INSISTENTES.sp_ObtenerPosiblesCompras @Pagina, @ID_User, @ID_Rubros, @Descripcion", listaParametros, conexion);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    cont++;

                    int Cod_Publicacion = Convert.ToInt32(lector["Cod_Publicacion"].ToString());
                    int Stock = Convert.ToInt32(lector["Stock"]);
                    bool Permite_Envios = Convert.ToBoolean(lector["Permite_Envios"]);
                    string Descripcion = lector["Descripcion"].ToString();
                    string Rubro = lector["Rubro"].ToString();
                    string Tipo = lector["Tipo"].ToString();
                    string Estado = lector["Estado"].ToString();
                    double MontoCompra = Convert.ToDouble(lector["montoCompra"]);

                    Clases.Comprar compra = new Clases.Comprar(Cod_Publicacion, Stock, Permite_Envios, Descripcion, Rubro, Tipo, Estado, MontoCompra);

                    listadoComprarOfertar.Add(compra);
                }

                dgComprarOfertar.DataSource = listadoComprarOfertar;

                dgComprarOfertar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                dgComprarOfertar.Columns[0].Visible = false;
                dgComprarOfertar.Columns[1].Visible = false;
                dgComprarOfertar.Columns[2].Visible = false;
                dgComprarOfertar.Columns[3].HeaderText = "Descripción";
                dgComprarOfertar.Columns[4].HeaderText = "Rubro";
                dgComprarOfertar.Columns[5].HeaderText = "Tipo";
                dgComprarOfertar.Columns[6].HeaderText = "Estado";

                dgComprarOfertar.Columns[3].Width = 220;
                dgComprarOfertar.Columns[4].Width = 160;
                dgComprarOfertar.Columns[5].Width = 120;
                dgComprarOfertar.Columns[6].Width = 80;
                dgComprarOfertar.Columns[7].Width = 80;

                DataGridViewButtonColumn bComprar = new DataGridViewButtonColumn();
                
                dgComprarOfertar.Columns.Add(bComprar);
                bComprar.HeaderText = "Comprar";
                bComprar.Text = "Comprar/Ofertar";
                bComprar.Name = "btnComprar";
                bComprar.Width = 120;
                bComprar.UseColumnTextForButtonValue = true;
                bComprar.Resizable = DataGridViewTriState.False;

                dgComprarOfertar.AutoGenerateColumns = false;

                dgComprarOfertar.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
                Interfaz.Interfaz.quitarLabel(grpPublicaciones);
            }
            else
            {
                Interfaz.Interfaz.emitirAviso("No hay datos con los filtros seleccionados");
            }
            BaseDeDatos.cerrarConexion();

            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimaPagina.Enabled = false;
            btnPrimeraPagina.Enabled = false;

            if (cont > 14)
            {
                btnUltimaPagina.Enabled = true;
                btnSiguiente.Enabled = true;
            }

            if (paginaActual > 1)
            {
                btnPrimeraPagina.Enabled = true;
                btnAnterior.Enabled = true;
            }


            return cont;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstRubros.ClearSelected();
            tDescripción.Text = null;

            paginaActual = 1;
            obtenerComprarOfertar(paginaActual);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

            paginaActual = 1;
            obtenerComprarOfertar(paginaActual);

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.paginaActual--;

            obtenerComprarOfertar(paginaActual);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.paginaActual++;

            obtenerComprarOfertar(paginaActual);
        }

        private void dgComprarOfertar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                string estado = dgComprarOfertar.Rows[dgComprarOfertar.CurrentRow.Index].Cells[6].Value.ToString();

                if (estado.Equals("Pausada"))
                {
                    Interfaz.Interfaz.emitirAviso("La publicación se encuentra pausada, no se puede comprar ni ofertar.");
                    return;
                }

                if (Interfaz.Interfaz.usuario.ObtenerComprasSinCalificar() >= Convert.ToInt32(Interfaz.Interfaz.obtenerConfiguracion("LimiteCalificaciones")))
                {
                    Interfaz.Interfaz.emitirAviso("Usted no puede ofertar hasta no realizar las calificaciones pendientes");
                    return;
                }

                int codPublicacion = Convert.ToInt32(dgComprarOfertar.Rows[dgComprarOfertar.CurrentRow.Index].Cells[0].Value);
                int stock = Convert.ToInt32(dgComprarOfertar.Rows[dgComprarOfertar.CurrentRow.Index].Cells[1].Value);
                bool permiteEnvios = Convert.ToBoolean(dgComprarOfertar.Rows[dgComprarOfertar.CurrentRow.Index].Cells[2].Value);
                string descripcion = dgComprarOfertar.Rows[dgComprarOfertar.CurrentRow.Index].Cells[3].Value.ToString();
                string tipo = dgComprarOfertar.Rows[dgComprarOfertar.CurrentRow.Index].Cells[5].Value.ToString();
                double precio = Convert.ToDouble(dgComprarOfertar.Rows[dgComprarOfertar.CurrentRow.Index].Cells[7].Value);

                Clases.Comprar compra = new Clases.Comprar(codPublicacion, stock, permiteEnvios, descripcion, null, tipo, null, precio);

                Comprar_Ofertar.DetalleCompra dialogo = new Comprar_Ofertar.DetalleCompra(idUser, compra);

                if (dialogo.ShowDialog() == DialogResult.OK)
                    obtenerComprarOfertar(paginaActual);
            }
        }

        private void btnPrimeraPagina_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            obtenerComprarOfertar(paginaActual);
        }

        private void btnUltimaPagina_Click(object sender, EventArgs e)
        {
            paginaActual = paginaFinal;
            obtenerComprarOfertar(paginaActual);            
        }
    }
}
