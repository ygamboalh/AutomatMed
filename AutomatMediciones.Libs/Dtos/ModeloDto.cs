using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class ModeloDto
    {
        public int ModeloId { get; set; }
        public string Descripcion { get; set; }
        public ICollection<TipoCeldaDto> TiposDeCelda { get; set; }


        public ModeloDto()
        {
            TiposDeCelda = new List<TipoCeldaDto>();
        }
    }
}
