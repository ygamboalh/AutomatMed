using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TacticaReparaciones.Servicios.Caracteristicas.Dtos
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
        public int EstadoId { get; set; }
        public int TipoTrabajoId { get; set; }
        public int Prioridad { get; set; }
        public string Comentarios { get; set; }
    }
}
