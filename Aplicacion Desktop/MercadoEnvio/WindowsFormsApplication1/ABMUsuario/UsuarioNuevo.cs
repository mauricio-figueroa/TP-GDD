using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Agrego
using System.Data.SqlClient;
using System.Security.Cryptography;
using LOS_INSISTENTES.Interfaz;
using LOS_INSISTENTES.Clases;


namespace LOS_INSISTENTES.ABMUsuario
{
    public partial class UsuarioNuevo : Form
    {

        public int tipo { get; set; }

        public UsuarioNuevo(int tipo)
        {
            InitializeComponent();
            CenterToParent();

            this.tipo = tipo;

            if (tipo == 1) {
                label1.Text="Nombre Usuario Cliente";
                this.Text = "Alta CLiente";
            }

            if (tipo == 2) {
                label1.Text = "Nombre Usuario Empresa";
                this.Text = "Alta Empresa";
            
            }

        }

        public string verificarUsuario1(string usuario)
        {
            
            if (BaseDeDatos.existeString(usuario, "LOS_INSISTENTES.Usuarios", "Username"))
            {
                return "0";
            }
            else
            {
                return usuario;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chequearNuevoUsuario() && chequearPass())
            {
                Form altaForm;

                if (tipo == 1)
                {
                    altaForm = new ABMUsuario.AltaCliente(txbUsuario.Text, txbPass.Text, "alta");
                    altaForm.ShowDialog();
                }
                else
                {
                    altaForm = new ABMUsuario.AltaEmpresa(txbUsuario.Text, txbPass.Text,"alta");
                    altaForm.ShowDialog();
                }
                Form form = new ABMUsuario.RolNuevo("", "");
                Panel panelContenido = (Panel)ParentForm.Controls["panelContenido"];
                Loggin.SeleccionFuncionalidades.mostrarEnPanel(form, panelContenido);
            }
        }

        private Boolean chequearNuevoUsuario() {
            if (txbUsuario.Text.Equals(""))
            {
                Interfaz.Interfaz.emitirAviso("debe Ingresar un Usuario");
                return false;
            }

             if (verificarUsuario1(this.txbUsuario.Text) == "0") {
                    Interfaz.Interfaz.emitirAviso("El Usuario ingresado ya existe, Ingrese otro");
                    return false;
                }


             return true;
        
        
        }
        
        private Boolean chequearPass() {
            if (!this.chequearVacios()) {
                return this.chequearPassIguales();
            } 
            return false;                  
        
        }

        private Boolean chequearPassIguales(){

            if (txbPass.Text.Equals(txbPass2.Text)) {
                return true;
            }
            Interfaz.Interfaz.emitirAviso("Las contraseñas ingresadas no coinciden");
            return false;
       }

        private Boolean chequearVacios() {
            if (txbPass.Text.Equals("") || txbPass2.Text.Equals(""))
            {
                Interfaz.Interfaz.emitirAviso( "complete los campos de Contraseña");
                return true;
            }
            return false;
        }
    }
}
