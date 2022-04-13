namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class IngresoInstrumento
    {
        public int IngresoInstrumentoId { get; set; }
        public int IngresoId { get; set; }
        public int InstrumentoId { get; set; }
        public bool Activo { get; set; }
        public string Comentarios { get; set; }
        public string NumeroServicioTecnico { get; set; }
        public Ingreso Ingreso { get; set; }
        public Instrumento Instrumento { get; set; }
    }
}
