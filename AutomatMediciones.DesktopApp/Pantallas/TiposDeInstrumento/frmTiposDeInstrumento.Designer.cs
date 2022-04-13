
namespace AutomatMediciones.DesktopApp.Pantallas.TiposDeInstrumento
{
    partial class frmTiposDeInstrumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposDeInstrumento));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcTipoInstrumento = new DevExpress.XtraGrid.GridControl();
            this.gvTipoInstrumento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResumen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMetodologia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarNuevInstrumento = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoInstrumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoInstrumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcTipoInstrumento
            // 
            this.gcTipoInstrumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTipoInstrumento.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcTipoInstrumento.Location = new System.Drawing.Point(0, 53);
            this.gcTipoInstrumento.MainView = this.gvTipoInstrumento;
            this.gcTipoInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcTipoInstrumento.Name = "gcTipoInstrumento";
            this.gcTipoInstrumento.Padding = new System.Windows.Forms.Padding(5);
            this.gcTipoInstrumento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditar,
            this.repositoryItemButtonEdit1});
            this.gcTipoInstrumento.Size = new System.Drawing.Size(992, 570);
            this.gcTipoInstrumento.TabIndex = 1;
            this.gcTipoInstrumento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTipoInstrumento});
            // 
            // gvTipoInstrumento
            // 
            this.gvTipoInstrumento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescripcion,
            this.colResumen,
            this.colMetodologia,
            this.colEditar});
            this.gvTipoInstrumento.GridControl = this.gcTipoInstrumento;
            this.gvTipoInstrumento.Name = "gvTipoInstrumento";
            this.gvTipoInstrumento.OptionsView.ShowAutoFilterRow = true;
            this.gvTipoInstrumento.OptionsView.ShowGroupPanel = false;
            this.gvTipoInstrumento.OptionsView.ShowIndicator = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "TipoInstrumentoId";
            this.colId.MinWidth = 24;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Width = 198;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.MinWidth = 24;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 198;
            // 
            // colResumen
            // 
            this.colResumen.Caption = "Resumen";
            this.colResumen.FieldName = "Resumen";
            this.colResumen.MinWidth = 24;
            this.colResumen.Name = "colResumen";
            this.colResumen.OptionsColumn.AllowEdit = false;
            this.colResumen.OptionsColumn.ReadOnly = true;
            this.colResumen.Visible = true;
            this.colResumen.VisibleIndex = 1;
            this.colResumen.Width = 198;
            // 
            // colMetodologia
            // 
            this.colMetodologia.Caption = "Metodología";
            this.colMetodologia.FieldName = "Metodologia";
            this.colMetodologia.MinWidth = 24;
            this.colMetodologia.Name = "colMetodologia";
            this.colMetodologia.OptionsColumn.AllowEdit = false;
            this.colMetodologia.OptionsColumn.ReadOnly = true;
            this.colMetodologia.Visible = true;
            this.colMetodologia.VisibleIndex = 2;
            this.colMetodologia.Width = 198;
            // 
            // colEditar
            // 
            this.colEditar.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colEditar.MinWidth = 24;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 3;
            this.colEditar.Width = 40;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregarNuevInstrumento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 7, 0, 7);
            this.panel1.Size = new System.Drawing.Size(992, 53);
            this.panel1.TabIndex = 2;
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
            this.btnAgregarNuevInstrumento.Text = "Nuevo Tipo de Instrumento";
            this.btnAgregarNuevInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNuevInstrumento.UseVisualStyleBackColor = true;
            this.btnAgregarNuevInstrumento.Click += new System.EventHandler(this.btnAgregarNuevInstrumento_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 623);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 27);
            this.panel2.TabIndex = 30;
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
            // frmTiposDeInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 650);
            this.Controls.Add(this.gcTipoInstrumento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmTiposDeInstrumento";
            this.Text = "Tipos de Instrumento";
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoInstrumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoInstrumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcTipoInstrumento;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTipoInstrumento;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAgregarNuevInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colResumen;
        private DevExpress.XtraGrid.Columns.GridColumn colMetodologia;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla3;
    }
}