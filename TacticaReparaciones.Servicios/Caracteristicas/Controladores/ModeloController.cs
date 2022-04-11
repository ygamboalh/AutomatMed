﻿using Microsoft.AspNetCore.Mvc;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using AutomatMediciones.Libs.Dtos;
using AutomatMediciones.Servicios.Caracteristicas.Servicios;

namespace AutomatMediciones.Servicios.Caracteristicas.Controladores
{
    [Route("modelos")]
    [ApiController]
    public class ModeloController : ControllerBase
    {
        private readonly ModeloService _modeloService;

        public ModeloController(ModeloService modeloService)
        {
            _modeloService = modeloService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _modeloService.ObtenerModelos();

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ModeloDto modeloDto)
        {
            var result = _modeloService.RegistrarModelo(modeloDto);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody] ModeloDto modeloDto)
        {
            var result = _modeloService.ActualizarModelo(modeloDto);

            if (result.Type != TypeResponse.Ok)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }
    }
}
