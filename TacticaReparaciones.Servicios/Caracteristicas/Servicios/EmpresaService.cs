using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using AutomatMediciones.Libs.Dtos;
using AutomatMediciones.Servicios.Infraestructura;

namespace AutomatMediciones.Servicios.Caracteristicas.Servicios
{
    public class EmpresaService
    {
        private readonly TacticaDbContext _tacticaDbContext;

        public EmpresaService(TacticaDbContext tacticaDbContext)
        {
            _tacticaDbContext = tacticaDbContext;
        }

        public Response<List<EmpresaDto>> ObtenerEmpresas()
        {
            try
            {
                var empresas = _tacticaDbContext.Empresas.ToList();
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
                                             EmpresaId = y.EmpresaId,
                                             ContactoId = y.ContactoId,
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
    }
}
