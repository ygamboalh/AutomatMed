using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using TacticaReparaciones.Libs.Dtos;
using TacticaReparaciones.Servicios.Infraestructura;

namespace TacticaReparaciones.Servicios.Caracteristicas.Servicios
{
    public class TipoDeInstrumentoService
    {
        private readonly TacticaReparacionesDbContext _tacticaDbContext;
        private readonly MarcaService _marcaService;

        public TipoDeInstrumentoService(TacticaReparacionesDbContext tacticaReparacionesDbContext, MarcaService marcaService)
        {
            _tacticaDbContext = tacticaReparacionesDbContext;         
            _marcaService = marcaService;
        }

        public Response<List<TipoInstrumentoDto>> ObtenerTiposDeInstrumento()
        {
            try
            {
                var resultMarcas = _marcaService.ObtenerMarcas();
                if (resultMarcas.Type != TypeResponse.Ok) return Response<List<TipoInstrumentoDto>>.Error(resultMarcas.Message, null);

                var marcas = resultMarcas.Data;

                var tiposDeInstrumentos = _tacticaDbContext.TiposDeInstrumentos.ToList();

                var query = tiposDeInstrumentos.AsQueryable().Select(x => new TipoInstrumentoDto
                {
                    TipoInstrumentoId = x.TipoInstrumentoId,
                    Descripcion = x.Descripcion,
                    Marcas = marcas,
                }).ToList();


                return Response<List<TipoInstrumentoDto>>.Ok("Ok", query);
            }
            catch (Exception exc)
            {
                return Response<List<TipoInstrumentoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
