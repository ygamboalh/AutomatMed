namespace AutomatMediciones.Libs.Dtos
{
    public class ConfiguracionNotificacionDto
    {
        public int ConfiguracionId { get; set; }
        public string CorreoOrigen { get; set; }
        public string Nombre { get; set; }
        public string Asunto { get; set; }
        public string ApiKey { get; set; }
        public bool Activo { get; set; }
    }
}
