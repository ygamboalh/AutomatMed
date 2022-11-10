using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class ArbolCarpetaDto
    {
        public string RecId { get; set; }
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public int Orden { get; set; }
        public int Nivel { get; set; }
        public string RefId { get; set; }
        public string IdPadre { get; set; }

        public List<ArbolCarpetaDto> ArbolCarpetas { get; set; }

    }
}
