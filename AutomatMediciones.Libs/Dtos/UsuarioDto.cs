namespace AutomatMediciones.Libs.Dtos
{
    public class UsuarioDto
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public string Correo { get; set; }
        public string EnlaceFirmaDigital { get; set; }
        public bool CopiaEnNotificaciones { get; set; }
    }
}
