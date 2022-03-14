using TacticaReparaciones.DesktopApp.Enums;

namespace TacticaReparaciones.DesktopApp.Helpers
{
    public static class EncabezadoPantallaHelper
    {
        public static string ObtenerTituloPantallaSegunMenu(IndiceMenu indiceMenu)
        {
            string tituloPantalla = "";
            switch (indiceMenu)
            {
                case IndiceMenu.Ingresos:
                    tituloPantalla = "Ingresos";
                    break;
                default:
                    tituloPantalla = "Opción Genérica";
                    break;
            }

            return tituloPantalla;
        }
    }
}
