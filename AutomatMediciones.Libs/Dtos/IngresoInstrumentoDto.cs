namespace AutomatMediciones.Libs.Dtos
{
    public class IngresoInstrumentoDto
    {
        public int IngresoInstrumentoId { get; set; }
        public int IngresoId { get; set; }
        public int InstrumentoId { get; set; }
        public string Comentarios { get; set; }
        public bool Activo { get; set; }
        public string NumeroServicioTecnico { get; set; }
        public IngresoDto Ingreso { get; set; }
        public InstrumentoDto Instrumento { get; set; }
    }
}
