using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AutomatMediciones.DesktopApp.Pantallas.Diagnosticos
{
    public partial class frmDiagnosticos : DevExpress.XtraEditors.XtraForm
    {
        private readonly IngresoService _ingresoService;
        private IngresoService _ingresoService2;


        List<IngresoInstrumento> ingresosInstrumentos = new List<IngresoInstrumento>();

        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();

        public frmDiagnosticos(IngresoService ingresoService)
        {
            InitializeComponent();

            _ingresoService = ingresoService;
            EstablecerNombreYTitulo();
            CargarIngresos();

            btnIniciarDiagnostico.Click += btnIniciarDiagnosticoClick;

        }

        private void btnIniciarDiagnosticoClick(object sender, EventArgs e)
        {
            var diagnosticoSeleccionado = gvInstrumentos.GetFocusedRow() as IngresoInstrumento;
            if (diagnosticoSeleccionado == null) return;

            var nuevoDiagnostico = new frmNuevoDiagnostico(diagnosticoSeleccionado, serviceProvider.GetService<UsuarioService>(), serviceProvider.GetService<EstadoService>(), serviceProvider.GetService<IngresoService>());
            nuevoDiagnostico.OnDiagnosticoAgregado += OnDiagnosticoAgregado;
            nuevoDiagnostico.Show();
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


        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {ingresosInstrumentos.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = System.Windows.Forms.DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Diagnósticos";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
    }
}