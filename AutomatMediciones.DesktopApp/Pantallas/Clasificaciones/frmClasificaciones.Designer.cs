
namespace AutomatMediciones.DesktopApp.Pantallas.Clasificaciones
{
    partial class frmClasificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClasificaciones));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcClasificaciones = new DevExpress.XtraGrid.GridControl();
            this.gvClasificaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoInstrumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriodoCalibracion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colInactivar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdInactivar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportarExcel = new FontAwesome.Sharp.IconButton();
            this.btnNuevaClasificacion = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.saveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcClasificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClasificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdInactivar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcClasificaciones
            // 
            this.gcClasificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcClasificaciones.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcClasificaciones.Location = new System.Drawing.Point(0, 53);
            this.gcClasificaciones.MainView = this.gvClasificaciones;
            this.gcClasificaciones.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcClasificaciones.Name = "gcClasificaciones";
            this.gcClasificaciones.Padding = new System.Windows.Forms.Padding(5);
            this.gcClasificaciones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditar,
            this.cmdInactivar});
            this.gcClasificaciones.Size = new System.Drawing.Size(964, 567);
            this.gcClasificaciones.TabIndex = 32;
            this.gcClasificaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClasificaciones});
            // 
            // gvClasificaciones
            // 
            this.gvClasificaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTipoInstrumento,
            this.colMarca,
            this.colModelo,
            this.colPeriodoCalibracion,
            this.colEditar,
            this.colInactivar});
            this.gvClasificaciones.GridControl = this.gcClasificaciones;
            this.gvClasificaciones.Name = "gvClasificaciones";
            this.gvClasificaciones.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvClasificaciones.OptionsView.ShowAutoFilterRow = true;
            this.gvClasificaciones.OptionsView.ShowGroupPanel = false;
            this.gvClasificaciones.OptionsView.ShowIndicator = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "TipoInstrumentoId";
            this.colId.MinWidth = 24;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Width = 198;
            // 
            // colTipoInstrumento
            // 
            this.colTipoInstrumento.Caption = "Tipo de Instrumento";
            this.colTipoInstrumento.FieldName = "TipoInstrumento.Descripcion";
            this.colTipoInstrumento.MinWidth = 24;
            this.colTipoInstrumento.Name = "colTipoInstrumento";
            this.colTipoInstrumento.OptionsColumn.AllowEdit = false;
            this.colTipoInstrumento.OptionsColumn.ReadOnly = true;
            this.colTipoInstrumento.Visible = true;
            this.colTipoInstrumento.VisibleIndex = 0;
            this.colTipoInstrumento.Width = 203;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "Marca";
            this.colMarca.FieldName = "Marca.Descripcion";
            this.colMarca.MinWidth = 24;
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowEdit = false;
            this.colMarca.OptionsColumn.ReadOnly = true;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 1;
            this.colMarca.Width = 268;
            // 
            // colModelo
            // 
            this.colModelo.Caption = "Modelo";
            this.colModelo.FieldName = "Modelo.Descripcion";
            this.colModelo.MinWidth = 24;
            this.colModelo.Name = "colModelo";
            this.colModelo.OptionsColumn.AllowEdit = false;
            this.colModelo.OptionsColumn.ReadOnly = true;
            this.colModelo.Visible = true;
            this.colModelo.VisibleIndex = 2;
            this.colModelo.Width = 268;
            // 
            // colPeriodoCalibracion
            // 
            this.colPeriodoCalibracion.Caption = "Periodo de Calibración";
            this.colPeriodoCalibracion.FieldName = "PeriodoDeCalibracion";
            this.colPeriodoCalibracion.MinWidth = 25;
            this.colPeriodoCalibracion.Name = "colPeriodoCalibracion";
            this.colPeriodoCalibracion.OptionsColumn.AllowEdit = false;
            this.colPeriodoCalibracion.Visible = true;
            this.colPeriodoCalibracion.VisibleIndex = 3;
            this.colPeriodoCalibracion.Width = 127;
            // 
            // colEditar
            // 
            this.colEditar.ColumnEdit = this.cmdEditar;
            this.colEditar.MinWidth = 24;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 4;
            this.colEditar.Width = 30;
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colInactivar
            // 
            this.colInactivar.ColumnEdit = this.cmdInactivar;
            this.colInactivar.MinWidth = 25;
            this.colInactivar.Name = "colInactivar";
            this.colInactivar.Visible = true;
            this.colInactivar.VisibleIndex = 5;
            this.colInactivar.Width = 30;
            // 
            // cmdInactivar
            // 
            this.cmdInactivar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdInactivar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdInactivar.Name = "cmdInactivar";
            this.cmdInactivar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportarExcel);
            this.panel1.Controls.Add(this.btnNuevaClasificacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 7, 0, 7);
            this.panel1.Size = new System.Drawing.Size(964, 53);
            this.panel1.TabIndex = 33;
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
            this.btnExportarExcel.Location = new System.Drawing.Point(753, 7);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(211, 39);
            this.btnExportarExcel.TabIndex = 163;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnNuevaClasificacion
            // 
            this.btnNuevaClasificacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNuevaClasificacion.FlatAppearance.BorderSize = 0;
            this.btnNuevaClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaClasificacion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevaClasificacion.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevaClasificacion.IconColor = System.Drawing.Color.Black;
            this.btnNuevaClasificacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaClasificacion.IconSize = 30;
            this.btnNuevaClasificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaClasificacion.Location = new System.Drawing.Point(8, 7);
            this.btnNuevaClasificacion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNuevaClasificacion.Name = "btnNuevaClasificacion";
            this.btnNuevaClasificacion.Size = new System.Drawing.Size(280, 39);
            this.btnNuevaClasificacion.TabIndex = 16;
            this.btnNuevaClasificacion.Text = "Nueva Clasificación";
            this.btnNuevaClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaClasificacion.UseVisualStyleBackColor = true;
            this.btnNuevaClasificacion.Click += new System.EventHandler(this.btnNuevaClasificacion_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 27);
            this.panel2.TabIndex = 34;
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
            // frmClasificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 647);
            this.Controls.Add(this.gcClasificaciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Name = "frmClasificaciones";
            this.Text = "Clasificaciones de Instrumentos";
            ((System.ComponentModel.ISupportInitialize)(this.gcClasificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClasificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdInactivar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcClasificaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClasificaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnNuevaClasificacion;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriodoCalibracion;
        private DevExpress.XtraGrid.Columns.GridColumn colInactivar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdInactivar;
        private FontAwesome.Sharp.IconButton btnExportarExcel;
        private DevExpress.XtraEditors.XtraSaveFileDialog saveFileDialog;
    }
}