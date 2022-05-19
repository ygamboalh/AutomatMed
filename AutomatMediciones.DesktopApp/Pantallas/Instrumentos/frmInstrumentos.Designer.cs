
namespace AutomatMediciones.DesktopApp.Pantallas.Instrumentos
{
    partial class frmInstrumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstrumentos));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarNuevoInstrumento = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.gcInstrumentos = new DevExpress.XtraGrid.GridControl();
            this.gvInstrumentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClasificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCompraFabricante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCompraCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCalibracion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaProximaCalibracion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGarnatia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDesactivar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstrumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstrumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesactivar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregarNuevoInstrumento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 7, 0, 7);
            this.panel1.Size = new System.Drawing.Size(1195, 53);
            this.panel1.TabIndex = 34;
            // 
            // btnAgregarNuevoInstrumento
            // 
            this.btnAgregarNuevoInstrumento.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarNuevoInstrumento.FlatAppearance.BorderSize = 0;
            this.btnAgregarNuevoInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoInstrumento.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarNuevoInstrumento.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarNuevoInstrumento.IconColor = System.Drawing.Color.Black;
            this.btnAgregarNuevoInstrumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarNuevoInstrumento.IconSize = 30;
            this.btnAgregarNuevoInstrumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNuevoInstrumento.Location = new System.Drawing.Point(8, 7);
            this.btnAgregarNuevoInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarNuevoInstrumento.Name = "btnAgregarNuevoInstrumento";
            this.btnAgregarNuevoInstrumento.Size = new System.Drawing.Size(211, 39);
            this.btnAgregarNuevoInstrumento.TabIndex = 16;
            this.btnAgregarNuevoInstrumento.Text = "Nuevo Instrumento";
            this.btnAgregarNuevoInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNuevoInstrumento.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoInstrumento.Click += new System.EventHandler(this.btnAgregarNuevoInstrumento_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 579);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1195, 27);
            this.panel2.TabIndex = 35;
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
            // gcInstrumentos
            // 
            this.gcInstrumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInstrumentos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcInstrumentos.Location = new System.Drawing.Point(0, 53);
            this.gcInstrumentos.MainView = this.gvInstrumentos;
            this.gcInstrumentos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcInstrumentos.Name = "gcInstrumentos";
            this.gcInstrumentos.Padding = new System.Windows.Forms.Padding(5);
            this.gcInstrumentos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar,
            this.btnDesactivar});
            this.gcInstrumentos.Size = new System.Drawing.Size(1195, 526);
            this.gcInstrumentos.TabIndex = 36;
            this.gcInstrumentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInstrumentos});
            // 
            // gvInstrumentos
            // 
            this.gvInstrumentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescripcion,
            this.colClasificacion,
            this.colEmpresa,
            this.colEditar,
            this.colSerie,
            this.colFechaCompraFabricante,
            this.colFechaCompraCliente,
            this.colFechaCalibracion,
            this.colFechaProximaCalibracion,
            this.colGarnatia,
            this.colEliminar});
            this.gvInstrumentos.GridControl = this.gcInstrumentos;
            this.gvInstrumentos.Name = "gvInstrumentos";
            this.gvInstrumentos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvInstrumentos.OptionsView.ShowAutoFilterRow = true;
            this.gvInstrumentos.OptionsView.ShowGroupPanel = false;
            this.gvInstrumentos.OptionsView.ShowIndicator = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "InstrumentoId";
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
            this.colDescripcion.OptionsColumn.AllowFocus = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 220;
            // 
            // colClasificacion
            // 
            this.colClasificacion.Caption = "Clasificación";
            this.colClasificacion.FieldName = "ClasificacionConcatenada";
            this.colClasificacion.MinWidth = 24;
            this.colClasificacion.Name = "colClasificacion";
            this.colClasificacion.OptionsColumn.AllowEdit = false;
            this.colClasificacion.OptionsColumn.AllowFocus = false;
            this.colClasificacion.OptionsColumn.ReadOnly = true;
            this.colClasificacion.Visible = true;
            this.colClasificacion.VisibleIndex = 1;
            this.colClasificacion.Width = 185;
            // 
            // colEmpresa
            // 
            this.colEmpresa.Caption = "Empresa";
            this.colEmpresa.FieldName = "NombreEmpresa";
            this.colEmpresa.MinWidth = 24;
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.OptionsColumn.AllowEdit = false;
            this.colEmpresa.OptionsColumn.AllowFocus = false;
            this.colEmpresa.OptionsColumn.ReadOnly = true;
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 2;
            this.colEmpresa.Width = 93;
            // 
            // colEditar
            // 
            this.colEditar.ColumnEdit = this.btnEditar;
            this.colEditar.MinWidth = 24;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 9;
            this.colEditar.Width = 38;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Editar", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "Serie";
            this.colSerie.FieldName = "NumeroSerie";
            this.colSerie.MinWidth = 24;
            this.colSerie.Name = "colSerie";
            this.colSerie.OptionsColumn.AllowEdit = false;
            this.colSerie.OptionsColumn.AllowFocus = false;
            this.colSerie.OptionsColumn.ReadOnly = true;
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 3;
            this.colSerie.Width = 93;
            // 
            // colFechaCompraFabricante
            // 
            this.colFechaCompraFabricante.Caption = "Fecha Compra Fabricante";
            this.colFechaCompraFabricante.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colFechaCompraFabricante.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaCompraFabricante.FieldName = "FechaCompraFabricante";
            this.colFechaCompraFabricante.MinWidth = 24;
            this.colFechaCompraFabricante.Name = "colFechaCompraFabricante";
            this.colFechaCompraFabricante.OptionsColumn.AllowEdit = false;
            this.colFechaCompraFabricante.OptionsColumn.AllowFocus = false;
            this.colFechaCompraFabricante.OptionsColumn.ReadOnly = true;
            this.colFechaCompraFabricante.Visible = true;
            this.colFechaCompraFabricante.VisibleIndex = 4;
            this.colFechaCompraFabricante.Width = 93;
            // 
            // colFechaCompraCliente
            // 
            this.colFechaCompraCliente.Caption = "Fecha Compra Cliente";
            this.colFechaCompraCliente.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colFechaCompraCliente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaCompraCliente.FieldName = "FechaCompraCliente";
            this.colFechaCompraCliente.MinWidth = 24;
            this.colFechaCompraCliente.Name = "colFechaCompraCliente";
            this.colFechaCompraCliente.OptionsColumn.AllowEdit = false;
            this.colFechaCompraCliente.OptionsColumn.AllowFocus = false;
            this.colFechaCompraCliente.OptionsColumn.ReadOnly = true;
            this.colFechaCompraCliente.Visible = true;
            this.colFechaCompraCliente.VisibleIndex = 5;
            this.colFechaCompraCliente.Width = 93;
            // 
            // colFechaCalibracion
            // 
            this.colFechaCalibracion.Caption = "Fecha Última Calibración";
            this.colFechaCalibracion.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colFechaCalibracion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaCalibracion.FieldName = "FechaUltiimaCalibracion";
            this.colFechaCalibracion.MinWidth = 24;
            this.colFechaCalibracion.Name = "colFechaCalibracion";
            this.colFechaCalibracion.OptionsColumn.AllowEdit = false;
            this.colFechaCalibracion.OptionsColumn.AllowFocus = false;
            this.colFechaCalibracion.OptionsColumn.ReadOnly = true;
            this.colFechaCalibracion.Visible = true;
            this.colFechaCalibracion.VisibleIndex = 6;
            this.colFechaCalibracion.Width = 93;
            // 
            // colFechaProximaCalibracion
            // 
            this.colFechaProximaCalibracion.Caption = "Fecha Próxima Calibración";
            this.colFechaProximaCalibracion.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colFechaProximaCalibracion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaProximaCalibracion.FieldName = "FechaProximaCalibracion";
            this.colFechaProximaCalibracion.MinWidth = 24;
            this.colFechaProximaCalibracion.Name = "colFechaProximaCalibracion";
            this.colFechaProximaCalibracion.OptionsColumn.AllowEdit = false;
            this.colFechaProximaCalibracion.OptionsColumn.AllowFocus = false;
            this.colFechaProximaCalibracion.OptionsColumn.ReadOnly = true;
            this.colFechaProximaCalibracion.Visible = true;
            this.colFechaProximaCalibracion.VisibleIndex = 7;
            this.colFechaProximaCalibracion.Width = 93;
            // 
            // colGarnatia
            // 
            this.colGarnatia.Caption = "Garantía";
            this.colGarnatia.FieldName = "Garantia";
            this.colGarnatia.MinWidth = 24;
            this.colGarnatia.Name = "colGarnatia";
            this.colGarnatia.OptionsColumn.AllowEdit = false;
            this.colGarnatia.OptionsColumn.AllowFocus = false;
            this.colGarnatia.OptionsColumn.ReadOnly = true;
            this.colGarnatia.Visible = true;
            this.colGarnatia.VisibleIndex = 8;
            this.colGarnatia.Width = 98;
            // 
            // colEliminar
            // 
            this.colEliminar.ColumnEdit = this.btnDesactivar;
            this.colEliminar.MinWidth = 24;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 10;
            this.colEliminar.Width = 43;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnDesactivar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Desactivar", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmInstrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 606);
            this.Controls.Add(this.gcInstrumentos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmInstrumentos";
            this.Text = "Instrumentos";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstrumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstrumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesactivar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAgregarNuevoInstrumento;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.GridControl gcInstrumentos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInstrumentos;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colClasificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCompraFabricante;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCompraCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCalibracion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaProximaCalibracion;
        private DevExpress.XtraGrid.Columns.GridColumn colGarnatia;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDesactivar;
    }
}