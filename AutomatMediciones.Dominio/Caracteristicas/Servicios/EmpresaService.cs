using AutoMapper;
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
    public class EmpresaService
    {
        private readonly TacticaDbContext _tacticaDbContext;
        private readonly IMapper _mapper;

        public EmpresaService(TacticaDbContext tacticaDbContext, IMapper mapper)
        {
            _tacticaDbContext = tacticaDbContext;
            _mapper = mapper;
        }

        public Response<List<EmpresaDto>> ObtenerEmpresas(string filtro)
        {
            try
            {
                var empresas = _tacticaDbContext.Empresas.Where(x => x.NombreEmpresa.Contains(filtro)).Take(100).ToList();
                var contactos = _tacticaDbContext.Contactos.ToList();
                var correosElectronicos = _tacticaDbContext.CorreosElectronicos.ToList();

                var query = empresas.AsQueryable().Select(x => new EmpresaDto
                {
                    EmpresaId = x.EmpresaId,
                    NombreEmpresa = x.NombreEmpresa,
                    Contactos = contactos.Where(z => z.EmpresaId.Equals(x.EmpresaId))
                                         .Select(y => new ContactoDto
                                         {
                                             Cargo = y.Cargo,
                                             Nombre = y.Nombre,
                                             Apellido = y.Apellido,
                                             EmpresaId = y.EmpresaId,
                                             ContactoId = y.ContactoId,
                                             Genero = y.Genero,
                                             Saludo = y.Saludo,
                                             CorreosElectronicos = correosElectronicos.Where(p => p.ContactoId.Equals(y.ContactoId))
                                                                                      .Select(z => new CorreoElectronicoDto
                                                                                      {
                                                                                          ContactoId = z.ContactoId,
                                                                                          Direccion = z.Direccion,
                                                                                          RegistroId = z.RegistroId
                                                                                      }).ToList()
                                         }).ToList()
                }).ToList();


                return Response<List<EmpresaDto>>.Ok("Ok", query);
            }
            catch (Exception exc)
            {
                return Response<List<EmpresaDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<EmpresaDto> ObtenerEmpresaPorId(string empresaId)
        {
            try
            {
                var empresa = _tacticaDbContext.Empresas.AsQueryable()
                                                        .FirstOrDefault(x => x.EmpresaId == empresaId);

                var contactos = _tacticaDbContext.Contactos.ToList();
                var correosElectronicos = _tacticaDbContext.CorreosElectronicos.ToList();

                var query = new EmpresaDto
                {
                    EmpresaId = empresa.EmpresaId,
                    NombreEmpresa = empresa.NombreEmpresa,
                    Contactos = contactos.Where(z => z.EmpresaId.Equals(empresa.EmpresaId))
                                         .Select(y => new ContactoDto
                                         {
                                             Cargo = y.Cargo,
                                             Nombre = y.Nombre,
                                             Apellido = y.Apellido,
                                             EmpresaId = y.EmpresaId,
                                             ContactoId = y.ContactoId,
                                             Genero = y.Genero,
                                             Saludo = y.Saludo,
                                             CorreosElectronicos = correosElectronicos.Where(p => p.ContactoId.Equals(y.ContactoId))
                                                                                      .Select(z => new CorreoElectronicoDto
                                                                                      {
                                                                                          ContactoId = z.ContactoId,
                                                                                          Direccion = z.Direccion,
                                                                                          RegistroId = z.RegistroId
                                                                                      }).ToList()
                                         }).ToList()
                };

                return Response<EmpresaDto>.Ok("Ok", _mapper.Map<EmpresaDto>(query));
            }
            catch (Exception exc)
            {
                return Response<EmpresaDto>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
