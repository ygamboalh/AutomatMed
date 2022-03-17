using System;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.Libs.Dtos;

namespace TacticaReparaciones.DesktopApp.Pantallas
{
    public partial class frmNuevoInstrumento : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InstrumentoAgregado(InstrumentoDto instrumento);
        public event InstrumentoAgregado OnInstrumentoAgregado;

        string rutaApi;

        public frmNuevoInstrumento()
        {
            InitializeComponent();

            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            CargarDatosMaestros();
            EstablecerColorBotonGuardar();
            EstablecerNombreYTituloPopupAgregarInstrumentos();
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            this.Text = "";
            ctlEncabezadoAgregarInstrumento.lblTitulo.Text = "Agregar Instrumento";
            ctlEncabezadoAgregarInstrumento.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void OnEmpresaSeleccionada(EmpresaDto empresa)
        {
            txtEmpresaInstrumento.Text = empresa.NombreEmpresa;
        }

        private void btnGuardarInstrumento_Click(object sender, EventArgs e)
        {
            OnInstrumentoAgregado?.Invoke(new InstrumentoDto());
            this.Close();
        }

        private void btnAbrirPopupEmpresaPorInstrumento_Click(object sender, EventArgs e)
        {
            frmEmpresas frmEmpresas = new frmEmpresas();
            frmEmpresas.OnSeleccionaEmpresa += OnEmpresaSeleccionada;
            frmEmpresas.Show();
        }

        private void CargarDatosMaestros()
        {
            CargarTiposDeInstrumentos();
            CargarMarcas();
            CargarModelos();
            CargarGarantias();
            CargarPeriodosDeCalibracion();
        }

        private async void CargarTiposDeInstrumentos()
        {
            string uri = "/tipos-instrumentos";
            var tiposDeInstrumentos = await HttpHelper.Get<TipoInstrumentoDto>(rutaApi, uri, "");

            glTipoInstrumento.Properties.DataSource = tiposDeInstrumentos;
        }

        private async void CargarMarcas()
        {
            string uri = "/marcas";
            var marcas = await HttpHelper.Get<MarcaDto>(rutaApi, uri, "");

            glMarca.Properties.DataSource = marcas;
        }

        private async void CargarPeriodosDeCalibracion()
        {
            string uri = "/periodos-de-calibracion";
            var periodosDeCalibracion = await HttpHelper.Get<PeriodoCalibracionDto>(rutaApi, uri, "");

            glMarca.Properties.DataSource = periodosDeCalibracion;
        }

        private async void CargarGarantias()
        {
            string uri = "/garantias";
            var garantias = await HttpHelper.Get<GarantiaDto>(rutaApi, uri, "");

            glMarca.Properties.DataSource = garantias;
        }

        private async void CargarModelos()
        {
            string uri = "/modelos";
            var modelos = await HttpHelper.Get<ModeloDto>(rutaApi, uri, "");

            glModelo.Properties.DataSource = modelos;
        }

        private void glTipoInstrumento_EditValueChanged(object sender, EventArgs e)
        {
            var fila = glTipoInstrumento.GetSelectedDataRow() as TipoInstrumentoDto;
        }

        private void glMarca_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void glModelo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void glPeriodoCalibracion_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void glGarantia_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}