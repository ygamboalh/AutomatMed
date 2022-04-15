
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiagnosticos));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnIniciarDiagnostico = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcInstrumentos = new DevExpress.XtraGrid.GridControl();
            this.gvInstrumentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIngresoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClasificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroServicioTecnico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaEstimada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIniciarDiagnostico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngresoInstrumentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarDiagnostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstrumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstrumentos)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.gcInstrumentos.Location = new System.Drawing.Point(0, 57);
            this.gcInstrumentos.MainView = this.gvInstrumentos;
            this.gcInstrumentos.Name = "gcInstrumentos";
            this.gcInstrumentos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnIniciarDiagnostico});
            this.gcInstrumentos.Size = new System.Drawing.Size(1534, 600);
            this.gcInstrumentos.TabIndex = 157;
            this.gcInstrumentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInstrumentos});
            // 
            // gvInstrumentos
            // 
            this.gvInstrumentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIngresoId,
            this.colPrioridad,
            this.colDescripcion,
            this.colClasificacion,
            this.colFecha,
            this.colEmpresa,
            this.colEstado,
            this.colNumeroServicioTecnico,
            this.colFechaEstimada,
            this.colIniciarDiagnostico,
            this.colIngresoInstrumentoId});
            this.gvInstrumentos.GridControl = this.gcInstrumentos;
            this.gvInstrumentos.Name = "gvInstrumentos";
            this.gvInstrumentos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvInstrumentos.OptionsView.ShowGroupPanel = false;
            this.gvInstrumentos.OptionsView.ShowIndicator = false;
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
            this.colPrioridad.Width = 78;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Instrumento";
            this.colDescripcion.FieldName = "Instrumento.Descripcion";
            this.colDescripcion.MinWidth = 25;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 276;
            // 
            // colClasificacion
            // 
            this.colClasificacion.Caption = "Clasificación";
            this.colClasificacion.FieldName = "ClasificacionConcatenada";
            this.colClasificacion.MinWidth = 25;
            this.colClasificacion.Name = "colClasificacion";
            this.colClasificacion.OptionsColumn.AllowEdit = false;
            this.colClasificacion.OptionsColumn.ReadOnly = true;
            this.colClasificacion.Visible = true;
            this.colClasificacion.VisibleIndex = 2;
            this.colClasificacion.Width = 304;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha de Ingreso";
            this.colFecha.DisplayFormat.FormatString = "dd/MM/yy";
            this.colFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFecha.FieldName = "Ingreso.FechaRegistro";
            this.colFecha.MinWidth = 25;
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 3;
            this.colFecha.Width = 97;
            // 
            // colEmpresa
            // 
            this.colEmpresa.Caption = "Empresa";
            this.colEmpresa.FieldName = "Ingreso.NombreEmpresa";
            this.colEmpresa.MinWidth = 25;
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.OptionsColumn.AllowEdit = false;
            this.colEmpresa.OptionsColumn.ReadOnly = true;
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 4;
            this.colEmpresa.Width = 260;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado.Descripcion";
            this.colEstado.MinWidth = 25;
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 5;
            this.colEstado.Width = 195;
            // 
            // colNumeroServicioTecnico
            // 
            this.colNumeroServicioTecnico.Caption = "N° Servicio Técnico";
            this.colNumeroServicioTecnico.FieldName = "NumeroServicioTecnico";
            this.colNumeroServicioTecnico.MinWidth = 25;
            this.colNumeroServicioTecnico.Name = "colNumeroServicioTecnico";
            this.colNumeroServicioTecnico.OptionsColumn.AllowEdit = false;
            this.colNumeroServicioTecnico.OptionsColumn.ReadOnly = true;
            this.colNumeroServicioTecnico.Visible = true;
            this.colNumeroServicioTecnico.VisibleIndex = 6;
            this.colNumeroServicioTecnico.Width = 130;
            // 
            // colFechaEstimada
            // 
            this.colFechaEstimada.Caption = "Fecha de Entrega Requerida";
            this.colFechaEstimada.FieldName = "FechaEntregaRequerida";
            this.colFechaEstimada.MinWidth = 25;
            this.colFechaEstimada.Name = "colFechaEstimada";
            this.colFechaEstimada.OptionsColumn.AllowEdit = false;
            this.colFechaEstimada.OptionsColumn.ReadOnly = true;
            this.colFechaEstimada.Visible = true;
            this.colFechaEstimada.VisibleIndex = 7;
            this.colFechaEstimada.Width = 97;
            // 
            // colIniciarDiagnostico
            // 
            this.colIniciarDiagnostico.Caption = "Iniciar Diagnóstico";
            this.colIniciarDiagnostico.ColumnEdit = this.btnIniciarDiagnostico;
            this.colIniciarDiagnostico.MinWidth = 25;
            this.colIniciarDiagnostico.Name = "colIniciarDiagnostico";
            this.colIniciarDiagnostico.Visible = true;
            this.colIniciarDiagnostico.VisibleIndex = 8;
            this.colIniciarDiagnostico.Width = 94;
            // 
            // colIngresoInstrumentoId
            // 
            this.colIngresoInstrumentoId.Caption = "Ingreso Instrumento Id";
            this.colIngresoInstrumentoId.FieldName = "IngresoInstrumentoId";
            this.colIngresoInstrumentoId.MinWidth = 25;
            this.colIngresoInstrumentoId.Name = "colIngresoInstrumentoId";
            this.colIngresoInstrumentoId.Width = 94;
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
            this.labelControl5.Text = "Instrumentos Ingresados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1534, 57);
            this.panel1.TabIndex = 153;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 657);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1534, 27);
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
            // frmDiagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 684);
            this.Controls.Add(this.gcInstrumentos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmDiagnosticos";
            this.Text = "Diagnósticos";
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarDiagnostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstrumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstrumentos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

  
        private DevExpress.XtraEditors.LabelControl labelControl5;
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
    }
}