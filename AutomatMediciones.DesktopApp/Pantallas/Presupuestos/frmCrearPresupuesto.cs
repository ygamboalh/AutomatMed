using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos;
using AutomatMediciones.DesktopApp.Pantallas.Productos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Presupuestos
{
    public partial class frmCrearPresupuesto : DevExpress.XtraEditors.XtraForm
    {
        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        public IngresoInstrumento IngresoInstrumento { get; set; }

        public List<ProductoDto> ProductosEnPresupuesto { get; set; }
        public frmCrearPresupuesto(IngresoInstrumento ingresoInstrumento)
        {
            InitializeComponent();
            IngresoInstrumento = ingresoInstrumento;
            ProductosEnPresupuesto = new List<ProductoDto>();
            EstablecerNombreYTituloDePantalla();
            PrecargarDatos();
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