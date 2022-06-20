using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class CeldaInstrumento
    {
        public int Id { get; set; }
        public int InstrumentoId { get; set; }
        public int CeldaId { get; set; }
        public DateTime? FechaColocacion { get; set; }
        public DateTime? FechaExtraccion { get; set; }
    }
}
