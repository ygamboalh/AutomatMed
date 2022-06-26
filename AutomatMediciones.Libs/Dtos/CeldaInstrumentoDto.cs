using System;

namespace AutomatMediciones.Libs.Dtos
{
    public class CeldaInstrumentoDto
    {
        public int Id { get; set; }
        public int InstrumentoId { get; set; }
        public int CeldaId { get; set; }
        public DateTime? FechaColocacion { get; set; }
        public DateTime? FechaExtraccion { get; set; }
    }
}
