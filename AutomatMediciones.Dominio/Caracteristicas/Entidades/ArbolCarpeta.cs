namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class ArbolCarpeta
    {
        public string RecId { get; set; }
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public int Orden { get; set; }
        public int Nivel { get; set; }
        public string IdRef { get; set; }
        public string IdPadre { get; set; }
    }
}
