using System;
using System.Collections.Generic;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class Patron
    {
        public int PatronId { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public string Link { get; set; }

        public ICollection<VariablePatron> VariablesPatrones { get; set; }
        public ICollection<VariableCertificado> VariablesCertificado { get; set; }
    }
}
