using System.Collections.Generic;

namespace TacticaReparaciones.Servicios.Caracteristicas.Entidades
{
    public class TipoInstrumento
    {
        public int TipoInstrumentoId { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Marca> Marcas { get; set; }
        public ICollection<Instrumento> Instrumentos { get; set; }
    }
}
