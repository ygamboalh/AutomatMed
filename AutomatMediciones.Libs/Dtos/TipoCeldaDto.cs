using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatMediciones.Libs.Dtos
{
    public class TipoCeldaDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int VariableMedicionId { get; set; }
    }
}
