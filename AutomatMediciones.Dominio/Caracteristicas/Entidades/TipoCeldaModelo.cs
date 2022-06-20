using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class TipoCeldaModelo
    {
        public int Id { get; set; }
        public int TipoCeldaId { get; set; }
        public int ModeloId { get; set; }
    }
}
