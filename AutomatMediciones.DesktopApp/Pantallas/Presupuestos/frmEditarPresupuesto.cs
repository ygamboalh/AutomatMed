using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos;
using AutomatMediciones.DesktopApp.Pantallas.Presupuestos.Dtos;
using AutomatMediciones.DesktopApp.Pantallas.Productos;
using AutomatMediciones.DesktopApp.Pantallas.Productos.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Presupuestos
{
    public partial class frmEditarPresupuesto : DevExpress.XtraEditors.XtraForm
    {
        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly ProductoService _productoService;
        private readonly PresupuestoService _presupuestoService;
        private readonly MonedaService _monedaService;
        private readonly IngresoService _ingresoService;

        public delegate void ArbolCarpetasCreado(TreeView treeView);
        public event ArbolCarpetasCreado OnArbolCarpetasCreado;

        public List<ProductoDto> ProductosEnPresupuesto { get; set; }
        public TreeView TreeView { get; set; }

        List<MonedaDto> monedas = new List<MonedaDto>();

        public MonedaCotizacionDto MonedaCotizacionActual { get; set; }

        public PresupuestoDto Presupuesto { get; set; }

        MonedaDto monedaSeleccionada = new MonedaDto();
        public PresupuestoDto presupuestoSeleccionado = new PresupuestoDto();
        public List<IngresoInstrumentoDto> ingresoInstrumentoDtos { get; set; }

        public frmEditarPresupuesto(PresupuestoDto presupuestoDto,IngresoService ingresoService, ProductoService productoService, PresupuestoService presupuestoService,
            MonedaService monedaService)
        {
            InitializeComponent();
            TreeView = new TreeView();

            _productoService = productoService;
            _presupuestoService = presupuestoService;
            _monedaService = monedaService;
            _ingresoService = ingresoService;
            Presupuesto = presupuestoDto;
            
            ProductosEnPresupuesto = new List<ProductoDto>();
            EstablecerNombreYTituloDePantalla();
            EstablecerColorBotonPorDefecto();
            EstablecerColorBotonGuardar();
            ObtenerMonedas();
            ObtenerIngresoInstrumento();
            ObtenerProductosIngresoId();
            MonedaCotizacionActual = CargarMonedaCotizacionActual();
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
            if (monedaSeleccionada == null) return;
            RecalcularPrecioSegunMonedaSeleccionada();
        }

        public List<ProductoDto>  ObtenerProductosIngresoId() 
        {
            int ingresoId = Presupuesto.IngresoId;
            var productosIngreso = _presupuestoService.ObtenerProductosIngresos(ingresoId);
            List<ProductoDto> productosDto = new List<ProductoDto>();

            int contador = productosIngreso.Data.Count;
            if (contador > 0)
            {
                for (int i = 0; i < productosIngreso.Data.Count; i++)
                {
                    decimal precio = productosIngreso.Data[i].Precio;
                    decimal cantidad = productosIngreso.Data[i].Cantidad;
                    decimal subtotal = CalculaSubTotal(cantidad, precio);
                    decimal impuesto = CalcularImpuesto(subtotal);
                    decimal total = CalcularTotal(subtotal, impuesto);
                    string recid = productosIngreso.Data[i].ProductoId.ToString();
                    string descripcion = productosIngreso.Data[i].Descripcion;
                    productosDto.Add(new ProductoDto
                    {
                        RecID = recid,
                        Descripcion = descripcion,
                        Precio = precio,
                        Cantidad = cantidad,
                        Impuesto = impuesto,
                        SubTotal = subtotal,
                        Total = total
                    });
                }
            }
            gcProductosPresupuesto.DataSource = productosDto;
            gcProductosPresupuesto.RefreshDataSource();
            return productosDto;
        }
        private void btnGuardarClick(object sender, EventArgs e)
        {
            if (ProductosEnPresupuesto.Count == 0 && gvProductosPresupuesto.RowCount == 0)
            {
                Notificaciones.MensajeAdvertencia("Es necesario que agregue al menos un producto al presupuesto.");
                return;
            }

            if (monedaSeleccionada == null)
            {
                Notificaciones.MensajeAdvertencia("Es necesario que seleccione una moneda para el presupuesto.");
                return;
            }

            PrepararPresupuesto();
            var resultadoIngresoPresupuesto = _presupuestoService.ActualizarPresupuesto(Presupuesto);

            if (resultadoIngresoPresupuesto.Type != TypeResponse.Ok)
            {
                Notificaciones.MensajeError(resultadoIngresoPresupuesto.Message);
                return;
            }

            Notificaciones.MensajeConfirmacion("¡El presupuesto se regitró exitosamente!");

            this.Close();

        }

        private void PrepararPresupuesto()
        {
            IngresoDto ingresoDto = _ingresoService.ObtenerIngreso(Presupuesto.IngresoId).Data;
            Dominio.Caracteristicas.Entidades.IngresoInstrumento ingresoInstrumento = _ingresoService.ObtenerIngresoInstrumentoIdIngreso(ingresoDto.IngresoId).Data;
            decimal total = 0;
            decimal subtotal = 0;
            decimal impuesto = 0;

            subtotal = ProductosEnPresupuesto.Sum(x => x.SubTotal);
            total = ProductosEnPresupuesto.Sum(x => x.Total);
            impuesto = ProductosEnPresupuesto.Sum(x => x.Impuesto);
            Presupuesto.Nombre = $"P-{ingresoInstrumento.IngresoId}";
            Presupuesto.Nombre = txtClienteId.Text;
            Presupuesto.Descripcion = txtNombreCliente.Text;
            Presupuesto.NroMoneda = monedaSeleccionada.Numero;
            Presupuesto.MonedaRecId = monedaSeleccionada.RecID;
            Presupuesto.IDRef = ingresoInstrumento.Ingreso.ContactoId;
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
            Presupuesto.Productos = new List<ProductoDto>();
            ProductosEnPresupuesto = new List<ProductoDto>();
            int contador = gvProductosPresupuesto.RowCount;
            List<ProductoDto> productoDtos = new List<ProductoDto>();
            for (int i = 0; i < contador; i++)
            {
                var productoActual = gvProductosPresupuesto.GetRow(i) as ProductoDto;
                productoDtos.Add(productoActual);
            }
            Presupuesto.Productos = productoDtos;
            Presupuesto.IngresoId = ingresoInstrumento.IngresoId; 
            Presupuesto.ModeloId = ingresoInstrumento.Instrumento.Clasificacion.ModeloId;
            Presupuesto.InstrumentoId = ingresoInstrumento.Instrumento.InstrumentoId;
            Presupuesto.NombreCliente = ingresoInstrumento.Ingreso.NombreEmpresa;
            Presupuesto.ClienteId = ingresoInstrumento.Ingreso.EmpresaId;
        }

        private void SetearSummary()
        {
            decimal cantidad = 0;
            ProductosEnPresupuesto.ForEach(x => cantidad += x.Total);

            lblSummary.Visible = true;
            lblSummary.Text = $"Total: {string.Format("{0:#,##0.##}",cantidad)}";
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

        private void QuitarProductoDeLista(ProductoDto producto)
        {
            int contador = gvProductosPresupuesto.RowCount;
            List<ProductoDto> productoDtos = new List<ProductoDto>();
            for (int i = 0; i < contador; i++)
            {
                var productoActual = gvProductosPresupuesto.GetRow(i) as ProductoDto;
                if (productoActual.RecID != producto.RecID)
                {
                    productoDtos.Add(productoActual);
                }
            }

            gcProductosPresupuesto.DataSource = productoDtos;
            gcProductosPresupuesto.RefreshDataSource();

            SetearTotales();
        }
        private void btnEliminarClick(object sender, EventArgs e)
        {
            var filaSeleccionada = ObtenerProductoSeleccionado();
            if (filaSeleccionada == null) return;
            QuitarProductoDeLista(filaSeleccionada);
            gcProductosPresupuesto.RefreshDataSource();

        }
        private void ObtenerIngresoInstrumento() 
        {
            var resultado = _ingresoService.ObtenerIngresos();
            if (resultado.Type != TypeResponse.Ok)
            {
                Notificaciones.MensajeError(resultado.Message);
                return;
            }

            var resultad = _ingresoService.ObtenerIngresoInstrumento();
            if(resultado.Type!=TypeResponse.Ok) Notificaciones.MensajeError(resultad.Message);
            ingresoInstrumentoDtos = resultad.Data;
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
            ctlEncabezadoPantalla3.lblTitulo.Text = "Editar Presupuesto";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void PrecargarDatos()
        {
            IngresoDto ingresoDto = _ingresoService.ObtenerIngreso(Presupuesto.IngresoId).Data;
            Dominio.Caracteristicas.Entidades.IngresoInstrumento ingresoInstrumento = _ingresoService.ObtenerIngresoInstrumentoIdIngreso(ingresoDto.IngresoId).Data;
            txtClienteId.Text = ingresoDto.NombreEmpresa;
            txtNombreCliente.Text = ingresoDto.NombreContacto;
            txtNoServicioTecnico.Text = ingresoInstrumento.NumeroServicioTecnico.ToString();
            txtClasificacion.Text = ingresoInstrumento.Instrumento.Clasificacion.TipoInstrumento.Descripcion;
            txtNombrePresupuesto.Text = Presupuesto.Nombre;
        }

        private void CargarPresupuestos()
        {
            int modeloId; int instrumentoId; string clienteId;

            //modeloId = IngresoInstrumento.Instrumento.Clasificacion.Modelo.ModeloId;
            modeloId = 3;
            //instrumentoId = IngresoInstrumento.Instrumento.InstrumentoId;
            instrumentoId = 2;
            //clienteId = IngresoInstrumento.Ingreso.EmpresaId;
            clienteId = "Id de la empresa";

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
        private decimal ObtenerCotizacionActualSegunMoneda(int numeroMoneda, MonedaCotizacionDto monedaCotizacionDto)
        {
            decimal precio = 0;
            switch (numeroMoneda)
            {
                case 1:
                    precio = 1;
                    break;
                case 2:
                    precio = monedaCotizacionDto.CotizacionMonedaDos;
                    break;
                case 3:
                    precio = monedaCotizacionDto.CotizacionMonedaTres;
                    break;
                case 4:
                    precio = monedaCotizacionDto.CotizacionMonedaCuatro;
                    break;
                case 5:
                    precio = monedaCotizacionDto.CotizacionMonedaCinco;
                    break;
                case 6:
                    precio = monedaCotizacionDto.CotizacionMonedaSeis;
                    break;
            }

            return Convert.ToDecimal(precio);
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
            var frmMaestroProductos = new frmProductos(serviceProvider.GetService<ProductoService>(), serviceProvider.GetService<MonedaService>());

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

        private MonedaCotizacionDto CargarMonedaCotizacionActual()
        {
            var resultado = _monedaService.ObtenerMonedaCotizacionActual();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            return resultado.Data;
        }

        private void AgregarProductosALista(List<ProductoDto> productos)
        {
            var monedaActual = ObtenerCotizacionActualSegunMoneda(monedaSeleccionada.Numero, MonedaCotizacionActual);

            productos.ForEach(producto =>
            {

                producto.Precio = producto.ImportePrecio1 / monedaActual;

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
            ProductosEnPresupuesto.AddRange(ObtenerProductosIngresoId());
            gcProductosPresupuesto.DataSource = ProductosEnPresupuesto;
            gcProductosPresupuesto.RefreshDataSource();

            SetearTotales();
            SetearSummary();
        }

        private void RecalcularPrecioSegunMonedaSeleccionada()
        {
            var monedaActual = ObtenerCotizacionActualSegunMoneda(monedaSeleccionada.Numero, MonedaCotizacionActual);
    
            ProductosEnPresupuesto.ForEach(producto =>
            {

                producto.Precio = producto.ImportePrecio1 / monedaActual;

                if (!EsValidaLaCantidad(producto.Cantidad))
                {
                    Notificaciones.MensajeAdvertencia("La cantidad no puede ser menor o igual que cero.");
                    return;
                }

                producto.SubTotal = CalculaSubTotal(producto.Cantidad, producto.Precio);
                producto.Impuesto = CalcularImpuesto(producto.SubTotal);
                producto.Total = CalcularTotal(producto.SubTotal, producto.Impuesto);

            });

            gcProductosPresupuesto.DataSource = null;
            gcProductosPresupuesto.DataSource = ProductosEnPresupuesto;
            gcProductosPresupuesto.RefreshDataSource();
            SetearTotales();
            SetearSummary();
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
            //frmHistorial.ModeloId = IngresoInstrumento.Instrumento.Clasificacion.ModeloId;
            frmHistorial.ModeloId = 1;
            //frmHistorial.InstrumentoId = IngresoInstrumento.Instrumento.InstrumentoId;
            frmHistorial.InstrumentoId = 1;
            //frmHistorial.ClienteId = IngresoInstrumento.Ingreso.EmpresaId;
            frmHistorial.ClienteId = "Empresa";
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

        private void lookupMonedas_EditValueChanging(object sender, ChangingEventArgs e)
        {
          
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
