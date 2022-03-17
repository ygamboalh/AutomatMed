using System.Collections.Generic;

namespace TacticaReparaciones.Libs.Dtos
{
    public class TipoInstrumentoDto
    {
        public int TipoInstrumentoId { get; set; }
        public string Descripcion { get; set; }
        public ICollection<MarcaDto> Marcas { get; set; }
        public ICollection<PeriodoCalibracionDto> PeriodosDeCalibracion { get; set; }
        public ICollection<GarantiaDto> Garantias { get; set; }
    }
}
