using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatMediciones.Libs.Dtos
{
    public class CeldaDto
    {
        public int Id { get; set; }
        public int TipoCeldaId { get; set; }
        public DateTime? FechaAdquisicion { get; set; }
        public DateTime? FechaFabricacion { get; set; }
        public string NumeroSerie { get; set; }
        public string Estado { get; set; }

        public TipoCeldaDto TipoCelda { get; set; }
    }
}
