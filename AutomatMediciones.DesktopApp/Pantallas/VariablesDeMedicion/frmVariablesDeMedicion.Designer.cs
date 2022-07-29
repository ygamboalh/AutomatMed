
namespace AutomatMediciones.DesktopApp.Pantallas.VariablesDeMedicion
{
    partial class frmVariablesDeMedicion
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVariablesDeMedicion));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportarExcel = new FontAwesome.Sharp.IconButton();
            this.btnAgregarNuevInstrumento = new FontAwesome.Sharp.IconButton();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.gcVariablesDeMedicion = new DevExpress.XtraGrid.GridControl();
            this.gvVariablesDeMedicion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimerValorRango = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSegundoValorRango = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTolerancia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDescripcionCorta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVariablesDeMedicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVariablesDeMedicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportarExcel);
            this.panel1.Controls.Add(this.btnAgregarNuevInstrumento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 7, 0, 7);
            this.panel1.Size = new System.Drawing.Size(995, 53);
            this.panel1.TabIndex = 37;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportarExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportarExcel.IconColor = System.Drawing.Color.Black;
            this.btnExportarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportarExcel.IconSize = 30;
            this.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarExcel.Location = new System.Drawing.Point(784, 7);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(211, 39);
            this.btnExportarExcel.TabIndex = 168;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnAgregarNuevInstrumento
            // 
            this.btnAgregarNuevInstrumento.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarNuevInstrumento.FlatAppearance.BorderSize = 0;
            this.btnAgregarNuevInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevInstrumento.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarNuevInstrumento.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarNuevInstrumento.IconColor = System.Drawing.Color.Black;
            this.btnAgregarNuevInstrumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarNuevInstrumento.IconSize = 30;
            this.btnAgregarNuevInstrumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNuevInstrumento.Location = new System.Drawing.Point(8, 7);
            this.btnAgregarNuevInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarNuevInstrumento.Name = "btnAgregarNuevInstrumento";
            this.btnAgregarNuevInstrumento.Size = new System.Drawing.Size(304, 39);
            this.btnAgregarNuevInstrumento.TabIndex = 16;
            this.btnAgregarNuevInstrumento.Text = "Nueva Variable de Medición";
            this.btnAgregarNuevInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNuevInstrumento.UseVisualStyleBackColor = true;
            this.btnAgregarNuevInstrumento.Click += new System.EventHandler(this.btnAgregarNuevInstrumento_Click);
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.MinWidth = 24;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowFocus = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 198;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 683);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 27);
            this.panel2.TabIndex = 38;
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(7, 17);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // gcVariablesDeMedicion
            // 
            this.gcVariablesDeMedicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVariablesDeMedicion.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcVariablesDeMedicion.Location = new System.Drawing.Point(0, 53);
            this.gcVariablesDeMedicion.MainView = this.gvVariablesDeMedicion;
            this.gcVariablesDeMedicion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcVariablesDeMedicion.Name = "gcVariablesDeMedicion";
            this.gcVariablesDeMedicion.Padding = new System.Windows.Forms.Padding(5);
            this.gcVariablesDeMedicion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditar});
            this.gcVariablesDeMedicion.Size = new System.Drawing.Size(995, 630);
            this.gcVariablesDeMedicion.TabIndex = 36;
            this.gcVariablesDeMedicion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVariablesDeMedicion});
            // 
            // gvVariablesDeMedicion
            // 
            this.gvVariablesDeMedicion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescripcion,
            this.colPrimerValorRango,
            this.colSegundoValorRango,
            this.colTolerancia,
            this.colEditar,
            this.colDescripcionCorta,
            this.colNombre});
            this.gvVariablesDeMedicion.GridControl = this.gcVariablesDeMedicion;
            this.gvVariablesDeMedicion.Name = "gvVariablesDeMedicion";
            this.gvVariablesDeMedicion.OptionsView.ShowAutoFilterRow = true;
            this.gvVariablesDeMedicion.OptionsView.ShowGroupPanel = false;
            this.gvVariablesDeMedicion.OptionsView.ShowIndicator = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "MarcaId";
            this.colId.MinWidth = 24;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Width = 198;
            // 
            // colPrimerValorRango
            // 
            this.colPrimerValorRango.Caption = "Primer Valor Rango";
            this.colPrimerValorRango.FieldName = "PrimerValorRango";
            this.colPrimerValorRango.MinWidth = 24;
            this.colPrimerValorRango.Name = "colPrimerValorRango";
            this.colPrimerValorRango.OptionsColumn.AllowEdit = false;
            this.colPrimerValorRango.OptionsColumn.AllowFocus = false;
            this.colPrimerValorRango.OptionsColumn.ReadOnly = true;
            this.colPrimerValorRango.Visible = true;
            this.colPrimerValorRango.VisibleIndex = 3;
            this.colPrimerValorRango.Width = 94;
            // 
            // colSegundoValorRango
            // 
            this.colSegundoValorRango.Caption = "Segundo Valor Rango";
            this.colSegundoValorRango.FieldName = "SegundoValorRango";
            this.colSegundoValorRango.MinWidth = 24;
            this.colSegundoValorRango.Name = "colSegundoValorRango";
            this.colSegundoValorRango.OptionsColumn.AllowEdit = false;
            this.colSegundoValorRango.OptionsColumn.AllowFocus = false;
            this.colSegundoValorRango.OptionsColumn.ReadOnly = true;
            this.colSegundoValorRango.Visible = true;
            this.colSegundoValorRango.VisibleIndex = 4;
            this.colSegundoValorRango.Width = 94;
            // 
            // colTolerancia
            // 
            this.colTolerancia.Caption = "Tolerancia";
            this.colTolerancia.FieldName = "Tolerancia";
            this.colTolerancia.MinWidth = 24;
            this.colTolerancia.Name = "colTolerancia";
            this.colTolerancia.OptionsColumn.AllowEdit = false;
            this.colTolerancia.OptionsColumn.AllowFocus = false;
            this.colTolerancia.OptionsColumn.ReadOnly = true;
            this.colTolerancia.Visible = true;
            this.colTolerancia.VisibleIndex = 5;
            this.colTolerancia.Width = 94;
            // 
            // colEditar
            // 
            this.colEditar.ColumnEdit = this.cmdEditar;
            this.colEditar.MaxWidth = 30;
            this.colEditar.MinWidth = 24;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 6;
            this.colEditar.Width = 30;
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Editar", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colDescripcionCorta
            // 
            this.colDescripcionCorta.Caption = "Descripción Corta";
            this.colDescripcionCorta.FieldName = "DescripcionCorta";
            this.colDescripcionCorta.MinWidth = 25;
            this.colDescripcionCorta.Name = "colDescripcionCorta";
            this.colDescripcionCorta.OptionsColumn.AllowEdit = false;
            this.colDescripcionCorta.OptionsColumn.AllowFocus = false;
            this.colDescripcionCorta.OptionsColumn.ReadOnly = true;
            this.colDescripcionCorta.Visible = true;
            this.colDescripcionCorta.VisibleIndex = 2;
            this.colDescripcionCorta.Width = 94;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.MinWidth = 25;
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.OptionsColumn.AllowFocus = false;
            this.colNombre.OptionsColumn.ReadOnly = true;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 94;
            // 
            // frmVariablesDeMedicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 710);
            this.Controls.Add(this.gcVariablesDeMedicion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmVariablesDeMedicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variables de Medición";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVariablesDeMedicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVariablesDeMedicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAgregarNuevInstrumento;
        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla3;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.GridControl gcVariablesDeMedicion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVariablesDeMedicion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimerValorRango;
        private DevExpress.XtraGrid.Columns.GridColumn colSegundoValorRango;
        private DevExpress.XtraGrid.Columns.GridColumn colTolerancia;
        private FontAwesome.Sharp.IconButton btnExportarExcel;
        private DevExpress.XtraEditors.XtraSaveFileDialog saveFileDialog;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionCorta;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
    }
}