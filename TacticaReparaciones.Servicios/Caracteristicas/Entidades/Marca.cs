using System.Collections.Generic;

namespace TacticaReparaciones.Servicios.Caracteristicas.Entidades
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Descripcion { get; set; }
        public int TipoInstrumentoId { get; set; }
        public ICollection<Modelo> Modelos { get; set; }
        public ICollection<Instrumento> Instrumentos { get; set; }
        public virtual TipoInstrumento TipoInstrumento { get; set; }
    }
}
