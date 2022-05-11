
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatrones));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarNuevoPatron = new FontAwesome.Sharp.IconButton();
            this.gcPatrones = new DevExpress.XtraGrid.GridControl();
            this.gvMarcas = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatrones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDesactivar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerPatron)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.btnAgregarNuevoPatron.Text = "Nueva Patrón";
            this.btnAgregarNuevoPatron.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNuevoPatron.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoPatron.Click += new System.EventHandler(this.btnAgregarNuevoPatron_Click);
            // 
            // gcPatrones
            // 
            this.gcPatrones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPatrones.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcPatrones.Location = new System.Drawing.Point(0, 53);
            this.gcPatrones.MainView = this.gvMarcas;
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
            this.gvMarcas});
            // 
            // gvMarcas
            // 
            this.gvMarcas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescripcion,
            this.colFechaCaducidad,
            this.colLink,
            this.colEditar,
            this.colDesactivar,
            this.colVerPatron});
            this.gvMarcas.GridControl = this.gcPatrones;
            this.gvMarcas.Name = "gvMarcas";
            this.gvMarcas.OptionsView.ShowAutoFilterRow = true;
            this.gvMarcas.OptionsView.ShowGroupPanel = false;
            this.gvMarcas.OptionsView.ShowIndicator = false;
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
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Editar", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdDesactivar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Desactivar", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.cmdVerPatron.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "Ver Patrón", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            this.Text = "Patrones";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPatrones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarcas)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gvMarcas;
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
    }
}