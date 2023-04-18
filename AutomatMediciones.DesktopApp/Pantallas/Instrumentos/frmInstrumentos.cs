using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Core.Extentions.Enumeradores;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Instrumentos
{
    public partial class frmInstrumentos : DevExpress.XtraEditors.XtraForm
    {
        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private InstrumentoService _instrumentoService;

        List<InstrumentoLista> instrumentosDeEmpresa;

        public frmInstrumentos(InstrumentoService instrumentoService)
        {
            InitializeComponent();
            _instrumentoService = instrumentoService;
            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();
            EstablecerColorBotonExportarExcel();

            CargarInstrumentos();

            btnEditar.Click += btnEditarClick;
            btnDesactivar.Click += btnDesactivarClick;
        }

        private void EstablecerColorBotonExportarExcel()
        {
            btnExportarExcel.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnExportarExcel.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnExportarExcel.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {instrumentosDeEmpresa.Count}";
            lblTotal.Visible = true;
        }

        private void btnDesactivarClick(object sender, EventArgs e)
        {
            var instrumento = gvInstrumentos.GetFocusedRow() as InstrumentoDto;
            SplashScreenManager.ShowForm(typeof(frmLoadingSave));

            var respuesta = _instrumentoService.DesactivarInstrumento(instrumento);

            SplashScreenManager.CloseForm();
            if (respuesta.Type != TypeResponse.Ok)
            {
                Notificaciones.MensajeError(respuesta.Message);
                return;
            }

            serviceProvider = Program.services.BuildServiceProvider();
            _instrumentoService = serviceProvider.GetService<InstrumentoService>();
            CargarInstrumentos();
            Notificaciones.MensajeConfirmacion("¡El Instrumento se desactivó exitosamente!");
        }

        private void btnEditarClick(object sender, EventArgs e)
        {
            var instrumento = gvInstrumentos.GetFocusedRow() as InstrumentoDto;

            SplashScreenManager.ShowForm(typeof(frmSaving));
            var frmNuevoInstrumento = new frmNuevoInstrumento(TipoTransaccion.Actualizar, serviceProvider.GetService<ClasificacionInstrumentoService>(),
                                                                            serviceProvider.GetService<InstrumentoService>(),
                                                                            serviceProvider.GetService<MarcaService>(),
                                                                            serviceProvider.GetService<ModeloService>(),
                                                                            serviceProvider.GetService<TipoDeInstrumentoService>(),
                                                                            serviceProvider.GetService<EmpresaService>(),
                                                                            serviceProvider.GetService<CeldaService>());

            frmNuevoInstrumento.OnInstrumentoModificado += onInstrumentoModificado;
            frmNuevoInstrumento.NuevoInstrumento = instrumento;
            frmNuevoInstrumento.CargarVariablesInstrumentos();
            frmNuevoInstrumento.SetearValoresParaActualizar();
            SplashScreenManager.CloseForm();
            frmNuevoInstrumento.ShowDialog();


        }

        private void onInstrumentoModificado(InstrumentoDto instrumento)
        {
            serviceProvider = Program.services.BuildServiceProvider();
            _instrumentoService = serviceProvider.GetService<InstrumentoService>();
            CargarInstrumentos();
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Instrumentos";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevoInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevoInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevoInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void CargarInstrumentos()
        {

            var resultado = _instrumentoService.ObtenerInstrumentos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            EstablecerSeleccionDeInstrumentos(resultado.Data);

            SetearTotales();
        }

        private void EstablecerSeleccionDeInstrumentos(List<InstrumentoDto> listaInstrumentos)
        {
            instrumentosDeEmpresa = new List<InstrumentoLista>();

            listaInstrumentos.ForEach(x =>
            {
                InstrumentoLista instrumentoLista = new InstrumentoLista
                {
                    Clasificacion = x.Clasificacion,
                    ClasificacionId = x.ClasificacionId,
                    Descripcion = x.Descripcion,
                    EmpresaId = x.EmpresaId,
                    FechaCompraCliente = x.FechaCompraCliente,
                    FechaCompraFabricante = x.FechaCompraFabricante,
                    FechaProximaCalibracion = x.FechaProximaCalibracion,
                    FechaUltimaCalibracion = x.FechaUltimaCalibracion,
                    Garantia = x.Garantia,
                    InstrumentoId = x.InstrumentoId,
                    NombreEmpresa = x.NombreEmpresa,
                    NumeroSerie = x.NumeroSerie,
                    CeldasInstrumentos = x.CeldasInstrumentos,
                    ClasificacionConcatenada = $"{x.Clasificacion.TipoInstrumento.Descripcion} / {x.Clasificacion.Marca.Descripcion} / {x.Clasificacion.Modelo.Descripcion}"
                };

                instrumentosDeEmpresa.Add(instrumentoLista);
            });

            gcInstrumentos.DataSource = instrumentosDeEmpresa;
            gcInstrumentos.RefreshDataSource();
        }

        private void btnAgregarNuevoInstrumento_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var frmNuevoInstrumento = new frmNuevoInstrumento(TipoTransaccion.Insertar, serviceProvider.GetService<ClasificacionInstrumentoService>(),
                                                                           serviceProvider.GetService<InstrumentoService>(),
                                                                           serviceProvider.GetService<MarcaService>(),
                                                                           serviceProvider.GetService<ModeloService>(),
                                                                           serviceProvider.GetService<TipoDeInstrumentoService>(),
                                                                           serviceProvider.GetService<EmpresaService>(),
                                                                           serviceProvider.GetService<CeldaService>());

            frmNuevoInstrumento.OnInstrumentoAgregado += OnInstrumentoAgregado;
            SplashScreenManager.CloseForm();
            frmNuevoInstrumento.ShowDialog();

        }

        private void OnInstrumentoAgregado(InstrumentoDto instrumento)
        {
            serviceProvider = Program.services.BuildServiceProvider();
            _instrumentoService = serviceProvider.GetService<InstrumentoService>();
            CargarInstrumentos();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var nombreArchivo = "Listado de Instrumentos";
            var filter = "Archivo de Microsoft Excel (*.xlsx)|*.xlsx";

            saveFileDialog.Filter = filter;
            saveFileDialog.FileName = nombreArchivo;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                nombreArchivo = saveFileDialog.FileName;

                colEditar.Visible = false;
                colEliminar.Visible = false;

                gcInstrumentos.ExportToXlsx(nombreArchivo);
                if (Notificaciones.PreguntaConfirmacion($"Archivo Guardado en: {nombreArchivo} ¿Desea abrir el archivo?") == System.Windows.Forms.DialogResult.Yes)
                {
                    FileHelper.AbrirArchivo(nombreArchivo);
                }
                SplashScreenManager.CloseForm();

                colEliminar.Visible = true;
                colEditar.Visible = true;
            }
            else
            {
                SplashScreenManager.CloseForm();
            }
        }
    }
}