using Microsoft.AspNetCore.Mvc;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using TacticaReparaciones.Libs.Dtos;
using TacticaReparaciones.Servicios.Caracteristicas.Servicios;

namespace TacticaReparaciones.Servicios.Caracteristicas.Controladores
{
    [Route("marcas")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly MarcaService _marcaService;

        public MarcaController(MarcaService marcaService)
        {
            _marcaService = marcaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _marcaService.ObtenerMarcas();

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpPost]
        public IActionResult Post([FromBody] MarcaDto marcaDto)
        {
            var result = _marcaService.RegistrarMarca(marcaDto);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody] MarcaDto marcaDto)
        {
            var result = _marcaService.ActualizarMarca(marcaDto);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }
    }
}
