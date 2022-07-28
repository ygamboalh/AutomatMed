
namespace AutomatMediciones.DesktopApp.Pantallas.Clasificaciones
{
    partial class frmNuevaClasificacion
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
            this.btnGuardarClasificacion = new FontAwesome.Sharp.IconButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.nmPeriodoCalibracion = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevoModelo = new FontAwesome.Sharp.IconButton();
            this.btnNuevaMarca = new FontAwesome.Sharp.IconButton();
            this.btnNuevoTipoInstrumento = new FontAwesome.Sharp.IconButton();
            this.lookupMarca = new DevExpress.XtraEditors.LookUpEdit();
            this.lookupModelo = new DevExpress.XtraEditors.LookUpEdit();
            this.lookupTipoInstrumento = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPeriodoCalibracion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupTipoInstrumento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarClasificacion
            // 
            this.btnGuardarClasificacion.FlatAppearance.BorderSize = 0;
            this.btnGuardarClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarClasificacion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarClasificacion.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarClasificacion.IconColor = System.Drawing.Color.Black;
            this.btnGuardarClasificacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarClasificacion.IconSize = 30;
            this.btnGuardarClasificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarClasificacion.Location = new System.Drawing.Point(498, 426);
            this.btnGuardarClasificacion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarClasificacion.Name = "btnGuardarClasificacion";
            this.btnGuardarClasificacion.Size = new System.Drawing.Size(265, 52);
            this.btnGuardarClasificacion.TabIndex = 127;
            this.btnGuardarClasificacion.Text = "Guardar Clasificación";
            this.btnGuardarClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarClasificacion.UseVisualStyleBackColor = true;
            this.btnGuardarClasificacion.Click += new System.EventHandler(this.btnGuardarClasificacionInstrumento_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(43, 104);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(118, 17);
            this.labelControl11.TabIndex = 128;
            this.labelControl11.Text = "Tipo de Instrumento";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(43, 180);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 17);
            this.labelControl1.TabIndex = 130;
            this.labelControl1.Text = "Marca";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(43, 257);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 17);
            this.labelControl2.TabIndex = 132;
            this.labelControl2.Text = "Modelo";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(43, 335);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(134, 17);
            this.labelControl3.TabIndex = 134;
            this.labelControl3.Text = "Periodo de Calibración";
            // 
            // nmPeriodoCalibracion
            // 
            this.nmPeriodoCalibracion.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmPeriodoCalibracion.Location = new System.Drawing.Point(43, 357);
            this.nmPeriodoCalibracion.Name = "nmPeriodoCalibracion";
            this.nmPeriodoCalibracion.Size = new System.Drawing.Size(182, 25);
            this.nmPeriodoCalibracion.TabIndex = 139;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNuevoModelo);
            this.panel1.Controls.Add(this.btnNuevaMarca);
            this.panel1.Controls.Add(this.btnNuevoTipoInstrumento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 7, 0, 7);
            this.panel1.Size = new System.Drawing.Size(802, 53);
            this.panel1.TabIndex = 140;
            // 
            // btnNuevoModelo
            // 
            this.btnNuevoModelo.FlatAppearance.BorderSize = 0;
            this.btnNuevoModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoModelo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoModelo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevoModelo.IconColor = System.Drawing.Color.Black;
            this.btnNuevoModelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoModelo.IconSize = 30;
            this.btnNuevoModelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoModelo.Location = new System.Drawing.Point(586, 7);
            this.btnNuevoModelo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNuevoModelo.Name = "btnNuevoModelo";
            this.btnNuevoModelo.Size = new System.Drawing.Size(177, 39);
            this.btnNuevoModelo.TabIndex = 18;
            this.btnNuevoModelo.Text = "Nuevo Modelo";
            this.btnNuevoModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoModelo.UseVisualStyleBackColor = true;
            this.btnNuevoModelo.Click += new System.EventHandler(this.btnNuevoModelo_Click);
            // 
            // btnNuevaMarca
            // 
            this.btnNuevaMarca.FlatAppearance.BorderSize = 0;
            this.btnNuevaMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaMarca.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevaMarca.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevaMarca.IconColor = System.Drawing.Color.Black;
            this.btnNuevaMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaMarca.IconSize = 30;
            this.btnNuevaMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaMarca.Location = new System.Drawing.Point(363, 7);
            this.btnNuevaMarca.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNuevaMarca.Name = "btnNuevaMarca";
            this.btnNuevaMarca.Size = new System.Drawing.Size(170, 39);
            this.btnNuevaMarca.TabIndex = 17;
            this.btnNuevaMarca.Text = "Nueva Marca";
            this.btnNuevaMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaMarca.UseVisualStyleBackColor = true;
            this.btnNuevaMarca.Click += new System.EventHandler(this.btnNuevaMarca_Click);
            // 
            // btnNuevoTipoInstrumento
            // 
            this.btnNuevoTipoInstrumento.FlatAppearance.BorderSize = 0;
            this.btnNuevoTipoInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTipoInstrumento.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoTipoInstrumento.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevoTipoInstrumento.IconColor = System.Drawing.Color.Black;
            this.btnNuevoTipoInstrumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoTipoInstrumento.IconSize = 30;
            this.btnNuevoTipoInstrumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoTipoInstrumento.Location = new System.Drawing.Point(43, 7);
            this.btnNuevoTipoInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNuevoTipoInstrumento.Name = "btnNuevoTipoInstrumento";
            this.btnNuevoTipoInstrumento.Size = new System.Drawing.Size(271, 39);
            this.btnNuevoTipoInstrumento.TabIndex = 16;
            this.btnNuevoTipoInstrumento.Text = "Nuevo Tipo de Instrumento";
            this.btnNuevoTipoInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoTipoInstrumento.UseVisualStyleBackColor = true;
            this.btnNuevoTipoInstrumento.Click += new System.EventHandler(this.btnNuevaClasificacion_Click);
            // 
            // lookupMarca
            // 
            this.lookupMarca.Location = new System.Drawing.Point(43, 202);
            this.lookupMarca.Name = "lookupMarca";
            this.lookupMarca.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lookupMarca.Properties.Appearance.Options.UseFont = true;
            this.lookupMarca.Properties.AutoHeight = false;
            this.lookupMarca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupMarca.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MarcaId", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción")});
            this.lookupMarca.Properties.NullText = "";
            this.lookupMarca.Size = new System.Drawing.Size(720, 31);
            this.lookupMarca.TabIndex = 141;
            // 
            // lookupModelo
            // 
            this.lookupModelo.Location = new System.Drawing.Point(43, 279);
            this.lookupModelo.Name = "lookupModelo";
            this.lookupModelo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lookupModelo.Properties.Appearance.Options.UseFont = true;
            this.lookupModelo.Properties.AutoHeight = false;
            this.lookupModelo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupModelo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModeloId", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción")});
            this.lookupModelo.Properties.NullText = "";
            this.lookupModelo.Size = new System.Drawing.Size(720, 31);
            this.lookupModelo.TabIndex = 142;
            // 
            // lookupTipoInstrumento
            // 
            this.lookupTipoInstrumento.Location = new System.Drawing.Point(43, 126);
            this.lookupTipoInstrumento.Name = "lookupTipoInstrumento";
            this.lookupTipoInstrumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lookupTipoInstrumento.Properties.Appearance.Options.UseFont = true;
            this.lookupTipoInstrumento.Properties.AutoHeight = false;
            this.lookupTipoInstrumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupTipoInstrumento.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TipoInstrumentoId", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción")});
            this.lookupTipoInstrumento.Properties.NullText = "";
            this.lookupTipoInstrumento.Size = new System.Drawing.Size(720, 31);
            this.lookupTipoInstrumento.TabIndex = 143;
            // 
            // frmNuevaClasificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 507);
            this.Controls.Add(this.lookupTipoInstrumento);
            this.Controls.Add(this.lookupModelo);
            this.Controls.Add(this.lookupMarca);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nmPeriodoCalibracion);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.btnGuardarClasificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Name = "frmNuevaClasificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Clasificación";
            ((System.ComponentModel.ISupportInitialize)(this.nmPeriodoCalibracion)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookupMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupTipoInstrumento.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnGuardarClasificacion;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.NumericUpDown nmPeriodoCalibracion;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnNuevoModelo;
        private FontAwesome.Sharp.IconButton btnNuevaMarca;
        private FontAwesome.Sharp.IconButton btnNuevoTipoInstrumento;
        private DevExpress.XtraEditors.LookUpEdit lookupMarca;
        private DevExpress.XtraEditors.LookUpEdit lookupModelo;
        private DevExpress.XtraEditors.LookUpEdit lookupTipoInstrumento;
    }
}