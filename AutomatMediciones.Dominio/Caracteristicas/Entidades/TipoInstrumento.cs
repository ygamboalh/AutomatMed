using System.Collections.Generic;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class TipoInstrumento
    {
        public int TipoInstrumentoId { get; set; }
        public string Descripcion { get; set; }
        public string Resumen { get; set; }
        public string Metodologia { get; set; }
        public ICollection<TipoInstrumentoVariable> TiposDeInstrumentoVariables { get; set; }
    }
}
