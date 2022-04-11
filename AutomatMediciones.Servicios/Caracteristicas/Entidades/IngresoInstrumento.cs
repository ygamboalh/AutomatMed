namespace AutomatMediciones.Servicios.Caracteristicas.Entidades
{
    public class IngresoInstrumento
    {
        public int IngresoInstrumentoId { get; set; }
        public int IngresoId { get; set; }
        public int InstrumentoId { get; set; }
        public bool Activo { get; set; }
        public Ingreso Ingreso { get; set; }
        public Instrumento Instrumento { get; set; }
    }
}
