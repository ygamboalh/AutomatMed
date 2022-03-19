using System.Collections.Generic;

namespace TacticaReparaciones.Libs.Dtos
{
    public class MarcaDto
    {
        public int MarcaId { get; set; }
        public string Descripcion { get; set; }
        public int TipoInstrumentoId { get; set; }
        public ICollection<ModeloDto> Modelos { get; set; }
        public ICollection<InstrumentoDto> Instrumentos { get; set; }
    }
}
