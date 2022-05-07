
namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos
{
    partial class frmInformacionAdicionalInstrumento
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
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel6 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel7 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel8 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel9 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel10 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.memoComentarios = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnIngresarInformacionAdicional = new FontAwesome.Sharp.IconButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.glTiposTrabajo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glTiposTrabajoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateFechaEntregaRequerida = new System.Windows.Forms.DateTimePicker();
            this.memoComentariosInstrumento = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTiposTrabajo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTiposTrabajoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentariosInstrumento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoComentarios
            // 
            this.memoComentarios.Location = new System.Drawing.Point(35, 490);
            this.memoComentarios.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoComentarios.Name = "memoComentarios";
            this.memoComentarios.Size = new System.Drawing.Size(742, 175);
            this.memoComentarios.TabIndex = 26;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(35, 469);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(338, 17);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "Comentarios o motivos de ingreso para este instrumento:";
            // 
            // btnIngresarInformacionAdicional
            // 
            this.btnIngresarInformacionAdicional.FlatAppearance.BorderSize = 0;
            this.btnIngresarInformacionAdicional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarInformacionAdicional.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarInformacionAdicional.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnIngresarInformacionAdicional.IconColor = System.Drawing.Color.Black;
            this.btnIngresarInformacionAdicional.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresarInformacionAdicional.IconSize = 30;
            this.btnIngresarInformacionAdicional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarInformacionAdicional.Location = new System.Drawing.Point(450, 687);
            this.btnIngresarInformacionAdicional.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnIngresarInformacionAdicional.Name = "btnIngresarInformacionAdicional";
            this.btnIngresarInformacionAdicional.Size = new System.Drawing.Size(327, 52);
            this.btnIngresarInformacionAdicional.TabIndex = 27;
            this.btnIngresarInformacionAdicional.Text = "Ingresar Información Adicional";
            this.btnIngresarInformacionAdicional.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresarInformacionAdicional.UseVisualStyleBackColor = true;
            this.btnIngresarInformacionAdicional.Click += new System.EventHandler(this.btnIngresarComentario_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(35, 69);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(106, 17);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Tipo de Trabajo *:";
            // 
            // glTiposTrabajo
            // 
            this.glTiposTrabajo.Location = new System.Drawing.Point(35, 90);
            this.glTiposTrabajo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glTiposTrabajo.Name = "glTiposTrabajo";
            this.glTiposTrabajo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glTiposTrabajo.Properties.Appearance.Options.UseFont = true;
            this.glTiposTrabajo.Properties.NullText = "";
            this.glTiposTrabajo.Properties.PopupView = this.glTiposTrabajoView;
            this.glTiposTrabajo.Size = new System.Drawing.Size(438, 26);
            this.glTiposTrabajo.TabIndex = 29;
            this.glTiposTrabajo.EditValueChanged += new System.EventHandler(this.glTiposTrabajo_EditValueChanged);
            // 
            // glTiposTrabajoView
            // 
            this.glTiposTrabajoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.glTiposTrabajoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glTiposTrabajoView.Name = "glTiposTrabajoView";
            this.glTiposTrabajoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glTiposTrabajoView.OptionsView.ShowColumnHeaders = false;
            this.glTiposTrabajoView.OptionsView.ShowGroupPanel = false;
            this.glTiposTrabajoView.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "TipoTrabajoId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tipo de Trabajo";
            this.gridColumn2.FieldName = "Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(35, 207);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 17);
            this.labelControl8.TabIndex = 30;
            this.labelControl8.Text = "Prioridad *:";
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.EditValue = 1;
            this.trackBarControl1.Location = new System.Drawing.Point(35, 241);
            this.trackBarControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Properties.AutoSize = false;
            this.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel6.Label = "1";
            trackBarLabel6.Value = 1;
            trackBarLabel7.Label = "2";
            trackBarLabel7.Value = 2;
            trackBarLabel8.Label = "3";
            trackBarLabel8.Value = 3;
            trackBarLabel9.Label = "4";
            trackBarLabel9.Value = 4;
            trackBarLabel10.Label = "5";
            trackBarLabel10.Value = 5;
            this.trackBarControl1.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel6,
            trackBarLabel7,
            trackBarLabel8,
            trackBarLabel9,
            trackBarLabel10});
            this.trackBarControl1.Properties.Maximum = 5;
            this.trackBarControl1.Properties.Minimum = 1;
            this.trackBarControl1.Properties.ShowLabels = true;
            this.trackBarControl1.Size = new System.Drawing.Size(438, 48);
            this.trackBarControl1.TabIndex = 31;
            this.trackBarControl1.Value = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(35, 137);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(149, 17);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Fecha Entrega Requerida:";
            // 
            // dateFechaEntregaRequerida
            // 
            this.dateFechaEntregaRequerida.Location = new System.Drawing.Point(35, 159);
            this.dateFechaEntregaRequerida.Name = "dateFechaEntregaRequerida";
            this.dateFechaEntregaRequerida.Size = new System.Drawing.Size(438, 23);
            this.dateFechaEntregaRequerida.TabIndex = 33;
            // 
            // memoComentariosInstrumento
            // 
            this.memoComentariosInstrumento.Location = new System.Drawing.Point(35, 345);
            this.memoComentariosInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoComentariosInstrumento.Name = "memoComentariosInstrumento";
            this.memoComentariosInstrumento.Size = new System.Drawing.Size(742, 94);
            this.memoComentariosInstrumento.TabIndex = 35;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 324);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(315, 17);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Comentarios u Observaciones acerca del instrumento:";
            // 
            // frmInformacionAdicionalInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 760);
            this.Controls.Add(this.memoComentariosInstrumento);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dateFechaEntregaRequerida);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.trackBarControl1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.glTiposTrabajo);
            this.Controls.Add(this.btnIngresarInformacionAdicional);
            this.Controls.Add(this.memoComentarios);
            this.Controls.Add(this.labelControl7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Name = "frmInformacionAdicionalInstrumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTiposTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTiposTrabajoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentariosInstrumento.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoComentarios;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private FontAwesome.Sharp.IconButton btnIngresarInformacionAdicional;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GridLookUpEdit glTiposTrabajo;
        private DevExpress.XtraGrid.Views.Grid.GridView glTiposTrabajoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TrackBarControl trackBarControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dateFechaEntregaRequerida;
        private DevExpress.XtraEditors.MemoEdit memoComentariosInstrumento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}