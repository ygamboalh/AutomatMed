using System;
using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class InstrumentoDto
    {
        public int InstrumentoId { get; set; }
        public string Descripcion { get; set; }
        public int ClasificacionId { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime? FechaCompraFabricante { get; set; }
        public DateTime? FechaCompraCliente { get; set; }
        public DateTime? FechaUltimaCalibracion { get; set; }
        public int? PeriodoCalibracion { get; set; }
        public DateTime? FechaProximaCalibracion { get; set; }
        public int Garantia { get; set; }
        public string EmpresaId { get; set; }
        public string NombreEmpresa { get; set; }
        public string Comentarios { get; set; }
        public ClasificacionInstrumentoDto Clasificacion { get; set; }
        public ICollection<CeldaInstrumentoDto> CeldasInstrumentos { get; set; }
        public ICollection<VariableInstrumentoDto> VariablesInstrumentos { get; set; }

        public InstrumentoDto()
        {
            CeldasInstrumentos = new List<CeldaInstrumentoDto>();
        }
    }
}
