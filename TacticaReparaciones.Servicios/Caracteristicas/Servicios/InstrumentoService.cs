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

        public InstrumentoService(TacticaReparacionesDbContext tacticaReparacionesDbContext)
        {
            _tacticaReparacionesDbContext = tacticaReparacionesDbContext;
        }

        public Response<List<InstrumentoDto>> ObtenerInstrumentos()
        {
            try
            {
                var instrumentos = _tacticaReparacionesDbContext.Instrumentos.Select(x => new InstrumentoDto
                {
                    Descripcion = x.Descripcion,
                    EmpresaId = x.EmpresaId,
                    FechaCompraCliente = x.FechaCompraCliente.Value,
                    FechaCompraFabricante = x.FechaCompraFabricante,
                    FechaProximaCalibracion = x.FechaProximaCalibracion,
                    FechaUltimaCalibracion = x.FechaUltimaCalibracion,
                    GarantiaId = x.GarantiaId,
                    InstrumentoId = x.InstrumentoId,
                    MarcaId = x.MarcaId,
                    ModeloId = x.ModeloId,
                    NombreEmpresa = x.NombreEmpresa,
                    NumeroSerie = x.NumeroSerie,
                    PeriodoCalibracionId = x.PeriodoCalibracionId,
                    TipoInstrumentoId = x.TipoInstrumentoId
                }).ToList();

                return Response<List<InstrumentoDto>>.Ok("Ok", instrumentos);
            }
            catch (Exception exc)
            {
                return Response<List<InstrumentoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<InstrumentoDto>> ObtenerInstrumentos(string empresaId)
        {
            try
            {
                var instrumentos = _tacticaReparacionesDbContext.Instrumentos.Where(x => x.Activo &&
                                                                                    x.EmpresaId.Equals(empresaId))
                                                                        .Select(x => new InstrumentoDto
                                                                        {
                                                                            Descripcion = x.Descripcion,
                                                                            EmpresaId = x.EmpresaId,
                                                                            FechaCompraCliente = x.FechaCompraCliente.Value,
                                                                            FechaCompraFabricante = x.FechaCompraFabricante,
                                                                            FechaProximaCalibracion = x.FechaProximaCalibracion,
                                                                            FechaUltimaCalibracion = x.FechaUltimaCalibracion,
                                                                            GarantiaId = x.GarantiaId,
                                                                            InstrumentoId = x.InstrumentoId,
                                                                            MarcaId = x.MarcaId,
                                                                            ModeloId = x.ModeloId,
                                                                            NombreEmpresa = x.NombreEmpresa,
                                                                            NumeroSerie = x.NumeroSerie,
                                                                            PeriodoCalibracionId = x.PeriodoCalibracionId,
                                                                            TipoInstrumentoId = x.TipoInstrumentoId
                                                                        }).ToList();

                return Response<List<InstrumentoDto>>.Ok("Ok", instrumentos);
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
                    GarantiaId = instrumentoDto.GarantiaId,
                    MarcaId = instrumentoDto.MarcaId,
                    ModeloId = instrumentoDto.ModeloId,
                    NumeroSerie = instrumentoDto.NumeroSerie,
                    PeriodoCalibracionId = instrumentoDto.PeriodoCalibracionId,
                    TipoInstrumentoId = instrumentoDto.TipoInstrumentoId,
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
