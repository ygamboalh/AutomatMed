using System;

namespace TacticaReparaciones.Servicios.Caracteristicas.Entidades
{
    public class Patron
    {
        public int PatronId { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public string Link { get; set; }
    }
}
