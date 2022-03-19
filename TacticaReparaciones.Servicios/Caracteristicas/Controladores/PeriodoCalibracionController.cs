using Microsoft.AspNetCore.Mvc;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TacticaReparaciones.Servicios.Caracteristicas.Servicios;

namespace TacticaReparaciones.Servicios.Caracteristicas.Controladores
{
    [Route("periodos-de-calibracion")]
    [ApiController]
    public class PeriodoCalibracionController : ControllerBase
    {
        private readonly PeriodoCalibracionService _periodoCalibracionService;

        public PeriodoCalibracionController(PeriodoCalibracionService periodoCalibracionService)
        {
            _periodoCalibracionService = periodoCalibracionService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _periodoCalibracionService.ObtenerPeriodosDeCalibracion();

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

    }
}
