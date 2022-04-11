namespace AutomatMediciones.Libs.Dtos
{
    public class VariableInstrumentoDto
    {
        public int VariableInstrumentoId { get; set; }
        public int VariableMedicionId { get; set; }
        public int InstrumentoId { get; set; }
        public bool TieneAlarma { get; set; }
        public decimal? AlarmaBaja { get; set; }
        public decimal? AlarmaAlta { get; set; }
        public decimal? AlarmaStel { get; set; }
        public decimal? AlarmaTwa { get; set; }
    }
}
