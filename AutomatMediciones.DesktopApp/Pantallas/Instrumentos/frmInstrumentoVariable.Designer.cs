
namespace AutomatMediciones.DesktopApp.Pantallas.Instrumentos
{
    partial class frmInstrumentoVariable
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
            this.glVariableDeMedicion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glVariableMedicion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoInstrumentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionTipoInstrumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.nmAlarmaAlta = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nmAlarmaBaja = new System.Windows.Forms.NumericUpDown();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nmAlarmaTwa = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.nmAlarmaStel = new System.Windows.Forms.NumericUpDown();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.toggleTieneAlarma = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnGuardarVinculacion = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.glVariableDeMedicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glVariableMedicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAlarmaAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAlarmaBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAlarmaTwa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAlarmaStel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleTieneAlarma.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // glVariableDeMedicion
            // 
            this.glVariableDeMedicion.EditValue = "";
            this.glVariableDeMedicion.Location = new System.Drawing.Point(27, 76);
            this.glVariableDeMedicion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glVariableDeMedicion.Name = "glVariableDeMedicion";
            this.glVariableDeMedicion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glVariableDeMedicion.Properties.Appearance.Options.UseFont = true;
            this.glVariableDeMedicion.Properties.NullText = "";
            this.glVariableDeMedicion.Properties.PopupView = this.glVariableMedicion;
            this.glVariableDeMedicion.Size = new System.Drawing.Size(667, 26);
            this.glVariableDeMedicion.TabIndex = 95;
            this.glVariableDeMedicion.EditValueChanged += new System.EventHandler(this.glVariableDeMedicion_EditValueChanged);
            // 
            // glVariableMedicion
            // 
            this.glVariableMedicion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoInstrumentoId,
            this.colDescripcionTipoInstrumento});
            this.glVariableMedicion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glVariableMedicion.Name = "glVariableMedicion";
            this.glVariableMedicion.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glVariableMedicion.OptionsView.ShowGroupPanel = false;
            this.glVariableMedicion.OptionsView.ShowIndicator = false;
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
            this.labelControl10.Location = new System.Drawing.Point(25, 55);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(128, 17);
            this.labelControl10.TabIndex = 94;
            this.labelControl10.Text = "Variable de Medición:";
            // 
            // nmAlarmaAlta
            // 
            this.nmAlarmaAlta.DecimalPlaces = 2;
            this.nmAlarmaAlta.Location = new System.Drawing.Point(202, 195);
            this.nmAlarmaAlta.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nmAlarmaAlta.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmAlarmaAlta.Name = "nmAlarmaAlta";
            this.nmAlarmaAlta.Size = new System.Drawing.Size(150, 23);
            this.nmAlarmaAlta.TabIndex = 149;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(202, 173);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 17);
            this.labelControl2.TabIndex = 148;
            this.labelControl2.Text = "Alarma Alta:";
            // 
            // nmAlarmaBaja
            // 
            this.nmAlarmaBaja.DecimalPlaces = 2;
            this.nmAlarmaBaja.Location = new System.Drawing.Point(27, 195);
            this.nmAlarmaBaja.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nmAlarmaBaja.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmAlarmaBaja.Name = "nmAlarmaBaja";
            this.nmAlarmaBaja.Size = new System.Drawing.Size(150, 23);
            this.nmAlarmaBaja.TabIndex = 147;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 173);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 17);
            this.labelControl1.TabIndex = 146;
            this.labelControl1.Text = "Alarma Baja:";
            // 
            // nmAlarmaTwa
            // 
            this.nmAlarmaTwa.DecimalPlaces = 2;
            this.nmAlarmaTwa.Location = new System.Drawing.Point(544, 195);
            this.nmAlarmaTwa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nmAlarmaTwa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmAlarmaTwa.Name = "nmAlarmaTwa";
            this.nmAlarmaTwa.Size = new System.Drawing.Size(150, 23);
            this.nmAlarmaTwa.TabIndex = 153;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(544, 173);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 17);
            this.labelControl3.TabIndex = 152;
            this.labelControl3.Text = "Alarma TWA:";
            // 
            // nmAlarmaStel
            // 
            this.nmAlarmaStel.DecimalPlaces = 2;
            this.nmAlarmaStel.Location = new System.Drawing.Point(374, 195);
            this.nmAlarmaStel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nmAlarmaStel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmAlarmaStel.Name = "nmAlarmaStel";
            this.nmAlarmaStel.Size = new System.Drawing.Size(150, 23);
            this.nmAlarmaStel.TabIndex = 151;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(374, 173);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 17);
            this.labelControl4.TabIndex = 150;
            this.labelControl4.Text = "Alarma Stel:";
            // 
            // toggleTieneAlarma
            // 
            this.toggleTieneAlarma.Location = new System.Drawing.Point(25, 120);
            this.toggleTieneAlarma.Name = "toggleTieneAlarma";
            this.toggleTieneAlarma.Properties.OffText = "No tiene alarma";
            this.toggleTieneAlarma.Properties.OnText = "Tiene alarma";
            this.toggleTieneAlarma.Size = new System.Drawing.Size(176, 24);
            this.toggleTieneAlarma.TabIndex = 154;
            // 
            // btnGuardarVinculacion
            // 
            this.btnGuardarVinculacion.FlatAppearance.BorderSize = 0;
            this.btnGuardarVinculacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVinculacion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarVinculacion.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarVinculacion.IconColor = System.Drawing.Color.Black;
            this.btnGuardarVinculacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarVinculacion.IconSize = 30;
            this.btnGuardarVinculacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarVinculacion.Location = new System.Drawing.Point(453, 266);
            this.btnGuardarVinculacion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarVinculacion.Name = "btnGuardarVinculacion";
            this.btnGuardarVinculacion.Size = new System.Drawing.Size(241, 52);
            this.btnGuardarVinculacion.TabIndex = 155;
            this.btnGuardarVinculacion.Text = "Guardar Vinculación";
            this.btnGuardarVinculacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarVinculacion.UseVisualStyleBackColor = true;
            this.btnGuardarVinculacion.Click += new System.EventHandler(this.btnGuardarVinculacion_Click);
            // 
            // frmInstrumentoVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 345);
            this.Controls.Add(this.btnGuardarVinculacion);
            this.Controls.Add(this.toggleTieneAlarma);
            this.Controls.Add(this.nmAlarmaTwa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.nmAlarmaStel);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.nmAlarmaAlta);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.nmAlarmaBaja);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.glVariableDeMedicion);
            this.Controls.Add(this.labelControl10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInstrumentoVariable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.glVariableDeMedicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glVariableMedicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAlarmaAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAlarmaBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAlarmaTwa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAlarmaStel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleTieneAlarma.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit glVariableDeMedicion;
        private DevExpress.XtraGrid.Views.Grid.GridView glVariableMedicion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInstrumentoId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionTipoInstrumento;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.NumericUpDown nmAlarmaAlta;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.NumericUpDown nmAlarmaBaja;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.NumericUpDown nmAlarmaTwa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.NumericUpDown nmAlarmaStel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ToggleSwitch toggleTieneAlarma;
        private FontAwesome.Sharp.IconButton btnGuardarVinculacion;
    }
}