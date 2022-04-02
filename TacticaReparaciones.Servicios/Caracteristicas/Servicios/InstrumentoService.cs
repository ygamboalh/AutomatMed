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
    public class InstrumentoService
    {
        private readonly TacticaReparacionesDbContext _tacticaReparacionesDbContext;
        private readonly IMapper _mapper;

        public InstrumentoService(TacticaReparacionesDbContext tacticaReparacionesDbContext, IMapper mapper)
        {
            _tacticaReparacionesDbContext = tacticaReparacionesDbContext;
            _mapper = mapper;
        }

        public Response<List<InstrumentoDto>> ObtenerInstrumentos()
        {
            try
            {
                var instrumentos = _tacticaReparacionesDbContext.Instrumentos.AsQueryable()
                                                                             
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
                var instrumentos = _tacticaReparacionesDbContext.Instrumentos.AsQueryable()
                                                                           
                                                                             
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

                    
                    NumeroSerie = instrumentoDto.NumeroSerie,
                
                };

                if (!instrumento.EsValido(out string mensaje))
                {
                    return Response<bool>.ErrorValidation(mensaje, false);
                }

                _tacticaReparacionesDbContext.Instrumentos.Add(instrumento);
                _tacticaReparacionesDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }
    }
}
