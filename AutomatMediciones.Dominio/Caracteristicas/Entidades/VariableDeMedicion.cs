using System.Collections.Generic;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class VariableDeMedicion
    {
        public int VariableMedicionId { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string DescripcionCorta { get; set; }
        public decimal PrimerValorRango { get; set; }
        public decimal SegundoValorRango { get; set; }
        public decimal Tolerancia { get; set; }
        public ICollection<TipoInstrumentoVariable> TiposDeInstrumentoVariables { get; set; }
        public ICollection<VariableInstrumento> VariablesInstrumentos { get; set; }
        public ICollection<VariablePatron> VariablesPatrones { get; set; }
        public ICollection<TipoCelda> TiposDeCeldas { get; set; }
    }
}
