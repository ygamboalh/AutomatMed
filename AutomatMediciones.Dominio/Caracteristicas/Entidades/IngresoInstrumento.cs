using System;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class IngresoInstrumento
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
        public DateTime? FechaQueEstaraDisponible { get; set; }
        public DateTime FechaEntregaRequerida { get; set; }
        public TimeSpan? TiempoConsumido { get; set; }
        public int? ResponsableId { get; set; }
        public bool Activo { get; set; }
        public int? PreIngresoId { get; set; }

        public TipoTrabajo TipoTrabajo { get; set; }
        public Estado Estado { get; set; }
        public Ingreso Ingreso { get; set; }
        public Instrumento Instrumento { get; set; }
        public Usuario Responsable { get; set; }

        public bool EsValido(out string mensaje)
        {
            if (TipoTrabajoId == 0)
            {
                mensaje = "Es necesario ingresar un tipo de trabajo para guardar el el ingreso.";
                return false;
            }

            if (Prioridad == 0)
            {
                mensaje = "Es necesario ingresar una prioridad para guardar el ingreso.";
                return false;
            }

            if (InstrumentoId == 0)
            {
                mensaje = "Es necesario ingresar un instrumento para guardar el ingreso.";
                return false;
            }

            mensaje = "Ok";
            return true;
        }
    }
}
