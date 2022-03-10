
namespace TacticaReparaciones.DesktopApp.Componentes.Menu
{
    partial class cmpMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmpLogo1 = new TacticaReparaciones.DesktopApp.Componentes.Menu.cmpLogo();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlExpandirMenu = new System.Windows.Forms.Panel();
            this.btnExpandirMenu = new FontAwesome.Sharp.IconButton();
            this.cmdIngresos = new FontAwesome.Sharp.IconButton();
            this.cmdIngresosSimple = new FontAwesome.Sharp.IconButton();
            this.navigationMenus = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageMenuExtendido = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageMenuContraido = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlLogo.SuspendLayout();
            this.pnlExpandirMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationMenus)).BeginInit();
            this.navigationMenus.SuspendLayout();
            this.pageMenuExtendido.SuspendLayout();
            this.pageMenuContraido.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmpLogo1
            // 
            this.cmpLogo1.BackColor = System.Drawing.Color.White;
            this.cmpLogo1.Location = new System.Drawing.Point(67, 22);
            this.cmpLogo1.MaximumSize = new System.Drawing.Size(172, 159);
            this.cmpLogo1.MinimumSize = new System.Drawing.Size(172, 159);
            this.cmpLogo1.Name = "cmpLogo1";
            this.cmpLogo1.Size = new System.Drawing.Size(172, 159);
            this.cmpLogo1.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.cmpLogo1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 34);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(320, 206);
            this.pnlLogo.TabIndex = 1;
            // 
            // pnlExpandirMenu
            // 
            this.pnlExpandirMenu.Controls.Add(this.btnExpandirMenu);
            this.pnlExpandirMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExpandirMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlExpandirMenu.Name = "pnlExpandirMenu";
            this.pnlExpandirMenu.Size = new System.Drawing.Size(320, 34);
            this.pnlExpandirMenu.TabIndex = 2;
            // 
            // btnExpandirMenu
            // 
            this.btnExpandirMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnExpandirMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExpandirMenu.FlatAppearance.BorderSize = 0;
            this.btnExpandirMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandirMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnExpandirMenu.IconColor = System.Drawing.Color.Black;
            this.btnExpandirMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpandirMenu.IconSize = 25;
            this.btnExpandirMenu.Location = new System.Drawing.Point(0, 0);
            this.btnExpandirMenu.MaximumSize = new System.Drawing.Size(36, 0);
            this.btnExpandirMenu.MinimumSize = new System.Drawing.Size(36, 0);
            this.btnExpandirMenu.Name = "btnExpandirMenu";
            this.btnExpandirMenu.Size = new System.Drawing.Size(36, 34);
            this.btnExpandirMenu.TabIndex = 2;
            this.btnExpandirMenu.UseVisualStyleBackColor = false;
            this.btnExpandirMenu.Click += new System.EventHandler(this.btnExpandirMenu_Click);
            // 
            // cmdIngresos
            // 
            this.cmdIngresos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdIngresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdIngresos.FlatAppearance.BorderSize = 0;
            this.cmdIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIngresos.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.cmdIngresos.IconColor = System.Drawing.Color.Black;
            this.cmdIngresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdIngresos.IconSize = 25;
            this.cmdIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdIngresos.Location = new System.Drawing.Point(0, 0);
            this.cmdIngresos.Name = "cmdIngresos";
            this.cmdIngresos.Size = new System.Drawing.Size(320, 31);
            this.cmdIngresos.TabIndex = 3;
            this.cmdIngresos.Text = "Ingresos";
            this.cmdIngresos.UseVisualStyleBackColor = false;
            this.cmdIngresos.Click += new System.EventHandler(this.cmdIngresos_Click);
            // 
            // cmdIngresosSimple
            // 
            this.cmdIngresosSimple.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdIngresosSimple.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdIngresosSimple.FlatAppearance.BorderSize = 0;
            this.cmdIngresosSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIngresosSimple.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.cmdIngresosSimple.IconColor = System.Drawing.Color.Black;
            this.cmdIngresosSimple.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdIngresosSimple.IconSize = 25;
            this.cmdIngresosSimple.Location = new System.Drawing.Point(0, 0);
            this.cmdIngresosSimple.Name = "cmdIngresosSimple";
            this.cmdIngresosSimple.Size = new System.Drawing.Size(320, 31);
            this.cmdIngresosSimple.TabIndex = 3;
            this.cmdIngresosSimple.UseVisualStyleBackColor = false;
            this.cmdIngresosSimple.Click += new System.EventHandler(this.cmdIngresos_Click);
            // 
            // navigationMenus
            // 
            this.navigationMenus.Controls.Add(this.pageMenuExtendido);
            this.navigationMenus.Controls.Add(this.pageMenuContraido);
            this.navigationMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationMenus.Location = new System.Drawing.Point(0, 240);
            this.navigationMenus.Name = "navigationMenus";
            this.navigationMenus.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageMenuExtendido,
            this.pageMenuContraido});
            this.navigationMenus.SelectedPage = this.pageMenuExtendido;
            this.navigationMenus.Size = new System.Drawing.Size(320, 280);
            this.navigationMenus.TabIndex = 6;
            this.navigationMenus.Text = "navigationFrame1";
            this.navigationMenus.TransitionAnimationProperties.FrameCount = 500;
            this.navigationMenus.TransitionAnimationProperties.FrameInterval = 500;
            this.navigationMenus.TransitionType = DevExpress.Utils.Animation.Transitions.Fade;
            // 
            // pageMenuExtendido
            // 
            this.pageMenuExtendido.Caption = "pageMenuExtendido";
            this.pageMenuExtendido.Controls.Add(this.cmdIngresos);
            this.pageMenuExtendido.Name = "pageMenuExtendido";
            this.pageMenuExtendido.Size = new System.Drawing.Size(320, 280);
            // 
            // pageMenuContraido
            // 
            this.pageMenuContraido.Caption = "pageMenuContraido";
            this.pageMenuContraido.Controls.Add(this.cmdIngresosSimple);
            this.pageMenuContraido.Name = "pageMenuContraido";
            this.pageMenuContraido.Size = new System.Drawing.Size(320, 280);
            // 
            // cmpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.navigationMenus);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlExpandirMenu);
            this.MaximumSize = new System.Drawing.Size(320, 0);
            this.MinimumSize = new System.Drawing.Size(30, 520);
            this.Name = "cmpMenu";
            this.Size = new System.Drawing.Size(320, 520);
            this.pnlLogo.ResumeLayout(false);
            this.pnlExpandirMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationMenus)).EndInit();
            this.navigationMenus.ResumeLayout(false);
            this.pageMenuExtendido.ResumeLayout(false);
            this.pageMenuContraido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private cmpLogo cmpLogo1;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlExpandirMenu;
        private FontAwesome.Sharp.IconButton btnExpandirMenu;
        private FontAwesome.Sharp.IconButton cmdIngresos;
        private FontAwesome.Sharp.IconButton cmdIngresosSimple;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationMenus;
        private DevExpress.XtraBars.Navigation.NavigationPage pageMenuExtendido;
        private DevExpress.XtraBars.Navigation.NavigationPage pageMenuContraido;
    }
}
