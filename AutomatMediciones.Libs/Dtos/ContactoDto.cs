using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class ContactoDto
    {
        public string ContactoId { get; set; }
        public string EmpresaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public string Saludo { get; set; }
        public int Genero { get; set; }
        public ICollection<CorreoElectronicoDto> CorreosElectronicos { get; set; }
    }
}
