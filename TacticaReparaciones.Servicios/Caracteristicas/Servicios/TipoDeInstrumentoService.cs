using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using TacticaReparaciones.Libs.Dtos;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;
using TacticaReparaciones.Servicios.Infraestructura;

namespace TacticaReparaciones.Servicios.Caracteristicas.Servicios
{
    public class TipoDeInstrumentoService
    {
        private readonly TacticaReparacionesDbContext _tacticaDbContext;

        public TipoDeInstrumentoService(TacticaReparacionesDbContext tacticaReparacionesDbContext)
        {
            _tacticaDbContext = tacticaReparacionesDbContext;
        }

        public Response<List<TipoInstrumentoDto>> ObtenerTiposDeInstrumento()
        {
            try
            {
                var tiposDeInstrumentos = _tacticaDbContext.TiposDeInstrumentos.ToList();

                var query = tiposDeInstrumentos.AsQueryable().Select(x => new TipoInstrumentoDto
                {
                    TipoInstrumentoId = x.TipoInstrumentoId,
                    Descripcion = x.Descripcion,
                    Metodologia = x.Metodologia,
                    Resumen = x.Resumen
                }).ToList();

                return Response<List<TipoInstrumentoDto>>.Ok("Ok", query);
            }
            catch (Exception exc)
            {
                return Response<List<TipoInstrumentoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<bool> RegistrarTipoInstrumento(TipoInstrumentoDto tipoInstrumentoDto)
        {
            try
            {
                TipoInstrumento tipoInstrumento = new TipoInstrumento
                {
                    Descripcion = tipoInstrumentoDto.Descripcion,
                    Metodologia = tipoInstrumentoDto.Metodologia,
                    Resumen = tipoInstrumentoDto.Resumen,
                };

                _tacticaDbContext.TiposDeInstrumentos.Add(tipoInstrumento);
                _tacticaDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> ActualizarTipoDeInstrumento(TipoInstrumentoDto tipoInstrumentoDto)
        {
            try
            {
                var tipoInstrumentoBd = _tacticaDbContext.TiposDeInstrumentos.FirstOrDefault(x => x.TipoInstrumentoId == tipoInstrumentoDto.TipoInstrumentoId);

                if (tipoInstrumentoBd == null)
                {
                    return Response<bool>.Error("El tipo de instrumento no fue encontrado en almacén de datos", false);
                }


                tipoInstrumentoBd.Descripcion = tipoInstrumentoDto.Descripcion;
                tipoInstrumentoBd.Metodologia = tipoInstrumentoDto.Metodologia;
                tipoInstrumentoBd.Resumen = tipoInstrumentoDto.Resumen;

                _tacticaDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }
    }
}
