using AutoMapper;
using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using TacticaReparaciones.Libs.Dtos;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;
using TacticaReparaciones.Servicios.Caracteristicas.Enums;
using TacticaReparaciones.Servicios.Infraestructura;

namespace TacticaReparaciones.Servicios.Caracteristicas.Servicios
{
    public class IngresoService
    {
        private readonly TacticaReparacionesDbContext _tacticaReparacionesDbContext;
        private readonly IMapper _mapper;

        public IngresoService(TacticaReparacionesDbContext tacticaReparacionesDbContext, IMapper mapper)
        {
            _tacticaReparacionesDbContext = tacticaReparacionesDbContext;
            _mapper = mapper;
        }

        public Response<List<IngresoDto>> ObtenerIngresosPorEstado(int estadoId)
        {
            try
            {
                var ingresos = _tacticaReparacionesDbContext.Ingresos.Where(x => x.EstadoId.Equals(estadoId)).ToList();

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

                _tacticaReparacionesDbContext.Database.BeginTransaction();
                _tacticaReparacionesDbContext.Ingresos.Add(ingreso);
                _tacticaReparacionesDbContext.SaveChanges();

                foreach (var instrumento in ingresoDto.Instrumentos)
                {
                    IngresoInstrumento ingresoInstrumento = new IngresoInstrumento
                    {
                        IngresoId = ingreso.IngresoId,
                        Activo = true,
                        InstrumentoId = instrumento.InstrumentoId
                    };

                    _tacticaReparacionesDbContext.IngresosInstrumentos.Add(ingresoInstrumento);

                }

                _tacticaReparacionesDbContext.SaveChanges();
                _tacticaReparacionesDbContext.Database.CommitTransaction();

                return Response<bool>.Ok("¡El ingreso se guardó exitosamente!", true);
            }
            catch (Exception exc)
            {
                _tacticaReparacionesDbContext.Database.RollbackTransaction();
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }
    }
}
