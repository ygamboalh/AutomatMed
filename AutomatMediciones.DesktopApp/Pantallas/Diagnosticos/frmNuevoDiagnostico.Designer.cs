
namespace AutomatMediciones.DesktopApp.Pantallas.Diagnosticos
{
    partial class frmNuevoDiagnostico
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
            this.btnGuardarDiagnostico = new FontAwesome.Sharp.IconButton();
            this.memoDiagnostico = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.memoComentarios = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtClasificacion = new DevExpress.XtraEditors.TextEdit();
            this.txtTipoOrdenTrabajo = new DevExpress.XtraEditors.TextEdit();
            this.txtPrioridad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.glUsuariosResponsables = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glUsuariosResponsablesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUsuarioId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.glEstado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glEstadoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lblTiempo = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.memoComentariosInstrumento = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrepararCertificado = new FontAwesome.Sharp.IconButton();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroServicioTecnico = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtContactoACargo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.btnDetalleInstrumento = new FontAwesome.Sharp.IconButton();
            this.btnHistorialDeCertificados = new FontAwesome.Sharp.IconButton();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.dateFechaDisponible = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDiagnostico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClasificacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoOrdenTrabajo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrioridad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsables.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsablesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glEstadoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentariosInstrumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroServicioTecnico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactoACargo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaDisponible.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaDisponible.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarDiagnostico
            // 
            this.btnGuardarDiagnostico.FlatAppearance.BorderSize = 0;
            this.btnGuardarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDiagnostico.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarDiagnostico.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarDiagnostico.IconColor = System.Drawing.Color.Black;
            this.btnGuardarDiagnostico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarDiagnostico.IconSize = 30;
            this.btnGuardarDiagnostico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarDiagnostico.Location = new System.Drawing.Point(768, 449);
            this.btnGuardarDiagnostico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarDiagnostico.Name = "btnGuardarDiagnostico";
            this.btnGuardarDiagnostico.Size = new System.Drawing.Size(235, 42);
            this.btnGuardarDiagnostico.TabIndex = 167;
            this.btnGuardarDiagnostico.Text = "Guardar Diagnóstico";
            this.btnGuardarDiagnostico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarDiagnostico.UseVisualStyleBackColor = true;
            this.btnGuardarDiagnostico.Click += new System.EventHandler(this.btnGuardarDiagnostico_Click);
            // 
            // memoDiagnostico
            // 
            this.memoDiagnostico.Location = new System.Drawing.Point(546, 281);
            this.memoDiagnostico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoDiagnostico.Name = "memoDiagnostico";
            this.memoDiagnostico.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoDiagnostico.Properties.Appearance.Options.UseFont = true;
            this.memoDiagnostico.Size = new System.Drawing.Size(457, 59);
            this.memoDiagnostico.TabIndex = 166;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(546, 264);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(155, 17);
            this.labelControl9.TabIndex = 165;
            this.labelControl9.Text = "Diagnóstico/Seguimiento:";
            // 
            // memoComentarios
            // 
            this.memoComentarios.Location = new System.Drawing.Point(29, 281);
            this.memoComentarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoComentarios.Name = "memoComentarios";
            this.memoComentarios.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoComentarios.Properties.Appearance.Options.UseFont = true;
            this.memoComentarios.Size = new System.Drawing.Size(478, 58);
            this.memoComentarios.TabIndex = 162;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(29, 263);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(162, 17);
            this.labelControl7.TabIndex = 161;
            this.labelControl7.Text = "Comentarios en el ingreso:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(658, 119);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(58, 17);
            this.labelControl8.TabIndex = 157;
            this.labelControl8.Text = "Prioridad:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(29, 228);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(318, 20);
            this.labelControl5.TabIndex = 156;
            this.labelControl5.Text = "Información complementaria para Diagnóstico";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(27, 119);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 17);
            this.labelControl4.TabIndex = 154;
            this.labelControl4.Text = "Tipo de Trabajo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(28, 46);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(138, 20);
            this.labelControl3.TabIndex = 153;
            this.labelControl3.Text = "Resumen de Ingreso";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(339, 119);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(177, 17);
            this.labelControl10.TabIndex = 147;
            this.labelControl10.Text = "Clasificación del Instrumento:";
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(339, 135);
            this.txtClasificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClasificacion.Properties.Appearance.Options.UseFont = true;
            this.txtClasificacion.Properties.ReadOnly = true;
            this.txtClasificacion.Properties.UseReadOnlyAppearance = false;
            this.txtClasificacion.Size = new System.Drawing.Size(312, 26);
            this.txtClasificacion.TabIndex = 168;
            // 
            // txtTipoOrdenTrabajo
            // 
            this.txtTipoOrdenTrabajo.Location = new System.Drawing.Point(28, 135);
            this.txtTipoOrdenTrabajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipoOrdenTrabajo.Name = "txtTipoOrdenTrabajo";
            this.txtTipoOrdenTrabajo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipoOrdenTrabajo.Properties.Appearance.Options.UseFont = true;
            this.txtTipoOrdenTrabajo.Properties.ReadOnly = true;
            this.txtTipoOrdenTrabajo.Properties.UseReadOnlyAppearance = false;
            this.txtTipoOrdenTrabajo.Size = new System.Drawing.Size(304, 26);
            this.txtTipoOrdenTrabajo.TabIndex = 171;
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.Location = new System.Drawing.Point(658, 135);
            this.txtPrioridad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrioridad.Properties.Appearance.Options.UseFont = true;
            this.txtPrioridad.Properties.ReadOnly = true;
            this.txtPrioridad.Properties.UseReadOnlyAppearance = false;
            this.txtPrioridad.Size = new System.Drawing.Size(92, 26);
            this.txtPrioridad.TabIndex = 172;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(339, 349);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(129, 17);
            this.labelControl6.TabIndex = 173;
            this.labelControl6.Text = "Usuario Responsable:";
            // 
            // glUsuariosResponsables
            // 
            this.glUsuariosResponsables.Location = new System.Drawing.Point(340, 370);
            this.glUsuariosResponsables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glUsuariosResponsables.Name = "glUsuariosResponsables";
            this.glUsuariosResponsables.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glUsuariosResponsables.Properties.Appearance.Options.UseFont = true;
            this.glUsuariosResponsables.Properties.NullText = "";
            this.glUsuariosResponsables.Properties.PopupView = this.glUsuariosResponsablesView;
            this.glUsuariosResponsables.Size = new System.Drawing.Size(285, 26);
            this.glUsuariosResponsables.TabIndex = 174;
            this.glUsuariosResponsables.EditValueChanged += new System.EventHandler(this.glUsuariosResponsables_EditValueChanged);
            // 
            // glUsuariosResponsablesView
            // 
            this.glUsuariosResponsablesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUsuarioId,
            this.colNombreUsuario});
            this.glUsuariosResponsablesView.DetailHeight = 284;
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
            this.colUsuarioId.MinWidth = 17;
            this.colUsuarioId.Name = "colUsuarioId";
            this.colUsuarioId.OptionsColumn.AllowEdit = false;
            this.colUsuarioId.OptionsColumn.ReadOnly = true;
            this.colUsuarioId.Width = 64;
            // 
            // colNombreUsuario
            // 
            this.colNombreUsuario.Caption = "Nombre";
            this.colNombreUsuario.FieldName = "Nombre";
            this.colNombreUsuario.MinWidth = 17;
            this.colNombreUsuario.Name = "colNombreUsuario";
            this.colNombreUsuario.OptionsColumn.AllowEdit = false;
            this.colNombreUsuario.OptionsColumn.ReadOnly = true;
            this.colNombreUsuario.Visible = true;
            this.colNombreUsuario.VisibleIndex = 0;
            this.colNombreUsuario.Width = 64;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(29, 349);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(44, 17);
            this.labelControl11.TabIndex = 175;
            this.labelControl11.Text = "Estado:";
            // 
            // glEstado
            // 
            this.glEstado.Location = new System.Drawing.Point(29, 370);
            this.glEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glEstado.Name = "glEstado";
            this.glEstado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glEstado.Properties.Appearance.Options.UseFont = true;
            this.glEstado.Properties.NullText = "";
            this.glEstado.Properties.PopupView = this.glEstadoView;
            this.glEstado.Size = new System.Drawing.Size(305, 26);
            this.glEstado.TabIndex = 176;
            this.glEstado.EditValueChanged += new System.EventHandler(this.glEstado_EditValueChanged);
            // 
            // glEstadoView
            // 
            this.glEstadoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEstado,
            this.colEstadoDescripcion});
            this.glEstadoView.DetailHeight = 284;
            this.glEstadoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glEstadoView.Name = "glEstadoView";
            this.glEstadoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glEstadoView.OptionsView.ShowColumnHeaders = false;
            this.glEstadoView.OptionsView.ShowGroupPanel = false;
            this.glEstadoView.OptionsView.ShowIndicator = false;
            // 
            // colIdEstado
            // 
            this.colIdEstado.Caption = "Id";
            this.colIdEstado.FieldName = "EstadoId";
            this.colIdEstado.MinWidth = 17;
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.OptionsColumn.AllowEdit = false;
            this.colIdEstado.OptionsColumn.ReadOnly = true;
            this.colIdEstado.Width = 64;
            // 
            // colEstadoDescripcion
            // 
            this.colEstadoDescripcion.Caption = "Estado";
            this.colEstadoDescripcion.FieldName = "Descripcion";
            this.colEstadoDescripcion.MinWidth = 17;
            this.colEstadoDescripcion.Name = "colEstadoDescripcion";
            this.colEstadoDescripcion.OptionsColumn.AllowEdit = false;
            this.colEstadoDescripcion.OptionsColumn.ReadOnly = true;
            this.colEstadoDescripcion.Visible = true;
            this.colEstadoDescripcion.VisibleIndex = 0;
            this.colEstadoDescripcion.Width = 64;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(27, 400);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(157, 23);
            this.labelControl12.TabIndex = 177;
            this.labelControl12.Text = "Tiempo Transcurrido";
            // 
            // lblTiempo
            // 
            this.lblTiempo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTiempo.Appearance.Options.UseFont = true;
            this.lblTiempo.Location = new System.Drawing.Point(199, 402);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 23);
            this.lblTiempo.TabIndex = 178;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // memoComentariosInstrumento
            // 
            this.memoComentariosInstrumento.Location = new System.Drawing.Point(28, 182);
            this.memoComentariosInstrumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoComentariosInstrumento.Name = "memoComentariosInstrumento";
            this.memoComentariosInstrumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoComentariosInstrumento.Properties.Appearance.Options.UseFont = true;
            this.memoComentariosInstrumento.Properties.ReadOnly = true;
            this.memoComentariosInstrumento.Properties.UseReadOnlyAppearance = false;
            this.memoComentariosInstrumento.Size = new System.Drawing.Size(975, 38);
            this.memoComentariosInstrumento.TabIndex = 179;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 161);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(208, 17);
            this.labelControl1.TabIndex = 180;
            this.labelControl1.Text = "Comentarios sobre el instrumento";
            // 
            // btnPrepararCertificado
            // 
            this.btnPrepararCertificado.FlatAppearance.BorderSize = 0;
            this.btnPrepararCertificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrepararCertificado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrepararCertificado.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnPrepararCertificado.IconColor = System.Drawing.Color.Black;
            this.btnPrepararCertificado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrepararCertificado.IconSize = 30;
            this.btnPrepararCertificado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrepararCertificado.Location = new System.Drawing.Point(526, 449);
            this.btnPrepararCertificado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrepararCertificado.Name = "btnPrepararCertificado";
            this.btnPrepararCertificado.Size = new System.Drawing.Size(213, 42);
            this.btnPrepararCertificado.TabIndex = 181;
            this.btnPrepararCertificado.Text = "Preparar Certificado";
            this.btnPrepararCertificado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrepararCertificado.UseVisualStyleBackColor = true;
            this.btnPrepararCertificado.Click += new System.EventHandler(this.btnPrepararCertificado_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(29, 93);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliente.Properties.Appearance.Options.UseFont = true;
            this.txtCliente.Properties.ReadOnly = true;
            this.txtCliente.Properties.UseReadOnlyAppearance = false;
            this.txtCliente.Size = new System.Drawing.Size(304, 26);
            this.txtCliente.TabIndex = 184;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(29, 76);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(44, 17);
            this.labelControl13.TabIndex = 183;
            this.labelControl13.Text = "Cliente:";
            // 
            // txtNumeroServicioTecnico
            // 
            this.txtNumeroServicioTecnico.Location = new System.Drawing.Point(658, 93);
            this.txtNumeroServicioTecnico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroServicioTecnico.Name = "txtNumeroServicioTecnico";
            this.txtNumeroServicioTecnico.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroServicioTecnico.Properties.Appearance.Options.UseFont = true;
            this.txtNumeroServicioTecnico.Properties.ReadOnly = true;
            this.txtNumeroServicioTecnico.Properties.UseReadOnlyAppearance = false;
            this.txtNumeroServicioTecnico.Size = new System.Drawing.Size(182, 26);
            this.txtNumeroServicioTecnico.TabIndex = 186;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(658, 76);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 17);
            this.labelControl2.TabIndex = 185;
            this.labelControl2.Text = "N° Servicio Técnico:";
            // 
            // txtContactoACargo
            // 
            this.txtContactoACargo.Location = new System.Drawing.Point(339, 93);
            this.txtContactoACargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContactoACargo.Name = "txtContactoACargo";
            this.txtContactoACargo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContactoACargo.Properties.Appearance.Options.UseFont = true;
            this.txtContactoACargo.Properties.ReadOnly = true;
            this.txtContactoACargo.Properties.UseReadOnlyAppearance = false;
            this.txtContactoACargo.Size = new System.Drawing.Size(312, 26);
            this.txtContactoACargo.TabIndex = 188;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(339, 72);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(107, 17);
            this.labelControl14.TabIndex = 187;
            this.labelControl14.Text = "Contacto a cargo:";
            // 
            // btnDetalleInstrumento
            // 
            this.btnDetalleInstrumento.FlatAppearance.BorderSize = 0;
            this.btnDetalleInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleInstrumento.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDetalleInstrumento.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnDetalleInstrumento.IconColor = System.Drawing.Color.Black;
            this.btnDetalleInstrumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetalleInstrumento.IconSize = 30;
            this.btnDetalleInstrumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleInstrumento.Location = new System.Drawing.Point(29, 449);
            this.btnDetalleInstrumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalleInstrumento.Name = "btnDetalleInstrumento";
            this.btnDetalleInstrumento.Size = new System.Drawing.Size(232, 42);
            this.btnDetalleInstrumento.TabIndex = 189;
            this.btnDetalleInstrumento.Text = "Detalle de Instrumento";
            this.btnDetalleInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalleInstrumento.UseVisualStyleBackColor = true;
            this.btnDetalleInstrumento.Click += new System.EventHandler(this.btnDetalleInstrumento_Click);
            // 
            // btnHistorialDeCertificados
            // 
            this.btnHistorialDeCertificados.FlatAppearance.BorderSize = 0;
            this.btnHistorialDeCertificados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialDeCertificados.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistorialDeCertificados.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btnHistorialDeCertificados.IconColor = System.Drawing.Color.Black;
            this.btnHistorialDeCertificados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorialDeCertificados.IconSize = 30;
            this.btnHistorialDeCertificados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialDeCertificados.Location = new System.Drawing.Point(281, 449);
            this.btnHistorialDeCertificados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistorialDeCertificados.Name = "btnHistorialDeCertificados";
            this.btnHistorialDeCertificados.Size = new System.Drawing.Size(226, 42);
            this.btnHistorialDeCertificados.TabIndex = 190;
            this.btnHistorialDeCertificados.Text = "Historial de Certificados";
            this.btnHistorialDeCertificados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistorialDeCertificados.UseVisualStyleBackColor = true;
            this.btnHistorialDeCertificados.Click += new System.EventHandler(this.btnHistorialDeCertificados_Click);
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(646, 349);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(172, 17);
            this.labelControl15.TabIndex = 191;
            this.labelControl15.Text = "Fecha que estará disponible:";
            // 
            // dateFechaDisponible
            // 
            this.dateFechaDisponible.EditValue = null;
            this.dateFechaDisponible.Location = new System.Drawing.Point(646, 370);
            this.dateFechaDisponible.Name = "dateFechaDisponible";
            this.dateFechaDisponible.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaDisponible.Properties.Appearance.Options.UseFont = true;
            this.dateFechaDisponible.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaDisponible.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaDisponible.Size = new System.Drawing.Size(270, 26);
            this.dateFechaDisponible.TabIndex = 192;
            // 
            // frmNuevoDiagnostico
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1057, 514);
            this.Controls.Add(this.dateFechaDisponible);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.btnHistorialDeCertificados);
            this.Controls.Add(this.btnDetalleInstrumento);
            this.Controls.Add(this.txtContactoACargo);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.txtNumeroServicioTecnico);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.btnPrepararCertificado);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.memoComentariosInstrumento);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.glEstado);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.glUsuariosResponsables);
            this.Controls.Add(this.txtPrioridad);
            this.Controls.Add(this.txtTipoOrdenTrabajo);
            this.Controls.Add(this.txtClasificacion);
            this.Controls.Add(this.btnGuardarDiagnostico);
            this.Controls.Add(this.memoDiagnostico);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.memoComentarios);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNuevoDiagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNuevoDiagnostico_FormClosing);
            this.Load += new System.EventHandler(this.frmNuevoDiagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoDiagnostico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClasificacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoOrdenTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrioridad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsables.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsablesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glEstadoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentariosInstrumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroServicioTecnico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactoACargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaDisponible.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaDisponible.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnGuardarDiagnostico;
        private DevExpress.XtraEditors.MemoEdit memoDiagnostico;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.MemoEdit memoComentarios;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtClasificacion;
        private DevExpress.XtraEditors.TextEdit txtTipoOrdenTrabajo;
        private DevExpress.XtraEditors.TextEdit txtPrioridad;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GridLookUpEdit glUsuariosResponsables;
        private DevExpress.XtraGrid.Views.Grid.GridView glUsuariosResponsablesView;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.GridLookUpEdit glEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView glEstadoView;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoId;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl lblTiempo;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.MemoEdit memoComentariosInstrumento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private FontAwesome.Sharp.IconButton btnPrepararCertificado;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtNumeroServicioTecnico;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtContactoACargo;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private FontAwesome.Sharp.IconButton btnDetalleInstrumento;
        private FontAwesome.Sharp.IconButton btnHistorialDeCertificados;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.DateEdit dateFechaDisponible;
    }
}