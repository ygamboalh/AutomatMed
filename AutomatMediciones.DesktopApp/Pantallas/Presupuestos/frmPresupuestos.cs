using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Enums;

using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using IngresoInstrumento = AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos.IngresoInstrumento;

namespace AutomatMediciones.DesktopApp.Pantallas.Presupuestos
{
    public partial class frmPresupuestos : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly ProductoService _productoService;
        private readonly PresupuestoService _presupuestoService;
        private readonly IngresoService _ingresoService;
        public PresupuestoDto presupuestoSeleccionado { get; set; } 

        List<IngresoInstrumento> ingresosInstrumentos = new List<IngresoInstrumento>();
        
        public frmPresupuestos(IngresoService ingresoService, ProductoService productoService, PresupuestoService presupuestoService)
        {
            InitializeComponent();
            _productoService = productoService;
            _presupuestoService = presupuestoService;
            _ingresoService = ingresoService;

            btnEditPresupuesto.Click += btnEditPresupuestoClick;
            btnDeletePresupuesto.Click += btnDeletePresupuestoClick;
            ObtenerIngresoInstrumento();
            CargarPresupuestos();
            EstablecerNombreYTitulo();
            SetearTotales();
        }

        private void btnDeletePresupuestoClick(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Está seguro que desea desactivar el presupuesto?","Confirmación", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var presupuestoSeleccionado = gvPresupuesto.GetFocusedRow() as PresupuestoDto;
                int presupustoControlId = Int16.Parse(ObtenerPosicionesDeCadena(presupuestoSeleccionado.RecID));
                var presupuestoControl = _presupuestoService.ObtenerPresupuestoControl(presupustoControlId);
                var presupuestoControlItems = _presupuestoService.ObtenerPresupuestoControlItems(presupustoControlId);
                var productosIngresos = _presupuestoService.ObtenerProductosIngresos()
                    .Data.Where(x => x.PresupuestoControlId == presupustoControlId);

                _presupuestoService.DesactivarPresupuesto(presupuestoSeleccionado.RecID);
                //_presupuestoService.EliminarProductosIngresos(presupustoControlId);
                //_presupuestoService.EliminarPresupuestoControl(presupustoControlId);
                //_presupuestoService.EliminarPresupuestoItemControles(presupustoControlId);
                CargarPresupuestos();
            }
            else { return; }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CargarPresupuestoItems();
        }

        private void CargarProductos()
        {
            var resultado = _productoService.ObtenerProductos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var modelosRespuesta = resultado.Data;
        }

        private void CargarPresupuestoItems()
        {
            var resultado = _presupuestoService.ObtenerPresupuestosDetalle();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var modelosRespuesta = resultado.Data;
        }

        public string ObtenerPosicionesDeCadena(string cadena)
        {
            string numerosFinales = "";
            int indice = cadena.Length - 1;
            if(cadena.Length == 12 && cadena.StartsWith("a"))
            {
                while (indice >= 0 && Char.IsDigit(cadena[indice]))
                {
                    numerosFinales = cadena[indice] + numerosFinales;
                    indice--;
                }
            }
            if (numerosFinales.Length == 0)
                return cadena;
            return numerosFinales;
        }
        private List<PresupuestoDto> ObtenerPresupuestos() 
        {
            var resultado = _presupuestoService.ObtenerPresupuestos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var modelosRespuesta = resultado.Data;
            List<PresupuestoDto> presupuestos = new List<PresupuestoDto>();
            foreach (var presupuesto in modelosRespuesta)
            {
                string id = presupuesto.RecID;
                PresupuestoControl presupuestoControl = null;
                ProductoIngreso productoIngreso = null;
                IngresoDto ingreso = null;
                int presupuestoIdControl = 0;
                short resultadoParse;
                if ((Int16.TryParse(ObtenerPosicionesDeCadena(id), out resultadoParse) == true))
                {
                    presupuestoIdControl = Int16.Parse(ObtenerPosicionesDeCadena(id));
                    if (_presupuestoService.ObtenerPresupuestoControl(presupuestoIdControl).Message == "" && _presupuestoService.ObtenerPresupuestoControl(presupuestoIdControl) != null)
                    {
                        presupuestoControl = _presupuestoService.ObtenerPresupuestoControl(presupuestoIdControl).Data;
                        if (_presupuestoService.ObtenerProductoIngreso(presupuestoControl.Id).Message == "" && _presupuestoService.ObtenerProductoIngreso(presupuestoControl.Id) != null)
                        {
                            productoIngreso = _presupuestoService.ObtenerProductoIngreso(presupuestoControl.Id).Data;
                            if (_ingresoService.ObtenerIngreso(productoIngreso.IngresoId).Message == "" && _presupuestoService.ObtenerProductoIngreso(presupuestoControl.Id) != null)
                            {
                                ingreso = _ingresoService.ObtenerIngresos().Data.FirstOrDefault(x => x.IngresoId == productoIngreso.IngresoId);
                                presupuesto.IngresoId = ingreso.IngresoId;
                                presupuesto.ClienteId = ingresosInstrumentos.FirstOrDefault(x => x.IngresoId == presupuesto.IngresoId).Ingreso.NombreEmpresa;
                                presupuesto.NombreCliente = ingresosInstrumentos.FirstOrDefault(x => x.IngresoId == presupuesto.IngresoId).Ingreso.NombreContacto;
                                var ClasificacionInstrumento = ingresosInstrumentos.FirstOrDefault(x => x.IngresoId == ingreso.IngresoId).Instrumento.Clasificacion.TipoInstrumento.Descripcion;
                                presupuestos.Add(presupuesto);
                            }
                        }
                    }
                }
            }
            return presupuestos;
        }
        private void CargarPresupuestos()
        { 
            var resultado = _presupuestoService.ObtenerPresupuestos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var modelosRespuesta = resultado.Data;
            List<PresupuestoDto> presupuestos = new List<PresupuestoDto>();
            foreach (var presupuesto in modelosRespuesta)
            {                 
                    string id = presupuesto.RecID;
                    PresupuestoControl presupuestoControl = null;
                    ProductoIngreso productoIngreso = null;
                    IngresoDto ingreso = null;
                    int presupuestoIdControl = 0;
                    short resultadoParse;
                    if ((Int16.TryParse(ObtenerPosicionesDeCadena(id), out resultadoParse)))
                    {
                        presupuestoIdControl = Int16.Parse(ObtenerPosicionesDeCadena(id));
                        var mensajePC = _presupuestoService.ObtenerPresupuestoControl(presupuestoIdControl).Message;
                        var presupuestoContr = _presupuestoService.ObtenerPresupuestoControl(presupuestoIdControl);
                        if (mensajePC == "" && presupuestoContr != null && presupuestoContr.Data.Estado == 1)
                        {
                            presupuestoControl = _presupuestoService.ObtenerPresupuestoControl(presupuestoIdControl).Data;
                            var mensajePI = _presupuestoService.ObtenerProductoIngreso(presupuestoControl.Id).Message;
                            var productoIngr = _presupuestoService.ObtenerProductoIngreso(presupuestoControl.Id);
                            if (mensajePI == "" && productoIngr != null)
                            {
                                productoIngreso = _presupuestoService.ObtenerProductoIngreso(presupuestoControl.Id).Data;
                                var mensajeI = _ingresoService.ObtenerIngreso(productoIngreso.IngresoId).Message;
                                var productoIng = _presupuestoService.ObtenerProductoIngreso(presupuestoControl.Id);
                                if (mensajeI == "" && productoIng != null)
                                {
                                    ingreso = _ingresoService.ObtenerIngresos().Data.FirstOrDefault(x => x.IngresoId == productoIngreso.IngresoId);
                                    presupuesto.IngresoId = ingreso.IngresoId;
                                    presupuesto.ClienteId = ingresosInstrumentos.FirstOrDefault(x => x.IngresoId == presupuesto.IngresoId).Ingreso.NombreEmpresa;
                                    presupuesto.NombreCliente = ingresosInstrumentos.FirstOrDefault(x => x.IngresoId == presupuesto.IngresoId).Ingreso.NombreContacto;
                                    var ClasificacionInstrumento = ingresosInstrumentos.FirstOrDefault(x => x.IngresoId == ingreso.IngresoId).Instrumento.Clasificacion.TipoInstrumento.Descripcion;
                                    presupuestos.Add(presupuesto);
                                }
                            }
                        }
                    }               
            }
            gcPresupuestos.DataSource = presupuestos;
            gcPresupuestos.RefreshDataSource();
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantallaPres = new ctlEncabezadoPantalla();
            ctlEncabezadoPantallaPres.Parent = this;
            ctlEncabezadoPantallaPres.Height = 43;
            ctlEncabezadoPantallaPres.Dock = System.Windows.Forms.DockStyle.Top;
            ctlEncabezadoPantallaPres.lblTitulo.Text = "Presupuestos";
            ctlEncabezadoPantallaPres.EstablecerColoresDeFondoYLetra();
        }
        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {gvPresupuesto.RowCount}";
            lblTotal.Visible = true;
        }
        private void ObtenerIngresoInstrumento()
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

            SetearTotales();
        }
        private void btnEditPresupuestoClick(object sender, EventArgs e)
        {
            presupuestoSeleccionado = gvPresupuesto.GetFocusedRow() as PresupuestoDto;
            if (presupuestoSeleccionado == null) return;
            var presupuestoDb = _presupuestoService.ObtenerPresupuestos().Data.FirstOrDefault(x => x.ID == presupuestoSeleccionado.ID);
            presupuestoDb = ObtenerPresupuestos().Where(x => x.ID == presupuestoSeleccionado.ID).FirstOrDefault(x => x.ID == presupuestoSeleccionado.ID);
            var frmEditarPresupuesto = new frmEditarPresupuesto(presupuestoDb, serviceProvider.GetService<IngresoService>(),
                                                    serviceProvider.GetService<ProductoService>(),
                                                    serviceProvider.GetService<PresupuestoService>(),
                                                    serviceProvider.GetService<MonedaService>()
                                                    );
            frmEditarPresupuesto.Text = "Editar Presupuesto";
            frmEditarPresupuesto.Presupuesto = presupuestoDb;
            frmEditarPresupuesto.ShowDialog();
            frmEditarPresupuesto.MdiParent = this.ParentForm;
        }
    }
}