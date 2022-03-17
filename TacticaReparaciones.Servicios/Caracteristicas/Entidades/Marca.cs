using System.Collections.Generic;

namespace TacticaReparaciones.Servicios.Caracteristicas.Entidades
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Descripcion { get; set; }
        public int TipoInstrumentoId { get; set; }
        ICollection<Modelo> Modelos { get; set; }
    }
}
