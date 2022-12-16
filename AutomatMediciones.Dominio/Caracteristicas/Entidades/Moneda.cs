using System.Collections.Generic;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class Moneda
    {
        public string RecID { get; set; }
        public int Numero { get; set; }
        public string Simbolo { get; set; }
        public string Descripcion { get; set; }
        public List<Presupuesto> Presupuestos { get; set; }
    }
}
