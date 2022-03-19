using System.Collections.Generic;

namespace TacticaReparaciones.Servicios.Caracteristicas.Entidades
{
    public class Modelo
    {
        public int ModeloId { get; set; }
        public string Descripcion { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        public IEnumerable<Instrumento>  Instrumentos { get; set; }

    }
}
