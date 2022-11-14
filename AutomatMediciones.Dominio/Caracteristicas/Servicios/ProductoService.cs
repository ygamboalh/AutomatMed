﻿using AutoMapper;
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
    public class ProductoService
    {
        private readonly TacticaDbContext _tacticaDbContext;
        private readonly IMapper _imapper;

        public ProductoService(TacticaDbContext tacticaDbContext, IMapper imapper)
        {
            _tacticaDbContext = tacticaDbContext;
            _imapper = imapper;
        }

        public Response<List<ProductoDto>> ObtenerProductos()
        {
            try
            {
                var productosDb = _tacticaDbContext.Productos.AsQueryable().Include(x => x.ProductoPrecios).ToList();

                var productos = _imapper.Map<List<ProductoDto>>(productosDb);

                productos.ForEach(producto =>
                {
                    var moneda = _tacticaDbContext.Monedas.FirstOrDefault(x => x.Numero == producto.MonedaId);
                    var productoPrecio = producto.ProductoPrecios.OrderBy(x => x.NroLista).FirstOrDefault(x => x.IDProducto == producto.RecID);
                    producto.Precio = productoPrecio.Precio;
                    producto.MonedaId = productoPrecio.NroMonedaPrecio;
                });

                return Response<List<ProductoDto>>.Ok("Ok", productos);

            }
            catch (Exception exc)
            {
                return Response<List<ProductoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<ProductoDto> ObtenerProductoPorId(string productoId)
        {
            try
            {
                var productoDb = _tacticaDbContext.Productos.AsQueryable().Include(x => x.ProductoPrecios).FirstOrDefault(x => x.RecID == productoId);
                return Response<ProductoDto>.Ok("Ok", _imapper.Map<ProductoDto>(productoDb));

            }
            catch (Exception exc)
            {
                return Response<ProductoDto>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<MonedaDto>> ObtenerMonedas()
        {
            try
            {
                var monedas = _tacticaDbContext.Monedas.AsQueryable();
                return Response<List<MonedaDto>>.Ok("Ok", _imapper.Map<List<MonedaDto>>(monedas));
            }
            catch (Exception exc)
            {
                return Response<List<MonedaDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<ArbolCarpetaDto>> ObtenerArbolCarpetas()
        {
            try
            {
                var productos = _tacticaDbContext.ArbolCarpetas.AsQueryable().ToList();


                return Response<List<ArbolCarpetaDto>>.Ok("Ok", _imapper.Map<List<ArbolCarpetaDto>>(productos));

            }
            catch (Exception exc)
            {
                return Response<List<ArbolCarpetaDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }


    }
}
