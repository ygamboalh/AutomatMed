using AutomatMediciones.Dominio.Infraestructura;
using AutomatMediciones.Libs.Dtos;
using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMediciones.Dominio.Caracteristicas.Servicios
{
    public class UnidadMedidaService
    {
        private readonly AutomatMedicionesDbContext _automatMedicionesDbContext;

        public UnidadMedidaService(AutomatMedicionesDbContext automatMedicionesDbContext)
        {
            _automatMedicionesDbContext = automatMedicionesDbContext;
        }

        public Response<List<UnidadMedidaDto>> ObtenerUnidadesDeMedida()
        {
            try
            {
                var estados = _automatMedicionesDbContext.UnidadesDeMedida.Select(x => new UnidadMedidaDto
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Abreviatura = x.Abreviatura,
                    Activo = x.Activo
                }).ToList();

                return Response<List<UnidadMedidaDto>>.Ok("Ok", estados);
            }
            catch (Exception exc)
            {
                return Response<List<UnidadMedidaDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
