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
    public class MarcaService
    {
        private readonly TacticaReparacionesDbContext _tacticaReparacionesDbContext;
        private readonly ModeloService _modeloService;

        public MarcaService(TacticaReparacionesDbContext tacticaReparacionesDbContext, ModeloService modeloService)
        {
            _tacticaReparacionesDbContext = tacticaReparacionesDbContext;
            _modeloService = modeloService;
        }

        public Response<List<MarcaDto>> ObtenerMarcas()
        {
            try
            {


                var marcas = _tacticaReparacionesDbContext.Marcas.Select(x => new MarcaDto
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

                _tacticaReparacionesDbContext.Marcas.Add(marca);
                _tacticaReparacionesDbContext.SaveChanges();

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
                var marcaBd = _tacticaReparacionesDbContext.Marcas.FirstOrDefault(x => x.MarcaId == marcaDto.MarcaId);

                if (marcaBd == null)
                {
                    return Response<bool>.Error("La marca no fue encontrado en almacén de datos", false);
                }


                marcaBd.Descripcion = marcaDto.Descripcion;

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
