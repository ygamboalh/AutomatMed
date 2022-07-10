namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public string Correo { get; set; }
        public string EnlaceFirmaDigital { get; set; }
        public bool CopiaEnNotificaciones { get; set; }
    }
}
