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
using LOS_INSISTENTES.Interfaz;

namespace LOS_INSISTENTES.ABMUsuario
{
   partial class BajaEmpresa : Form
    {

        public List<Clases.Empresa> listadoEmpresas = new List<Clases.Empresa>();
        public SqlConnection conexion { get; set; }
        public int paginaActual { get; set; }

        public int obtenerEmpresas(int pagina)
        {

            dgEmpresa.AutoGenerateColumns = true;

            dgEmpresa.DataSource = null;
            dgEmpresa.Columns.Clear();
            listadoEmpresas.Clear();

            int cont = 0;
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@pagina", pagina);
            if (chRazonSocial.Checked)
            {
                BaseDeDatos.agregarParametro(listaParametros, "@razonSocial", tRazonSocial.Text);
            }
            else
            {
                BaseDeDatos.agregarParametro(listaParametros, "@razonSocial", null);
            }
            if (chCUIT.Checked)
            {
                BaseDeDatos.agregarParametro(listaParametros, "@cuit", tCUIT.Text);
            }
            else
            {
                BaseDeDatos.agregarParametro(listaParametros, "@cuit", null);
            }
            if (chMail.Checked)
            {
                BaseDeDatos.agregarParametro(listaParametros, "@email", tMail.Text);
            }
            else
            {
                BaseDeDatos.agregarParametro(listaParametros, "@email", null);
            }

            this.conexion = BaseDeDatos.iniciarConexion();

            SqlDataReader lector = BaseDeDatos.ejecutarReader("LOS_INSISTENTES.sp_ObtenerEmpresasPorPagina @pagina, @razonSocial, @cuit, @email", listaParametros, conexion);

            if (lector.HasRows)
            {

                while (lector.Read())
                {
                    cont++;

                    int ID_User = Convert.ToInt32(lector["ID_User"].ToString());
                    string Razon_Social = lector["Razon_Social"].ToString();
                    string CUIT = lector["CUIT"].ToString();
                    string Mail = lector["Mail"].ToString();

                    Clases.Empresa empresa = new Clases.Empresa(ID_User, Razon_Social, CUIT, Mail);
                    listadoEmpresas.Add(empresa);
                }


                dgEmpresa.DataSource = listadoEmpresas;

                dgEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;


                dgEmpresa.Columns[0].HeaderText = "# Empresa";
                dgEmpresa.Columns[1].HeaderText = "Razon Social";
                dgEmpresa.Columns[2].HeaderText = "Cuit";
                dgEmpresa.Columns[3].HeaderText = "Mail";

                dgEmpresa.Columns[0].Visible = false;

                dgEmpresa.Columns[1].Width = 200;
                dgEmpresa.Columns[2].Width = 200;
                dgEmpresa.Columns[3].Width = 200;

                dgEmpresa.AutoGenerateColumns = false;

                DataGridViewImageColumn cModificar = new DataGridViewImageColumn();

                cModificar.Image = Properties.Resources.modificar;
                cModificar.Width = 40;
                cModificar.ToolTipText = "Modificar empresa";
                dgEmpresa.Columns.Add(cModificar);

                DataGridViewImageColumn cFinalizar = new DataGridViewImageColumn();

                cFinalizar.Image = Properties.Resources.close;
                cFinalizar.Width = 40;
                cFinalizar.ToolTipText = "Borrar empresa";
                dgEmpresa.Columns.Add(cFinalizar);


                dgEmpresa.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);

            }
            else
            {
                Interfaz.Interfaz.emitirAviso("No hay datos con los filtros seleccionados.");
            }

            BaseDeDatos.cerrarConexion();
            return cont;
        }


      
        public BajaEmpresa()
        {
            InitializeComponent();
            this.CenterToScreen();

            this.paginaActual = 1;

            btnAnterior.Enabled = false;

            if (obtenerEmpresas(paginaActual) <= 9)
                btnSiguiente.Enabled = false;
            else
                btnSiguiente.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            chRazonSocial.Checked = false;
            chCUIT.Checked = false;
            chMail.Checked = false;
            
            Interfaz.Interfaz.limpiarInterfaz(this);

            tRazonSocial.Enabled = false;
            tCUIT.Enabled = false;
            tMail.Enabled = false;


            ABMUsuario.BajaEmpresa form = new ABMUsuario.BajaEmpresa();
            form.ShowDialog();
        }

        private void BajaEmpresa_Load(object sender, EventArgs e)
        {
            chRazonSocial.Checked = false;
            chCUIT.Checked = false;
            chMail.Checked = false;

            tRazonSocial.Enabled = false;
            tCUIT.Enabled = false;
            tMail.Enabled = false;
        }

        private void chRazonSocial_CheckedChanged(object sender, EventArgs e)
        {
            tRazonSocial.Enabled = chRazonSocial.Checked;
        }

        private void chCUIT_CheckedChanged(object sender, EventArgs e)
        {
            tCUIT.Enabled = chCUIT.Checked;
        }

        private void chMail_CheckedChanged(object sender, EventArgs e)
        {
            tMail.Enabled = chMail.Checked;
        }

        public Boolean chequearCampos()
        {
            if (chRazonSocial.Checked == true && campoVacio(tRazonSocial))
                    return Interfaz.Interfaz.emitirAviso("Debe ingresar la Razón Social de la Empresa.");

            if (chCUIT.Checked == true && campoVacio(tCUIT))
                return Interfaz.Interfaz.emitirAviso("Debe ingresar el CUIT.");

            if (chMail.Checked == true && !Interfaz.Interfaz.testEmail(tMail.Text))
                return Interfaz.Interfaz.emitirAviso("Ingrese un mail válido.");

            if ((chMail.Checked == false) && (chRazonSocial.Checked == false) && (chCUIT.Checked == false))
                return Interfaz.Interfaz.emitirAviso("Debe Seleccionar criterio de filtro para dar de Baja a la Empresa");

            return true;

        }

        public Boolean campoVacio(TextBox textbox)
        {
            return textbox.Text.Equals("");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (chequearCampos())
                obtenerEmpresas(this.paginaActual);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.paginaActual--;

            btnSiguiente.Enabled = true;
            obtenerEmpresas(paginaActual);

            if (this.paginaActual == 1)
                btnAnterior.Enabled = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.paginaActual++;

            btnAnterior.Enabled = true;

            if (obtenerEmpresas(paginaActual) <= 9)
                btnSiguiente.Enabled = false;
            else
                btnSiguiente.Enabled = true;
        }

        private void dgEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = Convert.ToString(dgEmpresa.Rows[dgEmpresa.CurrentRow.Index].Cells[1].Value);
            int idUser = Convert.ToInt32(dgEmpresa.Rows[dgEmpresa.CurrentRow.Index].Cells[0].Value);

            // Modificar
            if (e.ColumnIndex == 4)
            {
                ABMUsuario.AltaEmpresa form = new ABMUsuario.AltaEmpresa(idUser.ToString(), "", "modificar");
                if (form.ShowDialog() == DialogResult.OK)
                    obtenerEmpresas(paginaActual);
            }
            // Borrar
            if (e.ColumnIndex == 5)
            {
                if (Interfaz.Interfaz.emitirPregunta("¿Seguro desea dar de baja (lógica) la empresa " + nombre + "?") == DialogResult.Yes)
                {
                    List<SqlParameter> listaParametros = new List<SqlParameter>();
                    BaseDeDatos.agregarParametro(listaParametros, "@ID_User", idUser);
                    BaseDeDatos.ejecutarSP("sp_DeshabilitarUsuario", listaParametros);
                    obtenerEmpresas(paginaActual);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
