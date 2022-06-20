﻿using AutomatMediciones.DesktopApp.Enums;
using AutomatMediciones.DesktopApp.Helpers;
using System.Drawing;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Componentes.Menu
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

            this.btnDiagnosticos.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
            this.btnDiagnosticosNoExpandido.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");

            this.btnTiposDeInstrumetnos.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
            this.btnTipoInstrumentoSimplificado.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
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
            this.Size = new Size(this.MinimumSize.Width + 5, this.Height);
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

        private void btnDiagnosticos_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Diagnosticos);
        }

        private void btnTiposDeInstrumetnos_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Configuracion);
        }

        private void btnCertificados_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Certificados);
        }

        public void AccionesBotonConfiguracion(bool activo)
        {
            pnlCertificados.Visible = activo;
            pnlClasificaciones.Visible = activo;
            pnlMarcas.Visible = activo;
            pnlModelos.Visible = activo;
            pnlTipoInstrumento.Visible = activo;
            pnlVariableMedicion.Visible = activo;
            pnlPatrones.Visible = activo;
            pnlInstrumento.Visible = activo;
            pnlCeldas.Visible = activo;
        }

        private void cmdClasificacionInstrumentos_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Clasificaciones);
        }

        private void cmdMarcas_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Marcas);
        }

        private void cmdModelos_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Modelos);
        }

        private void cmdInstrumentos_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Instrumentos);
        }

        private void cmdPatrones_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Patrones);
        }

        private void btnTiposDeInstrumento_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.TiposInstrumentos);
        }

        private void cmdVariablesDeMedicion_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.VariablesMedicion);
        }

        private void btnCeldas_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Celdas);
        }
    }
}
