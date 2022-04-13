using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AutomatMediciones.DesktopApp.Pantallas.Clasificaciones
{
    public partial class frmClasificaciones : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly ClasificacionInstrumentoService _clasificacionService;
        private readonly MarcaService _marcaService;
        private readonly ModeloService _modeloService;
        private readonly TipoDeInstrumentoService _tipoDeInstrumentoService;

        ICollection<ClasificacionInstrumentoDto> clasificaciones = new List<ClasificacionInstrumentoDto>();
        ICollection<ModeloDto> modelos = new List<ModeloDto>();
        ICollection<MarcaDto> marcas = new List<MarcaDto>();
        ICollection<TipoInstrumentoDto> tiposDeInstrumento = new List<TipoInstrumentoDto>();

        public frmClasificaciones(ClasificacionInstrumentoService clasificacionService, MarcaService marcaService, ModeloService modeloService,
            TipoDeInstrumentoService tipoDeInstrumentoService)
        {
            InitializeComponent();

            _clasificacionService = clasificacionService;
            _marcaService = marcaService;
            _modeloService = modeloService;
            _tipoDeInstrumentoService = tipoDeInstrumentoService;

            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();

            CargarClasificaciones();
            CargarMarcas();
            CargarModelos();
            CargarTiposDeInstrumentos();

            cmdEditar.Click += OnSeleccionaMarcaParaModificar;
            cmdInactivar.Click += OnSeleccionarClasificacionParaInactivar;

        }

        private void OnSeleccionarClasificacionParaInactivar(object sender, EventArgs e)
        {
            var clasificacionInstrumento = gvClasificaciones.GetFocusedRow() as ClasificacionInstrumentoDto;

            if (clasificacionInstrumento == null) return;

            if (InactivarClasificacionInstrumento(clasificacionInstrumento))
            {
                Notificaciones.MensajeConfirmacion("¡La inactivación de la Clasificación se ha realizado exitosamente!");
                clasificaciones = clasificaciones.Where(x => x.ClasificacionId != clasificacionInstrumento.ClasificacionId).ToList();
                gcClasificaciones.DataSource = clasificaciones;
                gcClasificaciones.RefreshDataSource();
            }
        }

        private void OnSeleccionaMarcaParaModificar(object sender, EventArgs e)
        {
            var clasificacionInstrumento = gvClasificaciones.GetFocusedRow() as ClasificacionInstrumentoDto;

            if (clasificacionInstrumento == null) return;

            var frmNuevaClasificacion = new frmNuevaClasificacion(TipoTransaccion.Actualizar, serviceProvider.GetService<ClasificacionInstrumentoService>());
            frmNuevaClasificacion.NuevaClasificacion = clasificacionInstrumento;
            frmNuevaClasificacion.Modelos = modelos;
            frmNuevaClasificacion.Marcas = marcas;
            frmNuevaClasificacion.TiposDeInstrumento = tiposDeInstrumento;
            frmNuevaClasificacion.InicializarMaestros();
            frmNuevaClasificacion.SetearValoresParaActualizar();
            frmNuevaClasificacion.OnClasificacionInstrumentoModificada += OnClasificacionInstrumentoModificada;
            frmNuevaClasificacion.Show();
        }

        private bool InactivarClasificacionInstrumento(ClasificacionInstrumentoDto clasificacionInstrumentoDto)
        {
            try
            {
                var resultado = _clasificacionService.DesactivarClasificacion(clasificacionInstrumentoDto);
                if (resultado.Type != TypeResponse.Ok) return false;

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(Exceptions.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void OnClasificacionInstrumentoModificada(ClasificacionInstrumentoDto clasificacionInstrumentoDto)
        {
            clasificaciones = clasificaciones.Where(x => x.ClasificacionId != clasificacionInstrumentoDto.ClasificacionId).ToList();
            clasificaciones.Add(clasificacionInstrumentoDto);

            CargarClasificaciones();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {clasificaciones.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla3.lblTitulo.Text = "Clasificaciones de Instrumentos";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonPorDefecto()
        {
            btnNuevaClasificacion.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnNuevaClasificacion.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnNuevaClasificacion.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void CargarClasificaciones()
        {

            var resultado = _clasificacionService.ObtenerClasificacionesActivas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var clasificacionesRespuesta = resultado.Data;
            clasificaciones = clasificacionesRespuesta;

            gcClasificaciones.DataSource = clasificaciones;
            gcClasificaciones.RefreshDataSource();

            SetearTotales();
        }


        private void CargarMarcas()
        {
            var resultado = _marcaService.ObtenerMarcas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var marcasRespuesta = resultado.Data;
            marcas = marcasRespuesta;

            SetearTotales();
        }


        private void CargarModelos()
        {
            var resultado = _modeloService.ObtenerModelos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var ModelosRespuesta = resultado.Data;
            modelos = ModelosRespuesta;

            SetearTotales();
        }

        private void CargarTiposDeInstrumentos()
        {
            var resultado = _tipoDeInstrumentoService.ObtenerTiposDeInstrumento();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var tiposDeInstrumentos = resultado.Data;
            tiposDeInstrumento = tiposDeInstrumentos;

            SetearTotales();
        }

        private void OnClasificacionInstrumentoAgregada(ClasificacionInstrumentoDto clasificacionInstrumentoDto)
        {
            CargarClasificaciones();
        }

        private void btnNuevaClasificacion_Click(object sender, EventArgs e)
        {
            var frmNuevaClasificacion = new frmNuevaClasificacion(TipoTransaccion.Insertar, serviceProvider.GetService<ClasificacionInstrumentoService>());

            frmNuevaClasificacion.OnClasificacionInstrumentoAgregada += OnClasificacionInstrumentoAgregada;
            frmNuevaClasificacion.Modelos = modelos;
            frmNuevaClasificacion.Marcas = marcas;
            frmNuevaClasificacion.TiposDeInstrumento = tiposDeInstrumento;
            frmNuevaClasificacion.InicializarMaestros();
            frmNuevaClasificacion.Show();
        }
    }
}