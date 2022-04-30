
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipoInstrumento = new DevExpress.XtraEditors.TextEdit();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.txtModelo = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.memoDiagnostico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoInstrumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoOrdenTrabajo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrioridad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsables.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsablesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glEstadoView)).BeginInit();
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
            this.btnGuardarDiagnostico.Location = new System.Drawing.Point(460, 699);
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
            this.memoDiagnostico.Location = new System.Drawing.Point(49, 420);
            this.memoDiagnostico.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoDiagnostico.Name = "memoDiagnostico";
            this.memoDiagnostico.Size = new System.Drawing.Size(648, 94);
            this.memoDiagnostico.TabIndex = 166;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(50, 399);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(72, 17);
            this.labelControl9.TabIndex = 165;
            this.labelControl9.Text = "Diagnóstico:";
            // 
            // memoComentarios
            // 
            this.memoComentarios.Location = new System.Drawing.Point(50, 321);
            this.memoComentarios.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoComentarios.Name = "memoComentarios";
            this.memoComentarios.Size = new System.Drawing.Size(646, 59);
            this.memoComentarios.TabIndex = 162;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(49, 298);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(147, 17);
            this.labelControl7.TabIndex = 161;
            this.labelControl7.Text = "Comentarios Adicionales:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(274, 178);
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
            this.labelControl5.Location = new System.Drawing.Point(50, 254);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(318, 20);
            this.labelControl5.TabIndex = 156;
            this.labelControl5.Text = "Información complementaria para Diagnóstico";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(49, 178);
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
            this.labelControl3.Location = new System.Drawing.Point(50, 81);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(262, 20);
            this.labelControl3.TabIndex = 153;
            this.labelControl3.Text = "Resumen de Instrumento seleccionado";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(492, 116);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 17);
            this.labelControl2.TabIndex = 151;
            this.labelControl2.Text = "Modelo:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(274, 116);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 17);
            this.labelControl1.TabIndex = 149;
            this.labelControl1.Text = "Marca:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(50, 116);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(121, 17);
            this.labelControl10.TabIndex = 147;
            this.labelControl10.Text = "Tipo de Instrumento:";
            // 
            // txtTipoInstrumento
            // 
            this.txtTipoInstrumento.Location = new System.Drawing.Point(50, 138);
            this.txtTipoInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTipoInstrumento.Name = "txtTipoInstrumento";
            this.txtTipoInstrumento.Properties.ReadOnly = true;
            this.txtTipoInstrumento.Size = new System.Drawing.Size(200, 22);
            this.txtTipoInstrumento.TabIndex = 168;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(274, 138);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(200, 22);
            this.txtMarca.TabIndex = 169;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(492, 138);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Properties.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(200, 22);
            this.txtModelo.TabIndex = 170;
            // 
            // txtTipoOrdenTrabajo
            // 
            this.txtTipoOrdenTrabajo.Location = new System.Drawing.Point(49, 202);
            this.txtTipoOrdenTrabajo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTipoOrdenTrabajo.Name = "txtTipoOrdenTrabajo";
            this.txtTipoOrdenTrabajo.Properties.ReadOnly = true;
            this.txtTipoOrdenTrabajo.Size = new System.Drawing.Size(202, 22);
            this.txtTipoOrdenTrabajo.TabIndex = 171;
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.Location = new System.Drawing.Point(273, 202);
            this.txtPrioridad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.Properties.ReadOnly = true;
            this.txtPrioridad.Size = new System.Drawing.Size(107, 22);
            this.txtPrioridad.TabIndex = 172;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(49, 609);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(127, 17);
            this.labelControl6.TabIndex = 173;
            this.labelControl6.Text = "Usuario Responsable:";
            // 
            // glUsuariosResponsables
            // 
            this.glUsuariosResponsables.Location = new System.Drawing.Point(49, 629);
            this.glUsuariosResponsables.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glUsuariosResponsables.Name = "glUsuariosResponsables";
            this.glUsuariosResponsables.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glUsuariosResponsables.Properties.Appearance.Options.UseFont = true;
            this.glUsuariosResponsables.Properties.NullText = "";
            this.glUsuariosResponsables.Properties.PopupView = this.glUsuariosResponsablesView;
            this.glUsuariosResponsables.Size = new System.Drawing.Size(438, 26);
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
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(50, 537);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(43, 17);
            this.labelControl11.TabIndex = 175;
            this.labelControl11.Text = "Estado:";
            // 
            // glEstado
            // 
            this.glEstado.Location = new System.Drawing.Point(50, 558);
            this.glEstado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glEstado.Name = "glEstado";
            this.glEstado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glEstado.Properties.Appearance.Options.UseFont = true;
            this.glEstado.Properties.NullText = "";
            this.glEstado.Properties.PopupView = this.glEstadoView;
            this.glEstado.Size = new System.Drawing.Size(438, 26);
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
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(492, 178);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(122, 17);
            this.labelControl12.TabIndex = 177;
            this.labelControl12.Text = "Tiempo Transcurrido";
            // 
            // lblTiempo
            // 
            this.lblTiempo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTiempo.Appearance.Options.UseFont = true;
            this.lblTiempo.Location = new System.Drawing.Point(492, 209);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 17);
            this.lblTiempo.TabIndex = 178;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmNuevoDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 774);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.glEstado);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.glUsuariosResponsables);
            this.Controls.Add(this.txtPrioridad);
            this.Controls.Add(this.txtTipoOrdenTrabajo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtTipoInstrumento);
            this.Controls.Add(this.btnGuardarDiagnostico);
            this.Controls.Add(this.memoDiagnostico);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.memoComentarios);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmNuevoDiagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Diagnóstico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNuevoDiagnostico_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.memoDiagnostico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoInstrumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoOrdenTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrioridad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsables.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glUsuariosResponsablesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glEstadoView)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtTipoInstrumento;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraEditors.TextEdit txtModelo;
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
    }
}