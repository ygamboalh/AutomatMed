using System.Collections.Generic;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class Modelo
    {
        public int ModeloId { get; set; }
        public string Descripcion { get; set; }

        public List<TipoCeldaModelo> TipoCeldaModelo { get; set; }
    }
}
