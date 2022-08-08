
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
            this.components = new System.ComponentModel.Container();
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
            this.lookupVariableDeInstrumento = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpPatron = new DevExpress.XtraEditors.LookUpEdit();
            this.gcVariablesCertificado = new DevExpress.XtraGrid.GridControl();
            this.gvVariablesCertificado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcionPatron = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVariableMedicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorMedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregarVariable = new FontAwesome.Sharp.IconButton();
            this.nmValorMedido = new System.Windows.Forms.NumericUpDown();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.memoResultado = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.memoObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdjunto = new FontAwesome.Sharp.IconButton();
            this.lblCertificado = new DevExpress.XtraEditors.LabelControl();
            this.txtRutaArchivo = new DevExpress.XtraEditors.TextEdit();
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.memoCondicionesAmbientales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsables.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsablesView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupVariableDeInstrumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPatron.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVariablesCertificado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVariablesCertificado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValorMedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoResultado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFechaCertificado
            // 
            this.dateFechaCertificado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaCertificado.Location = new System.Drawing.Point(37, 94);
            this.dateFechaCertificado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateFechaCertificado.Name = "dateFechaCertificado";
            this.dateFechaCertificado.Size = new System.Drawing.Size(364, 30);
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
            this.memoCondicionesAmbientales.Location = new System.Drawing.Point(37, 154);
            this.memoCondicionesAmbientales.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoCondicionesAmbientales.Name = "memoCondicionesAmbientales";
            this.memoCondicionesAmbientales.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoCondicionesAmbientales.Properties.Appearance.Options.UseFont = true;
            this.memoCondicionesAmbientales.Size = new System.Drawing.Size(364, 71);
            this.memoCondicionesAmbientales.TabIndex = 130;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(37, 133);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(149, 17);
            this.labelControl3.TabIndex = 129;
            this.labelControl3.Text = "Condiciones Ambientales:";
            // 
            // dateFechaCaducidad
            // 
            this.dateFechaCaducidad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaCaducidad.Location = new System.Drawing.Point(440, 94);
            this.dateFechaCaducidad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateFechaCaducidad.Name = "dateFechaCaducidad";
            this.dateFechaCaducidad.Size = new System.Drawing.Size(376, 30);
            this.dateFechaCaducidad.TabIndex = 132;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(440, 75);
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
            this.btnGenerarCertificado.Location = new System.Drawing.Point(596, 678);
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
            this.labelControl6.Location = new System.Drawing.Point(513, 611);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(127, 17);
            this.labelControl6.TabIndex = 134;
            this.labelControl6.Text = "Usuario Responsable:";
            // 
            // glUsuariosResponsables
            // 
            this.glUsuariosResponsables.Location = new System.Drawing.Point(513, 632);
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
            this.groupBox1.Controls.Add(this.lookupVariableDeInstrumento);
            this.groupBox1.Controls.Add(this.lookUpPatron);
            this.groupBox1.Controls.Add(this.gcVariablesCertificado);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.btnAgregarVariable);
            this.groupBox1.Controls.Add(this.nmValorMedido);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(37, 314);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(779, 250);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variables de Certificado";
            // 
            // lookupVariableDeInstrumento
            // 
            this.lookupVariableDeInstrumento.Location = new System.Drawing.Point(312, 40);
            this.lookupVariableDeInstrumento.Name = "lookupVariableDeInstrumento";
            this.lookupVariableDeInstrumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lookupVariableDeInstrumento.Properties.Appearance.Options.UseFont = true;
            this.lookupVariableDeInstrumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupVariableDeInstrumento.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VariableInstrumentoId", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VariableDeMedicion.Descripcion", "Descripción")});
            this.lookupVariableDeInstrumento.Properties.NullText = "";
            this.lookupVariableDeInstrumento.Size = new System.Drawing.Size(279, 30);
            this.lookupVariableDeInstrumento.TabIndex = 159;
            this.lookupVariableDeInstrumento.EditValueChanged += new System.EventHandler(this.glVariableInstrumento_EditValueChanged);
            // 
            // lookUpPatron
            // 
            this.lookUpPatron.Location = new System.Drawing.Point(27, 40);
            this.lookUpPatron.Name = "lookUpPatron";
            this.lookUpPatron.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lookUpPatron.Properties.Appearance.Options.UseFont = true;
            this.lookUpPatron.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPatron.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PatronId", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre de Patrón")});
            this.lookUpPatron.Properties.NullText = "";
            this.lookUpPatron.Size = new System.Drawing.Size(279, 30);
            this.lookUpPatron.TabIndex = 158;
            this.lookUpPatron.EditValueChanged += new System.EventHandler(this.glPatrones_EditValueChanged);
            // 
            // gcVariablesCertificado
            // 
            this.gcVariablesCertificado.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcVariablesCertificado.Location = new System.Drawing.Point(26, 75);
            this.gcVariablesCertificado.MainView = this.gvVariablesCertificado;
            this.gcVariablesCertificado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcVariablesCertificado.Name = "gcVariablesCertificado";
            this.gcVariablesCertificado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEliminar});
            this.gcVariablesCertificado.Size = new System.Drawing.Size(734, 159);
            this.gcVariablesCertificado.TabIndex = 157;
            this.gcVariablesCertificado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVariablesCertificado});
            // 
            // gvVariablesCertificado
            // 
            this.gvVariablesCertificado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcionPatron,
            this.colVariableMedicion,
            this.colValorMedido,
            this.colEliminar});
            this.gvVariablesCertificado.GridControl = this.gcVariablesCertificado;
            this.gvVariablesCertificado.Name = "gvVariablesCertificado";
            this.gvVariablesCertificado.OptionsView.ShowAutoFilterRow = true;
            this.gvVariablesCertificado.OptionsView.ShowGroupPanel = false;
            this.gvVariablesCertificado.OptionsView.ShowIndicator = false;
            // 
            // colDescripcionPatron
            // 
            this.colDescripcionPatron.Caption = "Patrón";
            this.colDescripcionPatron.FieldName = "Patron.Nombre";
            this.colDescripcionPatron.MinWidth = 25;
            this.colDescripcionPatron.Name = "colDescripcionPatron";
            this.colDescripcionPatron.OptionsColumn.AllowEdit = false;
            this.colDescripcionPatron.OptionsColumn.AllowFocus = false;
            this.colDescripcionPatron.OptionsColumn.ReadOnly = true;
            this.colDescripcionPatron.Visible = true;
            this.colDescripcionPatron.VisibleIndex = 0;
            this.colDescripcionPatron.Width = 94;
            // 
            // colVariableMedicion
            // 
            this.colVariableMedicion.Caption = "Variable de Medición";
            this.colVariableMedicion.FieldName = "VariableInstrumento.VariableDeMedicion.Descripcion";
            this.colVariableMedicion.MinWidth = 25;
            this.colVariableMedicion.Name = "colVariableMedicion";
            this.colVariableMedicion.OptionsColumn.AllowEdit = false;
            this.colVariableMedicion.OptionsColumn.AllowFocus = false;
            this.colVariableMedicion.OptionsColumn.ReadOnly = true;
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
            this.colValorMedido.OptionsColumn.AllowEdit = false;
            this.colValorMedido.OptionsColumn.AllowFocus = false;
            this.colValorMedido.OptionsColumn.ReadOnly = true;
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(313, 22);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(140, 17);
            this.labelControl2.TabIndex = 155;
            this.labelControl2.Text = "Variable de Instrumento";
            // 
            // btnAgregarVariable
            // 
            this.btnAgregarVariable.FlatAppearance.BorderSize = 0;
            this.btnAgregarVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVariable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarVariable.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarVariable.IconColor = System.Drawing.Color.Black;
            this.btnAgregarVariable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarVariable.IconSize = 30;
            this.btnAgregarVariable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarVariable.Location = new System.Drawing.Point(720, 38);
            this.btnAgregarVariable.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarVariable.Name = "btnAgregarVariable";
            this.btnAgregarVariable.Size = new System.Drawing.Size(40, 32);
            this.btnAgregarVariable.TabIndex = 154;
            this.btnAgregarVariable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarVariable.UseVisualStyleBackColor = true;
            this.btnAgregarVariable.Click += new System.EventHandler(this.btnAgregarVariable_Click);
            // 
            // nmValorMedido
            // 
            this.nmValorMedido.DecimalPlaces = 2;
            this.nmValorMedido.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmValorMedido.Location = new System.Drawing.Point(598, 39);
            this.nmValorMedido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nmValorMedido.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmValorMedido.Name = "nmValorMedido";
            this.nmValorMedido.Size = new System.Drawing.Size(114, 31);
            this.nmValorMedido.TabIndex = 151;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(598, 22);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 17);
            this.labelControl5.TabIndex = 150;
            this.labelControl5.Text = "Valor Medido:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(27, 22);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(38, 17);
            this.labelControl7.TabIndex = 148;
            this.labelControl7.Text = "Patrón";
            // 
            // memoResultado
            // 
            this.memoResultado.Location = new System.Drawing.Point(440, 154);
            this.memoResultado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoResultado.Name = "memoResultado";
            this.memoResultado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoResultado.Properties.Appearance.Options.UseFont = true;
            this.memoResultado.Size = new System.Drawing.Size(376, 71);
            this.memoResultado.TabIndex = 138;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(440, 133);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(61, 17);
            this.labelControl8.TabIndex = 137;
            this.labelControl8.Text = "Resultado:";
            // 
            // memoObservaciones
            // 
            this.memoObservaciones.Location = new System.Drawing.Point(40, 591);
            this.memoObservaciones.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoObservaciones.Name = "memoObservaciones";
            this.memoObservaciones.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoObservaciones.Properties.Appearance.Options.UseFont = true;
            this.memoObservaciones.Size = new System.Drawing.Size(450, 71);
            this.memoObservaciones.TabIndex = 140;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(40, 570);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(89, 17);
            this.labelControl9.TabIndex = 139;
            this.labelControl9.Text = "Observaciones:";
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
            this.btnAdjunto.Location = new System.Drawing.Point(776, 267);
            this.btnAdjunto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdjunto.Name = "btnAdjunto";
            this.btnAdjunto.Size = new System.Drawing.Size(40, 32);
            this.btnAdjunto.TabIndex = 160;
            this.btnAdjunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdjunto.UseVisualStyleBackColor = true;
            this.btnAdjunto.Click += new System.EventHandler(this.btnAdjunto_Click);
            // 
            // lblCertificado
            // 
            this.lblCertificado.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCertificado.Appearance.Options.UseFont = true;
            this.lblCertificado.Location = new System.Drawing.Point(37, 239);
            this.lblCertificado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblCertificado.Name = "lblCertificado";
            this.lblCertificado.Size = new System.Drawing.Size(153, 17);
            this.lblCertificado.TabIndex = 158;
            this.lblCertificado.Text = "Dirección Archivo Adjunto:";
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.EditValue = "";
            this.txtRutaArchivo.Location = new System.Drawing.Point(37, 264);
            this.txtRutaArchivo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRutaArchivo.Properties.Appearance.Options.UseFont = true;
            this.txtRutaArchivo.Size = new System.Drawing.Size(731, 30);
            this.txtRutaArchivo.TabIndex = 159;
            // 
            // xtraSaveFileDialog1
            // 
            this.xtraSaveFileDialog1.FileName = "xtraSaveFileDialog1";
            // 
            // frmNuevoCertificadoCalibracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 741);
            this.Controls.Add(this.btnAdjunto);
            this.Controls.Add(this.lblCertificado);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.memoObservaciones);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.memoResultado);
            this.Controls.Add(this.labelControl8);
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
            ((System.ComponentModel.ISupportInitialize)(this.memoCondicionesAmbientales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsables.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsablesView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupVariableDeInstrumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPatron.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVariablesCertificado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVariablesCertificado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValorMedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoResultado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private FontAwesome.Sharp.IconButton btnAgregarVariable;
        private System.Windows.Forms.NumericUpDown nmValorMedido;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl gcVariablesCertificado;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVariablesCertificado;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionPatron;
        private DevExpress.XtraGrid.Columns.GridColumn colVariableMedicion;
        private DevExpress.XtraGrid.Columns.GridColumn colValorMedido;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEliminar;
        private DevExpress.XtraEditors.LookUpEdit lookUpPatron;
        private DevExpress.XtraEditors.LookUpEdit lookupVariableDeInstrumento;
        private DevExpress.XtraEditors.MemoEdit memoResultado;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.MemoEdit memoObservaciones;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private FontAwesome.Sharp.IconButton btnAdjunto;
        private DevExpress.XtraEditors.LabelControl lblCertificado;
        private DevExpress.XtraEditors.TextEdit txtRutaArchivo;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
    }
}