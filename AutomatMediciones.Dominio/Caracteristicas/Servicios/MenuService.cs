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
    public class MenuService
    {
        private readonly AutomatMedicionesDbContext _automatMedicionesDbContext;
        private readonly IMapper _mapper;

        public MenuService(AutomatMedicionesDbContext automatMedicionesDbContext, IMapper mapper)
        {
            _automatMedicionesDbContext = automatMedicionesDbContext;
            _mapper = mapper;
        }

        public Response<List<MenuDto>> ObtenerMenu()
        {
            try
            {
                var menusDb = _automatMedicionesDbContext.Menus.AsQueryable().Where(x => x.Activo && x.MenuPadre == 0).ToList();
                var menus = _mapper.Map<List<MenuDto>>(menusDb);

                menus.ForEach(f => f.Items = ObtenerNivelesMenu(f));

                return Response<List<MenuDto>>.Ok("Ok", menus.OrderByDescending(x => x.Posicion).ThenByDescending(y => y.MenuPadre).ToList());
            }
            catch (Exception exc)
            {
                return Response<List<MenuDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }

        private List<MenuDto> ObtenerNivelesMenu(MenuDto item)
        {
            var menu = _automatMedicionesDbContext.Menus.AsQueryable().Where(x => x.MenuPadre == item.Id && x.Activo == true);
           
            var items = menu.Select(m => new MenuDto
                         {
                             Descripcion = m.Descripcion,
                             Id = m.Id,
                             Icono = m.Icono,
                             Posicion = m.Posicion,
                             MenuPadre = m.MenuPadre,
                             Activo = m.Activo,
                             Color = m.Color,
                             IndiceMenu = m.IndiceMenu,
                             FechaAgrega = m.FechaAgrega
                         }).ToList();

            if (items.Count == 0) return items;
            else
            {
                items.ForEach(x => x.Items = ObtenerNivelesMenu(x).OrderByDescending(y => y.Posicion).ThenByDescending(y => y.MenuPadre).ToList());
                return items;
            }
        }
    }
}
