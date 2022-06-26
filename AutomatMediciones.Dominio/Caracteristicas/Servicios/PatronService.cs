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
    public class PatronService
    {
        private readonly AutomatMedicionesDbContext _automatMedicionesDbContext;
        private readonly IMapper _mapper;

        public PatronService(AutomatMedicionesDbContext automatMedicionesDbContext, IMapper mapper)
        {
            _automatMedicionesDbContext = automatMedicionesDbContext;
            _mapper = mapper;
        }

        public Response<bool> RegistrarPatron(PatronDto patronDto)
        {
            try
            {
                Patron patron = new Patron
                {
                    Nombre = patronDto.Nombre,
                    FechaCaducidad = patronDto.FechaCaducidad,
                    Activo = true,
                    Link = patronDto.Link
                };

                _automatMedicionesDbContext.Database.BeginTransaction();
                _automatMedicionesDbContext.Patrones.Add(patron);
                _automatMedicionesDbContext.SaveChanges();

                List<VariablePatron> variablesPatrones = new List<VariablePatron>();

                foreach (var item in patronDto.VariablesPatrones)
                {
                    VariablePatron variablePatron = new VariablePatron
                    {
                        PatronId = patron.PatronId,
                        Tolerancia = item.Tolerancia,
                        VariableMeicionId = item.VariableMeicionId,
                        ValorPatron = item.ValorPatron,
                        Activo = true
                    };

                    variablesPatrones.Add(variablePatron);

                }

                if (variablesPatrones.Any())
                {
                    _automatMedicionesDbContext.VariablesPatrones.AddRange(variablesPatrones);
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

        public Response<bool> ActualizarPatron(PatronDto patronDto)
        {
            try
            {
                var patronDb = _automatMedicionesDbContext.Patrones.AsQueryable().FirstOrDefault(x => x.PatronId == patronDto.PatronId);
                if (patronDb == null) return Response<bool>.Error("No se pudo encontrar este patrón en almacén de datos.", false);

                patronDb.Nombre = patronDto.Nombre;
                patronDb.Link = patronDto.Link;
                patronDb.FechaCaducidad = patronDto.FechaCaducidad;

                List<VariablePatron> variablesPatrones = new List<VariablePatron>();

                foreach (var item in patronDto.VariablesPatrones)
                {
                    var vairablePatronDb = _automatMedicionesDbContext.VariablesPatrones.FirstOrDefault(x => x.VariablePatronId == item.VariablePatronId);
                    if (vairablePatronDb == null)
                    {
                        var variablePatron = new VariablePatron
                        {
                            VariableMeicionId = item.VariableMeicionId,
                            Activo = true,
                            PatronId = patronDb.PatronId,
                            Tolerancia = item.Tolerancia,
                            ValorPatron = item.ValorPatron
                        };

                        variablesPatrones.Add(variablePatron);
                    }
                }

                _automatMedicionesDbContext.Database.BeginTransaction();

                if (variablesPatrones.Any())
                {
                    _automatMedicionesDbContext.VariablesPatrones.AddRange(variablesPatrones);
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

        public Response<bool> DesactivarPatron(PatronDto patronDto)
        {
            try
            {
                var patronDb = _automatMedicionesDbContext.Patrones.FirstOrDefault(x => x.PatronId == patronDto.PatronId);
                if (patronDb == null) return Response<bool>.Error("No se pudo encontrar este patrón en almacén de datos.", false);

                patronDb.Activo = false;

                _automatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> DesactivarVariablePatron(VariablePatronDto variablePatronDto)
        {
            try
            {
                var variablePatronDb = _automatMedicionesDbContext.VariablesPatrones.FirstOrDefault(x => x.VariablePatronId == variablePatronDto.VariablePatronId);
                if (variablePatronDb == null) return Response<bool>.Error("No se pudo encontrar esta vinculación en almacén de datos.", false);

                variablePatronDb.Activo = false;

                _automatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }


        public Response<ICollection<PatronDto>> ObtenerPatrones()
        {
            try
            {
                var patrones = _automatMedicionesDbContext.Patrones.Include(x => x.VariablesPatrones).ThenInclude(x => x.VariableDeMedicion).Where(x => x.Activo);


                return Response<ICollection<PatronDto>>.Ok("Ok", _mapper.Map<List<PatronDto>>(patrones));
            }
            catch (Exception exc)
            {
                return Response<ICollection<PatronDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }


    }
}
