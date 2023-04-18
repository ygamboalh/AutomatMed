using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Productos.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Productos
{
    public partial class frmProductos : DevExpress.XtraEditors.XtraForm
    {
        private readonly ProductoService _productoService;
        private readonly MonedaService _monedaService;
        List<ArbolCarpetaDto> arbolCarpetas = new List<ArbolCarpetaDto>();
        List<ProductoListaDto> productos = new List<ProductoListaDto>();
        List<ProductoListaDto> productosSeleccionados = new List<ProductoListaDto>();

        public List<ProductoDto> ProductosEnPresupuesto { get; set; }

        public delegate void AgregarListaProductos(List<ProductoDto> productos);
        public event AgregarListaProductos OnListaProductosAgregados;

        public delegate void ArbolCarpetasCreado(TreeView treeView);
        public event ArbolCarpetasCreado OnArbolCarpetasCreado;

        public MonedaCotizacionDto MonedaCotizacionActual { get; set; }

        public frmProductos(ProductoService productoService, MonedaService monedaService)
        {
            InitializeComponent();
            _productoService = productoService;
            _monedaService = monedaService;
            chkSeleccionar.EditValueChanging += chkSeleccionarCheckedChanging;
            gvProductos.CellValueChanged += gvProductosCellValueChanged;
            
            EstablecerColorBotonGuardar();
            EstablecerNombreYTitulo();
            CargarProductos();
            CargarMonedaCotizacionActual();        
        }

        private void gvProductosCellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var filaSeleccionada = gvProductos.GetFocusedRow() as ProductoListaDto;
            if (filaSeleccionada == null) return;

            if (filaSeleccionada.Moneda.Numero == 1)
            {
                filaSeleccionada.ImportePrecio1 = filaSeleccionada.Precio;
                filaSeleccionada.ImporteUnitario1 = filaSeleccionada.Precio;
            }
            else
            {
                var cotizacionSegunMoneda = ObtenerCotizacionActualSegunMoneda(filaSeleccionada.Moneda.Numero, MonedaCotizacionActual);
                filaSeleccionada.ImportePrecio1 = cotizacionSegunMoneda * filaSeleccionada.Precio;
                filaSeleccionada.ImporteUnitario1 = cotizacionSegunMoneda * filaSeleccionada.Precio;
            }

            filaSeleccionada.Impuesto = 21;
            filaSeleccionada.ImportePrecio2 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaDos;
            filaSeleccionada.ImportePrecio3 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaTres;
            filaSeleccionada.ImportePrecio4 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaCuatro;
            filaSeleccionada.ImportePrecio5 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaCinco;
            filaSeleccionada.ImportePrecio6 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaSeis;

            filaSeleccionada.ImporteUnitario1 = filaSeleccionada.ImportePrecio1;
            filaSeleccionada.ImporteUnitario2 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaDos;
            filaSeleccionada.ImporteUnitario3 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaTres;
            filaSeleccionada.ImporteUnitario4 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaCuatro;
            filaSeleccionada.ImporteUnitario5 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaCinco;
            filaSeleccionada.ImporteUnitario6 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaSeis;
        }

        private void CargarMonedaCotizacionActual()
        {
            var resultado = _monedaService.ObtenerMonedaCotizacionActual();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            MonedaCotizacionActual = resultado.Data;           
        }

        private decimal ObtenerCotizacionActualSegunMoneda(int numeroMoneda, MonedaCotizacionDto monedaCotizacionDto)
        {
            decimal precio = 0;
            switch (numeroMoneda)
            {
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

        private void chkSeleccionarCheckedChanging(object sender, ChangingEventArgs e)
        {
            var filaSeleccionada = gvProductos.GetFocusedRow() as ProductoListaDto;
            if (filaSeleccionada == null) return;


            filaSeleccionada.Seleccionar = Convert.ToBoolean(e.NewValue);
            if (filaSeleccionada.Seleccionar)
            {
                if (ExisteElProductoEnPresupuesto(filaSeleccionada.RecID))
                {
                    e.NewValue = false;
                    e.Cancel = true;

                    filaSeleccionada.Seleccionar = false;
                    Notificaciones.MensajeAdvertencia("Este producto ya se agregó al presupuesto");
                    return;
                }

                if (filaSeleccionada.Moneda.Numero == 1)
                {
                    filaSeleccionada.ImportePrecio1 = filaSeleccionada.Precio;
                    filaSeleccionada.ImporteUnitario1 = filaSeleccionada.Precio;
                }
                else
                {
                    var cotizacionSegunMoneda = ObtenerCotizacionActualSegunMoneda(filaSeleccionada.Moneda.Numero, MonedaCotizacionActual);
                    filaSeleccionada.ImportePrecio1 = cotizacionSegunMoneda * filaSeleccionada.Precio;
                    filaSeleccionada.ImporteUnitario1 = cotizacionSegunMoneda * filaSeleccionada.Precio;
                }

                filaSeleccionada.Impuesto = 21;
                filaSeleccionada.ImportePrecio2 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaDos;
                filaSeleccionada.ImportePrecio3 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaTres;
                filaSeleccionada.ImportePrecio4 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaCuatro;
                filaSeleccionada.ImportePrecio5 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaCinco;
                filaSeleccionada.ImportePrecio6 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaSeis;

                filaSeleccionada.ImporteUnitario1 = filaSeleccionada.ImportePrecio1;
                filaSeleccionada.ImporteUnitario2 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaDos;
                filaSeleccionada.ImporteUnitario3 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaTres;
                filaSeleccionada.ImporteUnitario4 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaCuatro;
                filaSeleccionada.ImporteUnitario5 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaCinco;
                filaSeleccionada.ImporteUnitario6 = filaSeleccionada.ImportePrecio1 / MonedaCotizacionActual.CotizacionMonedaSeis;

                productosSeleccionados.Add(filaSeleccionada);

            }
            else productosSeleccionados = productosSeleccionados.Where(x => x.Codigo != filaSeleccionada.Codigo).ToList();

            CargarTotoales();
        }

        private void EstablecerColorBotonGuardar()
        {
            btnAgregarProductos.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnAgregarProductos.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarProductos.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void CargarProductos()
        {
            var resultado = _productoService.ObtenerProductos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            if (!resultado.Data.Any()) return;
            
            resultado.Data.ForEach(producto =>
            {
                productos.Add(new ProductoListaDto
                {
                    Codigo = producto.Codigo,
                    CodUnidad = producto.CodUnidad,
                    Descripcion = producto.Descripcion,
                    Estado = producto.Estado,
                    Fabricante = producto.Fabricante,
                    IdCarpeta = producto.IdCarpeta,
                    Imagen = producto.Imagen,
                    Nombre = producto.Nombre,
                    Precio = producto.Precio,
                    RecID = producto.RecID,
                    Moneda = producto.Moneda,
                    SubFamilia = producto.SubFamilia,
                    TipoProducto = producto.TipoProducto,
                    Seleccionar = false,
                    Cantidad = 1
                });
            });

            CargarTotoales();
        }

        private void CargarTotoales()
        {
            lblTotal.Visible = true;
            lblTotalSeleccionados.Visible = true;
            lblTotal.Text = $"Total registros: {gvProductos.RowCount}";
            lblTotalSeleccionados.Text = $"Total seleccionados: {productosSeleccionados.Count}";
        }

        public void CargarArbolCarpetas()
        {
            var resultado = _productoService.ObtenerArbolCarpetas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            arbolCarpetas = resultado.Data;

            var arboles = arbolCarpetas.Where(x => x.Nivel == 0).ToList();
            arboles.ForEach(arbol =>
            {
                TreeNode rootNode = new TreeNode();
                rootNode.Text = arbol.Nombre;
                rootNode.Name = arbol.RecId;
                treeView1.Nodes.Add(rootNode);
                var niveles = ObtenerNiveles(arbol, rootNode);
                if (niveles.Count == 0) return;
            });

            arbolCarpetas = resultado.Data;

            OnArbolCarpetasCreado?.Invoke(treeView1);
        }

        public List<ArbolCarpetaDto> ObtenerNiveles(ArbolCarpetaDto arbolCarpetaDto, TreeNode rootNodePadre)
        {
            var arboles = arbolCarpetas.Where(x => x.IdPadre == arbolCarpetaDto.RecId).ToList();
            arboles.ForEach(arbol =>
            {
                TreeNode rootNode = new TreeNode();
                rootNode.Text = arbol.Nombre;
                rootNode.Name = arbol.RecId;
                rootNodePadre.Nodes.Add(rootNode);

                var niveles = ObtenerNiveles(arbol, rootNode);
                if (niveles.Count == 0) return;
            });

            return arboles;
        }

        private bool ExisteElProductoEnPresupuesto(string productoId)
        {
            var existe = ProductosEnPresupuesto.Any(x => x.RecID == productoId);
            return existe;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = System.Windows.Forms.DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Productos";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            gcProductos.DataSource = productos.Where(x => x.IdCarpeta == e.Node.Name).ToList();
            CargarTotoales();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (productosSeleccionados.Count == 0)
            {
                Notificaciones.MensajeAdvertencia("Es necesario que seleccione al menos un producto");
                return;
            }

            List<ProductoDto> productos = new List<ProductoDto>();

            productosSeleccionados.ForEach(x =>
            {
                productos.Add(x);
            });

            OnListaProductosAgregados?.Invoke(productos);
            this.Close();
        }

        private void gcProductos_DoubleClick(object sender, EventArgs e)
        {
            var filaSeleccionada = gvProductos.GetFocusedRow() as ProductoListaDto;
            if (filaSeleccionada == null) return;

            chkSeleccionarCheckedChanging(sender, new ChangingEventArgs(filaSeleccionada.Seleccionar, !filaSeleccionada.Seleccionar));
        }
    }
}