using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraGrid.Views.Grid;
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

        List<IngresoInstrumento> ingresosInstrumentos = new List<IngresoInstrumento>();

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
            GridView view = this.gcInstrumentos.Views[1] as GridView;
            if (view != null)
            {

                var fila = view.GetFocusedRow() as IngresoInstrumento;

                //var frmNuevaOrdenTrabajo = 
            }
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
                    NumeroServicioTecnico = y.NumeroServicioTecnico,
                    ClasificacionConcatenada = $"{y.Instrumento.Clasificacion.TipoInstrumento.Descripcion}/{y.Instrumento.Clasificacion.Marca.Descripcion}/{y.Instrumento.Clasificacion.Modelo.Descripcion}"
                }).OrderBy(y => y.IngresoInstrumentoId).ToList();
                            
               gcInstrumentos.DataSource = ingresosInstrumentos;

                SetearTotales();
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(Exceptions.ObtenerMensajeExcepcion(exc));
            }
        }


        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {ingresosInstrumentos.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla1.lblTitulo.Text = "Diagnósticos";
            ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }
    }
}