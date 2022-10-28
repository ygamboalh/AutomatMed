using System.Collections.Generic;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class UnidadMedida
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public string Abreviatura { get; set; }

        public List<VariableDeMedicion> VariablesDeMedicion { get; set; }
    }
}
