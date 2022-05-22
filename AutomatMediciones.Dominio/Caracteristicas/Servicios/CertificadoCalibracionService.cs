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
    public class CertificadoCalibracionService
    {
        private readonly AutomatMedicionesDbContext _automatDbContext;
        private readonly IMapper _mapper;

        public CertificadoCalibracionService(AutomatMedicionesDbContext automatDbContext, IMapper mapper)
        {
            _automatDbContext = automatDbContext;
            _mapper = mapper;
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
                   NumeroCertificado = ""
                };

                _automatDbContext.Certificados.Add(certificado);
                _automatDbContext.SaveChanges();


                var certificadoDb = _automatDbContext.Certificados.AsQueryable().Include(x => x.Responsable)
                                                                                .Include(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Modelo)
                                                                                 .Include(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.Marca)
                                                                                  .Include(x => x.Instrumento).ThenInclude(x => x.Clasificacion).ThenInclude(x => x.TipoInstrumento)
                                                                                 
                                                        .FirstOrDefault(x => x.CertificadoId == certificado.CertificadoId);
                if (certificadoDb != null)
                {
                    certificadoDb.NumeroCertificado = $"{certificado.CertificadoId}-AM-{certificadoDto.Fecha.ToString("dd/MM/yyyy")}";
                }

                _automatDbContext.SaveChanges();

                var certificadoConvertido = _mapper.Map<CertificadoDto>(certificadoDb);

                return Response<CertificadoDto>.Ok("Ok", certificadoConvertido);
            }
            catch (Exception exc)
            {
                return Response<CertificadoDto>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
