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
        private readonly GarantiaService _garantiaService;
        private readonly MarcaService _marcaService;
        private readonly PeriodoCalibracionService _periodoCalibracionService;

        public TipoDeInstrumentoService(TacticaReparacionesDbContext tacticaReparacionesDbContext, GarantiaService garantiaService, 
               MarcaService marcaService, PeriodoCalibracionService periodoCalibracionService)
        {
            _tacticaDbContext = tacticaReparacionesDbContext;
            _garantiaService = garantiaService;
            _marcaService = marcaService;
            _periodoCalibracionService = periodoCalibracionService;
        }

        public Response<List<TipoInstrumentoDto>> ObtenerTiposDeInstrumento()
        {
            try
            {
                var resultMarcas = _marcaService.ObtenerMarcas();
                if (resultMarcas.Type != TypeResponse.Ok) return Response<List<TipoInstrumentoDto>>.Error(resultMarcas.Message, null);

                var marcas = resultMarcas.Data;

                var resultPeriodoCalibracion = _periodoCalibracionService.ObtenerPeriodosDeCalibracion();
                if (resultPeriodoCalibracion.Type != TypeResponse.Ok) return Response<List<TipoInstrumentoDto>>.Error(resultPeriodoCalibracion.Message, null);

                var periodosDeCalibracion = resultPeriodoCalibracion.Data;

                var resultGarantias = _garantiaService.ObtenerGarantias();
                if (resultGarantias.Type != TypeResponse.Ok) return Response<List<TipoInstrumentoDto>>.Error(resultGarantias.Message, null);

                var garantias = resultGarantias.Data;

                var tiposDeInstrumentos = _tacticaDbContext.TiposDeInstrumentos.ToList();

                var query = tiposDeInstrumentos.AsQueryable().Select(x => new TipoInstrumentoDto
                {
                    TipoInstrumentoId = x.TipoInstrumentoId,
                    Descripcion = x.Descripcion,
                    Garantias = garantias,
                    Marcas = marcas,
                    PeriodosDeCalibracion = periodosDeCalibracion
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
