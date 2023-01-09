using System;
using System.Collections.Generic;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class Menu
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int MenuPadre { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAgrega { get; set; }
        public int Posicion { get; set; }
        public string Icono { get; set; }
        public string Color { get; set; }
        public int IndiceMenu { get; set; }

        public Menu Padre { get; set; }
        public List<Menu> Items { get; set; }
    }
}
