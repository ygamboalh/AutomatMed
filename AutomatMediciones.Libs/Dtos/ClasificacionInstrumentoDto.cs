namespace AutomatMediciones.Libs.Dtos
{
    public class ClasificacionInstrumentoDto
    {
        public int ClasificacionId { get; set; }
        public int TipoInstrumentoId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int PeriodoDeCalibracion { get; set; }
        public bool Activo { get; set; }
        public TipoInstrumentoDto TipoInstrumento { get; set; }
        public ModeloDto Modelo { get; set; }
        public MarcaDto Marca { get; set; }
    }
}
