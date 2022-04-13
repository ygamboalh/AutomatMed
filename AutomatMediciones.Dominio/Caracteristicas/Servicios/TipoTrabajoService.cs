using AutomatMediciones.Dominio.Infraestructura;
using AutomatMediciones.Libs.Dtos;
using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatMediciones.Dominio.Caracteristicas.Servicios
{
    public class TipoTrabajoService
    {
        private readonly AutomatMedicionesDbContext _AutomatMedicionesDbContext;

        public TipoTrabajoService(AutomatMedicionesDbContext AutomatMedicionesdbcontext)
        {
            _AutomatMedicionesDbContext = AutomatMedicionesdbcontext;
        }

        public Response<List<TipoTrabajoDto>> ObtenerTiposDeTrabajo()
        {
            try
            {
                var estados = _AutomatMedicionesDbContext.TiposDeTrabajo.Select(x => new TipoTrabajoDto
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
