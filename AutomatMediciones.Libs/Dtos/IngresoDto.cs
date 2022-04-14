using System;
using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class IngresoDto
    {
        public int IngresoId { get; set; }
        public string EmpresaId { get; set; }
        public string NombreEmpresa { get; set; }
        public string ContactoId { get; set; }
        public string NombreContacto { get; set; }
        public string CorreoElectronicoId { get; set; }
        public string DireccionCorreoElectronico { get; set; }
        public string CuerpoCorreo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioResponsableId { get; set; }
        public bool Activo { get; set; }
        public ICollection<IngresoInstrumentoDto> IngresosInstrumentos { get; set; }
    }
}
