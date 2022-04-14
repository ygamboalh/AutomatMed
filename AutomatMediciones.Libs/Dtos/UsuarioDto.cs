using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatMediciones.Libs.Dtos
{
    public class UsuarioDto
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
    }
}
