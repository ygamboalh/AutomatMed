
namespace TacticaReparaciones.DesktopApp.Pantallas
{
    partial class frmIngresos
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
            this.ctlEncabezadoPantalla1 = new TacticaReparaciones.DesktopApp.Componentes.Encabezados.ctlEncabezadoPantalla();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.glCorreoElectronico = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnBuscarEmpresa = new FontAwesome.Sharp.IconButton();
            this.glContacto = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtEmpresa = new DevExpress.XtraEditors.TextEdit();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.glCorreoElectronico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlEncabezadoPantalla1
            // 
            this.ctlEncabezadoPantalla1.BackColor = System.Drawing.Color.SlateGray;
            this.ctlEncabezadoPantalla1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlEncabezadoPantalla1.Location = new System.Drawing.Point(0, 0);
            this.ctlEncabezadoPantalla1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlEncabezadoPantalla1.Name = "ctlEncabezadoPantalla1";
            this.ctlEncabezadoPantalla1.Size = new System.Drawing.Size(1062, 42);
            this.ctlEncabezadoPantalla1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(161, 23);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nombre de Empresa:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 134);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(166, 23);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Nombre de Contacto:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 215);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(145, 23);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Correo Electrónico:";
            // 
            // glCorreoElectronico
            // 
            this.glCorreoElectronico.Location = new System.Drawing.Point(45, 244);
            this.glCorreoElectronico.Name = "glCorreoElectronico";
            this.glCorreoElectronico.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glCorreoElectronico.Properties.Appearance.Options.UseFont = true;
            this.glCorreoElectronico.Properties.PopupView = this.gridLookUpEdit3View;
            this.glCorreoElectronico.Size = new System.Drawing.Size(420, 26);
            this.glCorreoElectronico.TabIndex = 5;
            // 
            // gridLookUpEdit3View
            // 
            this.gridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit3View.Name = "gridLookUpEdit3View";
            this.gridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // btnBuscarEmpresa
            // 
            this.btnBuscarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpresa.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarEmpresa.IconColor = System.Drawing.Color.Black;
            this.btnBuscarEmpresa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarEmpresa.IconSize = 30;
            this.btnBuscarEmpresa.Location = new System.Drawing.Point(715, 84);
            this.btnBuscarEmpresa.Name = "btnBuscarEmpresa";
            this.btnBuscarEmpresa.Size = new System.Drawing.Size(43, 32);
            this.btnBuscarEmpresa.TabIndex = 7;
            this.btnBuscarEmpresa.UseVisualStyleBackColor = true;
            this.btnBuscarEmpresa.Click += new System.EventHandler(this.btnBuscarEmpresa_Click);
            this.btnBuscarEmpresa.MouseHover += new System.EventHandler(this.iconButton1_MouseHover);
            // 
            // glContacto
            // 
            this.glContacto.Location = new System.Drawing.Point(45, 163);
            this.glContacto.Name = "glContacto";
            this.glContacto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glContacto.Properties.Appearance.Options.UseFont = true;
            this.glContacto.Properties.PopupView = this.gridLookUpEdit2View;
            this.glContacto.Size = new System.Drawing.Size(654, 26);
            this.glContacto.TabIndex = 8;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.EditValue = "";
            this.txtEmpresa.Location = new System.Drawing.Point(45, 86);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmpresa.Properties.Appearance.Options.UseFont = true;
            this.txtEmpresa.Properties.ReadOnly = true;
            this.txtEmpresa.Properties.UseReadOnlyAppearance = false;
            this.txtEmpresa.Size = new System.Drawing.Size(654, 30);
            this.txtEmpresa.TabIndex = 9;
            // 
            // frmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 659);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.glContacto);
            this.Controls.Add(this.btnBuscarEmpresa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.glCorreoElectronico);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ctlEncabezadoPantalla1);
            this.Name = "frmIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.glCorreoElectronico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit glCorreoElectronico;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private FontAwesome.Sharp.IconButton btnBuscarEmpresa;
        private DevExpress.XtraEditors.GridLookUpEdit glContacto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.TextEdit txtEmpresa;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}