namespace AutomatMediciones.Libs.Dtos
{
    public class TipoInstrumentoVariableDto
    {
        public int TipoInstrumentoVariableId { get; set; }
        public int TipoInstrumentoId { get; set; }
        public int VariableMedicionId { get; set; }
        public TipoInstrumentoDto TipoInstrumento { get; set; }
        public VariableMedicionDto VariableDeMedicion { get; set; }
    }
}
