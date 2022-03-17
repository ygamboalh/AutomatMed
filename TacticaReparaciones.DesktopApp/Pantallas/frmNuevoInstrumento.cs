using System;
using System.Windows;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.Libs.Dtos;

namespace TacticaReparaciones.DesktopApp.Pantallas
{
    public partial class frmNuevoInstrumento : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InstrumentoAgregado(InstrumentoDto instrumento);
        public event InstrumentoAgregado OnInstrumentoAgregado;

        EmpresaDto empresaSeleccionada;
        public InstrumentoDto NuevoInstrumento { get; set; }
        string rutaApi;

        public frmNuevoInstrumento()
        {
            InitializeComponent();

            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            CargarTiposDeInstrumentos();
            AsignarConfiguracionComboBoxes();
            EstablecerColorBotonGuardar();
            EstablecerNombreYTituloPopupAgregarInstrumentos();

            NuevoInstrumento = new InstrumentoDto();
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
            empresaSeleccionada = empresa;
            txtEmpresaInstrumento.Text = empresa.NombreEmpresa;
        }

        private void btnGuardarInstrumento_Click(object sender, EventArgs e)
        {
            PrepararNuevoInstrumentoParaGuardar();

            if (!EsValidaLaInformacionIngresadaParaNuevoInstrumento(out string mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }

            GuardarInstrumento();

            OnInstrumentoAgregado?.Invoke(NuevoInstrumento);
            this.Close();
        }

        private void btnAbrirPopupEmpresaPorInstrumento_Click(object sender, EventArgs e)
        {
            frmEmpresas frmEmpresas = new frmEmpresas();
            frmEmpresas.OnSeleccionaEmpresa += OnEmpresaSeleccionada;
            frmEmpresas.Show();
        }

        private async void CargarTiposDeInstrumentos()
        {
            string uri = "/tipos-de-instrumento";
            var tiposDeInstrumentos = await HttpHelper.Get<TipoInstrumentoDto>(rutaApi, uri, "");

            glTipoInstrumento.Properties.DataSource = tiposDeInstrumentos;
        }

        private async void GuardarInstrumento()
        {
            try
            {
                string uri = "/instrumentos";
                var result = await HttpHelper.Post<InstrumentoDto>(NuevoInstrumento, rutaApi, uri, "");
            }
            catch (Exception exc)
            {

                throw;
            }

        }

        private void AsignarConfiguracionComboBoxes()
        {
            glTipoInstrumento.Properties.ValueMember = "TipoInstrumentoId";
            glTipoInstrumento.Properties.DisplayMember = "Descripcion";

            glMarca.Properties.ValueMember = "MarcaId";
            glMarca.Properties.DisplayMember = "Descripcion";

            glGarantia.Properties.ValueMember = "GarantiaId";
            glGarantia.Properties.DisplayMember = "Descripcion";

            glModelo.Properties.ValueMember = "ModeloId";
            glModelo.Properties.DisplayMember = "Descripcion";

            glPeriodoCalibracion.Properties.ValueMember = "PeriodoCalibracionId";
            glPeriodoCalibracion.Properties.DisplayMember = "Descripcion";
        }

        private void glTipoInstrumento_EditValueChanged(object sender, EventArgs e)
        {
            var tipoInstrumento = glTipoInstrumento.GetSelectedDataRow() as TipoInstrumentoDto;
            AsignarDataSourcesQueDependenDelTipoInstrumento(tipoInstrumento);
        }

        private void AsignarDataSourcesQueDependenDelTipoInstrumento(TipoInstrumentoDto tipoInstrumento)
        {
            glMarca.Properties.DataSource = tipoInstrumento.Marcas;
            glGarantia.Properties.DataSource = tipoInstrumento.Garantias;
            glPeriodoCalibracion.Properties.DataSource = tipoInstrumento.PeriodosDeCalibracion;
        }

        private void glMarca_EditValueChanged(object sender, EventArgs e)
        {
            var marca = glMarca.GetSelectedDataRow() as MarcaDto;
            glModelo.Properties.DataSource = marca.Modelos;
        }

        private bool EsValidaLaInformacionIngresadaParaNuevoInstrumento(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevoInstrumento.NombreEmpresa))
            {
                mensaje = "Es necesario ingresar un nombre de empresa para guardar el ingreso.";
                return false;
            }

            if (string.IsNullOrEmpty(NuevoInstrumento.Descripcion))
            {
                mensaje = "Es necesario ingresar una descripcion para el instrumento.";
                return false;
            }

            if (NuevoInstrumento.TipoInstrumentoId == 0)
            {
                mensaje = "Es necesario ingresar un tipo de instrumento para el nuevo instrumento.";
                return false;
            }

            if (NuevoInstrumento.MarcaId == 0)
            {
                mensaje = "Es necesario ingresar una marca para el instrumento.";
                return false;
            }

            if (NuevoInstrumento.ModeloId == 0)
            {
                mensaje = "Es necesario ingresar un modelo para el instrumento.";
                return false;
            }

            mensaje = "Ok";
            return true;
        }

        private void PrepararNuevoInstrumentoParaGuardar()
        {
            var marca = glMarca.GetSelectedDataRow() as MarcaDto;
            var modelo = glModelo.GetSelectedDataRow() as ModeloDto;
            var garantia = glGarantia.GetSelectedDataRow() as GarantiaDto;
            var periodoCalibracion = glPeriodoCalibracion.GetSelectedDataRow() as PeriodoCalibracionDto;
            var tipoInstrumento = glTipoInstrumento.GetSelectedDataRow() as TipoInstrumentoDto;

            NuevoInstrumento.Descripcion = txtDescripcionInstrumento.Text;
            NuevoInstrumento.EmpresaId = empresaSeleccionada.EmpresaId;
            NuevoInstrumento.NombreEmpresa = empresaSeleccionada.NombreEmpresa;
            NuevoInstrumento.TipoInstrumentoId = tipoInstrumento.TipoInstrumentoId;
            NuevoInstrumento.MarcaId = marca.MarcaId;
            NuevoInstrumento.ModeloId = modelo.ModeloId;
            NuevoInstrumento.NumeroSerie = txtNumeroSerie.Text;
            NuevoInstrumento.FechaCompraFabricante = dateFechaCompraFabricante.Value;
            NuevoInstrumento.FechaCompraCliente = dateFechaCompraCliente.Value;
            NuevoInstrumento.FechaUltimaCalibracion = dateUltimaCalibracion.Value;
            NuevoInstrumento.PeriodoCalibracionId = periodoCalibracion.PeriodoCalibracionId;
            NuevoInstrumento.FechaProximaCalibracion = dateProximaCalibracion.Value;
            NuevoInstrumento.GarantiaId = garantia.GarantiaId;
        }
    }
}