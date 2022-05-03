using AutoMapper;
using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Caracteristicas.Enums;
using AutomatMediciones.Dominio.Infraestructura;
using AutomatMediciones.Libs.Dtos;
using Microsoft.EntityFrameworkCore;
using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatMediciones.Dominio.Caracteristicas.Servicios
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

        public Response<List<IngresoDto>> ObtenerIngresos()
        {
            try
            {
                var ingresos = _AutomatMedicionesDbContext.Ingresos.AsQueryable()
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Marca)
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Modelo)
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.TipoInstrumento)
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Estado)
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.TipoTrabajo)
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Ingreso)
                                                                                    .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Responsable)
                                                                                   .ToList();

                ingresos = ingresos.OrderBy(y => y.IngresoId).ToList();
                return Response<List<IngresoDto>>.Ok("Ok", _mapper.Map<List<IngresoDto>>(ingresos));
            }
            catch (Exception exc)
            {
                return Response<List<IngresoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<IngresoDto> GuardarIngreso(IngresoDto ingresoDto)
        {
            try
            {
                Ingreso ingreso = new Ingreso
                {
                    EmpresaId = ingresoDto.EmpresaId,
                    NombreEmpresa = ingresoDto.NombreEmpresa,
                    NombreContacto = ingresoDto.NombreContacto,
                    ApellidoContacto = ingresoDto.ApellidoContacto,
                    ContactoId = ingresoDto.ContactoId,
                    DireccionCorreoElectronico = ingresoDto.DireccionCorreoElectronico,
                    CorreoElectronicoId = ingresoDto.CorreoElectronicoId,
                    CuerpoCorreo = ingresoDto.CuerpoCorreo,
                    Activo = true,
                    FechaRegistro = ingresoDto.FechaRegistro,
                    UsuarioId = ingresoDto.UsuarioId
                };

                if (!ingreso.EsValido(out string mensaje))
                {
                    return Response<IngresoDto>.ErrorValidation(mensaje, null);
                }

                _AutomatMedicionesDbContext.Database.BeginTransaction();
                _AutomatMedicionesDbContext.Ingresos.Add(ingreso);
                _AutomatMedicionesDbContext.SaveChanges();

                int correlativoIntrumento = 1;
                foreach (var instrumento in ingresoDto.IngresosInstrumentos)
                {
                    var ingresoInstrumento = new IngresoInstrumento
                    {
                        NumeroServicioTecnico = $"{ingreso.IngresoId}-{correlativoIntrumento}",
                        Comentarios = instrumento.Comentarios,
                        IngresoId = ingreso.IngresoId,
                        Activo = true,
                        InstrumentoId = instrumento.InstrumentoId,
                        TipoTrabajoId = instrumento.TipoTrabajoId,
                        FechaFin = instrumento.FechaFin,
                        FechaInicio = instrumento.FechaInicio,
                        Prioridad = instrumento.Prioridad,
                        EstadoId = (int)Estados.Ingresado,
                        FechaEntregaRequerida = instrumento.FechaEntregaRequerida
                    };

                    _AutomatMedicionesDbContext.IngresosInstrumentos.Add(ingresoInstrumento);

                    correlativoIntrumento++;
                }

                ingresoDto.IngresoId = ingreso.IngresoId;

                _AutomatMedicionesDbContext.SaveChanges();
                _AutomatMedicionesDbContext.Database.CommitTransaction();

                var ingresoRegistrado = _AutomatMedicionesDbContext.Ingresos.Include(x => x.IngresosInstrumentos)
                                                                  .Include(x => x.Responsable)
                                                                  .FirstOrDefault(x => x.IngresoId == ingreso.IngresoId);

                return Response<IngresoDto>.Ok("¡El ingreso se guardó exitosamente!", _mapper.Map<IngresoDto>(ingresoRegistrado));
            }
            catch (Exception exc)
            {
                _AutomatMedicionesDbContext.Database.RollbackTransaction();
                return Response<IngresoDto>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<bool> ActualizarDiagnostico(IngresoInstrumentoDto ingresoInstrumento)
        {
            try
            {
                var diagnostico = _AutomatMedicionesDbContext.IngresosInstrumentos.FirstOrDefault(x => x.IngresoInstrumentoId.Equals(ingresoInstrumento.IngresoInstrumentoId));

                if (diagnostico == null)
                {
                    return Response<bool>.Error("No se encontró ningún registro en almacen de datos.", true);
                }

                diagnostico.Comentarios = ingresoInstrumento.Comentarios;
                diagnostico.Diagnostico = ingresoInstrumento.Diagnostico;
                diagnostico.EstadoId = ingresoInstrumento.EstadoId;
                diagnostico.ResponsableId = ingresoInstrumento.ResponsableId;
                diagnostico.TiempoConsumido = ingresoInstrumento.TiempoConsumido;
                diagnostico.FechaInicio = ingresoInstrumento.FechaInicio;

                _AutomatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("¡El diagnóstico se guardó exitosamente!", true);
            }
            catch (Exception exc)
            {
                _AutomatMedicionesDbContext.Database.RollbackTransaction();
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> ActualizarFechaUltimoIngreso(IngresoInstrumentoDto ingresoInstrumento)
        {
            try
            {
                var diagnostico = _AutomatMedicionesDbContext.IngresosInstrumentos.FirstOrDefault(x => x.IngresoInstrumentoId.Equals(ingresoInstrumento.IngresoInstrumentoId));

                if (diagnostico == null)
                {
                    return Response<bool>.Error("No se encontró ningún registro en almacen de datos.", true);
                }

                diagnostico.FechaInicio = ingresoInstrumento.FechaInicio;
                diagnostico.TiempoConsumido = ingresoInstrumento.TiempoConsumido;


                _AutomatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("¡El diagnóstico se guardó exitosamente!", true);
            }
            catch (Exception exc)
            {
                _AutomatMedicionesDbContext.Database.RollbackTransaction();
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }
    }
}
