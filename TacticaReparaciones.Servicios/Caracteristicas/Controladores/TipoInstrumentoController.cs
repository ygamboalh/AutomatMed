using Microsoft.AspNetCore.Mvc;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using TacticaReparaciones.Servicios.Caracteristicas.Servicios;

namespace TacticaReparaciones.Servicios.Caracteristicas.Controladores
{
    [Route("tipos-de-instrumento")]
    [ApiController]
    public class TipoInstrumentoController : ControllerBase
    {
        private readonly TipoDeInstrumentoService _tipoInstrumentoService;

        public TipoInstrumentoController(TipoDeInstrumentoService tipoInstrumentoService)
        {
            _tipoInstrumentoService = tipoInstrumentoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _tipoInstrumentoService.ObtenerTiposDeInstrumento();

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }
    }
}
