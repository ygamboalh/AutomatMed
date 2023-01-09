using AutomatMediciones.DesktopApp.Enums;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Libs.Dtos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Componentes.Menu
{
    public partial class cmpMenu : UserControl
    {
        public cmpMenu()
        {
            InitializeComponent();
            Menu = new List<MenuDto>();
        }

        public List<MenuDto> Menu { get; set; }

        public delegate void MenuSeleccionado(IndiceMenu indiceMenu, MenuDto menuDto = null, List<MenuDto> menuCompleto = null);
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

            Menu.ForEach(itemMenu =>
            {
                cmpItemMenu item = new cmpItemMenu();
                item.OnMenuClick += OnItemMenuClick;
                item.Menu = itemMenu;
                item.ConstruirControl();
                item.Dock = DockStyle.Top;
                item.TabIndex = itemMenu.Posicion - 1;
                pnlItems.Controls.Add(item);
            });
        }

        private void OnItemMenuClick(IndiceMenu indiceMenu, MenuDto menuDto)
        {
            OnMenuSeleccionado?.Invoke(indiceMenu, menuDto, Menu);
        }

        private void EstablecerColorBotonesMenu()
        {
            this.cmdIngresosSimple.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
            this.btnDiagnosticosNoExpandido.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
            this.btnCertificadosContraido.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
            this.btnCeldContraida.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
            this.btnPatronContraido.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
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

        private void btnCertificados_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Certificados);
        }

        public void AccionesBotonConfiguracion(bool activo, MenuDto menuPadre = null, List<MenuDto>menuCompleto = null)
        {
            if (activo)
            {          
                    menuPadre.Items.ForEach(itemDetalle =>
                    {
                        cmpItemMenu itemDetail = new cmpItemMenu();
                        itemDetail.OnMenuClick += OnItemMenuClick;
                        itemDetail.Menu = itemDetalle;
                        itemDetail.Name = itemDetalle.Descripcion;
                        itemDetail.ConstruirControl();
                        itemDetail.Dock = DockStyle.Top;
                        itemDetail.TabIndex = pnlItems.Controls.Count + 1;
                    
                        pnlItems.Controls.Add(itemDetail);
                        itemDetail.BringToFront();

                    });           
            }
            else{
                menuPadre.Items.ForEach(itemMenu =>
                {
                    cmpItemMenu item = new cmpItemMenu();
                    item.OnMenuClick += OnItemMenuClick;
                    item.Menu = itemMenu;
                    item.Name = itemMenu.Descripcion;
                    item.ConstruirControl();

                    pnlItems.Controls.RemoveByKey(item.Name);

                });
            }
        }

    
        private void cmdPatrones_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Patrones);
        }

        private void btnCeldas_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.Celdas);
        }

        private void cmdNuevoPreIngresoSimple_Click(object sender, System.EventArgs e)
        {
            OnMenuSeleccionado?.Invoke(IndiceMenu.PreIngreso);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navigationMenus_Click(object sender, EventArgs e)
        {

        }
    }
}
