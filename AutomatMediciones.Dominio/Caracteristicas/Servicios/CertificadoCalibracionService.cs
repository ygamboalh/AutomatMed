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
    public class CertificadoCalibracionService
    {
        private readonly AutomatMedicionesDbContext _automatDbContext;
        private readonly IMapper _mapper;

        public CertificadoCalibracionService(AutomatMedicionesDbContext automatDbContext, IMapper mapper)
        {
            _automatDbContext = automatDbContext;
            _mapper = mapper;
        }

        public Response<List<CertificadoDto>> ObtenerCertificados()
        {
            try
            {
                var certificados = _automatDbContext.Certificados.Include(x => x.Responsable)
                                                            .Include(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Modelo)
                                                            .Include(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Marca)
                                                            .Include(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.TipoInstrumento)
                                                            .Include(x => x.VariablesCertificado).ThenInclude(x => x.VariableInstrumento).ThenInclude(x => x.VariableDeMedicion)
                                                            .Include(x => x.VariablesCertificado).ThenInclude(x => x.Patron).ThenInclude(x => x.VariablesPatrones).ToList();

                return Response<List<CertificadoDto>>.Ok("Ok", _mapper.Map<List<CertificadoDto>>(certificados));
            }
            catch (Exception exc)
            {
                return Response<List<CertificadoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<CertificadoDto>> ObtenerCertificadosPorInstrumento(int instrumentoId)
        {
            try
            {
                var certificados = _automatDbContext.Certificados
                                                            .Include(x => x.Responsable)
                                                            .Include(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Modelo)
                                                            .Include(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Marca)
                                                            .Include(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.TipoInstrumento)
                                                            .Include(x => x.VariablesCertificado).ThenInclude(x => x.VariableInstrumento).ThenInclude(x => x.VariableDeMedicion)
                                                            .Include(x => x.VariablesCertificado).ThenInclude(x => x.Patron).ThenInclude(x => x.VariablesPatrones)
                                                            .Where(x => x.InstrumentoId == instrumentoId);

                return Response<List<CertificadoDto>>.Ok("Ok", _mapper.Map<List<CertificadoDto>>(certificados));
            }
            catch (Exception exc)
            {
                return Response<List<CertificadoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<VariableCertificadoDto>> ObtenerVariablesCertificados(int certificadoId)
        {
            try
            {
                var certificados = _automatDbContext.VariablesCertificados.Where(x => x.CertificadoId == certificadoId).ToList();
                return Response<List<VariableCertificadoDto>>.Ok("Ok", _mapper.Map<List<VariableCertificadoDto>>(certificados));
            }
            catch (Exception exc)
            {
                return Response<List<VariableCertificadoDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }


        public Response<CertificadoDto> RegistrarCertificado(CertificadoDto certificadoDto)
        {
            try
            {
                Certificado certificado = new Certificado
                {
                    CondicionesAmbientales = certificadoDto.CondicionesAmbientales,
                    Fecha = certificadoDto.Fecha,
                    FechaCaducidad = certificadoDto.FechaCaducidad,
                    InstrumentoId = certificadoDto.InstrumentoId,
                    ResponsableId = certificadoDto.ResponsableId,
                    NumeroCertificado = "",
                    Observaciones = certificadoDto.Observaciones,
                    Resultado = certificadoDto.Resultado,

                };

                _automatDbContext.Database.BeginTransaction();
                _automatDbContext.Certificados.Add(certificado);
                _automatDbContext.SaveChanges();


                List<VariableCertificado> variableCertificados = new List<VariableCertificado>();

                certificadoDto.VariablesCertificado.ToList().ForEach(x =>
                {
                    VariableCertificado variableCertificado = new VariableCertificado
                    {
                        PatronId = x.PatronId,
                        CertificadoId = certificado.CertificadoId,
                        ValorMedido = x.ValorMedido,
                        VariableInstrumentoId = x.VariableInstrumentoId
                    };

                    variableCertificados.Add(variableCertificado);

                });

                if (variableCertificados.Any())
                {
                    _automatDbContext.VariablesCertificados.AddRange(variableCertificados);
                }


                var certificadoDb = _automatDbContext.Certificados.AsQueryable().Include(x => x.Responsable)
                                                                                .Include(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Modelo)
                                                                                 .Include(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Marca)
                                                                                  .Include(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.TipoInstrumento)
                                                                                  .Include(x => x.VariablesCertificado).ThenInclude(x => x.VariableInstrumento).ThenInclude(x => x.VariableDeMedicion)
                                                                                 .Include(x => x.VariablesCertificado).ThenInclude(x => x.Patron).ThenInclude(x => x.VariablesPatrones)


                                                        .FirstOrDefault(x => x.CertificadoId == certificado.CertificadoId);
                if (certificadoDb != null)
                {
                    certificadoDb.NumeroCertificado = $"{certificado.CertificadoId}-AM-{certificadoDto.Fecha.ToString("dd/MM/yyyy")}";
                    certificadoDb.RutaCertificado = $"{certificadoDto.RutaCertificado}/{certificado.CertificadoId}.pdf";

                }

                _automatDbContext.SaveChanges();
                _automatDbContext.Database.CommitTransaction();

                var certificadoConvertido = _mapper.Map<CertificadoDto>(certificadoDb);

                return Response<CertificadoDto>.Ok("Ok", certificadoConvertido);
            }
            catch (Exception exc)
            {
                _automatDbContext.Database.RollbackTransaction();
                return Response<CertificadoDto>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<CertificadoDto> ActualizarCertificado(CertificadoDto certificadoDto)
        {
            try
            {
                var certificadoDb = _automatDbContext.Certificados.FirstOrDefault(x => x.CertificadoId == certificadoDto.CertificadoId);
                if (certificadoDb == null) return Response<CertificadoDto>.Error("No se encontró el certificado solicitado.", null);

                certificadoDb.CondicionesAmbientales = certificadoDto.CondicionesAmbientales;
                certificadoDb.Fecha = certificadoDto.Fecha;
                certificadoDb.FechaCaducidad = certificadoDto.FechaCaducidad;
                certificadoDb.InstrumentoId = certificadoDto.InstrumentoId;
                certificadoDb.NumeroCertificado = certificadoDto.NumeroCertificado;
                certificadoDb.Observaciones = certificadoDto.Observaciones;
                certificadoDb.ResponsableId = certificadoDto.ResponsableId;
                certificadoDb.Resultado = certificadoDto.Resultado;


                return Response<CertificadoDto>.Ok("Ok", certificadoDto);
            }
            catch (Exception exc)
            {
                _automatDbContext.Database.RollbackTransaction();
                return Response<CertificadoDto>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
