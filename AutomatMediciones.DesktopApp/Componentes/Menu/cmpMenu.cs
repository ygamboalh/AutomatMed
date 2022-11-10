using AutomatMediciones.DesktopApp.Enums;
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

            this.btnConfiguracion.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");

            this.btnCertificados.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
            this.btnCertificadosContraido.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");

            this.btnCeldas.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
            this.btnCeldContraida.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");

            this.btnPatrones.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
            this.btnPatronContraido.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");

            this.btnCreacionPreIngreso.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
            this.cmdNuevoPreIngresoSimple.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");



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
                return;
            }

            AccionesConBotonContraido();

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
            OnMenuSeleccionado?.Invoke(IndiceMenu.TiposInstrumentos);
        }

        private void btnCertificados_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Certificados);
        }

        public void AccionesBotonConfiguracion(bool activo)
        {
            pnlTipoInstrumento.Visible = activo;
            pnlMarcas.Visible = activo;
            pnlModelos.Visible = activo;
            pnlInstrumento.Visible = activo;
            pnlClasificaciones.Visible = activo;

            pnlSeparador.Visible = activo;

            pnlTipoCelda.Visible = activo;
            pnlVariableMedicion.Visible = activo;
            pnlUsuarios.Visible = activo;
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

        private void btnConfiguracion_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Configuracion);
        }

        private void cmdUsuarios_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Usuarios);
        }

        private void cmdTipoCelda_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.TiposDeCelda);
        }

        private void btnCreacionPreIngreso_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.PreIngreso);
        }

        private void cmdNuevoPreIngresoSimple_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.PreIngreso);
        }

        private void btnPresupuestos_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Presupuestos);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
