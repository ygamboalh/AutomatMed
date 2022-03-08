using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TacticaReparaciones.Servicios.Caracteristicas.Dtos;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;
using TacticaReparaciones.Servicios.Caracteristicas.Enums;
using TacticaReparaciones.Servicios.Infraestructura;

namespace TacticaReparaciones.Servicios.Caracteristicas.Servicios
{
    public class IngresoService
    {
        private readonly TacticaReparacionesDbContext _tacticaReparacionesDbContext;

        public IngresoService(TacticaReparacionesDbContext tacticaReparacionesDbContext)
        {
            _tacticaReparacionesDbContext = tacticaReparacionesDbContext;
        }

        public Response<List<IngresoDto>> ObtenerIngresosPorEstado(int estadoId)
        {
            try
            {
                var ingresos = _tacticaReparacionesDbContext.Ingresos.Where(x => x.EstadoId.Equals(estadoId))
                                                                     .Select(x => new IngresoDto
                                                                     {
                                                                         IngresoId = x.IngresoId,
                                                                         EmpresaId = x.EmpresaId,
                                                                         NombreEmpresa = x.NombreEmpresa,
                                                                         NombreContacto = x.NombreContacto,
                                                                         ContactoId = x.ContactoId,
                                                                         DireccionCorreoElectronico = x.DireccionCorreoElectronico,
                                                                         CorreoElectronicoId = x.CorreoElectronicoId,
                                                                         EstadoId = x.EstadoId,
                                                                         Prioridad = x.Prioridad,
                                                                         Comentarios = x.Comentarios,
                                                                         TipoTrabajoId = x.TipoTrabajoId
                                                                     }).ToList();

                return Response<List<IngresoDto>>.Ok("Ok", ingresos);
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

                _tacticaReparacionesDbContext.Ingresos.Add(ingreso);
                _tacticaReparacionesDbContext.SaveChanges();

                return Response<bool>.Ok("¡El ingreso se guardó exitosamente!", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }
    }
}
