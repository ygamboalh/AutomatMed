﻿
namespace TacticaReparaciones.DesktopApp.Pantallas
{
    partial class frmIngresos
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
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel4 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel5 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.glCorreoElectronico = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glCorreo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRegistroId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscarEmpresa = new FontAwesome.Sharp.IconButton();
            this.glContacto = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glContactos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtEmpresa = new DevExpress.XtraEditors.TextEdit();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ctlEncabezadoPantalla1 = new TacticaReparaciones.DesktopApp.Componentes.Encabezados.ctlEncabezadoPantalla();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregarNuevInstrumento = new FontAwesome.Sharp.IconButton();
            this.gcInstrumentosDeEmpresa = new DevExpress.XtraGrid.GridControl();
            this.gvInstrumentosDeEmpresa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSeleccionarInstrumento = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardarIngreso = new FontAwesome.Sharp.IconButton();
            this.memoComentarios = new DevExpress.XtraEditors.MemoEdit();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.glTiposTrabajo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glTipoTrabajo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTotalInstrumentos = new DevExpress.XtraEditors.LabelControl();
            this.lblInstrumentosSeleccionados = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.glCorreoElectronico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstrumentosDeEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstrumentosDeEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionarInstrumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTiposTrabajo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoTrabajo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(46, 49);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 12);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nombre de Empresa:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(46, 101);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 12);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Nombre de Contacto:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(46, 145);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 12);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Correo Electrónico:";
            // 
            // glCorreoElectronico
            // 
            this.glCorreoElectronico.Location = new System.Drawing.Point(46, 164);
            this.glCorreoElectronico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glCorreoElectronico.Name = "glCorreoElectronico";
            this.glCorreoElectronico.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glCorreoElectronico.Properties.Appearance.Options.UseFont = true;
            this.glCorreoElectronico.Properties.NullText = "";
            this.glCorreoElectronico.Properties.PopupView = this.glCorreo;
            this.glCorreoElectronico.Size = new System.Drawing.Size(360, 22);
            this.glCorreoElectronico.TabIndex = 5;
            this.glCorreoElectronico.EditValueChanged += new System.EventHandler(this.glCorreoElectronico_EditValueChanged);
            // 
            // glCorreo
            // 
            this.glCorreo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRegistroId,
            this.colDireccion});
            this.glCorreo.DetailHeight = 284;
            this.glCorreo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glCorreo.Name = "glCorreo";
            this.glCorreo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glCorreo.OptionsView.ShowGroupPanel = false;
            this.glCorreo.OptionsView.ShowIndicator = false;
            // 
            // colRegistroId
            // 
            this.colRegistroId.Caption = "Id";
            this.colRegistroId.FieldName = "RegistroId";
            this.colRegistroId.MinWidth = 17;
            this.colRegistroId.Name = "colRegistroId";
            this.colRegistroId.OptionsColumn.AllowEdit = false;
            this.colRegistroId.OptionsColumn.ReadOnly = true;
            this.colRegistroId.Width = 64;
            // 
            // colDireccion
            // 
            this.colDireccion.Caption = "Correo";
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.MinWidth = 17;
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.OptionsColumn.AllowEdit = false;
            this.colDireccion.OptionsColumn.ReadOnly = true;
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 0;
            this.colDireccion.Width = 64;
            // 
            // btnBuscarEmpresa
            // 
            this.btnBuscarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpresa.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarEmpresa.IconColor = System.Drawing.Color.Black;
            this.btnBuscarEmpresa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarEmpresa.IconSize = 30;
            this.btnBuscarEmpresa.Location = new System.Drawing.Point(681, 67);
            this.btnBuscarEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarEmpresa.Name = "btnBuscarEmpresa";
            this.btnBuscarEmpresa.Size = new System.Drawing.Size(37, 26);
            this.btnBuscarEmpresa.TabIndex = 7;
            this.btnBuscarEmpresa.UseVisualStyleBackColor = true;
            this.btnBuscarEmpresa.Click += new System.EventHandler(this.btnBuscarEmpresa_Click);
            this.btnBuscarEmpresa.MouseHover += new System.EventHandler(this.iconButton1_MouseHover);
            // 
            // glContacto
            // 
            this.glContacto.EditValue = "";
            this.glContacto.Location = new System.Drawing.Point(46, 119);
            this.glContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glContacto.Name = "glContacto";
            this.glContacto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glContacto.Properties.Appearance.Options.UseFont = true;
            this.glContacto.Properties.NullText = "";
            this.glContacto.Properties.PopupView = this.glContactos;
            this.glContacto.Properties.EditValueChanged += new System.EventHandler(this.glContacto_Properties_EditValueChanged);
            this.glContacto.Size = new System.Drawing.Size(627, 22);
            this.glContacto.TabIndex = 8;
            // 
            // glContactos
            // 
            this.glContactos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreContacto,
            this.colCargo,
            this.colContactoId});
            this.glContactos.DetailHeight = 284;
            this.glContactos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glContactos.Name = "glContactos";
            this.glContactos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glContactos.OptionsView.ShowGroupPanel = false;
            this.glContactos.OptionsView.ShowIndicator = false;
            // 
            // colNombreContacto
            // 
            this.colNombreContacto.Caption = "Nombre";
            this.colNombreContacto.FieldName = "Nombre";
            this.colNombreContacto.MinWidth = 17;
            this.colNombreContacto.Name = "colNombreContacto";
            this.colNombreContacto.OptionsColumn.AllowEdit = false;
            this.colNombreContacto.OptionsColumn.ReadOnly = true;
            this.colNombreContacto.Visible = true;
            this.colNombreContacto.VisibleIndex = 0;
            this.colNombreContacto.Width = 64;
            // 
            // colCargo
            // 
            this.colCargo.Caption = "Cargo";
            this.colCargo.FieldName = "Cargo";
            this.colCargo.MinWidth = 17;
            this.colCargo.Name = "colCargo";
            this.colCargo.OptionsColumn.AllowEdit = false;
            this.colCargo.OptionsColumn.ReadOnly = true;
            this.colCargo.Visible = true;
            this.colCargo.VisibleIndex = 1;
            this.colCargo.Width = 64;
            // 
            // colContactoId
            // 
            this.colContactoId.Caption = "Contacto Id";
            this.colContactoId.FieldName = "ContactoId";
            this.colContactoId.MinWidth = 17;
            this.colContactoId.Name = "colContactoId";
            this.colContactoId.OptionsColumn.AllowEdit = false;
            this.colContactoId.OptionsColumn.ReadOnly = true;
            this.colContactoId.Width = 64;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.EditValue = "";
            this.txtEmpresa.Location = new System.Drawing.Point(46, 67);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmpresa.Properties.Appearance.Options.UseFont = true;
            this.txtEmpresa.Properties.ReadOnly = true;
            this.txtEmpresa.Properties.UseReadOnlyAppearance = false;
            this.txtEmpresa.Size = new System.Drawing.Size(627, 26);
            this.txtEmpresa.TabIndex = 9;
            // 
            // ctlEncabezadoPantalla1
            // 
            this.ctlEncabezadoPantalla1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlEncabezadoPantalla1.Location = new System.Drawing.Point(0, 0);
            this.ctlEncabezadoPantalla1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlEncabezadoPantalla1.Name = "ctlEncabezadoPantalla1";
            this.ctlEncabezadoPantalla1.Size = new System.Drawing.Size(751, 32);
            this.ctlEncabezadoPantalla1.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(46, 207);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(172, 12);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Seleccione uno o varios instrumentos";
            // 
            // btnAgregarNuevInstrumento
            // 
            this.btnAgregarNuevInstrumento.FlatAppearance.BorderSize = 0;
            this.btnAgregarNuevInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevInstrumento.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarNuevInstrumento.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarNuevInstrumento.IconColor = System.Drawing.Color.Black;
            this.btnAgregarNuevInstrumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarNuevInstrumento.IconSize = 30;
            this.btnAgregarNuevInstrumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNuevInstrumento.Location = new System.Drawing.Point(529, 195);
            this.btnAgregarNuevInstrumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarNuevInstrumento.Name = "btnAgregarNuevInstrumento";
            this.btnAgregarNuevInstrumento.Size = new System.Drawing.Size(189, 26);
            this.btnAgregarNuevInstrumento.TabIndex = 15;
            this.btnAgregarNuevInstrumento.Text = "Nuevo Instrumento";
            this.btnAgregarNuevInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNuevInstrumento.UseVisualStyleBackColor = true;
            this.btnAgregarNuevInstrumento.Click += new System.EventHandler(this.btnAgregarNuevInstrumento_Click);
            // 
            // gcInstrumentosDeEmpresa
            // 
            this.gcInstrumentosDeEmpresa.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcInstrumentosDeEmpresa.Location = new System.Drawing.Point(46, 226);
            this.gcInstrumentosDeEmpresa.MainView = this.gvInstrumentosDeEmpresa;
            this.gcInstrumentosDeEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcInstrumentosDeEmpresa.Name = "gcInstrumentosDeEmpresa";
            this.gcInstrumentosDeEmpresa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSeleccionarInstrumento});
            this.gcInstrumentosDeEmpresa.Size = new System.Drawing.Size(671, 106);
            this.gcInstrumentosDeEmpresa.TabIndex = 16;
            this.gcInstrumentosDeEmpresa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInstrumentosDeEmpresa});
            // 
            // gvInstrumentosDeEmpresa
            // 
            this.gvInstrumentosDeEmpresa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion,
            this.colTipo,
            this.colMarca,
            this.colModelo,
            this.colSeleccionar});
            this.gvInstrumentosDeEmpresa.DetailHeight = 284;
            this.gvInstrumentosDeEmpresa.GridControl = this.gcInstrumentosDeEmpresa;
            this.gvInstrumentosDeEmpresa.Name = "gvInstrumentosDeEmpresa";
            this.gvInstrumentosDeEmpresa.OptionsView.ShowAutoFilterRow = true;
            this.gvInstrumentosDeEmpresa.OptionsView.ShowGroupPanel = false;
            this.gvInstrumentosDeEmpresa.OptionsView.ShowIndicator = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 151;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "TipoInstrumento.Descripcion";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            this.colTipo.OptionsColumn.ReadOnly = true;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 183;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "Marca";
            this.colMarca.FieldName = "Marca.Descripcion";
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowEdit = false;
            this.colMarca.OptionsColumn.ReadOnly = true;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 2;
            this.colMarca.Width = 183;
            // 
            // colModelo
            // 
            this.colModelo.Caption = "Modelo";
            this.colModelo.FieldName = "Modelo.Descripcion";
            this.colModelo.Name = "colModelo";
            this.colModelo.OptionsColumn.AllowEdit = false;
            this.colModelo.OptionsColumn.ReadOnly = true;
            this.colModelo.Visible = true;
            this.colModelo.VisibleIndex = 3;
            this.colModelo.Width = 160;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Caption = "Seleccionar";
            this.colSeleccionar.ColumnEdit = this.chkSeleccionarInstrumento;
            this.colSeleccionar.FieldName = "Seleccionar";
            this.colSeleccionar.MinWidth = 21;
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Visible = true;
            this.colSeleccionar.VisibleIndex = 4;
            this.colSeleccionar.Width = 108;
            // 
            // chkSeleccionarInstrumento
            // 
            this.chkSeleccionarInstrumento.AutoHeight = false;
            this.chkSeleccionarInstrumento.Name = "chkSeleccionarInstrumento";
            this.chkSeleccionarInstrumento.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(46, 362);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(70, 12);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Tipo de Trabajo:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(45, 419);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 12);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Comentarios";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(46, 499);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 12);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "Prioridad:";
            // 
            // btnGuardarIngreso
            // 
            this.btnGuardarIngreso.FlatAppearance.BorderSize = 0;
            this.btnGuardarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarIngreso.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarIngreso.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarIngreso.IconColor = System.Drawing.Color.Black;
            this.btnGuardarIngreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarIngreso.IconSize = 30;
            this.btnGuardarIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarIngreso.Location = new System.Drawing.Point(529, 561);
            this.btnGuardarIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarIngreso.Name = "btnGuardarIngreso";
            this.btnGuardarIngreso.Size = new System.Drawing.Size(189, 42);
            this.btnGuardarIngreso.TabIndex = 23;
            this.btnGuardarIngreso.Text = "Guardar Ingreso";
            this.btnGuardarIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarIngreso.UseVisualStyleBackColor = true;
            this.btnGuardarIngreso.Click += new System.EventHandler(this.btnGuardarIngreso_Click);
            // 
            // memoComentarios
            // 
            this.memoComentarios.Location = new System.Drawing.Point(46, 438);
            this.memoComentarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoComentarios.Name = "memoComentarios";
            this.memoComentarios.Size = new System.Drawing.Size(671, 48);
            this.memoComentarios.TabIndex = 24;
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.EditValue = 1;
            this.trackBarControl1.Location = new System.Drawing.Point(46, 518);
            this.trackBarControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Properties.AutoSize = false;
            this.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "1";
            trackBarLabel1.Value = 1;
            trackBarLabel2.Label = "2";
            trackBarLabel2.Value = 2;
            trackBarLabel3.Label = "3";
            trackBarLabel3.Value = 3;
            trackBarLabel4.Label = "4";
            trackBarLabel4.Value = 4;
            trackBarLabel5.Label = "5";
            trackBarLabel5.Value = 5;
            this.trackBarControl1.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3,
            trackBarLabel4,
            trackBarLabel5});
            this.trackBarControl1.Properties.Maximum = 5;
            this.trackBarControl1.Properties.Minimum = 1;
            this.trackBarControl1.Properties.ShowLabels = true;
            this.trackBarControl1.Size = new System.Drawing.Size(234, 42);
            this.trackBarControl1.TabIndex = 25;
            this.trackBarControl1.Value = 1;
            // 
            // glTiposTrabajo
            // 
            this.glTiposTrabajo.Location = new System.Drawing.Point(46, 380);
            this.glTiposTrabajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glTiposTrabajo.Name = "glTiposTrabajo";
            this.glTiposTrabajo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glTiposTrabajo.Properties.Appearance.Options.UseFont = true;
            this.glTiposTrabajo.Properties.NullText = "";
            this.glTiposTrabajo.Properties.PopupView = this.glTipoTrabajo;
            this.glTiposTrabajo.Size = new System.Drawing.Size(360, 22);
            this.glTiposTrabajo.TabIndex = 26;
            this.glTiposTrabajo.EditValueChanged += new System.EventHandler(this.glTiposTrabajo_EditValueChanged);
            // 
            // glTipoTrabajo
            // 
            this.glTipoTrabajo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.glTipoTrabajo.DetailHeight = 284;
            this.glTipoTrabajo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glTipoTrabajo.Name = "glTipoTrabajo";
            this.glTipoTrabajo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glTipoTrabajo.OptionsView.ShowColumnHeaders = false;
            this.glTipoTrabajo.OptionsView.ShowGroupPanel = false;
            this.glTipoTrabajo.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "TipoTrabajoId";
            this.gridColumn1.MinWidth = 17;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Width = 64;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tipo de Trabajo";
            this.gridColumn2.FieldName = "Descripcion";
            this.gridColumn2.MinWidth = 17;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 64;
            // 
            // lblTotalInstrumentos
            // 
            this.lblTotalInstrumentos.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalInstrumentos.Appearance.Options.UseFont = true;
            this.lblTotalInstrumentos.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalInstrumentos.Location = new System.Drawing.Point(0, 0);
            this.lblTotalInstrumentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotalInstrumentos.Name = "lblTotalInstrumentos";
            this.lblTotalInstrumentos.Size = new System.Drawing.Size(6, 12);
            this.lblTotalInstrumentos.TabIndex = 27;
            this.lblTotalInstrumentos.Text = "0";
            this.lblTotalInstrumentos.Visible = false;
            // 
            // lblInstrumentosSeleccionados
            // 
            this.lblInstrumentosSeleccionados.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstrumentosSeleccionados.Appearance.Options.UseFont = true;
            this.lblInstrumentosSeleccionados.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblInstrumentosSeleccionados.Location = new System.Drawing.Point(665, 0);
            this.lblInstrumentosSeleccionados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblInstrumentosSeleccionados.Name = "lblInstrumentosSeleccionados";
            this.lblInstrumentosSeleccionados.Size = new System.Drawing.Size(6, 12);
            this.lblInstrumentosSeleccionados.TabIndex = 28;
            this.lblInstrumentosSeleccionados.Text = "0";
            this.lblInstrumentosSeleccionados.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalInstrumentos);
            this.panel1.Controls.Add(this.lblInstrumentosSeleccionados);
            this.panel1.Location = new System.Drawing.Point(46, 336);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 22);
            this.panel1.TabIndex = 29;
            // 
            // frmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.glTiposTrabajo);
            this.Controls.Add(this.trackBarControl1);
            this.Controls.Add(this.memoComentarios);
            this.Controls.Add(this.btnGuardarIngreso);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.gcInstrumentosDeEmpresa);
            this.Controls.Add(this.btnAgregarNuevInstrumento);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.ctlEncabezadoPantalla1);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.glContacto);
            this.Controls.Add(this.btnBuscarEmpresa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.glCorreoElectronico);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.glCorreoElectronico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstrumentosDeEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstrumentosDeEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionarInstrumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTiposTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoTrabajo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit glCorreoElectronico;
        private DevExpress.XtraGrid.Views.Grid.GridView glCorreo;
        private FontAwesome.Sharp.IconButton btnBuscarEmpresa;
        private DevExpress.XtraEditors.GridLookUpEdit glContacto;
        private DevExpress.XtraGrid.Views.Grid.GridView glContactos;
        private DevExpress.XtraEditors.TextEdit txtEmpresa;
        private System.Windows.Forms.ToolTip toolTip1;
        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantallaPopupEmpresas;
        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla3;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colContactoId;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistroId;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private FontAwesome.Sharp.IconButton btnAgregarNuevInstrumento;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private FontAwesome.Sharp.IconButton btnGuardarIngreso;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl gcInstrumentosDeEmpresa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInstrumentosDeEmpresa;
        private DevExpress.XtraEditors.TrackBarControl trackBarControl1;
        private DevExpress.XtraEditors.MemoEdit memoComentarios;
        private DevExpress.XtraEditors.GridLookUpEdit glTiposTrabajo;
        private DevExpress.XtraGrid.Views.Grid.GridView glTipoTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraEditors.LabelControl lblTotalInstrumentos;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSeleccionarInstrumento;
        private DevExpress.XtraEditors.LabelControl lblInstrumentosSeleccionados;
        private System.Windows.Forms.Panel panel1;
    }
}