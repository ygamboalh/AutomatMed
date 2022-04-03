using AutoMapper;
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
    public class VariableMedicionService
    {
        private readonly TacticaReparacionesDbContext _tacticaDbContext;
        private readonly IMapper _mapper;

        public VariableMedicionService(TacticaReparacionesDbContext tacticaDbContext, IMapper mapper)
        {
            _tacticaDbContext = tacticaDbContext;
            _mapper = mapper;
        }

        public Response<List<VariableMedicionDto>> ObtenerVariablesDeMedicionActivas()
        {
            try
            {
                var variablesDeMedicion = _tacticaDbContext.VariablesDeMedicion.AsQueryable().ToList();
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
                    Tolerancia = variableMedicionDto.Tolerancia
                };

                _tacticaDbContext.VariablesDeMedicion.Add(variableDeMedicion);
                _tacticaDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
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

                variableMedicionBd.Tolerancia = variableMedicionDto.Tolerancia;
                variableMedicionBd.PrimerValorRango = variableMedicionDto.PrimerValorRango;
                variableMedicionBd.SegundoValorRango = variableMedicionDto.SegundoValorRango;
                variableMedicionBd.Descripcion = variableMedicionDto.Descripcion;

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
