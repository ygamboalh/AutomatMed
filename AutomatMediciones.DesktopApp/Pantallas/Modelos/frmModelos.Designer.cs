﻿
namespace AutomatMediciones.DesktopApp.Pantallas.Modelos
{
    partial class frmModelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModelos));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarNuevoModelo = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.gcModelos = new DevExpress.XtraGrid.GridControl();
            this.gvModelos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregarNuevoModelo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 7, 0, 7);
            this.panel1.Size = new System.Drawing.Size(659, 53);
            this.panel1.TabIndex = 37;
            // 
            // btnAgregarNuevoModelo
            // 
            this.btnAgregarNuevoModelo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarNuevoModelo.FlatAppearance.BorderSize = 0;
            this.btnAgregarNuevoModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoModelo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarNuevoModelo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarNuevoModelo.IconColor = System.Drawing.Color.Black;
            this.btnAgregarNuevoModelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarNuevoModelo.IconSize = 30;
            this.btnAgregarNuevoModelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNuevoModelo.Location = new System.Drawing.Point(8, 7);
            this.btnAgregarNuevoModelo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarNuevoModelo.Name = "btnAgregarNuevoModelo";
            this.btnAgregarNuevoModelo.Size = new System.Drawing.Size(211, 39);
            this.btnAgregarNuevoModelo.TabIndex = 16;
            this.btnAgregarNuevoModelo.Text = "Nuevo Modelo";
            this.btnAgregarNuevoModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNuevoModelo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoModelo.Click += new System.EventHandler(this.btnAgregarNuevoModelo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 358);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 27);
            this.panel2.TabIndex = 38;
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(7, 17);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // gcModelos
            // 
            this.gcModelos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcModelos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcModelos.Location = new System.Drawing.Point(0, 53);
            this.gcModelos.MainView = this.gvModelos;
            this.gcModelos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcModelos.Name = "gcModelos";
            this.gcModelos.Padding = new System.Windows.Forms.Padding(5);
            this.gcModelos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditar});
            this.gcModelos.Size = new System.Drawing.Size(659, 305);
            this.gcModelos.TabIndex = 39;
            this.gcModelos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvModelos});
            // 
            // gvModelos
            // 
            this.gvModelos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescripcion,
            this.colEditar});
            this.gvModelos.GridControl = this.gcModelos;
            this.gvModelos.Name = "gvModelos";
            this.gvModelos.OptionsView.ShowAutoFilterRow = true;
            this.gvModelos.OptionsView.ShowGroupPanel = false;
            this.gvModelos.OptionsView.ShowIndicator = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "ModeloId";
            this.colId.MinWidth = 24;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Width = 198;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.MinWidth = 24;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 198;
            // 
            // colEditar
            // 
            this.colEditar.ColumnEdit = this.cmdEditar;
            this.colEditar.MinWidth = 24;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 1;
            this.colEditar.Width = 40;
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 385);
            this.Controls.Add(this.gcModelos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModelos";
            this.Text = "Modelos";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAgregarNuevoModelo;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.GridControl gcModelos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvModelos;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar;
    }
}