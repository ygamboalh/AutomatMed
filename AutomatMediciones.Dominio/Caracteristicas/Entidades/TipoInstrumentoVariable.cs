namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class TipoInstrumentoVariable
    {
        public int TipoInstrumentoVariableId { get; set; }
        public int TipoInstrumentoId { get; set; }
        public int VariableMedicionId { get; set; }
        public VariableDeMedicion VariableDeMedicion { get; set; }
        public TipoInstrumento TipoInstrumento { get; set; }
    }
}
