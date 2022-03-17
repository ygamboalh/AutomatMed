using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using TacticaReparaciones.Libs.Dtos;
using TacticaReparaciones.Servicios.Infraestructura;

namespace TacticaReparaciones.Servicios.Caracteristicas.Servicios
{
    public class TipoDeInstrumentoService
    {
        private readonly TacticaReparacionesDbContext _tacticaDbContext;

        public TipoDeInstrumentoService(TacticaReparacionesDbContext tacticaReparacionesDbContext)
        {
            _tacticaDbContext = tacticaReparacionesDbContext;
        }

        public Response<List<TipoInstrumentoDto>> ObtenerTiposDeInstrumento()
        {
            try
            {
                var modelos = _tacticaDbContext.Modelos.Select(x => new ModeloDto
                {
                    MarcaId = x.MarcaId,
                    Descripcion = x.Descripcion,
                    ModeloId = x.ModeloId
                }).ToList();

                var marcas = _tacticaDbContext.Marcas.Select(x => new MarcaDto
                {
                    MarcaId = x.MarcaId,
                    Descripcion = x.Descripcion,
                    TipoInstrumentoId = x.TipoInstrumentoId,
                    Modelos = modelos
                }).ToList();

                var periodosDeCalibracion = _tacticaDbContext.PeriodosDeCalibracion.Select(x => new PeriodoCalibracionDto
                {
                    Descripcion = x.Descripcion,
                    TipoInstrumentoId = x.TipoInstrumentoId,
                    PeriodoCalibracionId = x.PeriodoCalibracionId
                }).ToList();


                var garantias = _tacticaDbContext.Garantias.Select(x => new GarantiaDto
                {
                    Descripcion = x.Descripcion,
                    GarantiaId = x.GarantiaId,
                    TipoInstrumentoId = x.TipoInstrumentoId
                }).ToList();

                var tiposDeInstrumentos = _tacticaDbContext.TiposDeInstrumentos.ToList();

                var query = tiposDeInstrumentos.AsQueryable().Select(x => new TipoInstrumentoDto
                {
                    TipoInstrumentoId = x.TipoInstrumentoId,
                    Descripcion = x.Descripcion,
                    Garantias = garantias,
                    Marcas = marcas,
                    PeriodosDeCalibracion = periodosDeCalibracion
                }).ToList();


                return Response<List<TipoInstrumentoDto>>.Ok("Ok", query);
            }
            catch (Exception exc)
            {
                return Response<List<TipoInstrumentoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
