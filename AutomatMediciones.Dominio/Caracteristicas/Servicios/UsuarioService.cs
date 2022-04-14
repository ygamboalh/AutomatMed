using AutoMapper;
using AutomatMediciones.Dominio.Infraestructura;
using AutomatMediciones.Libs.Dtos;
using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatMediciones.Dominio.Caracteristicas.Servicios
{
    public class UsuarioService
    {
        private readonly AutomatMedicionesDbContext _automatMedicionesDbContext;
        private readonly IMapper _mapper;

        public UsuarioService(AutomatMedicionesDbContext automatMedicionesDbContext, IMapper mapper)
        {
            _automatMedicionesDbContext = automatMedicionesDbContext;
            _mapper = mapper;
        }

        public Response<List<UsuarioDto>> ObtenerUsuariosActivos()
        {
            try
            {
                var usuarios = _automatMedicionesDbContext.Usuarios.Where(x => x.Activo);
                return Response<List<UsuarioDto>>.Ok("Ok", _mapper.Map<List<UsuarioDto>>(usuarios));
            }
            catch (Exception exc)
            {
                return Response<List<UsuarioDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        public Response<List<UsuarioDto>> ObtenerTodosLosUsuarios()
        {
            try
            {
                var usuarios = _automatMedicionesDbContext.Usuarios;
                return Response<List<UsuarioDto>>.Ok("Ok", _mapper.Map<List<UsuarioDto>>(usuarios));
            }
            catch (Exception exc)
            {
                return Response<List<UsuarioDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
