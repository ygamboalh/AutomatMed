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
            EstablecerColorBotonPorDefecto();
            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();
            CargarDatosDeEmpresas();
            CargarDatosTiposDeTrabajo();
        }

        private async void CargarDatosTiposDeTrabajo()
        {
            string uri = "/tipos-de-trabajo";
            var tiposTrabajo = await HttpHelper.Get<TipoTrabajoDto>(rutaApi, uri, "");

            glTiposTrabajo.Properties.DataSource = tiposTrabajo;
        }

        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void EstablecerColorBotonGuardar()
        {
            btnGuardarIngreso.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarIngreso.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarIngreso.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");

            btnGuardarInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void EstablecerNombreYTituloPopupEmpresas()
        {
            ctlEncabezadoPopup.lblTitulo.Text = "Listado de Empresas";
            ctlEncabezadoPopup.EstablecerColoresDeFondoYLetra();
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            ctlEncabezadoAgregarInstrumento.lblTitulo.Text = "Agregar Instrumento";
            ctlEncabezadoAgregarInstrumento.EstablecerColoresDeFondoYLetra();
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
            this.ctlEncabezadoPantalla1.lblTitulo.Text = "Creación de Ingreso";
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

        private void cmdCerrarPopupEmpresas_Click(object sender, EventArgs e)
        {
            flyoutPanel1.HidePopup();
        }

        private void gcEmpresas_DoubleClick(object sender, EventArgs e)
        {
            ObtenerEmpresaSeleccionada(ModoSeleccionEmpresa.Ingreso);
        }
        private void ObtenerContactosDeEmpresaSeleccionada()
        {
            LimpiarContactos();
            glContacto.Properties.DataSource = empresaSeleccionada.Contactos;
            glContacto.Properties.DisplayMember = "Nombre";
            glContacto.Properties.ValueMember = "ContactoId";
        }
        public void ObtenerEmpresaSeleccionada(ModoSeleccionEmpresa modoSeleccionEmpresa)
        {
            empresaSeleccionada = gvEmpresas.GetFocusedRow() as EmpresaDto;
            if (modoSeleccionEmpresa == ModoSeleccionEmpresa.Ingreso)
            {
                txtEmpresa.Text = empresaSeleccionada.NombreEmpresa;
                ObtenerContactosDeEmpresaSeleccionada();
            }
            else
            {
                txtEmpresaInstrumento.Text = empresaSeleccionada.NombreEmpresa;
            }
          
           
            flyoutPanel1.HidePopup();
           
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
                ObtenerEmpresaSeleccionada(ModoSeleccionEmpresa.Ingreso);
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

        private void btnAgregarNuevInstrumento_Click(object sender, EventArgs e)
        {
            flyoutPanel2.ShowPopup();
        }

        private void btnCerrarPopupAgregarInstrumento_Click(object sender, EventArgs e)
        {
            flyoutPanel2.HidePopup();
        }

        private void btnGuardarInstrumento_Click(object sender, EventArgs e)
        {
            HttpHelper.Post
        }

        private void btnAbrirPopupEmpresaPorInstrumento_Click(object sender, EventArgs e)
        {
            ObtenerEmpresaSeleccionada(ModoSeleccionEmpresa.Instrumento);
        }

        private void PrepararIngreso()
        {
            var tipoIngreso = glkTipoInstrumento.GetFocusedDataRow(); 
            //IngresoDto ingresoDto = new IngresoDto
            //{
            //    TipoTrabajoId = glkTipoInstrumento.GetFocusedDataRow();
            //}
        }
    }

    public enum ModoSeleccionEmpresa {
        Ingreso = 1,
        Instrumento = 2
    }
}

