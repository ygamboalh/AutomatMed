using System.Collections.Generic;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class VariableInstrumento
    {
        public int VariableInstrumentoId { get; set; }
        public int VariableMedicionId { get; set; }
        public int InstrumentoId { get; set; }
        public bool TieneAlarma { get; set; }
        public decimal? AlarmaBaja { get; set; }
        public decimal? AlarmaAlta { get; set; }
        public decimal? AlarmaStel { get; set; }
        public decimal? AlarmaTwa { get; set; }
        public bool Activo { get; set; }
        public VariableDeMedicion VariableDeMedicion { get; set; }
        public ICollection<VariableCertificado> VariablesCertificado { get; set; }

        public bool EsValido(out string mensaje)
        {
            if (VariableMedicionId == 0)
            {
                mensaje = "Es necesario ingresar una variable de medición para poder continuar.";
                return false;
            }

            if (InstrumentoId == 0)
            {
                mensaje = "Es necesario ingresar un instrumento para poder continuar.";
                return false;
            }

            mensaje = "Ok";
            return true;
        }
    }
}
