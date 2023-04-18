using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Core.Extentions.Enumeradores;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
            EstablecerColorBotonExportarExcel();

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
                Notificaciones.MensajeConfirmacion("¡La desactivación de la Clasificación se ha realizado exitosamente!");
                clasificaciones = clasificaciones.Where(x => x.ClasificacionId != clasificacionInstrumento.ClasificacionId).ToList();
                gcClasificaciones.DataSource = clasificaciones;
                gcClasificaciones.RefreshDataSource();
            }
        }

        private void OnSeleccionaMarcaParaModificar(object sender, EventArgs e)
        {
            var clasificacionInstrumento = gvClasificaciones.GetFocusedRow() as ClasificacionInstrumentoDto;

            if (clasificacionInstrumento == null) return;

            var frmNuevaClasificacion = new frmNuevaClasificacion(TipoTransaccion.Actualizar, serviceProvider.GetService<ClasificacionInstrumentoService>(), serviceProvider.GetService<MarcaService>(),
                serviceProvider.GetService<ModeloService>(), serviceProvider.GetService<TipoDeInstrumentoService>());
            frmNuevaClasificacion.NuevaClasificacion = clasificacionInstrumento;
            frmNuevaClasificacion.Modelos = modelos;
            frmNuevaClasificacion.Marcas = marcas;
            frmNuevaClasificacion.TiposDeInstrumento = tiposDeInstrumento;
            frmNuevaClasificacion.InicializarMaestros();
            frmNuevaClasificacion.SetearValoresParaActualizar();
            frmNuevaClasificacion.OnClasificacionInstrumentoModificada += OnClasificacionInstrumentoModificada;
            frmNuevaClasificacion.ShowDialog();
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
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
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
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
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
            var frmNuevaClasificacion = new frmNuevaClasificacion(TipoTransaccion.Insertar, serviceProvider.GetService<ClasificacionInstrumentoService>(), serviceProvider.GetService<MarcaService>(),
                serviceProvider.GetService<ModeloService>(), serviceProvider.GetService<TipoDeInstrumentoService>());

            frmNuevaClasificacion.OnClasificacionInstrumentoAgregada += OnClasificacionInstrumentoAgregada;
            frmNuevaClasificacion.Modelos = modelos;
            frmNuevaClasificacion.Marcas = marcas;
            frmNuevaClasificacion.TiposDeInstrumento = tiposDeInstrumento;
            frmNuevaClasificacion.InicializarMaestros();
            frmNuevaClasificacion.ShowDialog();
        }

        private void EstablecerColorBotonExportarExcel()
        {
            btnExportarExcel.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnExportarExcel.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnExportarExcel.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var nombreArchivo = "Clasificaciones de Instrumentos";
            var filter = "Archivo de Microsoft Excel (*.xlsx)|*.xlsx";

            saveFileDialog.Filter = filter;
            saveFileDialog.FileName = nombreArchivo;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                nombreArchivo = saveFileDialog.FileName;

                colEditar.Visible = false;
                colInactivar.Visible = false;

                gcClasificaciones.ExportToXlsx(nombreArchivo);
                if (Notificaciones.PreguntaConfirmacion($"Archivo Guardado en: {nombreArchivo} ¿Desea abrir el archivo?") == System.Windows.Forms.DialogResult.Yes)
                {
                    FileHelper.AbrirArchivo(nombreArchivo);
                }
                SplashScreenManager.CloseForm();

                colEditar.Visible = true;
                colInactivar.Visible = true;
            }
            else
            {
                SplashScreenManager.CloseForm();
            }
        }
    }
}