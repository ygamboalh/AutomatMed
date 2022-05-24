﻿
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
            this.btnGuardarDiagnostico.Location = new System.Drawing.Point(459, 686);
            this.btnGuardarDiagnostico.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarDiagnostico.Name = "btnGuardarDiagnostico";
            this.btnGuardarDiagnostico.Size = new System.Drawing.Size(237, 52);
            this.btnGuardarDiagnostico.TabIndex = 167;
            this.btnGuardarDiagnostico.Text = "Guardar Diagnóstico";
            this.btnGuardarDiagnostico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarDiagnostico.UseVisualStyleBackColor = true;
            this.btnGuardarDiagnostico.Click += new System.EventHandler(this.btnGuardarDiagnostico_Click);
            // 
            // memoDiagnostico
            // 
            this.memoDiagnostico.Location = new System.Drawing.Point(48, 465);
            this.memoDiagnostico.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoDiagnostico.Name = "memoDiagnostico";
            this.memoDiagnostico.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoDiagnostico.Properties.Appearance.Options.UseFont = true;
            this.memoDiagnostico.Size = new System.Drawing.Size(648, 94);
            this.memoDiagnostico.TabIndex = 166;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(49, 444);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(155, 17);
            this.labelControl9.TabIndex = 165;
            this.labelControl9.Text = "Diagnóstico/Seguimiento:";
            // 
            // memoComentarios
            // 
            this.memoComentarios.Location = new System.Drawing.Point(48, 370);
            this.memoComentarios.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoComentarios.Name = "memoComentarios";
            this.memoComentarios.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoComentarios.Properties.Appearance.Options.UseFont = true;
            this.memoComentarios.Size = new System.Drawing.Size(646, 59);
            this.memoComentarios.TabIndex = 162;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(47, 347);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(162, 17);
            this.labelControl7.TabIndex = 161;
            this.labelControl7.Text = "Comentarios en el ingreso:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(275, 149);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(58, 17);
            this.labelControl8.TabIndex = 157;
            this.labelControl8.Text = "Prioridad:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(50, 312);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(318, 20);
            this.labelControl5.TabIndex = 156;
            this.labelControl5.Text = "Información complementaria para Diagnóstico";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(50, 149);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 17);
            this.labelControl4.TabIndex = 154;
            this.labelControl4.Text = "Tipo de Trabajo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(47, 71);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(262, 20);
            this.labelControl3.TabIndex = 153;
            this.labelControl3.Text = "Resumen de Instrumento seleccionado";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(51, 95);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(75, 17);
            this.labelControl10.TabIndex = 147;
            this.labelControl10.Text = "Clasificación:";
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(50, 116);
            this.txtClasificacion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClasificacion.Properties.Appearance.Options.UseFont = true;
            this.txtClasificacion.Properties.ReadOnly = true;
            this.txtClasificacion.Properties.UseReadOnlyAppearance = false;
            this.txtClasificacion.Size = new System.Drawing.Size(646, 26);
            this.txtClasificacion.TabIndex = 168;
            // 
            // txtTipoOrdenTrabajo
            // 
            this.txtTipoOrdenTrabajo.Location = new System.Drawing.Point(50, 173);
            this.txtTipoOrdenTrabajo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTipoOrdenTrabajo.Name = "txtTipoOrdenTrabajo";
            this.txtTipoOrdenTrabajo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipoOrdenTrabajo.Properties.Appearance.Options.UseFont = true;
            this.txtTipoOrdenTrabajo.Properties.ReadOnly = true;
            this.txtTipoOrdenTrabajo.Properties.UseReadOnlyAppearance = false;
            this.txtTipoOrdenTrabajo.Size = new System.Drawing.Size(202, 26);
            this.txtTipoOrdenTrabajo.TabIndex = 171;
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.Location = new System.Drawing.Point(274, 173);
            this.txtPrioridad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrioridad.Properties.Appearance.Options.UseFont = true;
            this.txtPrioridad.Properties.ReadOnly = true;
            this.txtPrioridad.Properties.UseReadOnlyAppearance = false;
            this.txtPrioridad.Size = new System.Drawing.Size(107, 26);
            this.txtPrioridad.TabIndex = 172;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(366, 572);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(129, 17);
            this.labelControl6.TabIndex = 173;
            this.labelControl6.Text = "Usuario Responsable:";
            // 
            // glUsuariosResponsables
            // 
            this.glUsuariosResponsables.Location = new System.Drawing.Point(366, 592);
            this.glUsuariosResponsables.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glUsuariosResponsables.Name = "glUsuariosResponsables";
            this.glUsuariosResponsables.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glUsuariosResponsables.Properties.Appearance.Options.UseFont = true;
            this.glUsuariosResponsables.Properties.NullText = "";
            this.glUsuariosResponsables.Properties.PopupView = this.glUsuariosResponsablesView;
            this.glUsuariosResponsables.Size = new System.Drawing.Size(332, 26);
            this.glUsuariosResponsables.TabIndex = 174;
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
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(51, 572);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(44, 17);
            this.labelControl11.TabIndex = 175;
            this.labelControl11.Text = "Estado:";
            // 
            // glEstado
            // 
            this.glEstado.Location = new System.Drawing.Point(51, 593);
            this.glEstado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glEstado.Name = "glEstado";
            this.glEstado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glEstado.Properties.Appearance.Options.UseFont = true;
            this.glEstado.Properties.NullText = "";
            this.glEstado.Properties.PopupView = this.glEstadoView;
            this.glEstado.Size = new System.Drawing.Size(297, 26);
            this.glEstado.TabIndex = 176;
            this.glEstado.EditValueChanged += new System.EventHandler(this.glEstado_EditValueChanged);
            // 
            // glEstadoView
            // 
            this.glEstadoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEstado,
            this.colEstadoDescripcion});
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
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.OptionsColumn.AllowEdit = false;
            this.colIdEstado.OptionsColumn.ReadOnly = true;
            // 
            // colEstadoDescripcion
            // 
            this.colEstadoDescripcion.Caption = "Estado";
            this.colEstadoDescripcion.FieldName = "Descripcion";
            this.colEstadoDescripcion.Name = "colEstadoDescripcion";
            this.colEstadoDescripcion.OptionsColumn.AllowEdit = false;
            this.colEstadoDescripcion.OptionsColumn.ReadOnly = true;
            this.colEstadoDescripcion.Visible = true;
            this.colEstadoDescripcion.VisibleIndex = 0;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(51, 645);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(157, 23);
            this.labelControl12.TabIndex = 177;
            this.labelControl12.Text = "Tiempo Transcurrido";
            // 
            // lblTiempo
            // 
            this.lblTiempo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTiempo.Appearance.Options.UseFont = true;
            this.lblTiempo.Location = new System.Drawing.Point(238, 645);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.memoComentariosInstrumento.Location = new System.Drawing.Point(50, 230);
            this.memoComentariosInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoComentariosInstrumento.Name = "memoComentariosInstrumento";
            this.memoComentariosInstrumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoComentariosInstrumento.Properties.Appearance.Options.UseFont = true;
            this.memoComentariosInstrumento.Size = new System.Drawing.Size(646, 53);
            this.memoComentariosInstrumento.TabIndex = 179;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(51, 209);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(208, 17);
            this.labelControl1.TabIndex = 180;
            this.labelControl1.Text = "Comentarios sobre el instrumento";
            // 
            // frmNuevoDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 749);
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
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmNuevoDiagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNuevoDiagnostico_FormClosing);
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
    }
}