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
    public class PeriodoCalibracionService
    {
        private readonly TacticaReparacionesDbContext _tacticaReparacionesDbContext;

        public PeriodoCalibracionService(TacticaReparacionesDbContext tacticaReparacionesDbContext)
        {
            _tacticaReparacionesDbContext = tacticaReparacionesDbContext;
        }

        public Response<List<PeriodoCalibracionDto>> ObtenerPeriodosDeCalibracion()
        {
            try
            {
                var periodosDeCalibracion = _tacticaReparacionesDbContext.PeriodosDeCalibracion.Select(x => new PeriodoCalibracionDto
                {
                    Descripcion = x.Descripcion,
                    PeriodoCalibracionId = x.PeriodoCalibracionId,
                    TipoInstrumentoId = x.TipoInstrumentoId
                }).ToList();

                return Response<List<PeriodoCalibracionDto>>.Ok("Ok", periodosDeCalibracion);
            }
            catch (Exception exc)
            {
                return Response<List<PeriodoCalibracionDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
