using AutoMapper;
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
        private readonly IMapper _mapper;

        public PatronService(AutomatMedicionesDbContext automatMedicionesDbContext, IMapper mapper)
        {
            _automatMedicionesDbContext = automatMedicionesDbContext;
            _mapper = mapper;
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

        public Response<ICollection<PatronDto>> ObtenerPatrones()
        {
            try
            {
                var patrones = _automatMedicionesDbContext.Patrones.Where(x => x.Activo);


                return Response<ICollection<PatronDto>>.Ok("Ok", _mapper.Map<List<PatronDto>>(patrones));
            }
            catch (Exception exc)
            {
                return Response<ICollection<PatronDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }


    }
}
