using AutoMapper;
using AutomatMediciones.Dominio.Caracteristicas.Entidades;
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
    public class VariableMedicionService
    {
        private readonly AutomatMedicionesDbContext _tacticaDbContext;
        private readonly IMapper _mapper;

        public VariableMedicionService(AutomatMedicionesDbContext tacticaDbContext, IMapper mapper)
        {
            _tacticaDbContext = tacticaDbContext;
            _mapper = mapper;
        }

        public Response<List<VariableMedicionDto>> ObtenerVariablesDeMedicionActivas()
        {
            try
            {
                var variablesDeMedicion = _tacticaDbContext.VariablesDeMedicion.AsQueryable()
                                                                               .Include(x => x.TiposDeInstrumentoVariables)                                                                              
                                                                               .ThenInclude(x => x.TipoInstrumento)
                                                                               .Include(x => x.UnidadMedida).ToList();
                return Response<List<VariableMedicionDto>>.Ok("Ok", _mapper.Map<List<VariableMedicionDto>>(variablesDeMedicion));
            }
            catch (Exception exc)
            {
                return Response<List<VariableMedicionDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<VariableMedicionDto>> ObtenerVariablesDeMedicion(List<int> variablesPatronesVariablesMedicionIds, List<int> variablesInstrumentosVariablesMedicionIds)
        {
            try
            {
                var variablesDeMedicion = _tacticaDbContext.VariablesDeMedicion.Where(x => variablesPatronesVariablesMedicionIds.Contains(x.VariableMedicionId)).ToList();
                variablesDeMedicion = variablesDeMedicion.Where(x => variablesInstrumentosVariablesMedicionIds.Contains(x.VariableMedicionId)).ToList();

                return Response<List<VariableMedicionDto>>.Ok("Ok", _mapper.Map<List<VariableMedicionDto>>(variablesDeMedicion));
            }
            catch (Exception exc)
            {
                return Response<List<VariableMedicionDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<bool> RegistrarVariableDeMedicion(VariableMedicionDto variableMedicionDto)
        {
            try
            {
                VariableDeMedicion variableDeMedicion = new VariableDeMedicion
                {
                    Descripcion = variableMedicionDto.Descripcion,
                    PrimerValorRango = variableMedicionDto.PrimerValorRango,
                    SegundoValorRango = variableMedicionDto.SegundoValorRango,
                    Tolerancia = variableMedicionDto.Tolerancia,
                    DescripcionCorta = variableMedicionDto.DescripcionCorta,
                    Nombre = variableMedicionDto.Nombre,
                    UnidadMedidaId = variableMedicionDto.UnidadMedidaId
                };

                _tacticaDbContext.Database.BeginTransaction();
                _tacticaDbContext.VariablesDeMedicion.Add(variableDeMedicion);
                _tacticaDbContext.SaveChanges();

                if (variableMedicionDto.TiposDeInstrumentoVariables.Any())
                {
                    var tiposDeInstrumentoVariable = variableMedicionDto.TiposDeInstrumentoVariables.ToList();

                    tiposDeInstrumentoVariable.ForEach(x =>
                    {
                        TipoInstrumentoVariable tipoInstrumentoVariable = new TipoInstrumentoVariable
                        {
                            VariableMedicionId = variableDeMedicion.VariableMedicionId,
                            TipoInstrumentoId = x.TipoInstrumentoId
                        };

                        _tacticaDbContext.TiposDeInstrumentosVariable.Add(tipoInstrumentoVariable);

                    });
                }

                _tacticaDbContext.SaveChanges();
                _tacticaDbContext.Database.CommitTransaction();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                _tacticaDbContext.Database.RollbackTransaction();
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> ActualizarVariableDeMedicion(VariableMedicionDto variableMedicionDto)
        {
            try
            {
                var variableMedicionBd = _tacticaDbContext.VariablesDeMedicion.FirstOrDefault(x => x.VariableMedicionId == variableMedicionDto.VariableMedicionId);

                if (variableMedicionBd == null)
                {
                    return Response<bool>.Error("La Variable de medición no fue encontrada en almacén de datos", false);
                }

                variableMedicionBd.DescripcionCorta = variableMedicionDto.DescripcionCorta;
                variableMedicionBd.Nombre = variableMedicionDto.Nombre;
                variableMedicionBd.Tolerancia = variableMedicionDto.Tolerancia;
                variableMedicionBd.PrimerValorRango = variableMedicionDto.PrimerValorRango;
                variableMedicionBd.SegundoValorRango = variableMedicionDto.SegundoValorRango;
                variableMedicionBd.Descripcion = variableMedicionDto.Descripcion;
                variableMedicionBd.UnidadMedidaId = variableMedicionDto.UnidadMedidaId;

                _tacticaDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }
    }
}
