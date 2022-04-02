using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TacticaReparaciones.Libs.Dtos;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;
using TacticaReparaciones.Servicios.Infraestructura;

namespace TacticaReparaciones.Servicios.Caracteristicas.Servicios
{
    public class ModeloService
    {
        private readonly TacticaReparacionesDbContext _tacticaReparacionesDbContext;

        public ModeloService(TacticaReparacionesDbContext tacticaReparacionesDbContext)
        {
            _tacticaReparacionesDbContext = tacticaReparacionesDbContext;
        }

        public Response<List<ModeloDto>> ObtenerModelos()
        {
            try
            {
                var modelos = _tacticaReparacionesDbContext.Modelos.Select(x => new ModeloDto
                {
                   
                    Descripcion = x.Descripcion,
                    ModeloId = x.ModeloId
                }).ToList();

                return Response<List<ModeloDto>>.Ok("Ok", modelos);

            }
            catch (Exception exc)
            {
                return Response<List<ModeloDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<bool> RegistrarModelo(ModeloDto modeloDto)
        {
            try
            {
                Modelo modelo = new Modelo
                {
                    Descripcion = modeloDto.Descripcion               
                };

                _tacticaReparacionesDbContext.Modelos.Add(modelo);
                _tacticaReparacionesDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> ActualizarModelo(ModeloDto modeloDto)
        {
            try
            {
                var tipoInstrumentoBd = _tacticaReparacionesDbContext.Modelos.FirstOrDefault(x => x.ModeloId == modeloDto.ModeloId);

                if (tipoInstrumentoBd == null)
                {
                    return Response<bool>.Error("El modelo no fue encontrado en almacén de datos", false);
                }


                tipoInstrumentoBd.Descripcion = modeloDto.Descripcion;

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
