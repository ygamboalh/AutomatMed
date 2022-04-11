using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using AutomatMediciones.Libs.Dtos;
using AutomatMediciones.Servicios.Caracteristicas.Entidades;
using AutomatMediciones.Servicios.Infraestructura;

namespace AutomatMediciones.Servicios.Caracteristicas.Servicios
{
    public class InstrumentoService
    {
        private readonly AutomatMedicionesDbContext _AutomatMedicionesDbContext;
        private readonly IMapper _mapper;

        public InstrumentoService(AutomatMedicionesDbContext AutomatMedicionesDbContext, IMapper mapper)
        {
            _AutomatMedicionesDbContext = AutomatMedicionesDbContext;
            _mapper = mapper;
        }

        public Response<List<InstrumentoDto>> ObtenerInstrumentos()
        {
            try
            {
                var instrumentos = _AutomatMedicionesDbContext.Instrumentos.AsQueryable()

                                                                             .ToList();
                return Response<List<InstrumentoDto>>.Ok("Ok", _mapper.Map<List<InstrumentoDto>>(instrumentos));
            }
            catch (Exception exc)
            {
                return Response<List<InstrumentoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<InstrumentoDto>> ObtenerInstrumentos(string nombreEmpresa)
        {
            try
            {
                var instrumentos = _AutomatMedicionesDbContext.Instrumentos.AsQueryable()
                                                                             .Include(x => x.Clasificacion).ThenInclude(x => x.TipoInstrumento)
                                                                             .Include(x => x.Clasificacion).ThenInclude(x => x.Marca)
                                                                             .Include(x => x.Clasificacion).ThenInclude(x => x.Modelo)
                                                                             .Where(x => x.Activo &&
                                                                                    x.NombreEmpresa.Equals(nombreEmpresa)).AsEnumerable();


                return Response<List<InstrumentoDto>>.Ok("Ok", _mapper.Map<List<InstrumentoDto>>(instrumentos));
            }
            catch (Exception exc)
            {
                return Response<List<InstrumentoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<bool> RegistrarInstrumento(InstrumentoDto instrumentoDto)
        {
            try
            {
                Instrumento instrumento = new Instrumento
                {
                    Descripcion = instrumentoDto.Descripcion,
                    Activo = true,
                    EmpresaId = instrumentoDto.EmpresaId,
                    NombreEmpresa = instrumentoDto.NombreEmpresa,
                    FechaCompraCliente = instrumentoDto.FechaCompraCliente,
                    FechaCompraFabricante = instrumentoDto.FechaCompraFabricante,
                    FechaProximaCalibracion = instrumentoDto.FechaProximaCalibracion,
                    FechaRegistro = DateTime.Now,
                    FechaUltimaCalibracion = instrumentoDto.FechaUltimaCalibracion,
                    Garantia = instrumentoDto.Garantia,
                    ClasificacionId = instrumentoDto.ClasificacionId,
                    NumeroSerie = instrumentoDto.NumeroSerie,

                };

                if (!instrumento.EsValido(out string mensaje))
                {
                    return Response<bool>.ErrorValidation(mensaje, false);
                }

                _AutomatMedicionesDbContext.Instrumentos.Add(instrumento);
                _AutomatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }
    }
}
