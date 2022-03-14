
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.glCorreoElectronico = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glCorreo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRegistroId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscarEmpresa = new FontAwesome.Sharp.IconButton();
            this.glContacto = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glContactos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtEmpresa = new DevExpress.XtraEditors.TextEdit();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ctlEncabezadoPantalla1 = new TacticaReparaciones.DesktopApp.Componentes.Encabezados.ctlEncabezadoPantalla();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl2 = new DevExpress.Utils.FlyoutPanelControl();
            this.gcEmpresas = new DevExpress.XtraGrid.GridControl();
            this.gvEmpresas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctlEncabezadoPopup = new TacticaReparaciones.DesktopApp.Componentes.Encabezados.ctlEncabezadoPantalla();
            this.cmdCerrarPopupEmpresas = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.glCorreoElectronico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).BeginInit();
            this.flyoutPanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.glCorreoElectronico.Properties.NullText = "";
            this.glCorreoElectronico.Properties.PopupView = this.glCorreo;
            this.glCorreoElectronico.Size = new System.Drawing.Size(420, 26);
            this.glCorreoElectronico.TabIndex = 5;
            // 
            // glCorreo
            // 
            this.glCorreo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRegistroId,
            this.colDireccion});
            this.glCorreo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glCorreo.Name = "glCorreo";
            this.glCorreo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glCorreo.OptionsView.ShowGroupPanel = false;
            this.glCorreo.OptionsView.ShowIndicator = false;
            // 
            // colRegistroId
            // 
            this.colRegistroId.Caption = "Id";
            this.colRegistroId.FieldName = "RegistroId";
            this.colRegistroId.Name = "colRegistroId";
            this.colRegistroId.OptionsColumn.AllowEdit = false;
            this.colRegistroId.OptionsColumn.ReadOnly = true;
            // 
            // colDireccion
            // 
            this.colDireccion.Caption = "Correo";
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.OptionsColumn.AllowEdit = false;
            this.colDireccion.OptionsColumn.ReadOnly = true;
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 0;
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
            this.glContacto.EditValue = "";
            this.glContacto.Location = new System.Drawing.Point(45, 163);
            this.glContacto.Name = "glContacto";
            this.glContacto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glContacto.Properties.Appearance.Options.UseFont = true;
            this.glContacto.Properties.NullText = "";
            this.glContacto.Properties.PopupView = this.glContactos;
            this.glContacto.Properties.EditValueChanged += new System.EventHandler(this.glContacto_Properties_EditValueChanged);
            this.glContacto.Size = new System.Drawing.Size(654, 26);
            this.glContacto.TabIndex = 8;
            // 
            // glContactos
            // 
            this.glContactos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreContacto,
            this.colCargo,
            this.colContactoId});
            this.glContactos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glContactos.Name = "glContactos";
            this.glContactos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glContactos.OptionsView.ShowGroupPanel = false;
            this.glContactos.OptionsView.ShowIndicator = false;
            // 
            // colNombreContacto
            // 
            this.colNombreContacto.Caption = "Nombre";
            this.colNombreContacto.FieldName = "Nombre";
            this.colNombreContacto.Name = "colNombreContacto";
            this.colNombreContacto.OptionsColumn.AllowEdit = false;
            this.colNombreContacto.OptionsColumn.ReadOnly = true;
            this.colNombreContacto.Visible = true;
            this.colNombreContacto.VisibleIndex = 0;
            // 
            // colCargo
            // 
            this.colCargo.Caption = "Cargo";
            this.colCargo.FieldName = "Cargo";
            this.colCargo.Name = "colCargo";
            this.colCargo.OptionsColumn.AllowEdit = false;
            this.colCargo.OptionsColumn.ReadOnly = true;
            this.colCargo.Visible = true;
            this.colCargo.VisibleIndex = 1;
            // 
            // colContactoId
            // 
            this.colContactoId.Caption = "Contacto Id";
            this.colContactoId.FieldName = "ContactoId";
            this.colContactoId.Name = "colContactoId";
            this.colContactoId.OptionsColumn.AllowEdit = false;
            this.colContactoId.OptionsColumn.ReadOnly = true;
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
            // ctlEncabezadoPantalla1
            // 
            this.ctlEncabezadoPantalla1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlEncabezadoPantalla1.Location = new System.Drawing.Point(0, 0);
            this.ctlEncabezadoPantalla1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlEncabezadoPantalla1.Name = "ctlEncabezadoPantalla1";
            this.ctlEncabezadoPantalla1.Size = new System.Drawing.Size(1711, 35);
            this.ctlEncabezadoPantalla1.TabIndex = 12;
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl2);
            this.flyoutPanel1.Location = new System.Drawing.Point(881, 89);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center;
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.OwnerControl = this;
            this.flyoutPanel1.ParentForm = this;
            this.flyoutPanel1.Size = new System.Drawing.Size(586, 415);
            this.flyoutPanel1.TabIndex = 13;
            // 
            // flyoutPanelControl2
            // 
            this.flyoutPanelControl2.Controls.Add(this.gcEmpresas);
            this.flyoutPanelControl2.Controls.Add(this.labelControl4);
            this.flyoutPanelControl2.Controls.Add(this.panel1);
            this.flyoutPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl2.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl2.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl2.Name = "flyoutPanelControl2";
            this.flyoutPanelControl2.Size = new System.Drawing.Size(586, 415);
            this.flyoutPanelControl2.TabIndex = 0;
            // 
            // gcEmpresas
            // 
            this.gcEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmpresas.Location = new System.Drawing.Point(2, 69);
            this.gcEmpresas.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcEmpresas.MainView = this.gvEmpresas;
            this.gcEmpresas.Name = "gcEmpresas";
            this.gcEmpresas.Size = new System.Drawing.Size(582, 344);
            this.gcEmpresas.TabIndex = 5;
            this.gcEmpresas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmpresas});
            this.gcEmpresas.DoubleClick += new System.EventHandler(this.gcEmpresas_DoubleClick);
            this.gcEmpresas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gcEmpresas_KeyUp);
            // 
            // gvEmpresas
            // 
            this.gvEmpresas.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gvEmpresas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.SelectedRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gvEmpresas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvEmpresas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreEmpresa,
            this.colEmpresaId});
            this.gvEmpresas.GridControl = this.gcEmpresas;
            this.gvEmpresas.Name = "gvEmpresas";
            this.gvEmpresas.OptionsView.ShowAutoFilterRow = true;
            this.gvEmpresas.OptionsView.ShowColumnHeaders = false;
            this.gvEmpresas.OptionsView.ShowGroupPanel = false;
            this.gvEmpresas.OptionsView.ShowIndicator = false;
            // 
            // colNombreEmpresa
            // 
            this.colNombreEmpresa.Caption = "Empresa";
            this.colNombreEmpresa.FieldName = "NombreEmpresa";
            this.colNombreEmpresa.MinWidth = 25;
            this.colNombreEmpresa.Name = "colNombreEmpresa";
            this.colNombreEmpresa.OptionsColumn.AllowEdit = false;
            this.colNombreEmpresa.OptionsColumn.ReadOnly = true;
            this.colNombreEmpresa.Visible = true;
            this.colNombreEmpresa.VisibleIndex = 0;
            this.colNombreEmpresa.Width = 94;
            // 
            // colEmpresaId
            // 
            this.colEmpresaId.Caption = "Empresa Id";
            this.colEmpresaId.FieldName = "EmpresaId";
            this.colEmpresaId.MinWidth = 25;
            this.colEmpresaId.Name = "colEmpresaId";
            this.colEmpresaId.OptionsColumn.AllowEdit = false;
            this.colEmpresaId.OptionsColumn.ReadOnly = true;
            this.colEmpresaId.Width = 94;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl4.Location = new System.Drawing.Point(2, 46);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(184, 23);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Seleccione una Empresa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctlEncabezadoPopup);
            this.panel1.Controls.Add(this.cmdCerrarPopupEmpresas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 44);
            this.panel1.TabIndex = 3;
            // 
            // ctlEncabezadoPopup
            // 
            this.ctlEncabezadoPopup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlEncabezadoPopup.Location = new System.Drawing.Point(0, 0);
            this.ctlEncabezadoPopup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlEncabezadoPopup.Name = "ctlEncabezadoPopup";
            this.ctlEncabezadoPopup.Size = new System.Drawing.Size(539, 44);
            this.ctlEncabezadoPopup.TabIndex = 9;
            // 
            // cmdCerrarPopupEmpresas
            // 
            this.cmdCerrarPopupEmpresas.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdCerrarPopupEmpresas.FlatAppearance.BorderSize = 0;
            this.cmdCerrarPopupEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrarPopupEmpresas.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.cmdCerrarPopupEmpresas.IconColor = System.Drawing.Color.Red;
            this.cmdCerrarPopupEmpresas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdCerrarPopupEmpresas.IconSize = 40;
            this.cmdCerrarPopupEmpresas.Location = new System.Drawing.Point(539, 0);
            this.cmdCerrarPopupEmpresas.Name = "cmdCerrarPopupEmpresas";
            this.cmdCerrarPopupEmpresas.Size = new System.Drawing.Size(43, 44);
            this.cmdCerrarPopupEmpresas.TabIndex = 8;
            this.cmdCerrarPopupEmpresas.UseVisualStyleBackColor = true;
            this.cmdCerrarPopupEmpresas.Click += new System.EventHandler(this.cmdCerrarPopupEmpresas_Click);
            // 
            // frmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 659);
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.ctlEncabezadoPantalla1);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.glContacto);
            this.Controls.Add(this.btnBuscarEmpresa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.glCorreoElectronico);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glCorreoElectronico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).EndInit();
            this.flyoutPanelControl2.ResumeLayout(false);
            this.flyoutPanelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit glCorreoElectronico;
        private DevExpress.XtraGrid.Views.Grid.GridView glCorreo;
        private FontAwesome.Sharp.IconButton btnBuscarEmpresa;
        private DevExpress.XtraEditors.GridLookUpEdit glContacto;
        private DevExpress.XtraGrid.Views.Grid.GridView glContactos;
        private DevExpress.XtraEditors.TextEdit txtEmpresa;
        private System.Windows.Forms.ToolTip toolTip1;
        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantallaPopupEmpresas;
        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla3;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl2;
        private DevExpress.XtraGrid.GridControl gcEmpresas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmpresas;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresaId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panel1;
        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPopup;
        private FontAwesome.Sharp.IconButton cmdCerrarPopupEmpresas;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colContactoId;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistroId;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
    }
}