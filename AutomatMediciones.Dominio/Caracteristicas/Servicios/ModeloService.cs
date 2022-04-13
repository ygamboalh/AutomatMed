using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Infraestructura;
using AutomatMediciones.Libs.Dtos;
using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatMediciones.Dominio.Caracteristicas.Servicios
{
    public class ModeloService
    {
        private readonly AutomatMedicionesDbContext _AutomatMedicionesDbContext;

        public ModeloService(AutomatMedicionesDbContext AutomatMedicionesDbContext)
        {
            _AutomatMedicionesDbContext = AutomatMedicionesDbContext;
        }

        public Response<List<ModeloDto>> ObtenerModelos()
        {
            try
            {
                var modelos = _AutomatMedicionesDbContext.Modelos.Select(x => new ModeloDto
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

                _AutomatMedicionesDbContext.Modelos.Add(modelo);
                _AutomatMedicionesDbContext.SaveChanges();

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
                var tipoInstrumentoBd = _AutomatMedicionesDbContext.Modelos.FirstOrDefault(x => x.ModeloId == modeloDto.ModeloId);

                if (tipoInstrumentoBd == null)
                {
                    return Response<bool>.Error("El modelo no fue encontrado en almacén de datos", false);
                }


                tipoInstrumentoBd.Descripcion = modeloDto.Descripcion;

                _AutomatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

    }
}
