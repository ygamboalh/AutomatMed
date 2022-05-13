
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gcEmpresas = new DevExpress.XtraGrid.GridControl();
            this.gvEmpresas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTotalRegistros = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscarEmpresa = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl4.Location = new System.Drawing.Point(10, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(832, 38);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Seleccione una Empresa, presione Enter o haga doble click para confirmar su elecc" +
    "ión.";
            // 
            // gcEmpresas
            // 
            this.gcEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmpresas.Location = new System.Drawing.Point(10, 97);
            this.gcEmpresas.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcEmpresas.MainView = this.gvEmpresas;
            this.gcEmpresas.Name = "gcEmpresas";
            this.gcEmpresas.Size = new System.Drawing.Size(832, 465);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.btnBuscarEmpresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panel1.Size = new System.Drawing.Size(832, 49);
            this.panel1.TabIndex = 128;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBusqueda.EditValue = "";
            this.txtBusqueda.Location = new System.Drawing.Point(0, 8);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusqueda.Properties.Appearance.Options.UseFont = true;
            this.txtBusqueda.Properties.AutoHeight = false;
            this.txtBusqueda.Size = new System.Drawing.Size(789, 41);
            this.txtBusqueda.TabIndex = 129;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // btnBuscarEmpresa
            // 
            this.btnBuscarEmpresa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuscarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpresa.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarEmpresa.IconColor = System.Drawing.Color.Black;
            this.btnBuscarEmpresa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarEmpresa.IconSize = 30;
            this.btnBuscarEmpresa.Location = new System.Drawing.Point(789, 8);
            this.btnBuscarEmpresa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscarEmpresa.Name = "btnBuscarEmpresa";
            this.btnBuscarEmpresa.Size = new System.Drawing.Size(43, 41);
            this.btnBuscarEmpresa.TabIndex = 128;
            this.btnBuscarEmpresa.UseVisualStyleBackColor = true;
            this.btnBuscarEmpresa.Click += new System.EventHandler(this.btnBuscarEmpresa_Click);
            // 
            // frmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 595);
            this.Controls.Add(this.gcEmpresas);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalRegistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEmpresas";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gcEmpresas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmpresas;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresaId;
        private DevExpress.XtraEditors.LabelControl lblTotalRegistros;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnBuscarEmpresa;
        public DevExpress.XtraEditors.TextEdit txtBusqueda;
    }
}