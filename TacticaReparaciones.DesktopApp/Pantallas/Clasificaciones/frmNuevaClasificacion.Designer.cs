
namespace TacticaReparaciones.DesktopApp.Pantallas.Clasificaciones
{
    partial class frmNuevaClasificacion
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
            this.ctlEncabezadoPantalla1 = new TacticaReparaciones.DesktopApp.Componentes.Encabezados.ctlEncabezadoPantalla();
            this.btnGuardarClasificacion = new FontAwesome.Sharp.IconButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.glTipoInstrumento = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gvTipoInstrumento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glMarca = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gvMarca = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glModelo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gvModelo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nmPeriodoCalibracion = new System.Windows.Forms.NumericUpDown();
            this.colTipoInstrumentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarcaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModeloId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoInstrumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPeriodoCalibracion)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlEncabezadoPantalla1
            // 
            this.ctlEncabezadoPantalla1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlEncabezadoPantalla1.Location = new System.Drawing.Point(0, 0);
            this.ctlEncabezadoPantalla1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlEncabezadoPantalla1.Name = "ctlEncabezadoPantalla1";
            this.ctlEncabezadoPantalla1.Size = new System.Drawing.Size(794, 49);
            this.ctlEncabezadoPantalla1.TabIndex = 0;
            // 
            // btnGuardarClasificacion
            // 
            this.btnGuardarClasificacion.FlatAppearance.BorderSize = 0;
            this.btnGuardarClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarClasificacion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarClasificacion.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarClasificacion.IconColor = System.Drawing.Color.Black;
            this.btnGuardarClasificacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarClasificacion.IconSize = 30;
            this.btnGuardarClasificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarClasificacion.Location = new System.Drawing.Point(491, 387);
            this.btnGuardarClasificacion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarClasificacion.Name = "btnGuardarClasificacion";
            this.btnGuardarClasificacion.Size = new System.Drawing.Size(265, 52);
            this.btnGuardarClasificacion.TabIndex = 127;
            this.btnGuardarClasificacion.Text = "Guardar Clasificación";
            this.btnGuardarClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarClasificacion.UseVisualStyleBackColor = true;
            this.btnGuardarClasificacion.Click += new System.EventHandler(this.btnGuardarClasificacionInstrumento_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(36, 65);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(118, 17);
            this.labelControl11.TabIndex = 128;
            this.labelControl11.Text = "Tipo de Instrumento";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 141);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 17);
            this.labelControl1.TabIndex = 130;
            this.labelControl1.Text = "Marca";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(36, 218);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 17);
            this.labelControl2.TabIndex = 132;
            this.labelControl2.Text = "Modelo";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(36, 296);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(134, 17);
            this.labelControl3.TabIndex = 134;
            this.labelControl3.Text = "Periodo de Calibración";
            // 
            // glTipoInstrumento
            // 
            this.glTipoInstrumento.EditValue = "";
            this.glTipoInstrumento.Location = new System.Drawing.Point(36, 87);
            this.glTipoInstrumento.Name = "glTipoInstrumento";
            this.glTipoInstrumento.Properties.AutoHeight = false;
            this.glTipoInstrumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glTipoInstrumento.Properties.NullText = "";
            this.glTipoInstrumento.Properties.PopupView = this.gvTipoInstrumento;
            this.glTipoInstrumento.Size = new System.Drawing.Size(720, 31);
            this.glTipoInstrumento.TabIndex = 136;
            // 
            // gvTipoInstrumento
            // 
            this.gvTipoInstrumento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoInstrumentoId,
            this.colDescripcion});
            this.gvTipoInstrumento.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvTipoInstrumento.Name = "gvTipoInstrumento";
            this.gvTipoInstrumento.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvTipoInstrumento.OptionsView.ShowGroupPanel = false;
            // 
            // glMarca
            // 
            this.glMarca.Location = new System.Drawing.Point(36, 163);
            this.glMarca.Name = "glMarca";
            this.glMarca.Properties.AutoHeight = false;
            this.glMarca.Properties.NullText = "";
            this.glMarca.Properties.PopupView = this.gvMarca;
            this.glMarca.Size = new System.Drawing.Size(720, 31);
            this.glMarca.TabIndex = 137;
            // 
            // gvMarca
            // 
            this.gvMarca.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMarcaId,
            this.colDescripcionMarca});
            this.gvMarca.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvMarca.Name = "gvMarca";
            this.gvMarca.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvMarca.OptionsView.ShowGroupPanel = false;
            // 
            // glModelo
            // 
            this.glModelo.Location = new System.Drawing.Point(36, 240);
            this.glModelo.Name = "glModelo";
            this.glModelo.Properties.AutoHeight = false;
            this.glModelo.Properties.NullText = "";
            this.glModelo.Properties.PopupView = this.gvModelo;
            this.glModelo.Size = new System.Drawing.Size(720, 31);
            this.glModelo.TabIndex = 138;
            // 
            // gvModelo
            // 
            this.gvModelo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colModeloId,
            this.colDescripcionModelo});
            this.gvModelo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvModelo.Name = "gvModelo";
            this.gvModelo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvModelo.OptionsView.ShowGroupPanel = false;
            // 
            // nmPeriodoCalibracion
            // 
            this.nmPeriodoCalibracion.Location = new System.Drawing.Point(36, 318);
            this.nmPeriodoCalibracion.Name = "nmPeriodoCalibracion";
            this.nmPeriodoCalibracion.Size = new System.Drawing.Size(150, 23);
            this.nmPeriodoCalibracion.TabIndex = 139;
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
            // colMarcaId
            // 
            this.colMarcaId.Caption = "Id";
            this.colMarcaId.FieldName = "MarcaId";
            this.colMarcaId.Name = "colMarcaId";
            // 
            // colDescripcionMarca
            // 
            this.colDescripcionMarca.Caption = "Descripción";
            this.colDescripcionMarca.FieldName = "Descripcion";
            this.colDescripcionMarca.Name = "colDescripcionMarca";
            this.colDescripcionMarca.OptionsColumn.AllowEdit = false;
            this.colDescripcionMarca.OptionsColumn.ReadOnly = true;
            this.colDescripcionMarca.Visible = true;
            this.colDescripcionMarca.VisibleIndex = 0;
            // 
            // colModeloId
            // 
            this.colModeloId.Caption = "Id";
            this.colModeloId.FieldName = "ModeloId";
            this.colModeloId.Name = "colModeloId";
            // 
            // colDescripcionModelo
            // 
            this.colDescripcionModelo.Caption = "Descripción";
            this.colDescripcionModelo.FieldName = "Descripcion";
            this.colDescripcionModelo.Name = "colDescripcionModelo";
            this.colDescripcionModelo.OptionsColumn.AllowEdit = false;
            this.colDescripcionModelo.OptionsColumn.ReadOnly = true;
            this.colDescripcionModelo.Visible = true;
            this.colDescripcionModelo.VisibleIndex = 0;
            // 
            // frmNuevaClasificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 478);
            this.Controls.Add(this.nmPeriodoCalibracion);
            this.Controls.Add(this.glModelo);
            this.Controls.Add(this.glMarca);
            this.Controls.Add(this.glTipoInstrumento);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.btnGuardarClasificacion);
            this.Controls.Add(this.ctlEncabezadoPantalla1);
            this.Name = "frmNuevaClasificacion";
            this.Text = "Nueva Clasificación";
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoInstrumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPeriodoCalibracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla1;
        private FontAwesome.Sharp.IconButton btnGuardarClasificacion;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit glTipoInstrumento;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTipoInstrumento;
        private DevExpress.XtraEditors.GridLookUpEdit glMarca;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMarca;
        private DevExpress.XtraEditors.GridLookUpEdit glModelo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvModelo;
        private System.Windows.Forms.NumericUpDown nmPeriodoCalibracion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInstrumentoId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colMarcaId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colModeloId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionModelo;
    }
}