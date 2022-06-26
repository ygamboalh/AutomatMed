using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class ModeloDto
    {
        public int ModeloId { get; set; }
        public string Descripcion { get; set; }
        public List<TipoCeldaModeloDto> TipoCeldaModelo { get; set; }


        public ModeloDto()
        {
            TipoCeldaModelo = new List<TipoCeldaModeloDto>();
        }
    }
}
