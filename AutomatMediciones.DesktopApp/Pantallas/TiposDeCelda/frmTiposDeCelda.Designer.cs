
namespace AutomatMediciones.DesktopApp.Pantallas.TiposDeCelda
{
    partial class frmTiposDeCelda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposDeCelda));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportarExcel = new FontAwesome.Sharp.IconButton();
            this.btnNuevoTipoDeCelda = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.gcTiposDeCelda = new DevExpress.XtraGrid.GridControl();
            this.gvTipoDeCelda = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoDeCelda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVariableDeMedicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.saveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposDeCelda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoDeCelda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportarExcel);
            this.panel1.Controls.Add(this.btnNuevoTipoDeCelda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 7, 0, 7);
            this.panel1.Size = new System.Drawing.Size(1016, 53);
            this.panel1.TabIndex = 35;
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
            this.btnExportarExcel.Location = new System.Drawing.Point(805, 7);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(211, 39);
            this.btnExportarExcel.TabIndex = 166;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnNuevoTipoDeCelda
            // 
            this.btnNuevoTipoDeCelda.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNuevoTipoDeCelda.FlatAppearance.BorderSize = 0;
            this.btnNuevoTipoDeCelda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTipoDeCelda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoTipoDeCelda.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevoTipoDeCelda.IconColor = System.Drawing.Color.Black;
            this.btnNuevoTipoDeCelda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoTipoDeCelda.IconSize = 30;
            this.btnNuevoTipoDeCelda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoTipoDeCelda.Location = new System.Drawing.Point(8, 7);
            this.btnNuevoTipoDeCelda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNuevoTipoDeCelda.Name = "btnNuevoTipoDeCelda";
            this.btnNuevoTipoDeCelda.Size = new System.Drawing.Size(211, 39);
            this.btnNuevoTipoDeCelda.TabIndex = 16;
            this.btnNuevoTipoDeCelda.Text = "Nuevo Tipo de Celda";
            this.btnNuevoTipoDeCelda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoTipoDeCelda.UseVisualStyleBackColor = true;
            this.btnNuevoTipoDeCelda.Click += new System.EventHandler(this.btnNuevoTipoDeCelda_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 454);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 27);
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
            // gcTiposDeCelda
            // 
            this.gcTiposDeCelda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTiposDeCelda.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcTiposDeCelda.Location = new System.Drawing.Point(0, 53);
            this.gcTiposDeCelda.MainView = this.gvTipoDeCelda;
            this.gcTiposDeCelda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcTiposDeCelda.Name = "gcTiposDeCelda";
            this.gcTiposDeCelda.Padding = new System.Windows.Forms.Padding(5);
            this.gcTiposDeCelda.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar});
            this.gcTiposDeCelda.Size = new System.Drawing.Size(1016, 401);
            this.gcTiposDeCelda.TabIndex = 38;
            this.gcTiposDeCelda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTipoDeCelda});
            // 
            // gvTipoDeCelda
            // 
            this.gvTipoDeCelda.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoDeCelda,
            this.colVariableDeMedicion,
            this.colEditar});
            this.gvTipoDeCelda.GridControl = this.gcTiposDeCelda;
            this.gvTipoDeCelda.Name = "gvTipoDeCelda";
            this.gvTipoDeCelda.OptionsView.ShowAutoFilterRow = true;
            this.gvTipoDeCelda.OptionsView.ShowGroupPanel = false;
            this.gvTipoDeCelda.OptionsView.ShowIndicator = false;
            // 
            // colTipoDeCelda
            // 
            this.colTipoDeCelda.Caption = "Descripción";
            this.colTipoDeCelda.FieldName = "Descripcion";
            this.colTipoDeCelda.MinWidth = 25;
            this.colTipoDeCelda.Name = "colTipoDeCelda";
            this.colTipoDeCelda.OptionsColumn.AllowEdit = false;
            this.colTipoDeCelda.OptionsColumn.AllowFocus = false;
            this.colTipoDeCelda.OptionsColumn.ReadOnly = true;
            this.colTipoDeCelda.Visible = true;
            this.colTipoDeCelda.VisibleIndex = 0;
            this.colTipoDeCelda.Width = 94;
            // 
            // colVariableDeMedicion
            // 
            this.colVariableDeMedicion.Caption = "Variable de Medición";
            this.colVariableDeMedicion.FieldName = "VariableDeMedicion.Descripcion";
            this.colVariableDeMedicion.MinWidth = 25;
            this.colVariableDeMedicion.Name = "colVariableDeMedicion";
            this.colVariableDeMedicion.OptionsColumn.AllowEdit = false;
            this.colVariableDeMedicion.OptionsColumn.AllowFocus = false;
            this.colVariableDeMedicion.OptionsColumn.ReadOnly = true;
            this.colVariableDeMedicion.Visible = true;
            this.colVariableDeMedicion.VisibleIndex = 1;
            this.colVariableDeMedicion.Width = 94;
            // 
            // colEditar
            // 
            this.colEditar.ColumnEdit = this.btnEditar;
            this.colEditar.MaxWidth = 30;
            this.colEditar.MinWidth = 25;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 2;
            this.colEditar.Width = 30;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Editar Tipo de Celda", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmTiposDeCelda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 481);
            this.Controls.Add(this.gcTiposDeCelda);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTiposDeCelda";
            this.Text = "Tipos de Celda";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposDeCelda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoDeCelda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExportarExcel;
        private FontAwesome.Sharp.IconButton btnNuevoTipoDeCelda;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.GridControl gcTiposDeCelda;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTipoDeCelda;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDeCelda;
        private DevExpress.XtraGrid.Columns.GridColumn colVariableDeMedicion;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraEditors.XtraSaveFileDialog saveFileDialog;
    }
}