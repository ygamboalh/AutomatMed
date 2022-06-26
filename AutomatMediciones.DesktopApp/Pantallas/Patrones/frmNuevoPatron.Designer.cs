
namespace AutomatMediciones.DesktopApp.Pantallas.Patrones
{
    partial class frmNuevoPatron
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreRango = new DevExpress.XtraEditors.TextEdit();
            this.dateFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVincularVariableMedicion = new FontAwesome.Sharp.IconButton();
            this.nmTolerancia = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nmValorPatron = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.glVariablesDeMedicion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gvVariableMedicion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoInstrumentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalInstrumentos = new DevExpress.XtraEditors.LabelControl();
            this.gcVariablesDeMedicion = new DevExpress.XtraGrid.GridControl();
            this.gvVariablesDeMedicion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVariableMedicionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionVariableMedicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorRango = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTolerancia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorrar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtRutaArchivo = new DevExpress.XtraEditors.TextEdit();
            this.btnAdjunto = new FontAwesome.Sharp.IconButton();
            this.xtraSaveFileDialog2 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreRango.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTolerancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValorPatron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glVariablesDeMedicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVariableMedicion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVariablesDeMedicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVariablesDeMedicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(507, 532);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(207, 42);
            this.btnGuardar.TabIndex = 127;
            this.btnGuardar.Text = "Guardar Patrón";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(21, 82);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(38, 12);
            this.labelControl11.TabIndex = 128;
            this.labelControl11.Text = "Nombre:";
            // 
            // txtNombreRango
            // 
            this.txtNombreRango.EditValue = "";
            this.txtNombreRango.Location = new System.Drawing.Point(21, 102);
            this.txtNombreRango.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreRango.Name = "txtNombreRango";
            this.txtNombreRango.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreRango.Properties.Appearance.Options.UseFont = true;
            this.txtNombreRango.Size = new System.Drawing.Size(343, 26);
            this.txtNombreRango.TabIndex = 129;
            // 
            // dateFechaCaducidad
            // 
            this.dateFechaCaducidad.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaCaducidad.Location = new System.Drawing.Point(382, 101);
            this.dateFechaCaducidad.Name = "dateFechaCaducidad";
            this.dateFechaCaducidad.Size = new System.Drawing.Size(332, 27);
            this.dateFechaCaducidad.TabIndex = 130;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(382, 82);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 12);
            this.labelControl1.TabIndex = 131;
            this.labelControl1.Text = "Fecha de Caducidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVincularVariableMedicion);
            this.groupBox1.Controls.Add(this.nmTolerancia);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.nmValorPatron);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.glVariablesDeMedicion);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(21, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 79);
            this.groupBox1.TabIndex = 132;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variable de Medición para vincular al patrón";
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
            this.btnVincularVariableMedicion.Location = new System.Drawing.Point(639, 35);
            this.btnVincularVariableMedicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVincularVariableMedicion.Name = "btnVincularVariableMedicion";
            this.btnVincularVariableMedicion.Size = new System.Drawing.Size(34, 26);
            this.btnVincularVariableMedicion.TabIndex = 154;
            this.btnVincularVariableMedicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVincularVariableMedicion.UseVisualStyleBackColor = true;
            this.btnVincularVariableMedicion.Click += new System.EventHandler(this.btnVincularVariableMedicion_Click);
            this.btnVincularVariableMedicion.MouseHover += new System.EventHandler(this.btnAgregarTipoDeInstrumento_MouseHover);
            // 
            // nmTolerancia
            // 
            this.nmTolerancia.DecimalPlaces = 2;
            this.nmTolerancia.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmTolerancia.Location = new System.Drawing.Point(480, 38);
            this.nmTolerancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmTolerancia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmTolerancia.Name = "nmTolerancia";
            this.nmTolerancia.Size = new System.Drawing.Size(129, 27);
            this.nmTolerancia.TabIndex = 153;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(480, 21);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 12);
            this.labelControl2.TabIndex = 152;
            this.labelControl2.Text = "Tolerancia";
            // 
            // nmValorPatron
            // 
            this.nmValorPatron.DecimalPlaces = 2;
            this.nmValorPatron.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmValorPatron.Location = new System.Drawing.Point(335, 38);
            this.nmValorPatron.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmValorPatron.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmValorPatron.Name = "nmValorPatron";
            this.nmValorPatron.Size = new System.Drawing.Size(129, 27);
            this.nmValorPatron.TabIndex = 151;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(335, 21);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 12);
            this.labelControl3.TabIndex = 150;
            this.labelControl3.Text = "Valor Patrón:";
            // 
            // glVariablesDeMedicion
            // 
            this.glVariablesDeMedicion.EditValue = "";
            this.glVariablesDeMedicion.Location = new System.Drawing.Point(20, 40);
            this.glVariablesDeMedicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glVariablesDeMedicion.Name = "glVariablesDeMedicion";
            this.glVariablesDeMedicion.Properties.AutoHeight = false;
            this.glVariablesDeMedicion.Properties.NullText = "";
            this.glVariablesDeMedicion.Properties.PopupView = this.gvVariableMedicion;
            this.glVariablesDeMedicion.Size = new System.Drawing.Size(296, 25);
            this.glVariablesDeMedicion.TabIndex = 149;
            this.glVariablesDeMedicion.EditValueChanged += new System.EventHandler(this.glVariablesDeMedicion_EditValueChanged);
            // 
            // gvVariableMedicion
            // 
            this.gvVariableMedicion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoInstrumentoId,
            this.colDescripcion});
            this.gvVariableMedicion.DetailHeight = 284;
            this.gvVariableMedicion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvVariableMedicion.Name = "gvVariableMedicion";
            this.gvVariableMedicion.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvVariableMedicion.OptionsView.ShowGroupPanel = false;
            // 
            // colTipoInstrumentoId
            // 
            this.colTipoInstrumentoId.Caption = "Id";
            this.colTipoInstrumentoId.FieldName = "TipoInstrumentoId";
            this.colTipoInstrumentoId.MinWidth = 17;
            this.colTipoInstrumentoId.Name = "colTipoInstrumentoId";
            this.colTipoInstrumentoId.Width = 64;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripcion";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.MinWidth = 17;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 64;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(20, 22);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 12);
            this.labelControl4.TabIndex = 148;
            this.labelControl4.Text = "Variable de Medición";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(21, 235);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(215, 12);
            this.labelControl5.TabIndex = 154;
            this.labelControl5.Text = "Variables de Medición vinculadas a este patrón";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalInstrumentos);
            this.panel1.Location = new System.Drawing.Point(21, 417);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 22);
            this.panel1.TabIndex = 153;
            // 
            // lblTotalInstrumentos
            // 
            this.lblTotalInstrumentos.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalInstrumentos.Appearance.Options.UseFont = true;
            this.lblTotalInstrumentos.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalInstrumentos.Location = new System.Drawing.Point(0, 0);
            this.lblTotalInstrumentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotalInstrumentos.Name = "lblTotalInstrumentos";
            this.lblTotalInstrumentos.Size = new System.Drawing.Size(6, 12);
            this.lblTotalInstrumentos.TabIndex = 27;
            this.lblTotalInstrumentos.Text = "0";
            this.lblTotalInstrumentos.Visible = false;
            // 
            // gcVariablesDeMedicion
            // 
            this.gcVariablesDeMedicion.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcVariablesDeMedicion.Location = new System.Drawing.Point(21, 252);
            this.gcVariablesDeMedicion.MainView = this.gvVariablesDeMedicion;
            this.gcVariablesDeMedicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcVariablesDeMedicion.Name = "gcVariablesDeMedicion";
            this.gcVariablesDeMedicion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEliminar});
            this.gcVariablesDeMedicion.Size = new System.Drawing.Size(693, 162);
            this.gcVariablesDeMedicion.TabIndex = 152;
            this.gcVariablesDeMedicion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVariablesDeMedicion});
            // 
            // gvVariablesDeMedicion
            // 
            this.gvVariablesDeMedicion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVariableMedicionId,
            this.colDescripcionVariableMedicion,
            this.colValorRango,
            this.colTolerancia,
            this.colBorrar});
            this.gvVariablesDeMedicion.DetailHeight = 284;
            this.gvVariablesDeMedicion.GridControl = this.gcVariablesDeMedicion;
            this.gvVariablesDeMedicion.Name = "gvVariablesDeMedicion";
            this.gvVariablesDeMedicion.OptionsView.ShowAutoFilterRow = true;
            this.gvVariablesDeMedicion.OptionsView.ShowGroupPanel = false;
            this.gvVariablesDeMedicion.OptionsView.ShowIndicator = false;
            // 
            // colVariableMedicionId
            // 
            this.colVariableMedicionId.Caption = "Id";
            this.colVariableMedicionId.FieldName = "VariableMedicionId";
            this.colVariableMedicionId.MinWidth = 21;
            this.colVariableMedicionId.Name = "colVariableMedicionId";
            this.colVariableMedicionId.Width = 81;
            // 
            // colDescripcionVariableMedicion
            // 
            this.colDescripcionVariableMedicion.Caption = "Descripción";
            this.colDescripcionVariableMedicion.FieldName = "VariableDeMedicion.Descripcion";
            this.colDescripcionVariableMedicion.MinWidth = 21;
            this.colDescripcionVariableMedicion.Name = "colDescripcionVariableMedicion";
            this.colDescripcionVariableMedicion.OptionsColumn.AllowEdit = false;
            this.colDescripcionVariableMedicion.OptionsColumn.AllowFocus = false;
            this.colDescripcionVariableMedicion.OptionsColumn.ReadOnly = true;
            this.colDescripcionVariableMedicion.Visible = true;
            this.colDescripcionVariableMedicion.VisibleIndex = 0;
            this.colDescripcionVariableMedicion.Width = 187;
            // 
            // colValorRango
            // 
            this.colValorRango.Caption = "Valor Patrón";
            this.colValorRango.FieldName = "ValorPatron";
            this.colValorRango.MinWidth = 21;
            this.colValorRango.Name = "colValorRango";
            this.colValorRango.OptionsColumn.AllowEdit = false;
            this.colValorRango.OptionsColumn.AllowFocus = false;
            this.colValorRango.OptionsColumn.ReadOnly = true;
            this.colValorRango.Visible = true;
            this.colValorRango.VisibleIndex = 1;
            this.colValorRango.Width = 187;
            // 
            // colTolerancia
            // 
            this.colTolerancia.Caption = "Tolerancia";
            this.colTolerancia.FieldName = "Tolerancia";
            this.colTolerancia.MinWidth = 21;
            this.colTolerancia.Name = "colTolerancia";
            this.colTolerancia.OptionsColumn.AllowEdit = false;
            this.colTolerancia.OptionsColumn.AllowFocus = false;
            this.colTolerancia.OptionsColumn.ReadOnly = true;
            this.colTolerancia.Visible = true;
            this.colTolerancia.VisibleIndex = 2;
            this.colTolerancia.Width = 187;
            // 
            // colBorrar
            // 
            this.colBorrar.ColumnEdit = this.btnEliminar;
            this.colBorrar.MinWidth = 21;
            this.colBorrar.Name = "colBorrar";
            this.colBorrar.Visible = true;
            this.colBorrar.VisibleIndex = 3;
            this.colBorrar.Width = 26;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoHeight = false;
            this.btnEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Quitar Vinculación", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(21, 459);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(117, 12);
            this.labelControl6.TabIndex = 155;
            this.labelControl6.Text = "Dirección Archivo Adjunto:";
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.EditValue = "";
            this.txtRutaArchivo.Location = new System.Drawing.Point(21, 479);
            this.txtRutaArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRutaArchivo.Properties.Appearance.Options.UseFont = true;
            this.txtRutaArchivo.Size = new System.Drawing.Size(651, 26);
            this.txtRutaArchivo.TabIndex = 156;
            // 
            // btnAdjunto
            // 
            this.btnAdjunto.FlatAppearance.BorderSize = 0;
            this.btnAdjunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjunto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdjunto.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.btnAdjunto.IconColor = System.Drawing.Color.Black;
            this.btnAdjunto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdjunto.IconSize = 30;
            this.btnAdjunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdjunto.Location = new System.Drawing.Point(680, 481);
            this.btnAdjunto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdjunto.Name = "btnAdjunto";
            this.btnAdjunto.Size = new System.Drawing.Size(34, 26);
            this.btnAdjunto.TabIndex = 157;
            this.btnAdjunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdjunto.UseVisualStyleBackColor = true;
            this.btnAdjunto.Click += new System.EventHandler(this.btnAdjunto_Click);
            this.btnAdjunto.MouseHover += new System.EventHandler(this.btnAdjunto_MouseHover);
            // 
            // xtraSaveFileDialog2
            // 
            this.xtraSaveFileDialog2.FileName = "xtraSaveFileDialog1";
            // 
            // frmNuevoPatron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 593);
            this.Controls.Add(this.btnAdjunto);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gcVariablesDeMedicion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dateFechaCaducidad);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtNombreRango);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNuevoPatron";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmNuevoPatron_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreRango.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTolerancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValorPatron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glVariablesDeMedicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVariableMedicion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVariablesDeMedicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVariablesDeMedicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtNombreRango;
        private System.Windows.Forms.DateTimePicker dateFechaCaducidad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.GridLookUpEdit glVariablesDeMedicion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVariableMedicion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInstrumentoId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.NumericUpDown nmTolerancia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.NumericUpDown nmValorPatron;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private FontAwesome.Sharp.IconButton btnVincularVariableMedicion;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblTotalInstrumentos;
        private DevExpress.XtraGrid.GridControl gcVariablesDeMedicion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVariablesDeMedicion;
        private DevExpress.XtraGrid.Columns.GridColumn colVariableMedicionId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionVariableMedicion;
        private DevExpress.XtraGrid.Columns.GridColumn colValorRango;
        private DevExpress.XtraGrid.Columns.GridColumn colTolerancia;
        private DevExpress.XtraGrid.Columns.GridColumn colBorrar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEliminar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtRutaArchivo;
        private FontAwesome.Sharp.IconButton btnAdjunto;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog2;
    }
}