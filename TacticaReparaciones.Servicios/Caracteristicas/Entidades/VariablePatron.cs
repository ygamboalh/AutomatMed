using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TacticaReparaciones.Servicios.Caracteristicas.Entidades
{
    public class VariablePatron
    {
        public int VariablePatronId { get; set; }
        public int VariableMeicionId { get; set; }
        public int PatronId { get; set; }
        public decimal ValorPatron { get; set; }
        public decimal Tolerancia { get; set; }
    }
}
