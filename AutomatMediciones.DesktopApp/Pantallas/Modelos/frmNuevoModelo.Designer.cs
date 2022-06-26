
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gcTiposDeCelda = new DevExpress.XtraGrid.GridControl();
            this.gvTiposDeCelda = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.leTipoCelda = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposDeCelda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposDeCelda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTipoCelda.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(27, 57);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(51, 12);
            this.labelControl11.TabIndex = 125;
            this.labelControl11.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(27, 73);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(440, 24);
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
            this.btnGuardarModelo.Location = new System.Drawing.Point(246, 406);
            this.btnGuardarModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarModelo.Name = "btnGuardarModelo";
            this.btnGuardarModelo.Size = new System.Drawing.Size(220, 42);
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
            this.btnAgregarTipoCelda.Location = new System.Drawing.Point(432, 129);
            this.btnAgregarTipoCelda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarTipoCelda.Name = "btnAgregarTipoCelda";
            this.btnAgregarTipoCelda.Size = new System.Drawing.Size(34, 26);
            this.btnAgregarTipoCelda.TabIndex = 151;
            this.btnAgregarTipoCelda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTipoCelda.UseVisualStyleBackColor = true;
            this.btnAgregarTipoCelda.Click += new System.EventHandler(this.btnAgregarTipoCelda_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(27, 112);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(227, 12);
            this.labelControl4.TabIndex = 149;
            this.labelControl4.Text = "Seleccione un tipo de celda para vincular al Módelo";
            // 
            // gcTiposDeCelda
            // 
            this.gcTiposDeCelda.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcTiposDeCelda.Location = new System.Drawing.Point(27, 189);
            this.gcTiposDeCelda.MainView = this.gvTiposDeCelda;
            this.gcTiposDeCelda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcTiposDeCelda.Name = "gcTiposDeCelda";
            this.gcTiposDeCelda.Size = new System.Drawing.Size(440, 203);
            this.gcTiposDeCelda.TabIndex = 152;
            this.gcTiposDeCelda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTiposDeCelda});
            // 
            // gvTiposDeCelda
            // 
            this.gvTiposDeCelda.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion,
            this.colId});
            this.gvTiposDeCelda.DetailHeight = 284;
            this.gvTiposDeCelda.GridControl = this.gcTiposDeCelda;
            this.gvTiposDeCelda.Name = "gvTiposDeCelda";
            this.gvTiposDeCelda.OptionsView.ShowGroupPanel = false;
            this.gvTiposDeCelda.OptionsView.ShowIndicator = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Celda";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            // 
            // colId
            // 
            this.colId.Caption = "colId";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 171);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 12);
            this.labelControl1.TabIndex = 153;
            this.labelControl1.Text = "Tipos de Celda Vinculados";
            // 
            // leTipoCelda
            // 
            this.leTipoCelda.EditValue = "";
            this.leTipoCelda.Location = new System.Drawing.Point(27, 129);
            this.leTipoCelda.Name = "leTipoCelda";
            this.leTipoCelda.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.leTipoCelda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leTipoCelda.Properties.Appearance.Options.UseFont = true;
            this.leTipoCelda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leTipoCelda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.leTipoCelda.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.leTipoCelda.Properties.NullText = "";
            this.leTipoCelda.Size = new System.Drawing.Size(399, 24);
            this.leTipoCelda.TabIndex = 154;
            // 
            // frmNuevoModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 462);
            this.Controls.Add(this.leTipoCelda);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gcTiposDeCelda);
            this.Controls.Add(this.btnAgregarTipoCelda);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnGuardarModelo);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Name = "frmNuevoModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposDeCelda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposDeCelda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTipoCelda.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private FontAwesome.Sharp.IconButton btnGuardarModelo;
        private FontAwesome.Sharp.IconButton btnAgregarTipoCelda;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gcTiposDeCelda;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTiposDeCelda;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit leTipoCelda;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}