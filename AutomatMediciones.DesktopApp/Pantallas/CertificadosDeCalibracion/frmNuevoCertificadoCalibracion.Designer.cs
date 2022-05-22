
namespace AutomatMediciones.DesktopApp.Pantallas.CertificadosDeCalibracion
{
    partial class frmNuevoCertificadoCalibracion
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoCertificadoCalibracion));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dateFechaCertificado = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.memoCondicionesAmbientales = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerarCertificado = new FontAwesome.Sharp.IconButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.glUsuariosResponsables = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glUsuariosResponsablesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUsuarioId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnVincularVariableMedicion = new FontAwesome.Sharp.IconButton();
            this.nmValorPatron = new System.Windows.Forms.NumericUpDown();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.glVariablesDeMedicion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glVariablesDeMedicionView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoInstrumentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gcTiposDeInstrumento = new DevExpress.XtraGrid.GridControl();
            this.gvTiposDeInstrumento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcionPatron = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVariableMedicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorMedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoCondicionesAmbientales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsables.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsablesView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValorPatron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glVariablesDeMedicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glVariablesDeMedicionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposDeInstrumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposDeInstrumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFechaCertificado
            // 
            this.dateFechaCertificado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaCertificado.Location = new System.Drawing.Point(37, 94);
            this.dateFechaCertificado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateFechaCertificado.Name = "dateFechaCertificado";
            this.dateFechaCertificado.Size = new System.Drawing.Size(303, 30);
            this.dateFechaCertificado.TabIndex = 35;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(37, 75);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(122, 17);
            this.labelControl4.TabIndex = 34;
            this.labelControl4.Text = "Fecha de Certificado:";
            // 
            // memoCondicionesAmbientales
            // 
            this.memoCondicionesAmbientales.Location = new System.Drawing.Point(37, 164);
            this.memoCondicionesAmbientales.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoCondicionesAmbientales.Name = "memoCondicionesAmbientales";
            this.memoCondicionesAmbientales.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoCondicionesAmbientales.Properties.Appearance.Options.UseFont = true;
            this.memoCondicionesAmbientales.Size = new System.Drawing.Size(632, 71);
            this.memoCondicionesAmbientales.TabIndex = 130;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(37, 143);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(149, 17);
            this.labelControl3.TabIndex = 129;
            this.labelControl3.Text = "Condiciones Ambientales:";
            // 
            // dateFechaCaducidad
            // 
            this.dateFechaCaducidad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaCaducidad.Location = new System.Drawing.Point(366, 94);
            this.dateFechaCaducidad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateFechaCaducidad.Name = "dateFechaCaducidad";
            this.dateFechaCaducidad.Size = new System.Drawing.Size(303, 30);
            this.dateFechaCaducidad.TabIndex = 132;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(366, 75);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 17);
            this.labelControl1.TabIndex = 131;
            this.labelControl1.Text = "Fecha de Caducidad:";
            // 
            // btnGenerarCertificado
            // 
            this.btnGenerarCertificado.FlatAppearance.BorderSize = 0;
            this.btnGenerarCertificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCertificado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerarCertificado.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGenerarCertificado.IconColor = System.Drawing.Color.Black;
            this.btnGenerarCertificado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarCertificado.IconSize = 30;
            this.btnGenerarCertificado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarCertificado.Location = new System.Drawing.Point(689, 678);
            this.btnGenerarCertificado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGenerarCertificado.Name = "btnGenerarCertificado";
            this.btnGenerarCertificado.Size = new System.Drawing.Size(220, 52);
            this.btnGenerarCertificado.TabIndex = 133;
            this.btnGenerarCertificado.Text = "Generar Certificado";
            this.btnGenerarCertificado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarCertificado.UseVisualStyleBackColor = true;
            this.btnGenerarCertificado.Click += new System.EventHandler(this.btnGenerarCertificado_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(37, 596);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(127, 17);
            this.labelControl6.TabIndex = 134;
            this.labelControl6.Text = "Usuario Responsable:";
            // 
            // glUsuariosResponsables
            // 
            this.glUsuariosResponsables.Location = new System.Drawing.Point(37, 617);
            this.glUsuariosResponsables.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glUsuariosResponsables.Name = "glUsuariosResponsables";
            this.glUsuariosResponsables.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glUsuariosResponsables.Properties.Appearance.Options.UseFont = true;
            this.glUsuariosResponsables.Properties.NullText = "";
            this.glUsuariosResponsables.Properties.PopupView = this.glUsuariosResponsablesView;
            this.glUsuariosResponsables.Size = new System.Drawing.Size(303, 30);
            this.glUsuariosResponsables.TabIndex = 135;
            this.glUsuariosResponsables.EditValueChanged += new System.EventHandler(this.glUsuariosResponsables_EditValueChanged);
            // 
            // glUsuariosResponsablesView
            // 
            this.glUsuariosResponsablesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUsuarioId,
            this.colNombreUsuario});
            this.glUsuariosResponsablesView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glUsuariosResponsablesView.Name = "glUsuariosResponsablesView";
            this.glUsuariosResponsablesView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glUsuariosResponsablesView.OptionsView.ShowColumnHeaders = false;
            this.glUsuariosResponsablesView.OptionsView.ShowGroupPanel = false;
            this.glUsuariosResponsablesView.OptionsView.ShowIndicator = false;
            // 
            // colUsuarioId
            // 
            this.colUsuarioId.Caption = "Id";
            this.colUsuarioId.FieldName = "UsuarioId";
            this.colUsuarioId.Name = "colUsuarioId";
            this.colUsuarioId.OptionsColumn.AllowEdit = false;
            this.colUsuarioId.OptionsColumn.ReadOnly = true;
            // 
            // colNombreUsuario
            // 
            this.colNombreUsuario.Caption = "Nombre";
            this.colNombreUsuario.FieldName = "Nombre";
            this.colNombreUsuario.Name = "colNombreUsuario";
            this.colNombreUsuario.OptionsColumn.AllowEdit = false;
            this.colNombreUsuario.OptionsColumn.ReadOnly = true;
            this.colNombreUsuario.Visible = true;
            this.colNombreUsuario.VisibleIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gcTiposDeInstrumento);
            this.groupBox1.Controls.Add(this.gridLookUpEdit1);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.btnVincularVariableMedicion);
            this.groupBox1.Controls.Add(this.nmValorPatron);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.glVariablesDeMedicion);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(37, 265);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(872, 313);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variable de Certificado";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.EditValue = "";
            this.gridLookUpEdit1.Location = new System.Drawing.Point(329, 49);
            this.gridLookUpEdit1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.AutoHeight = false;
            this.gridLookUpEdit1.Properties.NullText = "";
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(287, 31);
            this.gridLookUpEdit1.TabIndex = 156;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "TipoInstrumentoId";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descripcion";
            this.gridColumn2.FieldName = "Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(330, 28);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 17);
            this.labelControl2.TabIndex = 155;
            this.labelControl2.Text = "Patrón";
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
            this.btnVincularVariableMedicion.Location = new System.Drawing.Point(806, 48);
            this.btnVincularVariableMedicion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnVincularVariableMedicion.Name = "btnVincularVariableMedicion";
            this.btnVincularVariableMedicion.Size = new System.Drawing.Size(40, 32);
            this.btnVincularVariableMedicion.TabIndex = 154;
            this.btnVincularVariableMedicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVincularVariableMedicion.UseVisualStyleBackColor = true;
            // 
            // nmValorPatron
            // 
            this.nmValorPatron.DecimalPlaces = 2;
            this.nmValorPatron.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmValorPatron.Location = new System.Drawing.Point(638, 49);
            this.nmValorPatron.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nmValorPatron.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmValorPatron.Name = "nmValorPatron";
            this.nmValorPatron.Size = new System.Drawing.Size(150, 31);
            this.nmValorPatron.TabIndex = 151;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(639, 29);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 17);
            this.labelControl5.TabIndex = 150;
            this.labelControl5.Text = "Valor Patrón:";
            // 
            // glVariablesDeMedicion
            // 
            this.glVariablesDeMedicion.EditValue = "";
            this.glVariablesDeMedicion.Location = new System.Drawing.Point(23, 49);
            this.glVariablesDeMedicion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glVariablesDeMedicion.Name = "glVariablesDeMedicion";
            this.glVariablesDeMedicion.Properties.AutoHeight = false;
            this.glVariablesDeMedicion.Properties.NullText = "";
            this.glVariablesDeMedicion.Properties.PopupView = this.glVariablesDeMedicionView;
            this.glVariablesDeMedicion.Size = new System.Drawing.Size(280, 31);
            this.glVariablesDeMedicion.TabIndex = 149;
            // 
            // glVariablesDeMedicionView
            // 
            this.glVariablesDeMedicionView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoInstrumentoId,
            this.colDescripcion});
            this.glVariablesDeMedicionView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glVariablesDeMedicionView.Name = "glVariablesDeMedicionView";
            this.glVariablesDeMedicionView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glVariablesDeMedicionView.OptionsView.ShowGroupPanel = false;
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
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(24, 28);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(38, 17);
            this.labelControl7.TabIndex = 148;
            this.labelControl7.Text = "Patrón";
            // 
            // gcTiposDeInstrumento
            // 
            this.gcTiposDeInstrumento.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcTiposDeInstrumento.Location = new System.Drawing.Point(23, 94);
            this.gcTiposDeInstrumento.MainView = this.gvTiposDeInstrumento;
            this.gcTiposDeInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcTiposDeInstrumento.Name = "gcTiposDeInstrumento";
            this.gcTiposDeInstrumento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEliminar});
            this.gcTiposDeInstrumento.Size = new System.Drawing.Size(823, 199);
            this.gcTiposDeInstrumento.TabIndex = 157;
            this.gcTiposDeInstrumento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTiposDeInstrumento});
            // 
            // gvTiposDeInstrumento
            // 
            this.gvTiposDeInstrumento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcionPatron,
            this.colVariableMedicion,
            this.colValorMedido,
            this.colEliminar});
            this.gvTiposDeInstrumento.GridControl = this.gcTiposDeInstrumento;
            this.gvTiposDeInstrumento.Name = "gvTiposDeInstrumento";
            this.gvTiposDeInstrumento.OptionsView.ShowAutoFilterRow = true;
            this.gvTiposDeInstrumento.OptionsView.ShowGroupPanel = false;
            this.gvTiposDeInstrumento.OptionsView.ShowIndicator = false;
            // 
            // colDescripcionPatron
            // 
            this.colDescripcionPatron.Caption = "Patrón";
            this.colDescripcionPatron.FieldName = "Descripcion";
            this.colDescripcionPatron.MinWidth = 25;
            this.colDescripcionPatron.Name = "colDescripcionPatron";
            this.colDescripcionPatron.Visible = true;
            this.colDescripcionPatron.VisibleIndex = 0;
            this.colDescripcionPatron.Width = 94;
            // 
            // colVariableMedicion
            // 
            this.colVariableMedicion.Caption = "Variable de Medición";
            this.colVariableMedicion.FieldName = "Descripcion";
            this.colVariableMedicion.MinWidth = 25;
            this.colVariableMedicion.Name = "colVariableMedicion";
            this.colVariableMedicion.Visible = true;
            this.colVariableMedicion.VisibleIndex = 1;
            this.colVariableMedicion.Width = 94;
            // 
            // colValorMedido
            // 
            this.colValorMedido.Caption = "Valor Medido";
            this.colValorMedido.FieldName = "ValorMedido";
            this.colValorMedido.MinWidth = 25;
            this.colValorMedido.Name = "colValorMedido";
            this.colValorMedido.Visible = true;
            this.colValorMedido.VisibleIndex = 2;
            this.colValorMedido.Width = 94;
            // 
            // colEliminar
            // 
            this.colEliminar.ColumnEdit = this.btnEliminar;
            this.colEliminar.MinWidth = 25;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 3;
            this.colEliminar.Width = 30;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Eliminar", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmNuevoCertificadoCalibracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 752);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.glUsuariosResponsables);
            this.Controls.Add(this.btnGenerarCertificado);
            this.Controls.Add(this.dateFechaCaducidad);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.memoCondicionesAmbientales);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dateFechaCertificado);
            this.Controls.Add(this.labelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNuevoCertificadoCalibracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNuevoCertificadoCalibracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoCondicionesAmbientales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsables.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsablesView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValorPatron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glVariablesDeMedicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glVariablesDeMedicionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposDeInstrumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposDeInstrumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateFechaCertificado;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit memoCondicionesAmbientales;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dateFechaCaducidad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private FontAwesome.Sharp.IconButton btnGenerarCertificado;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GridLookUpEdit glUsuariosResponsables;
        private DevExpress.XtraGrid.Views.Grid.GridView glUsuariosResponsablesView;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private FontAwesome.Sharp.IconButton btnVincularVariableMedicion;
        private System.Windows.Forms.NumericUpDown nmValorPatron;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GridLookUpEdit glVariablesDeMedicion;
        private DevExpress.XtraGrid.Views.Grid.GridView glVariablesDeMedicionView;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInstrumentoId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl gcTiposDeInstrumento;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTiposDeInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionPatron;
        private DevExpress.XtraGrid.Columns.GridColumn colVariableMedicion;
        private DevExpress.XtraGrid.Columns.GridColumn colValorMedido;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEliminar;
    }
}