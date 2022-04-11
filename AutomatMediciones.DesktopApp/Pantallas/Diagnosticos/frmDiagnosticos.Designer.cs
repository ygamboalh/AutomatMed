
namespace AutomatMediciones.DesktopApp.Pantallas.Diagnosticos
{
    partial class frmDiagnosticos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiagnosticos));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvInstrumentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIngresoInstrumentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstrumentoIdFk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionInstrumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoInstrumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIniciarDiagnostico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnIniciarDiagnostico = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colIngresoFk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvIngresos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIngresoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.ctlEncabezadoPantalla1 = new AutomatMediciones.DesktopApp.Componentes.Encabezados.ctlEncabezadoPantalla();
            this.jsonDataSource1 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvInstrumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarDiagnostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngresos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvInstrumentos
            // 
            this.gvInstrumentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIngresoInstrumentoId,
            this.colInstrumentoIdFk,
            this.colDescripcionInstrumento,
            this.colTipoInstrumento,
            this.colMarca,
            this.colModelo,
            this.colIniciarDiagnostico,
            this.colIngresoFk});
            this.gvInstrumentos.GridControl = this.gridControl1;
            this.gvInstrumentos.Name = "gvInstrumentos";
            this.gvInstrumentos.OptionsView.ShowGroupPanel = false;
            this.gvInstrumentos.OptionsView.ShowIndicator = false;
            // 
            // colIngresoInstrumentoId
            // 
            this.colIngresoInstrumentoId.Caption = "Id";
            this.colIngresoInstrumentoId.FieldName = "IngresoInstrumentoId";
            this.colIngresoInstrumentoId.MinWidth = 25;
            this.colIngresoInstrumentoId.Name = "colIngresoInstrumentoId";
            this.colIngresoInstrumentoId.OptionsColumn.AllowEdit = false;
            this.colIngresoInstrumentoId.OptionsColumn.ReadOnly = true;
            this.colIngresoInstrumentoId.Width = 94;
            // 
            // colInstrumentoIdFk
            // 
            this.colInstrumentoIdFk.Caption = "Instrumento Id";
            this.colInstrumentoIdFk.FieldName = "InstrumentoId";
            this.colInstrumentoIdFk.MinWidth = 25;
            this.colInstrumentoIdFk.Name = "colInstrumentoIdFk";
            this.colInstrumentoIdFk.OptionsColumn.AllowEdit = false;
            this.colInstrumentoIdFk.OptionsColumn.ReadOnly = true;
            this.colInstrumentoIdFk.Width = 94;
            // 
            // colDescripcionInstrumento
            // 
            this.colDescripcionInstrumento.Caption = "Instrumento";
            this.colDescripcionInstrumento.FieldName = "DescripcionInstrumento";
            this.colDescripcionInstrumento.MinWidth = 25;
            this.colDescripcionInstrumento.Name = "colDescripcionInstrumento";
            this.colDescripcionInstrumento.OptionsColumn.AllowEdit = false;
            this.colDescripcionInstrumento.OptionsColumn.ReadOnly = true;
            this.colDescripcionInstrumento.Visible = true;
            this.colDescripcionInstrumento.VisibleIndex = 0;
            this.colDescripcionInstrumento.Width = 94;
            // 
            // colTipoInstrumento
            // 
            this.colTipoInstrumento.Caption = "Tipo de Instrumento";
            this.colTipoInstrumento.FieldName = "TipoInstrumento";
            this.colTipoInstrumento.MinWidth = 25;
            this.colTipoInstrumento.Name = "colTipoInstrumento";
            this.colTipoInstrumento.OptionsColumn.AllowEdit = false;
            this.colTipoInstrumento.OptionsColumn.ReadOnly = true;
            this.colTipoInstrumento.Visible = true;
            this.colTipoInstrumento.VisibleIndex = 1;
            this.colTipoInstrumento.Width = 94;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "Marca";
            this.colMarca.FieldName = "Marca";
            this.colMarca.MinWidth = 25;
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowEdit = false;
            this.colMarca.OptionsColumn.ReadOnly = true;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 2;
            this.colMarca.Width = 94;
            // 
            // colModelo
            // 
            this.colModelo.Caption = "Modelo";
            this.colModelo.FieldName = "Modelo";
            this.colModelo.MinWidth = 25;
            this.colModelo.Name = "colModelo";
            this.colModelo.OptionsColumn.AllowEdit = false;
            this.colModelo.OptionsColumn.ReadOnly = true;
            this.colModelo.Visible = true;
            this.colModelo.VisibleIndex = 3;
            this.colModelo.Width = 94;
            // 
            // colIniciarDiagnostico
            // 
            this.colIniciarDiagnostico.ColumnEdit = this.btnIniciarDiagnostico;
            this.colIniciarDiagnostico.MinWidth = 25;
            this.colIniciarDiagnostico.Name = "colIniciarDiagnostico";
            this.colIniciarDiagnostico.Visible = true;
            this.colIniciarDiagnostico.VisibleIndex = 4;
            this.colIniciarDiagnostico.Width = 40;
            // 
            // btnIniciarDiagnostico
            // 
            this.btnIniciarDiagnostico.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnIniciarDiagnostico.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnIniciarDiagnostico.Name = "btnIniciarDiagnostico";
            this.btnIniciarDiagnostico.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colIngresoFk
            // 
            this.colIngresoFk.Caption = "Ingreso Id";
            this.colIngresoFk.FieldName = "IngresoId";
            this.colIngresoFk.MinWidth = 25;
            this.colIngresoFk.Name = "colIngresoFk";
            this.colIngresoFk.OptionsColumn.AllowEdit = false;
            this.colIngresoFk.OptionsColumn.ReadOnly = true;
            this.colIngresoFk.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gvInstrumentos;
            gridLevelNode1.RelationName = "Instrumentos";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 97);
            this.gridControl1.MainView = this.gvIngresos;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnIniciarDiagnostico});
            this.gridControl1.Size = new System.Drawing.Size(1071, 560);
            this.gridControl1.TabIndex = 157;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIngresos,
            this.gvInstrumentos});
            // 
            // gvIngresos
            // 
            this.gvIngresos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIngresoId,
            this.colPrioridad,
            this.colFecha,
            this.colEmpresa,
            this.colEstado});
            this.gvIngresos.GridControl = this.gridControl1;
            this.gvIngresos.Name = "gvIngresos";
            this.gvIngresos.OptionsView.ShowGroupPanel = false;
            this.gvIngresos.OptionsView.ShowIndicator = false;
            // 
            // colIngresoId
            // 
            this.colIngresoId.Caption = "Id";
            this.colIngresoId.FieldName = "IngresoId";
            this.colIngresoId.MinWidth = 25;
            this.colIngresoId.Name = "colIngresoId";
            this.colIngresoId.OptionsColumn.AllowEdit = false;
            this.colIngresoId.OptionsColumn.ReadOnly = true;
            this.colIngresoId.Width = 94;
            // 
            // colPrioridad
            // 
            this.colPrioridad.Caption = "Prioridad";
            this.colPrioridad.FieldName = "Prioridad";
            this.colPrioridad.MinWidth = 25;
            this.colPrioridad.Name = "colPrioridad";
            this.colPrioridad.OptionsColumn.AllowEdit = false;
            this.colPrioridad.OptionsColumn.ReadOnly = true;
            this.colPrioridad.Visible = true;
            this.colPrioridad.VisibleIndex = 0;
            this.colPrioridad.Width = 94;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.MinWidth = 25;
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            this.colFecha.Width = 94;
            // 
            // colEmpresa
            // 
            this.colEmpresa.Caption = "Empresa";
            this.colEmpresa.FieldName = "NombreEmpresa";
            this.colEmpresa.MinWidth = 25;
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.OptionsColumn.AllowEdit = false;
            this.colEmpresa.OptionsColumn.ReadOnly = true;
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 2;
            this.colEmpresa.Width = 94;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.MinWidth = 25;
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 3;
            this.colEstado.Width = 94;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl5.Location = new System.Drawing.Point(0, 0);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelControl5.Size = new System.Drawing.Size(348, 57);
            this.labelControl5.TabIndex = 152;
            this.labelControl5.Text = "Listado de Ingresos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 57);
            this.panel1.TabIndex = 153;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 657);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 27);
            this.panel2.TabIndex = 154;
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
            // ctlEncabezadoPantalla1
            // 
            this.ctlEncabezadoPantalla1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlEncabezadoPantalla1.Location = new System.Drawing.Point(0, 0);
            this.ctlEncabezadoPantalla1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlEncabezadoPantalla1.Name = "ctlEncabezadoPantalla1";
            this.ctlEncabezadoPantalla1.Size = new System.Drawing.Size(1071, 40);
            this.ctlEncabezadoPantalla1.TabIndex = 156;
            // 
            // jsonDataSource1
            // 
            this.jsonDataSource1.Name = "jsonDataSource1";
            // 
            // frmDiagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 684);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctlEncabezadoPantalla1);
            this.Controls.Add(this.panel2);
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmDiagnosticos";
            this.Text = "Diagnósticos";
            ((System.ComponentModel.ISupportInitialize)(this.gvInstrumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarDiagnostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngresos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;    
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIngresos;
        private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colIngresoId;
        private DevExpress.XtraGrid.Columns.GridColumn colPrioridad;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInstrumentos;
        private DevExpress.XtraGrid.Columns.GridColumn colIngresoInstrumentoId;
        private DevExpress.XtraGrid.Columns.GridColumn colInstrumentoIdFk;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn colIniciarDiagnostico;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnIniciarDiagnostico;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIngresoFk;
    }
}