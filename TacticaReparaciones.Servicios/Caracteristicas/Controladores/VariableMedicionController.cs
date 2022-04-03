using Microsoft.AspNetCore.Mvc;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using TacticaReparaciones.Libs.Dtos;
using TacticaReparaciones.Servicios.Caracteristicas.Servicios;

namespace TacticaReparaciones.Servicios.Caracteristicas.Controladores
{
    [Route("variables-de-medicion")]
    [ApiController]
    public class VariablesMedicionController : ControllerBase
    {
        private readonly VariableMedicionService _variablesMedicionService;

        public VariablesMedicionController(VariableMedicionService variableMedicionService)
        {
            _variablesMedicionService = variableMedicionService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _variablesMedicionService.ObtenerVariablesDeMedicionActivas();

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpPost]
        public IActionResult Post([FromBody] VariableMedicionDto variableMedicionDto)
        {
            var result = _variablesMedicionService.RegistrarVariableDeMedicion(variableMedicionDto);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpPut]
        public IActionResult Put([FromBody] VariableMedicionDto variableMedicionDto)
        {
            var result = _variablesMedicionService.ActualizarVariableDeMedicion(variableMedicionDto);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }
    }
}
