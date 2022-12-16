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
            this.colCodigoPresupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstrumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClasificacion = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 71);
            this.panel1.TabIndex = 0;
            // 
            // dateHasta
            // 
            this.dateHasta.EditValue = null;
            this.dateHasta.Location = new System.Drawing.Point(70, 36);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHasta.Size = new System.Drawing.Size(156, 22);
            this.dateHasta.TabIndex = 200;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 41);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 17);
            this.labelControl1.TabIndex = 199;
            this.labelControl1.Text = "Hasta:";
            // 
            // dateDesde
            // 
            this.dateDesde.EditValue = null;
            this.dateDesde.Location = new System.Drawing.Point(70, 8);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDesde.Size = new System.Drawing.Size(156, 22);
            this.dateDesde.TabIndex = 198;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(19, 13);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(40, 17);
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
            this.btnFiltroModelo.Location = new System.Drawing.Point(556, 11);
            this.btnFiltroModelo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFiltroModelo.Name = "btnFiltroModelo";
            this.btnFiltroModelo.Size = new System.Drawing.Size(148, 47);
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
            this.btnFiltroPorCliente.Location = new System.Drawing.Point(401, 11);
            this.btnFiltroPorCliente.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFiltroPorCliente.Name = "btnFiltroPorCliente";
            this.btnFiltroPorCliente.Size = new System.Drawing.Size(148, 47);
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
            this.btnFiltroPorInstrumento.Location = new System.Drawing.Point(246, 11);
            this.btnFiltroPorInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFiltroPorInstrumento.Name = "btnFiltroPorInstrumento";
            this.btnFiltroPorInstrumento.Size = new System.Drawing.Size(148, 47);
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
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(12, 0, 12, 6);
            this.panel2.Size = new System.Drawing.Size(846, 451);
            this.panel2.TabIndex = 1;
            // 
            // gcHistorialPresupuesto
            // 
            this.gcHistorialPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHistorialPresupuesto.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcHistorialPresupuesto.Location = new System.Drawing.Point(12, 0);
            this.gcHistorialPresupuesto.MainView = this.gvHistorialPresupuesto;
            this.gcHistorialPresupuesto.Margin = new System.Windows.Forms.Padding(4);
            this.gcHistorialPresupuesto.Name = "gcHistorialPresupuesto";
            this.gcHistorialPresupuesto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSeleccionar});
            this.gcHistorialPresupuesto.Size = new System.Drawing.Size(822, 364);
            this.gcHistorialPresupuesto.TabIndex = 0;
            this.gcHistorialPresupuesto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHistorialPresupuesto});
            // 
            // gvHistorialPresupuesto
            // 
            this.gvHistorialPresupuesto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoPresupuesto,
            this.colFechaRegistro,
            this.colDescripcion,
            this.colCantidad,
            this.colPrecio,
            this.colModelo,
            this.colInstrumento,
            this.colCliente,
            this.colClasificacion,
            this.colSeleccionar});
            this.gvHistorialPresupuesto.DetailHeight = 431;
            this.gvHistorialPresupuesto.GridControl = this.gcHistorialPresupuesto;
            this.gvHistorialPresupuesto.Name = "gvHistorialPresupuesto";
            this.gvHistorialPresupuesto.OptionsView.ShowGroupPanel = false;
            this.gvHistorialPresupuesto.OptionsView.ShowIndicator = false;
            // 
            // colCodigoPresupuesto
            // 
            this.colCodigoPresupuesto.Caption = "Código Presupuesto";
            this.colCodigoPresupuesto.FieldName = "Id";
            this.colCodigoPresupuesto.MinWidth = 23;
            this.colCodigoPresupuesto.Name = "colCodigoPresupuesto";
            this.colCodigoPresupuesto.OptionsColumn.AllowEdit = false;
            this.colCodigoPresupuesto.OptionsColumn.AllowFocus = false;
            this.colCodigoPresupuesto.Visible = true;
            this.colCodigoPresupuesto.VisibleIndex = 0;
            this.colCodigoPresupuesto.Width = 133;
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.Caption = "Fecha";
            this.colFechaRegistro.DisplayFormat.FormatString = "dd/MM/yy";
            this.colFechaRegistro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaRegistro.FieldName = "FechaRegistro";
            this.colFechaRegistro.MinWidth = 25;
            this.colFechaRegistro.Name = "colFechaRegistro";
            this.colFechaRegistro.OptionsColumn.AllowEdit = false;
            this.colFechaRegistro.OptionsColumn.AllowFocus = false;
            this.colFechaRegistro.Visible = true;
            this.colFechaRegistro.VisibleIndex = 1;
            this.colFechaRegistro.Width = 143;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.MinWidth = 23;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowFocus = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            this.colDescripcion.Width = 133;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.MinWidth = 23;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.OptionsColumn.AllowFocus = false;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            this.colCantidad.Width = 133;
            // 
            // colPrecio
            // 
            this.colPrecio.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPrecio.Caption = "Precio";
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.MinWidth = 23;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.OptionsColumn.AllowEdit = false;
            this.colPrecio.OptionsColumn.AllowFocus = false;
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 4;
            this.colPrecio.Width = 133;
            // 
            // colModelo
            // 
            this.colModelo.Caption = "Modelo";
            this.colModelo.FieldName = "Modelo.Descripcion";
            this.colModelo.MinWidth = 25;
            this.colModelo.Name = "colModelo";
            this.colModelo.OptionsColumn.AllowEdit = false;
            this.colModelo.OptionsColumn.AllowFocus = false;
            this.colModelo.Width = 87;
            // 
            // colInstrumento
            // 
            this.colInstrumento.Caption = "Instrumento";
            this.colInstrumento.FieldName = "Instrumento.Descripcion";
            this.colInstrumento.MinWidth = 25;
            this.colInstrumento.Name = "colInstrumento";
            this.colInstrumento.OptionsColumn.AllowEdit = false;
            this.colInstrumento.OptionsColumn.AllowFocus = false;
            this.colInstrumento.Width = 87;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "NombreCliente";
            this.colCliente.MinWidth = 25;
            this.colCliente.Name = "colCliente";
            this.colCliente.OptionsColumn.AllowEdit = false;
            this.colCliente.OptionsColumn.AllowFocus = false;
            this.colCliente.Width = 87;
            // 
            // colClasificacion
            // 
            this.colClasificacion.Caption = "Clasificación";
            this.colClasificacion.FieldName = "Clasificacion.ClasificacionConcatenada";
            this.colClasificacion.MinWidth = 25;
            this.colClasificacion.Name = "colClasificacion";
            this.colClasificacion.Width = 94;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Caption = " ";
            this.colSeleccionar.ColumnEdit = this.chkSeleccionar;
            this.colSeleccionar.FieldName = "Seleccionar";
            this.colSeleccionar.MinWidth = 25;
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Visible = true;
            this.colSeleccionar.VisibleIndex = 5;
            this.colSeleccionar.Width = 30;
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
            this.panel3.Location = new System.Drawing.Point(12, 364);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 27);
            this.panel3.TabIndex = 208;
            // 
            // lblTotalSeleccionados
            // 
            this.lblTotalSeleccionados.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalSeleccionados.Appearance.Options.UseFont = true;
            this.lblTotalSeleccionados.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalSeleccionados.Location = new System.Drawing.Point(805, 0);
            this.lblTotalSeleccionados.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lblTotalSeleccionados.Name = "lblTotalSeleccionados";
            this.lblTotalSeleccionados.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblTotalSeleccionados.Size = new System.Drawing.Size(17, 17);
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
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(7, 17);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAgregarProductosSeleccionados);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(12, 391);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panel5.Size = new System.Drawing.Size(822, 54);
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
            this.btnAgregarProductosSeleccionados.Location = new System.Drawing.Point(501, 0);
            this.btnAgregarProductosSeleccionados.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarProductosSeleccionados.Name = "btnAgregarProductosSeleccionados";
            this.btnAgregarProductosSeleccionados.Size = new System.Drawing.Size(321, 48);
            this.btnAgregarProductosSeleccionados.TabIndex = 128;
            this.btnAgregarProductosSeleccionados.Text = "Agregar Productos Seleccionados";
            this.btnAgregarProductosSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProductosSeleccionados.UseVisualStyleBackColor = true;
            this.btnAgregarProductosSeleccionados.Click += new System.EventHandler(this.btnAgregarProductosSeleccionados_Click);
            // 
            // frmHistorialPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoPresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraEditors.DateEdit dateHasta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateDesde;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colClasificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSeleccionar;
        private DevExpress.XtraEditors.LabelControl lblTotalSeleccionados;
    }
}