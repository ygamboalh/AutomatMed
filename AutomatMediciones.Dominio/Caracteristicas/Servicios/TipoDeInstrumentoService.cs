﻿using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Infraestructura;
using AutomatMediciones.Libs.Dtos;
using Nagaira.Core.Extentions.Exceptions;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatMediciones.Dominio.Caracteristicas.Servicios
{
    public class TipoDeInstrumentoService
    {
        private readonly AutomatMedicionesDbContext _tacticaDbContext;

        public TipoDeInstrumentoService(AutomatMedicionesDbContext AutomatMedicionesDbContext)
        {
            _tacticaDbContext = AutomatMedicionesDbContext;
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
                }).OrderBy(x => x.Descripcion).ToList();

                return Response<List<TipoInstrumentoDto>>.Ok("Ok", query);
            }
            catch (Exception exc)
            {
                return Response<List<TipoInstrumentoDto>>.Excepcion(MessageException.LanzarExcepcion(exc), null);
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
                return Response<bool>.Excepcion(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> ActualizarTipoDeInstrumento(TipoInstrumentoDto tipoInstrumentoDto)
        {
            try
            {
                var tipoInstrumentoBd = _tacticaDbContext.TiposDeInstrumentos.FirstOrDefault(x => x.TipoInstrumentoId == tipoInstrumentoDto.TipoInstrumentoId);

                if (tipoInstrumentoBd == null)
                {
                    return Response<bool>.Excepcion("El tipo de instrumento no fue encontrado en almacén de datos", false);
                }


                tipoInstrumentoBd.Descripcion = tipoInstrumentoDto.Descripcion;
                tipoInstrumentoBd.Metodologia = tipoInstrumentoDto.Metodologia;
                tipoInstrumentoBd.Resumen = tipoInstrumentoDto.Resumen;

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
