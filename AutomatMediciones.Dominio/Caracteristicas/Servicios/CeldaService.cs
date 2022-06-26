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
using System.Text;
using System.Threading.Tasks;

namespace AutomatMediciones.Dominio.Caracteristicas.Servicios
{
    public class CeldaService
    {
        private readonly AutomatMedicionesDbContext _automatDbContext;
        private readonly IMapper _mapper;

        public CeldaService(AutomatMedicionesDbContext automatDbContext, IMapper mapper)
        {
            _automatDbContext = automatDbContext;
            _mapper = mapper;
        }

        public Response<List<TipoCeldaDto>> ObtenerTiposDeCeldas()
        {
            try
            {
                var tiposDeCeldas = _automatDbContext.TiposDeCeldas.AsQueryable()
                                                                   .Include(x => x.VariableDeMedicion)
                                                                   .ToList();
                return Response<List<TipoCeldaDto>>.Ok("Ok", _mapper.Map<List<TipoCeldaDto>>(tiposDeCeldas));
            }
            catch (Exception exc)
            {
                return Response<List<TipoCeldaDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<EstadoCeldaDto>> ObtenerEstadosDeCelda()
        {
            try
            {
                var estados = _automatDbContext.EstadosCeldas.AsQueryable().ToList();
                return Response<List<EstadoCeldaDto>>.Ok("Ok", _mapper.Map<List<EstadoCeldaDto>>(estados));
            }
            catch (Exception exc)
            {
                return Response<List<EstadoCeldaDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<CeldaDto>> ObtenerCeldas()
        {
            try
            {
                var celdas = _automatDbContext.Celdas.AsQueryable().Include(x => x.TipoCelda).Include(x => x.Estado).ToList();
                return Response<List<CeldaDto>>.Ok("Ok", _mapper.Map<List<CeldaDto>>(celdas));
            }
            catch (Exception exc)
            {
                return Response<List<CeldaDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<bool>RegistrarCelda(CeldaDto celdaDto)
        {
            try
            {
                Celda celda = new Celda
                {
                    TipoCeldaId = celdaDto.TipoCeldaId,
                    NumeroSerie = celdaDto.NumeroSerie,
                    FechaFabricacion = celdaDto.FechaFabricacion,
                    FechaAdquisicion = celdaDto.FechaAdquisicion,
                    EstadoId = celdaDto.EstadoId
                };

                _automatDbContext.Celdas.Add(celda);
                _automatDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> ActualizarMarca(CeldaDto celdaDto)
        {
            try
            {
                var celdaDb = _automatDbContext.Celdas.FirstOrDefault(x => x.Id == celdaDto.Id);

                if (celdaDb == null) return Response<bool>.Error("La celda no fue encontrado en almacén de datos", false);

                celdaDb = _mapper.Map<Celda>(celdaDto);

                _automatDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> DesactivarTipoCeldaModelo(int tipoCeldaModeloId)
        {
            try
            {
                var tipoCeldaModeloDb = _automatDbContext.TiposDeCeldasModelos.FirstOrDefault(x => x.Id == tipoCeldaModeloId);

                if (tipoCeldaModeloDb == null)
                {
                    return Response<bool>.Error("El Tipo de Celda vinculado a este modelo no fue encontrado en almacén de datos", false);
                }

                tipoCeldaModeloDb.Activo = false;

                _automatDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }
    }
}
