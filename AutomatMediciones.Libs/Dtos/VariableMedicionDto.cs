﻿using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class VariableMedicionDto
    {
        public int VariableMedicionId { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string DescripcionCorta { get; set; }
        public int TipoInstrumentoId { get; set; }
        public decimal PrimerValorRango { get; set; }
        public decimal SegundoValorRango { get; set; }
        public decimal Tolerancia { get; set; }
        public int UnidadMedidaId { get; set; }
        public UnidadMedidaDto UnidadMedida { get; set; }
        public ICollection<TipoInstrumentoVariableDto> TiposDeInstrumentoVariables { get; set; }
        public ICollection<VariableInstrumentoDto> VariablesInstrumentos { get; set; }
        public ICollection<VariablePatronDto> VariablesPatrones { get; set; }
        public ICollection<TipoCeldaDto> TiposDeCelda { get; set; }
    }
}
