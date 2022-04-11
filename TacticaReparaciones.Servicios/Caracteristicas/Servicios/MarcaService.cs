using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using AutomatMediciones.Libs.Dtos;
using AutomatMediciones.Servicios.Caracteristicas.Entidades;
using AutomatMediciones.Servicios.Infraestructura;

namespace AutomatMediciones.Servicios.Caracteristicas.Servicios
{
    public class MarcaService
    {
        private readonly AutomatMedicionesDbContext _AutomatMedicionesDbContext;
        private readonly ModeloService _modeloService;

        public MarcaService(AutomatMedicionesDbContext AutomatMedicionesDbContext, ModeloService modeloService)
        {
            _AutomatMedicionesDbContext = AutomatMedicionesDbContext;
            _modeloService = modeloService;
        }

        public Response<List<MarcaDto>> ObtenerMarcas()
        {
            try
            {


                var marcas = _AutomatMedicionesDbContext.Marcas.Select(x => new MarcaDto
                {
                    MarcaId = x.MarcaId,
                    Descripcion = x.Descripcion,


                }).ToList();

                return Response<List<MarcaDto>>.Ok("Ok", marcas);
            }
            catch (Exception exc)
            {
                return Response<List<MarcaDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<bool> RegistrarMarca(MarcaDto marcaDto)
        {
            try
            {
                Marca marca = new Marca
                {
                    Descripcion = marcaDto.Descripcion
                };

                _AutomatMedicionesDbContext.Marcas.Add(marca);
                _AutomatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> ActualizarMarca(MarcaDto marcaDto)
        {
            try
            {
                var marcaBd = _AutomatMedicionesDbContext.Marcas.FirstOrDefault(x => x.MarcaId == marcaDto.MarcaId);

                if (marcaBd == null)
                {
                    return Response<bool>.Error("La marca no fue encontrado en almacén de datos", false);
                }


                marcaBd.Descripcion = marcaDto.Descripcion;

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
