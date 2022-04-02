using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public class ClasificacionInstrumentoService
    {
        private readonly TacticaReparacionesDbContext _tacticaDbContext;
        private readonly IMapper _mapper;

        public ClasificacionInstrumentoService(TacticaReparacionesDbContext tacticaDbContext, IMapper mapper)
        {
            _tacticaDbContext = tacticaDbContext;
            _mapper = mapper;
        }

        public Response<List<ClasificacionInstrumentoDto>> ObtenerClasificacionesActivas()
        {
            try
            {
                var clasificaciones = _tacticaDbContext.ClasificacionesInstrumentos.AsQueryable().Include(x => x.TipoInstrumento)
                                                                                                 .Include(x => x.Marca)
                                                                                                 .Include(x => x.Modelo)
                                                                                                 .Where(x => x.Activo).ToList();

                return Response<List<ClasificacionInstrumentoDto>>.Ok("Ok", _mapper.Map<List<ClasificacionInstrumentoDto>>(clasificaciones));
            }
            catch (Exception exc)
            {
                return Response<List<ClasificacionInstrumentoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<bool> RegistrarClasificacion(ClasificacionInstrumentoDto clasificacionDto)
        {
            try
            {

                var existeEstaClasificacion = _tacticaDbContext.ClasificacionesInstrumentos.Any(x => x.TipoInstrumentoId.Equals(clasificacionDto.TipoInstrumentoId) &&
                                                                                                     x.MarcaId.Equals(clasificacionDto.MarcaId) &&
                                                                                                     x.ModeloId.Equals(clasificacionDto.ModeloId) && 
                                                                                                     x.Activo);
                if (existeEstaClasificacion)
                {
                    return Response<bool>.Error("La clasificación que intenta registrar ya existe, por favor verifique la información ingresada e intente nuevamente.", false); 
                }

                ClasificacionInstrumento clasificacionInstrumento = new ClasificacionInstrumento
                {
                    TipoInstrumentoId = clasificacionDto.TipoInstrumentoId,
                    MarcaId = clasificacionDto.MarcaId,
                    ModeloId = clasificacionDto.ModeloId,
                    PeriodoDeCalibracion = clasificacionDto.PeriodoDeCalibracion,
                    Activo = true
                };

                _tacticaDbContext.ClasificacionesInstrumentos.Add(clasificacionInstrumento);
                _tacticaDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> ActualizarClasificacion(ClasificacionInstrumentoDto clasificacionInstrumentoDto)
        {
            try
            {
                var clasificacionBd = _tacticaDbContext.ClasificacionesInstrumentos.FirstOrDefault(x => x.MarcaId == clasificacionInstrumentoDto.ClasificacionId);

                if (clasificacionBd == null)
                {
                    return Response<bool>.Error("La clasificación no fue encontrado en almacén de datos", false);
                }

                clasificacionBd.TipoInstrumentoId = clasificacionInstrumentoDto.TipoInstrumentoId;
                clasificacionBd.MarcaId = clasificacionInstrumentoDto.MarcaId;
                clasificacionBd.ModeloId = clasificacionInstrumentoDto.ModeloId;
                clasificacionBd.PeriodoDeCalibracion = clasificacionInstrumentoDto.PeriodoDeCalibracion;

                _tacticaDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> DesactivarClasificacion(ClasificacionInstrumentoDto clasificacionInstrumentoDto)
        {
            try
            {
                var clasificacionBd = _tacticaDbContext.ClasificacionesInstrumentos.FirstOrDefault(x => x.MarcaId == clasificacionInstrumentoDto.ClasificacionId);

                if (clasificacionBd == null)
                {
                    return Response<bool>.Error("La clasificación no fue encontrado en almacén de datos", false);
                }

                clasificacionBd.Activo = false;

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
