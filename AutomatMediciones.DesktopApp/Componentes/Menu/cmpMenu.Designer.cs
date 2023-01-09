
namespace AutomatMediciones.DesktopApp.Componentes.Menu
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
            this.cmpLogo1 = new AutomatMediciones.DesktopApp.Componentes.Menu.cmpLogo();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlExpandirMenu = new System.Windows.Forms.Panel();
            this.btnExpandirMenu = new FontAwesome.Sharp.IconButton();
            this.cmdIngresosSimple = new FontAwesome.Sharp.IconButton();
            this.navigationMenus = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageMenuExtendido = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.pageMenuContraido = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnPatronContraido = new FontAwesome.Sharp.IconButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnCeldContraida = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCertificadosContraido = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDiagnosticosNoExpandido = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.cmdNuevoPreIngresoSimple = new FontAwesome.Sharp.IconButton();
            this.pnlLogo.SuspendLayout();
            this.pnlExpandirMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationMenus)).BeginInit();
            this.navigationMenus.SuspendLayout();
            this.pageMenuExtendido.SuspendLayout();
            this.pageMenuContraido.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmpLogo1
            // 
            this.cmpLogo1.BackColor = System.Drawing.Color.White;
            this.cmpLogo1.Location = new System.Drawing.Point(67, 21);
            this.cmpLogo1.MaximumSize = new System.Drawing.Size(171, 159);
            this.cmpLogo1.MinimumSize = new System.Drawing.Size(171, 159);
            this.cmpLogo1.Name = "cmpLogo1";
            this.cmpLogo1.Size = new System.Drawing.Size(171, 159);
            this.cmpLogo1.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.cmpLogo1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 35);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(320, 195);
            this.pnlLogo.TabIndex = 1;
            // 
            // pnlExpandirMenu
            // 
            this.pnlExpandirMenu.Controls.Add(this.btnExpandirMenu);
            this.pnlExpandirMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExpandirMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlExpandirMenu.Name = "pnlExpandirMenu";
            this.pnlExpandirMenu.Size = new System.Drawing.Size(320, 35);
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
            this.btnExpandirMenu.MaximumSize = new System.Drawing.Size(37, 0);
            this.btnExpandirMenu.MinimumSize = new System.Drawing.Size(37, 0);
            this.btnExpandirMenu.Name = "btnExpandirMenu";
            this.btnExpandirMenu.Size = new System.Drawing.Size(37, 35);
            this.btnExpandirMenu.TabIndex = 2;
            this.btnExpandirMenu.UseVisualStyleBackColor = false;
            this.btnExpandirMenu.Click += new System.EventHandler(this.btnExpandirMenu_Click);
            // 
            // cmdIngresosSimple
            // 
            this.cmdIngresosSimple.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdIngresosSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdIngresosSimple.FlatAppearance.BorderSize = 0;
            this.cmdIngresosSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIngresosSimple.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.cmdIngresosSimple.IconColor = System.Drawing.Color.Black;
            this.cmdIngresosSimple.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdIngresosSimple.IconSize = 25;
            this.cmdIngresosSimple.Location = new System.Drawing.Point(0, 0);
            this.cmdIngresosSimple.Name = "cmdIngresosSimple";
            this.cmdIngresosSimple.Size = new System.Drawing.Size(320, 38);
            this.cmdIngresosSimple.TabIndex = 3;
            this.cmdIngresosSimple.UseVisualStyleBackColor = false;
            this.cmdIngresosSimple.Click += new System.EventHandler(this.cmdIngresos_Click);
            // 
            // navigationMenus
            // 
            this.navigationMenus.Controls.Add(this.pageMenuExtendido);
            this.navigationMenus.Controls.Add(this.pageMenuContraido);
            this.navigationMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationMenus.Location = new System.Drawing.Point(0, 230);
            this.navigationMenus.Name = "navigationMenus";
            this.navigationMenus.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageMenuExtendido,
            this.pageMenuContraido});
            this.navigationMenus.SelectedPage = this.pageMenuExtendido;
            this.navigationMenus.Size = new System.Drawing.Size(320, 290);
            this.navigationMenus.TabIndex = 6;
            this.navigationMenus.Text = "navigationFrame1";
            this.navigationMenus.TransitionAnimationProperties.FrameCount = 500;
            this.navigationMenus.TransitionAnimationProperties.FrameInterval = 500;
            this.navigationMenus.TransitionType = DevExpress.Utils.Animation.Transitions.Fade;
            this.navigationMenus.Click += new System.EventHandler(this.navigationMenus_Click);
            // 
            // pageMenuExtendido
            // 
            this.pageMenuExtendido.Caption = "pageMenuExtendido";
            this.pageMenuExtendido.Controls.Add(this.pnlItems);
            this.pageMenuExtendido.MinimumSize = new System.Drawing.Size(320, 0);
            this.pageMenuExtendido.Name = "pageMenuExtendido";
            this.pageMenuExtendido.Size = new System.Drawing.Size(320, 290);
            // 
            // pnlItems
            // 
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItems.Location = new System.Drawing.Point(0, 0);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(320, 290);
            this.pnlItems.TabIndex = 3;
            // 
            // pageMenuContraido
            // 
            this.pageMenuContraido.Caption = "pageMenuContraido";
            this.pageMenuContraido.Controls.Add(this.panel15);
            this.pageMenuContraido.Controls.Add(this.panel14);
            this.pageMenuContraido.Controls.Add(this.panel6);
            this.pageMenuContraido.Controls.Add(this.panel3);
            this.pageMenuContraido.Controls.Add(this.panel2);
            this.pageMenuContraido.Controls.Add(this.panel18);
            this.pageMenuContraido.Name = "pageMenuContraido";
            this.pageMenuContraido.Size = new System.Drawing.Size(320, 290);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnPatronContraido);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 215);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel15.Size = new System.Drawing.Size(320, 43);
            this.panel15.TabIndex = 10;
            // 
            // btnPatronContraido
            // 
            this.btnPatronContraido.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPatronContraido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPatronContraido.FlatAppearance.BorderSize = 0;
            this.btnPatronContraido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatronContraido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPatronContraido.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnPatronContraido.IconColor = System.Drawing.Color.Black;
            this.btnPatronContraido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPatronContraido.IconSize = 25;
            this.btnPatronContraido.Location = new System.Drawing.Point(0, 0);
            this.btnPatronContraido.Name = "btnPatronContraido";
            this.btnPatronContraido.Size = new System.Drawing.Size(320, 38);
            this.btnPatronContraido.TabIndex = 5;
            this.btnPatronContraido.UseVisualStyleBackColor = false;
            this.btnPatronContraido.Click += new System.EventHandler(this.cmdPatrones_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnCeldContraida);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 172);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel14.Size = new System.Drawing.Size(320, 43);
            this.panel14.TabIndex = 9;
            // 
            // btnCeldContraida
            // 
            this.btnCeldContraida.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCeldContraida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCeldContraida.FlatAppearance.BorderSize = 0;
            this.btnCeldContraida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCeldContraida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCeldContraida.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnCeldContraida.IconColor = System.Drawing.Color.Black;
            this.btnCeldContraida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCeldContraida.IconSize = 25;
            this.btnCeldContraida.Location = new System.Drawing.Point(0, 0);
            this.btnCeldContraida.Name = "btnCeldContraida";
            this.btnCeldContraida.Size = new System.Drawing.Size(320, 38);
            this.btnCeldContraida.TabIndex = 5;
            this.btnCeldContraida.UseVisualStyleBackColor = false;
            this.btnCeldContraida.Click += new System.EventHandler(this.btnCeldas_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCertificadosContraido);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 129);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel6.Size = new System.Drawing.Size(320, 43);
            this.panel6.TabIndex = 8;
            // 
            // btnCertificadosContraido
            // 
            this.btnCertificadosContraido.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCertificadosContraido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCertificadosContraido.FlatAppearance.BorderSize = 0;
            this.btnCertificadosContraido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCertificadosContraido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCertificadosContraido.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.btnCertificadosContraido.IconColor = System.Drawing.Color.Black;
            this.btnCertificadosContraido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCertificadosContraido.IconSize = 25;
            this.btnCertificadosContraido.Location = new System.Drawing.Point(0, 0);
            this.btnCertificadosContraido.Name = "btnCertificadosContraido";
            this.btnCertificadosContraido.Size = new System.Drawing.Size(320, 38);
            this.btnCertificadosContraido.TabIndex = 5;
            this.btnCertificadosContraido.UseVisualStyleBackColor = false;
            this.btnCertificadosContraido.Click += new System.EventHandler(this.btnCertificados_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDiagnosticosNoExpandido);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel3.Size = new System.Drawing.Size(320, 43);
            this.panel3.TabIndex = 6;
            // 
            // btnDiagnosticosNoExpandido
            // 
            this.btnDiagnosticosNoExpandido.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDiagnosticosNoExpandido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiagnosticosNoExpandido.FlatAppearance.BorderSize = 0;
            this.btnDiagnosticosNoExpandido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnosticosNoExpandido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiagnosticosNoExpandido.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnDiagnosticosNoExpandido.IconColor = System.Drawing.Color.Black;
            this.btnDiagnosticosNoExpandido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiagnosticosNoExpandido.IconSize = 25;
            this.btnDiagnosticosNoExpandido.Location = new System.Drawing.Point(0, 0);
            this.btnDiagnosticosNoExpandido.Name = "btnDiagnosticosNoExpandido";
            this.btnDiagnosticosNoExpandido.Size = new System.Drawing.Size(320, 38);
            this.btnDiagnosticosNoExpandido.TabIndex = 5;
            this.btnDiagnosticosNoExpandido.UseVisualStyleBackColor = false;
            this.btnDiagnosticosNoExpandido.Click += new System.EventHandler(this.btnDiagnosticos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdIngresosSimple);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel2.Size = new System.Drawing.Size(320, 43);
            this.panel2.TabIndex = 4;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.cmdNuevoPreIngresoSimple);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Name = "panel18";
            this.panel18.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel18.Size = new System.Drawing.Size(320, 43);
            this.panel18.TabIndex = 11;
            // 
            // cmdNuevoPreIngresoSimple
            // 
            this.cmdNuevoPreIngresoSimple.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdNuevoPreIngresoSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdNuevoPreIngresoSimple.FlatAppearance.BorderSize = 0;
            this.cmdNuevoPreIngresoSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevoPreIngresoSimple.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.cmdNuevoPreIngresoSimple.IconColor = System.Drawing.Color.Black;
            this.cmdNuevoPreIngresoSimple.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdNuevoPreIngresoSimple.IconSize = 25;
            this.cmdNuevoPreIngresoSimple.Location = new System.Drawing.Point(0, 0);
            this.cmdNuevoPreIngresoSimple.Name = "cmdNuevoPreIngresoSimple";
            this.cmdNuevoPreIngresoSimple.Size = new System.Drawing.Size(320, 38);
            this.cmdNuevoPreIngresoSimple.TabIndex = 3;
            this.cmdNuevoPreIngresoSimple.UseVisualStyleBackColor = false;
            this.cmdNuevoPreIngresoSimple.Click += new System.EventHandler(this.cmdNuevoPreIngresoSimple_Click);
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
            this.MinimumSize = new System.Drawing.Size(320, 520);
            this.Name = "cmpMenu";
            this.Size = new System.Drawing.Size(320, 520);
            this.pnlLogo.ResumeLayout(false);
            this.pnlExpandirMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationMenus)).EndInit();
            this.navigationMenus.ResumeLayout(false);
            this.pageMenuExtendido.ResumeLayout(false);
            this.pageMenuContraido.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private cmpLogo cmpLogo1;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlExpandirMenu;
        private FontAwesome.Sharp.IconButton btnExpandirMenu;
        private FontAwesome.Sharp.IconButton cmdIngresosSimple;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationMenus;
        private DevExpress.XtraBars.Navigation.NavigationPage pageMenuExtendido;
        private DevExpress.XtraBars.Navigation.NavigationPage pageMenuContraido;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnDiagnosticosNoExpandido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel15;
        private FontAwesome.Sharp.IconButton btnPatronContraido;
        private System.Windows.Forms.Panel panel14;
        private FontAwesome.Sharp.IconButton btnCeldContraida;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton btnCertificadosContraido;
        private System.Windows.Forms.Panel panel18;
        private FontAwesome.Sharp.IconButton cmdNuevoPreIngresoSimple;
        private System.Windows.Forms.Panel pnlItems;
    }
}
