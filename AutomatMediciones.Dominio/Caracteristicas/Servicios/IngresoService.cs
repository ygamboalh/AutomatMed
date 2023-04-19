using AutoMapper;
using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Caracteristicas.Enums;
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
    public class IngresoService
    {
        private readonly AutomatMedicionesDbContext _automatMedicionesDbContext;
        private readonly IMapper _mapper;

        public IngresoService(AutomatMedicionesDbContext automatMedicionesDbContext, IMapper mapper)
        {
            _automatMedicionesDbContext = automatMedicionesDbContext;
            _mapper = mapper;
        }

        public Response<IngresoDto> ObtenerIngreso(int ingresoId)
        {
            try
            {
                var ingresoDb = _automatMedicionesDbContext.Ingresos.AsQueryable()
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Marca)
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Modelo)
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.TipoInstrumento)
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Estado)
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.TipoTrabajo)
                                                                                   .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Ingreso)
                                                                                    .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Responsable)
                                                                                    .FirstOrDefault(x => x.IngresoId == ingresoId);


                if (ingresoDb == null) return Response<IngresoDto>.Excepcion("No pudo ser obtenida la información de ingreso", null);

                return Response<IngresoDto>.Ok("", _mapper.Map<IngresoDto>(ingresoDb));
            }
            catch (Exception exc)
            {
                return Response<IngresoDto>.Excepcion(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<IngresoDto>> ObtenerIngresos()
        {
            try
            {
                var ingresos = _automatMedicionesDbContext.Ingresos.AsQueryable()
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
                return Response<List<IngresoDto>>.Excepcion(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<IngresoInstrumentoDto> ObtenerIngresoInstrumento(int ingresoInstrumentoId)
        {
            try
            {
                var ingreso = _automatMedicionesDbContext.IngresosInstrumentos.FirstOrDefault(x => x.IngresoInstrumentoId == ingresoInstrumentoId);
                if (ingreso == null) return Response<IngresoInstrumentoDto>.Excepcion("No pudo ser obtenida la información de ingreso", null);
                return Response<IngresoInstrumentoDto>.Ok("Ok", _mapper.Map<IngresoInstrumentoDto>(ingreso));
            }
            catch (Exception exc)
            {
                return Response<IngresoInstrumentoDto>.Excepcion(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<IngresoInstrumentoDto>> ObtenerIngresoInstrumento()
        {
            try
            {
                var ingreso = _automatMedicionesDbContext.IngresosInstrumentos.ToList();
                if (ingreso == null) return Response<List<IngresoInstrumentoDto>>.Excepcion("No pudo ser obtenida la información de ingreso", null);
                return Response<List<IngresoInstrumentoDto>>.Ok("Ok", _mapper.Map<List<IngresoInstrumentoDto>>(ingreso));
            }
            catch (Exception exc)
            {
                return Response<List<IngresoInstrumentoDto>>.Excepcion(MessageException.LanzarExcepcion(exc), null);
            }
        }
        public Response<IngresoInstrumento> ObtenerIngresoInstrumentoIdIngreso(int ingresoId)
        {
            try
            {
                var ingresoIdP = _automatMedicionesDbContext.Ingresos.FirstOrDefault(x => x.IngresoId == ingresoId);
                var ingreso = _automatMedicionesDbContext.IngresosInstrumentos.FirstOrDefault(x => x.IngresoId == ingresoIdP.IngresoId);
                if (ingreso == null) return Response<IngresoInstrumento>.Excepcion("No pudo ser obtenida la información de ingreso", null);

                return Response<IngresoInstrumento>.Ok("Ok", _mapper.Map<IngresoInstrumento>(ingreso));
            }
            catch (Exception exc)
            {
                return Response<IngresoInstrumento>.Excepcion(MessageException.LanzarExcepcion(exc), null);
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
                    UsuarioId = ingresoDto.UsuarioId,
                    TipoIngresoId = ingresoDto.TipoIngresoId
                };

                if (!ingreso.EsValido(out string mensaje)) return Response<IngresoDto>.Excepcion(mensaje, null);

                _automatMedicionesDbContext.Database.BeginTransaction();
                _automatMedicionesDbContext.Ingresos.Add(ingreso);
                _automatMedicionesDbContext.SaveChanges();

                int correlativoIntrumento = 1;
                foreach (var instrumento in ingresoDto.IngresosInstrumentos)
                {
                    var instrumentoBd = _automatMedicionesDbContext.Instrumentos.FirstOrDefault(x => x.InstrumentoId == instrumento.InstrumentoId);

                    if (instrumentoBd != null) instrumentoBd.Comentarios = instrumento.Instrumento.Comentarios;

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
                        EstadoId = instrumento.EstadoId,
                        ResponsableId = ingresoDto.UsuarioId,
                        FechaEntregaRequerida = instrumento.FechaEntregaRequerida,
                        PreIngresoId = instrumento.PreIngresoId
                    };

                    _automatMedicionesDbContext.IngresosInstrumentos.Add(ingresoInstrumento);

                    correlativoIntrumento++;
                }

                ingresoDto.IngresoId = ingreso.IngresoId;

                _automatMedicionesDbContext.SaveChanges();
                _automatMedicionesDbContext.Database.CommitTransaction();

                var ingresoRegistrado = _automatMedicionesDbContext.Ingresos.Include(x => x.IngresosInstrumentos)
                                                                            .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Instrumento)
                                                                            .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.TipoTrabajo)
                                                                  .Include(x => x.Responsable)
                                                                  .FirstOrDefault(x => x.IngresoId == ingreso.IngresoId);

                return Response<IngresoDto>.Ok("¡El ingreso se guardó exitosamente!", _mapper.Map<IngresoDto>(ingresoRegistrado));
            }
            catch (Exception exc)
            {
                _automatMedicionesDbContext.Database.RollbackTransaction();
                return Response<IngresoDto>.Excepcion(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<IngresoDto> ActualizarIngreso(IngresoDto ingresoDto)
        {
            try
            {
                var ingresoDb = _automatMedicionesDbContext.Ingresos.FirstOrDefault(x => x.IngresoId == ingresoDto.IngresoId);

                if (ingresoDb == null) return Response<IngresoDto>.Excepcion("No se encontró ningún registro en almacén de datos.", null);

                _automatMedicionesDbContext.Database.BeginTransaction();

                ingresoDb = _mapper.Map<Ingreso>(ingresoDto);

                if (ingresoDto.IngresosInstrumentos.Any(x => x.IngresoId == 0))
                {
                    int correlativoIntrumento = ingresoDto.IngresosInstrumentos.Count;

                    foreach (var instrumento in ingresoDto.IngresosInstrumentos.Where(x => x.IngresoId == 0))
                    {
                        var ingresoInstrumento = new IngresoInstrumento
                        {
                            NumeroServicioTecnico = $"{ingresoDb.IngresoId}-{correlativoIntrumento + 1}",
                            Comentarios = instrumento.Comentarios,
                            IngresoId = ingresoDb.IngresoId,
                            Activo = true,
                            InstrumentoId = instrumento.InstrumentoId,
                            TipoTrabajoId = instrumento.TipoTrabajoId,
                            FechaFin = instrumento.FechaFin,
                            FechaInicio = instrumento.FechaInicio,
                            Prioridad = instrumento.Prioridad,
                            EstadoId = instrumento.EstadoId,
                            ResponsableId = ingresoDto.UsuarioId,
                            FechaEntregaRequerida = instrumento.FechaEntregaRequerida,
                            PreIngresoId = instrumento.PreIngresoId
                        };

                        _automatMedicionesDbContext.IngresosInstrumentos.Add(ingresoInstrumento);

                        correlativoIntrumento++;
                    }

                }

                ingresoDto.IngresoId = ingresoDb.IngresoId;

                _automatMedicionesDbContext.SaveChanges();
                _automatMedicionesDbContext.Database.CommitTransaction();
                

                var ingresoRegistrado = _automatMedicionesDbContext.Ingresos.Include(x => x.IngresosInstrumentos)
                                                                            .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.Instrumento)
                                                                            .Include(x => x.IngresosInstrumentos).ThenInclude(x => x.TipoTrabajo)
                                                                  .Include(x => x.Responsable)
                                                                  .FirstOrDefault(x => x.IngresoId == ingresoDb.IngresoId);

                return Response<IngresoDto>.Ok("¡El ingreso se guardó exitosamente!", _mapper.Map<IngresoDto>(ingresoRegistrado));
            }
            catch (Exception exc)
            {
                _automatMedicionesDbContext.Database.RollbackTransaction();
                return Response<IngresoDto>.Excepcion(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<bool> ActualizarDiagnostico(IngresoInstrumentoDto ingresoInstrumento)
        {
            try
            {
                var diagnostico = _automatMedicionesDbContext.IngresosInstrumentos.FirstOrDefault(x => x.IngresoInstrumentoId.Equals(ingresoInstrumento.IngresoInstrumentoId));

                if (diagnostico == null) return Response<bool>.Excepcion("No se encontró ningún registro en almacén de datos.", true);

                var instrumento = _automatMedicionesDbContext.Instrumentos.FirstOrDefault(x => x.InstrumentoId == ingresoInstrumento.InstrumentoId);
                if (instrumento != null) instrumento.Comentarios = ingresoInstrumento.Instrumento.Comentarios;

                diagnostico.Comentarios = ingresoInstrumento.Comentarios;
                diagnostico.Diagnostico = ingresoInstrumento.Diagnostico;
                diagnostico.EstadoId = ingresoInstrumento.EstadoId;
                diagnostico.ResponsableId = ingresoInstrumento.ResponsableId;
                diagnostico.TiempoConsumido = ingresoInstrumento.TiempoConsumido;
                diagnostico.FechaInicio = ingresoInstrumento.FechaInicio;
                diagnostico.FechaQueEstaraDisponible = ingresoInstrumento.FechaQueEstaraDisponible;

                _automatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("¡El diagnóstico se guardó exitosamente!", true);
            }
            catch (Exception exc)
            {
                _automatMedicionesDbContext.Database.RollbackTransaction();
                return Response<bool>.Excepcion(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> QuitarInstrumentoDeListaIngreso(int instrumentoId)
        {
            try
            {
                var ingresoInstrumentoDb = _automatMedicionesDbContext.IngresosInstrumentos.FirstOrDefault(x => x.InstrumentoId == instrumentoId);

                if (ingresoInstrumentoDb == null) return Response<bool>.Excepcion("No se encontró ningún registro en almacen de datos.", true);

                ingresoInstrumentoDb.Activo = false;

                _automatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("¡El instrumento se quitó de lista de ingreso!", true);
            }
            catch (Exception exc)
            {

                return Response<bool>.Excepcion(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> ActualizarFechaUltimoIngreso(IngresoInstrumentoDto ingresoInstrumento)
        {
            try
            {
                var diagnostico = _automatMedicionesDbContext.IngresosInstrumentos.FirstOrDefault(x => x.IngresoInstrumentoId.Equals(ingresoInstrumento.IngresoInstrumentoId));

                if (diagnostico == null) return Response<bool>.Excepcion("No se encontró ningún registro en almacén de datos.", true);

                diagnostico.FechaInicio = ingresoInstrumento.FechaInicio;
                diagnostico.TiempoConsumido = ingresoInstrumento.TiempoConsumido;

                _automatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("¡El diagnóstico se guardó exitosamente!", true);
            }
            catch (Exception exc)
            {
                _automatMedicionesDbContext.Database.RollbackTransaction();
                return Response<bool>.Excepcion(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<List<ProductoIngresoDto>> ObtenerProductosIngresoId(int ingresoId)
        {
            try
            {
                var productosIngresos = _automatMedicionesDbContext.ProductosIngresos.Where(x => x.IngresoId == ingresoId);
                if(productosIngresos != null)
                    return Response<List<ProductoIngresoDto>>.Ok("Ok", _mapper.Map<List<ProductoIngresoDto>>(productosIngresos));
                return Response<List<ProductoIngresoDto>>.Excepcion("", null);
            }
            catch (Exception exc)
            {
                return Response<List<ProductoIngresoDto>>.Excepcion(exc.Message, null);
            }
        }
        public Response<List<IngresoDto>> ObtenerPreIngresosPorEmpresa(string empresaId)
        {
            try
            {


                var ingresos = _automatMedicionesDbContext.Ingresos.AsQueryable()
                    .Include(x => x.IngresosInstrumentos.Where(y => y.Activo)).ThenInclude(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Marca)
                                                                .Include(x => x.IngresosInstrumentos.Where(y => y.Activo)).ThenInclude(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Modelo)
                                                                .Include(x => x.IngresosInstrumentos.Where(y => y.Activo)).ThenInclude(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.TipoInstrumento)
                                                                .Include(x => x.IngresosInstrumentos.Where(y => y.Activo)).ThenInclude(x => x.Estado)
                                                                .Include(x => x.IngresosInstrumentos.Where(y => y.Activo)).ThenInclude(x => x.TipoTrabajo)
                                                                .Include(x => x.IngresosInstrumentos.Where(y => y.Activo)).ThenInclude(x => x.Ingreso)
                                                                .Include(x => x.IngresosInstrumentos.Where(y => y.Activo)).ThenInclude(x => x.Responsable)
                                                                .Where(x => x.Activo && x.EmpresaId == empresaId && x.TipoIngresoId == (int)TipoIngreso.PreIngreso)


                                                                .ToList();

                ingresos = ingresos.OrderBy(y => y.IngresoId).ToList();
                return Response<List<IngresoDto>>.Ok("Ok", _mapper.Map<List<IngresoDto>>(ingresos));

            }
            catch (Exception exc)
            {
                string message = exc.InnerException == null ? exc.Message : exc.InnerException.Message;
                return Response<List<IngresoDto>>.Excepcion(message, null);
            }
        }

    }
}
