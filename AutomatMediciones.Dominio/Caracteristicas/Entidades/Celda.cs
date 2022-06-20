using System;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class Celda
    {
        public int Id { get; set; }
        public int TipoCeldaId { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public string NumeroSerie { get; set; }
        public string Estado { get; set; }

        public TipoCelda TipoCelda { get; set; }
    }
}
