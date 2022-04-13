
namespace AutomatMediciones.DesktopApp.Pantallas.Principales
{
    partial class frmPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::AutomatMediciones.DesktopApp.Pantallas.frmSaving), true, true);
            this.cmpMenu1 = new AutomatMediciones.DesktopApp.Componentes.Menu.cmpMenu();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBaseDatos = new DevExpress.XtraEditors.LabelControl();
            this.lblVersion = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // cmpMenu1
            // 
            this.cmpMenu1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmpMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmpMenu1.ExpandirMenu = true;
            this.cmpMenu1.Location = new System.Drawing.Point(3, 3);
            this.cmpMenu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmpMenu1.MaximumSize = new System.Drawing.Size(280, 0);
            this.cmpMenu1.MinimumSize = new System.Drawing.Size(26, 416);
            this.cmpMenu1.Name = "cmpMenu1";
            this.cmpMenu1.Size = new System.Drawing.Size(280, 639);
            this.cmpMenu1.TabIndex = 1;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBaseDatos);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(283, 613);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(918, 29);
            this.panel1.TabIndex = 2;
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.Appearance.Options.UseTextOptions = true;
            this.lblBaseDatos.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblBaseDatos.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaseDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBaseDatos.Location = new System.Drawing.Point(266, 0);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(642, 29);
            this.lblBaseDatos.TabIndex = 0;
            this.lblBaseDatos.Text = "labelControl1";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblVersion.Location = new System.Drawing.Point(10, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(256, 29);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "labelControl1";
            // 
            // frmPrincipal
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmpMenu1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmPrincipal.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.Menu.cmpMenu cmpMenu1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblVersion;
        private DevExpress.XtraEditors.LabelControl lblBaseDatos;
    }
}