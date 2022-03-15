using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TacticaReparaciones.Libs.Dtos;
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

        public Response<List<InstrumentoDto>> ObtenerInstrumentosPorEmpresa(string empresaId)
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
    }
}
