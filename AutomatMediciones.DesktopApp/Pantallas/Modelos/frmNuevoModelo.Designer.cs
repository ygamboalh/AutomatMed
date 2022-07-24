
namespace AutomatMediciones.DesktopApp.Pantallas.Modelos
{
    partial class frmNuevoModelo
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoModelo));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.btnGuardarModelo = new FontAwesome.Sharp.IconButton();
            this.btnAgregarTipoCelda = new FontAwesome.Sharp.IconButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gcTiposDeCeldaModelo = new DevExpress.XtraGrid.GridControl();
            this.gvTiposDeCeldaModelo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVariableDeMedicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimerValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSegundoValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTolerancia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.leTipoCelda = new DevExpress.XtraEditors.LookUpEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposDeCeldaModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposDeCeldaModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTipoCelda.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(31, 70);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(71, 17);
            this.labelControl11.TabIndex = 125;
            this.labelControl11.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(31, 90);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(513, 28);
            this.txtDescripcion.TabIndex = 126;
            // 
            // btnGuardarModelo
            // 
            this.btnGuardarModelo.FlatAppearance.BorderSize = 0;
            this.btnGuardarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarModelo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarModelo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarModelo.IconColor = System.Drawing.Color.Black;
            this.btnGuardarModelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarModelo.IconSize = 30;
            this.btnGuardarModelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarModelo.Location = new System.Drawing.Point(649, 501);
            this.btnGuardarModelo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarModelo.Name = "btnGuardarModelo";
            this.btnGuardarModelo.Size = new System.Drawing.Size(257, 52);
            this.btnGuardarModelo.TabIndex = 127;
            this.btnGuardarModelo.Text = "Guardar Modelo";
            this.btnGuardarModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarModelo.UseVisualStyleBackColor = true;
            this.btnGuardarModelo.Click += new System.EventHandler(this.btnGuardarModelo_Click);
            // 
            // btnAgregarTipoCelda
            // 
            this.btnAgregarTipoCelda.FlatAppearance.BorderSize = 0;
            this.btnAgregarTipoCelda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTipoCelda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarTipoCelda.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarTipoCelda.IconColor = System.Drawing.Color.Black;
            this.btnAgregarTipoCelda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarTipoCelda.IconSize = 30;
            this.btnAgregarTipoCelda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTipoCelda.Location = new System.Drawing.Point(505, 150);
            this.btnAgregarTipoCelda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarTipoCelda.Name = "btnAgregarTipoCelda";
            this.btnAgregarTipoCelda.Size = new System.Drawing.Size(40, 32);
            this.btnAgregarTipoCelda.TabIndex = 151;
            this.btnAgregarTipoCelda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTipoCelda.UseVisualStyleBackColor = true;
            this.btnAgregarTipoCelda.Click += new System.EventHandler(this.btnAgregarTipoCelda_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(33, 129);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(303, 17);
            this.labelControl4.TabIndex = 149;
            this.labelControl4.Text = "Seleccione un tipo de celda para vincular al Modelo";
            // 
            // gcTiposDeCeldaModelo
            // 
            this.gcTiposDeCeldaModelo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcTiposDeCeldaModelo.Location = new System.Drawing.Point(31, 217);
            this.gcTiposDeCeldaModelo.MainView = this.gvTiposDeCeldaModelo;
            this.gcTiposDeCeldaModelo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcTiposDeCeldaModelo.Name = "gcTiposDeCeldaModelo";
            this.gcTiposDeCeldaModelo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEliminar});
            this.gcTiposDeCeldaModelo.Size = new System.Drawing.Size(874, 233);
            this.gcTiposDeCeldaModelo.TabIndex = 152;
            this.gcTiposDeCeldaModelo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTiposDeCeldaModelo});
            // 
            // gvTiposDeCeldaModelo
            // 
            this.gvTiposDeCeldaModelo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion,
            this.colVariableDeMedicion,
            this.colPrimerValor,
            this.colSegundoValor,
            this.colTolerancia,
            this.colId,
            this.colEliminar});
            this.gvTiposDeCeldaModelo.GridControl = this.gcTiposDeCeldaModelo;
            this.gvTiposDeCeldaModelo.Name = "gvTiposDeCeldaModelo";
            this.gvTiposDeCeldaModelo.OptionsView.ShowGroupPanel = false;
            this.gvTiposDeCeldaModelo.OptionsView.ShowIndicator = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Tipo de Celda";
            this.colDescripcion.FieldName = "TipoDeCelda.Descripcion";
            this.colDescripcion.MinWidth = 23;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowFocus = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 181;
            // 
            // colVariableDeMedicion
            // 
            this.colVariableDeMedicion.Caption = "Variable de Medición";
            this.colVariableDeMedicion.FieldName = "TipoDeCelda.VariableDeMedicion.Descripcion";
            this.colVariableDeMedicion.MinWidth = 23;
            this.colVariableDeMedicion.Name = "colVariableDeMedicion";
            this.colVariableDeMedicion.OptionsColumn.AllowEdit = false;
            this.colVariableDeMedicion.OptionsColumn.AllowFocus = false;
            this.colVariableDeMedicion.OptionsColumn.ReadOnly = true;
            this.colVariableDeMedicion.Visible = true;
            this.colVariableDeMedicion.VisibleIndex = 1;
            this.colVariableDeMedicion.Width = 180;
            // 
            // colPrimerValor
            // 
            this.colPrimerValor.Caption = "Primer Valor Rango";
            this.colPrimerValor.FieldName = "TipoDeCelda.VariableDeMedicion.PrimerValorRango";
            this.colPrimerValor.MinWidth = 23;
            this.colPrimerValor.Name = "colPrimerValor";
            this.colPrimerValor.OptionsColumn.AllowEdit = false;
            this.colPrimerValor.OptionsColumn.AllowFocus = false;
            this.colPrimerValor.OptionsColumn.ReadOnly = true;
            this.colPrimerValor.Visible = true;
            this.colPrimerValor.VisibleIndex = 2;
            this.colPrimerValor.Width = 115;
            // 
            // colSegundoValor
            // 
            this.colSegundoValor.Caption = "Segundo Valor Rango";
            this.colSegundoValor.FieldName = "TipoDeCelda.VariableDeMedicion.SegundoValorRango";
            this.colSegundoValor.MinWidth = 23;
            this.colSegundoValor.Name = "colSegundoValor";
            this.colSegundoValor.OptionsColumn.AllowEdit = false;
            this.colSegundoValor.OptionsColumn.AllowFocus = false;
            this.colSegundoValor.OptionsColumn.ReadOnly = true;
            this.colSegundoValor.Visible = true;
            this.colSegundoValor.VisibleIndex = 3;
            this.colSegundoValor.Width = 115;
            // 
            // colTolerancia
            // 
            this.colTolerancia.Caption = "Tolerancia";
            this.colTolerancia.FieldName = "TipoDeCelda.VariableDeMedicion.Tolerancia";
            this.colTolerancia.MinWidth = 23;
            this.colTolerancia.Name = "colTolerancia";
            this.colTolerancia.OptionsColumn.AllowEdit = false;
            this.colTolerancia.OptionsColumn.AllowFocus = false;
            this.colTolerancia.OptionsColumn.ReadOnly = true;
            this.colTolerancia.Visible = true;
            this.colTolerancia.VisibleIndex = 4;
            this.colTolerancia.Width = 80;
            // 
            // colId
            // 
            this.colId.Caption = "colId";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 23;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Width = 87;
            // 
            // colEliminar
            // 
            this.colEliminar.ColumnEdit = this.btnEliminar;
            this.colEliminar.MinWidth = 23;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 5;
            this.colEliminar.Width = 35;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 194);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(155, 17);
            this.labelControl1.TabIndex = 153;
            this.labelControl1.Text = "Tipos de Celda Vinculados";
            // 
            // leTipoCelda
            // 
            this.leTipoCelda.EditValue = "";
            this.leTipoCelda.Location = new System.Drawing.Point(33, 150);
            this.leTipoCelda.Margin = new System.Windows.Forms.Padding(4);
            this.leTipoCelda.Name = "leTipoCelda";
            this.leTipoCelda.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.leTipoCelda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leTipoCelda.Properties.Appearance.Options.UseFont = true;
            this.leTipoCelda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leTipoCelda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 23, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.leTipoCelda.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.leTipoCelda.Properties.NullText = "";
            this.leTipoCelda.Size = new System.Drawing.Size(465, 28);
            this.leTipoCelda.TabIndex = 154;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Location = new System.Drawing.Point(31, 454);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 27);
            this.panel2.TabIndex = 155;
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(7, 17);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // frmNuevoModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.leTipoCelda);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gcTiposDeCeldaModelo);
            this.Controls.Add(this.btnAgregarTipoCelda);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnGuardarModelo);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNuevoModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposDeCeldaModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposDeCeldaModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTipoCelda.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private FontAwesome.Sharp.IconButton btnGuardarModelo;
        private FontAwesome.Sharp.IconButton btnAgregarTipoCelda;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gcTiposDeCeldaModelo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTiposDeCeldaModelo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit leTipoCelda;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colVariableDeMedicion;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimerValor;
        private DevExpress.XtraGrid.Columns.GridColumn colSegundoValor;
        private DevExpress.XtraGrid.Columns.GridColumn colTolerancia;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEliminar;
    }
}