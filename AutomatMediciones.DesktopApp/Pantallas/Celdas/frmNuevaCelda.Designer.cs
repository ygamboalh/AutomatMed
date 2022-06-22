
namespace AutomatMediciones.DesktopApp.Pantallas.Celdas
{
    partial class frmNuevaCelda
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
            this.glTipoCelda = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glTipoInstrumentoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoInstrumentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.dateFechaAdquisicion = new DevExpress.XtraEditors.DateEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroSerie = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dateFechaFabricacion = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardarCelda = new FontAwesome.Sharp.IconButton();
            this.gleEstado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glevEstado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoCelda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumentoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaAdquisicion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaAdquisicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaFabricacion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaFabricacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glevEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // glTipoCelda
            // 
            this.glTipoCelda.EditValue = "";
            this.glTipoCelda.Location = new System.Drawing.Point(23, 119);
            this.glTipoCelda.Name = "glTipoCelda";
            this.glTipoCelda.Properties.AutoHeight = false;
            this.glTipoCelda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glTipoCelda.Properties.NullText = "";
            this.glTipoCelda.Properties.PopupView = this.glTipoInstrumentoView;
            this.glTipoCelda.Size = new System.Drawing.Size(346, 31);
            this.glTipoCelda.TabIndex = 138;
            // 
            // glTipoInstrumentoView
            // 
            this.glTipoInstrumentoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoInstrumentoId,
            this.colDescripcion});
            this.glTipoInstrumentoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glTipoInstrumentoView.Name = "glTipoInstrumentoView";
            this.glTipoInstrumentoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glTipoInstrumentoView.OptionsView.ShowGroupPanel = false;
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
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(23, 97);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(85, 17);
            this.labelControl11.TabIndex = 137;
            this.labelControl11.Text = "Tipo de Celda:";
            // 
            // dateFechaAdquisicion
            // 
            this.dateFechaAdquisicion.EditValue = null;
            this.dateFechaAdquisicion.Location = new System.Drawing.Point(23, 189);
            this.dateFechaAdquisicion.Name = "dateFechaAdquisicion";
            this.dateFechaAdquisicion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaAdquisicion.Properties.Appearance.Options.UseFont = true;
            this.dateFechaAdquisicion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaAdquisicion.Size = new System.Drawing.Size(346, 30);
            this.dateFechaAdquisicion.TabIndex = 158;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(23, 165);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(123, 17);
            this.labelControl15.TabIndex = 157;
            this.labelControl15.Text = "Fecha de Adquisición";
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.EditValue = "";
            this.txtNumeroSerie.Location = new System.Drawing.Point(400, 121);
            this.txtNumeroSerie.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroSerie.Properties.Appearance.Options.UseFont = true;
            this.txtNumeroSerie.Properties.UseReadOnlyAppearance = false;
            this.txtNumeroSerie.Size = new System.Drawing.Size(359, 30);
            this.txtNumeroSerie.TabIndex = 160;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(400, 97);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(103, 17);
            this.labelControl9.TabIndex = 159;
            this.labelControl9.Text = "Número de Serie:";
            // 
            // dateFechaFabricacion
            // 
            this.dateFechaFabricacion.EditValue = null;
            this.dateFechaFabricacion.Location = new System.Drawing.Point(400, 189);
            this.dateFechaFabricacion.Name = "dateFechaFabricacion";
            this.dateFechaFabricacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaFabricacion.Properties.Appearance.Options.UseFont = true;
            this.dateFechaFabricacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaFabricacion.Size = new System.Drawing.Size(359, 30);
            this.dateFechaFabricacion.TabIndex = 162;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(400, 165);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(125, 17);
            this.labelControl1.TabIndex = 161;
            this.labelControl1.Text = "Fecha de Fabricación:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 246);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 17);
            this.labelControl2.TabIndex = 163;
            this.labelControl2.Text = "Estado:";
            // 
            // btnGuardarCelda
            // 
            this.btnGuardarCelda.FlatAppearance.BorderSize = 0;
            this.btnGuardarCelda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCelda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarCelda.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarCelda.IconColor = System.Drawing.Color.Black;
            this.btnGuardarCelda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCelda.IconSize = 30;
            this.btnGuardarCelda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCelda.Location = new System.Drawing.Point(539, 339);
            this.btnGuardarCelda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarCelda.Name = "btnGuardarCelda";
            this.btnGuardarCelda.Size = new System.Drawing.Size(220, 52);
            this.btnGuardarCelda.TabIndex = 165;
            this.btnGuardarCelda.Text = "Guardar Celda";
            this.btnGuardarCelda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCelda.UseVisualStyleBackColor = true;
            this.btnGuardarCelda.Click += new System.EventHandler(this.btnGuardarCelda_Click);
            // 
            // gleEstado
            // 
            this.gleEstado.EditValue = "";
            this.gleEstado.Location = new System.Drawing.Point(23, 268);
            this.gleEstado.Name = "gleEstado";
            this.gleEstado.Properties.AutoHeight = false;
            this.gleEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleEstado.Properties.NullText = "";
            this.gleEstado.Properties.PopupView = this.glevEstado;
            this.gleEstado.Size = new System.Drawing.Size(346, 31);
            this.gleEstado.TabIndex = 166;
            // 
            // glevEstado
            // 
            this.glevEstado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.glevEstado.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glevEstado.Name = "glevEstado";
            this.glevEstado.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glevEstado.OptionsView.ShowGroupPanel = false;
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
            // frmNuevaCelda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 414);
            this.Controls.Add(this.gleEstado);
            this.Controls.Add(this.btnGuardarCelda);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dateFechaFabricacion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dateFechaAdquisicion);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.glTipoCelda);
            this.Controls.Add(this.labelControl11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNuevaCelda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Celda";
            ((System.ComponentModel.ISupportInitialize)(this.glTipoCelda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumentoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaAdquisicion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaAdquisicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaFabricacion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaFabricacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glevEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit glTipoCelda;
        private DevExpress.XtraGrid.Views.Grid.GridView glTipoInstrumentoView;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInstrumentoId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.DateEdit dateFechaAdquisicion;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtNumeroSerie;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dateFechaFabricacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private FontAwesome.Sharp.IconButton btnGuardarCelda;
        private DevExpress.XtraEditors.GridLookUpEdit gleEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView glevEstado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}