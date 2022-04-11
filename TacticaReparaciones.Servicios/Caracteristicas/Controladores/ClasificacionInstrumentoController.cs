using Microsoft.AspNetCore.Mvc;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using AutomatMediciones.Libs.Dtos;
using AutomatMediciones.Servicios.Caracteristicas.Servicios;

namespace AutomatMediciones.Servicios.Caracteristicas.Controladores
{
    [Route("clasificaciones-instrumentos")]
    [ApiController]
    public class ClasificacionInstrumentoController : ControllerBase
    {
        private readonly ClasificacionInstrumentoService _clasificacionInstrumentoService;

        public ClasificacionInstrumentoController(ClasificacionInstrumentoService clasificacionInstrumentoService)
        {
            _clasificacionInstrumentoService = clasificacionInstrumentoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _clasificacionInstrumentoService.ObtenerClasificacionesActivas();

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClasificacionInstrumentoDto clasificacionInstrumentoDto)
        {
            var result = _clasificacionInstrumentoService.RegistrarClasificacion(clasificacionInstrumentoDto);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpPut]
        public IActionResult Put([FromBody] ClasificacionInstrumentoDto clasificacionInstrumentoDto)
        {
            var result = _clasificacionInstrumentoService.ActualizarClasificacion(clasificacionInstrumentoDto);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody] ClasificacionInstrumentoDto clasificacionInstrumentoDto)
        {
            var result = _clasificacionInstrumentoService.DesactivarClasificacion(clasificacionInstrumentoDto);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

    }
}
