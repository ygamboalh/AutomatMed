
namespace AutomatMediciones.DesktopApp.Pantallas
{
    partial class frmEmpresas
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
            this.ctlEncabezadoPopup = new AutomatMediciones.DesktopApp.Componentes.Encabezados.ctlEncabezadoPantalla();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gcEmpresas = new DevExpress.XtraGrid.GridControl();
            this.gvEmpresas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTotalRegistros = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlEncabezadoPopup
            // 
            this.ctlEncabezadoPopup.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlEncabezadoPopup.Location = new System.Drawing.Point(10, 10);
            this.ctlEncabezadoPopup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlEncabezadoPopup.Name = "ctlEncabezadoPopup";
            this.ctlEncabezadoPopup.Size = new System.Drawing.Size(832, 43);
            this.ctlEncabezadoPopup.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl4.Location = new System.Drawing.Point(10, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(832, 38);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Seleccione una Empresa, presione Enter o haga doble click para confirmar su elecc" +
    "ión.";
            // 
            // gcEmpresas
            // 
            this.gcEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmpresas.Location = new System.Drawing.Point(10, 91);
            this.gcEmpresas.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcEmpresas.MainView = this.gvEmpresas;
            this.gcEmpresas.Name = "gcEmpresas";
            this.gcEmpresas.Size = new System.Drawing.Size(832, 471);
            this.gcEmpresas.TabIndex = 12;
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
            this.colNombreEmpresa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NombreEmpresa", "{0}")});
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
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalRegistros.Appearance.Options.UseFont = true;
            this.lblTotalRegistros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalRegistros.Location = new System.Drawing.Point(10, 562);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(0, 23);
            this.lblTotalRegistros.TabIndex = 13;
            // 
            // frmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 595);
            this.Controls.Add(this.gcEmpresas);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ctlEncabezadoPopup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEmpresas";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPopup;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gcEmpresas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmpresas;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresaId;
        private DevExpress.XtraEditors.LabelControl lblTotalRegistros;
    }
}