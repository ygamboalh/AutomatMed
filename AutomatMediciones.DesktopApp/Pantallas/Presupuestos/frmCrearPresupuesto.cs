using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos;
using AutomatMediciones.DesktopApp.Pantallas.Productos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Presupuestos
{
    public partial class frmCrearPresupuesto : DevExpress.XtraEditors.XtraForm
    {
        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly ProductoService _productoService;

        public IngresoInstrumento IngresoInstrumento { get; set; }

        public List<ProductoDto> ProductosEnPresupuesto { get; set; }
        public frmCrearPresupuesto(IngresoInstrumento ingresoInstrumento, ProductoService productoService)
        {
            InitializeComponent();
            IngresoInstrumento = ingresoInstrumento;
            _productoService = productoService;
            ProductosEnPresupuesto = new List<ProductoDto>();
            EstablecerNombreYTituloDePantalla();
            EstablecerColorBotonPorDefecto();
            EstablecerColorBotonGuardar();
            ObtenerMonedas();
            PrecargarDatos();

            txtCantidad.KeyPress += txtCantidadKeyPress;
            btnEliminar.Click += btnEliminarClick;
            txtPrecio.KeyPress += txtCantidadKeyPress;
        }

        private void txtCantidadKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',' || e.KeyChar == '.');
        }

        private void btnEliminarClick(object sender, EventArgs e)
        {
            var filaSeleccionada = gvProductosPresupuesto.GetFocusedRow() as ProductoDto;
            if (filaSeleccionada == null) return;
            QuitarProductoDeLista(filaSeleccionada);

        }

        private void ObtenerMonedas()
        {
            var resultado = _productoService.ObtenerMonedas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var monedas = resultado.Data;

            leMonedas.DataSource = monedas;
            leMonedas.ValueMember = "Numero";
            leMonedas.DisplayMember = "Descripcion";

          

        }

        private void EstablecerColorBotonGuardar()
        {
            btnGuardar.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardar.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardar.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }
        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarDesdeHistorialPresupuesto.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarDesdeHistorialPresupuesto.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarDesdeHistorialPresupuesto.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");

            btnAgregarProductosDesdeArchivoMaestro.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarProductosDesdeArchivoMaestro.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarProductosDesdeArchivoMaestro.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void EstablecerNombreYTituloDePantalla()
        {

            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Crear Presupuesto";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void PrecargarDatos()
        {
            var tipoInstrumento = IngresoInstrumento.Instrumento.Clasificacion.TipoInstrumento.Descripcion;
            var marca = IngresoInstrumento.Instrumento.Clasificacion.Marca.Descripcion;
            var modelo = IngresoInstrumento.Instrumento.Clasificacion.Modelo.Descripcion;
            var serie = IngresoInstrumento.Instrumento.NumeroSerie;

            txtContactoACargo.Text = $"{IngresoInstrumento.Ingreso.NombreContacto} {IngresoInstrumento.Ingreso.ApellidoContacto}";
            txtCliente.Text = IngresoInstrumento.Ingreso.NombreEmpresa;
            txtNumeroServicioTecnico.Text = IngresoInstrumento.NumeroServicioTecnico;

            txtClasificacion.Text = $"{tipoInstrumento} / {marca} / {modelo} - Serie: {serie}";
            txtTipoOrdenTrabajo.Text = IngresoInstrumento.TipoTrabajo.Descripcion;

            IngresoInstrumento.FechaInicio = IngresoInstrumento.FechaInicio == null ? DateTime.Now : IngresoInstrumento.FechaInicio;
        }

        private void btnAgregarProductosDesdeArchivoMaestro_Click(object sender, EventArgs e)
        {
            var frmMaestroProductos = new frmProductos(serviceProvider.GetService<ProductoService>());
            frmMaestroProductos.OnListaProductosAgregados += frmMaestroProductosOnListaProductosAgregados;
            frmMaestroProductos.ProductosEnPresupuesto = ProductosEnPresupuesto;
            frmMaestroProductos.ShowDialog();
        }

        private void AgregarProductosALista(List<ProductoDto> productos)
        {
            ProductosEnPresupuesto.AddRange(productos);
            gcProductosPresupuesto.DataSource = ProductosEnPresupuesto;
            gcProductosPresupuesto.RefreshDataSource();
        }

        private void QuitarProductoDeLista(ProductoDto producto)
        {
            ProductosEnPresupuesto = ProductosEnPresupuesto.Where(x => x.RecID != producto.RecID).ToList();
            gcProductosPresupuesto.DataSource = ProductosEnPresupuesto;
            gcProductosPresupuesto.RefreshDataSource();
        }

        private void frmMaestroProductosOnListaProductosAgregados(List<ProductoDto> productos)
        {
            AgregarProductosALista(productos);
        }

        private void btnAgregarDesdeHistorialPresupuesto_Click(object sender, EventArgs e)
        {
            var frmHistorial = new frmHistorialPresupuesto();
            frmHistorial.ShowDialog();
        }
    }
}