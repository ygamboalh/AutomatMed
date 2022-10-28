namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos
{
    partial class frmPreIngresos
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
            this.gcPreIngresos = new DevExpress.XtraGrid.GridControl();
            this.gvPreIngresos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPreIngresoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstrumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClasificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPreIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlBtnAgregar = new System.Windows.Forms.Panel();
            this.btnAgregarPreIngreso = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIntrumentosSeleccionados = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcPreIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPreIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).BeginInit();
            this.pnlBtnAgregar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcPreIngresos
            // 
            this.gcPreIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPreIngresos.Location = new System.Drawing.Point(0, 0);
            this.gcPreIngresos.MainView = this.gvPreIngresos;
            this.gcPreIngresos.Name = "gcPreIngresos";
            this.gcPreIngresos.Padding = new System.Windows.Forms.Padding(10);
            this.gcPreIngresos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSeleccionar});
            this.gcPreIngresos.Size = new System.Drawing.Size(1101, 602);
            this.gcPreIngresos.TabIndex = 0;
            this.gcPreIngresos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPreIngresos});
            // 
            // gvPreIngresos
            // 
            this.gvPreIngresos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPreIngresoId,
            this.colInstrumento,
            this.colClasificacion,
            this.colSerie,
            this.colPrioridad,
            this.colResponsable,
            this.colFechaPreIngreso,
            this.colSeleccionar});
            this.gvPreIngresos.GridControl = this.gcPreIngresos;
            this.gvPreIngresos.Name = "gvPreIngresos";
            this.gvPreIngresos.OptionsView.ShowGroupPanel = false;
            this.gvPreIngresos.OptionsView.ShowIndicator = false;
            // 
            // colPreIngresoId
            // 
            this.colPreIngresoId.Caption = "N° Pre-Ingreso";
            this.colPreIngresoId.FieldName = "NumeroServicioTecnico";
            this.colPreIngresoId.MinWidth = 25;
            this.colPreIngresoId.Name = "colPreIngresoId";
            this.colPreIngresoId.OptionsColumn.AllowEdit = false;
            this.colPreIngresoId.OptionsColumn.AllowFocus = false;
            this.colPreIngresoId.Visible = true;
            this.colPreIngresoId.VisibleIndex = 0;
            this.colPreIngresoId.Width = 110;
            // 
            // colInstrumento
            // 
            this.colInstrumento.Caption = "Instrumento";
            this.colInstrumento.FieldName = "Instrumento.Descripcion";
            this.colInstrumento.MinWidth = 25;
            this.colInstrumento.Name = "colInstrumento";
            this.colInstrumento.OptionsColumn.AllowEdit = false;
            this.colInstrumento.OptionsColumn.AllowFocus = false;
            this.colInstrumento.Visible = true;
            this.colInstrumento.VisibleIndex = 1;
            this.colInstrumento.Width = 156;
            // 
            // colClasificacion
            // 
            this.colClasificacion.Caption = "Clasificación";
            this.colClasificacion.FieldName = "ClasificacionConcatenada";
            this.colClasificacion.MinWidth = 25;
            this.colClasificacion.Name = "colClasificacion";
            this.colClasificacion.OptionsColumn.AllowEdit = false;
            this.colClasificacion.OptionsColumn.AllowFocus = false;
            this.colClasificacion.Visible = true;
            this.colClasificacion.VisibleIndex = 2;
            this.colClasificacion.Width = 156;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "N° Serie";
            this.colSerie.FieldName = "Instrumento.NumeroSerie";
            this.colSerie.MinWidth = 25;
            this.colSerie.Name = "colSerie";
            this.colSerie.OptionsColumn.AllowEdit = false;
            this.colSerie.OptionsColumn.AllowFocus = false;
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 3;
            this.colSerie.Width = 156;
            // 
            // colPrioridad
            // 
            this.colPrioridad.Caption = "Prioridad";
            this.colPrioridad.FieldName = "Prioridad";
            this.colPrioridad.MinWidth = 25;
            this.colPrioridad.Name = "colPrioridad";
            this.colPrioridad.OptionsColumn.AllowEdit = false;
            this.colPrioridad.OptionsColumn.AllowFocus = false;
            this.colPrioridad.Visible = true;
            this.colPrioridad.VisibleIndex = 4;
            this.colPrioridad.Width = 81;
            // 
            // colResponsable
            // 
            this.colResponsable.Caption = "Responsable Pre-Ingreso";
            this.colResponsable.FieldName = "Responsable.Nombre";
            this.colResponsable.MinWidth = 25;
            this.colResponsable.Name = "colResponsable";
            this.colResponsable.OptionsColumn.AllowEdit = false;
            this.colResponsable.OptionsColumn.AllowFocus = false;
            this.colResponsable.Visible = true;
            this.colResponsable.VisibleIndex = 5;
            this.colResponsable.Width = 187;
            // 
            // colFechaPreIngreso
            // 
            this.colFechaPreIngreso.Caption = "Fecha Pre-Ingreso";
            this.colFechaPreIngreso.FieldName = "Ingreso.FechaRegistro";
            this.colFechaPreIngreso.MinWidth = 25;
            this.colFechaPreIngreso.Name = "colFechaPreIngreso";
            this.colFechaPreIngreso.OptionsColumn.AllowEdit = false;
            this.colFechaPreIngreso.OptionsColumn.AllowFocus = false;
            this.colFechaPreIngreso.Visible = true;
            this.colFechaPreIngreso.VisibleIndex = 6;
            this.colFechaPreIngreso.Width = 187;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Caption = " ";
            this.colSeleccionar.ColumnEdit = this.chkSeleccionar;
            this.colSeleccionar.FieldName = "Seleccionado";
            this.colSeleccionar.MinWidth = 25;
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Visible = true;
            this.colSeleccionar.VisibleIndex = 7;
            this.colSeleccionar.Width = 30;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoHeight = false;
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive;
            // 
            // pnlBtnAgregar
            // 
            this.pnlBtnAgregar.Controls.Add(this.btnAgregarPreIngreso);
            this.pnlBtnAgregar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtnAgregar.Location = new System.Drawing.Point(0, 534);
            this.pnlBtnAgregar.Name = "pnlBtnAgregar";
            this.pnlBtnAgregar.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBtnAgregar.Size = new System.Drawing.Size(1101, 68);
            this.pnlBtnAgregar.TabIndex = 1;
            // 
            // btnAgregarPreIngreso
            // 
            this.btnAgregarPreIngreso.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregarPreIngreso.FlatAppearance.BorderSize = 0;
            this.btnAgregarPreIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPreIngreso.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarPreIngreso.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAgregarPreIngreso.IconColor = System.Drawing.Color.Black;
            this.btnAgregarPreIngreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarPreIngreso.IconSize = 30;
            this.btnAgregarPreIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPreIngreso.Location = new System.Drawing.Point(717, 10);
            this.btnAgregarPreIngreso.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarPreIngreso.Name = "btnAgregarPreIngreso";
            this.btnAgregarPreIngreso.Size = new System.Drawing.Size(374, 48);
            this.btnAgregarPreIngreso.TabIndex = 25;
            this.btnAgregarPreIngreso.Text = "Agregar Pre-Ingresos Seleccionados";
            this.btnAgregarPreIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPreIngreso.UseVisualStyleBackColor = true;
            this.btnAgregarPreIngreso.Click += new System.EventHandler(this.btnAgregarPreIngreso_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblIntrumentosSeleccionados);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 507);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1101, 27);
            this.panel2.TabIndex = 155;
            // 
            // lblIntrumentosSeleccionados
            // 
            this.lblIntrumentosSeleccionados.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIntrumentosSeleccionados.Appearance.Options.UseFont = true;
            this.lblIntrumentosSeleccionados.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblIntrumentosSeleccionados.Location = new System.Drawing.Point(1089, 5);
            this.lblIntrumentosSeleccionados.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lblIntrumentosSeleccionados.Name = "lblIntrumentosSeleccionados";
            this.lblIntrumentosSeleccionados.Size = new System.Drawing.Size(7, 17);
            this.lblIntrumentosSeleccionados.TabIndex = 28;
            this.lblIntrumentosSeleccionados.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Location = new System.Drawing.Point(5, 5);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(7, 17);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // frmPreIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBtnAgregar);
            this.Controls.Add(this.gcPreIngresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPreIngresos";
            this.Text = "Pre-Ingresos";
            ((System.ComponentModel.ISupportInitialize)(this.gcPreIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPreIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).EndInit();
            this.pnlBtnAgregar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPreIngresos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPreIngresos;
        private DevExpress.XtraGrid.Columns.GridColumn colPreIngresoId;
        private DevExpress.XtraGrid.Columns.GridColumn colInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn colClasificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colPrioridad;
        private DevExpress.XtraGrid.Columns.GridColumn colResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPreIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSeleccionar;
        private System.Windows.Forms.Panel pnlBtnAgregar;
        private FontAwesome.Sharp.IconButton btnAgregarPreIngreso;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl lblIntrumentosSeleccionados;
    }
}