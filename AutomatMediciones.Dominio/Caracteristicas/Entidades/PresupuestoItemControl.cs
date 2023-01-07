using System;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class PresupuestoItemControl
    {
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int PresupuestoControlId { get; set; }
    }
}
