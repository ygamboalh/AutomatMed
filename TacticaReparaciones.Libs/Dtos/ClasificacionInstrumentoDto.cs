using System;
using System.Collections.Generic;
using System.Text;

namespace TacticaReparaciones.Libs.Dtos
{
    public class ClasificacionInstrumentoDto
    {
        public int ClasificacionId { get; set; }
        public int TipoInstrumentoId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int PeriodoDeCalibracion { get; set; }
        public bool Activo { get; set; }
        public ICollection<TipoInstrumentoDto>TipoInstrumento { get; set; }
        public ICollection<ModeloDto> Modelo { get; set; }
        public ICollection<MarcaDto> Marca { get; set; }
    }
}
