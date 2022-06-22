
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
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.btnGuardarModelo = new FontAwesome.Sharp.IconButton();
            this.btnAgregarTipoCelda = new FontAwesome.Sharp.IconButton();
            this.glTipoInstrumento = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glTipoInstrumentoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoInstrumentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumentoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(31, 70);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(68, 17);
            this.labelControl11.TabIndex = 125;
            this.labelControl11.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(31, 94);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(513, 30);
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
            this.btnGuardarModelo.Location = new System.Drawing.Point(287, 531);
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
            this.btnAgregarTipoCelda.Location = new System.Drawing.Point(504, 177);
            this.btnAgregarTipoCelda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarTipoCelda.Name = "btnAgregarTipoCelda";
            this.btnAgregarTipoCelda.Size = new System.Drawing.Size(40, 32);
            this.btnAgregarTipoCelda.TabIndex = 151;
            this.btnAgregarTipoCelda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTipoCelda.UseVisualStyleBackColor = true;
            // 
            // glTipoInstrumento
            // 
            this.glTipoInstrumento.EditValue = "";
            this.glTipoInstrumento.Location = new System.Drawing.Point(31, 178);
            this.glTipoInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glTipoInstrumento.Name = "glTipoInstrumento";
            this.glTipoInstrumento.Properties.AutoHeight = false;
            this.glTipoInstrumento.Properties.NullText = "";
            this.glTipoInstrumento.Properties.PopupView = this.glTipoInstrumentoView;
            this.glTipoInstrumento.Size = new System.Drawing.Size(465, 31);
            this.glTipoInstrumento.TabIndex = 150;
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
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(31, 156);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(303, 17);
            this.labelControl4.TabIndex = 149;
            this.labelControl4.Text = "Seleccione un tipo de celda para vincular al Módelo";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(31, 263);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(513, 250);
            this.gridControl1.TabIndex = 152;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 241);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 17);
            this.labelControl1.TabIndex = 153;
            this.labelControl1.Text = "Tipos de Celda";
            // 
            // frmNuevoModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 604);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnAgregarTipoCelda);
            this.Controls.Add(this.glTipoInstrumento);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnGuardarModelo);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNuevoModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumentoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private FontAwesome.Sharp.IconButton btnGuardarModelo;
        private FontAwesome.Sharp.IconButton btnAgregarTipoCelda;
        private DevExpress.XtraEditors.GridLookUpEdit glTipoInstrumento;
        private DevExpress.XtraGrid.Views.Grid.GridView glTipoInstrumentoView;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInstrumentoId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}