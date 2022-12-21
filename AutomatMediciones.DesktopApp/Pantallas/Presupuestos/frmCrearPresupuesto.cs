using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos;
using AutomatMediciones.DesktopApp.Pantallas.Presupuestos.Dtos;
using AutomatMediciones.DesktopApp.Pantallas.Productos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
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
        private readonly PresupuestoService _presupuestoService;
        private readonly MonedaService _monedaService;

        public delegate void ArbolCarpetasCreado(TreeView treeView);
        public event ArbolCarpetasCreado OnArbolCarpetasCreado;

        public IngresoInstrumento IngresoInstrumento { get; set; }
        public List<ProductoDto> ProductosEnPresupuesto { get; set; }
        public TreeView TreeView { get; set; }

        List<MonedaDto> monedas = new List<MonedaDto>();

        public PresupuestoDto Presupuesto { get; set; }

        MonedaDto monedaSeleccionada = new MonedaDto();

        public frmCrearPresupuesto(IngresoInstrumento ingresoInstrumento, ProductoService productoService, PresupuestoService presupuestoService,
            MonedaService monedaService)
        {
            InitializeComponent();
            TreeView = new TreeView();
            IngresoInstrumento = ingresoInstrumento;
            _productoService = productoService;
            _presupuestoService = presupuestoService;
            _monedaService = monedaService;
            Presupuesto = new PresupuestoDto();
            ProductosEnPresupuesto = new List<ProductoDto>();

            EstablecerNombreYTituloDePantalla();
            EstablecerColorBotonPorDefecto();
            EstablecerColorBotonGuardar();
            ObtenerMonedas();
            PrecargarDatos();

            txtCantidad.KeyPress += txtCantidadKeyPress;
            btnEliminar.Click += btnEliminarClick;
            txtPrecio.KeyPress += txtCantidadKeyPress;
            txtCantidad.EditValueChanging += txtCantidadEditValueChanging;
            txtPrecio.EditValueChanging += txtPrecioEditValueChanging;
            btnGuardar.Click += btnGuardarClick;

            lookupMonedas.EditValueChanged += lookupMonedasEditValueChanged;
        }

        private void lookupMonedasEditValueChanged(object sender, EventArgs e)
        {
            monedaSeleccionada = lookupMonedas.GetSelectedDataRow() as MonedaDto;
        }

        private void btnGuardarClick(object sender, EventArgs e)
        {
            if (ProductosEnPresupuesto.Count == 0)
            {
                Notificaciones.MensajeAdvertencia("Es necesario que agregue al menos un producto al presupuesto.");
                return;
            }

            if (string.IsNullOrEmpty(txtNombrePresupuesto.Text))
            {
                Notificaciones.MensajeAdvertencia("Es necesario que agregue un nombre para el presupuesto.");
                return;
            }

            if (monedaSeleccionada == null)
            {
                Notificaciones.MensajeAdvertencia("Es necesario que seleccione una moneda para el presupuesto.");
                return;
            }

            PrepararNuevoPresupuesto();
            var resultadoIngresoPresupuesto = _presupuestoService.RegistrarPresupuesto(Presupuesto);

            if (resultadoIngresoPresupuesto.Type != TypeResponse.Ok)
            {
                Notificaciones.MensajeError(resultadoIngresoPresupuesto.Message);
                return;
            }

            Notificaciones.MensajeConfirmacion("¡El presupuesto se regitró exitosamente!");

            this.Close();

        }

        private void PrepararNuevoPresupuesto()
        {
            decimal total = 0;
            decimal subtotal = 0;
            decimal impuesto = 0;

            subtotal = ProductosEnPresupuesto.Sum(x => x.SubTotal);
            total = ProductosEnPresupuesto.Sum(x => x.Total);
            impuesto = ProductosEnPresupuesto.Sum(x => x.Impuesto);

            Presupuesto.Nombre = txtNombrePresupuesto.Text;
            Presupuesto.Descripcion = memoDescripcion.Text;
            Presupuesto.NroMoneda = monedaSeleccionada.Numero;
            Presupuesto.MonedaRecId = monedaSeleccionada.RecID;
            Presupuesto.IDRef = IngresoInstrumento.Ingreso.ContactoId;
            Presupuesto.Total = total;
            Presupuesto.Subtotal = subtotal;
            Presupuesto.Impuesto = impuesto;
            Presupuesto.Estado = 0;
            Presupuesto.IDUsuario = $"AM_V{Application.ProductVersion}";
            Presupuesto.Cierre = "";
            Presupuesto.Introduccion = "";
            Presupuesto.Descuento = 0;
            Presupuesto.IDCampania = "";
            Presupuesto.IDFormula = "";
            Presupuesto.Revision = 1;
            Presupuesto.Auditoria = "";
            Presupuesto.ImpuestosInternos = 0;
            Presupuesto.MotivoCierre = "";
            Presupuesto.Productos = ProductosEnPresupuesto;
            Presupuesto.IngresoId = IngresoInstrumento.IngresoId;
            Presupuesto.ModeloId = IngresoInstrumento.Instrumento.Clasificacion.ModeloId;
            Presupuesto.InstrumentoId = IngresoInstrumento.Instrumento.InstrumentoId;
            Presupuesto.NombreCliente = IngresoInstrumento.Ingreso.NombreEmpresa;
            Presupuesto.ClienteId = IngresoInstrumento.Ingreso.EmpresaId;
        }

        private void SetearSummary()
        {
            decimal cantidad = 0;
            ProductosEnPresupuesto.ForEach(x => cantidad += x.Total);

            lblSummary.Visible = true;
            lblSummary.Text = $"Total: {cantidad}";
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {gvProductosPresupuesto.RowCount}";
            lblTotal.Visible = true;
        }

        private void txtPrecioEditValueChanging(object sender, ChangingEventArgs e)
        {
            var filaSeleccionada = ObtenerProductoSeleccionado();
            if (filaSeleccionada == null) return;

            if (string.IsNullOrEmpty(e.NewValue.ToString())) return;
            decimal precio = Decimal.Parse(e.NewValue.ToString());

            if (!EsValidaLaCantidad(precio))
            {
                Notificaciones.MensajeAdvertencia("El precio no puede ser menor o igual que cero.");
                return;
            }

            filaSeleccionada.SubTotal = CalculaSubTotal(filaSeleccionada.Cantidad, precio);
            filaSeleccionada.Impuesto = CalcularImpuesto(filaSeleccionada.SubTotal);
            filaSeleccionada.Total = CalcularTotal(filaSeleccionada.SubTotal, filaSeleccionada.Impuesto);
            SetearSummary();
        }

        private void txtCantidadEditValueChanging(object sender, ChangingEventArgs e)
        {
            var filaSeleccionada = ObtenerProductoSeleccionado();
            if (filaSeleccionada == null) return;

            if (string.IsNullOrEmpty(e.NewValue.ToString())) return;
            decimal cantidad = Decimal.Parse(e.NewValue.ToString());

            if (!EsValidaLaCantidad(cantidad))
            {
                Notificaciones.MensajeAdvertencia("La cantidad no puede ser menor o igual que cero.");
                return;
            }

            filaSeleccionada.SubTotal = CalculaSubTotal(cantidad, filaSeleccionada.Precio);
            filaSeleccionada.Impuesto = CalcularImpuesto(filaSeleccionada.SubTotal);
            filaSeleccionada.Total = CalcularTotal(filaSeleccionada.SubTotal, filaSeleccionada.Impuesto);
            SetearSummary();
        }

        private decimal CalculaSubTotal(decimal cantidad, decimal precio)
        {
            decimal subtotal = precio * cantidad;
            return subtotal;
        }

        private decimal CalcularImpuesto(decimal subtotal)
        {
            decimal porcentajeImpuesto = 0.21M;
            decimal impuesto = subtotal * porcentajeImpuesto;

            CalcularTotal(subtotal, impuesto);

            return impuesto;
        }

        private decimal CalcularTotal(decimal subtotal, decimal impuesto)
        {
            decimal total = subtotal + impuesto;
            return total;
        }

        private bool EsValidaLaCantidad(decimal cantidad)
        {
            if (cantidad <= 0) return false;
            return true;
        }

        private void txtCantidadKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',' || e.KeyChar == '.');
        }

        private ProductoDto ObtenerProductoSeleccionado()
        {
            var filaSeleccionada = gvProductosPresupuesto.GetFocusedRow() as ProductoDto;
            return filaSeleccionada;
        }

        private void btnEliminarClick(object sender, EventArgs e)
        {
            var filaSeleccionada = ObtenerProductoSeleccionado();
            if (filaSeleccionada == null) return;
            QuitarProductoDeLista(filaSeleccionada);

        }

        private void ObtenerMonedas()
        {
            var resultado = _monedaService.ObtenerMonedas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            monedas = resultado.Data;

            leMonedas.DataSource = monedas;
            leMonedas.ValueMember = "Numero";
            leMonedas.DisplayMember = "Descripcion";

            lookupMonedas.Properties.DataSource = monedas;
            lookupMonedas.Properties.ValueMember = "Numero";
            lookupMonedas.Properties.DisplayMember = "Descripcion";

            monedaSeleccionada = monedas.FirstOrDefault(x => x.Numero == 2);
            lookupMonedas.EditValue = monedaSeleccionada.Numero;
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

            CargarPresupuestos();
        }

        private void CargarPresupuestos()
        {
            int modeloId; int instrumentoId; string clienteId;

            modeloId = IngresoInstrumento.Instrumento.Clasificacion.Modelo.ModeloId;
            instrumentoId = IngresoInstrumento.Instrumento.InstrumentoId;
            clienteId = IngresoInstrumento.Ingreso.EmpresaId;

            var resultado = _presupuestoService.ObtenerPresupuestosPorInstrumentoClienteYmodelo(instrumentoId, clienteId, modeloId);
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var presupuestos = resultado.Data;

            List<PresupuestoViewDto> listaDePresupuestos = new List<PresupuestoViewDto>();
            if (presupuestos == null) return;

            if (!presupuestos.Any()) return;

            presupuestos.ForEach(x =>
            {
                var presupuesto = new PresupuestoViewDto
                {
                    RecID = x.RecID,
                    FechaCreacion = x.FechaCreacion,
                    Moneda = x.Moneda.Descripcion,
                    Nombre = x.Nombre,
                    NroMoneda = x.NroMoneda,
                    Total = x.Total,
                    PresupuestoItems = new List<PresupuestoDetalleViewDto>()
                };

                if (x.PresupuestoItems.Any())
                {
                    x.PresupuestoItems.ForEach(y =>
                    {
                        var presupuestoItem = new PresupuestoDetalleViewDto
                        {
                            Descripcion = y.Descripcion,
                            Cantidad = y.Cantidad,
                            Precio = ObtenerPrecioSegunMoneda(x.NroMoneda, y),
                        };

                        presupuesto.PresupuestoItems.Add(presupuestoItem);
                    });

                }


                listaDePresupuestos.Add(presupuesto);
            });

            gcHistorialPresupuesto.DataSource = listaDePresupuestos;
            gcHistorialPresupuesto.RefreshDataSource();

        }

        private decimal ObtenerPrecioSegunMoneda(int numeroMoneda, PresupuestoItemDto presupuestoDto)
        {
            double precio = 0;
            switch (numeroMoneda)
            {
                case 1:
                    precio = presupuestoDto.ImportePrecio1.Value;
                    break;
                case 2:
                    precio = presupuestoDto.ImportePrecio2.Value;
                    break;
                case 3:
                    precio = presupuestoDto.ImportePrecio3.Value;
                    break;
                case 4:
                    precio = presupuestoDto.ImportePrecio4.Value;
                    break;
                case 5:
                    precio = presupuestoDto.ImportePrecio5.Value;
                    break;
                case 6:
                    precio = presupuestoDto.ImportePrecio6.Value;
                    break;
            }

            return Convert.ToDecimal(precio);
        }

        private void btnAgregarProductosDesdeArchivoMaestro_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var frmMaestroProductos = new frmProductos(serviceProvider.GetService<ProductoService>());

            frmMaestroProductos.OnListaProductosAgregados += frmMaestroProductosOnListaProductosAgregados;
            frmMaestroProductos.OnArbolCarpetasCreado += frmMaestroProductosOnArbolCarpetaCreado;

            if (TreeView.Nodes.Count > 0) {
                foreach (TreeNode item in TreeView.Nodes)
                {
                    var itemParaAgregar = item.Clone() as TreeNode;
                    frmMaestroProductos.treeView1.Nodes.Add(itemParaAgregar);
                }
            }
            else frmMaestroProductos.CargarArbolCarpetas();
            
            frmMaestroProductos.ProductosEnPresupuesto = ProductosEnPresupuesto;     
            frmMaestroProductos.ShowDialog();
            SplashScreenManager.CloseForm();
        }

        private void frmMaestroProductosOnArbolCarpetaCreado(TreeView treeView)
        {
            TreeView = treeView;
            OnArbolCarpetasCreado?.Invoke(treeView);
        }

        private void AgregarProductosALista(List<ProductoDto> productos)
        {

            productos.ForEach(producto =>
            {
                if (!EsValidaLaCantidad(producto.Cantidad))
                {
                    Notificaciones.MensajeAdvertencia("La cantidad no puede ser menor o igual que cero.");
                    return;
                }

                producto.SubTotal = CalculaSubTotal(producto.Cantidad, producto.Precio);
                producto.Impuesto = CalcularImpuesto(producto.SubTotal);
                producto.Total = CalcularTotal(producto.SubTotal, producto.Impuesto);
               
            });

            ProductosEnPresupuesto.AddRange(productos);
            gcProductosPresupuesto.DataSource = ProductosEnPresupuesto;
            gcProductosPresupuesto.RefreshDataSource();

            SetearTotales();
            SetearSummary();
        }

        private void QuitarProductoDeLista(ProductoDto producto)
        {
            ProductosEnPresupuesto = ProductosEnPresupuesto.Where(x => x.RecID != producto.RecID).ToList();
            gcProductosPresupuesto.DataSource = ProductosEnPresupuesto;
            gcProductosPresupuesto.RefreshDataSource();

            SetearTotales();
        }

        private void frmMaestroProductosOnListaProductosAgregados(List<ProductoDto> productos)
        {
            AgregarProductosALista(productos);
        }

        private void btnAgregarDesdeHistorialPresupuesto_Click(object sender, EventArgs e)
        {
            var frmHistorial = new frmHistorialPresupuesto(serviceProvider.GetService<PresupuestoService>(), serviceProvider.GetService<ProductoService>());
            frmHistorial.ProductosEnPresupuesto = ProductosEnPresupuesto;
            frmHistorial.OnListaProductosAgregados += frmHistorialOnListaProductosAgregados;
            frmHistorial.ModeloId = IngresoInstrumento.Instrumento.Clasificacion.ModeloId;
            frmHistorial.InstrumentoId = IngresoInstrumento.Instrumento.InstrumentoId;
            frmHistorial.ClienteId = IngresoInstrumento.Ingreso.EmpresaId;
            frmHistorial.CargaInicial();
            frmHistorial.ShowDialog();
        }

        private void frmHistorialOnListaProductosAgregados(List<ProductoDto> productos)
        {
            AgregarProductosALista(productos);
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtClasificacion_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
