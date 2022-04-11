using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class TipoInstrumentoDto
    {
        public int TipoInstrumentoId { get; set; }
        public string Descripcion { get; set; }
        public string Resumen { get; set; }
        public string Metodologia { get; set; }
        public ICollection<TipoInstrumentoVariableDto> TiposDeInstrumentoVariables { get; set; }
    }
}
