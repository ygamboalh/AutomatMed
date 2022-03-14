using Newtonsoft.Json;
using System.Collections.Generic;

namespace TacticaReparaciones.DesktopApp.Helpers
{
    public static class JsonHelpers
    {
        public static List<TEntity> Deserializes<TEntity>(this string value) where TEntity : class
        {
            return JsonConvert.DeserializeObject<List<TEntity>>(value);
        }
    }
}
