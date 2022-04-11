using Microsoft.AspNetCore.Mvc;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using AutomatMediciones.Servicios.Caracteristicas.Servicios;

namespace AutomatMediciones.Servicios.Caracteristicas.Controladores
{
    [Route("empresas")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly EmpresaService _empresaService;

        public EmpresaController(EmpresaService empresaService)
        {
            _empresaService = empresaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _empresaService.ObtenerEmpresas();

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }
    }
}
