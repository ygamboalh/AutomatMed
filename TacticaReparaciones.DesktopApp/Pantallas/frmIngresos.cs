using System;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.Libs.Dtos;

namespace TacticaReparaciones.DesktopApp.Pantallas
{
    public partial class frmIngresos : DevExpress.XtraEditors.XtraForm
    {
        string rutaApi;
        EmpresaDto empresaSeleccionada;
        ContactoDto contactoSeleccionado;

        public frmIngresos()
        {
            InitializeComponent();

            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();

            EstablecerNombreYTituloDePantalla();
            EstablecerNombreYTituloPopupEmpresas();
            CargarDatosDeEmpresas();
        }

        private void EstablecerNombreYTituloPopupEmpresas()
        {
            ctlEncabezadoPopup.lblTitulo.Text = "Listado de Empresas";
            ctlEncabezadoPopup.EstablecerColoresDeFondoYLetra();
        }

        private async void CargarDatosDeEmpresas()
        {
            string uri = "/empresas";
            var empresas = await HttpHelper.Get<EmpresaDto>(rutaApi, uri, "");

            gcEmpresas.DataSource = empresas;

        }

        private void EstablecerNombreYTituloDePantalla()
        {
            string titulo = "Ingresos";
            this.Text = titulo;
            this.ctlEncabezadoPantalla1.lblTitulo.Text = titulo;
            this.ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }

        private void iconButton1_MouseHover(object sender, System.EventArgs e)
        {
            toolTip1.SetToolTip(btnBuscarEmpresa, "Presione para ir la a pantalla que le permite buscar y seleccionar una empresa");
        }

        private void btnBuscarEmpresa_Click(object sender, System.EventArgs e)
        {
            this.Parent.BringToFront();
            flyoutPanel1.ShowPopup();
        }

        private void frmIngresos_Load(object sender, System.EventArgs e)
        {

        }

        private void cmdCerrarPopupEmpresas_Click(object sender, EventArgs e)
        {
            flyoutPanel1.HidePopup();
        }

        private void gcEmpresas_DoubleClick(object sender, EventArgs e)
        {
            ObtenerEmpresaSeleccionada();
        }
        private void ObtenerContactosDeEmpresaSeleccionada()
        {
            LimpiarContactos();
            glContacto.Properties.DataSource = empresaSeleccionada.Contactos;
            glContacto.Properties.DisplayMember = "Nombre";
            glContacto.Properties.ValueMember = "ContactoId";
        }
        public void ObtenerEmpresaSeleccionada()
        {
            empresaSeleccionada = gvEmpresas.GetFocusedRow() as EmpresaDto;
            txtEmpresa.Text = empresaSeleccionada.NombreEmpresa;
            flyoutPanel1.HidePopup();
            ObtenerContactosDeEmpresaSeleccionada();
        }

        public void ObtenerCorreoElectronicoDeContacto()
        {

            LimpiarCorreos();
            glCorreoElectronico.Properties.DataSource = contactoSeleccionado.CorreosElectronicos;
            glCorreoElectronico.Properties.DisplayMember = "Direccion";
            glCorreoElectronico.Properties.ValueMember = "RegistroId";
        }
        private void gcEmpresas_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                ObtenerEmpresaSeleccionada();
            }
        }

        private void glContacto_Properties_EditValueChanged(object sender, EventArgs e)
        {
            contactoSeleccionado = glContactos.GetFocusedRow() as ContactoDto;
            ObtenerCorreoElectronicoDeContacto();
        }

        private void LimpiarContactos()
        {
            glContacto.Properties.DataSource = null;
            contactoSeleccionado = null;
            LimpiarCorreos();
        }

        private void LimpiarCorreos()
        {
            glCorreoElectronico.Properties.DataSource = null;

        }
    }
}

