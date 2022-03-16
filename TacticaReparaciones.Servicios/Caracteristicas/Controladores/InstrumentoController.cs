using Microsoft.AspNetCore.Mvc;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using TacticaReparaciones.Libs.Dtos;
using TacticaReparaciones.Servicios.Caracteristicas.Servicios;

namespace TacticaReparaciones.Servicios.Caracteristicas.Controladores
{
    [Route("instrumentos")]
    [ApiController]
    public class InstrumentoController : Controller
    {
        private readonly InstrumentoService _instrumentoService;

        public InstrumentoController(InstrumentoService instrumentoService)
        {
            _instrumentoService = instrumentoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _instrumentoService.ObtenerInstrumentos();

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpGet, Route("por-empresa/{empresaId}")]
        public IActionResult GetByEmpresa([FromRoute] string empresaId)
        {
            var result = _instrumentoService.ObtenerInstrumentosPorEmpresa(empresaId);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpPost]
        public IActionResult Post([FromBody] InstrumentoDto instrumentoDto)
        {
            var result = _instrumentoService.RegistrarInstrumento(instrumentoDto);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }
    }
}
