
namespace AutomatMediciones.DesktopApp.Pantallas.CertificadosDeCalibracion
{
    partial class frmCertificadosDeCalibracion
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificadosDeCalibracion));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcCertificados = new DevExpress.XtraGrid.GridControl();
            this.gvCertificados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCaducidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroCertificado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerCertificado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnVerCertificado = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.saveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExportarExcel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcCertificados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCertificados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerCertificado)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcCertificados
            // 
            this.gcCertificados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCertificados.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcCertificados.Location = new System.Drawing.Point(0, 52);
            this.gcCertificados.MainView = this.gvCertificados;
            this.gcCertificados.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcCertificados.Name = "gcCertificados";
            this.gcCertificados.Padding = new System.Windows.Forms.Padding(5);
            this.gcCertificados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnVerCertificado});
            this.gcCertificados.Size = new System.Drawing.Size(1154, 601);
            this.gcCertificados.TabIndex = 36;
            this.gcCertificados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCertificados});
            // 
            // gvCertificados
            // 
            this.gvCertificados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFecha,
            this.colFechaCaducidad,
            this.colNumeroCertificado,
            this.colResponsable,
            this.colVerCertificado});
            this.gvCertificados.GridControl = this.gcCertificados;
            this.gvCertificados.Name = "gvCertificados";
            this.gvCertificados.OptionsView.ShowAutoFilterRow = true;
            this.gvCertificados.OptionsView.ShowGroupPanel = false;
            this.gvCertificados.OptionsView.ShowIndicator = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Ce";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.MinWidth = 25;
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.AllowFocus = false;
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 230;
            // 
            // colFechaCaducidad
            // 
            this.colFechaCaducidad.Caption = "Fecha de Caducidad";
            this.colFechaCaducidad.FieldName = "FechaCaducidad";
            this.colFechaCaducidad.MinWidth = 25;
            this.colFechaCaducidad.Name = "colFechaCaducidad";
            this.colFechaCaducidad.OptionsColumn.AllowEdit = false;
            this.colFechaCaducidad.OptionsColumn.AllowFocus = false;
            this.colFechaCaducidad.OptionsColumn.ReadOnly = true;
            this.colFechaCaducidad.Visible = true;
            this.colFechaCaducidad.VisibleIndex = 1;
            this.colFechaCaducidad.Width = 230;
            // 
            // colNumeroCertificado
            // 
            this.colNumeroCertificado.Caption = "N° Certificado";
            this.colNumeroCertificado.FieldName = "NumeroCertificado";
            this.colNumeroCertificado.MinWidth = 25;
            this.colNumeroCertificado.Name = "colNumeroCertificado";
            this.colNumeroCertificado.OptionsColumn.AllowEdit = false;
            this.colNumeroCertificado.OptionsColumn.AllowFocus = false;
            this.colNumeroCertificado.OptionsColumn.ReadOnly = true;
            this.colNumeroCertificado.Visible = true;
            this.colNumeroCertificado.VisibleIndex = 2;
            this.colNumeroCertificado.Width = 230;
            // 
            // colResponsable
            // 
            this.colResponsable.Caption = "Responsable";
            this.colResponsable.FieldName = "Responsable.Nombre";
            this.colResponsable.MinWidth = 25;
            this.colResponsable.Name = "colResponsable";
            this.colResponsable.OptionsColumn.AllowEdit = false;
            this.colResponsable.OptionsColumn.AllowFocus = false;
            this.colResponsable.OptionsColumn.ReadOnly = true;
            this.colResponsable.Visible = true;
            this.colResponsable.VisibleIndex = 3;
            this.colResponsable.Width = 230;
            // 
            // colVerCertificado
            // 
            this.colVerCertificado.ColumnEdit = this.btnVerCertificado;
            this.colVerCertificado.MinWidth = 25;
            this.colVerCertificado.Name = "colVerCertificado";
            this.colVerCertificado.Visible = true;
            this.colVerCertificado.VisibleIndex = 4;
            this.colVerCertificado.Width = 25;
            // 
            // btnVerCertificado
            // 
            this.btnVerCertificado.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnVerCertificado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Ver Certificado", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnVerCertificado.Name = "btnVerCertificado";
            this.btnVerCertificado.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 653);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 27);
            this.panel2.TabIndex = 37;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExportarExcel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 7, 0, 7);
            this.panel3.Size = new System.Drawing.Size(1154, 52);
            this.panel3.TabIndex = 39;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportarExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportarExcel.IconColor = System.Drawing.Color.Black;
            this.btnExportarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportarExcel.IconSize = 30;
            this.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarExcel.Location = new System.Drawing.Point(976, 7);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(178, 38);
            this.btnExportarExcel.TabIndex = 163;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // frmCertificadosDeCalibracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 680);
            this.Controls.Add(this.gcCertificados);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCertificadosDeCalibracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificados de Calibración";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcCertificados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCertificados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerCertificado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCertificados;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCertificados;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCaducidad;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroCertificado;
        private DevExpress.XtraGrid.Columns.GridColumn colResponsable;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colVerCertificado;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnVerCertificado;
        private DevExpress.XtraEditors.XtraSaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnExportarExcel;
    }
}