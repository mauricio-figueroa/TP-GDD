using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOS_INSISTENTES.Loggin
{
    public partial class SeleccionFuncionalidades : Form
    {

        int rol;
        public Clases.Usuario usuario { get; set; }
        public Clases.Rol rolActual { get; set; }

        Interfaz.Interfaz interfaz=new Interfaz.Interfaz();

        public SeleccionFuncionalidades(Clases.Usuario usuario, int idRol, Boolean bypass)
        {
            this.usuario = usuario;

            rol = idRol;

            InitializeComponent();
            this.CenterToScreen();

            FormBorderStyle = FormBorderStyle.FixedDialog;
            // WindowState = FormWindowState.Maximized;

            cbFuncionalidades.DropDownStyle = ComboBoxStyle.DropDownList;

            this.lblTitulo.Text = this.lblTitulo.Text + " " + Interfaz.Interfaz.usuario.Username;

            listarFuncionalidades();           
        }

        public void listarFuncionalidades()
        {
           interfaz.cargarComboIDValor(cbFuncionalidades,"select f.ID_Funcionalidad as id, f.Nombre as valor from LOS_INSISTENTES.Funcionalidades f,LOS_INSISTENTES.Funcionalidad_rol fr, LOS_INSISTENTES.Roles r where r.ID_Rol = fr.ID_Rol AND fr.ID_Funcionalidad=f.ID_Funcionalidad and f.Habilitado = 1 AND r.Habilitado=1 and r.ID_Rol="+rol+" order by f.Nombre");
        }

        private void cbFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idFuncionalidadElegida = Convert.ToInt32(cbFuncionalidades.SelectedValue);

            if (idFuncionalidadElegida == -1)
            {
                // Interfaz.Interfaz.emitirAviso("Por favor elija una funcionalidad de la lista");
                limpiarPanel();
                return;
            }

            lblElegido.Text = cbFuncionalidades.Text;

            Form formularioElegido = null;

            /* 
             * Referencias de la BBDD
                1	Administrar Usuarios
                2	Administrar Roles
                3	Administrar Rubros
                4	Administrar Visibilidades
                5	Administrar Publicaciones
                6	Comprar / Ofertar
                7	Calificar
                8	Historial Cliente
                9	Consultar Facturas
                10	Listado Estadístico
            */

            switch (idFuncionalidadElegida)
            {
                
                case 1:
                    formularioElegido = new ABMUsuario.RolNuevo("", "");
                    break;
                case 2:
                    formularioElegido = new RolAbm.ABMRol();
                    break;
                case 3:
                    Interfaz.Interfaz.emitirAviso("Esta funcionalidad no se debe realizar según enunciado.");
                    break;
                case 4:
                    formularioElegido = new ABM_Visibilidad.ABMVisibilidad();
                    break;
                case 5:
                    formularioElegido = new Generar_Publicación.GenerarPublicacion();
                    break;
                case 6:
                    formularioElegido = new ComprarOfertar.ComprarOfertar();
                    break;
                case 7:
                    formularioElegido = new Calificar.CalificarVendedor();
                    break;
                case 8:
                    formularioElegido = new Historial_Cliente.HistorialCliente();
                    break;
                case 9:
                    formularioElegido = new Facturas.Facturas();
                    break;
                case 10:
                    formularioElegido = new Listado_Estadistico.ListadoEstadistico();
                    break;
                case 11:
                    formularioElegido = new Loggin.CambiarPassword(false);
                    break;
            }

            if (formularioElegido != null)
                mostrarEnPanel (formularioElegido, this.panelContenido);
            else
                limpiarPanel();
        }



        private void limpiarPanel()
        {
            lblElegido.Text = "";
            this.panelContenido.Controls.Clear();
            this.Show();
        }

        public static void mostrarEnPanel(Form formularioElegido, Panel panelContenido) {
            formularioElegido.TopLevel = false;
            formularioElegido.AutoScroll = true;
            // formularioElegido.Top = 1;
            // formularioElegido.Left = 1;
            formularioElegido.Width = panelContenido.Width - 2;
            formularioElegido.Height = panelContenido.Height - 2;
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(formularioElegido);
            formularioElegido.FormBorderStyle = FormBorderStyle.None;
            formularioElegido.StartPosition = FormStartPosition.CenterParent;
            formularioElegido.Top = 0;
            panelContenido.Show();
            formularioElegido.Show();        
        }

        private void SeleccionFuncionalidades_Load_1(object sender, EventArgs e)
        {
            if (Interfaz.Interfaz.usuario.ID_User == 0 && Interfaz.Interfaz.leyendaSubastas != "")
                Interfaz.Interfaz.emitirAviso(Interfaz.Interfaz.leyendaSubastas);

            this.Size = Screen.FromRectangle(this.Bounds).WorkingArea.Size;
            this.Top = 0;
            this.Left = 0;
            this.grpFuncionalidades.Width = this.Width - 20;
            this.cbFuncionalidades.Width = this.grpFuncionalidades.Width - 600;
            this.panelContenido.Top = 100;
            this.panelContenido.Left = 15;
            this.panelContenido.Height = this.Height - 140;
            this.panelContenido.Width = this.Width - 30;
            this.btnSalir.Left = this.Width - 150;
            this.btnSalir.Top = 22;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }  
    }
}
