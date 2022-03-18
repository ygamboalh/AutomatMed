using System;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.Libs.Dtos;

namespace TacticaReparaciones.DesktopApp.Pantallas
{
    public partial class frmIngresos : DevExpress.XtraEditors.XtraForm
    {
        string rutaApi;

        ContactoDto contactoSeleccionado;
        EmpresaDto empresaSeleccionada;

        public frmIngresos()
        {
            InitializeComponent();

            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            EstablecerNombreYTituloDePantalla();
            EstablecerColorBotonPorDefecto();
            EstablecerColorBotonGuardar();
            CargarDatosTiposDeTrabajo();
        }

        private async void CargarDatosTiposDeTrabajo()
        {
            string uri = "/tipos-de-trabajo";
            var tiposTrabajo = await HttpHelper.Get<TipoTrabajoDto>(rutaApi, uri, "");

            glTiposTrabajo.Properties.DataSource = tiposTrabajo;
        }

        private async void ObtenerInstrumentosParaEmpresaSeleccionada()
        {
            string uri = $"/instrumentos/por-empresa/{empresaSeleccionada.EmpresaId}";
            var instrumentos = await HttpHelper.Get<InstrumentoDto>(rutaApi, uri, "");

            gcInstrumentosDeEmpresa.DataSource = instrumentos;
        }

        private async void CargarTiposDeInstrumentos()
        {
            string uri = "/tipos-de-instrumento";
            var tiposDeInstrumentos = await HttpHelper.Get<TipoInstrumentoDto>(rutaApi, uri, "");

            glTipoInstrumento.DataSource = tiposDeInstrumentos;        
            ConfiguracionColumnasGridInstrumentos();
        }

        public void ConfiguracionColumnasGridInstrumentos()
        {
            glPopupModelo.DisplayMember = "Descripcion";
            glPopupModelo.ValueMember = "ModeloId";

            glTipoInstrumento.DisplayMember = "Descripcion";
            glTipoInstrumento.ValueMember = "TipoInstrumentoId";

            glMarcaPopup.DisplayMember = "Descripcion";
            glMarcaPopup.ValueMember = "MarcaId";
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
            frmEmpresas frmEmpresas = new frmEmpresas();
            frmEmpresas.OnSeleccionaEmpresa += OnEmpresaSeleccionada;
            frmEmpresas.Show();
        }

        private void OnEmpresaSeleccionada(EmpresaDto empresa)
        {
            empresaSeleccionada = empresa;
            txtEmpresa.Text = empresaSeleccionada.NombreEmpresa;
            ObtenerInstrumentosParaEmpresaSeleccionada();
            ObtenerContactosDeEmpresaSeleccionada();
        }

        private void ObtenerContactosDeEmpresaSeleccionada()
        {
            LimpiarContactos();
            glContacto.Properties.DataSource = empresaSeleccionada.Contactos;
            glContacto.Properties.DisplayMember = "Nombre";
            glContacto.Properties.ValueMember = "ContactoId";
        }

        public void ObtenerCorreoElectronicoDeContacto()
        {

            LimpiarCorreos();
            glCorreoElectronico.Properties.DataSource = contactoSeleccionado.CorreosElectronicos;
            glCorreoElectronico.Properties.DisplayMember = "Direccion";
            glCorreoElectronico.Properties.ValueMember = "RegistroId";
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
            frmNuevoInstrumento frmNuevoInstrumento = new frmNuevoInstrumento();
            frmNuevoInstrumento.OnInstrumentoAgregado += OnInstrumentoAgregado;
            frmNuevoInstrumento.Show();
        }

        private void OnInstrumentoAgregado(InstrumentoDto empresa)
        {
            if (empresaSeleccionada != null)
            {
                ObtenerInstrumentosParaEmpresaSeleccionada();
            }
        }
    }
}

