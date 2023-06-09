﻿using AutoMapper;
using AutomatMediciones.Dominio.Infraestructura;
using AutomatMediciones.Libs.Dtos;
using Nagaira.Core.Extentions.Exceptions;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Linq;

namespace AutomatMediciones.Dominio.Caracteristicas.Servicios
{
    public class ConfiguracionNotificacionService
    {
        private readonly AutomatMedicionesDbContext _automatMedicionesDbContext;
        private readonly IMapper _mapper;

        public ConfiguracionNotificacionService(AutomatMedicionesDbContext automatMedicionesDbContext, IMapper mapper)
        {
            _automatMedicionesDbContext = automatMedicionesDbContext;
            _mapper = mapper;
        }

        public Response<ConfiguracionNotificacionDto> ObtenerConfiguraciones()
        {
            try
            {
                var configuracion = _automatMedicionesDbContext.ConfiguracionesNotificaciones.FirstOrDefault(x => x.Activo);

                return Response<ConfiguracionNotificacionDto>.Ok("Ok", _mapper.Map<ConfiguracionNotificacionDto>(configuracion));
            }
            catch (Exception exc)
            {
                return Response<ConfiguracionNotificacionDto>.Excepcion(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
