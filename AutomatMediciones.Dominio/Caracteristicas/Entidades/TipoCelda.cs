using System.Collections.Generic;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class TipoCelda
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int VariableMedicionId { get; set; }
        public VariableDeMedicion VariableDeMedicion { get; set; }
        public ICollection<TipoCeldaModelo> TiposDeCeldaModelo { get; set; }
    }
}
