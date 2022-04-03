
namespace TacticaReparaciones.DesktopApp.Pantallas
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
            this.ctlEncabezadoAgregarInstrumento = new TacticaReparaciones.DesktopApp.Componentes.Encabezados.ctlEncabezadoPantalla();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmpresaInstrumento = new DevExpress.XtraEditors.TextEdit();
            this.btnAbrirPopupEmpresaPorInstrumento = new FontAwesome.Sharp.IconButton();
            this.txtNumeroSerie = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.glClasificacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glTipoInstrumentoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClasificacionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoInstrumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionCompuesta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardarInstrumento = new FontAwesome.Sharp.IconButton();
            this.txtDescripcionInstrumento = new DevExpress.XtraEditors.TextEdit();
            this.dateFechaCompraFabricante = new System.Windows.Forms.DateTimePicker();
            this.dateFechaCompraCliente = new System.Windows.Forms.DateTimePicker();
            this.dateUltimaCalibracion = new System.Windows.Forms.DateTimePicker();
            this.dateProximaCalibracion = new System.Windows.Forms.DateTimePicker();
            this.txtGarantia = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresaInstrumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glClasificacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumentoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionInstrumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGarantia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlEncabezadoAgregarInstrumento
            // 
            this.ctlEncabezadoAgregarInstrumento.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlEncabezadoAgregarInstrumento.Location = new System.Drawing.Point(0, 0);
            this.ctlEncabezadoAgregarInstrumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlEncabezadoAgregarInstrumento.Name = "ctlEncabezadoAgregarInstrumento";
            this.ctlEncabezadoAgregarInstrumento.Size = new System.Drawing.Size(756, 43);
            this.ctlEncabezadoAgregarInstrumento.TabIndex = 10;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(30, 129);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(126, 17);
            this.labelControl20.TabIndex = 116;
            this.labelControl20.Text = "Nombre de Empresa:";
            // 
            // txtEmpresaInstrumento
            // 
            this.txtEmpresaInstrumento.EditValue = "";
            this.txtEmpresaInstrumento.Location = new System.Drawing.Point(30, 149);
            this.txtEmpresaInstrumento.Name = "txtEmpresaInstrumento";
            this.txtEmpresaInstrumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmpresaInstrumento.Properties.Appearance.Options.UseFont = true;
            this.txtEmpresaInstrumento.Properties.ReadOnly = true;
            this.txtEmpresaInstrumento.Properties.UseReadOnlyAppearance = false;
            this.txtEmpresaInstrumento.Size = new System.Drawing.Size(644, 30);
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
            this.btnAbrirPopupEmpresaPorInstrumento.Location = new System.Drawing.Point(700, 152);
            this.btnAbrirPopupEmpresaPorInstrumento.Name = "btnAbrirPopupEmpresaPorInstrumento";
            this.btnAbrirPopupEmpresaPorInstrumento.Size = new System.Drawing.Size(33, 32);
            this.btnAbrirPopupEmpresaPorInstrumento.TabIndex = 114;
            this.btnAbrirPopupEmpresaPorInstrumento.UseVisualStyleBackColor = true;
            this.btnAbrirPopupEmpresaPorInstrumento.Click += new System.EventHandler(this.btnAbrirPopupEmpresaPorInstrumento_Click);
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.EditValue = "";
            this.txtNumeroSerie.Location = new System.Drawing.Point(30, 288);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroSerie.Properties.Appearance.Options.UseFont = true;
            this.txtNumeroSerie.Properties.UseReadOnlyAppearance = false;
            this.txtNumeroSerie.Size = new System.Drawing.Size(644, 30);
            this.txtNumeroSerie.TabIndex = 109;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(367, 412);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(119, 17);
            this.labelControl19.TabIndex = 106;
            this.labelControl19.Text = "Próxima Calibración:";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(30, 412);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(109, 17);
            this.labelControl17.TabIndex = 102;
            this.labelControl17.Text = "Última Calibración:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(367, 342);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(171, 17);
            this.labelControl14.TabIndex = 101;
            this.labelControl14.Text = "Fecha de Compra del Cliente:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(30, 342);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(184, 17);
            this.labelControl15.TabIndex = 100;
            this.labelControl15.Text = "Fecha de Compra al Fabricante:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(30, 265);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(103, 17);
            this.labelControl9.TabIndex = 99;
            this.labelControl9.Text = "Número de Serie:";
            // 
            // glClasificacion
            // 
            this.glClasificacion.EditValue = "";
            this.glClasificacion.Location = new System.Drawing.Point(30, 217);
            this.glClasificacion.Name = "glClasificacion";
            this.glClasificacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glClasificacion.Properties.Appearance.Options.UseFont = true;
            this.glClasificacion.Properties.NullText = "";
            this.glClasificacion.Properties.PopupView = this.glTipoInstrumentoView;
            this.glClasificacion.Size = new System.Drawing.Size(644, 26);
            this.glClasificacion.TabIndex = 93;
            this.glClasificacion.EditValueChanged += new System.EventHandler(this.glClasificacion_EditValueChanged);
            // 
            // glTipoInstrumentoView
            // 
            this.glTipoInstrumentoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClasificacionId,
            this.colTipoInstrumento,
            this.colMarca,
            this.colModelo,
            this.colDescripcionCompuesta});
            this.glTipoInstrumentoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glTipoInstrumentoView.Name = "glTipoInstrumentoView";
            this.glTipoInstrumentoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glTipoInstrumentoView.OptionsView.ShowGroupPanel = false;
            this.glTipoInstrumentoView.OptionsView.ShowIndicator = false;
            // 
            // colClasificacionId
            // 
            this.colClasificacionId.Caption = "Id";
            this.colClasificacionId.FieldName = "TipoInstrumentoId";
            this.colClasificacionId.Name = "colClasificacionId";
            this.colClasificacionId.OptionsColumn.AllowEdit = false;
            this.colClasificacionId.OptionsColumn.ReadOnly = true;
            // 
            // colTipoInstrumento
            // 
            this.colTipoInstrumento.Caption = "Tipo de Instrumento";
            this.colTipoInstrumento.FieldName = "TipoInstrumento.Descripcion";
            this.colTipoInstrumento.Name = "colTipoInstrumento";
            this.colTipoInstrumento.OptionsColumn.AllowEdit = false;
            this.colTipoInstrumento.OptionsColumn.ReadOnly = true;
            this.colTipoInstrumento.Visible = true;
            this.colTipoInstrumento.VisibleIndex = 0;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "Marca";
            this.colMarca.FieldName = "Marca.Descripcion";
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowEdit = false;
            this.colMarca.OptionsColumn.ReadOnly = true;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 1;
            // 
            // colModelo
            // 
            this.colModelo.Caption = "Modelo";
            this.colModelo.FieldName = "Modelo.Descripcion";
            this.colModelo.Name = "colModelo";
            this.colModelo.OptionsColumn.AllowEdit = false;
            this.colModelo.OptionsColumn.ReadOnly = true;
            this.colModelo.Visible = true;
            this.colModelo.VisibleIndex = 2;
            // 
            // colDescripcionCompuesta
            // 
            this.colDescripcionCompuesta.Caption = "Descripcion Compuesta";
            this.colDescripcionCompuesta.FieldName = "DescripcionCompuesta";
            this.colDescripcionCompuesta.Name = "colDescripcionCompuesta";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(30, 194);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(74, 17);
            this.labelControl10.TabIndex = 92;
            this.labelControl10.Text = "Clasificación:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(30, 61);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(160, 17);
            this.labelControl11.TabIndex = 91;
            this.labelControl11.Text = "Descripción de Instrumento";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(30, 478);
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
            this.btnGuardarInstrumento.Location = new System.Drawing.Point(453, 563);
            this.btnGuardarInstrumento.Name = "btnGuardarInstrumento";
            this.btnGuardarInstrumento.Size = new System.Drawing.Size(221, 52);
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
            this.txtDescripcionInstrumento.Name = "txtDescripcionInstrumento";
            this.txtDescripcionInstrumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcionInstrumento.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcionInstrumento.Properties.UseReadOnlyAppearance = false;
            this.txtDescripcionInstrumento.Size = new System.Drawing.Size(644, 30);
            this.txtDescripcionInstrumento.TabIndex = 94;
            // 
            // dateFechaCompraFabricante
            // 
            this.dateFechaCompraFabricante.Location = new System.Drawing.Point(30, 365);
            this.dateFechaCompraFabricante.Name = "dateFechaCompraFabricante";
            this.dateFechaCompraFabricante.Size = new System.Drawing.Size(320, 23);
            this.dateFechaCompraFabricante.TabIndex = 117;
            // 
            // dateFechaCompraCliente
            // 
            this.dateFechaCompraCliente.Location = new System.Drawing.Point(367, 365);
            this.dateFechaCompraCliente.Name = "dateFechaCompraCliente";
            this.dateFechaCompraCliente.Size = new System.Drawing.Size(307, 23);
            this.dateFechaCompraCliente.TabIndex = 118;
            // 
            // dateUltimaCalibracion
            // 
            this.dateUltimaCalibracion.Location = new System.Drawing.Point(30, 435);
            this.dateUltimaCalibracion.Name = "dateUltimaCalibracion";
            this.dateUltimaCalibracion.Size = new System.Drawing.Size(320, 23);
            this.dateUltimaCalibracion.TabIndex = 119;
            // 
            // dateProximaCalibracion
            // 
            this.dateProximaCalibracion.Location = new System.Drawing.Point(367, 435);
            this.dateProximaCalibracion.Name = "dateProximaCalibracion";
            this.dateProximaCalibracion.Size = new System.Drawing.Size(307, 23);
            this.dateProximaCalibracion.TabIndex = 120;
            // 
            // txtGarantia
            // 
            this.txtGarantia.EditValue = "";
            this.txtGarantia.Location = new System.Drawing.Point(30, 501);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGarantia.Properties.Appearance.Options.UseFont = true;
            this.txtGarantia.Properties.UseReadOnlyAppearance = false;
            this.txtGarantia.Size = new System.Drawing.Size(644, 30);
            this.txtGarantia.TabIndex = 121;
            // 
            // frmNuevoInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 646);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.dateProximaCalibracion);
            this.Controls.Add(this.dateUltimaCalibracion);
            this.Controls.Add(this.dateFechaCompraCliente);
            this.Controls.Add(this.dateFechaCompraFabricante);
            this.Controls.Add(this.labelControl20);
            this.Controls.Add(this.txtEmpresaInstrumento);
            this.Controls.Add(this.btnAbrirPopupEmpresaPorInstrumento);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.labelControl17);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.glClasificacion);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.btnGuardarInstrumento);
            this.Controls.Add(this.txtDescripcionInstrumento);
            this.Controls.Add(this.ctlEncabezadoAgregarInstrumento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNuevoInstrumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Instrumento";
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresaInstrumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glClasificacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumentoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionInstrumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGarantia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoAgregarInstrumento;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtEmpresaInstrumento;
        private FontAwesome.Sharp.IconButton btnAbrirPopupEmpresaPorInstrumento;
        private DevExpress.XtraEditors.TextEdit txtNumeroSerie;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.GridLookUpEdit glClasificacion;
        private DevExpress.XtraGrid.Views.Grid.GridView glTipoInstrumentoView;
        private DevExpress.XtraGrid.Columns.GridColumn colClasificacionId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private FontAwesome.Sharp.IconButton btnGuardarInstrumento;
        private DevExpress.XtraEditors.TextEdit txtDescripcionInstrumento;
        private System.Windows.Forms.DateTimePicker dateFechaCompraFabricante;
        private System.Windows.Forms.DateTimePicker dateFechaCompraCliente;
        private System.Windows.Forms.DateTimePicker dateUltimaCalibracion;
        private System.Windows.Forms.DateTimePicker dateProximaCalibracion;
        private DevExpress.XtraEditors.TextEdit txtGarantia;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionCompuesta;
    }
}