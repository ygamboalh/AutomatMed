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
    public class ModeloService
    {
        private readonly AutomatMedicionesDbContext _automatMedicionesDbContext;
        private readonly IMapper _mapper;

        public ModeloService(AutomatMedicionesDbContext automatMedicionesDbContext, IMapper imapper)
        {
            _automatMedicionesDbContext = automatMedicionesDbContext;
            _mapper = imapper;
        }

        public Response<List<ModeloDto>> ObtenerModelos()
        {
            try
            {
                var modelos = _automatMedicionesDbContext.Modelos.AsQueryable().ToList();
                var tipoCeldaModelos = _automatMedicionesDbContext.TiposDeCeldasModelos.Where(y => modelos.Select(x => x.ModeloId).Contains(y.ModeloId) && y.Activo)
                                                                                        .ToList();
                var tiposDeCeldas = _automatMedicionesDbContext.TiposDeCeldas.AsQueryable().Include(y => y.VariableDeMedicion)
                                                                                           .Where(y => tipoCeldaModelos.Select(x => x.TipoCeldaId).Contains(y.Id))
                                                                                           .ToList();


                var query = modelos.Select(x => new ModeloDto
                {
                    Descripcion = x.Descripcion,
                    ModeloId = x.ModeloId,
                    TipoCeldaModelo = tipoCeldaModelos.Where(y => y.ModeloId == x.ModeloId).Select(r => new TipoCeldaModeloDto
                    {
                        Id = r.Id,
                        ModeloId = r.ModeloId,
                        TipoCeldaId = r.TipoCeldaId,
                        Activo = r.Activo,
                        TipoDeCelda = _mapper.Map<TipoCeldaDto>(tiposDeCeldas.FirstOrDefault(d => d.Id == r.TipoCeldaId)),

                    }).ToList()
                }).ToList();


                return Response<List<ModeloDto>>.Ok("Ok", query);

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

                _automatMedicionesDbContext.Database.BeginTransaction();
                _automatMedicionesDbContext.Modelos.Add(modelo);
                _automatMedicionesDbContext.SaveChanges();

                var tiposDeCeldaModelos = modeloDto.TipoCeldaModelo.Where(x => x.Id == 0).ToList();
                if (tiposDeCeldaModelos.Any())
                {
                    List<TipoCeldaModelo> listaTiposDeCeldaModelosParaRegistrar = new List<TipoCeldaModelo>();
                    tiposDeCeldaModelos.ForEach(x =>
                    {
                        listaTiposDeCeldaModelosParaRegistrar.Add(new TipoCeldaModelo
                        {
                            TipoCeldaId = x.TipoCeldaId,
                            ModeloId = modelo.ModeloId,
                            Activo = true
                        });
                    });

                    _automatMedicionesDbContext.TiposDeCeldasModelos.AddRange(listaTiposDeCeldaModelosParaRegistrar);
                    _automatMedicionesDbContext.SaveChanges();
                }

                _automatMedicionesDbContext.Database.CommitTransaction();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                _automatMedicionesDbContext.Database.RollbackTransaction();
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> ActualizarModelo(ModeloDto modeloDto)
        {
            try
            {
                var tipoInstrumentoBd = _automatMedicionesDbContext.Modelos.FirstOrDefault(x => x.ModeloId == modeloDto.ModeloId);

                if (tipoInstrumentoBd == null)
                {
                    return Response<bool>.Error("El modelo no fue encontrado en almacén de datos", false);
                }

                _automatMedicionesDbContext.Database.BeginTransaction();
                tipoInstrumentoBd.Descripcion = modeloDto.Descripcion;

                var tiposDeCeldaModelos = modeloDto.TipoCeldaModelo.Where(x => x.Id == 0).ToList();
                if (tiposDeCeldaModelos.Any())
                {
                    List<TipoCeldaModelo> listaTiposDeCeldaModelosParaRegistrar = new List<TipoCeldaModelo>();
                    tiposDeCeldaModelos.ForEach(x =>
                    {
                        listaTiposDeCeldaModelosParaRegistrar.Add(new TipoCeldaModelo
                        {
                            TipoCeldaId = x.TipoCeldaId,
                            ModeloId = tipoInstrumentoBd.ModeloId,
                            Activo = true
                        });
                    });

                    _automatMedicionesDbContext.TiposDeCeldasModelos.AddRange(listaTiposDeCeldaModelosParaRegistrar);
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

    }
}
