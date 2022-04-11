using Nagaira.Herramientas.Standard.Helpers.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Clasificaciones.Dtos;
using AutomatMediciones.Libs.Dtos;

namespace AutomatMediciones.DesktopApp.Pantallas
{
    public partial class frmNuevoInstrumento : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InstrumentoAgregado(InstrumentoDto instrumento);
        public event InstrumentoAgregado OnInstrumentoAgregado;

        EmpresaDto empresaSeleccionada;
        public InstrumentoDto NuevoInstrumento { get; set; }
        string rutaApi;

        List<ClasificacionDto> clasificaciones = new List<ClasificacionDto>();
        List<TipoInstrumentoDto> tiposInstrumentos = new List<TipoInstrumentoDto>();
        List<MarcaDto> marcas = new List<MarcaDto>();
        List<ModeloDto> modelos = new List<ModeloDto>();

        public frmNuevoInstrumento()
        {
            InitializeComponent();

            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            CargarClasificacionesDeInstrumentos();

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

        private async void btnGuardarInstrumento_Click(object sender, EventArgs e)
        {
            PrepararNuevoInstrumentoParaGuardar();

            if (!EsValidaLaInformacionIngresadaParaNuevoInstrumento(out string mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }

            if ((await GuardarInstrumento()))
            {
                MessageBox.Show("¡El instrumento se ha registrado exitosamente!", "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Information);
                OnInstrumentoAgregado?.Invoke(NuevoInstrumento);
                this.Close();
            }
        }

        private void btnAbrirPopupEmpresaPorInstrumento_Click(object sender, EventArgs e)
        {
            frmEmpresas frmEmpresas = new frmEmpresas();
            frmEmpresas.OnSeleccionaEmpresa += OnEmpresaSeleccionada;
            frmEmpresas.Show();
        }

        private async void CargarClasificacionesDeInstrumentos()
        {
            string uri = "/clasificaciones-instrumentos";
            clasificaciones = await HttpHelper.Get<ClasificacionDto>(rutaApi, uri, "");

            if (clasificaciones != null)
            {
                clasificaciones.ForEach(x => x.DescripcionCompuesta = $"{x.TipoInstrumento.Descripcion} / {x.Marca.Descripcion} / {x.Modelo.Descripcion}");
            }

            marcas = clasificaciones.Select(x => x.Marca).ToList();
            modelos = clasificaciones.Select(x => x.Modelo).ToList();
            tiposInstrumentos = clasificaciones.Select(x => x.TipoInstrumento).ToList();

            AsignarConfiguracionComboBoxes();
        }

        private async Task<bool> GuardarInstrumento()
        {
            bool guardado = false;
            string uri = "/instrumentos";

            try
            {
                guardado = await HttpHelper.Post<InstrumentoDto>(NuevoInstrumento, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return guardado;
        }

        private void AsignarConfiguracionComboBoxes()
        {
            glTipoInstrumento.Properties.DataSource = tiposInstrumentos;
            glTipoInstrumento.Properties.ValueMember = "TipoInstrumentoId";
            glTipoInstrumento.Properties.DisplayMember = "Descripcion";

            glMarcas.Properties.DataSource = marcas;
            glMarcas.Properties.ValueMember = "MarcaId";
            glMarcas.Properties.DisplayMember = "Descripcion";

            glModelos.Properties.DataSource = modelos;
            glModelos.Properties.ValueMember = "ModeloId";
            glModelos.Properties.DisplayMember = "Descripcion";
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
                mensaje = "Es necesario ingresar una descripción para el instrumento.";
                return false;
            }

            mensaje = "Ok";
            return true;
        }

        private void PrepararNuevoInstrumentoParaGuardar()
        {
            var tipoInstrumentoSeleccionado = glTipoInstrumento.GetSelectedDataRow() as TipoInstrumentoDto;
            var marcaSeleccionada = glMarcas.GetSelectedDataRow() as MarcaDto;
            var modeloSeleccionado = glModelos.GetSelectedDataRow() as ModeloDto;

            if (tipoInstrumentoSeleccionado == null || marcaSeleccionada == null || modeloSeleccionado == null)
            {
                MessageBox.Show("Es necesario que rellene campos obligatorios, para poder continuar.", "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var clasificacionSegunFiltrosSeleccionados = clasificaciones.FirstOrDefault(x => x.TipoInstrumentoId == tipoInstrumentoSeleccionado.TipoInstrumentoId &&
                                                                                             x.MarcaId == marcaSeleccionada.MarcaId &&
                                                                                             x.ModeloId == modeloSeleccionado.ModeloId);

            if (clasificacionSegunFiltrosSeleccionados == null)
            {
                MessageBox.Show("No se pudo encontrar una clasificación con el tipo de instrumento, marca y modelo seleccionados.", "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            NuevoInstrumento.Descripcion = txtDescripcionInstrumento.Text;
            NuevoInstrumento.EmpresaId = empresaSeleccionada.EmpresaId;
            NuevoInstrumento.NombreEmpresa = empresaSeleccionada.NombreEmpresa;
            NuevoInstrumento.ClasificacionId = clasificacionSegunFiltrosSeleccionados.ClasificacionId;
            NuevoInstrumento.NumeroSerie = txtNumeroSerie.Text;
            NuevoInstrumento.FechaCompraFabricante = dateFechaCompraFabricante.Value;
            NuevoInstrumento.FechaCompraCliente = dateFechaCompraCliente.Value;
            NuevoInstrumento.Garantia = txtGarantia.Text;
        }

        private void glTipoInstrumento_EditValueChanged(object sender, EventArgs e)
        {
            var tipoInstrumentoSeleccionado = glTipoInstrumento.GetSelectedDataRow() as TipoInstrumentoDto;
            if (tipoInstrumentoSeleccionado != null)
            {
                marcas = clasificaciones.Where(x => x.TipoInstrumentoId.Equals(tipoInstrumentoSeleccionado.TipoInstrumentoId)).Select(x => x.Marca).ToList();
                glMarcas.Properties.DataSource = marcas;
            }
        }

        private void glMarcas_EditValueChanged(object sender, EventArgs e)
        {
            var marcaSeleccionada = glMarcas.GetSelectedDataRow() as MarcaDto;
            if (marcaSeleccionada != null)
            {
                modelos = clasificaciones.Where(x => x.MarcaId.Equals(marcaSeleccionada.MarcaId)).Select(x => x.Modelo).ToList();
                glModelos.Properties.DataSource = modelos;
            }
        }

        private void glModelos_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}