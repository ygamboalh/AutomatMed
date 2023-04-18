﻿using AutoMapper;
using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Infraestructura;
using AutomatMediciones.Libs.Dtos;

using Microsoft.EntityFrameworkCore;
using Nagaira.Core.Extentions.Exceptions;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatMediciones.Dominio.Caracteristicas.Servicios
{
    public class ClasificacionInstrumentoService
    {
        private readonly AutomatMedicionesDbContext _tacticaDbContext;
        private readonly IMapper _mapper;

        public ClasificacionInstrumentoService(AutomatMedicionesDbContext tacticaDbContext, IMapper mapper)
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
                return Response<List<ClasificacionInstrumentoDto>>.Excepcion(MessageException.LanzarExcepcion(exc), null);
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
                    return Response<bool>.Excepcion("La clasificación que intenta registrar ya existe, por favor verifique la información ingresada e intente nuevamente.", false);
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
                return Response<bool>.Excepcion(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> ActualizarClasificacion(ClasificacionInstrumentoDto clasificacionInstrumentoDto)
        {
            try
            {
                var clasificacionBd = _tacticaDbContext.ClasificacionesInstrumentos.FirstOrDefault(x => x.ClasificacionId == clasificacionInstrumentoDto.ClasificacionId);

                if (clasificacionBd == null)
                {
                    return Response<bool>.Excepcion("La clasificación no fue encontrado en almacén de datos", false);
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
                return Response<bool>.Excepcion(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> DesactivarClasificacion(ClasificacionInstrumentoDto clasificacionInstrumentoDto)
        {
            try
            {
                var clasificacionBd = _tacticaDbContext.ClasificacionesInstrumentos.FirstOrDefault(x => x.ClasificacionId == clasificacionInstrumentoDto.ClasificacionId);

                if (clasificacionBd == null)
                {
                    return Response<bool>.Excepcion("La clasificación no fue encontrado en almacén de datos", false);
                }

                clasificacionBd.Activo = false;

                _tacticaDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Excepcion(MessageException.LanzarExcepcion(exc), false);
            }
        }
    }

}
