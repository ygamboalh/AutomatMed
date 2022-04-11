using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using AutomatMediciones.Libs.Dtos;
using AutomatMediciones.Servicios.Caracteristicas.Entidades;
using AutomatMediciones.Servicios.Caracteristicas.Enums;
using AutomatMediciones.Servicios.Infraestructura;

namespace AutomatMediciones.Servicios.Caracteristicas.Servicios
{
    public class IngresoService
    {
        private readonly AutomatMedicionesDbContext _AutomatMedicionesDbContext;
        private readonly IMapper _mapper;

        public IngresoService(AutomatMedicionesDbContext AutomatMedicionesDbContext, IMapper mapper)
        {
            _AutomatMedicionesDbContext = AutomatMedicionesDbContext;
            _mapper = mapper;
        }

        public Response<List<IngresoDto>> ObtenerIngresos(int estadoId)
        {
            try
            {
                var ingresos = _AutomatMedicionesDbContext.Ingresos.Where(x => x.EstadoId.Equals(estadoId)).ToList();

                return Response<List<IngresoDto>>.Ok("Ok", _mapper.Map<List<IngresoDto>>(ingresos));
            }
            catch (Exception exc)
            {
                return Response<List<IngresoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<IngresoDto>> ObtenerIngresos()
        {
            try
            {
                var ingresos = _AutomatMedicionesDbContext.Ingresos.AsQueryable().Include(x => x.Estado)
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Marca)
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Modelo)
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.TipoInstrumento)
                                                                                   .Where(x => x.EstadoId != (int)Estados.Cerrado).ToList();

                return Response<List<IngresoDto>>.Ok("Ok", _mapper.Map<List<IngresoDto>>(ingresos));
            }
            catch (Exception exc)
            {
                return Response<List<IngresoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<bool> GuardarIngreso(IngresoDto ingresoDto)
        {
            try
            {
                Ingreso ingreso = new Ingreso
                {
                    EmpresaId = ingresoDto.EmpresaId,
                    NombreEmpresa = ingresoDto.NombreEmpresa,
                    NombreContacto = ingresoDto.NombreContacto,
                    ContactoId = ingresoDto.ContactoId,
                    DireccionCorreoElectronico = ingresoDto.DireccionCorreoElectronico,
                    CorreoElectronicoId = ingresoDto.CorreoElectronicoId,
                    EstadoId = (int)Estados.Ingresado,
                    Prioridad = ingresoDto.Prioridad,
                    Comentarios = ingresoDto.Comentarios,
                    TipoTrabajoId = ingresoDto.TipoTrabajoId,
                    Activo = true,
                    FechaRegistro = DateTime.Now
                };

                if (!ingreso.EsValido(out string mensaje))
                {
                    return Response<bool>.ErrorValidation(mensaje, false);
                }

                _AutomatMedicionesDbContext.Database.BeginTransaction();
                _AutomatMedicionesDbContext.Ingresos.Add(ingreso);
                _AutomatMedicionesDbContext.SaveChanges();

                foreach (var instrumento in ingresoDto.IngresosInstrumentos)
                {
                    IngresoInstrumento ingresoInstrumento = new IngresoInstrumento
                    {
                        IngresoId = ingreso.IngresoId,
                        Activo = true,
                        InstrumentoId = instrumento.InstrumentoId
                    };

                    _AutomatMedicionesDbContext.IngresosInstrumentos.Add(ingresoInstrumento);

                }

                _AutomatMedicionesDbContext.SaveChanges();
                _AutomatMedicionesDbContext.Database.CommitTransaction();

                return Response<bool>.Ok("¡El ingreso se guardó exitosamente!", true);
            }
            catch (Exception exc)
            {
                _AutomatMedicionesDbContext.Database.RollbackTransaction();
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }
    }
}
