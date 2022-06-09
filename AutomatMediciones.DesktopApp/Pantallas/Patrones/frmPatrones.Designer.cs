
namespace AutomatMediciones.DesktopApp.Pantallas.Patrones
{
    partial class frmPatrones
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatrones));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarNuevoPatron = new FontAwesome.Sharp.IconButton();
            this.gcPatrones = new DevExpress.XtraGrid.GridControl();
            this.gvPatrones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCaducidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDesactivar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDesactivar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colVerPatron = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerPatron = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.btnExportarExcel = new FontAwesome.Sharp.IconButton();
            this.saveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatrones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatrones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDesactivar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerPatron)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportarExcel);
            this.panel1.Controls.Add(this.btnAgregarNuevoPatron);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 7, 0, 7);
            this.panel1.Size = new System.Drawing.Size(957, 53);
            this.panel1.TabIndex = 34;
            // 
            // btnAgregarNuevoPatron
            // 
            this.btnAgregarNuevoPatron.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarNuevoPatron.FlatAppearance.BorderSize = 0;
            this.btnAgregarNuevoPatron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoPatron.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarNuevoPatron.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarNuevoPatron.IconColor = System.Drawing.Color.Black;
            this.btnAgregarNuevoPatron.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarNuevoPatron.IconSize = 30;
            this.btnAgregarNuevoPatron.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNuevoPatron.Location = new System.Drawing.Point(8, 7);
            this.btnAgregarNuevoPatron.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarNuevoPatron.Name = "btnAgregarNuevoPatron";
            this.btnAgregarNuevoPatron.Size = new System.Drawing.Size(211, 39);
            this.btnAgregarNuevoPatron.TabIndex = 16;
            this.btnAgregarNuevoPatron.Text = "Nuevo Patrón";
            this.btnAgregarNuevoPatron.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNuevoPatron.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoPatron.Click += new System.EventHandler(this.btnAgregarNuevoPatron_Click);
            // 
            // gcPatrones
            // 
            this.gcPatrones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPatrones.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcPatrones.Location = new System.Drawing.Point(0, 53);
            this.gcPatrones.MainView = this.gvPatrones;
            this.gcPatrones.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcPatrones.Name = "gcPatrones";
            this.gcPatrones.Padding = new System.Windows.Forms.Padding(5);
            this.gcPatrones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditar,
            this.cmdDesactivar,
            this.cmdVerPatron});
            this.gcPatrones.Size = new System.Drawing.Size(957, 468);
            this.gcPatrones.TabIndex = 35;
            this.gcPatrones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatrones});
            // 
            // gvPatrones
            // 
            this.gvPatrones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescripcion,
            this.colFechaCaducidad,
            this.colLink,
            this.colEditar,
            this.colDesactivar,
            this.colVerPatron});
            this.gvPatrones.GridControl = this.gcPatrones;
            this.gvPatrones.Name = "gvPatrones";
            this.gvPatrones.OptionsView.ShowAutoFilterRow = true;
            this.gvPatrones.OptionsView.ShowGroupPanel = false;
            this.gvPatrones.OptionsView.ShowIndicator = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "PatronId";
            this.colId.MinWidth = 24;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Width = 198;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Nombre";
            this.colDescripcion.MinWidth = 24;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowFocus = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 385;
            // 
            // colFechaCaducidad
            // 
            this.colFechaCaducidad.Caption = "Fecha de Caducidad";
            this.colFechaCaducidad.FieldName = "FechaCaducidad";
            this.colFechaCaducidad.MinWidth = 25;
            this.colFechaCaducidad.Name = "colFechaCaducidad";
            this.colFechaCaducidad.OptionsColumn.AllowEdit = false;
            this.colFechaCaducidad.OptionsColumn.AllowFocus = false;
            this.colFechaCaducidad.OptionsColumn.ReadOnly = true;
            this.colFechaCaducidad.Visible = true;
            this.colFechaCaducidad.VisibleIndex = 1;
            this.colFechaCaducidad.Width = 182;
            // 
            // colLink
            // 
            this.colLink.Caption = "Archivo Adjunto";
            this.colLink.FieldName = "Link";
            this.colLink.MinWidth = 25;
            this.colLink.Name = "colLink";
            this.colLink.OptionsColumn.AllowEdit = false;
            this.colLink.OptionsColumn.AllowFocus = false;
            this.colLink.OptionsColumn.ReadOnly = true;
            this.colLink.Visible = true;
            this.colLink.VisibleIndex = 2;
            this.colLink.Width = 182;
            // 
            // colEditar
            // 
            this.colEditar.ColumnEdit = this.cmdEditar;
            this.colEditar.MinWidth = 25;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 3;
            this.colEditar.Width = 46;
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "Editar", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colDesactivar
            // 
            this.colDesactivar.ColumnEdit = this.cmdDesactivar;
            this.colDesactivar.MinWidth = 25;
            this.colDesactivar.Name = "colDesactivar";
            this.colDesactivar.Visible = true;
            this.colDesactivar.VisibleIndex = 4;
            this.colDesactivar.Width = 46;
            // 
            // cmdDesactivar
            // 
            this.cmdDesactivar.AutoHeight = false;
            editorButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions5.Image")));
            this.cmdDesactivar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject17, serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, "Desactivar", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdDesactivar.Name = "cmdDesactivar";
            this.cmdDesactivar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colVerPatron
            // 
            this.colVerPatron.ColumnEdit = this.cmdVerPatron;
            this.colVerPatron.MinWidth = 25;
            this.colVerPatron.Name = "colVerPatron";
            this.colVerPatron.Visible = true;
            this.colVerPatron.VisibleIndex = 5;
            this.colVerPatron.Width = 40;
            // 
            // cmdVerPatron
            // 
            this.cmdVerPatron.AutoHeight = false;
            editorButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions6.Image")));
            this.cmdVerPatron.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions6, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, serializableAppearanceObject22, serializableAppearanceObject23, serializableAppearanceObject24, "Ver Patrón", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerPatron.Name = "cmdVerPatron";
            this.cmdVerPatron.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 521);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 27);
            this.panel2.TabIndex = 36;
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
            this.btnExportarExcel.Location = new System.Drawing.Point(746, 7);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(211, 39);
            this.btnExportarExcel.TabIndex = 166;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // frmPatrones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 548);
            this.Controls.Add(this.gcPatrones);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPatrones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patrónes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPatrones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatrones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDesactivar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerPatron)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAgregarNuevoPatron;
        private DevExpress.XtraGrid.GridControl gcPatrones;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatrones;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCaducidad;
        private DevExpress.XtraGrid.Columns.GridColumn colLink;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colDesactivar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDesactivar;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colVerPatron;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerPatron;
        private FontAwesome.Sharp.IconButton btnExportarExcel;
        private DevExpress.XtraEditors.XtraSaveFileDialog saveFileDialog;
    }
}