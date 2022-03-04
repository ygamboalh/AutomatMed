using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using TacticaReparaciones.Servicios.Caracteristicas.Dtos;
using TacticaReparaciones.Servicios.Infraestructura;

namespace TacticaReparaciones.Servicios.Caracteristicas.Servicios
{
    public class EmpresaService
    {
        private readonly TacticaReparacionesDbContext _tacticaDbContext;

        public EmpresaService(TacticaReparacionesDbContext tacticaDbContext)
        {
            _tacticaDbContext = tacticaDbContext;
        }

        public Response<List<EmpresaDto>> ObtenerEmpresas()
        {
            try
            {
                var empresas = _tacticaDbContext.Empresas.ToList();

                var query = empresas.Select(x => new EmpresaDto
                {
                    EmpresaId = x.EmpresaId,
                    NombreEmpresa = x.NombreEmpresa
                }).ToList();


                return Response<List<EmpresaDto>>.Ok("Ok", query);
            }
            catch (Exception exc)
            {
                return Response<List<EmpresaDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
