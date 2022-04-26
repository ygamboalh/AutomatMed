namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class ConfiguracionNotificacion
    {
        public int ConfiguracionId { get; set; }
        public string Servidor { get; set; }
        public int Puerto { get; set; }
        public string CorreoOrigen { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Asunto { get; set; }
        public bool Activo { get; set; }
    }
}
