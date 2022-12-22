using AutoMapper;
using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Infraestructura;
using AutomatMediciones.Libs.Dtos;
using Microsoft.EntityFrameworkCore;
using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatMediciones.Dominio.Caracteristicas.Servicios
{
    public class PresupuestoService
    {
        private readonly TacticaDbContext _tacticaDbContext;
        private readonly AutomatMedicionesDbContext _automatMedicionesDbContext;
        private readonly IMapper _imapper;
        private readonly MonedaService _monedaService;

        public PresupuestoService(TacticaDbContext tacticaDbContext, AutomatMedicionesDbContext automatMedicionesDbContext, IMapper imapper, MonedaService monedaService)
        {
            _tacticaDbContext = tacticaDbContext;
            _automatMedicionesDbContext = automatMedicionesDbContext;
            _imapper = imapper;
            _monedaService = monedaService;
        }

        public Response<List<PresupuestoDto>> ObtenerPresupuestos()
        {
            try
            {
                var presupuestos = _tacticaDbContext.Presupuestos.AsQueryable().ToList();
                return Response<List<PresupuestoDto>>.Ok("Ok", _imapper.Map<List<PresupuestoDto>>(presupuestos));

            }
            catch (Exception exc)
            {
                return Response<List<PresupuestoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<PresupuestoDto>> ObtenerPresupuestosPorInstrumentoClienteYmodelo(int instrumentoId, string clienteId, int modeloId)
        {
            try
            {
                char pad = 'a';
                var productosIngresos = _automatMedicionesDbContext.ProductosIngresos.AsQueryable()
                                                                                     .Where(x => x.InstrumentoId == instrumentoId &&
                                                                                                 x.ModeloId == modeloId &&
                                                                                                 x.ClienteId == clienteId)
                                                                                     .Select(x => x.PresupuestoControlId).ToList();

                if (!productosIngresos.Any()) return Response<List<PresupuestoDto>>.Ok("Ok",new List<PresupuestoDto>());


                var presupuestosIds = _automatMedicionesDbContext.PresupuestosControles.Where(x => productosIngresos.Contains(x.Id))
                                                                                       .Select(x => x.Id.ToString().PadLeft(12, pad)).ToList();

                var presupuestos = _tacticaDbContext.Presupuestos.AsQueryable().Include(x => x.PresupuestoItems).Include(x => x.Moneda)
                                                                 .Where(x => presupuestosIds.Contains(x.RecID)).ToList();

            
                return Response<List<PresupuestoDto>>.Ok("Ok", _imapper.Map<List<PresupuestoDto>>(presupuestos));

            }
            catch (Exception exc)
            {
                return Response<List<PresupuestoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        private decimal ObtenerConfiguracionMonedaExtranjeraActual(int numeroMoneda, MonedaCotizacionDto monedaCotizacionDto)
        {
            decimal monedaCotizacionActual = 0;
            switch (numeroMoneda)
            {
                case 1:
                    monedaCotizacionActual = monedaCotizacionDto.CotizacionMonedaDos;
                    break;
                case 2:
                    monedaCotizacionActual = monedaCotizacionDto.CotizacionMonedaDos;
                    break;
                case 3:
                    monedaCotizacionActual = monedaCotizacionDto.CotizacionMonedaTres;
                    break;
                case 4:
                    monedaCotizacionActual = monedaCotizacionDto.CotizacionMonedaCuatro;
                    break;
                case 5:
                    monedaCotizacionActual = monedaCotizacionDto.CotizacionMonedaCinco;
                    break;
                case 6:
                    monedaCotizacionActual = monedaCotizacionDto.CotizacionMonedaSeis;
                    break;
            }

            return monedaCotizacionActual;
        }

        public Response<PresupuestoDto> RegistrarPresupuesto(PresupuestoDto presupuestoDto)
        {
            try
            {
                var configuracionMonedasResponse = _monedaService.ObtenerMonedaCotizacionActual();
                if (configuracionMonedasResponse.Type != TypeResponse.Ok) return Response<PresupuestoDto>.Error("No se pudo obtener configuración de monedas extranjeras", null);

                var configuracionMonedaCotizacionActual = configuracionMonedasResponse.Data;

                var monedaActual = ObtenerConfiguracionMonedaExtranjeraActual(presupuestoDto.NroMoneda, configuracionMonedaCotizacionActual);

                _automatMedicionesDbContext.Database.BeginTransaction();
                _tacticaDbContext.Database.BeginTransaction();

                var presupuestoControl = new PresupuestoControl
                {
                    FechaRegistro = DateTime.Now
                };

                _automatMedicionesDbContext.PresupuestosControles.Add(presupuestoControl);
                _automatMedicionesDbContext.SaveChanges();

                var ultimoPresupuesto = _tacticaDbContext.Presupuestos.OrderByDescending(x => x.ID).FirstOrDefault().ID;
                var presupuesto = _imapper.Map<Presupuesto>(presupuestoDto);

                presupuesto.PresupuestoItems = null;

                char pad = 'a';
                string recId = presupuestoControl.Id.ToString().PadLeft(12, pad);

                presupuesto.RecID = recId;
                presupuesto.ID = ultimoPresupuesto + 1;
                presupuesto.FechaCreacion = DateTime.Now;

                presupuesto.Moneda = null;

                _tacticaDbContext.Presupuestos.Add(presupuesto);

                int fila = 0;
                presupuestoDto.Productos.ForEach(producto =>
                {
                    ProductoIngreso productoIngreso = new ProductoIngreso
                    {
                        Activo = true,
                        Descripcion = producto.Descripcion,
                        FechaRegistro = DateTime.Now,
                        ProductoId = producto.RecID,
                        PresupuestoControlId = presupuestoControl.Id,
                        IngresoId = presupuestoDto.IngresoId,
                        Cantidad = producto.Cantidad,
                        InstrumentoId = presupuestoDto.InstrumentoId,
                        ModeloId = presupuestoDto.ModeloId,
                        ClienteId = presupuestoDto.ClienteId,
                        NombreCliente = presupuestoDto.NombreCliente,
                        Precio = producto.Precio,
                    };

                    var presupuestoItemControl = new PresupuestoItemControl
                    {
                        FechaRegistro = DateTime.Now
                    };

                    _automatMedicionesDbContext.PresupuestosItemsControles.Add(presupuestoItemControl);
                    _automatMedicionesDbContext.SaveChanges();

                    char padItem = 'a';
                    string recIdItem = presupuestoItemControl.Id.ToString().PadLeft(12, padItem);

                    PresupuestoItem presupuestoItem = new PresupuestoItem
                    {
                        Cantidad = producto.Cantidad,
                        RecID = recIdItem,
                        IDPresupuesto = recId,
                        Descripcion = producto.Descripcion,
                        FechaSistema = DateTime.Now,
                        NroMoneda = presupuesto.NroMoneda,
                        ImportePrecio1 = producto.ImportePrecio1,
                        ImportePrecio2 = producto.ImportePrecio2,
                        ImportePrecio3 = producto.ImportePrecio3,
                        ImportePrecio4 = producto.ImportePrecio4,
                        ImportePrecio5 = producto.ImportePrecio5,
                        ImportePrecio6 = producto.ImportePrecio6,
                        Fabricante = producto.Fabricante,
                        Notas = "",
                        NroFila = fila + 1,
                        TipoProducto = producto.TipoProducto ?? "",
                        Codigo = producto.Codigo,
                        DescripcionDescuento = "",
                        FormaPago = "",
                        IDCotizacionMoneda = configuracionMonedaCotizacionActual.RecId,
                        IDProdOb = "",
                        NroItem = (fila + 1).ToString(),
                        PrecioOculto = 0,
                        PlazoEntrega = "",
                        Unidad = "",
                        Impuesto = producto.Impuesto,
                        ImporteCosto1 = 0,
                        ImporteCosto2 = 0,
                        ImporteCosto3 = 0,
                        ImporteCosto4 = 0,
                        ImporteCosto5 = 0,
                        ImporteCosto6 = 0,
                        Descripcion2 = "",
                        Descripcion3 = "",
                        FechaInclusion = DateTime.Now,
                        FechaModificacion = DateTime.Now,
                        ObligOp = 0,
                        ImporteUnitario1 = producto.ImporteUnitario1,
                        ImporteUnitario2 = producto.ImporteUnitario2,
                        ImporteUnitario3 = producto.ImporteUnitario3,
                        ImporteUnitario4 = producto.ImporteUnitario4,
                        ImporteUnitario5 = producto.ImporteUnitario5,
                        ImporteUnitario6 = producto.ImporteUnitario6,
                        ImpuestoDescripcion = "IVA 21%",
                        DescripcionGrupo = "",
                        NombreGrupo = "",
                        Estado = 0,
                        IDUsuarioVendedor = presupuesto.IDUsuario,
                        IDProducto = producto.RecID,
                        CantidadCerrada = 0,
                        Descuento = 0,
                        TipoComision = 0,
                        Comision = 0,
                        ComisionTerceros = 0,
                        IDUsuario = presupuesto.IDUsuario,
                        TipoComisionTerceros = 0,
                        Validez = 0,
                        TipoUnidad = 0,
                        SobrePrecio = 0,
                        Probabilidad = 0,
                        NroPrecio = 1,
                        NroMonedaComisionTerceros = 1
                    };

                    presupuestoItem.Presupuesto = null;
                    _automatMedicionesDbContext.ProductosIngresos.Add(productoIngreso);
                    _tacticaDbContext.PresupuestosItems.Add(presupuestoItem);

                });

                _automatMedicionesDbContext.SaveChanges();
                _tacticaDbContext.SaveChanges();

                _tacticaDbContext.Database.CommitTransaction();
                _automatMedicionesDbContext.Database.CommitTransaction();

                return Response<PresupuestoDto>.Ok("Ok", presupuestoDto);
            }
            catch (Exception exc)
            {
                _automatMedicionesDbContext.Database.RollbackTransaction();
                _tacticaDbContext.Database.RollbackTransaction();
                string message = exc.InnerException == null ? exc.Message : exc.InnerException.Message;
                return Response<PresupuestoDto>.Error(message, null);
            }
        }

        public Response<List<PresupuestoItemDto>> ObtenerPresupuestosDetalle()
        {
            try
            {
                var presupuestos = _tacticaDbContext.PresupuestosItems.AsQueryable().ToList();
                return Response<List<PresupuestoItemDto>>.Ok("Ok", _imapper.Map<List<PresupuestoItemDto>>(presupuestos));

            }
            catch (Exception exc)
            {
                return Response<List<PresupuestoItemDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<ProductoIngresoDto>> CargarHistorialPresupuesto(DateTime? desde, DateTime? hasta, int modeloId, int instrumentoId, string clienteId)
        {
            try
            {
                char pad = 'a';
                var historialPresupuestos = _automatMedicionesDbContext.ProductosIngresos.AsQueryable();

                if (!historialPresupuestos.Any()) return Response<List<ProductoIngresoDto>>.Ok("", new List<ProductoIngresoDto>());
                
                if (desde != null && hasta != null)
                    historialPresupuestos = historialPresupuestos.Where(x => x.FechaRegistro.Date >= desde.Value.Date &&
                                                                             x.FechaRegistro.Date <= hasta.Value.Date && 
                                                                             x.ModeloId == modeloId && 
                                                                             x.InstrumentoId == instrumentoId && 
                                                                             x.ClienteId == clienteId);

                var historial = historialPresupuestos.Where(x => x.ModeloId == modeloId && 
                                                                 x.InstrumentoId == instrumentoId &&
                                                                 x.ClienteId == clienteId)
                                                     .Include(x => x.Modelo)
                                                     .Include(x => x.Instrumento).ToList();

                var productosIngresos = historial.Select(x => x.Id).ToList();

                if (!productosIngresos.Any()) return Response<List<ProductoIngresoDto>>.Ok("", new List<ProductoIngresoDto>());
                var presupuestosIds = _automatMedicionesDbContext.PresupuestosControles.Where(x => productosIngresos.Contains(x.Id))
                                                                                       .Select(x => x.Id.ToString().PadLeft(12, pad)).ToList();

                var presupuestos = _tacticaDbContext.Presupuestos.AsQueryable()
                                                                 .Include(x => x.Moneda)
                                                                 .Where(x => presupuestosIds.Contains(x.RecID)).ToList();

                return Response<List<ProductoIngresoDto>>.Ok("", _imapper.Map<List<ProductoIngresoDto>>(historial));
            }
            catch (Exception exc)
            {
                return Response<List<ProductoIngresoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
