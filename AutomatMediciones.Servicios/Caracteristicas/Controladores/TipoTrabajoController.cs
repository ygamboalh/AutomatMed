using Microsoft.AspNetCore.Mvc;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using AutomatMediciones.Servicios.Caracteristicas.Servicios;

namespace AutomatMediciones.Servicios.Caracteristicas.Controladores
{
    [Route("tipos-de-trabajo")]
    [ApiController]
    public class TipoTrabajoController : ControllerBase
    {
        private readonly TipoTrabajoService _tipoTrabajoService;

        public TipoTrabajoController(TipoTrabajoService tipoTrabajoService)
        {
            _tipoTrabajoService = tipoTrabajoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _tipoTrabajoService.ObtenerTiposDeTrabajo();

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }
    }
}
