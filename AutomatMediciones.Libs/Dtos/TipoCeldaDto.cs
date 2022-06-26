using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class TipoCeldaDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int VariableMedicionId { get; set; }

        public VariableMedicionDto VariableDeMedicion { get; set; }
        public ICollection<TipoCeldaModeloDto> TiposDeCeldaModelo { get; set; }
    }
}
