namespace AutomatMediciones.DesktopApp.Pantallas.Presupuestos
{
    partial class frmCrearPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearPresupuesto));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtContactoACargo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroServicioTecnico = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipoOrdenTrabajo = new DevExpress.XtraEditors.TextEdit();
            this.txtClasificacion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.gcProductosPresupuesto = new DevExpress.XtraGrid.GridControl();
            this.gvProductosPresupuesto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigoProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCantidad = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPrecio = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.leMonedas = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlProductosPresupuesto = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookupMonedas = new DevExpress.XtraEditors.LookUpEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSummary = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarProductosDesdeArchivoMaestro = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAgregarDesdeHistorialPresupuesto = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactoACargo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroServicioTecnico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoOrdenTrabajo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClasificacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductosPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductosPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leMonedas)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlProductosPresupuesto.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonedas.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContactoACargo
            // 
            this.txtContactoACargo.Location = new System.Drawing.Point(326, 58);
            this.txtContactoACargo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtContactoACargo.Name = "txtContactoACargo";
            this.txtContactoACargo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContactoACargo.Properties.Appearance.Options.UseFont = true;
            this.txtContactoACargo.Properties.ReadOnly = true;
            this.txtContactoACargo.Properties.UseReadOnlyAppearance = false;
            this.txtContactoACargo.Size = new System.Drawing.Size(312, 26);
            this.txtContactoACargo.TabIndex = 201;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(326, 37);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(107, 17);
            this.labelControl14.TabIndex = 200;
            this.labelControl14.Text = "Contacto a cargo:";
            // 
            // txtNumeroServicioTecnico
            // 
            this.txtNumeroServicioTecnico.Location = new System.Drawing.Point(644, 58);
            this.txtNumeroServicioTecnico.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNumeroServicioTecnico.Name = "txtNumeroServicioTecnico";
            this.txtNumeroServicioTecnico.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroServicioTecnico.Properties.Appearance.Options.UseFont = true;
            this.txtNumeroServicioTecnico.Properties.ReadOnly = true;
            this.txtNumeroServicioTecnico.Properties.UseReadOnlyAppearance = false;
            this.txtNumeroServicioTecnico.Size = new System.Drawing.Size(182, 26);
            this.txtNumeroServicioTecnico.TabIndex = 199;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(644, 41);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 17);
            this.labelControl2.TabIndex = 198;
            this.labelControl2.Text = "N° Servicio Técnico:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(15, 58);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliente.Properties.Appearance.Options.UseFont = true;
            this.txtCliente.Properties.ReadOnly = true;
            this.txtCliente.Properties.UseReadOnlyAppearance = false;
            this.txtCliente.Size = new System.Drawing.Size(304, 26);
            this.txtCliente.TabIndex = 197;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(14, 41);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(44, 17);
            this.labelControl13.TabIndex = 196;
            this.labelControl13.Text = "Cliente:";
            // 
            // txtTipoOrdenTrabajo
            // 
            this.txtTipoOrdenTrabajo.Location = new System.Drawing.Point(14, 111);
            this.txtTipoOrdenTrabajo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTipoOrdenTrabajo.Name = "txtTipoOrdenTrabajo";
            this.txtTipoOrdenTrabajo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipoOrdenTrabajo.Properties.Appearance.Options.UseFont = true;
            this.txtTipoOrdenTrabajo.Properties.ReadOnly = true;
            this.txtTipoOrdenTrabajo.Properties.UseReadOnlyAppearance = false;
            this.txtTipoOrdenTrabajo.Size = new System.Drawing.Size(304, 26);
            this.txtTipoOrdenTrabajo.TabIndex = 194;
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(326, 111);
            this.txtClasificacion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClasificacion.Properties.Appearance.Options.UseFont = true;
            this.txtClasificacion.Properties.ReadOnly = true;
            this.txtClasificacion.Properties.UseReadOnlyAppearance = false;
            this.txtClasificacion.Size = new System.Drawing.Size(500, 26);
            this.txtClasificacion.TabIndex = 193;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 90);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 17);
            this.labelControl4.TabIndex = 191;
            this.labelControl4.Text = "Tipo de Trabajo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 11);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(138, 20);
            this.labelControl3.TabIndex = 190;
            this.labelControl3.Text = "Resumen de Ingreso";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(326, 90);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(177, 17);
            this.labelControl10.TabIndex = 189;
            this.labelControl10.Text = "Clasificación del Instrumento:";
            // 
            // gcProductosPresupuesto
            // 
            this.gcProductosPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProductosPresupuesto.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcProductosPresupuesto.Location = new System.Drawing.Point(15, 93);
            this.gcProductosPresupuesto.MainView = this.gvProductosPresupuesto;
            this.gcProductosPresupuesto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcProductosPresupuesto.Name = "gcProductosPresupuesto";
            this.gcProductosPresupuesto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEliminar,
            this.txtCantidad,
            this.leMonedas,
            this.txtPrecio});
            this.gcProductosPresupuesto.Size = new System.Drawing.Size(955, 357);
            this.gcProductosPresupuesto.TabIndex = 202;
            this.gcProductosPresupuesto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductosPresupuesto});
            // 
            // gvProductosPresupuesto
            // 
            this.gvProductosPresupuesto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoProducto,
            this.colDescripcion,
            this.colCantidad,
            this.colPrecio,
            this.colTotal,
            this.colEliminar});
            this.gvProductosPresupuesto.GridControl = this.gcProductosPresupuesto;
            this.gvProductosPresupuesto.Name = "gvProductosPresupuesto";
            this.gvProductosPresupuesto.OptionsView.ShowGroupPanel = false;
            this.gvProductosPresupuesto.OptionsView.ShowIndicator = false;
            // 
            // colCodigoProducto
            // 
            this.colCodigoProducto.Caption = "Código";
            this.colCodigoProducto.FieldName = "RecID";
            this.colCodigoProducto.MinWidth = 24;
            this.colCodigoProducto.Name = "colCodigoProducto";
            this.colCodigoProducto.OptionsColumn.AllowEdit = false;
            this.colCodigoProducto.OptionsColumn.AllowFocus = false;
            this.colCodigoProducto.Width = 132;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.MinWidth = 24;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowFocus = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 280;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceCell.Options.UseTextOptions = true;
            this.colCantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.ColumnEdit = this.txtCantidad;
            this.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.MinWidth = 24;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.UnboundDataType = typeof(decimal);
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 1;
            this.colCantidad.Width = 90;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoHeight = false;
            this.txtCantidad.Name = "txtCantidad";
            // 
            // colPrecio
            // 
            this.colPrecio.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPrecio.Caption = "Precio";
            this.colPrecio.ColumnEdit = this.txtPrecio;
            this.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.MinWidth = 24;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.UnboundDataType = typeof(decimal);
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 2;
            this.colPrecio.Width = 120;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoHeight = false;
            this.txtPrecio.Name = "txtPrecio";
            // 
            // colTotal
            // 
            this.colTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.MinWidth = 24;
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.OptionsColumn.AllowFocus = false;
            this.colTotal.UnboundDataType = typeof(decimal);
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 3;
            this.colTotal.Width = 150;
            // 
            // colEliminar
            // 
            this.colEliminar.ColumnEdit = this.btnEliminar;
            this.colEliminar.MinWidth = 24;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 4;
            this.colEliminar.Width = 30;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // leMonedas
            // 
            this.leMonedas.AutoHeight = false;
            this.leMonedas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leMonedas.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción")});
            this.leMonedas.Name = "leMonedas";
            this.leMonedas.NullText = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl10);
            this.panel1.Controls.Add(this.txtContactoACargo);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl14);
            this.panel1.Controls.Add(this.txtClasificacion);
            this.panel1.Controls.Add(this.txtNumeroServicioTecnico);
            this.panel1.Controls.Add(this.txtTipoOrdenTrabajo);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl13);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 150);
            this.panel1.TabIndex = 203;
            // 
            // pnlProductosPresupuesto
            // 
            this.pnlProductosPresupuesto.Controls.Add(this.gcProductosPresupuesto);
            this.pnlProductosPresupuesto.Controls.Add(this.panel6);
            this.pnlProductosPresupuesto.Controls.Add(this.panel3);
            this.pnlProductosPresupuesto.Controls.Add(this.panel5);
            this.pnlProductosPresupuesto.Controls.Add(this.panel2);
            this.pnlProductosPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductosPresupuesto.Location = new System.Drawing.Point(0, 150);
            this.pnlProductosPresupuesto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlProductosPresupuesto.Name = "pnlProductosPresupuesto";
            this.pnlProductosPresupuesto.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.pnlProductosPresupuesto.Size = new System.Drawing.Size(985, 542);
            this.pnlProductosPresupuesto.TabIndex = 204;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelControl1);
            this.panel6.Controls.Add(this.lookupMonedas);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(15, 47);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(955, 46);
            this.panel6.TabIndex = 207;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 20);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 17);
            this.labelControl1.TabIndex = 197;
            this.labelControl1.Text = "Moneda:";
            // 
            // lookupMonedas
            // 
            this.lookupMonedas.Location = new System.Drawing.Point(64, 15);
            this.lookupMonedas.Name = "lookupMonedas";
            this.lookupMonedas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupMonedas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción")});
            this.lookupMonedas.Properties.NullText = "";
            this.lookupMonedas.Size = new System.Drawing.Size(224, 22);
            this.lookupMonedas.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSummary);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(15, 450);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 27);
            this.panel3.TabIndex = 203;
            // 
            // lblSummary
            // 
            this.lblSummary.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSummary.Appearance.Options.UseFont = true;
            this.lblSummary.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSummary.Location = new System.Drawing.Point(946, 0);
            this.lblSummary.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(9, 23);
            this.lblSummary.TabIndex = 28;
            this.lblSummary.Text = "0";
            this.lblSummary.Visible = false;
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
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnGuardar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(15, 477);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panel5.Size = new System.Drawing.Size(955, 65);
            this.panel5.TabIndex = 206;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(714, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(241, 59);
            this.btnGuardar.TabIndex = 128;
            this.btnGuardar.Text = "Crear Presupuesto";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregarProductosDesdeArchivoMaestro);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnAgregarDesdeHistorialPresupuesto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(15, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel2.Size = new System.Drawing.Size(955, 47);
            this.panel2.TabIndex = 205;
            // 
            // btnAgregarProductosDesdeArchivoMaestro
            // 
            this.btnAgregarProductosDesdeArchivoMaestro.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarProductosDesdeArchivoMaestro.FlatAppearance.BorderSize = 0;
            this.btnAgregarProductosDesdeArchivoMaestro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductosDesdeArchivoMaestro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarProductosDesdeArchivoMaestro.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarProductosDesdeArchivoMaestro.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProductosDesdeArchivoMaestro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProductosDesdeArchivoMaestro.IconSize = 30;
            this.btnAgregarProductosDesdeArchivoMaestro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProductosDesdeArchivoMaestro.Location = new System.Drawing.Point(487, 0);
            this.btnAgregarProductosDesdeArchivoMaestro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarProductosDesdeArchivoMaestro.Name = "btnAgregarProductosDesdeArchivoMaestro";
            this.btnAgregarProductosDesdeArchivoMaestro.Size = new System.Drawing.Size(399, 37);
            this.btnAgregarProductosDesdeArchivoMaestro.TabIndex = 205;
            this.btnAgregarProductosDesdeArchivoMaestro.Text = "Agregar productos desde archivo maestro";
            this.btnAgregarProductosDesdeArchivoMaestro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProductosDesdeArchivoMaestro.UseVisualStyleBackColor = true;
            this.btnAgregarProductosDesdeArchivoMaestro.Click += new System.EventHandler(this.btnAgregarProductosDesdeArchivoMaestro_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(463, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 37);
            this.panel4.TabIndex = 206;
            // 
            // btnAgregarDesdeHistorialPresupuesto
            // 
            this.btnAgregarDesdeHistorialPresupuesto.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarDesdeHistorialPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnAgregarDesdeHistorialPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDesdeHistorialPresupuesto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarDesdeHistorialPresupuesto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarDesdeHistorialPresupuesto.IconColor = System.Drawing.Color.Black;
            this.btnAgregarDesdeHistorialPresupuesto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarDesdeHistorialPresupuesto.IconSize = 30;
            this.btnAgregarDesdeHistorialPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDesdeHistorialPresupuesto.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarDesdeHistorialPresupuesto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarDesdeHistorialPresupuesto.Name = "btnAgregarDesdeHistorialPresupuesto";
            this.btnAgregarDesdeHistorialPresupuesto.Size = new System.Drawing.Size(463, 37);
            this.btnAgregarDesdeHistorialPresupuesto.TabIndex = 204;
            this.btnAgregarDesdeHistorialPresupuesto.Text = "Agregar productos desde historial de presupuestos";
            this.btnAgregarDesdeHistorialPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarDesdeHistorialPresupuesto.UseVisualStyleBackColor = true;
            this.btnAgregarDesdeHistorialPresupuesto.Click += new System.EventHandler(this.btnAgregarDesdeHistorialPresupuesto_Click);
            // 
            // frmCrearPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 692);
            this.Controls.Add(this.pnlProductosPresupuesto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmCrearPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Presupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.txtContactoACargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroServicioTecnico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoOrdenTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClasificacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductosPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductosPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leMonedas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlProductosPresupuesto.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonedas.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtContactoACargo;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtNumeroServicioTecnico;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtTipoOrdenTrabajo;
        private DevExpress.XtraEditors.TextEdit txtClasificacion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraGrid.GridControl gcProductosPresupuesto;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductosPresupuesto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlProductosPresupuesto;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEliminar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAgregarProductosDesdeArchivoMaestro;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnAgregarDesdeHistorialPresupuesto;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCantidad;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leMonedas;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPrecio;
        private DevExpress.XtraEditors.LabelControl lblSummary;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookupMonedas;
    }
}