using Microsoft.AspNetCore.Mvc;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using AutomatMediciones.Libs.Dtos;
using AutomatMediciones.Servicios.Caracteristicas.Servicios;

namespace AutomatMediciones.Servicios.Caracteristicas.Controladores
{
    [Route("ingresos")]
    [ApiController]
    public class IngresoController : ControllerBase
    {
        private readonly IngresoService _ingresoService;

        public IngresoController(IngresoService ingresoService)
        {
            _ingresoService = ingresoService;
        }

        [HttpGet]
        public IActionResult GetIngresosQueNoEstanCerrados()
        {
            var result = _ingresoService.ObtenerIngresos();

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpGet, Route("por-estado/{estadoId}")]
        public IActionResult GetPorEstado([FromRoute] int estadoId)
        {
            var result = _ingresoService.ObtenerIngresos(estadoId);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpPost]
        public IActionResult Post([FromBody] IngresoDto ingresoDto)
        {
            var result = _ingresoService.GuardarIngreso(ingresoDto);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

    }
}
