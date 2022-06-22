
namespace AutomatMediciones.DesktopApp.Pantallas.Celdas
{
    partial class frmCeldas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCeldas));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportarExcel = new FontAwesome.Sharp.IconButton();
            this.btnAgregarNuevaCelda = new FontAwesome.Sharp.IconButton();
            this.gcCeldas = new DevExpress.XtraGrid.GridControl();
            this.gvCeldas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCeldaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCelda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAdquisicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFabricacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.saveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCeldas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCeldas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportarExcel);
            this.panel1.Controls.Add(this.btnAgregarNuevaCelda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 7, 0, 7);
            this.panel1.Size = new System.Drawing.Size(974, 53);
            this.panel1.TabIndex = 34;
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
            this.btnExportarExcel.Location = new System.Drawing.Point(763, 7);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(211, 39);
            this.btnExportarExcel.TabIndex = 164;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnAgregarNuevaCelda
            // 
            this.btnAgregarNuevaCelda.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarNuevaCelda.FlatAppearance.BorderSize = 0;
            this.btnAgregarNuevaCelda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevaCelda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarNuevaCelda.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarNuevaCelda.IconColor = System.Drawing.Color.Black;
            this.btnAgregarNuevaCelda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarNuevaCelda.IconSize = 30;
            this.btnAgregarNuevaCelda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNuevaCelda.Location = new System.Drawing.Point(8, 7);
            this.btnAgregarNuevaCelda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarNuevaCelda.Name = "btnAgregarNuevaCelda";
            this.btnAgregarNuevaCelda.Size = new System.Drawing.Size(211, 39);
            this.btnAgregarNuevaCelda.TabIndex = 16;
            this.btnAgregarNuevaCelda.Text = "Nueva Celda";
            this.btnAgregarNuevaCelda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNuevaCelda.UseVisualStyleBackColor = true;
            this.btnAgregarNuevaCelda.Click += new System.EventHandler(this.btnAgregarNuevaCelda_Click);
            // 
            // gcCeldas
            // 
            this.gcCeldas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCeldas.Location = new System.Drawing.Point(0, 53);
            this.gcCeldas.MainView = this.gvCeldas;
            this.gcCeldas.Name = "gcCeldas";
            this.gcCeldas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar});
            this.gcCeldas.Size = new System.Drawing.Size(974, 472);
            this.gcCeldas.TabIndex = 35;
            this.gcCeldas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCeldas});
            // 
            // gvCeldas
            // 
            this.gvCeldas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCeldaId,
            this.colTipoCelda,
            this.colNumeroSerie,
            this.colEstado,
            this.colFechaAdquisicion,
            this.colFechaFabricacion,
            this.colEditar});
            this.gvCeldas.GridControl = this.gcCeldas;
            this.gvCeldas.Name = "gvCeldas";
            this.gvCeldas.OptionsView.ShowGroupPanel = false;
            this.gvCeldas.OptionsView.ShowIndicator = false;
            // 
            // colCeldaId
            // 
            this.colCeldaId.Caption = "Id";
            this.colCeldaId.FieldName = "Id";
            this.colCeldaId.MinWidth = 25;
            this.colCeldaId.Name = "colCeldaId";
            this.colCeldaId.OptionsColumn.AllowEdit = false;
            this.colCeldaId.OptionsColumn.AllowFocus = false;
            this.colCeldaId.OptionsColumn.ReadOnly = true;
            this.colCeldaId.Width = 138;
            // 
            // colTipoCelda
            // 
            this.colTipoCelda.Caption = "Tipo de Celda";
            this.colTipoCelda.FieldName = "TipoCelda.Descripcion";
            this.colTipoCelda.MinWidth = 25;
            this.colTipoCelda.Name = "colTipoCelda";
            this.colTipoCelda.OptionsColumn.AllowEdit = false;
            this.colTipoCelda.OptionsColumn.AllowFocus = false;
            this.colTipoCelda.OptionsColumn.ReadOnly = true;
            this.colTipoCelda.Visible = true;
            this.colTipoCelda.VisibleIndex = 0;
            this.colTipoCelda.Width = 138;
            // 
            // colNumeroSerie
            // 
            this.colNumeroSerie.Caption = "N° Serie";
            this.colNumeroSerie.FieldName = "NumeroSerie";
            this.colNumeroSerie.MinWidth = 25;
            this.colNumeroSerie.Name = "colNumeroSerie";
            this.colNumeroSerie.OptionsColumn.AllowEdit = false;
            this.colNumeroSerie.OptionsColumn.AllowFocus = false;
            this.colNumeroSerie.OptionsColumn.ReadOnly = true;
            this.colNumeroSerie.Visible = true;
            this.colNumeroSerie.VisibleIndex = 1;
            this.colNumeroSerie.Width = 138;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado.Descripcion";
            this.colEstado.MinWidth = 25;
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.OptionsColumn.AllowFocus = false;
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            this.colEstado.Width = 138;
            // 
            // colFechaAdquisicion
            // 
            this.colFechaAdquisicion.Caption = "Fecha de Adquisición";
            this.colFechaAdquisicion.FieldName = "FechaAdquisicion";
            this.colFechaAdquisicion.MinWidth = 25;
            this.colFechaAdquisicion.Name = "colFechaAdquisicion";
            this.colFechaAdquisicion.OptionsColumn.AllowEdit = false;
            this.colFechaAdquisicion.OptionsColumn.AllowFocus = false;
            this.colFechaAdquisicion.OptionsColumn.ReadOnly = true;
            this.colFechaAdquisicion.Visible = true;
            this.colFechaAdquisicion.VisibleIndex = 3;
            this.colFechaAdquisicion.Width = 138;
            // 
            // colFechaFabricacion
            // 
            this.colFechaFabricacion.Caption = "Fecha Fabricación";
            this.colFechaFabricacion.FieldName = "FechaFabricacion";
            this.colFechaFabricacion.MinWidth = 25;
            this.colFechaFabricacion.Name = "colFechaFabricacion";
            this.colFechaFabricacion.OptionsColumn.AllowEdit = false;
            this.colFechaFabricacion.OptionsColumn.AllowFocus = false;
            this.colFechaFabricacion.OptionsColumn.ReadOnly = true;
            this.colFechaFabricacion.Visible = true;
            this.colFechaFabricacion.VisibleIndex = 4;
            this.colFechaFabricacion.Width = 138;
            // 
            // colEditar
            // 
            this.colEditar.ColumnEdit = this.btnEditar;
            this.colEditar.MinWidth = 25;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 5;
            this.colEditar.Width = 30;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 525);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 27);
            this.panel2.TabIndex = 36;
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
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "xtraSaveFileDialog1";
            // 
            // frmCeldas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 552);
            this.Controls.Add(this.gcCeldas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCeldas";
            this.Text = "Celdas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCeldas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCeldas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExportarExcel;
        private FontAwesome.Sharp.IconButton btnAgregarNuevaCelda;
        private DevExpress.XtraGrid.GridControl gcCeldas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCeldas;
        private DevExpress.XtraGrid.Columns.GridColumn colCeldaId;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCelda;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAdquisicion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFabricacion;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraEditors.XtraSaveFileDialog saveFileDialog;
    }
}