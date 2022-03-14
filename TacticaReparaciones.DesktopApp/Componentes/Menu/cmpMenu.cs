﻿using System.Drawing;
using System.Windows.Forms;
using TacticaReparaciones.DesktopApp.Enums;
using TacticaReparaciones.DesktopApp.Helpers;

namespace TacticaReparaciones.DesktopApp.Componentes.Menu
{
    public partial class cmpMenu : UserControl
    {
        public cmpMenu()
        {
            InitializeComponent();

        }

        public delegate void MenuSeleccionado(IndiceMenu indiceMenu);
        public event MenuSeleccionado OnMenuSeleccionado;

        bool expandirMenu;
        public bool ExpandirMenu
        {
            get
            {
                return expandirMenu;
            }
            set
            {
                expandirMenu = value;
                AccionarTamanioMenu();
            }
        }

        public void InicializarControl()
        {
            ExpandirMenu = true;
            EstablecerColorFondoMenu();
            EstablecerColorBotonesMenu();

            cmpLogo1.InicializarControl();
        }

        private void EstablecerColorBotonesMenu()
        {
            this.cmdIngresos.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
            this.cmdIngresosSimple.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
        }

        private void EstablecerColorFondoMenu()
        {
            this.BackColor = ColorHelper.ObtenerColorEnRGB("Primary200");
        }

        private void btnExpandirMenu_Click(object sender, System.EventArgs e)
        {
            ExpandirMenu = !ExpandirMenu;
        }

        private void EstablecerMaximoTamanioDelMenu()
        {
            this.Size = new Size(this.MaximumSize.Width, this.Height);
        }

        private void ExpandirBotonMenu()
        {
            this.btnExpandirMenu.Dock = DockStyle.Fill;
        }

        private void AlinearBotonMenuALaIzquierda()
        {
            this.btnExpandirMenu.Dock = DockStyle.Left;
        }

        private void EstablecerMinimoTamanioDelMenu()
        {
            this.Size = new Size(this.MinimumSize.Width, this.Height);
        }

        private void HabilitarMenuSinTitulos()
        {
            this.navigationMenus.SelectedPage = pageMenuContraido;
        }

        private void HabilitarMenuConTitulos()
        {
            this.navigationMenus.SelectedPage = pageMenuExtendido;
        }

        private void AccionesConBotonExpandido()
        {
            EstablecerMaximoTamanioDelMenu();
            HabilitarMenuConTitulos();
            AlinearBotonMenuALaIzquierda();
        }

        private void AccionesConBotonContraido()
        {
            EstablecerMinimoTamanioDelMenu();
            HabilitarMenuSinTitulos();
            ExpandirBotonMenu();
        }

        private void AccionarTamanioMenu()
        {
            if (ExpandirMenu)
            {
                AccionesConBotonExpandido();
            }
            else
            {
                AccionesConBotonContraido();
            }
        }

        private void cmdIngresos_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Ingresos);
        }
    }
}
