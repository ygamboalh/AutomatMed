using System;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class CeldaInstrumento
    {
        public int Id { get; set; }
        public int InstrumentoId { get; set; }
        public int CeldaId { get; set; }
        public DateTime? FechaColocacion { get; set; }
        public DateTime? FechaExtraccion { get; set; }
        public bool Activo { get; set; }

        public Celda Celda { get; set; }
    }
}
