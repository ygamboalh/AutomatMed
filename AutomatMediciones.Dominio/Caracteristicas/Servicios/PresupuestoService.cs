﻿using AutoMapper;
using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Infraestructura;
using AutomatMediciones.Libs.Dtos;
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

        public PresupuestoService(TacticaDbContext tacticaDbContext, AutomatMedicionesDbContext automatMedicionesDbContext, IMapper imapper)
        {
            _tacticaDbContext = tacticaDbContext;
            _automatMedicionesDbContext = automatMedicionesDbContext;
            _imapper = imapper;
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

        public Response<PresupuestoDto> RegistrarPresupuesto(PresupuestoDto presupuestoDto)
        {
            try
            {
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

                char pad = 'a';
                string recId = presupuestoControl.Id.ToString().PadLeft(12, pad);

                presupuesto.RecID = recId;
                presupuesto.ID = ultimoPresupuesto + 1;
                presupuesto.FechaCreacion = DateTime.Now;

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
                        Cantidad = producto.Cantidad
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
                        ImportePrecio1 = producto.Precio,
                        Fabricante = producto.Fabricante,
                        Notas = "",
                        NroFila = fila + 1,
                        TipoProducto = producto.TipoProducto ?? "",
                        Codigo = producto.Codigo,
                        DescripcionDescuento = "",
                        FormaPago = "",
                        IDCotizacionMoneda = "",
                        IDProdOb = "",
                        NroItem = "",
                        PrecioOculto = 0,
                        PlazoEntrega = "",
                        Unidad = "",
                        Impuesto = producto.Impuesto
                        
                    };

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
    }
}
