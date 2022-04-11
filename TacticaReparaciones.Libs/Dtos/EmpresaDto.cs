using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class EmpresaDto
    {
        public string EmpresaId { get; set; }
        public string NombreEmpresa { get; set; }
        public ICollection<ContactoDto> Contactos { get; set; }
    }
}
