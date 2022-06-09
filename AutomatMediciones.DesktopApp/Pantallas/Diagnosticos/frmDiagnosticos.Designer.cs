
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnIniciarDiagnostico = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcInstrumentos = new DevExpress.XtraGrid.GridControl();
            this.gvInstrumentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIngresoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroServicioTecnico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClasificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaEstimada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIniciarDiagnostico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngresoInstrumentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerReporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnVerReporteDeIngreso = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExportarExcel = new FontAwesome.Sharp.IconButton();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.btnComercial = new FontAwesome.Sharp.IconButton();
            this.btnServicioTecnico = new FontAwesome.Sharp.IconButton();
            this.btnFiltroTodos = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.saveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarDiagnostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstrumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstrumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerReporteDeIngreso)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // gcInstrumentos
            // 
            this.gcInstrumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInstrumentos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcInstrumentos.Location = new System.Drawing.Point(0, 58);
            this.gcInstrumentos.MainView = this.gvInstrumentos;
            this.gcInstrumentos.Margin = new System.Windows.Forms.Padding(4);
            this.gcInstrumentos.Name = "gcInstrumentos";
            this.gcInstrumentos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnIniciarDiagnostico,
            this.btnVerReporteDeIngreso});
            this.gcInstrumentos.Size = new System.Drawing.Size(1243, 599);
            this.gcInstrumentos.TabIndex = 157;
            this.gcInstrumentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInstrumentos});
            // 
            // gvInstrumentos
            // 
            this.gvInstrumentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIngresoId,
            this.colNumeroServicioTecnico,
            this.colEmpresa,
            this.colDescripcion,
            this.colClasificacion,
            this.colSerie,
            this.colPrioridad,
            this.colResponsable,
            this.colFecha,
            this.colFechaEstimada,
            this.colEstado,
            this.colIniciarDiagnostico,
            this.colIngresoInstrumentoId,
            this.colVerReporte});
            this.gvInstrumentos.DetailHeight = 351;
            this.gvInstrumentos.GridControl = this.gcInstrumentos;
            this.gvInstrumentos.Name = "gvInstrumentos";
            this.gvInstrumentos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvInstrumentos.OptionsView.ShowAutoFilterRow = true;
            this.gvInstrumentos.OptionsView.ShowGroupPanel = false;
            this.gvInstrumentos.OptionsView.ShowIndicator = false;
            // 
            // colIngresoId
            // 
            this.colIngresoId.Caption = "Id";
            this.colIngresoId.FieldName = "IngresoId";
            this.colIngresoId.MinWidth = 24;
            this.colIngresoId.Name = "colIngresoId";
            this.colIngresoId.OptionsColumn.AllowEdit = false;
            this.colIngresoId.OptionsColumn.ReadOnly = true;
            this.colIngresoId.Width = 94;
            // 
            // colNumeroServicioTecnico
            // 
            this.colNumeroServicioTecnico.Caption = "N° Servicio Técnico";
            this.colNumeroServicioTecnico.FieldName = "NumeroServicioTecnico";
            this.colNumeroServicioTecnico.MinWidth = 24;
            this.colNumeroServicioTecnico.Name = "colNumeroServicioTecnico";
            this.colNumeroServicioTecnico.OptionsColumn.AllowEdit = false;
            this.colNumeroServicioTecnico.OptionsColumn.ReadOnly = true;
            this.colNumeroServicioTecnico.Visible = true;
            this.colNumeroServicioTecnico.VisibleIndex = 0;
            this.colNumeroServicioTecnico.Width = 99;
            // 
            // colEmpresa
            // 
            this.colEmpresa.Caption = "Empresa";
            this.colEmpresa.FieldName = "Ingreso.NombreEmpresa";
            this.colEmpresa.MinWidth = 24;
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.OptionsColumn.AllowEdit = false;
            this.colEmpresa.OptionsColumn.ReadOnly = true;
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 1;
            this.colEmpresa.Width = 203;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Instrumento";
            this.colDescripcion.FieldName = "Instrumento.Descripcion";
            this.colDescripcion.MinWidth = 24;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            this.colDescripcion.Width = 205;
            // 
            // colClasificacion
            // 
            this.colClasificacion.Caption = "Clasificación";
            this.colClasificacion.FieldName = "ClasificacionConcatenada";
            this.colClasificacion.MinWidth = 24;
            this.colClasificacion.Name = "colClasificacion";
            this.colClasificacion.OptionsColumn.AllowEdit = false;
            this.colClasificacion.OptionsColumn.ReadOnly = true;
            this.colClasificacion.Visible = true;
            this.colClasificacion.VisibleIndex = 3;
            this.colClasificacion.Width = 237;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "N° Serie";
            this.colSerie.FieldName = "Instrumento.NumeroSerie";
            this.colSerie.MinWidth = 24;
            this.colSerie.Name = "colSerie";
            this.colSerie.OptionsColumn.AllowEdit = false;
            this.colSerie.OptionsColumn.AllowFocus = false;
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 4;
            this.colSerie.Width = 154;
            // 
            // colPrioridad
            // 
            this.colPrioridad.Caption = "Prioridad";
            this.colPrioridad.FieldName = "Prioridad";
            this.colPrioridad.MinWidth = 24;
            this.colPrioridad.Name = "colPrioridad";
            this.colPrioridad.OptionsColumn.AllowEdit = false;
            this.colPrioridad.OptionsColumn.ReadOnly = true;
            this.colPrioridad.Visible = true;
            this.colPrioridad.VisibleIndex = 5;
            this.colPrioridad.Width = 92;
            // 
            // colResponsable
            // 
            this.colResponsable.Caption = "Responsable";
            this.colResponsable.FieldName = "Ingreso.Responsable.Nombre";
            this.colResponsable.MinWidth = 24;
            this.colResponsable.Name = "colResponsable";
            this.colResponsable.OptionsColumn.AllowEdit = false;
            this.colResponsable.OptionsColumn.AllowFocus = false;
            this.colResponsable.Visible = true;
            this.colResponsable.VisibleIndex = 6;
            this.colResponsable.Width = 154;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha de Ingreso";
            this.colFecha.DisplayFormat.FormatString = "dd/MM/yy";
            this.colFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFecha.FieldName = "Ingreso.FechaRegistro";
            this.colFecha.MinWidth = 24;
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 7;
            this.colFecha.Width = 73;
            // 
            // colFechaEstimada
            // 
            this.colFechaEstimada.Caption = "Fecha de Entrega Requerida";
            this.colFechaEstimada.FieldName = "FechaEntregaRequerida";
            this.colFechaEstimada.MinWidth = 24;
            this.colFechaEstimada.Name = "colFechaEstimada";
            this.colFechaEstimada.OptionsColumn.AllowEdit = false;
            this.colFechaEstimada.OptionsColumn.ReadOnly = true;
            this.colFechaEstimada.Visible = true;
            this.colFechaEstimada.VisibleIndex = 8;
            this.colFechaEstimada.Width = 90;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado.Descripcion";
            this.colEstado.MinWidth = 24;
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 9;
            this.colEstado.Width = 142;
            // 
            // colIniciarDiagnostico
            // 
            this.colIniciarDiagnostico.Caption = "Iniciar Diagnóstico";
            this.colIniciarDiagnostico.ColumnEdit = this.btnIniciarDiagnostico;
            this.colIniciarDiagnostico.MinWidth = 24;
            this.colIniciarDiagnostico.Name = "colIniciarDiagnostico";
            this.colIniciarDiagnostico.Visible = true;
            this.colIniciarDiagnostico.VisibleIndex = 10;
            this.colIniciarDiagnostico.Width = 83;
            // 
            // colIngresoInstrumentoId
            // 
            this.colIngresoInstrumentoId.Caption = "Ingreso Instrumento Id";
            this.colIngresoInstrumentoId.FieldName = "IngresoInstrumentoId";
            this.colIngresoInstrumentoId.MinWidth = 24;
            this.colIngresoInstrumentoId.Name = "colIngresoInstrumentoId";
            this.colIngresoInstrumentoId.Width = 94;
            // 
            // colVerReporte
            // 
            this.colVerReporte.Caption = "Visualizar Reporte de Ingreso";
            this.colVerReporte.ColumnEdit = this.btnVerReporteDeIngreso;
            this.colVerReporte.MinWidth = 24;
            this.colVerReporte.Name = "colVerReporte";
            this.colVerReporte.Visible = true;
            this.colVerReporte.VisibleIndex = 11;
            this.colVerReporte.Width = 94;
            // 
            // btnVerReporteDeIngreso
            // 
            this.btnVerReporteDeIngreso.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnVerReporteDeIngreso.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnVerReporteDeIngreso.Name = "btnVerReporteDeIngreso";
            this.btnVerReporteDeIngreso.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 58);
            this.panel1.TabIndex = 153;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExportarExcel);
            this.panel3.Controls.Add(this.btnCliente);
            this.panel3.Controls.Add(this.btnComercial);
            this.panel3.Controls.Add(this.btnServicioTecnico);
            this.panel3.Controls.Add(this.btnFiltroTodos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1243, 58);
            this.panel3.TabIndex = 153;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportarExcel.IconColor = System.Drawing.Color.Black;
            this.btnExportarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportarExcel.IconSize = 30;
            this.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarExcel.Location = new System.Drawing.Point(1052, 10);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(178, 37);
            this.btnExportarExcel.TabIndex = 161;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnCliente.IconColor = System.Drawing.Color.Black;
            this.btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCliente.IconSize = 30;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(562, 10);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(178, 37);
            this.btnCliente.TabIndex = 160;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnComercial
            // 
            this.btnComercial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnComercial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComercial.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComercial.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnComercial.IconColor = System.Drawing.Color.Black;
            this.btnComercial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComercial.IconSize = 30;
            this.btnComercial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComercial.Location = new System.Drawing.Point(376, 10);
            this.btnComercial.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnComercial.Name = "btnComercial";
            this.btnComercial.Size = new System.Drawing.Size(178, 37);
            this.btnComercial.TabIndex = 159;
            this.btnComercial.Text = "Comercial";
            this.btnComercial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComercial.UseVisualStyleBackColor = true;
            this.btnComercial.Click += new System.EventHandler(this.btnComercial_Click);
            // 
            // btnServicioTecnico
            // 
            this.btnServicioTecnico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnServicioTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicioTecnico.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnServicioTecnico.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnServicioTecnico.IconColor = System.Drawing.Color.Black;
            this.btnServicioTecnico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServicioTecnico.IconSize = 30;
            this.btnServicioTecnico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicioTecnico.Location = new System.Drawing.Point(190, 10);
            this.btnServicioTecnico.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnServicioTecnico.Name = "btnServicioTecnico";
            this.btnServicioTecnico.Size = new System.Drawing.Size(178, 37);
            this.btnServicioTecnico.TabIndex = 158;
            this.btnServicioTecnico.Text = "Servicio Técnico";
            this.btnServicioTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServicioTecnico.UseVisualStyleBackColor = true;
            this.btnServicioTecnico.Click += new System.EventHandler(this.btnServicioTecnico_Click);
            // 
            // btnFiltroTodos
            // 
            this.btnFiltroTodos.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltroTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltroTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroTodos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltroTodos.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFiltroTodos.IconColor = System.Drawing.Color.Black;
            this.btnFiltroTodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltroTodos.IconSize = 30;
            this.btnFiltroTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroTodos.Location = new System.Drawing.Point(4, 10);
            this.btnFiltroTodos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFiltroTodos.Name = "btnFiltroTodos";
            this.btnFiltroTodos.Size = new System.Drawing.Size(178, 37);
            this.btnFiltroTodos.TabIndex = 157;
            this.btnFiltroTodos.Text = "Todos";
            this.btnFiltroTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltroTodos.UseVisualStyleBackColor = false;
            this.btnFiltroTodos.Click += new System.EventHandler(this.btnFiltroTodos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 657);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 27);
            this.panel2.TabIndex = 154;
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(7, 17);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // frmDiagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 684);
            this.Controls.Add(this.gcInstrumentos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Name = "frmDiagnosticos";
            this.Text = "Ingresos";
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarDiagnostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstrumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstrumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerReporteDeIngreso)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;    
        private DevExpress.XtraGrid.GridControl gcInstrumentos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInstrumentos;
        private DevExpress.XtraGrid.Columns.GridColumn colIngresoId;
        private DevExpress.XtraGrid.Columns.GridColumn colPrioridad;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnIniciarDiagnostico;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colClasificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroServicioTecnico;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaEstimada;
        private DevExpress.XtraGrid.Columns.GridColumn colIniciarDiagnostico;
        private DevExpress.XtraGrid.Columns.GridColumn colIngresoInstrumentoId;
        private DevExpress.XtraGrid.Columns.GridColumn colResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colVerReporte;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnVerReporteDeIngreso;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconButton btnComercial;
        private FontAwesome.Sharp.IconButton btnServicioTecnico;
        private FontAwesome.Sharp.IconButton btnFiltroTodos;
        private FontAwesome.Sharp.IconButton btnExportarExcel;
        private DevExpress.XtraEditors.XtraSaveFileDialog saveFileDialog;
    }
}