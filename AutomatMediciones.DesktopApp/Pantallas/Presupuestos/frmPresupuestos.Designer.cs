namespace AutomatMediciones.DesktopApp.Pantallas.Presupuestos
{
    partial class frmPresupuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresupuestos));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnViewDetails = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcPresupuestos = new DevExpress.XtraGrid.GridControl();
            this.gvPresupuesto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClienteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroServicioTecnico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClasificacionInstrumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnShowDetails = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditPresupuesto = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeletePresupuesto = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelListadoPresupuesto = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePresupuesto)).BeginInit();
            this.panelListadoPresupuesto.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.AutoHeight = false;
            this.btnViewDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gcPresupuestos
            // 
            this.gcPresupuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPresupuestos.Location = new System.Drawing.Point(0, 0);
            this.gcPresupuestos.MainView = this.gvPresupuesto;
            this.gcPresupuestos.Name = "gcPresupuestos";
            this.gcPresupuestos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnShowDetails,
            this.btnEditPresupuesto,
            this.btnDeletePresupuesto});
            this.gcPresupuestos.Size = new System.Drawing.Size(1920, 1027);
            this.gcPresupuestos.TabIndex = 191;
            this.gcPresupuestos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPresupuesto});
            // 
            // gvPresupuesto
            // 
            this.gvPresupuesto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClienteId,
            this.colNombreCliente,
            this.colNumeroServicioTecnico,
            this.colClasificacionInstrumento,
            this.Description,
            this.FechaCreacion,
            this.btnDetail,
            this.btnEdit,
            this.btnDelete});
            this.gvPresupuesto.GridControl = this.gcPresupuestos;
            this.gvPresupuesto.Name = "gvPresupuesto";
            this.gvPresupuesto.OptionsView.ShowGroupPanel = false;
            // 
            // colClienteId
            // 
            this.colClienteId.Caption = "Cliente";
            this.colClienteId.FieldName = "ClienteId";
            this.colClienteId.MinWidth = 40;
            this.colClienteId.Name = "colClienteId";
            this.colClienteId.OptionsColumn.AllowEdit = false;
            this.colClienteId.OptionsColumn.ReadOnly = true;
            this.colClienteId.Visible = true;
            this.colClienteId.VisibleIndex = 0;
            this.colClienteId.Width = 243;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.Caption = "Contacto";
            this.colNombreCliente.FieldName = "NombreCliente";
            this.colNombreCliente.MinWidth = 40;
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.OptionsColumn.AllowEdit = false;
            this.colNombreCliente.OptionsColumn.ReadOnly = true;
            this.colNombreCliente.Visible = true;
            this.colNombreCliente.VisibleIndex = 1;
            this.colNombreCliente.Width = 243;
            // 
            // colNumeroServicioTecnico
            // 
            this.colNumeroServicioTecnico.Caption = "No Servicio técnico ";
            this.colNumeroServicioTecnico.FieldName = "NoServicioTecnico";
            this.colNumeroServicioTecnico.MinWidth = 40;
            this.colNumeroServicioTecnico.Name = "colNumeroServicioTecnico";
            this.colNumeroServicioTecnico.OptionsColumn.AllowEdit = false;
            this.colNumeroServicioTecnico.OptionsColumn.ReadOnly = true;
            this.colNumeroServicioTecnico.Visible = true;
            this.colNumeroServicioTecnico.VisibleIndex = 2;
            this.colNumeroServicioTecnico.Width = 243;
            // 
            // colClasificacionInstrumento
            // 
            this.colClasificacionInstrumento.Caption = "Clasificación Instrumento";
            this.colClasificacionInstrumento.FieldName = "ClasificacionInstrumento";
            this.colClasificacionInstrumento.MinWidth = 40;
            this.colClasificacionInstrumento.Name = "colClasificacionInstrumento";
            this.colClasificacionInstrumento.OptionsColumn.AllowEdit = false;
            this.colClasificacionInstrumento.OptionsColumn.ReadOnly = true;
            this.colClasificacionInstrumento.Visible = true;
            this.colClasificacionInstrumento.VisibleIndex = 3;
            this.colClasificacionInstrumento.Width = 243;
            // 
            // Description
            // 
            this.Description.FieldName = "Descripcion";
            this.Description.MinWidth = 40;
            this.Description.Name = "Description";
            this.Description.OptionsColumn.AllowEdit = false;
            this.Description.OptionsColumn.ReadOnly = true;
            this.Description.Visible = true;
            this.Description.VisibleIndex = 4;
            this.Description.Width = 243;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.FieldName = "FechaCreacion";
            this.FechaCreacion.MinWidth = 40;
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.OptionsColumn.AllowEdit = false;
            this.FechaCreacion.OptionsColumn.ReadOnly = true;
            this.FechaCreacion.Visible = true;
            this.FechaCreacion.VisibleIndex = 5;
            this.FechaCreacion.Width = 243;
            // 
            // btnDetail
            // 
            this.btnDetail.ColumnEdit = this.btnShowDetails;
            this.btnDetail.MaxWidth = 51;
            this.btnDetail.MinWidth = 41;
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Visible = true;
            this.btnDetail.VisibleIndex = 6;
            this.btnDetail.Width = 51;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Appearance.BackColor = System.Drawing.Color.White;
            this.btnShowDetails.Appearance.Options.UseBackColor = true;
            this.btnShowDetails.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnShowDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Mostrar detalle del presupuesto", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnEdit
            // 
            this.btnEdit.ColumnEdit = this.btnEditPresupuesto;
            this.btnEdit.MaxWidth = 51;
            this.btnEdit.MinWidth = 41;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Visible = true;
            this.btnEdit.VisibleIndex = 7;
            this.btnEdit.Width = 51;
            // 
            // btnEditPresupuesto
            // 
            this.btnEditPresupuesto.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEditPresupuesto.Appearance.Options.UseBackColor = true;
            this.btnEditPresupuesto.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEditPresupuesto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Editar presupuesto", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditPresupuesto.Name = "btnEditPresupuesto";
            this.btnEditPresupuesto.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnDelete
            // 
            this.btnDelete.ColumnEdit = this.btnDeletePresupuesto;
            this.btnDelete.MaxWidth = 51;
            this.btnDelete.MinWidth = 41;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Visible = true;
            this.btnDelete.VisibleIndex = 8;
            this.btnDelete.Width = 51;
            // 
            // btnDeletePresupuesto
            // 
            this.btnDeletePresupuesto.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnDeletePresupuesto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "Eliminar presupuesto", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDeletePresupuesto.Name = "btnDeletePresupuesto";
            this.btnDeletePresupuesto.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panelListadoPresupuesto
            // 
            this.panelListadoPresupuesto.Controls.Add(this.gcPresupuestos);
            this.panelListadoPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListadoPresupuesto.Location = new System.Drawing.Point(0, 0);
            this.panelListadoPresupuesto.Name = "panelListadoPresupuesto";
            this.panelListadoPresupuesto.Size = new System.Drawing.Size(1920, 1027);
            this.panelListadoPresupuesto.TabIndex = 195;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.lblTotal);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 985);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1920, 42);
            this.panelFooter.TabIndex = 195;
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
            // frmPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1027);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelListadoPresupuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPresupuestos";
            this.Text = "Presupuestos";
            ((System.ComponentModel.ISupportInitialize)(this.btnViewDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPresupuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePresupuesto)).EndInit();
            this.panelListadoPresupuesto.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnViewDetails;
        private DevExpress.XtraGrid.GridControl gcPresupuestos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroServicioTecnico;
        private DevExpress.XtraGrid.Columns.GridColumn colClasificacionInstrumento;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn FechaCreacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnShowDetails;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditPresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn btnDetail;
        private DevExpress.XtraGrid.Columns.GridColumn btnEdit;
        private System.Windows.Forms.Panel panelListadoPresupuesto;
        private System.Windows.Forms.Panel panelFooter;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.Columns.GridColumn btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeletePresupuesto;
    }
}