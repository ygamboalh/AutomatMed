namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class ClasificacionInstrumento
    {
        public int ClasificacionId { get; set; }
        public int TipoInstrumentoId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int PeriodoDeCalibracion { get; set; }
        public bool Activo { get; set; }
        public TipoInstrumento TipoInstrumento { get; set; }
        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }
    }
}
