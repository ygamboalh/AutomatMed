
namespace AutomatMediciones.DesktopApp.Pantallas.Instrumentos
{
    partial class frmNuevoInstrumento
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
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmpresaInstrumento = new DevExpress.XtraEditors.TextEdit();
            this.btnAbrirPopupEmpresaPorInstrumento = new FontAwesome.Sharp.IconButton();
            this.txtNumeroSerie = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.glTipoInstrumento = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glTipoInstrumentoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoInstrumentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionTipoInstrumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardarInstrumento = new FontAwesome.Sharp.IconButton();
            this.txtDescripcionInstrumento = new DevExpress.XtraEditors.TextEdit();
            this.dateFechaCompraFabricante = new System.Windows.Forms.DateTimePicker();
            this.dateFechaCompraCliente = new System.Windows.Forms.DateTimePicker();
            this.txtGarantia = new DevExpress.XtraEditors.TextEdit();
            this.glMarcas = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMarcaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.glModelos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colModeloId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregarClasificacion = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.memoComentarios = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresaInstrumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumentoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionInstrumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGarantia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glMarcas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glModelos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(30, 129);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(135, 17);
            this.labelControl20.TabIndex = 116;
            this.labelControl20.Text = "Nombre de Empresa *:";
            // 
            // txtEmpresaInstrumento
            // 
            this.txtEmpresaInstrumento.EditValue = "";
            this.txtEmpresaInstrumento.Location = new System.Drawing.Point(30, 149);
            this.txtEmpresaInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmpresaInstrumento.Name = "txtEmpresaInstrumento";
            this.txtEmpresaInstrumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmpresaInstrumento.Properties.Appearance.Options.UseFont = true;
            this.txtEmpresaInstrumento.Properties.ReadOnly = true;
            this.txtEmpresaInstrumento.Properties.UseReadOnlyAppearance = false;
            this.txtEmpresaInstrumento.Size = new System.Drawing.Size(652, 30);
            this.txtEmpresaInstrumento.TabIndex = 115;
            // 
            // btnAbrirPopupEmpresaPorInstrumento
            // 
            this.btnAbrirPopupEmpresaPorInstrumento.FlatAppearance.BorderSize = 0;
            this.btnAbrirPopupEmpresaPorInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirPopupEmpresaPorInstrumento.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnAbrirPopupEmpresaPorInstrumento.IconColor = System.Drawing.Color.Black;
            this.btnAbrirPopupEmpresaPorInstrumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbrirPopupEmpresaPorInstrumento.IconSize = 30;
            this.btnAbrirPopupEmpresaPorInstrumento.Location = new System.Drawing.Point(690, 152);
            this.btnAbrirPopupEmpresaPorInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAbrirPopupEmpresaPorInstrumento.Name = "btnAbrirPopupEmpresaPorInstrumento";
            this.btnAbrirPopupEmpresaPorInstrumento.Size = new System.Drawing.Size(33, 32);
            this.btnAbrirPopupEmpresaPorInstrumento.TabIndex = 114;
            this.btnAbrirPopupEmpresaPorInstrumento.UseVisualStyleBackColor = true;
            this.btnAbrirPopupEmpresaPorInstrumento.Click += new System.EventHandler(this.btnAbrirPopupEmpresaPorInstrumento_Click);
            this.btnAbrirPopupEmpresaPorInstrumento.MouseHover += new System.EventHandler(this.btnAbrirPopupEmpresaPorInstrumento_MouseHover);
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.EditValue = "";
            this.txtNumeroSerie.Location = new System.Drawing.Point(29, 292);
            this.txtNumeroSerie.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroSerie.Properties.Appearance.Options.UseFont = true;
            this.txtNumeroSerie.Properties.UseReadOnlyAppearance = false;
            this.txtNumeroSerie.Size = new System.Drawing.Size(694, 30);
            this.txtNumeroSerie.TabIndex = 109;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(415, 345);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(171, 17);
            this.labelControl14.TabIndex = 101;
            this.labelControl14.Text = "Fecha de Compra del Cliente:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(30, 345);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(184, 17);
            this.labelControl15.TabIndex = 100;
            this.labelControl15.Text = "Fecha de Compra al Fabricante:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(29, 268);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(103, 17);
            this.labelControl9.TabIndex = 99;
            this.labelControl9.Text = "Número de Serie:";
            // 
            // glTipoInstrumento
            // 
            this.glTipoInstrumento.EditValue = "";
            this.glTipoInstrumento.Location = new System.Drawing.Point(30, 217);
            this.glTipoInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glTipoInstrumento.Name = "glTipoInstrumento";
            this.glTipoInstrumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glTipoInstrumento.Properties.Appearance.Options.UseFont = true;
            this.glTipoInstrumento.Properties.NullText = "";
            this.glTipoInstrumento.Properties.PopupView = this.glTipoInstrumentoView;
            this.glTipoInstrumento.Size = new System.Drawing.Size(204, 26);
            this.glTipoInstrumento.TabIndex = 93;
            this.glTipoInstrumento.EditValueChanged += new System.EventHandler(this.glTipoInstrumento_EditValueChanged);
            // 
            // glTipoInstrumentoView
            // 
            this.glTipoInstrumentoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoInstrumentoId,
            this.colDescripcionTipoInstrumento});
            this.glTipoInstrumentoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glTipoInstrumentoView.Name = "glTipoInstrumentoView";
            this.glTipoInstrumentoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glTipoInstrumentoView.OptionsView.ShowGroupPanel = false;
            this.glTipoInstrumentoView.OptionsView.ShowIndicator = false;
            // 
            // colTipoInstrumentoId
            // 
            this.colTipoInstrumentoId.Caption = "Id";
            this.colTipoInstrumentoId.FieldName = "TipoInstrumentoId";
            this.colTipoInstrumentoId.MinWidth = 23;
            this.colTipoInstrumentoId.Name = "colTipoInstrumentoId";
            // 
            // colDescripcionTipoInstrumento
            // 
            this.colDescripcionTipoInstrumento.Caption = "Descripción";
            this.colDescripcionTipoInstrumento.FieldName = "Descripcion";
            this.colDescripcionTipoInstrumento.MinWidth = 23;
            this.colDescripcionTipoInstrumento.Name = "colDescripcionTipoInstrumento";
            this.colDescripcionTipoInstrumento.Visible = true;
            this.colDescripcionTipoInstrumento.VisibleIndex = 0;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(30, 194);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(130, 17);
            this.labelControl10.TabIndex = 92;
            this.labelControl10.Text = "Tipo de Instrumento *:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(30, 62);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(172, 17);
            this.labelControl11.TabIndex = 91;
            this.labelControl11.Text = "Descripción de Instrumento *:";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(30, 404);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(52, 17);
            this.labelControl18.TabIndex = 107;
            this.labelControl18.Text = "Garantía:";
            // 
            // btnGuardarInstrumento
            // 
            this.btnGuardarInstrumento.FlatAppearance.BorderSize = 0;
            this.btnGuardarInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarInstrumento.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarInstrumento.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarInstrumento.IconColor = System.Drawing.Color.Black;
            this.btnGuardarInstrumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarInstrumento.IconSize = 30;
            this.btnGuardarInstrumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarInstrumento.Location = new System.Drawing.Point(505, 593);
            this.btnGuardarInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarInstrumento.Name = "btnGuardarInstrumento";
            this.btnGuardarInstrumento.Size = new System.Drawing.Size(220, 52);
            this.btnGuardarInstrumento.TabIndex = 105;
            this.btnGuardarInstrumento.Text = "Guardar Instrumento";
            this.btnGuardarInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarInstrumento.UseVisualStyleBackColor = true;
            this.btnGuardarInstrumento.Click += new System.EventHandler(this.btnGuardarInstrumento_Click);
            // 
            // txtDescripcionInstrumento
            // 
            this.txtDescripcionInstrumento.EditValue = "";
            this.txtDescripcionInstrumento.Location = new System.Drawing.Point(30, 84);
            this.txtDescripcionInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescripcionInstrumento.Name = "txtDescripcionInstrumento";
            this.txtDescripcionInstrumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcionInstrumento.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcionInstrumento.Properties.UseReadOnlyAppearance = false;
            this.txtDescripcionInstrumento.Size = new System.Drawing.Size(693, 30);
            this.txtDescripcionInstrumento.TabIndex = 94;
            // 
            // dateFechaCompraFabricante
            // 
            this.dateFechaCompraFabricante.Location = new System.Drawing.Point(30, 368);
            this.dateFechaCompraFabricante.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateFechaCompraFabricante.Name = "dateFechaCompraFabricante";
            this.dateFechaCompraFabricante.Size = new System.Drawing.Size(320, 23);
            this.dateFechaCompraFabricante.TabIndex = 117;
            // 
            // dateFechaCompraCliente
            // 
            this.dateFechaCompraCliente.Location = new System.Drawing.Point(415, 368);
            this.dateFechaCompraCliente.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateFechaCompraCliente.Name = "dateFechaCompraCliente";
            this.dateFechaCompraCliente.Size = new System.Drawing.Size(307, 23);
            this.dateFechaCompraCliente.TabIndex = 118;
            // 
            // txtGarantia
            // 
            this.txtGarantia.EditValue = "";
            this.txtGarantia.Location = new System.Drawing.Point(30, 425);
            this.txtGarantia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGarantia.Properties.Appearance.Options.UseFont = true;
            this.txtGarantia.Properties.UseReadOnlyAppearance = false;
            this.txtGarantia.Size = new System.Drawing.Size(693, 30);
            this.txtGarantia.TabIndex = 121;
            // 
            // glMarcas
            // 
            this.glMarcas.EditValue = "";
            this.glMarcas.Location = new System.Drawing.Point(242, 217);
            this.glMarcas.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glMarcas.Name = "glMarcas";
            this.glMarcas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glMarcas.Properties.Appearance.Options.UseFont = true;
            this.glMarcas.Properties.NullText = "";
            this.glMarcas.Properties.PopupView = this.gridLookUpEdit1View;
            this.glMarcas.Size = new System.Drawing.Size(221, 26);
            this.glMarcas.TabIndex = 123;
            this.glMarcas.EditValueChanged += new System.EventHandler(this.glMarcas_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMarcaId,
            this.colDescripcionMarca});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.OptionsView.ShowIndicator = false;
            // 
            // colMarcaId
            // 
            this.colMarcaId.Caption = "Id";
            this.colMarcaId.FieldName = "MarcaId";
            this.colMarcaId.MinWidth = 23;
            this.colMarcaId.Name = "colMarcaId";
            this.colMarcaId.Width = 87;
            // 
            // colDescripcionMarca
            // 
            this.colDescripcionMarca.Caption = "Marca";
            this.colDescripcionMarca.FieldName = "Descripcion";
            this.colDescripcionMarca.MinWidth = 23;
            this.colDescripcionMarca.Name = "colDescripcionMarca";
            this.colDescripcionMarca.OptionsColumn.AllowEdit = false;
            this.colDescripcionMarca.Visible = true;
            this.colDescripcionMarca.VisibleIndex = 0;
            this.colDescripcionMarca.Width = 87;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(242, 194);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 17);
            this.labelControl1.TabIndex = 122;
            this.labelControl1.Text = "Marca *:";
            // 
            // glModelos
            // 
            this.glModelos.EditValue = "";
            this.glModelos.Location = new System.Drawing.Point(471, 217);
            this.glModelos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glModelos.Name = "glModelos";
            this.glModelos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glModelos.Properties.Appearance.Options.UseFont = true;
            this.glModelos.Properties.NullText = "";
            this.glModelos.Properties.PopupView = this.gridLookUpEdit2View;
            this.glModelos.Size = new System.Drawing.Size(211, 26);
            this.glModelos.TabIndex = 125;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colModeloId,
            this.colDescripcionModelo});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit2View.OptionsView.ShowIndicator = false;
            // 
            // colModeloId
            // 
            this.colModeloId.Caption = "Id";
            this.colModeloId.FieldName = "ModeloId";
            this.colModeloId.MinWidth = 23;
            this.colModeloId.Name = "colModeloId";
            this.colModeloId.Width = 87;
            // 
            // colDescripcionModelo
            // 
            this.colDescripcionModelo.Caption = "Descripción";
            this.colDescripcionModelo.FieldName = "Descripcion";
            this.colDescripcionModelo.MinWidth = 23;
            this.colDescripcionModelo.Name = "colDescripcionModelo";
            this.colDescripcionModelo.OptionsColumn.AllowEdit = false;
            this.colDescripcionModelo.Visible = true;
            this.colDescripcionModelo.VisibleIndex = 0;
            this.colDescripcionModelo.Width = 87;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(471, 194);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 17);
            this.labelControl2.TabIndex = 124;
            this.labelControl2.Text = "Modelo *:";
            // 
            // btnAgregarClasificacion
            // 
            this.btnAgregarClasificacion.FlatAppearance.BorderSize = 0;
            this.btnAgregarClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarClasificacion.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarClasificacion.IconColor = System.Drawing.Color.Black;
            this.btnAgregarClasificacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarClasificacion.IconSize = 30;
            this.btnAgregarClasificacion.Location = new System.Drawing.Point(690, 211);
            this.btnAgregarClasificacion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarClasificacion.Name = "btnAgregarClasificacion";
            this.btnAgregarClasificacion.Size = new System.Drawing.Size(33, 32);
            this.btnAgregarClasificacion.TabIndex = 126;
            this.btnAgregarClasificacion.UseVisualStyleBackColor = true;
            this.btnAgregarClasificacion.Click += new System.EventHandler(this.btnAgregarClasificacion_Click);
            this.btnAgregarClasificacion.MouseHover += new System.EventHandler(this.btnAgregarClasificacion_MouseHover);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 467);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 17);
            this.labelControl3.TabIndex = 127;
            this.labelControl3.Text = "Comentarios:";
            // 
            // memoComentarios
            // 
            this.memoComentarios.Location = new System.Drawing.Point(30, 488);
            this.memoComentarios.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoComentarios.Name = "memoComentarios";
            this.memoComentarios.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoComentarios.Properties.Appearance.Options.UseFont = true;
            this.memoComentarios.Size = new System.Drawing.Size(693, 71);
            this.memoComentarios.TabIndex = 128;
            // 
            // frmNuevoInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 656);
            this.Controls.Add(this.memoComentarios);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnAgregarClasificacion);
            this.Controls.Add(this.glModelos);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.glMarcas);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.dateFechaCompraCliente);
            this.Controls.Add(this.dateFechaCompraFabricante);
            this.Controls.Add(this.labelControl20);
            this.Controls.Add(this.txtEmpresaInstrumento);
            this.Controls.Add(this.btnAbrirPopupEmpresaPorInstrumento);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.glTipoInstrumento);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.btnGuardarInstrumento);
            this.Controls.Add(this.txtDescripcionInstrumento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmNuevoInstrumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresaInstrumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumentoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionInstrumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGarantia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glMarcas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glModelos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtEmpresaInstrumento;
        private FontAwesome.Sharp.IconButton btnAbrirPopupEmpresaPorInstrumento;
        private DevExpress.XtraEditors.TextEdit txtNumeroSerie;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.GridLookUpEdit glTipoInstrumento;
        private DevExpress.XtraGrid.Views.Grid.GridView glTipoInstrumentoView;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private FontAwesome.Sharp.IconButton btnGuardarInstrumento;
        private DevExpress.XtraEditors.TextEdit txtDescripcionInstrumento;
        private System.Windows.Forms.DateTimePicker dateFechaCompraFabricante;
        private System.Windows.Forms.DateTimePicker dateFechaCompraCliente;
        private DevExpress.XtraEditors.TextEdit txtGarantia;
        private DevExpress.XtraEditors.GridLookUpEdit glMarcas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit glModelos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInstrumentoId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionTipoInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn colMarcaId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colModeloId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionModelo;
        private FontAwesome.Sharp.IconButton btnAgregarClasificacion;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit memoComentarios;
    }
}