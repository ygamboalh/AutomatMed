﻿
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
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstrumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClasificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroSerie = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gcCertificados.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcCertificados.Location = new System.Drawing.Point(0, 42);
            this.gcCertificados.MainView = this.gvCertificados;
            this.gcCertificados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcCertificados.Name = "gcCertificados";
            this.gcCertificados.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcCertificados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnVerCertificado});
            this.gcCertificados.Size = new System.Drawing.Size(893, 488);
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
            this.colEmpresa,
            this.colInstrumento,
            this.colClasificacion,
            this.colNumeroSerie,
            this.colVerCertificado});
            this.gvCertificados.DetailHeight = 284;
            this.gvCertificados.GridControl = this.gcCertificados;
            this.gvCertificados.Name = "gvCertificados";
            this.gvCertificados.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvCertificados.OptionsView.ShowAutoFilterRow = true;
            this.gvCertificados.OptionsView.ShowGroupPanel = false;
            this.gvCertificados.OptionsView.ShowIndicator = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Ce";
            this.colId.MinWidth = 21;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Width = 81;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.MinWidth = 21;
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.AllowFocus = false;
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 64;
            // 
            // colFechaCaducidad
            // 
            this.colFechaCaducidad.Caption = "Fecha de Caducidad";
            this.colFechaCaducidad.FieldName = "FechaCaducidad";
            this.colFechaCaducidad.MinWidth = 21;
            this.colFechaCaducidad.Name = "colFechaCaducidad";
            this.colFechaCaducidad.OptionsColumn.AllowEdit = false;
            this.colFechaCaducidad.OptionsColumn.AllowFocus = false;
            this.colFechaCaducidad.OptionsColumn.ReadOnly = true;
            this.colFechaCaducidad.Visible = true;
            this.colFechaCaducidad.VisibleIndex = 1;
            this.colFechaCaducidad.Width = 64;
            // 
            // colNumeroCertificado
            // 
            this.colNumeroCertificado.Caption = "N° Certificado";
            this.colNumeroCertificado.FieldName = "NumeroCertificado";
            this.colNumeroCertificado.MinWidth = 21;
            this.colNumeroCertificado.Name = "colNumeroCertificado";
            this.colNumeroCertificado.OptionsColumn.AllowEdit = false;
            this.colNumeroCertificado.OptionsColumn.AllowFocus = false;
            this.colNumeroCertificado.OptionsColumn.ReadOnly = true;
            this.colNumeroCertificado.Visible = true;
            this.colNumeroCertificado.VisibleIndex = 2;
            this.colNumeroCertificado.Width = 152;
            // 
            // colResponsable
            // 
            this.colResponsable.Caption = "Responsable";
            this.colResponsable.FieldName = "Responsable.Nombre";
            this.colResponsable.MinWidth = 21;
            this.colResponsable.Name = "colResponsable";
            this.colResponsable.OptionsColumn.AllowEdit = false;
            this.colResponsable.OptionsColumn.AllowFocus = false;
            this.colResponsable.OptionsColumn.ReadOnly = true;
            this.colResponsable.Visible = true;
            this.colResponsable.VisibleIndex = 3;
            this.colResponsable.Width = 152;
            // 
            // colEmpresa
            // 
            this.colEmpresa.Caption = "Empresa";
            this.colEmpresa.FieldName = "Instrumento.NombreEmpresa";
            this.colEmpresa.MinWidth = 21;
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.OptionsColumn.AllowEdit = false;
            this.colEmpresa.OptionsColumn.AllowFocus = false;
            this.colEmpresa.OptionsColumn.ReadOnly = true;
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 4;
            this.colEmpresa.Width = 147;
            // 
            // colInstrumento
            // 
            this.colInstrumento.Caption = "Instrumento";
            this.colInstrumento.FieldName = "Instrumento.Descripcion";
            this.colInstrumento.MinWidth = 21;
            this.colInstrumento.Name = "colInstrumento";
            this.colInstrumento.OptionsColumn.AllowEdit = false;
            this.colInstrumento.OptionsColumn.AllowFocus = false;
            this.colInstrumento.OptionsColumn.ReadOnly = true;
            this.colInstrumento.Visible = true;
            this.colInstrumento.VisibleIndex = 5;
            this.colInstrumento.Width = 109;
            // 
            // colClasificacion
            // 
            this.colClasificacion.Caption = "Clasificación";
            this.colClasificacion.FieldName = "ClasificacionConcatenada";
            this.colClasificacion.MinWidth = 21;
            this.colClasificacion.Name = "colClasificacion";
            this.colClasificacion.OptionsColumn.AllowEdit = false;
            this.colClasificacion.OptionsColumn.AllowFocus = false;
            this.colClasificacion.OptionsColumn.ReadOnly = true;
            this.colClasificacion.Visible = true;
            this.colClasificacion.VisibleIndex = 6;
            this.colClasificacion.Width = 152;
            // 
            // colNumeroSerie
            // 
            this.colNumeroSerie.Caption = "N° Serie";
            this.colNumeroSerie.FieldName = "Instrumento.NumeroSerie";
            this.colNumeroSerie.MinWidth = 21;
            this.colNumeroSerie.Name = "colNumeroSerie";
            this.colNumeroSerie.OptionsColumn.AllowEdit = false;
            this.colNumeroSerie.OptionsColumn.AllowFocus = false;
            this.colNumeroSerie.OptionsColumn.ReadOnly = true;
            this.colNumeroSerie.Visible = true;
            this.colNumeroSerie.VisibleIndex = 7;
            this.colNumeroSerie.Width = 115;
            // 
            // colVerCertificado
            // 
            this.colVerCertificado.ColumnEdit = this.btnVerCertificado;
            this.colVerCertificado.MinWidth = 21;
            this.colVerCertificado.Name = "colVerCertificado";
            this.colVerCertificado.Visible = true;
            this.colVerCertificado.VisibleIndex = 8;
            this.colVerCertificado.Width = 33;
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
            this.panel2.Location = new System.Drawing.Point(0, 530);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 22);
            this.panel2.TabIndex = 37;
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(6, 12);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExportarExcel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(7, 6, 0, 6);
            this.panel3.Size = new System.Drawing.Size(893, 42);
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
            this.btnExportarExcel.Location = new System.Drawing.Point(740, 6);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(153, 30);
            this.btnExportarExcel.TabIndex = 163;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // frmCertificadosDeCalibracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 552);
            this.Controls.Add(this.gcCertificados);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn colClasificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroSerie;
    }
}