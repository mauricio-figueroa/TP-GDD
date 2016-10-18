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
using System.Security.Cryptography;
using LOS_INSISTENTES.Interfaz;



namespace LOS_INSISTENTES.ABMUsuario
{
    public partial class BajaCliente : Form
    {

        public List<Clases.Cliente> listadoClientes = new List<Clases.Cliente>();
        public SqlConnection conexion { get; set; }
        public int paginaActual { get; set; }
       

        Interfaz.Interfaz interfaz = new Interfaz.Interfaz();
        
        public int obtenerClientes(int pagina)
        {

            dgCliente.AutoGenerateColumns = true;

            dgCliente.DataSource = null;
            dgCliente.Columns.Clear();
           listadoClientes.Clear();

            int cont = 0;
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            BaseDeDatos.agregarParametro(listaParametros, "@pagina", pagina);
           
            if (chNombre.Checked)
            {
                BaseDeDatos.agregarParametro(listaParametros, "@nombre", tNombre.Text);
            }
            else
            {
                BaseDeDatos.agregarParametro(listaParametros, "@nombre", null);
            }
            if (chApellido.Checked)
            {
                BaseDeDatos.agregarParametro(listaParametros, "@apellido", tApellido.Text);
            }
            else
            {
                BaseDeDatos.agregarParametro(listaParametros, "@apellido", null);
            }
            if (chTipoDeDocumento.Checked)
            {
                BaseDeDatos.agregarParametro(listaParametros, "@tipoDoc", cbTipoDeDocumento.Text);
            }
            else
            {
                BaseDeDatos.agregarParametro(listaParametros, "@tipoDoc", null);
            }

            if (chNumeroDeDocumento.Checked)
            {
                BaseDeDatos.agregarParametro(listaParametros, "@numeroDoc", tNumeroDeDocumento.Text);
            }
            else
            {
                BaseDeDatos.agregarParametro(listaParametros, "@numeroDoc", null);
            }
            if (chMail.Checked)
            {
                BaseDeDatos.agregarParametro(listaParametros, "@mail", tMail.Text);
            }
            else
            {
                BaseDeDatos.agregarParametro(listaParametros, "@mail", null);
            }


            this.conexion = BaseDeDatos.iniciarConexion();

            SqlDataReader lector = BaseDeDatos.ejecutarReader("LOS_INSISTENTES.sp_ObtenerClientesPorPagina @pagina, @nombre, @apellido, @mail, @tipoDoc, @numeroDoc", listaParametros, conexion);


            // SqlDataReader lector = BaseDeDatos.ejecutarReader("EXEC LOS_INSISTENTES.sp_DeshabilitarUsuario @Pagina, @ID_User, @Nombre, @Apellido, @Tipo_Doc, @Num_Doc, @Mail", listaParametros, conexion);
            if (lector.HasRows)
            {
                
                while (lector.Read())
                {
                    cont++;

                    int ID_User = Convert.ToInt32(lector["ID_User"].ToString());
                    string Nombre = lector["Nombre"].ToString();
                    string Apellido = lector["Apellido"].ToString();
                    string Tipo_Doc = lector["Tipo_Doc"].ToString();
                    int Num_Doc = Convert.ToInt32(lector["Num_Doc"].ToString());
                    string Mail = lector["Mail"].ToString();




                    Clases.Cliente cliente = new Clases.Cliente(ID_User, Nombre, Apellido, Tipo_Doc, Num_Doc, Mail);
                    listadoClientes.Add(cliente);
                }
                 

               dgCliente.DataSource = listadoClientes;

                dgCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;


               dgCliente.Columns[0].HeaderText = "# Cliente";
                dgCliente.Columns[1].HeaderText = "Nombre";
                dgCliente.Columns[2].HeaderText = "Apellido";
                dgCliente.Columns[3].HeaderText = "Tipo";
                dgCliente.Columns[4].HeaderText = "# Doc";
                dgCliente.Columns[5].HeaderText = "Correo";

                dgCliente.Columns[0].Visible = false;

                dgCliente.Columns[1].Width = 100;
                dgCliente.Columns[2].Width = 100;
                dgCliente.Columns[3].Width = 50;
                dgCliente.Columns[4].Width = 80;
                dgCliente.Columns[5].Width = 160;


                dgCliente.AutoGenerateColumns = false;

                DataGridViewImageColumn cModificar = new DataGridViewImageColumn();

                cModificar.Image = Properties.Resources.modificar;
                cModificar.Width = 40;
                cModificar.ToolTipText = "Modificar cliente";
                dgCliente.Columns.Add(cModificar);

                DataGridViewImageColumn cFinalizar = new DataGridViewImageColumn();

                cFinalizar.Image = Properties.Resources.close;
                cFinalizar.Width = 40;
                cFinalizar.ToolTipText = "Borrar cliente";
                dgCliente.Columns.Add(cFinalizar);




                dgCliente.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);

                
            }
            else
            {
                Interfaz.Interfaz.emitirAviso("No hay datos con los filtros seleccionados.");
            }

                
            BaseDeDatos.cerrarConexion();
            return cont;
        }



        String usuario;
        String pass;
        

        public BajaCliente(String user,String pas)
        {
            this.usuario = user;
            this.pass = pas;
            InitializeComponent();
        }
        public BajaCliente()
        {
            InitializeComponent();
            this.CenterToScreen();

            

            this.paginaActual = 1;

            btnAnterior.Enabled = false;

            if (obtenerClientes(paginaActual) <= 9)
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
            }
        }
        public Boolean campoVacio(TextBox textbox)
        {
            return textbox.Text.Equals("");
        }

        public Boolean chequearCampos()
        {
            if (chNombre.Checked == true && campoVacio(tNombre))
                return Interfaz.Interfaz.emitirAviso("Debe ingresar el nombre del cliente.");

            if (chApellido.Checked == true && campoVacio(tApellido))
                return Interfaz.Interfaz.emitirAviso("Debe ingresar el apellido del cliente.");

            if (chTipoDeDocumento.Checked == true && cbTipoDeDocumento.SelectedIndex == -1)
                return Interfaz.Interfaz.emitirAviso("Debe Seleccionar el Tipo de Documento del cliente.");

            if (chNumeroDeDocumento.Checked == true && campoVacio(tNumeroDeDocumento))
                return Interfaz.Interfaz.emitirAviso("Debe ingresar el Número de Documento del cliente.");

            if (chMail.Checked == true && !Interfaz.Interfaz.testEmail(tMail.Text))
                return Interfaz.Interfaz.emitirAviso("Debe ingresar un correo válido.");

            if ((chNombre.Checked == false) && (chMail.Checked == false) && (chApellido.Checked == false) && (chTipoDeDocumento.Checked == false) && (chNumeroDeDocumento.Checked == false) && (chMail.Checked == false))
                return Interfaz.Interfaz.emitirAviso("Debe Seleccionar criterio de filtro para dar de Baja a la Empresa");

            return true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (chequearCampos())
                obtenerClientes(this.paginaActual);
        }

        private void cbNombre_CheckedChanged(object sender, EventArgs e)
        {
                tNombre.Enabled = chNombre.Checked;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            chNombre.Checked = false;
            chApellido.Checked = false;
            chTipoDeDocumento.Checked = false;
            chNumeroDeDocumento.Checked = false;
            chMail.Checked = false;

            Interfaz.Interfaz.limpiarInterfaz(this);

            tNombre.Enabled = false;
            tApellido.Enabled = false;
            cbTipoDeDocumento.Enabled = false;
            tNumeroDeDocumento.Enabled = false;
            tMail.Enabled = false;
        }



        private void _3ClienteBaja_Load(object sender, EventArgs e)
        {
            tNombre.Enabled = false;
            tApellido.Enabled = false;
            cbTipoDeDocumento.Enabled = false;
            tNumeroDeDocumento.Enabled = false;
            tMail.Enabled = false;
            
        }

        private void chMail_CheckedChanged(object sender, EventArgs e)
        {
                tMail.Enabled = chMail.Checked;
        }

        private void chNumeroDeDocumento_CheckedChanged(object sender, EventArgs e)
        {
                tNumeroDeDocumento.Enabled = chNumeroDeDocumento.Checked;
        }

        private void chTipoDeDocumento_CheckedChanged(object sender, EventArgs e)
        {
                cbTipoDeDocumento.Enabled = chTipoDeDocumento.Checked;
        }

        private void chApellido_CheckedChanged(object sender, EventArgs e)
        {
                tApellido.Enabled = chApellido.Checked;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.paginaActual++;

            btnAnterior.Enabled = true;

            if (obtenerClientes(paginaActual) <= 9)
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
            obtenerClientes(paginaActual);

            if (this.paginaActual == 1)
            {
                btnAnterior.Enabled = false;
            }
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string nombre = Convert.ToString(dgCliente.Rows[dgCliente.CurrentRow.Index].Cells[2].Value);
            int idUser = Convert.ToInt32(dgCliente.Rows[dgCliente.CurrentRow.Index].Cells[0].Value);

            // Modificar
            if (e.ColumnIndex == 6)
            {
                ABMUsuario.AltaCliente form = new ABMUsuario.AltaCliente(idUser.ToString(), "", "modificar");
                if (form.ShowDialog() == DialogResult.OK)
                    obtenerClientes(paginaActual);
            }
            // Borrar
            if (e.ColumnIndex == 7)
            {
                if (Interfaz.Interfaz.emitirPregunta("¿Seguro desea dar de baja (lógica) el cliente " + nombre + "?") == DialogResult.Yes)
                {
                    List<SqlParameter> listaParametros = new List<SqlParameter>();
                    BaseDeDatos.agregarParametro(listaParametros, "@ID_User", idUser);
                    BaseDeDatos.ejecutarSP("sp_DeshabilitarUsuario", listaParametros);
                    obtenerClientes(paginaActual);
                }
            }           
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            this.paginaActual++;

            btnAnterior.Enabled = true;

            if (obtenerClientes(paginaActual) <= 9)
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
