using AutoMapper;
using AutomatMediciones.Dominio.Caracteristicas.Entidades;
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

        public Response<bool> RegistrarUsuario(UsuarioDto usuarioDto)
        {
            try
            {
                Usuario usuario = new Usuario
                {
                    Nombre = usuarioDto.Nombre,
                    Correo = usuarioDto.Correo,
                    Activo = true,
                    CopiaEnNotificaciones = usuarioDto.CopiaEnNotificaciones,
                    EnlaceFirmaDigital = usuarioDto.EnlaceFirmaDigital
                };

                _automatMedicionesDbContext.Usuarios.Add(usuario);
                _automatMedicionesDbContext.SaveChanges();
         
                return Response<bool>.Ok("Ok", true);
            }
            catch (Exception exc)
            {
               
                return Response<bool>.Error(MessageException.LanzarExcepcion(exc), false);
            }
        }

        public Response<bool> ActualizarUsuario(UsuarioDto usuarioDto)
        {
            try
            {
                var usuarioDb = _automatMedicionesDbContext.Usuarios.AsQueryable().FirstOrDefault(x => x.UsuarioId == usuarioDto.UsuarioId);
                if (usuarioDb == null) return Response<bool>.Error("No se pudo encontrar este usuario en almacén de datos.", false);

                usuarioDb.Nombre = usuarioDto.Nombre;
                usuarioDb.EnlaceFirmaDigital = usuarioDto.EnlaceFirmaDigital;
                usuarioDb.Correo = usuarioDto.Correo;

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
