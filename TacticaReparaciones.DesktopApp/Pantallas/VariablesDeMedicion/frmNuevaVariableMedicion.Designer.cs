
namespace AutomatMediciones.DesktopApp.Pantallas.VariablesDeMedicion
{
    partial class frmNuevaVariableMedicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaVariableMedicion));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnGuardarVariableMedicion = new FontAwesome.Sharp.IconButton();
            this.ctlEncabezadoPantalla1 = new AutomatMediciones.DesktopApp.Componentes.Encabezados.ctlEncabezadoPantalla();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.nmPrimerValorRango = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.nmSegundoValorRango = new System.Windows.Forms.NumericUpDown();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nmTolerancia = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.glTipoInstrumento = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glTipoInstrumentoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoInstrumentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregarTipoDeInstrumento = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalInstrumentos = new DevExpress.XtraEditors.LabelControl();
            this.gcTiposDeInstrumento = new DevExpress.XtraGrid.GridControl();
            this.gvTiposDeInstrumento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionTipoInstrumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.chkSeleccionarInstrumento = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrimerValorRango)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSegundoValorRango)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTolerancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumentoView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposDeInstrumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposDeInstrumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionarInstrumento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarVariableMedicion
            // 
            this.btnGuardarVariableMedicion.FlatAppearance.BorderSize = 0;
            this.btnGuardarVariableMedicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVariableMedicion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarVariableMedicion.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarVariableMedicion.IconColor = System.Drawing.Color.Black;
            this.btnGuardarVariableMedicion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarVariableMedicion.IconSize = 30;
            this.btnGuardarVariableMedicion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarVariableMedicion.Location = new System.Drawing.Point(332, 574);
            this.btnGuardarVariableMedicion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarVariableMedicion.Name = "btnGuardarVariableMedicion";
            this.btnGuardarVariableMedicion.Size = new System.Drawing.Size(301, 52);
            this.btnGuardarVariableMedicion.TabIndex = 130;
            this.btnGuardarVariableMedicion.Text = "Guardar Variable de Medición";
            this.btnGuardarVariableMedicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarVariableMedicion.UseVisualStyleBackColor = true;
            this.btnGuardarVariableMedicion.Click += new System.EventHandler(this.btnGuardarVariableMedicion_Click);
            // 
            // ctlEncabezadoPantalla1
            // 
            this.ctlEncabezadoPantalla1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlEncabezadoPantalla1.Location = new System.Drawing.Point(0, 0);
            this.ctlEncabezadoPantalla1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ctlEncabezadoPantalla1.Name = "ctlEncabezadoPantalla1";
            this.ctlEncabezadoPantalla1.Size = new System.Drawing.Size(676, 38);
            this.ctlEncabezadoPantalla1.TabIndex = 129;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(29, 70);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(68, 17);
            this.labelControl11.TabIndex = 127;
            this.labelControl11.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(29, 93);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(604, 30);
            this.txtDescripcion.TabIndex = 128;
            // 
            // nmPrimerValorRango
            // 
            this.nmPrimerValorRango.DecimalPlaces = 2;
            this.nmPrimerValorRango.Location = new System.Drawing.Point(29, 161);
            this.nmPrimerValorRango.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmPrimerValorRango.Name = "nmPrimerValorRango";
            this.nmPrimerValorRango.Size = new System.Drawing.Size(150, 23);
            this.nmPrimerValorRango.TabIndex = 141;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 139);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(115, 17);
            this.labelControl3.TabIndex = 140;
            this.labelControl3.Text = "Primer Valor Rango";
            // 
            // nmSegundoValorRango
            // 
            this.nmSegundoValorRango.DecimalPlaces = 2;
            this.nmSegundoValorRango.Location = new System.Drawing.Point(257, 161);
            this.nmSegundoValorRango.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmSegundoValorRango.Name = "nmSegundoValorRango";
            this.nmSegundoValorRango.Size = new System.Drawing.Size(150, 23);
            this.nmSegundoValorRango.TabIndex = 143;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(257, 139);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 17);
            this.labelControl1.TabIndex = 142;
            this.labelControl1.Text = "Segundo Valor Rango";
            // 
            // nmTolerancia
            // 
            this.nmTolerancia.DecimalPlaces = 2;
            this.nmTolerancia.Location = new System.Drawing.Point(482, 161);
            this.nmTolerancia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmTolerancia.Name = "nmTolerancia";
            this.nmTolerancia.Size = new System.Drawing.Size(150, 23);
            this.nmTolerancia.TabIndex = 145;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(482, 139);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 17);
            this.labelControl2.TabIndex = 144;
            this.labelControl2.Text = "Tolerancia";
            // 
            // glTipoInstrumento
            // 
            this.glTipoInstrumento.EditValue = "";
            this.glTipoInstrumento.Location = new System.Drawing.Point(29, 239);
            this.glTipoInstrumento.Name = "glTipoInstrumento";
            this.glTipoInstrumento.Properties.AutoHeight = false;
            this.glTipoInstrumento.Properties.NullText = "";
            this.glTipoInstrumento.Properties.PopupView = this.glTipoInstrumentoView;
            this.glTipoInstrumento.Size = new System.Drawing.Size(378, 31);
            this.glTipoInstrumento.TabIndex = 147;
            // 
            // glTipoInstrumentoView
            // 
            this.glTipoInstrumentoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoInstrumentoId,
            this.colDescripcion});
            this.glTipoInstrumentoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glTipoInstrumentoView.Name = "glTipoInstrumentoView";
            this.glTipoInstrumentoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glTipoInstrumentoView.OptionsView.ShowGroupPanel = false;
            // 
            // colTipoInstrumentoId
            // 
            this.colTipoInstrumentoId.Caption = "Id";
            this.colTipoInstrumentoId.FieldName = "TipoInstrumentoId";
            this.colTipoInstrumentoId.Name = "colTipoInstrumentoId";
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripcion";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(29, 217);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(118, 17);
            this.labelControl4.TabIndex = 146;
            this.labelControl4.Text = "Tipo de Instrumento";
            // 
            // btnAgregarTipoDeInstrumento
            // 
            this.btnAgregarTipoDeInstrumento.FlatAppearance.BorderSize = 0;
            this.btnAgregarTipoDeInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTipoDeInstrumento.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarTipoDeInstrumento.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarTipoDeInstrumento.IconColor = System.Drawing.Color.Black;
            this.btnAgregarTipoDeInstrumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarTipoDeInstrumento.IconSize = 30;
            this.btnAgregarTipoDeInstrumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTipoDeInstrumento.Location = new System.Drawing.Point(429, 238);
            this.btnAgregarTipoDeInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarTipoDeInstrumento.Name = "btnAgregarTipoDeInstrumento";
            this.btnAgregarTipoDeInstrumento.Size = new System.Drawing.Size(40, 32);
            this.btnAgregarTipoDeInstrumento.TabIndex = 148;
            this.btnAgregarTipoDeInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTipoDeInstrumento.UseVisualStyleBackColor = true;
            this.btnAgregarTipoDeInstrumento.Click += new System.EventHandler(this.btnAgregarTipoDeInstrumento_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalInstrumentos);
            this.panel1.Location = new System.Drawing.Point(28, 532);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 27);
            this.panel1.TabIndex = 150;
            // 
            // lblTotalInstrumentos
            // 
            this.lblTotalInstrumentos.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalInstrumentos.Appearance.Options.UseFont = true;
            this.lblTotalInstrumentos.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalInstrumentos.Location = new System.Drawing.Point(0, 0);
            this.lblTotalInstrumentos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblTotalInstrumentos.Name = "lblTotalInstrumentos";
            this.lblTotalInstrumentos.Size = new System.Drawing.Size(7, 17);
            this.lblTotalInstrumentos.TabIndex = 27;
            this.lblTotalInstrumentos.Text = "0";
            this.lblTotalInstrumentos.Visible = false;
            // 
            // gcTiposDeInstrumento
            // 
            this.gcTiposDeInstrumento.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcTiposDeInstrumento.Location = new System.Drawing.Point(29, 316);
            this.gcTiposDeInstrumento.MainView = this.gvTiposDeInstrumento;
            this.gcTiposDeInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcTiposDeInstrumento.Name = "gcTiposDeInstrumento";
            this.gcTiposDeInstrumento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSeleccionarInstrumento,
            this.btnEliminar});
            this.gcTiposDeInstrumento.Size = new System.Drawing.Size(604, 199);
            this.gcTiposDeInstrumento.TabIndex = 149;
            this.gcTiposDeInstrumento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTiposDeInstrumento});
            // 
            // gvTiposDeInstrumento
            // 
            this.gvTiposDeInstrumento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescripcionTipoInstrumento,
            this.colEliminar});
            this.gvTiposDeInstrumento.GridControl = this.gcTiposDeInstrumento;
            this.gvTiposDeInstrumento.Name = "gvTiposDeInstrumento";
            this.gvTiposDeInstrumento.OptionsView.ShowAutoFilterRow = true;
            this.gvTiposDeInstrumento.OptionsView.ShowGroupPanel = false;
            this.gvTiposDeInstrumento.OptionsView.ShowIndicator = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "TipoInstrumentoId";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colDescripcionTipoInstrumento
            // 
            this.colDescripcionTipoInstrumento.Caption = "Descripción";
            this.colDescripcionTipoInstrumento.FieldName = "TiposDeInstrumentoVariables.TipoDeInstrumento.Descripcion";
            this.colDescripcionTipoInstrumento.MinWidth = 25;
            this.colDescripcionTipoInstrumento.Name = "colDescripcionTipoInstrumento";
            this.colDescripcionTipoInstrumento.Visible = true;
            this.colDescripcionTipoInstrumento.VisibleIndex = 0;
            this.colDescripcionTipoInstrumento.Width = 501;
            // 
            // colEliminar
            // 
            this.colEliminar.ColumnEdit = this.btnEliminar;
            this.colEliminar.MinWidth = 25;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 1;
            this.colEliminar.Width = 40;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // chkSeleccionarInstrumento
            // 
            this.chkSeleccionarInstrumento.AutoHeight = false;
            this.chkSeleccionarInstrumento.Name = "chkSeleccionarInstrumento";
            this.chkSeleccionarInstrumento.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(29, 295);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(190, 17);
            this.labelControl5.TabIndex = 151;
            this.labelControl5.Text = "Tipos de Intrumento Asociados";
            // 
            // frmNuevaVariableMedicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 658);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gcTiposDeInstrumento);
            this.Controls.Add(this.btnAgregarTipoDeInstrumento);
            this.Controls.Add(this.glTipoInstrumento);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.nmTolerancia);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.nmSegundoValorRango);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.nmPrimerValorRango);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnGuardarVariableMedicion);
            this.Controls.Add(this.ctlEncabezadoPantalla1);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtDescripcion);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmNuevaVariableMedicion";
            this.Text = "Agregar Variable de Medición";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrimerValorRango)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSegundoValorRango)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTolerancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumentoView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposDeInstrumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposDeInstrumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionarInstrumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGuardarVariableMedicion;
        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private System.Windows.Forms.NumericUpDown nmPrimerValorRango;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.NumericUpDown nmSegundoValorRango;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.NumericUpDown nmTolerancia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit glTipoInstrumento;
        private DevExpress.XtraGrid.Views.Grid.GridView glTipoInstrumentoView;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInstrumentoId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private FontAwesome.Sharp.IconButton btnAgregarTipoDeInstrumento;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblTotalInstrumentos;
        private DevExpress.XtraGrid.GridControl gcTiposDeInstrumento;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTiposDeInstrumento;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSeleccionarInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionTipoInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEliminar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}