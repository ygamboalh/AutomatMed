using Microsoft.AspNetCore.Mvc;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using AutomatMediciones.Libs.Dtos;
using AutomatMediciones.Servicios.Caracteristicas.Servicios;

namespace AutomatMediciones.Servicios.Caracteristicas.Controladores
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

        [HttpPost]
        public IActionResult Post([FromBody] TipoInstrumentoDto tipoInstrumentoDto)
        {
            var result = _tipoInstrumentoService.RegistrarTipoInstrumento(tipoInstrumentoDto);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody] TipoInstrumentoDto tipoInstrumentoDto)
        {
            var result = _tipoInstrumentoService.ActualizarTipoDeInstrumento(tipoInstrumentoDto);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }
    }
}
