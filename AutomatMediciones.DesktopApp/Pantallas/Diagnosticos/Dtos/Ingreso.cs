using System;
using System.Collections.Generic;

namespace AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos
{
    public class Ingreso
    {
        public int Id { get; set; }
        public int Prioridad { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreEmpresa { get; set; }
        public string Estado { get; set; }
        public List<IngresoInstrumento> Instrumentos { get; set; }
    }
}
