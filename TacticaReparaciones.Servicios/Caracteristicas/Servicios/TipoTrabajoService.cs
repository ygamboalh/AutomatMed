using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using TacticaReparaciones.Libs.Dtos;
using TacticaReparaciones.Servicios.Infraestructura;

namespace TacticaReparaciones.Servicios.Caracteristicas.Servicios
{
    public class TipoTrabajoService
    {
        private readonly TacticaReparacionesDbContext _tacticaReparacionesDbContext;

        public TipoTrabajoService(TacticaReparacionesDbContext tacticareparacionesdbcontext)
        {
            _tacticaReparacionesDbContext = tacticareparacionesdbcontext;
        }

        public Response<List<TipoTrabajoDto>> ObtenerTiposDeTrabajo()
        {
            try
            {
                var estados = _tacticaReparacionesDbContext.TiposDeTrabajo.Select(x => new TipoTrabajoDto
                {
                    TipoTrabajoId = x.TipoTrabajoId,
                    Descripcion = x.Descripcion
                }).ToList();

                return Response<List<TipoTrabajoDto>>.Ok("Ok", estados);
            }
            catch (Exception exc)
            {
                return Response<List<TipoTrabajoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

    }
}
