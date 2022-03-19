using System.Collections.Generic;

namespace TacticaReparaciones.Libs.Dtos
{
    public class ModeloDto
    {
        public int ModeloId { get; set; }
        public string Descripcion { get; set; }
        public int MarcaId { get; set; }
        public ICollection<InstrumentoDto> Instrumentos { get; set; }
    }
}
