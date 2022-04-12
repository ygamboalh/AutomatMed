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

        ICollection<IngresoDto> ingresos = new List<IngresoDto>();

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
            GridView view = this.gridControl1.Views[1] as GridView;
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

                var ingresosRespuesta = resultado.Data;
                ingresos = ingresosRespuesta;

                List<Ingreso> ingresosLista = new List<Ingreso>();

                var detalle = ingresos.SelectMany(x => x.IngresosInstrumentos).ToList();
                foreach (var ingreso in ingresos)
                {
                    var nuevoIngreso = new Ingreso
                    {
                        Id = ingreso.IngresoId,
                        Estado = ingreso.Estado.Descripcion,
                        Fecha = ingreso.FechaRegistro,
                        NombreEmpresa = ingreso.NombreEmpresa,
                        Prioridad = ingreso.Prioridad,
                        Instrumentos = detalle.Where(x => x.IngresoId == ingreso.IngresoId).Select(y => new IngresoInstrumento
                        {
                            IngresoId = y.IngresoId,
                            IngresoInstrumentoId = y.IngresoInstrumentoId,
                            DescripcionInstrumento = y.Instrumento.Descripcion,
                            InstrumentoId = y.InstrumentoId,
                            Marca = y.Instrumento.Clasificacion.Marca.Descripcion,
                            Modelo = y.Instrumento.Clasificacion.Modelo.Descripcion,
                            TipoInstrumento = y.Instrumento.Clasificacion.TipoInstrumento.Descripcion
                        }).ToList()
                    };

                    ingresosLista.Add(nuevoIngreso);
                }

                gridControl1.DataSource = ingresosLista;
                ExpandAllRows(gvIngresos);

                SetearTotales();
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(Exceptions.ObtenerMensajeExcepcion(exc));
            }
        }

        public void ExpandAllRows(GridView view)
        {
            view.BeginUpdate();
            try
            {
                int dataRowCount = view.DataRowCount;
                for (int rHandle = 0; rHandle < dataRowCount; rHandle++)
                    view.SetMasterRowExpanded(rHandle, true);
            }
            finally
            {
                view.EndUpdate();
            }
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {ingresos.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla1.lblTitulo.Text = "Diagnósticos";
            ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }
    }
}