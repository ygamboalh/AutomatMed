namespace AutomatMediciones.DesktopApp.Pantallas.Productos
{
    partial class frmProductos
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
            this.gcProductos = new DevExpress.XtraGrid.GridControl();
            this.gvProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigoProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubfamilia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalSeleccionados = new DevExpress.XtraEditors.LabelControl();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarProductos = new FontAwesome.Sharp.IconButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcProductos
            // 
            this.gcProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProductos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcProductos.Location = new System.Drawing.Point(255, 0);
            this.gcProductos.MainView = this.gvProductos;
            this.gcProductos.Margin = new System.Windows.Forms.Padding(4);
            this.gcProductos.Name = "gcProductos";
            this.gcProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSeleccionar});
            this.gcProductos.Size = new System.Drawing.Size(947, 656);
            this.gcProductos.TabIndex = 130;
            this.gcProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductos});
            // 
            // gvProductos
            // 
            this.gvProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoProducto,
            this.colDescripcion,
            this.colSubfamilia,
            this.colPrecio,
            this.colMoneda,
            this.colSeleccionar});
            this.gvProductos.DetailHeight = 431;
            this.gvProductos.GridControl = this.gcProductos;
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.OptionsView.ShowGroupPanel = false;
            this.gvProductos.OptionsView.ShowIndicator = false;
            // 
            // colCodigoProducto
            // 
            this.colCodigoProducto.Caption = "Código";
            this.colCodigoProducto.MinWidth = 23;
            this.colCodigoProducto.Name = "colCodigoProducto";
            this.colCodigoProducto.OptionsColumn.AllowEdit = false;
            this.colCodigoProducto.OptionsColumn.AllowFocus = false;
            this.colCodigoProducto.Width = 87;
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
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 87;
            // 
            // colSubfamilia
            // 
            this.colSubfamilia.Caption = "Sub Familia";
            this.colSubfamilia.FieldName = "SubFamilia";
            this.colSubfamilia.MinWidth = 23;
            this.colSubfamilia.Name = "colSubfamilia";
            this.colSubfamilia.OptionsColumn.AllowEdit = false;
            this.colSubfamilia.OptionsColumn.AllowFocus = false;
            this.colSubfamilia.Visible = true;
            this.colSubfamilia.VisibleIndex = 1;
            this.colSubfamilia.Width = 87;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio";
            this.colPrecio.DisplayFormat.FormatString = "F";
            this.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.MinWidth = 25;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.OptionsColumn.AllowEdit = false;
            this.colPrecio.OptionsColumn.AllowFocus = false;
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 2;
            this.colPrecio.Width = 94;
            // 
            // colMoneda
            // 
            this.colMoneda.Caption = "Moneda";
            this.colMoneda.FieldName = "Moneda.Descripcion";
            this.colMoneda.MinWidth = 25;
            this.colMoneda.Name = "colMoneda";
            this.colMoneda.OptionsColumn.AllowEdit = false;
            this.colMoneda.OptionsColumn.AllowFocus = false;
            this.colMoneda.Visible = true;
            this.colMoneda.VisibleIndex = 3;
            this.colMoneda.Width = 94;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Caption = " ";
            this.colSeleccionar.ColumnEdit = this.chkSeleccionar;
            this.colSeleccionar.FieldName = "Seleccionar";
            this.colSeleccionar.MinWidth = 25;
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Visible = true;
            this.colSeleccionar.VisibleIndex = 4;
            this.colSeleccionar.Width = 30;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoHeight = false;
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotalSeleccionados);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(255, 656);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(947, 27);
            this.panel3.TabIndex = 155;
            // 
            // lblTotalSeleccionados
            // 
            this.lblTotalSeleccionados.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalSeleccionados.Appearance.Options.UseFont = true;
            this.lblTotalSeleccionados.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalSeleccionados.Location = new System.Drawing.Point(930, 0);
            this.lblTotalSeleccionados.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lblTotalSeleccionados.Name = "lblTotalSeleccionados";
            this.lblTotalSeleccionados.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblTotalSeleccionados.Size = new System.Drawing.Size(17, 17);
            this.lblTotalSeleccionados.TabIndex = 28;
            this.lblTotalSeleccionados.Text = "0";
            this.lblTotalSeleccionados.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(251, 774);
            this.treeView1.TabIndex = 156;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gcProductos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 774);
            this.panel1.TabIndex = 157;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregarProductos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(255, 683);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(947, 91);
            this.panel2.TabIndex = 161;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregarProductos.FlatAppearance.BorderSize = 0;
            this.btnAgregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarProductos.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAgregarProductos.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProductos.IconSize = 30;
            this.btnAgregarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProductos.Location = new System.Drawing.Point(593, 10);
            this.btnAgregarProductos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(354, 81);
            this.btnAgregarProductos.TabIndex = 160;
            this.btnAgregarProductos.Text = "Agregar Productos Seleccionados";
            this.btnAgregarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(251, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 774);
            this.splitter1.TabIndex = 157;
            this.splitter1.TabStop = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 794);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductos";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colSubfamilia;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSeleccionar;
        private DevExpress.XtraEditors.LabelControl lblTotalSeleccionados;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAgregarProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colMoneda;
    }
}