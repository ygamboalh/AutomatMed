using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Clasificaciones;
using AutomatMediciones.DesktopApp.Pantallas.Clasificaciones.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace AutomatMediciones.DesktopApp.Pantallas
{
    public partial class frmNuevoInstrumento : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InstrumentoAgregado(InstrumentoDto instrumento);
        public event InstrumentoAgregado OnInstrumentoAgregado;

        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly ClasificacionInstrumentoService _clasificacionInstrumentoService;
        private readonly InstrumentoService _instrumentoService;
        private readonly MarcaService _marcaService;
        private readonly ModeloService _modeloService;
        private readonly TipoDeInstrumentoService _tipoDeInstrumentoService;

        private EmpresaDto EmpresaSeleccionada { get; set; }

        public InstrumentoDto NuevoInstrumento { get; set; }

        List<ClasificacionDto> clasificaciones = new List<ClasificacionDto>();
        List<TipoInstrumentoDto> tiposInstrumentos = new List<TipoInstrumentoDto>();
        List<MarcaDto> marcas = new List<MarcaDto>();
        List<ModeloDto> modelos = new List<ModeloDto>();

        public frmNuevoInstrumento(ClasificacionInstrumentoService clasificacionInstrumentoService, InstrumentoService instrumentoService, MarcaService marcaService, ModeloService modeloService, TipoDeInstrumentoService tipoDeInstrumentoService)
        {
            InitializeComponent();

            _clasificacionInstrumentoService = clasificacionInstrumentoService;
            _instrumentoService = instrumentoService;
            _marcaService = marcaService;
            _modeloService = modeloService;
            _tipoDeInstrumentoService = tipoDeInstrumentoService;
            CargarClasificacionesDeInstrumentos();

            EstablecerColorBotonGuardar();
            EstablecerNombreYTituloPopupAgregarInstrumentos();

            NuevoInstrumento = new InstrumentoDto();

        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {

            ctlEncabezadoAgregarInstrumento.lblTitulo.Text = "Agregar Instrumento";
            ctlEncabezadoAgregarInstrumento.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        public void OnEmpresaSeleccionada(EmpresaDto empresa)
        {
            if (empresa == null) return;

            EmpresaSeleccionada = empresa;
            txtEmpresaInstrumento.Text = empresa.NombreEmpresa;
        }

        private void btnGuardarInstrumento_Click(object sender, EventArgs e)
        {
            if (!PrepararNuevoInstrumentoParaGuardar())
            {
                return;
            }

            if (!EsValidaLaInformacionIngresadaParaNuevoInstrumento(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            CargarClasificacionesDeInstrumentos();
            NuevoInstrumento.Clasificacion = clasificaciones.FirstOrDefault(x => x.ClasificacionId == NuevoInstrumento.ClasificacionId);

            SplashScreenManager.ShowForm(typeof(frmSaving));
            if (GuardarInstrumento())
            {
                Notificaciones.MensajeConfirmacion("¡El instrumento se ha registrado exitosamente!");
                OnInstrumentoAgregado?.Invoke(NuevoInstrumento);
                this.Close();
            }

            SplashScreenManager.CloseForm();
        }

        private void btnAbrirPopupEmpresaPorInstrumento_Click(object sender, EventArgs e)
        {
            var frmEmpresas = serviceProvider.GetService<frmEmpresas>();
            frmEmpresas.OnSeleccionaEmpresa += OnEmpresaSeleccionada;
            frmEmpresas.Show();
        }

        private void CargarClasificacionesDeInstrumentos()
        {
            var resultado = _clasificacionInstrumentoService.ObtenerClasificacionesActivas();
            if (resultado.Type != TypeResponse.Ok)
            {
                Notificaciones.MensajeError(resultado.Message);
                return;
            }

            PrepararDataSourceClasificaciones(resultado.Data);
        }

        private void PrepararDataSourceClasificaciones(List<ClasificacionInstrumentoDto> clasificacionInstrumentos)
        {
            clasificaciones.Clear();
            clasificacionInstrumentos.ForEach(x =>
            {
                ClasificacionDto clasificacionDto = new ClasificacionDto
                {
                    Activo = x.Activo,
                    ClasificacionId = x.ClasificacionId,
                    MarcaId = x.MarcaId,
                    ModeloId = x.ModeloId,
                    TipoInstrumentoId = x.TipoInstrumentoId,
                    DescripcionCompuesta = $"{x.TipoInstrumento.Descripcion} / {x.Marca.Descripcion} / {x.Modelo.Descripcion}",
                    Marca = x.Marca,
                    Modelo = x.Modelo,
                    PeriodoDeCalibracion = x.PeriodoDeCalibracion,
                    TipoInstrumento = x.TipoInstrumento
                };

                clasificaciones.Add(clasificacionDto);
            });

            marcas = clasificaciones.Select(x => x.Marca).ToList();
            modelos = clasificaciones.Select(x => x.Modelo).ToList();
            tiposInstrumentos = clasificaciones.Select(x => x.TipoInstrumento).ToList();

            AsignarConfiguracionComboBoxes();
        }

        private bool GuardarInstrumento()
        {

            try
            {
                var resultado = _instrumentoService.RegistrarInstrumento(NuevoInstrumento);
                if (resultado.Type != TypeResponse.Ok)
                {
                    Notificaciones.MensajeError(resultado.Message);
                    return false;
                }

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
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

        private bool PrepararNuevoInstrumentoParaGuardar()
        {
            var tipoInstrumentoSeleccionado = glTipoInstrumento.GetSelectedDataRow() as TipoInstrumentoDto;
            var marcaSeleccionada = glMarcas.GetSelectedDataRow() as MarcaDto;
            var modeloSeleccionado = glModelos.GetSelectedDataRow() as ModeloDto;

            if (tipoInstrumentoSeleccionado == null || marcaSeleccionada == null || modeloSeleccionado == null)
            {
                MessageBox.Show("Es necesario que rellene campos obligatorios, para poder continuar.", "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            var clasificacionSegunFiltrosSeleccionados = clasificaciones.FirstOrDefault(x => x.TipoInstrumentoId == tipoInstrumentoSeleccionado.TipoInstrumentoId &&
                                                                                             x.MarcaId == marcaSeleccionada.MarcaId &&
                                                                                             x.ModeloId == modeloSeleccionado.ModeloId);

            if (clasificacionSegunFiltrosSeleccionados == null)
            {
                MessageBox.Show("No se pudo encontrar una clasificación con el tipo de instrumento, marca y modelo seleccionados.", "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            NuevoInstrumento.Descripcion = txtDescripcionInstrumento.Text;
            NuevoInstrumento.EmpresaId = EmpresaSeleccionada.EmpresaId;
            NuevoInstrumento.NombreEmpresa = EmpresaSeleccionada.NombreEmpresa;
            NuevoInstrumento.ClasificacionId = clasificacionSegunFiltrosSeleccionados.ClasificacionId;
            NuevoInstrumento.NumeroSerie = txtNumeroSerie.Text;
            NuevoInstrumento.FechaCompraFabricante = dateFechaCompraFabricante.Value;
            NuevoInstrumento.FechaCompraCliente = dateFechaCompraCliente.Value;
            NuevoInstrumento.Garantia = txtGarantia.Text;

            return true;
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

        private void btnAgregarClasificacion_Click(object sender, EventArgs e)
        {
            var frmClasificaciones = new frmNuevaClasificacion(TipoTransaccion.Insertar, serviceProvider.GetService<ClasificacionInstrumentoService>());

            frmClasificaciones.OnClasificacionInstrumentoAgregada += OnClasificacionInstrumentoAgregada;
            frmClasificaciones.Modelos = CargarModelos();
            frmClasificaciones.Marcas = CargarMarcas();
            frmClasificaciones.TiposDeInstrumento = CargarTiposDeInstrumentos();
            frmClasificaciones.InicializarMaestros();
            frmClasificaciones.Show();
        }

        private List<MarcaDto> CargarMarcas()
        {
            var resultado = _marcaService.ObtenerMarcas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var marcasRespuesta = resultado.Data;
            return marcasRespuesta;

        }

        private List<ModeloDto> CargarModelos()
        {
            var resultado = _modeloService.ObtenerModelos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var modelosRespuesta = resultado.Data;
            return modelosRespuesta;

        }

        private List<TipoInstrumentoDto> CargarTiposDeInstrumentos()
        {
            var resultado = _tipoDeInstrumentoService.ObtenerTiposDeInstrumento();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            return resultado.Data;
        }

        private void OnClasificacionInstrumentoAgregada(ClasificacionInstrumentoDto tipoInstrumento)
        {
            CargarClasificacionesDeInstrumentos();
            this.Focus();
        }

        private void btnAbrirPopupEmpresaPorInstrumento_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAbrirPopupEmpresaPorInstrumento, "Presione para ir la a pantalla que le permite buscar y seleccionar una empresa");
        }

        private void btnAgregarClasificacion_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAgregarClasificacion, "Presione para ir la a pantalla que le permite agregar una nueva clasificación");
        }
    }
}