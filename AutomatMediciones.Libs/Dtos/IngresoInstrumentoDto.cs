using System;

namespace AutomatMediciones.Libs.Dtos
{
    public class IngresoInstrumentoDto
    {
        public int IngresoInstrumentoId { get; set; }
        public string NumeroServicioTecnico { get; set; }
        public int IngresoId { get; set; }
        public int InstrumentoId { get; set; }
        public int TipoTrabajoId { get; set; }
        public int EstadoId { get; set; }
        public int Prioridad { get; set; }
        public string Comentarios { get; set; }
        public string Diagnostico { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime FechaEntregaRequerida { get; set; }
        public TimeSpan? TiempoConsumido { get; set; }
        public int? ResponsableId { get; set; }
        public bool Activo { get; set; }
        public TipoTrabajoDto TipoTrabajo { get; set; }
        public EstadoDto Estado { get; set; }
        public IngresoDto Ingreso { get; set; }
        public InstrumentoDto Instrumento { get; set; }
        public UsuarioDto Responsable { get; set; }
    }
}
