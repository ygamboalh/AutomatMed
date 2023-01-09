using AutomatMediciones.DesktopApp.Enums;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Libs.Dtos;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;

namespace AutomatMediciones.DesktopApp.Componentes.Menu
{
    public partial class cmpItemMenu : DevExpress.XtraEditors.XtraUserControl
    {

        public delegate void MenuClick(IndiceMenu indiceMenu, MenuDto menuDto);
        public event MenuClick OnMenuClick;

        public MenuDto Menu { get; set; }
        public cmpItemMenu()
        {
            InitializeComponent();

            btnMenu.Click += btnMenuClick;
        }

        private void btnMenuClick(object sender, EventArgs e)
        {
            OnMenuClick?.Invoke((IndiceMenu)Menu.IndiceMenu, Menu );
        }

        public void ConstruirControl()
        {
            pnlMenuHijo.Visible = Menu.MenuPadre != 0 ? true : false;
            btnMenu.Text = Menu.Descripcion;
            btnMenu.IconChar = (IconChar)Enum.Parse(typeof(IconChar), Menu.Icono);
            btnMenu.BackColor = ColorHelper.ObtenerColorEnRGB(Menu.Color);
        }

        
    }
}
