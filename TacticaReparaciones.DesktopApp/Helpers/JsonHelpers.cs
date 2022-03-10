using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
