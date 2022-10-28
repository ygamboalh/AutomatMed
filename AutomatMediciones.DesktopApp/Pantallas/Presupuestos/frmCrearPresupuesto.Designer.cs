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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearPresupuesto));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlProductosPresupuesto = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlProductosPresupuesto.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContactoACargo
            // 
            this.txtContactoACargo.Location = new System.Drawing.Point(279, 47);
            this.txtContactoACargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContactoACargo.Name = "txtContactoACargo";
            this.txtContactoACargo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContactoACargo.Properties.Appearance.Options.UseFont = true;
            this.txtContactoACargo.Properties.ReadOnly = true;
            this.txtContactoACargo.Properties.UseReadOnlyAppearance = false;
            this.txtContactoACargo.Size = new System.Drawing.Size(267, 22);
            this.txtContactoACargo.TabIndex = 201;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(279, 30);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(81, 12);
            this.labelControl14.TabIndex = 200;
            this.labelControl14.Text = "Contacto a cargo:";
            // 
            // txtNumeroServicioTecnico
            // 
            this.txtNumeroServicioTecnico.Location = new System.Drawing.Point(552, 47);
            this.txtNumeroServicioTecnico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroServicioTecnico.Name = "txtNumeroServicioTecnico";
            this.txtNumeroServicioTecnico.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroServicioTecnico.Properties.Appearance.Options.UseFont = true;
            this.txtNumeroServicioTecnico.Properties.ReadOnly = true;
            this.txtNumeroServicioTecnico.Properties.UseReadOnlyAppearance = false;
            this.txtNumeroServicioTecnico.Size = new System.Drawing.Size(156, 22);
            this.txtNumeroServicioTecnico.TabIndex = 199;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(552, 33);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 12);
            this.labelControl2.TabIndex = 198;
            this.labelControl2.Text = "N° Servicio Técnico:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(13, 47);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliente.Properties.Appearance.Options.UseFont = true;
            this.txtCliente.Properties.ReadOnly = true;
            this.txtCliente.Properties.UseReadOnlyAppearance = false;
            this.txtCliente.Size = new System.Drawing.Size(261, 22);
            this.txtCliente.TabIndex = 197;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(12, 33);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(34, 12);
            this.labelControl13.TabIndex = 196;
            this.labelControl13.Text = "Cliente:";
            // 
            // txtTipoOrdenTrabajo
            // 
            this.txtTipoOrdenTrabajo.Location = new System.Drawing.Point(12, 90);
            this.txtTipoOrdenTrabajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipoOrdenTrabajo.Name = "txtTipoOrdenTrabajo";
            this.txtTipoOrdenTrabajo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipoOrdenTrabajo.Properties.Appearance.Options.UseFont = true;
            this.txtTipoOrdenTrabajo.Properties.ReadOnly = true;
            this.txtTipoOrdenTrabajo.Properties.UseReadOnlyAppearance = false;
            this.txtTipoOrdenTrabajo.Size = new System.Drawing.Size(261, 22);
            this.txtTipoOrdenTrabajo.TabIndex = 194;
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(279, 90);
            this.txtClasificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClasificacion.Properties.Appearance.Options.UseFont = true;
            this.txtClasificacion.Properties.ReadOnly = true;
            this.txtClasificacion.Properties.UseReadOnlyAppearance = false;
            this.txtClasificacion.Size = new System.Drawing.Size(429, 22);
            this.txtClasificacion.TabIndex = 193;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(11, 73);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 12);
            this.labelControl4.TabIndex = 191;
            this.labelControl4.Text = "Tipo de Trabajo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(10, 9);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 15);
            this.labelControl3.TabIndex = 190;
            this.labelControl3.Text = "Resumen de Ingreso";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(279, 73);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(136, 12);
            this.labelControl10.TabIndex = 189;
            this.labelControl10.Text = "Clasificación del Instrumento:";
            // 
            // gcProductosPresupuesto
            // 
            this.gcProductosPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProductosPresupuesto.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcProductosPresupuesto.Location = new System.Drawing.Point(13, 38);
            this.gcProductosPresupuesto.MainView = this.gvProductosPresupuesto;
            this.gcProductosPresupuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcProductosPresupuesto.Name = "gcProductosPresupuesto";
            this.gcProductosPresupuesto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar});
            this.gcProductosPresupuesto.Size = new System.Drawing.Size(818, 327);
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
            this.colMoneda,
            this.colTotal,
            this.colEliminar});
            this.gvProductosPresupuesto.DetailHeight = 284;
            this.gvProductosPresupuesto.GridControl = this.gcProductosPresupuesto;
            this.gvProductosPresupuesto.Name = "gvProductosPresupuesto";
            this.gvProductosPresupuesto.OptionsView.ShowGroupPanel = false;
            this.gvProductosPresupuesto.OptionsView.ShowIndicator = false;
            // 
            // colCodigoProducto
            // 
            this.colCodigoProducto.Caption = "Código";
            this.colCodigoProducto.MinWidth = 21;
            this.colCodigoProducto.Name = "colCodigoProducto";
            this.colCodigoProducto.OptionsColumn.AllowEdit = false;
            this.colCodigoProducto.OptionsColumn.AllowFocus = false;
            this.colCodigoProducto.Visible = true;
            this.colCodigoProducto.VisibleIndex = 0;
            this.colCodigoProducto.Width = 113;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.MinWidth = 21;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowFocus = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 113;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.MinWidth = 21;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.OptionsColumn.AllowFocus = false;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            this.colCantidad.Width = 113;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio";
            this.colPrecio.MinWidth = 21;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.OptionsColumn.AllowEdit = false;
            this.colPrecio.OptionsColumn.AllowFocus = false;
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 3;
            this.colPrecio.Width = 113;
            // 
            // colMoneda
            // 
            this.colMoneda.Caption = "Moneda";
            this.colMoneda.MinWidth = 21;
            this.colMoneda.Name = "colMoneda";
            this.colMoneda.OptionsColumn.AllowEdit = false;
            this.colMoneda.OptionsColumn.AllowFocus = false;
            this.colMoneda.Visible = true;
            this.colMoneda.VisibleIndex = 4;
            this.colMoneda.Width = 113;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.MinWidth = 21;
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.OptionsColumn.AllowFocus = false;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 113;
            // 
            // colEliminar
            // 
            this.colEliminar.ColumnEdit = this.btnEditar;
            this.colEliminar.MinWidth = 21;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 6;
            this.colEliminar.Width = 26;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 122);
            this.panel1.TabIndex = 203;
            // 
            // pnlProductosPresupuesto
            // 
            this.pnlProductosPresupuesto.Controls.Add(this.gcProductosPresupuesto);
            this.pnlProductosPresupuesto.Controls.Add(this.panel3);
            this.pnlProductosPresupuesto.Controls.Add(this.panel5);
            this.pnlProductosPresupuesto.Controls.Add(this.panel2);
            this.pnlProductosPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductosPresupuesto.Location = new System.Drawing.Point(0, 122);
            this.pnlProductosPresupuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlProductosPresupuesto.Name = "pnlProductosPresupuesto";
            this.pnlProductosPresupuesto.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.pnlProductosPresupuesto.Size = new System.Drawing.Size(844, 440);
            this.pnlProductosPresupuesto.TabIndex = 204;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(13, 365);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 22);
            this.panel3.TabIndex = 203;
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(6, 12);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnGuardar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(13, 387);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel5.Size = new System.Drawing.Size(818, 53);
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
            this.btnGuardar.Location = new System.Drawing.Point(611, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(207, 48);
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
            this.panel2.Location = new System.Drawing.Point(13, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 38);
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
            this.btnAgregarProductosDesdeArchivoMaestro.Location = new System.Drawing.Point(418, 0);
            this.btnAgregarProductosDesdeArchivoMaestro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProductosDesdeArchivoMaestro.Name = "btnAgregarProductosDesdeArchivoMaestro";
            this.btnAgregarProductosDesdeArchivoMaestro.Size = new System.Drawing.Size(342, 38);
            this.btnAgregarProductosDesdeArchivoMaestro.TabIndex = 205;
            this.btnAgregarProductosDesdeArchivoMaestro.Text = "Agregar productos desde archivo maestro";
            this.btnAgregarProductosDesdeArchivoMaestro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProductosDesdeArchivoMaestro.UseVisualStyleBackColor = true;
            this.btnAgregarProductosDesdeArchivoMaestro.Click += new System.EventHandler(this.btnAgregarProductosDesdeArchivoMaestro_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(397, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 38);
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
            this.btnAgregarDesdeHistorialPresupuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarDesdeHistorialPresupuesto.Name = "btnAgregarDesdeHistorialPresupuesto";
            this.btnAgregarDesdeHistorialPresupuesto.Size = new System.Drawing.Size(397, 38);
            this.btnAgregarDesdeHistorialPresupuesto.TabIndex = 204;
            this.btnAgregarDesdeHistorialPresupuesto.Text = "Agregar productos desde historial de presupuestos";
            this.btnAgregarDesdeHistorialPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarDesdeHistorialPresupuesto.UseVisualStyleBackColor = true;
            this.btnAgregarDesdeHistorialPresupuesto.Click += new System.EventHandler(this.btnAgregarDesdeHistorialPresupuesto_Click);
            // 
            // frmCrearPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 562);
            this.Controls.Add(this.pnlProductosPresupuesto);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCrearPresupuesto";
            this.Text = "Nuevo Presupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.txtContactoACargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroServicioTecnico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoOrdenTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClasificacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductosPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductosPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlProductosPresupuesto.ResumeLayout(false);
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
        private DevExpress.XtraGrid.Columns.GridColumn colMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAgregarProductosDesdeArchivoMaestro;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnAgregarDesdeHistorialPresupuesto;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnGuardar;
    }
}