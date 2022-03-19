using Nagaira.Herramientas.Standard.Helpers.Exceptions;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TacticaReparaciones.Libs.Dtos;
using TacticaReparaciones.Servicios.Infraestructura;

namespace TacticaReparaciones.Servicios.Caracteristicas.Servicios
{
    public class ModeloService
    {
        private readonly TacticaReparacionesDbContext _tacticaReparacionesDbContext;

        public ModeloService(TacticaReparacionesDbContext tacticaReparacionesDbContext)
        {
            _tacticaReparacionesDbContext = tacticaReparacionesDbContext;
        }

        public Response<List<ModeloDto>> ObtenerModelos()
        {
            try
            {
                var modelos = _tacticaReparacionesDbContext.Modelos.Select(x => new ModeloDto
                {
                    MarcaId = x.MarcaId,
                    Descripcion = x.Descripcion,
                    ModeloId = x.ModeloId
                }).ToList();

                return Response<List<ModeloDto>>.Ok("Ok", modelos);

            }
            catch (Exception exc)
            {
                return Response<List<ModeloDto>>.Error(MessageException.LanzarExcepcion(exc), null);
            }
        }
    }
}
