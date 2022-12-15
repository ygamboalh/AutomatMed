using AutoMapper;
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
    public class MonedaService
    {
        private readonly TacticaDbContext _tacticaDbContext;
        private readonly IMapper _imapper;

        public MonedaService(TacticaDbContext tacticaDbContext, IMapper imapper)
        {
            _tacticaDbContext = tacticaDbContext;
            _imapper = imapper;
        }

        public Response<List<MonedaDto>> ObtenerMonedas()
        {
            try
            {
                var monedas = _tacticaDbContext.Monedas.AsQueryable();
                return Response<List<MonedaDto>>.Ok("Ok", _imapper.Map<List<MonedaDto>>(monedas));
            }
            catch (Exception exc)
            {
                return Response<List<MonedaDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<MonedaCotizacionDto> ObtenerMonedaCotizacionActual()
        {
            try
            {               
                var ultimoRegistroDeCotizacion = _tacticaDbContext.MonedasCotizaciones.OrderByDescending(x => x.FechaHora).FirstOrDefault();

                if (ultimoRegistroDeCotizacion == null) return Response<MonedaCotizacionDto>.Error("No se encontraron configuraciones de monedas extranjeras.", null);

                return Response<MonedaCotizacionDto>.Ok("Ok", _imapper.Map<MonedaCotizacionDto>(ultimoRegistroDeCotizacion));
            }
            catch (Exception exc)
            {
                return Response<MonedaCotizacionDto>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
