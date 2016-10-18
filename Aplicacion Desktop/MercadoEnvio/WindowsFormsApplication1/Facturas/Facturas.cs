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

namespace LOS_INSISTENTES.Facturas
{
    public partial class Facturas : Form
    {
        public List<Clases.Factura> listadoFacturas = new List<Clases.Factura>();
        public SqlConnection conexion { get; set; }
        public int paginaActual { get; set; }

        public int idUser = Interfaz.Interfaz.usuario.ID_User;

        public Facturas()
        {
            InitializeComponent();
            CenterToParent();

            dtFechaDesde.Value = DateTime.Now.AddMonths(-1);

            paginaActual = 1;

            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;

            if (obtenerFacturas(paginaActual) <= 9)
                btnSiguiente.Enabled = false;
            else
                btnSiguiente.Enabled = true;
        }

        public int obtenerFacturas(int pagina)
        {

            dgFacturas.AutoGenerateColumns = true;

            dgFacturas.DataSource = null;
            dgFacturas.Columns.Clear();
            listadoFacturas.Clear();

            int cont = 0;
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@Pagina", pagina);
            BaseDeDatos.agregarParametro(listaParametros, "@ID_User", idUser);
            if (chkFecha.Checked)
            {
                BaseDeDatos.agregarParametro(listaParametros, "@fechaDesde", dtFechaDesde.Value);
                BaseDeDatos.agregarParametro(listaParametros, "@fechaHasta", dtFechaHasta.Value);
            }
            else
            {
                BaseDeDatos.agregarParametro(listaParametros, "@fechaDesde", null);
                BaseDeDatos.agregarParametro(listaParametros, "@fechaHasta", null);
            }
            if (chkImporte.Checked)
            {
                BaseDeDatos.agregarParametro(listaParametros, "@importeDesde", Convert.ToDouble(tImporteDesde.Text));
                BaseDeDatos.agregarParametro(listaParametros, "@importeHasta", Convert.ToDouble(tImporteHasta.Text));
            }
            else
            {
                BaseDeDatos.agregarParametro(listaParametros, "@importeDesde", null);
                BaseDeDatos.agregarParametro(listaParametros, "@importeHasta", null);
            }
            if (chkDescripcion.Checked)
                BaseDeDatos.agregarParametro(listaParametros, "@concepto", tDescripcion.Text);
            else
                BaseDeDatos.agregarParametro(listaParametros, "@concepto", null);

            this.conexion = BaseDeDatos.iniciarConexion();

            SqlDataReader lector = BaseDeDatos.ejecutarReader("EXEC LOS_INSISTENTES.sp_FacturasRealizadasPorPagina @Pagina, @ID_User, @fechaDesde, @fechaHasta, @importeDesde, @importeHasta, @concepto", listaParametros, conexion);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    cont++;

                    int Nro_Factura = Convert.ToInt32(lector["Nro_Factura"].ToString());
                    string Forma_Pago = lector["Forma_Pago"].ToString();
                    double Total_Facturacion = Convert.ToDouble(lector["Total_Facturacion"]);
                    DateTime Factura_Fecha = Convert.ToDateTime(lector["Factura_Fecha"].ToString());
                    string NombreComprador = ""; // lector["NombreComprador"].ToString();


                    Clases.Factura factura = new Clases.Factura(Nro_Factura, Forma_Pago, Total_Facturacion, Factura_Fecha, NombreComprador);
                    listadoFacturas.Add(factura);
                }

                dgFacturas.DataSource = listadoFacturas;

                dgFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;


                dgFacturas.Columns[0].HeaderText = "# Factura";
                dgFacturas.Columns[1].HeaderText = "Forma Pago";
                dgFacturas.Columns[2].HeaderText = "Total ($)";
                dgFacturas.Columns[3].HeaderText = "Fecha";
                dgFacturas.Columns[4].HeaderText = "Comprador";

                dgFacturas.Columns[4].Visible = false;

                dgFacturas.Columns[1].Width = 100;
                dgFacturas.Columns[2].Width = 100;
                dgFacturas.Columns[3].Width = 100;
                dgFacturas.Columns[4].Width = 200;

                dgFacturas.AutoGenerateColumns = false;

                DataGridViewImageColumn cDetalles = new DataGridViewImageColumn();

                cDetalles.Image = Properties.Resources.ver;
                cDetalles.Width = 40;
                dgFacturas.Columns.Add(cDetalles);
                dgFacturas.Cursor = Cursors.Hand;

                dgFacturas.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);

            }
            else if (chkDescripcion.Checked || chkFecha.Checked || chkImporte.Checked)
            {
                Interfaz.Interfaz.emitirAviso("No hay datos con los filtros seleccionados.");
            }
            else
            {
                Interfaz.Interfaz.ponerLabel(grpFacturas, "Aún no tiene facturas generadas.");
            }
            BaseDeDatos.cerrarConexion();
            return cont;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.paginaActual++;

            btnAnterior.Enabled = true;

            if (obtenerFacturas(paginaActual) <= 9)
                btnSiguiente.Enabled = false;
            else
                btnSiguiente.Enabled = true;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.paginaActual--;

            btnSiguiente.Enabled = true;
            obtenerFacturas(paginaActual);

            if (this.paginaActual == 1)
                btnAnterior.Enabled = false;
        }

        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int nroFactura = Convert.ToInt32(dgFacturas.Rows[dgFacturas.CurrentRow.Index].Cells[0].Value);
                DetalleFactura detalleFactura = new DetalleFactura(nroFactura);
                detalleFactura.ShowDialog();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtFechaDesde.Enabled = !dtFechaDesde.Enabled;
            dtFechaHasta.Enabled = !dtFechaHasta.Enabled;
        }

        private void chkImporte_CheckedChanged(object sender, EventArgs e)
        {
            tImporteDesde.Enabled = !tImporteDesde.Enabled;
            tImporteHasta.Enabled = !tImporteHasta.Enabled;
        }

        private void chkDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            tDescripcion.Enabled = !tDescripcion.Enabled;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!chkDescripcion.Checked && !chkFecha.Checked && !chkImporte.Checked)
            {
                Interfaz.Interfaz.emitirAviso("Por favor elija al menos uno de los filtros.");
                return;
            }
            if (obtenerFacturas(1) <= 9)
                btnSiguiente.Enabled = false;
            else
                btnSiguiente.Enabled = true;
        }

        private void tImporteDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e, true);
        }

        private void tImporteHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interfaz.Interfaz.soloNumeros(e, true);
        }

        private void dtFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            dtFechaHasta.Value = dtFechaDesde.Value.AddMonths(1);
        }

        private void dtFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            dtFechaDesde.Value = dtFechaHasta.Value.AddMonths(-1);
        }

    }
}
