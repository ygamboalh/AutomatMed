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
    public class InstrumentoService
    {
        private readonly AutomatMedicionesDbContext _automatMedicionesDbContext;
        private readonly IMapper _mapper;

        public InstrumentoService(AutomatMedicionesDbContext AutomatMedicionesDbContext, IMapper mapper)
        {
            _automatMedicionesDbContext = AutomatMedicionesDbContext;
            _mapper = mapper;
        }

        public Response<List<InstrumentoDto>> ObtenerInstrumentos()
        {
            try
            {
                var instrumentos = _automatMedicionesDbContext.Instrumentos.AsQueryable()
                                                                              .Include(x => x.Clasificacion).ThenInclude(x => x.TipoInstrumento)
                                                                             .Include(x => x.Clasificacion).ThenInclude(x => x.Marca)
                                                                             .Include(x => x.Clasificacion).ThenInclude(x => x.Modelo)
                                                                             .Include(x => x.CeldasInstrumentos)
                                                                             .Where(x => x.Activo)
                                                                             .ToList();

                var celdasInstrumentos = _automatMedicionesDbContext.CeldasInstrumentos.AsQueryable()
                                                                                       .Include(x => x.Celda).ThenInclude(x => x.TipoCelda)
                                                                                       .Where(x => x.Activo && instrumentos.Select(y => y.InstrumentoId)
                                                                                                                           .Contains(x.InstrumentoId));


                instrumentos.ForEach(x =>
                {
                    var celdas = celdasInstrumentos.Where(y => y.InstrumentoId == x.InstrumentoId).ToList();
                    x.CeldasInstrumentos = celdas;
                });

                return Response<List<InstrumentoDto>>.Ok("Ok", _mapper.Map<List<InstrumentoDto>>(instrumentos));
            }
            catch (Exception exc)
            {
                return Response<List<InstrumentoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<InstrumentoDto> ObtenerInstrumento(int instrumentoId)
        {
            try
            {
                var instrumentos = _automatMedicionesDbContext.Instrumentos.AsQueryable()
                                                                              .Include(x => x.Clasificacion).ThenInclude(x => x.TipoInstrumento)
                                                                             .Include(x => x.Clasificacion).ThenInclude(x => x.Marca)
                                                                             .Include(x => x.Clasificacion).ThenInclude(x => x.Modelo)
                                                                             .FirstOrDefault(x => x.InstrumentoId == instrumentoId);
                return Response<InstrumentoDto>.Ok("Ok", _mapper.Map<InstrumentoDto>(instrumentos));
            }
            catch (Exception exc)
            {
                return Response<InstrumentoDto>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<InstrumentoDto> ObtenerInstrumento(int marcaId, int modeloId, int tipoInstrumentoId, string serie)
        {
            try
            {
                var instrumentos = _automatMedicionesDbContext.Instrumentos.AsQueryable()
                                                                              .Include(x => x.Clasificacion).ThenInclude(x => x.TipoInstrumento)
                                                                             .Include(x => x.Clasificacion).ThenInclude(x => x.Marca)
                                                                             .Include(x => x.Clasificacion).ThenInclude(x => x.Modelo)
                                                                             .FirstOrDefault(x => x.NumeroSerie == serie &&
                                                                                                  x.Clasificacion.MarcaId == marcaId &&
                                                                                                  x.Clasificacion.ModeloId == modeloId &&
                                                                                                  x.Clasificacion.TipoInstrumentoId == tipoInstrumentoId);
                return Response<InstrumentoDto>.Ok("Ok", _mapper.Map<InstrumentoDto>(instrumentos));
            }
            catch (Exception exc)
            {
                return Response<InstrumentoDto>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<InstrumentoDto>> ObtenerInstrumentos(string nombreEmpresa)
        {
            try
            {
                var instrumentos = _automatMedicionesDbContext.Instrumentos.AsQueryable()
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

        public Response<InstrumentoDto> RegistrarInstrumento(InstrumentoDto instrumentoDto)
        {
            try
            {
                var instrumentoDb = _automatMedicionesDbContext.Instrumentos.Include(x => x.Clasificacion).ThenInclude(x => x.Marca)
                                                                                  .Include(x => x.Clasificacion).ThenInclude(x => x.Modelo)
                                                                                  .Include(x => x.Clasificacion).ThenInclude(x => x.TipoInstrumento)
                                                                                  .FirstOrDefault(x => x.Activo &&
                                                                                                        x.NumeroSerie == instrumentoDto.NumeroSerie &&
                                                                                                        x.Clasificacion.ModeloId == instrumentoDto.Clasificacion.ModeloId &&
                                                                                                        x.Clasificacion.MarcaId == instrumentoDto.Clasificacion.MarcaId &&
                                                                                                        x.Clasificacion.TipoInstrumentoId == instrumentoDto.Clasificacion.TipoInstrumentoId);

                if (instrumentoDb != null) return Response<InstrumentoDto>.ErrorValidation($"Ya existe un instrumento para la empresa {instrumentoDb.NombreEmpresa} con estas mismas características.", null);

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
                    Comentarios = instrumentoDto.Comentarios,
                    FechaUltimaCalibracion = instrumentoDto.FechaUltimaCalibracion,
                    Garantia = instrumentoDto.Garantia,
                    ClasificacionId = instrumentoDto.ClasificacionId,
                    NumeroSerie = instrumentoDto.NumeroSerie,

                };

                if (!instrumento.EsValido(out string mensaje))
                {
                    return Response<InstrumentoDto>.ErrorValidation(mensaje, null);
                }
                _automatMedicionesDbContext.Database.BeginTransaction();
                _automatMedicionesDbContext.Instrumentos.Add(instrumento);
                _automatMedicionesDbContext.SaveChanges();

                var celdasInstrumentos = instrumentoDto.CeldasInstrumentos.Where(x => x.Id == 0).ToList();
                if (celdasInstrumentos.Any())
                {
                    List<CeldaInstrumento> listaTiposDeCeldaModelosParaRegistrar = new List<CeldaInstrumento>();
                    celdasInstrumentos.ForEach(x =>
                    {
                        listaTiposDeCeldaModelosParaRegistrar.Add(new CeldaInstrumento
                        {
                            CeldaId = x.CeldaId,
                            FechaColocacion = x.FechaColocacion,
                            InstrumentoId = instrumento.InstrumentoId,
                            Activo = true
                        });
                    });

                    _automatMedicionesDbContext.CeldasInstrumentos.AddRange(listaTiposDeCeldaModelosParaRegistrar);
                    _automatMedicionesDbContext.SaveChanges();
                }

                _automatMedicionesDbContext.Database.CommitTransaction();

                var instrumentoIngresado = _automatMedicionesDbContext.Instrumentos.AsQueryable()
                                                                                   .Include(x => x.Clasificacion)
                                                                                   .FirstOrDefault(x => x.InstrumentoId == instrumento.InstrumentoId);

                return Response<InstrumentoDto>.Ok("Ok", _mapper.Map<InstrumentoDto>(instrumentoIngresado));
            }
            catch (Exception exc)
            {
                _automatMedicionesDbContext.Database.RollbackTransaction();
                return Response<InstrumentoDto>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<bool> ActualizarInstrumento(InstrumentoDto instrumentoDto)
        {
            try
            {
                var instrumentoBd = _automatMedicionesDbContext.Instrumentos.FirstOrDefault(x => x.InstrumentoId == instrumentoDto.InstrumentoId);
                if (instrumentoBd == null)
                {
                    return Response<bool>.ErrorValidation("El instrumento no fue encontrado", false);
                }

                if (instrumentoBd.Descripcion != instrumentoDto.Descripcion)
                {
                    var existeConMismaDescripcion = _automatMedicionesDbContext.Instrumentos.Any(x => x.Descripcion == instrumentoDto.Descripcion && x.EmpresaId == instrumentoDto.EmpresaId && x.Activo);
                    if (existeConMismaDescripcion) return Response<bool>.Error($"Ya existe un instrumento para la empresa {instrumentoDto.NombreEmpresa} con esta misma descripción.", false);
                }

                if (instrumentoBd.NumeroSerie != instrumentoDto.NumeroSerie)
                {
                    var existeConMismaSerie = _automatMedicionesDbContext.Instrumentos.Any(x => x.NumeroSerie == instrumentoDto.NumeroSerie && x.EmpresaId == instrumentoDto.EmpresaId && x.Activo);
                    if (existeConMismaSerie) return Response<bool>.Error($"Ya existe un instrumento para la empresa {instrumentoDto.NombreEmpresa} con esta misma serie.", false);
                }

                _automatMedicionesDbContext.Database.BeginTransaction();
                instrumentoBd.Comentarios = instrumentoDto.Comentarios;
                instrumentoBd.ClasificacionId = instrumentoDto.ClasificacionId;
                instrumentoBd.Descripcion = instrumentoDto.Descripcion;
                instrumentoBd.EmpresaId = instrumentoDto.EmpresaId;
                instrumentoBd.FechaCompraCliente = instrumentoDto.FechaCompraCliente;
                instrumentoBd.FechaCompraFabricante = instrumentoDto.FechaCompraFabricante;
                instrumentoBd.Garantia = instrumentoDto.Garantia;
                instrumentoBd.NombreEmpresa = instrumentoDto.NombreEmpresa;
                instrumentoBd.NumeroSerie = instrumentoDto.NumeroSerie;

                var celdasInstrumentos = instrumentoDto.CeldasInstrumentos.Where(x => x.Id == 0).ToList();
                if (celdasInstrumentos.Any())
                {
                    var celdasIds = celdasInstrumentos.Select(r => r.CeldaId);
                    var celdas = _automatMedicionesDbContext.Celdas.Where(x => celdasIds.Contains(x.Id)).ToList();

                    List<CeldaInstrumento> celdasInstrumentosParaRegistrar = new List<CeldaInstrumento>();
                    celdasInstrumentos.ForEach(x =>
                    {
                        celdasInstrumentosParaRegistrar.Add(new CeldaInstrumento
                        {
                            CeldaId = x.CeldaId,
                            InstrumentoId = instrumentoBd.InstrumentoId,
                            FechaColocacion = x.FechaColocacion,
                            Activo = true
                        });
                    });


                    celdas.ForEach(y => y.EstadoId = (int)CeldaEstado.Colocada);

                    _automatMedicionesDbContext.CeldasInstrumentos.AddRange(celdasInstrumentosParaRegistrar);
                }

                _automatMedicionesDbContext.SaveChanges();
                _automatMedicionesDbContext.Database.CommitTransaction();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                _automatMedicionesDbContext.Database.RollbackTransaction();
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> DesactivarInstrumentoCelda(CeldaInstrumentoDto celdaInstrumentoDto)
        {
            try
            {
                var celdaInstrumentoBd = _automatMedicionesDbContext.CeldasInstrumentos.FirstOrDefault(x => x.Id == celdaInstrumentoDto.Id);

                if (celdaInstrumentoBd == null)
                {
                    return Response<bool>.Error("La celda vinculada a este instrumento no fue encontrado en almacén de datos", false);
                }

                celdaInstrumentoBd.Activo = false;
                celdaInstrumentoBd.FechaExtraccion = celdaInstrumentoDto.FechaExtraccion;

                _automatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> DesactivarVariableInstrumento(int variableInstrumentoId)
        {
            try
            {
                var variableInstrumentoBd = _automatMedicionesDbContext.VariablesInstrumentos.FirstOrDefault(x => x.VariableInstrumentoId == variableInstrumentoId);

                if (variableInstrumentoBd == null)
                {
                    return Response<bool>.Error("La variable vinculada a este instrumento no fue encontrado en almacén de datos", false);
                }

                variableInstrumentoBd.Activo = false;


                _automatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> DesactivarInstrumento(InstrumentoDto instrumentoDto)
        {
            try
            {
                var instrumentoBd = _automatMedicionesDbContext.Instrumentos.FirstOrDefault(x => x.InstrumentoId == instrumentoDto.InstrumentoId);
                if (instrumentoBd == null)
                {
                    return Response<bool>.ErrorValidation("El instrumento no fue encontrado", false);
                }

                instrumentoBd.Activo = false;


                _automatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<VariableInstrumentoDto> GuardarVinculacionVariableDeMedicion(VariableInstrumentoDto variableInstrumentoDto)
        {
            try
            {
                var existeVariableVinculada = _automatMedicionesDbContext.VariablesInstrumentos.Any(x => x.Activo &&
                                                                                                         x.InstrumentoId == variableInstrumentoDto.InstrumentoId &&
                                                                                                         x.VariableMedicionId == variableInstrumentoDto.VariableMedicionId);

                if (existeVariableVinculada) return Response<VariableInstrumentoDto>.ErrorValidation("Esta variable de medición ya está vinculada a este instrumento.", null);




                VariableInstrumento variableInstrumento = new VariableInstrumento
                {
                    VariableMedicionId = variableInstrumentoDto.VariableMedicionId,
                    TieneAlarma = variableInstrumentoDto.TieneAlarma,
                    AlarmaAlta = variableInstrumentoDto.AlarmaAlta,
                    AlarmaBaja = variableInstrumentoDto.AlarmaBaja,
                    AlarmaStel = variableInstrumentoDto.AlarmaStel,
                    AlarmaTwa = variableInstrumentoDto.AlarmaTwa,
                    InstrumentoId = variableInstrumentoDto.InstrumentoId,
                    Activo = true
                };

                if (!variableInstrumento.EsValido(out string mensaje))
                {
                    return Response<VariableInstrumentoDto>.ErrorValidation(mensaje, null);
                }

                _automatMedicionesDbContext.VariablesInstrumentos.Add(variableInstrumento);
                _automatMedicionesDbContext.SaveChanges();

                var variableInstrumentoAgregada = _automatMedicionesDbContext.VariablesInstrumentos.AsQueryable()
                                                                                                   .FirstOrDefault(x => x.InstrumentoId == variableInstrumento.VariableInstrumentoId);

                return Response<VariableInstrumentoDto>.Ok("Ok", _mapper.Map<VariableInstrumentoDto>(variableInstrumentoAgregada));
            }
            catch (Exception exc)
            {
                return Response<VariableInstrumentoDto>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<VariableInstrumentoDto> ActualizarVinculacionVariableDeMedicion(VariableInstrumentoDto variableInstrumentoDto)
        {
            try
            {
                var variablesInstrumentoBd = _automatMedicionesDbContext.VariablesInstrumentos.FirstOrDefault(x => x.VariableInstrumentoId == variableInstrumentoDto.VariableInstrumentoId);

                if (variablesInstrumentoBd == null)
                {
                    return Response<VariableInstrumentoDto>.ErrorValidation("La vinculación para la variable de medición no fue encontrada", null);
                }

                variablesInstrumentoBd.InstrumentoId = variableInstrumentoDto.InstrumentoId;
                variablesInstrumentoBd.VariableMedicionId = variableInstrumentoDto.VariableMedicionId;
                variablesInstrumentoBd.TieneAlarma = variableInstrumentoDto.TieneAlarma;

                variablesInstrumentoBd.AlarmaAlta = variableInstrumentoDto.AlarmaAlta;
                variablesInstrumentoBd.AlarmaBaja = variableInstrumentoDto.AlarmaBaja;
                variablesInstrumentoBd.AlarmaStel = variableInstrumentoDto.AlarmaStel;
                variablesInstrumentoBd.AlarmaTwa = variableInstrumentoDto.AlarmaTwa;

                _automatMedicionesDbContext.SaveChanges();

                return Response<VariableInstrumentoDto>.Ok("Ok", _mapper.Map<VariableInstrumentoDto>(variablesInstrumentoBd));
            }
            catch (Exception exc)
            {
                return Response<VariableInstrumentoDto>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }


        public Response<List<VariableInstrumentoDto>> ObtenerVariablesInstrumentos(int instrumentoId)
        {
            try
            {
                var variablesInstrumentos = _automatMedicionesDbContext.VariablesInstrumentos.AsQueryable().Where(x => x.InstrumentoId == instrumentoId && x.Activo).Include(x => x.VariableDeMedicion).ToList();
                return Response<List<VariableInstrumentoDto>>.Ok("Ok", _mapper.Map<List<VariableInstrumentoDto>>(variablesInstrumentos));
            }
            catch (Exception exc)
            {
                return Response<List<VariableInstrumentoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
