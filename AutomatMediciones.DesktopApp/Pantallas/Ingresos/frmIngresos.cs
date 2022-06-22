using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos;
using AutomatMediciones.DesktopApp.Reportes;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos
{
    public partial class frmIngresos : DevExpress.XtraEditors.XtraForm
    {
        private readonly IngresoService _ingresoService;
        private IngresoService _ingresoService2;

        public Filtros FiltroSeleccionado { get; set; }
        List<IngresoInstrumento> ingresosInstrumentos = new List<IngresoInstrumento>();

        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();

        public frmIngresos(IngresoService ingresoService)
        {
            InitializeComponent();

            _ingresoService = ingresoService;
            EstablecerNombreYTitulo();
            CargarIngresos();

            EstablecerColorBotonExportarExcel();
            btnIniciarDiagnostico.Click += btnIniciarDiagnosticoClick;
            btnVerReporteDeIngreso.Click += btnVerReporteIngresoClick;

            FiltroSeleccionado = Filtros.Todos;
            btnFiltroTodos.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnFiltroTodos.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnFiltroTodos.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");

        }

        private void EstablecerColorBotonExportarExcel()
        {
            btnExportarExcel.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnExportarExcel.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnExportarExcel.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }


        private void btnVerReporteIngresoClick(object sender, EventArgs e)
        {
            var diagnosticoSeleccionado = gvInstrumentos.GetFocusedRow() as IngresoInstrumento;
            if (diagnosticoSeleccionado == null) return;

            SplashScreenManager.ShowForm(typeof(frmSaving));

            rptIngreso rptIngreso = new rptIngreso();
            rptIngreso.objectDataSource1.DataSource = diagnosticoSeleccionado.Ingreso;
            rptIngreso.DisplayName = $"Ingreso #{diagnosticoSeleccionado.Ingreso.IngresoId}";
            ReportPrintTool printTool = new ReportPrintTool(rptIngreso);
            printTool.ShowRibbonPreview();

            SplashScreenManager.CloseForm();
        }

        private void btnIniciarDiagnosticoClick(object sender, EventArgs e)
        {
            var diagnosticoSeleccionado = gvInstrumentos.GetFocusedRow() as IngresoInstrumento;
            if (diagnosticoSeleccionado == null) return;

            serviceProvider = Program.services.BuildServiceProvider();
            var nuevoDiagnostico = new frmNuevoDiagnostico(diagnosticoSeleccionado,
                serviceProvider.GetService<UsuarioService>(),
                serviceProvider.GetService<EstadoService>(),
                serviceProvider.GetService<IngresoService>(),
                serviceProvider.GetService<ConfiguracionNotificacionService>()
              );
            nuevoDiagnostico.OnDiagnosticoAgregado += OnDiagnosticoAgregado;
            nuevoDiagnostico.ShowDialog();
        }


        private void OnDiagnosticoAgregado(IngresoInstrumento ingresoInstrumento)
        {
            Program.services.BuildServiceProvider();
            _ingresoService2 = serviceProvider.GetService<IngresoService>();
            CargarIngresos2();
        }

        private void CargarIngresos()
        {
            try
            {

                var resultado = _ingresoService.ObtenerIngresos();
                if (resultado.Type != TypeResponse.Ok)
                {
                    Notificaciones.MensajeError(resultado.Message);
                    return;
                }

                ingresosInstrumentos = resultado.Data.SelectMany(x => x.IngresosInstrumentos).Select(y => new IngresoInstrumento
                {
                    Activo = y.Activo,
                    IngresoId = y.IngresoId,
                    IngresoInstrumentoId = y.IngresoInstrumentoId,
                    InstrumentoId = y.InstrumentoId,
                    Comentarios = y.Comentarios,
                    Ingreso = y.Ingreso,
                    Instrumento = y.Instrumento,
                    EstadoId = y.EstadoId,
                    Estado = y.Estado,
                    TipoTrabajo = y.TipoTrabajo,
                    Prioridad = y.Prioridad,
                    TipoTrabajoId = y.TipoTrabajoId,
                    Responsable = y.Responsable,
                    Diagnostico = y.Diagnostico,
                    FechaInicio = y.FechaInicio,
                    FechaFin = y.FechaFin,
                    TiempoConsumido = y.TiempoConsumido,
                    ResponsableId = y.ResponsableId,
                    FechaEntregaRequerida = y.FechaEntregaRequerida,
                    NumeroServicioTecnico = y.NumeroServicioTecnico,
                    ClasificacionConcatenada = $"{y.Instrumento.Clasificacion.TipoInstrumento.Descripcion} / {y.Instrumento.Clasificacion.Marca.Descripcion} / {y.Instrumento.Clasificacion.Modelo.Descripcion}"
                }).OrderBy(y => y.Prioridad).ToList();

                gcInstrumentos.DataSource = ingresosInstrumentos;
                gcInstrumentos.RefreshDataSource();


                SetearTotales();
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
            }
        }


        private void CargarIngresos2()
        {
            try
            {

                var resultado = _ingresoService2.ObtenerIngresos();
                if (resultado.Type != TypeResponse.Ok)
                {
                    Notificaciones.MensajeError(resultado.Message);
                    return;
                }

                ingresosInstrumentos = resultado.Data.SelectMany(x => x.IngresosInstrumentos).Select(y => new IngresoInstrumento
                {
                    Activo = y.Activo,
                    IngresoId = y.IngresoId,
                    IngresoInstrumentoId = y.IngresoInstrumentoId,
                    InstrumentoId = y.InstrumentoId,
                    Comentarios = y.Comentarios,
                    Ingreso = y.Ingreso,
                    Instrumento = y.Instrumento,
                    EstadoId = y.EstadoId,
                    Estado = y.Estado,
                    TipoTrabajo = y.TipoTrabajo,
                    Prioridad = y.Prioridad,
                    TipoTrabajoId = y.TipoTrabajoId,
                    Diagnostico = y.Diagnostico,
                    FechaInicio = y.FechaInicio,
                    Responsable = y.Responsable,
                    FechaFin = y.FechaFin,
                    TiempoConsumido = y.TiempoConsumido,
                    ResponsableId = y.ResponsableId,
                    FechaEntregaRequerida = y.FechaEntregaRequerida,
                    NumeroServicioTecnico = y.NumeroServicioTecnico,
                    ClasificacionConcatenada = $"{y.Instrumento.Clasificacion.TipoInstrumento.Descripcion} / {y.Instrumento.Clasificacion.Marca.Descripcion} / {y.Instrumento.Clasificacion.Modelo.Descripcion}"
                }).OrderBy(y => y.Prioridad).ToList();

                gcInstrumentos.DataSource = ingresosInstrumentos;
                gcInstrumentos.RefreshDataSource();

                switch (FiltroSeleccionado)
                {
                    case Filtros.Todos:
                        btnFiltroTodos_Click(new object(), new EventArgs());
                        break;
                    case Filtros.Clientes:
                        btnCliente_Click(new object(), new EventArgs());
                        break;
                    case Filtros.ServicioTecnico:
                        btnServicioTecnico_Click(new object(), new EventArgs());
                        break;
                    case Filtros.Comercial:
                        btnComercial_Click(new object(), new EventArgs());
                        break;

                }


                SetearTotales();
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
            }
        }


        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {gvInstrumentos.RowCount}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = System.Windows.Forms.DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Ingresos";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void btnFiltroTodos_Click(object sender, EventArgs e)
        {
            gcInstrumentos.DataSource = ingresosInstrumentos;
            gcInstrumentos.RefreshDataSource();

            btnFiltroTodos.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnFiltroTodos.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnFiltroTodos.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");

            btnComercial.BackColor = Color.Transparent;
            btnComercial.ForeColor = Color.Black;
            btnComercial.IconColor = Color.Black;

            btnCliente.BackColor = Color.Transparent;
            btnCliente.ForeColor = Color.Black;
            btnCliente.IconColor = Color.Black;

            btnServicioTecnico.BackColor = Color.Transparent;
            btnServicioTecnico.ForeColor = Color.Black;
            btnServicioTecnico.IconColor = Color.Black;

            FiltroSeleccionado = Filtros.Todos;

            SetearTotales();

        }

        private void btnServicioTecnico_Click(object sender, EventArgs e)
        {
            gcInstrumentos.DataSource = ingresosInstrumentos.Where(x => x.EstadoId == 3 || x.EstadoId == 6);
            gcInstrumentos.RefreshDataSource();

            btnServicioTecnico.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnServicioTecnico.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnServicioTecnico.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");

            btnComercial.BackColor = Color.Transparent;
            btnComercial.ForeColor = Color.Black;
            btnComercial.IconColor = Color.Black;

            btnCliente.BackColor = Color.Transparent;
            btnCliente.ForeColor = Color.Black;
            btnCliente.IconColor = Color.Black;

            btnFiltroTodos.BackColor = Color.Transparent;
            btnFiltroTodos.ForeColor = Color.Black;
            btnFiltroTodos.IconColor = Color.Black;

            FiltroSeleccionado = Filtros.ServicioTecnico;


            SetearTotales();
        }

        private void btnComercial_Click(object sender, EventArgs e)
        {
            gcInstrumentos.DataSource = ingresosInstrumentos.Where(x => x.EstadoId == 2 || x.EstadoId == 4 || x.EstadoId == 7);
            gcInstrumentos.RefreshDataSource();

            btnComercial.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnComercial.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnComercial.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");

            btnCliente.BackColor = Color.Transparent;
            btnCliente.ForeColor = Color.Black;
            btnCliente.IconColor = Color.Black;

            btnServicioTecnico.BackColor = Color.Transparent;
            btnServicioTecnico.ForeColor = Color.Black;
            btnServicioTecnico.IconColor = Color.Black;

            btnFiltroTodos.BackColor = Color.Transparent;
            btnFiltroTodos.ForeColor = Color.Black;
            btnFiltroTodos.IconColor = Color.Black;

            FiltroSeleccionado = Filtros.Comercial;

            SetearTotales();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            gcInstrumentos.DataSource = ingresosInstrumentos.Where(x => x.EstadoId == 5);
            gcInstrumentos.RefreshDataSource();

            btnCliente.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnCliente.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnCliente.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");

            btnComercial.BackColor = Color.Transparent;
            btnComercial.ForeColor = Color.Black;
            btnComercial.IconColor = Color.Black;

            btnServicioTecnico.BackColor = Color.Transparent;
            btnServicioTecnico.ForeColor = Color.Black;
            btnServicioTecnico.IconColor = Color.Black;

            btnFiltroTodos.BackColor = Color.Transparent;
            btnFiltroTodos.ForeColor = Color.Black;
            btnFiltroTodos.IconColor = Color.Black;

            FiltroSeleccionado = Filtros.Clientes;

            SetearTotales();

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var nombreArchivo = "Listado de Ingresos";
            var filter = "Archivo de Microsoft Excel (*.xlsx)|*.xlsx";

            saveFileDialog.Filter = filter;
            saveFileDialog.FileName = nombreArchivo;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                nombreArchivo = saveFileDialog.FileName;

                colIniciarDiagnostico.Visible = false;
                colVerReporte.Visible = false;

                gcInstrumentos.ExportToXlsx(nombreArchivo);
                if (Notificaciones.PreguntaConfirmacion($"Archivo Guardado en: {nombreArchivo} ¿Desea abrir el archivo?") == System.Windows.Forms.DialogResult.Yes)
                {
                    FileHelper.AbrirArchivo(nombreArchivo);
                }
                SplashScreenManager.CloseForm();

                colIniciarDiagnostico.Visible = true;
                colVerReporte.Visible = true;
            }
            else
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void frmIngresos_Load(object sender, EventArgs e)
        {

        }
    }

    public enum Filtros
    {
        Todos = 1,
        Clientes = 2,
        ServicioTecnico = 3,
        Comercial = 4
    }
}