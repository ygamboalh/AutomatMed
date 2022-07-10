
namespace AutomatMediciones.DesktopApp.Pantallas.Usuarios
{
    partial class frmUsuarios
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportarExcel = new FontAwesome.Sharp.IconButton();
            this.btnAgregarUsuario = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.gcUsuarios = new DevExpress.XtraGrid.GridControl();
            this.gvUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerFirmaDigital = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerFirmaDigtal = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colEditarUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditarUsuario = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.saveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerFirmaDigtal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportarExcel);
            this.panel1.Controls.Add(this.btnAgregarUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 7, 0, 7);
            this.panel1.Size = new System.Drawing.Size(1174, 53);
            this.panel1.TabIndex = 35;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportarExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportarExcel.IconColor = System.Drawing.Color.Black;
            this.btnExportarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportarExcel.IconSize = 30;
            this.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarExcel.Location = new System.Drawing.Point(963, 7);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(211, 39);
            this.btnExportarExcel.TabIndex = 166;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarUsuario.IconSize = 30;
            this.btnAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(8, 7);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(211, 39);
            this.btnAgregarUsuario.TabIndex = 16;
            this.btnAgregarUsuario.Text = "Nuevo Usuario";
            this.btnAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 524);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 27);
            this.panel2.TabIndex = 37;
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
            // gcUsuarios
            // 
            this.gcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUsuarios.Location = new System.Drawing.Point(0, 53);
            this.gcUsuarios.MainView = this.gvUsuarios;
            this.gcUsuarios.Name = "gcUsuarios";
            this.gcUsuarios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerFirmaDigtal,
            this.cmdEditarUsuario});
            this.gcUsuarios.Size = new System.Drawing.Size(1174, 471);
            this.gcUsuarios.TabIndex = 38;
            this.gcUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsuarios});
            // 
            // gvUsuarios
            // 
            this.gvUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreUsuario,
            this.colCorreo,
            this.colVerFirmaDigital,
            this.colEditarUsuario});
            this.gvUsuarios.GridControl = this.gcUsuarios;
            this.gvUsuarios.Name = "gvUsuarios";
            this.gvUsuarios.OptionsView.ShowGroupPanel = false;
            this.gvUsuarios.OptionsView.ShowIndicator = false;
            // 
            // colNombreUsuario
            // 
            this.colNombreUsuario.Caption = "Usuario";
            this.colNombreUsuario.FieldName = "Nombre";
            this.colNombreUsuario.MinWidth = 25;
            this.colNombreUsuario.Name = "colNombreUsuario";
            this.colNombreUsuario.OptionsColumn.AllowEdit = false;
            this.colNombreUsuario.OptionsColumn.AllowFocus = false;
            this.colNombreUsuario.OptionsColumn.ReadOnly = true;
            this.colNombreUsuario.Visible = true;
            this.colNombreUsuario.VisibleIndex = 0;
            this.colNombreUsuario.Width = 293;
            // 
            // colCorreo
            // 
            this.colCorreo.Caption = "Correo";
            this.colCorreo.FieldName = "Correo";
            this.colCorreo.MinWidth = 25;
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.OptionsColumn.AllowEdit = false;
            this.colCorreo.OptionsColumn.AllowFocus = false;
            this.colCorreo.OptionsColumn.ReadOnly = true;
            this.colCorreo.Visible = true;
            this.colCorreo.VisibleIndex = 1;
            this.colCorreo.Width = 293;
            // 
            // colVerFirmaDigital
            // 
            this.colVerFirmaDigital.ColumnEdit = this.cmdVerFirmaDigtal;
            this.colVerFirmaDigital.MaxWidth = 30;
            this.colVerFirmaDigital.MinWidth = 25;
            this.colVerFirmaDigital.Name = "colVerFirmaDigital";
            this.colVerFirmaDigital.Visible = true;
            this.colVerFirmaDigital.VisibleIndex = 2;
            this.colVerFirmaDigital.Width = 30;
            // 
            // cmdVerFirmaDigtal
            // 
            this.cmdVerFirmaDigtal.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdVerFirmaDigtal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Ver Firma Digital", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerFirmaDigtal.Name = "cmdVerFirmaDigtal";
            this.cmdVerFirmaDigtal.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colEditarUsuario
            // 
            this.colEditarUsuario.ColumnEdit = this.cmdEditarUsuario;
            this.colEditarUsuario.MaxWidth = 30;
            this.colEditarUsuario.MinWidth = 25;
            this.colEditarUsuario.Name = "colEditarUsuario";
            this.colEditarUsuario.Visible = true;
            this.colEditarUsuario.VisibleIndex = 3;
            this.colEditarUsuario.Width = 30;
            // 
            // cmdEditarUsuario
            // 
            this.cmdEditarUsuario.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdEditarUsuario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Editar Usuario", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditarUsuario.Name = "cmdEditarUsuario";
            this.cmdEditarUsuario.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "xtraSaveFileDialog1";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 551);
            this.Controls.Add(this.gcUsuarios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerFirmaDigtal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditarUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExportarExcel;
        private FontAwesome.Sharp.IconButton btnAgregarUsuario;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.GridControl gcUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsuarios;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colVerFirmaDigital;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerFirmaDigtal;
        private DevExpress.XtraGrid.Columns.GridColumn colEditarUsuario;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditarUsuario;
        private DevExpress.XtraEditors.XtraSaveFileDialog saveFileDialog;
    }
}