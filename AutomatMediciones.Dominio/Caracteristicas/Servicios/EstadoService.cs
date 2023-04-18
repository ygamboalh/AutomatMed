using AutomatMediciones.Dominio.Infraestructura;
using AutomatMediciones.Libs.Dtos;
using Nagaira.Core.Extentions.Exceptions;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatMediciones.Dominio.Caracteristicas.Servicios
{
    public class EstadoService
    {
        private readonly AutomatMedicionesDbContext _AutomatMedicionesDbContext;

        public EstadoService(AutomatMedicionesDbContext AutomatMedicionesDbContext)
        {
            _AutomatMedicionesDbContext = AutomatMedicionesDbContext;
        }

        public Response<List<EstadoDto>> ObtenerEstados()
        {
            try
            {
                var estados = _AutomatMedicionesDbContext.Estados.Select(x => new EstadoDto
                {
                    EstadoId = x.EstadoId,
                    Descripcion = x.Descripcion
                }).ToList();

                return Response<List<EstadoDto>>.Ok("Ok", estados);
            }
            catch (Exception exc)
            {
                return Response<List<EstadoDto>>.Excepcion(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
