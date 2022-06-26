using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class TipoCelda
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int VariableMedicionId { get; set; }
        public VariableDeMedicion VariableDeMedicion { get; set; }
    }
}
