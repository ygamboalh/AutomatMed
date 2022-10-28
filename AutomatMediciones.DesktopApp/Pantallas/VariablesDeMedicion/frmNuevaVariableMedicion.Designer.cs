
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaVariableMedicion));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnGuardarVariableMedicion = new FontAwesome.Sharp.IconButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.nmPrimerValorRango = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.nmSegundoValorRango = new System.Windows.Forms.NumericUpDown();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nmTolerancia = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnVincularVariableMedicion = new FontAwesome.Sharp.IconButton();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcionCorta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.leTipInstrumento = new DevExpress.XtraEditors.LookUpEdit();
            this.leUnidadDeMedida = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrimerValorRango)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSegundoValorRango)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTolerancia)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposDeInstrumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposDeInstrumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionarInstrumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionCorta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTipInstrumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leUnidadDeMedida.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.btnGuardarVariableMedicion.Location = new System.Drawing.Point(642, 582);
            this.btnGuardarVariableMedicion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarVariableMedicion.Name = "btnGuardarVariableMedicion";
            this.btnGuardarVariableMedicion.Size = new System.Drawing.Size(301, 52);
            this.btnGuardarVariableMedicion.TabIndex = 130;
            this.btnGuardarVariableMedicion.Text = "Guardar Variable de Medición";
            this.btnGuardarVariableMedicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarVariableMedicion.UseVisualStyleBackColor = true;
            this.btnGuardarVariableMedicion.Click += new System.EventHandler(this.btnGuardarVariableMedicion_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(452, 60);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(68, 17);
            this.labelControl11.TabIndex = 127;
            this.labelControl11.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(452, 84);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(484, 26);
            this.txtDescripcion.TabIndex = 128;
            // 
            // nmPrimerValorRango
            // 
            this.nmPrimerValorRango.DecimalPlaces = 2;
            this.nmPrimerValorRango.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmPrimerValorRango.Location = new System.Drawing.Point(425, 139);
            this.nmPrimerValorRango.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nmPrimerValorRango.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmPrimerValorRango.Name = "nmPrimerValorRango";
            this.nmPrimerValorRango.Size = new System.Drawing.Size(160, 27);
            this.nmPrimerValorRango.TabIndex = 141;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(425, 120);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(115, 17);
            this.labelControl3.TabIndex = 140;
            this.labelControl3.Text = "Primer Valor Rango";
            // 
            // nmSegundoValorRango
            // 
            this.nmSegundoValorRango.DecimalPlaces = 2;
            this.nmSegundoValorRango.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmSegundoValorRango.Location = new System.Drawing.Point(596, 139);
            this.nmSegundoValorRango.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nmSegundoValorRango.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmSegundoValorRango.Name = "nmSegundoValorRango";
            this.nmSegundoValorRango.Size = new System.Drawing.Size(157, 27);
            this.nmSegundoValorRango.TabIndex = 143;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(596, 118);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 17);
            this.labelControl1.TabIndex = 142;
            this.labelControl1.Text = "Segundo Valor Rango";
            // 
            // nmTolerancia
            // 
            this.nmTolerancia.DecimalPlaces = 2;
            this.nmTolerancia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmTolerancia.Location = new System.Drawing.Point(771, 139);
            this.nmTolerancia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nmTolerancia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmTolerancia.Name = "nmTolerancia";
            this.nmTolerancia.Size = new System.Drawing.Size(172, 27);
            this.nmTolerancia.TabIndex = 145;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(771, 117);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 17);
            this.labelControl2.TabIndex = 144;
            this.labelControl2.Text = "Tolerancia";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(20, 25);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(118, 17);
            this.labelControl4.TabIndex = 146;
            this.labelControl4.Text = "Tipo de Instrumento";
            // 
            // btnVincularVariableMedicion
            // 
            this.btnVincularVariableMedicion.FlatAppearance.BorderSize = 0;
            this.btnVincularVariableMedicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincularVariableMedicion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVincularVariableMedicion.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnVincularVariableMedicion.IconColor = System.Drawing.Color.Black;
            this.btnVincularVariableMedicion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVincularVariableMedicion.IconSize = 30;
            this.btnVincularVariableMedicion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVincularVariableMedicion.Location = new System.Drawing.Point(306, 45);
            this.btnVincularVariableMedicion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnVincularVariableMedicion.Name = "btnVincularVariableMedicion";
            this.btnVincularVariableMedicion.Size = new System.Drawing.Size(40, 32);
            this.btnVincularVariableMedicion.TabIndex = 148;
            this.btnVincularVariableMedicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVincularVariableMedicion.UseVisualStyleBackColor = true;
            this.btnVincularVariableMedicion.Click += new System.EventHandler(this.btnAgregarTipoDeInstrumento_Click);
            this.btnVincularVariableMedicion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAgregarTipoDeInstrumento_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalInstrumentos);
            this.panel1.Location = new System.Drawing.Point(20, 319);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 27);
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
            this.gcTiposDeInstrumento.Location = new System.Drawing.Point(20, 116);
            this.gcTiposDeInstrumento.MainView = this.gvTiposDeInstrumento;
            this.gcTiposDeInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcTiposDeInstrumento.Name = "gcTiposDeInstrumento";
            this.gcTiposDeInstrumento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSeleccionarInstrumento,
            this.btnEliminar});
            this.gcTiposDeInstrumento.Size = new System.Drawing.Size(889, 196);
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
            this.colId.MinWidth = 24;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colDescripcionTipoInstrumento
            // 
            this.colDescripcionTipoInstrumento.Caption = "Descripción";
            this.colDescripcionTipoInstrumento.FieldName = "TipoInstrumento.Descripcion";
            this.colDescripcionTipoInstrumento.MinWidth = 24;
            this.colDescripcionTipoInstrumento.Name = "colDescripcionTipoInstrumento";
            this.colDescripcionTipoInstrumento.Visible = true;
            this.colDescripcionTipoInstrumento.VisibleIndex = 0;
            this.colDescripcionTipoInstrumento.Width = 500;
            // 
            // colEliminar
            // 
            this.colEliminar.ColumnEdit = this.btnEliminar;
            this.colEliminar.MinWidth = 24;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 1;
            this.colEliminar.Width = 40;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            this.labelControl5.Location = new System.Drawing.Point(20, 95);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(190, 17);
            this.labelControl5.TabIndex = 151;
            this.labelControl5.Text = "Tipos de Intrumento Asociados";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(244, 120);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(104, 17);
            this.labelControl6.TabIndex = 152;
            this.labelControl6.Text = "Descripción Corta";
            // 
            // txtDescripcionCorta
            // 
            this.txtDescripcionCorta.EditValue = "";
            this.txtDescripcionCorta.Location = new System.Drawing.Point(244, 140);
            this.txtDescripcionCorta.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescripcionCorta.Name = "txtDescripcionCorta";
            this.txtDescripcionCorta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcionCorta.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcionCorta.Size = new System.Drawing.Size(164, 26);
            this.txtDescripcionCorta.TabIndex = 153;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(27, 60);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 17);
            this.labelControl7.TabIndex = 154;
            this.labelControl7.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.EditValue = "";
            this.txtNombre.Location = new System.Drawing.Point(27, 84);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(417, 26);
            this.txtNombre.TabIndex = 155;
            // 
            // leTipInstrumento
            // 
            this.leTipInstrumento.Location = new System.Drawing.Point(20, 49);
            this.leTipInstrumento.Margin = new System.Windows.Forms.Padding(4);
            this.leTipInstrumento.Name = "leTipInstrumento";
            this.leTipInstrumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leTipInstrumento.Properties.Appearance.Options.UseFont = true;
            this.leTipInstrumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leTipInstrumento.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Tipo de Instrumento", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Metodologia", "Metodología", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Resumen", "Resumen", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.leTipInstrumento.Properties.NullText = "";
            this.leTipInstrumento.Size = new System.Drawing.Size(278, 26);
            this.leTipInstrumento.TabIndex = 156;
            // 
            // leUnidadDeMedida
            // 
            this.leUnidadDeMedida.Location = new System.Drawing.Point(29, 141);
            this.leUnidadDeMedida.Margin = new System.Windows.Forms.Padding(4);
            this.leUnidadDeMedida.Name = "leUnidadDeMedida";
            this.leUnidadDeMedida.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leUnidadDeMedida.Properties.Appearance.Options.UseFont = true;
            this.leUnidadDeMedida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leUnidadDeMedida.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Unidad de Medida", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.leUnidadDeMedida.Properties.NullText = "";
            this.leUnidadDeMedida.Size = new System.Drawing.Size(208, 26);
            this.leUnidadDeMedida.TabIndex = 158;
            this.leUnidadDeMedida.EditValueChanged += new System.EventHandler(this.leUnidadDeMedida_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(29, 120);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(113, 17);
            this.labelControl8.TabIndex = 157;
            this.labelControl8.Text = "Unidad de Medida:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.btnVincularVariableMedicion);
            this.groupBox1.Controls.Add(this.leTipInstrumento);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.gcTiposDeInstrumento);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(27, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 375);
            this.groupBox1.TabIndex = 159;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asociación de Instrumentos";
            // 
            // frmNuevaVariableMedicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 655);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.leUnidadDeMedida);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtDescripcionCorta);
            this.Controls.Add(this.nmTolerancia);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.nmSegundoValorRango);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.nmPrimerValorRango);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnGuardarVariableMedicion);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmNuevaVariableMedicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrimerValorRango)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSegundoValorRango)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTolerancia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposDeInstrumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposDeInstrumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionarInstrumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionCorta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTipInstrumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leUnidadDeMedida.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private FontAwesome.Sharp.IconButton btnVincularVariableMedicion;
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
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtDescripcionCorta;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LookUpEdit leTipInstrumento;
        private DevExpress.XtraEditors.LookUpEdit leUnidadDeMedida;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}