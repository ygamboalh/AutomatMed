using System;
using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class PatronDto
    {
        public int PatronId { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public string Link { get; set; }

        public ICollection<VariablePatronDto> VariablesPatrones { get; set; }
    }
}
