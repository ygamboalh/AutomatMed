using System.Collections.Generic;

namespace TacticaReparaciones.Servicios.Caracteristicas.Entidades
{
    public class TipoInstrumento
    {
        public int TipoInstrumentoId { get; set; }
        public string Descripcion { get; set; }
        ICollection<Marca> Marcas { get; set; }
        ICollection<PeriodoDeCalibracion> PeriodosDeCalibracion { get; set; }
        ICollection<PeriodoDeCalibracion> Garantias { get; set; }
    }
}
