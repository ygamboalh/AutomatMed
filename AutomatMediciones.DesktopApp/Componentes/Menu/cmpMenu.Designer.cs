
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
            this.cmdIngresos = new FontAwesome.Sharp.IconButton();
            this.cmdIngresosSimple = new FontAwesome.Sharp.IconButton();
            this.navigationMenus = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageMenuExtendido = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTiposDeInstrumetnos = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDiagnosticos = new FontAwesome.Sharp.IconButton();
            this.pnlIngresos = new System.Windows.Forms.Panel();
            this.pageMenuContraido = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTipoInstrumentoSimplificado = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDiagnosticosNoExpandido = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlLogo.SuspendLayout();
            this.pnlExpandirMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationMenus)).BeginInit();
            this.navigationMenus.SuspendLayout();
            this.pageMenuExtendido.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlIngresos.SuspendLayout();
            this.pageMenuContraido.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.cmdIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdIngresos.FlatAppearance.BorderSize = 0;
            this.cmdIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIngresos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdIngresos.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.cmdIngresos.IconColor = System.Drawing.Color.Black;
            this.cmdIngresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdIngresos.IconSize = 25;
            this.cmdIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdIngresos.Location = new System.Drawing.Point(0, 0);
            this.cmdIngresos.Name = "cmdIngresos";
            this.cmdIngresos.Size = new System.Drawing.Size(320, 43);
            this.cmdIngresos.TabIndex = 3;
            this.cmdIngresos.Text = "Ingresos";
            this.cmdIngresos.UseVisualStyleBackColor = false;
            this.cmdIngresos.Click += new System.EventHandler(this.cmdIngresos_Click);
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
            this.pageMenuExtendido.Controls.Add(this.panel4);
            this.pageMenuExtendido.Controls.Add(this.panel1);
            this.pageMenuExtendido.Controls.Add(this.pnlIngresos);
            this.pageMenuExtendido.Name = "pageMenuExtendido";
            this.pageMenuExtendido.Size = new System.Drawing.Size(320, 280);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnTiposDeInstrumetnos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 96);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel4.Size = new System.Drawing.Size(320, 47);
            this.panel4.TabIndex = 6;
            // 
            // btnTiposDeInstrumetnos
            // 
            this.btnTiposDeInstrumetnos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTiposDeInstrumetnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTiposDeInstrumetnos.FlatAppearance.BorderSize = 0;
            this.btnTiposDeInstrumetnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiposDeInstrumetnos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTiposDeInstrumetnos.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnTiposDeInstrumetnos.IconColor = System.Drawing.Color.Black;
            this.btnTiposDeInstrumetnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTiposDeInstrumetnos.IconSize = 25;
            this.btnTiposDeInstrumetnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiposDeInstrumetnos.Location = new System.Drawing.Point(0, 0);
            this.btnTiposDeInstrumetnos.Name = "btnTiposDeInstrumetnos";
            this.btnTiposDeInstrumetnos.Size = new System.Drawing.Size(320, 42);
            this.btnTiposDeInstrumetnos.TabIndex = 3;
            this.btnTiposDeInstrumetnos.Text = "Configuraciones";
            this.btnTiposDeInstrumetnos.UseVisualStyleBackColor = false;
            this.btnTiposDeInstrumetnos.Click += new System.EventHandler(this.btnTiposDeInstrumetnos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDiagnosticos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel1.Size = new System.Drawing.Size(320, 48);
            this.panel1.TabIndex = 5;
            // 
            // btnDiagnosticos
            // 
            this.btnDiagnosticos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDiagnosticos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiagnosticos.FlatAppearance.BorderSize = 0;
            this.btnDiagnosticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnosticos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiagnosticos.IconChar = FontAwesome.Sharp.IconChar.Stethoscope;
            this.btnDiagnosticos.IconColor = System.Drawing.Color.Black;
            this.btnDiagnosticos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiagnosticos.IconSize = 25;
            this.btnDiagnosticos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiagnosticos.Location = new System.Drawing.Point(0, 0);
            this.btnDiagnosticos.Name = "btnDiagnosticos";
            this.btnDiagnosticos.Size = new System.Drawing.Size(320, 43);
            this.btnDiagnosticos.TabIndex = 3;
            this.btnDiagnosticos.Text = "Diagnósticos";
            this.btnDiagnosticos.UseVisualStyleBackColor = false;
            this.btnDiagnosticos.Click += new System.EventHandler(this.btnDiagnosticos_Click);
            // 
            // pnlIngresos
            // 
            this.pnlIngresos.Controls.Add(this.cmdIngresos);
            this.pnlIngresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIngresos.Location = new System.Drawing.Point(0, 0);
            this.pnlIngresos.Name = "pnlIngresos";
            this.pnlIngresos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlIngresos.Size = new System.Drawing.Size(320, 48);
            this.pnlIngresos.TabIndex = 4;
            // 
            // pageMenuContraido
            // 
            this.pageMenuContraido.Caption = "pageMenuContraido";
            this.pageMenuContraido.Controls.Add(this.panel5);
            this.pageMenuContraido.Controls.Add(this.panel3);
            this.pageMenuContraido.Controls.Add(this.panel2);
            this.pageMenuContraido.Name = "pageMenuContraido";
            this.pageMenuContraido.Size = new System.Drawing.Size(320, 280);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnTipoInstrumentoSimplificado);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 86);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel5.Size = new System.Drawing.Size(320, 43);
            this.panel5.TabIndex = 7;
            // 
            // btnTipoInstrumentoSimplificado
            // 
            this.btnTipoInstrumentoSimplificado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTipoInstrumentoSimplificado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTipoInstrumentoSimplificado.FlatAppearance.BorderSize = 0;
            this.btnTipoInstrumentoSimplificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoInstrumentoSimplificado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTipoInstrumentoSimplificado.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnTipoInstrumentoSimplificado.IconColor = System.Drawing.Color.Black;
            this.btnTipoInstrumentoSimplificado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTipoInstrumentoSimplificado.IconSize = 25;
            this.btnTipoInstrumentoSimplificado.Location = new System.Drawing.Point(0, 0);
            this.btnTipoInstrumentoSimplificado.Name = "btnTipoInstrumentoSimplificado";
            this.btnTipoInstrumentoSimplificado.Size = new System.Drawing.Size(320, 38);
            this.btnTipoInstrumentoSimplificado.TabIndex = 5;
            this.btnTipoInstrumentoSimplificado.UseVisualStyleBackColor = false;
            this.btnTipoInstrumentoSimplificado.Click += new System.EventHandler(this.btnTiposDeInstrumetnos_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDiagnosticosNoExpandido);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 43);
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
            this.btnDiagnosticosNoExpandido.IconChar = FontAwesome.Sharp.IconChar.Stethoscope;
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
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel2.Size = new System.Drawing.Size(320, 43);
            this.panel2.TabIndex = 4;
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
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlIngresos.ResumeLayout(false);
            this.pageMenuContraido.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnDiagnosticos;
        private System.Windows.Forms.Panel pnlIngresos;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnDiagnosticosNoExpandido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnTiposDeInstrumetnos;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnTipoInstrumentoSimplificado;
    }
}
