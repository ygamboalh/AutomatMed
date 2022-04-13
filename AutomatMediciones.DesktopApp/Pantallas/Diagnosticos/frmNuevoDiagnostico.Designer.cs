
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
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel4 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel5 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.ctlEncabezadoPantalla1 = new AutomatMediciones.DesktopApp.Componentes.Encabezados.ctlEncabezadoPantalla();
            this.btnGuardarDiagnostico = new FontAwesome.Sharp.IconButton();
            this.memoDiagnostico = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.nmTiempoEstimado = new System.Windows.Forms.NumericUpDown();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.memoComentarios = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dateFechaInicioOrdenTrabajo = new System.Windows.Forms.DateTimePicker();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.trackPrioridad = new DevExpress.XtraEditors.TrackBarControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.glTipoOrdenDeTrabajo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glTipoOrdenDeTrabajoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.glModelos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glModelosView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colModeloId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.glMarcas = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glMarcasView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMarcaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.glTipoInstrumento = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glTipoInstrumentoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoInstrumentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionTipoInstrumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.memoDiagnostico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTiempoEstimado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPrioridad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPrioridad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoOrdenDeTrabajo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoOrdenDeTrabajoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glModelos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glModelosView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glMarcas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glMarcasView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumentoView)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlEncabezadoPantalla1
            // 
            this.ctlEncabezadoPantalla1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlEncabezadoPantalla1.Location = new System.Drawing.Point(0, 0);
            this.ctlEncabezadoPantalla1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlEncabezadoPantalla1.Name = "ctlEncabezadoPantalla1";
            this.ctlEncabezadoPantalla1.Size = new System.Drawing.Size(744, 44);
            this.ctlEncabezadoPantalla1.TabIndex = 0;
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
            this.btnGuardarDiagnostico.Location = new System.Drawing.Point(396, 658);
            this.btnGuardarDiagnostico.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarDiagnostico.Name = "btnGuardarDiagnostico";
            this.btnGuardarDiagnostico.Size = new System.Drawing.Size(295, 52);
            this.btnGuardarDiagnostico.TabIndex = 167;
            this.btnGuardarDiagnostico.Text = "Guardar Nuevo Diagnóstico";
            this.btnGuardarDiagnostico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarDiagnostico.UseVisualStyleBackColor = true;
            // 
            // memoDiagnostico
            // 
            this.memoDiagnostico.Location = new System.Drawing.Point(44, 446);
            this.memoDiagnostico.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoDiagnostico.Name = "memoDiagnostico";
            this.memoDiagnostico.Size = new System.Drawing.Size(647, 59);
            this.memoDiagnostico.TabIndex = 166;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(46, 425);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(69, 17);
            this.labelControl9.TabIndex = 165;
            this.labelControl9.Text = "Diagnóstico";
            // 
            // nmTiempoEstimado
            // 
            this.nmTiempoEstimado.DecimalPlaces = 2;
            this.nmTiempoEstimado.Location = new System.Drawing.Point(47, 387);
            this.nmTiempoEstimado.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmTiempoEstimado.Name = "nmTiempoEstimado";
            this.nmTiempoEstimado.Size = new System.Drawing.Size(150, 23);
            this.nmTiempoEstimado.TabIndex = 164;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(47, 365);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(105, 17);
            this.labelControl6.TabIndex = 163;
            this.labelControl6.Text = "Tiempo Estimado:";
            // 
            // memoComentarios
            // 
            this.memoComentarios.Location = new System.Drawing.Point(45, 291);
            this.memoComentarios.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoComentarios.Name = "memoComentarios";
            this.memoComentarios.Size = new System.Drawing.Size(646, 59);
            this.memoComentarios.TabIndex = 162;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(44, 270);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(74, 17);
            this.labelControl7.TabIndex = 161;
            this.labelControl7.Text = "Comentarios";
            // 
            // dateFechaInicioOrdenTrabajo
            // 
            this.dateFechaInicioOrdenTrabajo.Location = new System.Drawing.Point(369, 235);
            this.dateFechaInicioOrdenTrabajo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateFechaInicioOrdenTrabajo.Name = "dateFechaInicioOrdenTrabajo";
            this.dateFechaInicioOrdenTrabajo.Size = new System.Drawing.Size(320, 23);
            this.dateFechaInicioOrdenTrabajo.TabIndex = 160;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(369, 212);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(89, 17);
            this.labelControl15.TabIndex = 159;
            this.labelControl15.Text = "Fecha de Inicio:";
            // 
            // trackPrioridad
            // 
            this.trackPrioridad.EditValue = 1;
            this.trackPrioridad.Location = new System.Drawing.Point(45, 550);
            this.trackPrioridad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.trackPrioridad.Name = "trackPrioridad";
            this.trackPrioridad.Properties.AutoSize = false;
            this.trackPrioridad.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackPrioridad.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "1";
            trackBarLabel1.Value = 1;
            trackBarLabel2.Label = "2";
            trackBarLabel2.Value = 2;
            trackBarLabel3.Label = "3";
            trackBarLabel3.Value = 3;
            trackBarLabel4.Label = "4";
            trackBarLabel4.Value = 4;
            trackBarLabel5.Label = "5";
            trackBarLabel5.Value = 5;
            this.trackPrioridad.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3,
            trackBarLabel4,
            trackBarLabel5});
            this.trackPrioridad.Properties.Maximum = 5;
            this.trackPrioridad.Properties.Minimum = 1;
            this.trackPrioridad.Properties.ShowLabels = true;
            this.trackPrioridad.Size = new System.Drawing.Size(273, 63);
            this.trackPrioridad.TabIndex = 158;
            this.trackPrioridad.Value = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(45, 526);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(57, 17);
            this.labelControl8.TabIndex = 157;
            this.labelControl8.Text = "Prioridad:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(33, 173);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(318, 20);
            this.labelControl5.TabIndex = 156;
            this.labelControl5.Text = "Información complementaria para Diagnóstico";
            // 
            // glTipoOrdenDeTrabajo
            // 
            this.glTipoOrdenDeTrabajo.EditValue = "";
            this.glTipoOrdenDeTrabajo.Location = new System.Drawing.Point(45, 234);
            this.glTipoOrdenDeTrabajo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glTipoOrdenDeTrabajo.Name = "glTipoOrdenDeTrabajo";
            this.glTipoOrdenDeTrabajo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glTipoOrdenDeTrabajo.Properties.Appearance.Options.UseFont = true;
            this.glTipoOrdenDeTrabajo.Properties.NullText = "";
            this.glTipoOrdenDeTrabajo.Properties.PopupView = this.glTipoOrdenDeTrabajoView;
            this.glTipoOrdenDeTrabajo.Size = new System.Drawing.Size(303, 26);
            this.glTipoOrdenDeTrabajo.TabIndex = 155;
            // 
            // glTipoOrdenDeTrabajoView
            // 
            this.glTipoOrdenDeTrabajoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.glTipoOrdenDeTrabajoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glTipoOrdenDeTrabajoView.Name = "glTipoOrdenDeTrabajoView";
            this.glTipoOrdenDeTrabajoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glTipoOrdenDeTrabajoView.OptionsView.ShowGroupPanel = false;
            this.glTipoOrdenDeTrabajoView.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "TipoInstrumentoId";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descripción";
            this.gridColumn2.FieldName = "Descripcion";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(45, 211);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(138, 17);
            this.labelControl4.TabIndex = 154;
            this.labelControl4.Text = "Tipo Orden de Trabajo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(33, 48);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(175, 20);
            this.labelControl3.TabIndex = 153;
            this.labelControl3.Text = "Instrumento seleccionado";
            // 
            // glModelos
            // 
            this.glModelos.EditValue = "";
            this.glModelos.Location = new System.Drawing.Point(489, 104);
            this.glModelos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glModelos.Name = "glModelos";
            this.glModelos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glModelos.Properties.Appearance.Options.UseFont = true;
            this.glModelos.Properties.NullText = "";
            this.glModelos.Properties.PopupView = this.glModelosView;
            this.glModelos.Size = new System.Drawing.Size(202, 26);
            this.glModelos.TabIndex = 152;
            // 
            // glModelosView
            // 
            this.glModelosView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colModeloId,
            this.colDescripcionModelo});
            this.glModelosView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glModelosView.Name = "glModelosView";
            this.glModelosView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glModelosView.OptionsView.ShowGroupPanel = false;
            this.glModelosView.OptionsView.ShowIndicator = false;
            // 
            // colModeloId
            // 
            this.colModeloId.Caption = "Id";
            this.colModeloId.FieldName = "ModeloId";
            this.colModeloId.MinWidth = 23;
            this.colModeloId.Name = "colModeloId";
            this.colModeloId.Width = 87;
            // 
            // colDescripcionModelo
            // 
            this.colDescripcionModelo.Caption = "Descripción";
            this.colDescripcionModelo.FieldName = "Descripcion";
            this.colDescripcionModelo.MinWidth = 23;
            this.colDescripcionModelo.Name = "colDescripcionModelo";
            this.colDescripcionModelo.OptionsColumn.AllowEdit = false;
            this.colDescripcionModelo.Visible = true;
            this.colDescripcionModelo.VisibleIndex = 0;
            this.colDescripcionModelo.Width = 87;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(489, 81);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 17);
            this.labelControl2.TabIndex = 151;
            this.labelControl2.Text = "Modelo *:";
            // 
            // glMarcas
            // 
            this.glMarcas.EditValue = "";
            this.glMarcas.Location = new System.Drawing.Point(271, 104);
            this.glMarcas.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glMarcas.Name = "glMarcas";
            this.glMarcas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glMarcas.Properties.Appearance.Options.UseFont = true;
            this.glMarcas.Properties.NullText = "";
            this.glMarcas.Properties.PopupView = this.glMarcasView;
            this.glMarcas.Size = new System.Drawing.Size(200, 26);
            this.glMarcas.TabIndex = 150;
            // 
            // glMarcasView
            // 
            this.glMarcasView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMarcaId,
            this.colDescripcionMarca});
            this.glMarcasView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glMarcasView.Name = "glMarcasView";
            this.glMarcasView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glMarcasView.OptionsView.ShowGroupPanel = false;
            this.glMarcasView.OptionsView.ShowIndicator = false;
            // 
            // colMarcaId
            // 
            this.colMarcaId.Caption = "Id";
            this.colMarcaId.FieldName = "MarcaId";
            this.colMarcaId.MinWidth = 23;
            this.colMarcaId.Name = "colMarcaId";
            this.colMarcaId.Width = 87;
            // 
            // colDescripcionMarca
            // 
            this.colDescripcionMarca.Caption = "Marca";
            this.colDescripcionMarca.FieldName = "Descripcion";
            this.colDescripcionMarca.MinWidth = 23;
            this.colDescripcionMarca.Name = "colDescripcionMarca";
            this.colDescripcionMarca.OptionsColumn.AllowEdit = false;
            this.colDescripcionMarca.Visible = true;
            this.colDescripcionMarca.VisibleIndex = 0;
            this.colDescripcionMarca.Width = 87;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(271, 81);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 17);
            this.labelControl1.TabIndex = 149;
            this.labelControl1.Text = "Marca *:";
            // 
            // glTipoInstrumento
            // 
            this.glTipoInstrumento.EditValue = "";
            this.glTipoInstrumento.Location = new System.Drawing.Point(47, 104);
            this.glTipoInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glTipoInstrumento.Name = "glTipoInstrumento";
            this.glTipoInstrumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glTipoInstrumento.Properties.Appearance.Options.UseFont = true;
            this.glTipoInstrumento.Properties.NullText = "";
            this.glTipoInstrumento.Properties.PopupView = this.glTipoInstrumentoView;
            this.glTipoInstrumento.Size = new System.Drawing.Size(204, 26);
            this.glTipoInstrumento.TabIndex = 148;
            // 
            // glTipoInstrumentoView
            // 
            this.glTipoInstrumentoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoInstrumentoId,
            this.colDescripcionTipoInstrumento});
            this.glTipoInstrumentoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glTipoInstrumentoView.Name = "glTipoInstrumentoView";
            this.glTipoInstrumentoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glTipoInstrumentoView.OptionsView.ShowGroupPanel = false;
            this.glTipoInstrumentoView.OptionsView.ShowIndicator = false;
            // 
            // colTipoInstrumentoId
            // 
            this.colTipoInstrumentoId.Caption = "Id";
            this.colTipoInstrumentoId.FieldName = "TipoInstrumentoId";
            this.colTipoInstrumentoId.MinWidth = 23;
            this.colTipoInstrumentoId.Name = "colTipoInstrumentoId";
            // 
            // colDescripcionTipoInstrumento
            // 
            this.colDescripcionTipoInstrumento.Caption = "Descripción";
            this.colDescripcionTipoInstrumento.FieldName = "Descripcion";
            this.colDescripcionTipoInstrumento.MinWidth = 23;
            this.colDescripcionTipoInstrumento.Name = "colDescripcionTipoInstrumento";
            this.colDescripcionTipoInstrumento.Visible = true;
            this.colDescripcionTipoInstrumento.VisibleIndex = 0;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(47, 81);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(130, 17);
            this.labelControl10.TabIndex = 147;
            this.labelControl10.Text = "Tipo de Instrumento *:";
            // 
            // frmNuevoDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 735);
            this.Controls.Add(this.btnGuardarDiagnostico);
            this.Controls.Add(this.memoDiagnostico);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.nmTiempoEstimado);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.memoComentarios);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.dateFechaInicioOrdenTrabajo);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.trackPrioridad);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.glTipoOrdenDeTrabajo);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.glModelos);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.glMarcas);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.glTipoInstrumento);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.ctlEncabezadoPantalla1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmNuevoDiagnostico";
            this.Text = "Nuevo Diagnóstico";
            ((System.ComponentModel.ISupportInitialize)(this.memoDiagnostico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTiempoEstimado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPrioridad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPrioridad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoOrdenDeTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoOrdenDeTrabajoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glModelos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glModelosView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glMarcas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glMarcasView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumentoView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla1;
        private FontAwesome.Sharp.IconButton btnGuardarDiagnostico;
        private DevExpress.XtraEditors.MemoEdit memoDiagnostico;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.NumericUpDown nmTiempoEstimado;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit memoComentarios;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.DateTimePicker dateFechaInicioOrdenTrabajo;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TrackBarControl trackPrioridad;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GridLookUpEdit glTipoOrdenDeTrabajo;
        private DevExpress.XtraGrid.Views.Grid.GridView glTipoOrdenDeTrabajoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit glModelos;
        private DevExpress.XtraGrid.Views.Grid.GridView glModelosView;
        private DevExpress.XtraGrid.Columns.GridColumn colModeloId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionModelo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit glMarcas;
        private DevExpress.XtraGrid.Views.Grid.GridView glMarcasView;
        private DevExpress.XtraGrid.Columns.GridColumn colMarcaId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionMarca;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit glTipoInstrumento;
        private DevExpress.XtraGrid.Views.Grid.GridView glTipoInstrumentoView;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInstrumentoId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionTipoInstrumento;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}