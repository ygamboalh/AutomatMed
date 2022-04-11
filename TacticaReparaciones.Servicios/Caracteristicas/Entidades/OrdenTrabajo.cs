using System;

namespace AutomatMediciones.Servicios.Caracteristicas.Entidades
{
    public class OrdenTrabajo
    {
        public int OrdenTrabajoId { get; set; }
        public int IngresoInstrumentoId { get; set; }
        public int TipoOrdenTrabajoId { get; set; }
        public int Prioridad { get; set; }
        public string Comentarios { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal? TiempoConsumido { get; set; }
        public bool Activo { get; set; }
        public int EstadoOrdenTrabajoId { get; set; }
        public decimal? TiempoEstimado { get; set; }
        public string Diagnostico { get; set; }

    }
}
