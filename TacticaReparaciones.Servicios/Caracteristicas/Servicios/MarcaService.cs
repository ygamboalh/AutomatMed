using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TacticaReparaciones.Libs.Dtos;
using TacticaReparaciones.Servicios.Infraestructura;

namespace TacticaReparaciones.Servicios.Caracteristicas.Servicios
{
    public class MarcaService
    {
        private readonly TacticaReparacionesDbContext _tacticaReparacionesDbContext;
        private readonly ModeloService _modeloService;

        public MarcaService(TacticaReparacionesDbContext tacticaReparacionesDbContext, ModeloService modeloService)
        {
            _tacticaReparacionesDbContext = tacticaReparacionesDbContext;
            _modeloService = modeloService;
        }

        public Response<List<MarcaDto>> ObtenerMarcas()
        {
            try
            {
                var resultModelo = _modeloService.ObtenerModelos();
                if (resultModelo.Type != TypeResponse.Ok) return Response<List<MarcaDto>>.Error(resultModelo.Message, null);

                var modelos = resultModelo.Data;

                var marcas = _tacticaReparacionesDbContext.Marcas.Select(x => new MarcaDto
                {
                    MarcaId = x.MarcaId,
                    Descripcion = x.Descripcion,
                    TipoInstrumentoId = x.TipoInstrumentoId,
                    Modelos = modelos
                }).ToList();

                return Response<List<MarcaDto>>.Ok("Ok", marcas);
            }
            catch (Exception exc)
            {
                return Response<List<MarcaDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
