
namespace AutomatMediciones.DesktopApp.Pantallas.TiposDeCelda
{
    partial class frmNuevoTIpoCelda
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
            this.glVariablesDeMedicion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glVariablesDeMedicionView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoInstrumentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardarTipoCelda = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glVariablesDeMedicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glVariablesDeMedicionView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(27, 84);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(68, 17);
            this.labelControl11.TabIndex = 123;
            this.labelControl11.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(27, 107);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(626, 30);
            this.txtDescripcion.TabIndex = 124;
            // 
            // glVariablesDeMedicion
            // 
            this.glVariablesDeMedicion.EditValue = "";
            this.glVariablesDeMedicion.Location = new System.Drawing.Point(26, 173);
            this.glVariablesDeMedicion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glVariablesDeMedicion.Name = "glVariablesDeMedicion";
            this.glVariablesDeMedicion.Properties.AutoHeight = false;
            this.glVariablesDeMedicion.Properties.NullText = "";
            this.glVariablesDeMedicion.Properties.PopupView = this.glVariablesDeMedicionView;
            this.glVariablesDeMedicion.Size = new System.Drawing.Size(627, 31);
            this.glVariablesDeMedicion.TabIndex = 149;
            // 
            // glVariablesDeMedicionView
            // 
            this.glVariablesDeMedicionView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoInstrumentoId,
            this.colDescripcion});
            this.glVariablesDeMedicionView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glVariablesDeMedicionView.Name = "glVariablesDeMedicionView";
            this.glVariablesDeMedicionView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glVariablesDeMedicionView.OptionsView.ShowGroupPanel = false;
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
            this.labelControl4.Location = new System.Drawing.Point(27, 152);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(125, 17);
            this.labelControl4.TabIndex = 148;
            this.labelControl4.Text = "Variable de Medición";
            // 
            // btnGuardarTipoCelda
            // 
            this.btnGuardarTipoCelda.FlatAppearance.BorderSize = 0;
            this.btnGuardarTipoCelda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTipoCelda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarTipoCelda.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarTipoCelda.IconColor = System.Drawing.Color.Black;
            this.btnGuardarTipoCelda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarTipoCelda.IconSize = 30;
            this.btnGuardarTipoCelda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarTipoCelda.Location = new System.Drawing.Point(412, 242);
            this.btnGuardarTipoCelda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarTipoCelda.Name = "btnGuardarTipoCelda";
            this.btnGuardarTipoCelda.Size = new System.Drawing.Size(241, 52);
            this.btnGuardarTipoCelda.TabIndex = 159;
            this.btnGuardarTipoCelda.Text = "Guardar Tipo de Celda";
            this.btnGuardarTipoCelda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarTipoCelda.UseVisualStyleBackColor = true;
            this.btnGuardarTipoCelda.Click += new System.EventHandler(this.btnGuardarTipoCelda_Click);
            // 
            // frmNuevoTIpoCelda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 325);
            this.Controls.Add(this.btnGuardarTipoCelda);
            this.Controls.Add(this.glVariablesDeMedicion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNuevoTIpoCelda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipos de Celda";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glVariablesDeMedicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glVariablesDeMedicionView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.GridLookUpEdit glVariablesDeMedicion;
        private DevExpress.XtraGrid.Views.Grid.GridView glVariablesDeMedicionView;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInstrumentoId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private FontAwesome.Sharp.IconButton btnGuardarTipoCelda;
    }
}