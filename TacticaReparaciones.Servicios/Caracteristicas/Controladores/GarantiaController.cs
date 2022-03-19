using Microsoft.AspNetCore.Mvc;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TacticaReparaciones.Servicios.Caracteristicas.Servicios;

namespace TacticaReparaciones.Servicios.Caracteristicas.Controladores
{
    [Route("garantias")]
    [ApiController]
    public class GarantiaController : ControllerBase
    {
        private readonly GarantiaService _garantiaService;

        public GarantiaController(GarantiaService garantiaService)
        {
            _garantiaService = garantiaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _garantiaService.ObtenerGarantias();

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }
    }
}
