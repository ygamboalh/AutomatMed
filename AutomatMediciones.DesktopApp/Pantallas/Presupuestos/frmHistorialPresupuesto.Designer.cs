namespace AutomatMediciones.DesktopApp.Pantallas.Presupuestos
{
    partial class frmHistorialPresupuesto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.btnFiltroModelo = new FontAwesome.Sharp.IconButton();
            this.btnFiltroPorCliente = new FontAwesome.Sharp.IconButton();
            this.btnFiltroPorInstrumento = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcHistorialPresupuesto = new DevExpress.XtraGrid.GridControl();
            this.gvHistorialPresupuesto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPresupuestoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresupuestoDetalleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCotizacionMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstrumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalSeleccionados = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAgregarProductosSeleccionados = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesde.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHistorialPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistorialPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateHasta);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.dateDesde);
            this.panel1.Controls.Add(this.labelControl13);
            this.panel1.Controls.Add(this.btnFiltroModelo);
            this.panel1.Controls.Add(this.btnFiltroPorCliente);
            this.panel1.Controls.Add(this.btnFiltroPorInstrumento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 111);
            this.panel1.TabIndex = 0;
            // 
            // dateHasta
            // 
            this.dateHasta.EditValue = null;
            this.dateHasta.Location = new System.Drawing.Point(120, 56);
            this.dateHasta.Margin = new System.Windows.Forms.Padding(5);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHasta.Size = new System.Drawing.Size(267, 40);
            this.dateHasta.TabIndex = 200;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(33, 64);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 30);
            this.labelControl1.TabIndex = 199;
            this.labelControl1.Text = "Hasta:";
            // 
            // dateDesde
            // 
            this.dateDesde.EditValue = null;
            this.dateDesde.Location = new System.Drawing.Point(120, 12);
            this.dateDesde.Margin = new System.Windows.Forms.Padding(5);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDesde.Size = new System.Drawing.Size(267, 40);
            this.dateDesde.TabIndex = 198;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(33, 20);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(64, 30);
            this.labelControl13.TabIndex = 197;
            this.labelControl13.Text = "Desde:";
            // 
            // btnFiltroModelo
            // 
            this.btnFiltroModelo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltroModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroModelo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltroModelo.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFiltroModelo.IconColor = System.Drawing.Color.Black;
            this.btnFiltroModelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltroModelo.IconSize = 20;
            this.btnFiltroModelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroModelo.Location = new System.Drawing.Point(953, 17);
            this.btnFiltroModelo.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.btnFiltroModelo.Name = "btnFiltroModelo";
            this.btnFiltroModelo.Size = new System.Drawing.Size(254, 73);
            this.btnFiltroModelo.TabIndex = 161;
            this.btnFiltroModelo.Text = "Modelo";
            this.btnFiltroModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltroModelo.UseVisualStyleBackColor = true;
            this.btnFiltroModelo.Click += new System.EventHandler(this.btnFiltroModelo_Click);
            // 
            // btnFiltroPorCliente
            // 
            this.btnFiltroPorCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltroPorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroPorCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltroPorCliente.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFiltroPorCliente.IconColor = System.Drawing.Color.Black;
            this.btnFiltroPorCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltroPorCliente.IconSize = 20;
            this.btnFiltroPorCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroPorCliente.Location = new System.Drawing.Point(687, 17);
            this.btnFiltroPorCliente.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.btnFiltroPorCliente.Name = "btnFiltroPorCliente";
            this.btnFiltroPorCliente.Size = new System.Drawing.Size(254, 73);
            this.btnFiltroPorCliente.TabIndex = 160;
            this.btnFiltroPorCliente.Text = "Cliente";
            this.btnFiltroPorCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltroPorCliente.UseVisualStyleBackColor = true;
            this.btnFiltroPorCliente.Click += new System.EventHandler(this.btnFiltroPorCliente_Click);
            // 
            // btnFiltroPorInstrumento
            // 
            this.btnFiltroPorInstrumento.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltroPorInstrumento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltroPorInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroPorInstrumento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltroPorInstrumento.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFiltroPorInstrumento.IconColor = System.Drawing.Color.Black;
            this.btnFiltroPorInstrumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltroPorInstrumento.IconSize = 20;
            this.btnFiltroPorInstrumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroPorInstrumento.Location = new System.Drawing.Point(422, 17);
            this.btnFiltroPorInstrumento.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.btnFiltroPorInstrumento.Name = "btnFiltroPorInstrumento";
            this.btnFiltroPorInstrumento.Size = new System.Drawing.Size(254, 73);
            this.btnFiltroPorInstrumento.TabIndex = 159;
            this.btnFiltroPorInstrumento.Text = "Instrumento";
            this.btnFiltroPorInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltroPorInstrumento.UseVisualStyleBackColor = false;
            this.btnFiltroPorInstrumento.Click += new System.EventHandler(this.btnFiltroPorInstrumento_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcHistorialPresupuesto);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(21, 0, 21, 9);
            this.panel2.Size = new System.Drawing.Size(1450, 705);
            this.panel2.TabIndex = 1;
            // 
            // gcHistorialPresupuesto
            // 
            this.gcHistorialPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHistorialPresupuesto.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gcHistorialPresupuesto.Location = new System.Drawing.Point(21, 0);
            this.gcHistorialPresupuesto.MainView = this.gvHistorialPresupuesto;
            this.gcHistorialPresupuesto.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gcHistorialPresupuesto.Name = "gcHistorialPresupuesto";
            this.gcHistorialPresupuesto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSeleccionar});
            this.gcHistorialPresupuesto.Size = new System.Drawing.Size(1408, 570);
            this.gcHistorialPresupuesto.TabIndex = 0;
            this.gcHistorialPresupuesto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHistorialPresupuesto});
            // 
            // gvHistorialPresupuesto
            // 
            this.gvHistorialPresupuesto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPresupuestoId,
            this.colPresupuestoDetalleId,
            this.colDescripcionProducto,
            this.colProductoId,
            this.colMoneda,
            this.colIdCotizacionMoneda,
            this.colPrecio,
            this.colCantidad,
            this.colCliente,
            this.colModelo,
            this.colInstrumento,
            this.colSeleccionar});
            this.gvHistorialPresupuesto.DetailHeight = 673;
            this.gvHistorialPresupuesto.GridControl = this.gcHistorialPresupuesto;
            this.gvHistorialPresupuesto.Name = "gvHistorialPresupuesto";
            this.gvHistorialPresupuesto.OptionsView.ShowGroupPanel = false;
            this.gvHistorialPresupuesto.OptionsView.ShowIndicator = false;
            // 
            // colPresupuestoId
            // 
            this.colPresupuestoId.Caption = "PresupuestoId";
            this.colPresupuestoId.FieldName = "PresupuestoId";
            this.colPresupuestoId.MinWidth = 43;
            this.colPresupuestoId.Name = "colPresupuestoId";
            this.colPresupuestoId.OptionsColumn.AllowEdit = false;
            this.colPresupuestoId.OptionsColumn.AllowFocus = false;
            this.colPresupuestoId.Width = 161;
            // 
            // colPresupuestoDetalleId
            // 
            this.colPresupuestoDetalleId.Caption = "Presupuesto Detalle Id";
            this.colPresupuestoDetalleId.FieldName = "PresupuestoDetalleId";
            this.colPresupuestoDetalleId.MinWidth = 43;
            this.colPresupuestoDetalleId.Name = "colPresupuestoDetalleId";
            this.colPresupuestoDetalleId.OptionsColumn.AllowEdit = false;
            this.colPresupuestoDetalleId.OptionsColumn.AllowFocus = false;
            this.colPresupuestoDetalleId.Width = 161;
            // 
            // colDescripcionProducto
            // 
            this.colDescripcionProducto.Caption = "Descripción";
            this.colDescripcionProducto.FieldName = "DescripcionProducto";
            this.colDescripcionProducto.MinWidth = 43;
            this.colDescripcionProducto.Name = "colDescripcionProducto";
            this.colDescripcionProducto.Visible = true;
            this.colDescripcionProducto.VisibleIndex = 3;
            this.colDescripcionProducto.Width = 194;
            // 
            // colProductoId
            // 
            this.colProductoId.Caption = "Producto Id";
            this.colProductoId.FieldName = "ProductoId";
            this.colProductoId.MinWidth = 43;
            this.colProductoId.Name = "colProductoId";
            this.colProductoId.OptionsColumn.AllowEdit = false;
            this.colProductoId.OptionsColumn.AllowFocus = false;
            this.colProductoId.Width = 161;
            // 
            // colMoneda
            // 
            this.colMoneda.Caption = "Moneda";
            this.colMoneda.FieldName = "Moneda";
            this.colMoneda.MinWidth = 43;
            this.colMoneda.Name = "colMoneda";
            this.colMoneda.OptionsColumn.AllowEdit = false;
            this.colMoneda.OptionsColumn.AllowFocus = false;
            this.colMoneda.Visible = true;
            this.colMoneda.VisibleIndex = 4;
            this.colMoneda.Width = 194;
            // 
            // colIdCotizacionMoneda
            // 
            this.colIdCotizacionMoneda.Caption = "Id Cotizacion Moneda";
            this.colIdCotizacionMoneda.FieldName = "IdCotizacionMoneda";
            this.colIdCotizacionMoneda.MinWidth = 43;
            this.colIdCotizacionMoneda.Name = "colIdCotizacionMoneda";
            this.colIdCotizacionMoneda.OptionsColumn.AllowEdit = false;
            this.colIdCotizacionMoneda.OptionsColumn.AllowFocus = false;
            this.colIdCotizacionMoneda.Width = 161;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio";
            this.colPrecio.DisplayFormat.FormatString = "{0:#,##0.##}";
            this.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.MinWidth = 43;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 5;
            this.colPrecio.Width = 158;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.MinWidth = 43;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.OptionsColumn.AllowFocus = false;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 6;
            this.colCantidad.Width = 123;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente";
            this.colCliente.MinWidth = 43;
            this.colCliente.Name = "colCliente";
            this.colCliente.OptionsColumn.AllowEdit = false;
            this.colCliente.OptionsColumn.AllowFocus = false;
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 0;
            this.colCliente.Width = 194;
            // 
            // colModelo
            // 
            this.colModelo.Caption = "Modelo";
            this.colModelo.FieldName = "Modelo";
            this.colModelo.MinWidth = 43;
            this.colModelo.Name = "colModelo";
            this.colModelo.OptionsColumn.AllowEdit = false;
            this.colModelo.OptionsColumn.AllowFocus = false;
            this.colModelo.Visible = true;
            this.colModelo.VisibleIndex = 1;
            this.colModelo.Width = 194;
            // 
            // colInstrumento
            // 
            this.colInstrumento.Caption = "Instrumento";
            this.colInstrumento.FieldName = "Instrumento";
            this.colInstrumento.MinWidth = 43;
            this.colInstrumento.Name = "colInstrumento";
            this.colInstrumento.OptionsColumn.AllowEdit = false;
            this.colInstrumento.OptionsColumn.AllowFocus = false;
            this.colInstrumento.Visible = true;
            this.colInstrumento.VisibleIndex = 2;
            this.colInstrumento.Width = 194;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.ColumnEdit = this.chkSeleccionar;
            this.colSeleccionar.FieldName = "Seleccionar";
            this.colSeleccionar.MinWidth = 43;
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Visible = true;
            this.colSeleccionar.VisibleIndex = 7;
            this.colSeleccionar.Width = 51;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoHeight = false;
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotalSeleccionados);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(21, 570);
            this.panel3.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1408, 42);
            this.panel3.TabIndex = 208;
            // 
            // lblTotalSeleccionados
            // 
            this.lblTotalSeleccionados.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalSeleccionados.Appearance.Options.UseFont = true;
            this.lblTotalSeleccionados.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalSeleccionados.Location = new System.Drawing.Point(1379, 0);
            this.lblTotalSeleccionados.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.lblTotalSeleccionados.Name = "lblTotalSeleccionados";
            this.lblTotalSeleccionados.Padding = new System.Windows.Forms.Padding(0, 0, 17, 0);
            this.lblTotalSeleccionados.Size = new System.Drawing.Size(29, 30);
            this.lblTotalSeleccionados.TabIndex = 29;
            this.lblTotalSeleccionados.Text = "0";
            this.lblTotalSeleccionados.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(12, 30);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAgregarProductosSeleccionados);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(21, 612);
            this.panel5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.panel5.Size = new System.Drawing.Size(1408, 84);
            this.panel5.TabIndex = 207;
            // 
            // btnAgregarProductosSeleccionados
            // 
            this.btnAgregarProductosSeleccionados.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregarProductosSeleccionados.FlatAppearance.BorderSize = 0;
            this.btnAgregarProductosSeleccionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductosSeleccionados.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarProductosSeleccionados.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAgregarProductosSeleccionados.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProductosSeleccionados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProductosSeleccionados.IconSize = 30;
            this.btnAgregarProductosSeleccionados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProductosSeleccionados.Location = new System.Drawing.Point(858, 0);
            this.btnAgregarProductosSeleccionados.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.btnAgregarProductosSeleccionados.Name = "btnAgregarProductosSeleccionados";
            this.btnAgregarProductosSeleccionados.Size = new System.Drawing.Size(550, 75);
            this.btnAgregarProductosSeleccionados.TabIndex = 128;
            this.btnAgregarProductosSeleccionados.Text = "Agregar Productos Seleccionados";
            this.btnAgregarProductosSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProductosSeleccionados.UseVisualStyleBackColor = true;
            this.btnAgregarProductosSeleccionados.Click += new System.EventHandler(this.btnAgregarProductosSeleccionados_Click);
            // 
            // frmHistorialPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 816);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmHistorialPresupuesto";
            this.Text = "Historial de Presupuesto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesde.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHistorialPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistorialPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnFiltroModelo;
        private FontAwesome.Sharp.IconButton btnFiltroPorCliente;
        private FontAwesome.Sharp.IconButton btnFiltroPorInstrumento;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gcHistorialPresupuesto;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHistorialPresupuesto;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnAgregarProductosSeleccionados;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.DateEdit dateHasta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateDesde;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSeleccionar;
        private DevExpress.XtraEditors.LabelControl lblTotalSeleccionados;
        private DevExpress.XtraGrid.Columns.GridColumn colPresupuestoId;
        private DevExpress.XtraGrid.Columns.GridColumn colPresupuestoDetalleId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoId;
        private DevExpress.XtraGrid.Columns.GridColumn colMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCotizacionMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
    }
}