using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Infraestructura;
using AutomatMediciones.Libs.Dtos;
using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMediciones.Dominio.Caracteristicas.Servicios
{
    public class PatronService
    {
        private readonly AutomatMedicionesDbContext _automatMedicionesDbContext;

        public PatronService(AutomatMedicionesDbContext automatMedicionesDbContext)
        {
            _automatMedicionesDbContext = automatMedicionesDbContext;
        }

        public Response<bool> RegistrarPatron(PatronDto patronDto)
        {
            try
            {
                Patron modelo = new Patron
                {
                    Nombre = patronDto.Nombre,
                    FechaCaducidad = patronDto.FechaCaducidad,
                    Activo = true,
                    Link = patronDto.Link
                };

                _automatMedicionesDbContext.Patrones.Add(modelo);
                _automatMedicionesDbContext.SaveChanges();

                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

    }
}
