using AutoMapper;
using AutomatMediciones.Dominio.Infraestructura;
using AutomatMediciones.Libs.Dtos;
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
                var productos = _tacticaDbContext.Productos.AsQueryable().ToList();
                return Response<List<ProductoDto>>.Ok("Ok", _imapper.Map<List<ProductoDto>>(productos));

            }
            catch (Exception exc)
            {
                return Response<List<ProductoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }


    }
}
