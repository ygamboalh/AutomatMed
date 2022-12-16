using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos;
using AutomatMediciones.DesktopApp.Pantallas.Presupuestos.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatMediciones.DesktopApp.Pantallas.Presupuestos
{
    public partial class frmHistorialPresupuesto : DevExpress.XtraEditors.XtraForm
    {
        private readonly PresupuestoService _presupuestoService;
        private readonly ProductoService _productoService;

        public List<ProductoIngresoVista> ProductosIngresos { get; set; }
        public List<ProductoDto> ProductosEnPresupuesto { get; set; }

        public int ModeloId { get; set; }
        public string ClienteId { get; set; }
        public int InstrumentoId { get; set; }
        List<ProductoIngresoVista> productosSeleccionados = new List<ProductoIngresoVista>();

        public delegate void AgregarListaProductos(List<ProductoDto> productos);
        public event AgregarListaProductos OnListaProductosAgregados;

        public frmHistorialPresupuesto(PresupuestoService presupuestoService, ProductoService productoService)
        {
            InitializeComponent();

            chkSeleccionar.EditValueChanging += chkSeleccionarEditValueChanging;

            _presupuestoService = presupuestoService;
            _productoService = productoService;

            ProductosIngresos = new List<ProductoIngresoVista>();
            EstablecerNombreYTitulo();
            EstablecerColorBotonGuardar();
            CargarHistorial();
        }

        private bool ExisteElProductoEnPresupuesto(string productoId)
        {
            var existe = ProductosEnPresupuesto.Any(x => x.RecID == productoId);
            return existe;
        }

        private void chkSeleccionarEditValueChanging(object sender, ChangingEventArgs e)
        {
            var filaSeleccionada = gvHistorialPresupuesto.GetFocusedRow() as ProductoIngresoVista;
            if (filaSeleccionada == null) return;

            filaSeleccionada.Seleccionar = Convert.ToBoolean(e.NewValue);
            if (filaSeleccionada.Seleccionar)
            {
                if (ExisteElProductoEnPresupuesto(filaSeleccionada.ProductoId))
                {
                    e.NewValue = false;
                    e.Cancel = true;

                    filaSeleccionada.Seleccionar = false;
                    Notificaciones.MensajeAdvertencia("Este producto ya se agregó al presupuesto");
                    return;
                }

                productosSeleccionados.Add(filaSeleccionada);

            }
            else productosSeleccionados = productosSeleccionados.Where(x => x.ProductoId != filaSeleccionada.ProductoId).ToList();

            CargarTotoales();
        }

        private void CargarTotoales()
        {
            lblTotal.Visible = true;
            lblTotalSeleccionados.Visible = true;
            lblTotal.Text = $"Total registros: {gvHistorialPresupuesto.RowCount}";
            lblTotalSeleccionados.Text = $"Total seleccionados: {productosSeleccionados.Count}";
        }

        private void EstablecerColorBotonGuardar()
        {
            btnAgregarProductosSeleccionados.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnAgregarProductosSeleccionados.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarProductosSeleccionados.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void ConvertirRegistrosALista(List<ProductoIngresoDto> productoIngresosDtos)
        {
            productoIngresosDtos.ForEach(producto =>
            {
                ProductoIngresoVista productoIngresoVista = new ProductoIngresoVista
                {
                    Activo = producto.Activo,
                    Cantidad = producto.Cantidad,
                    ClienteId = producto.ClienteId,
                    Descripcion = producto.Descripcion,
                    FechaRegistro = producto.FechaRegistro,
                    Id = producto.Id,
                    IngresoId = producto.IngresoId,
                    Instrumento = producto.Instrumento,
                    InstrumentoId = producto.InstrumentoId,
                    Modelo = producto.Modelo,
                    ModeloId = producto.ModeloId,
                    NombreCliente = producto.NombreCliente,
                    Precio = producto.Precio,
                    ProductoId = producto.ProductoId,
                    Seleccionar = false
                };


                ProductosIngresos.Add(productoIngresoVista);
            });
        }

        private void CargarHistorial()
        {
            var desde = dateDesde != null ? dateDesde.EditValue: null;
            var hasta = dateHasta != null ? dateHasta.EditValue: null;

          
            if (desde != null  && hasta != null)
            {
                var resultado = _presupuestoService.CargarHistorialPresupuesto((DateTime)desde, (DateTime)hasta, ModeloId,
                                                                                InstrumentoId, ClienteId);

                if (resultado.Type != Nagaira.Herramientas.Standard.Helpers.Responses.TypeResponse.Ok)
                {
                    Notificaciones.MensajeError(resultado.Message);
                    return;
                }

                ConvertirRegistrosALista(resultado.Data);

                gcHistorialPresupuesto.DataSource = ProductosIngresos;
                gcHistorialPresupuesto.RefreshDataSource();
            }
            else
            {
                var resultado = _presupuestoService.CargarHistorialPresupuesto(null, null, ModeloId,
                                                                                InstrumentoId, ClienteId);

                if (resultado.Type != Nagaira.Herramientas.Standard.Helpers.Responses.TypeResponse.Ok)
                {
                    Notificaciones.MensajeError(resultado.Message);
                    return;
                }
                ConvertirRegistrosALista(resultado.Data);

                gcHistorialPresupuesto.DataSource = ProductosIngresos;
                gcHistorialPresupuesto.RefreshDataSource();
            }

            SetearTotales();
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = System.Windows.Forms.DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Historial de Presupuestos";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void btnFiltroModelo_Click(object sender, System.EventArgs e)
        {
            ActivacionColumnas(3);
            CargarHistorial();
        }

        private void btnFiltroPorCliente_Click(object sender, System.EventArgs e)
        {
            ActivacionColumnas(2);
            CargarHistorial();
        }

        private void btnFiltroPorInstrumento_Click(object sender, System.EventArgs e)
        {
            ActivacionColumnas(1);
            CargarHistorial();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {gvHistorialPresupuesto.RowCount}";
            lblTotal.Visible = true;
        }

        private void ActivacionColumnas(int filtro)
        {
            if (filtro == 1)
            {
                colInstrumento.Visible = true;
                colInstrumento.VisibleIndex = 0;
                colCliente.Visible = false;
                colModelo.Visible = false;
            }
            else if (filtro == 2)
            {
                colInstrumento.Visible = false;
                colCliente.Visible = true;
                colCliente.VisibleIndex = 0;
                colModelo.Visible = false;
            }
            else
            {
                colInstrumento.Visible = false;
                colCliente.Visible = false;
                colModelo.Visible = true;
                colModelo.VisibleIndex = 0;
            }
        }

        private void btnAgregarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            if (productosSeleccionados.Count == 0)
            {
                Notificaciones.MensajeAdvertencia("Es necesario que seleccione al menos un producto");
                return;
            }

            List<ProductoDto> productos = new List<ProductoDto>();

            productosSeleccionados.ForEach(x =>
            {
                var productoDb = _productoService.ObtenerProductoPorId(x.ProductoId);

                productoDb.Data.Cantidad = x.Cantidad;
                productoDb.Data.Precio = x.Precio;


                productos.Add(productoDb.Data);
            });

            OnListaProductosAgregados?.Invoke(productos);
            this.Close();
        }
    }
}