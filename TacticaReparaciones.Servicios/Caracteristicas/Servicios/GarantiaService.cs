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
    public class GarantiaService
    {
        private readonly TacticaReparacionesDbContext _tacticaReparacionesDbContext;

        public GarantiaService(TacticaReparacionesDbContext tacticaReparacionesDbContext)
        {
            _tacticaReparacionesDbContext = tacticaReparacionesDbContext;
        }

        public Response<List<GarantiaDto>> ObtenerGarantias()
        {
            try
            {
                var garantias = _tacticaReparacionesDbContext.Garantias.Select(x => new GarantiaDto
                {
                    Descripcion = x.Descripcion,
                    GarantiaId = x.GarantiaId,
                    TipoInstrumentoId = x.TipoInstrumentoId
                }).ToList();

                return Response<List<GarantiaDto>>.Ok("Ok", garantias);
            }
            catch (Exception exc)
            {
                return Response<List<GarantiaDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
