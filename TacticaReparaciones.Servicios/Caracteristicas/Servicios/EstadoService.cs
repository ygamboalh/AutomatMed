using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using TacticaReparaciones.Servicios.Caracteristicas.Dtos;
using TacticaReparaciones.Servicios.Infraestructura;

namespace TacticaReparaciones.Servicios.Caracteristicas.Servicios
{
    public class EstadoService
    {
        private readonly TacticaReparacionesDbContext _tacticaReparacionesDbContext;

        public EstadoService(TacticaReparacionesDbContext tacticaReparacionesDbContext)
        {
            _tacticaReparacionesDbContext = tacticaReparacionesDbContext;
        }

        public Response<List<EstadoDto>> ObtenerEstados()
        {
            try
            {
                var estados = _tacticaReparacionesDbContext.Estados.Select(x => new EstadoDto
                {
                    EstadoId = x.EstadoId,
                    Descripcion = x.Descripcion
                }).ToList();

                return Response<List<EstadoDto>>.Ok("Ok", estados);
            }
            catch (Exception exc)
            {
                return Response<List<EstadoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
